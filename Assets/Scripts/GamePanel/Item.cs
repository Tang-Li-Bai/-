using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using UnityEngine.EventSystems;
using UnityEngine.UI;
using SLua;

[CustomLuaClass]
public class Item : MonoBehaviour,IPointerEnterHandler ,IPointerExitHandler,IPointerClickHandler
{
    private bool isSelect;

    public bool isCheck = false;
    public int row;
    public int col;

    public bool IsSelect
    {
        get
        {
            return isSelect;
        }

        set
        {
            isSelect = value;
            if (value)
            {
                transform.DOScale(Vector3.one * 1.2f, 0.15f);
                GameManager.Instance.AddItem(this);
            }
            else
            {
                transform.DOScale(Vector3.one, 0.15f);
            }
        }
    }

    public bool IsCheck
    {
        get
        {
            return isCheck;
        }

        set
        {
            isCheck = value;
            if (!isCheck)
            {
                List<Item> result = new List<Item>();
                GameManager.Instance.Dfs(GameManager.Instance.items, row, col, GetComponent<Image>().color,ref result);
                if (result.Count >= 3)
                {
                    for (int k = 0; k < result.Count; k++)
                    {
                        GameManager.Instance.ClearItem(result[k]);
                    }
                }


                for (int i = 0; i < GameManager.Instance.items.GetLength(0); i++)
                {
                    for (int j = 0; j < GameManager.Instance.items.GetLength(1); j++)
                    {
                        GameManager.Instance.items[i, j].isCheck = false;
                    }
                }
            }
        }
    }

    public void OnPointerClick(PointerEventData eventData)
    {
        if (!IsSelect && GameManager.Instance.SecondItem == null)
        {
            IsSelect = true;
        }
    }

    public void OnPointerEnter(PointerEventData eventData)
    {
        if (!IsSelect)
            transform.DOScale(Vector3.one * 1.2f, 0.15f);
    }

    public void OnPointerExit(PointerEventData eventData)
    {
        if (!IsSelect)
            transform.DOScale(Vector3.one, 0.15f);
    }
    
}
