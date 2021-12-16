using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;

[CustomLuaClass]
public class UnityFunction {
    public ABManager ABManager = ABManager.Instance;
    
    public GameObject gameObject;
    public GameObject UnityGameObject(string path)
    {
        return GameObject.Find(path);
    }
}
