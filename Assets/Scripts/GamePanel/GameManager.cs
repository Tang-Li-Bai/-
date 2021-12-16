using DG.Tweening;
using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using SLua;

public class GameManager : BaseManager<GameManager> {
    public Item[,] items;
    public Color[] colors;

    public Item firstItem;
    public Item secondItem;

    public Item FirstItem
    {
        get
        {
            return firstItem;
        }

        set
        {
            firstItem = value;
        }
    }

    public Item SecondItem
    {
        get
        {
            return secondItem;
        }

        set
        {
            secondItem = value;
            //开始交换firstItem和secondItem
            if(value != null)
                ExChange(firstItem, secondItem);
        }
    }

    private void Start()
    {
        items = new Item[transform.childCount, transform.GetChild(0).childCount];
        for (int i = 0; i < transform.childCount; i++)
        {
            for (int j = 0; j < transform.GetChild(i).childCount; j++)
            {
                items[i, j] = transform.GetChild(i).GetChild(j).GetComponent<Item>();
                items[i, j].col = j;
                items[i, j].row = i;
            }
        }
        Init();
    }

    /// <summary>
    /// 初始化每一个item的信息
    /// </summary>
    private void Init()
    {
        for (int i = 0; i < items.GetLength(0); i++)
        {
            for (int j = 0; j < items.GetLength(1); j++)
            {
                items[i,j].GetComponent<Image>().color = colors[UnityEngine.Random.Range(0, 5)];
                items[i, j].GetComponent<Image>().DOFade(1, 1.5f).OnComplete(()=> {
                    CheckItem();
                });
            }
        }

    }

    public void AddItem(Item item)
    {
        if(FirstItem == null)
        {
            FirstItem = item;
        }else if(SecondItem == null)
        {
            SecondItem = item;
        }
    }

    [MonoPInvokeCallback(typeof(LuaCSFunction))]
    private void ChangePos(Item firstItem, Item secondItem,Action callBack)
    {
        Vector3 firstPos = firstItem.transform.localPosition;
        Vector3 secondPos = secondItem.transform.localPosition;

        firstItem.transform.DOLocalMove(secondPos, 0.15f);
        secondItem.transform.DOLocalMove(firstPos, 0.15f).OnComplete(()=> { callBack(); });

        //交换数值


        int tempRow = firstItem.row;
        int tempCol = firstItem.col;

        items[firstItem.row, firstItem.col] = secondItem;
        items[secondItem.row, secondItem.col] = firstItem;

        firstItem.row = secondItem.row;
        secondItem.row = tempRow;

        firstItem.col = secondItem.col;
        secondItem.col = tempCol;

        Transform temp = firstItem.transform.parent;
        firstItem.transform.parent = secondItem.transform.parent;
        secondItem.transform.parent = temp;
    }

    private void ExChange(Item firstItem,Item secondItem)
    {
        //如果不是相邻的两个item就不能交换
        if(Mathf.Abs(Mathf.Sqrt((firstItem.row - secondItem.row)*(firstItem.row - secondItem.row) +  (firstItem.col - secondItem.col)*(firstItem.col - secondItem.col))) == 1)
        {
            ChangePos(firstItem, secondItem,()=> {
                firstItem.IsSelect = false;
                secondItem.IsSelect = false;

                FirstItem.IsCheck = false;
                SecondItem.IsCheck = false;

                List<Item> result = new List<Item>();
                List<Item> result1 = new List<Item>();
                Dfs(items, FirstItem.row, FirstItem.col, FirstItem.GetComponent<Image>().color, ref result);
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    for (int j = 0; j < items.GetLength(1); j++)
                    {
                        items[i, j].isCheck = false;
                    }
                }
                Dfs(items, SecondItem.row, SecondItem.col, SecondItem.GetComponent<Image>().color, ref result1);
                for (int i = 0; i < items.GetLength(0); i++)
                {
                    for (int j = 0; j < items.GetLength(1); j++)
                    {
                        items[i, j].isCheck = false;
                    }
                }
                if (result.Count < 3 && result1.Count < 3)
                {
                    ChangePos(firstItem, secondItem, null);
                    Debug.Log("回复原状");
                }
                FirstItem = null;
                SecondItem = null;
            });
        }
        
    }

    public void CheckItem()
    {
        List<Item> result = new List<Item>();
        for (int i = 0; i < items.GetLength(0); i++)
        {
            for (int j = 0; j < items.GetLength(1); j++)
            {
                if (!items[i, j].IsCheck)
                {
                    Dfs(items, i, j,items[i,j].GetComponent<Image>().color,ref result);
                }
                if (result.Count >= 3)
                {
                    for (int k = 0; k < result.Count; k++)
                    {
                        ClearItem(result[k]);
                    }
                }
                result.Clear();
            }
        }
        for (int i = 0; i < items.GetLength(0); i++)
        {
            for (int j = 0; j <items.GetLength(1); j++)
            {
                items[i, j].isCheck = false;
            }
        }
    }

    public void Dfs(Item[,] items,int x,int y,Color color,ref List<Item> result)
    {
        if (items[x, y].IsCheck) return;
        items[x, y].IsCheck = true;
        result.Add(items[x, y]);
        if (x > 0 && items[x - 1,y].GetComponent<Image>().color == color) Dfs(items, x - 1, y,color,ref result);
        if (y > 0 && items[x,y-1].GetComponent<Image>().color == color) Dfs(items, x, y - 1,color, ref result);
        if (x < items.GetLength(0) - 1 && items[x + 1,y].GetComponent<Image>().color == color) Dfs(items, x + 1, y,color, ref result);
        if (y < items.GetLength(1) - 1 && items[x,y+1].GetComponent<Image>().color == color) Dfs(items, x, y + 1,color, ref result);
    }

    public void ClearItem(Item item)
    {
        item.GetComponent<Image>().DOFade(0, 1f).OnComplete(() => {
            item.GetComponent<Image>().color = colors[UnityEngine.Random.Range(0, 5)];
            item.GetComponent<Image>().DOFade(1, 1f).OnComplete(()=> {
                item.IsCheck = false;
            }); 
        });
    }
}
