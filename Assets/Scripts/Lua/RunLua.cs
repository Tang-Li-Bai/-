using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using SLua;
using DG.Tweening;

[CustomLuaClass]
public class RunLua : MonoBehaviour {
    
    public string luaName;
    LuaSvr luaSvr;
    LuaTable self;

    private LuaFunction _luaStart = null;
    private LuaFunction _luaUpdate = null;
    private LuaFunction _luaLateUpdate = null;
    private LuaFunction _luaFixedUpdate = null;
    private LuaFunction _luaAwake = null;
    private LuaFunction _luaOnDisable = null;
    private LuaFunction _luaOnDestroy = null;
    
    private void Start()
    {
        luaSvr = LuaManager.Instance.Init();
        self = (LuaTable)luaSvr.start(luaName);
        _luaAwake = LuaSvr.mainState.getFunction("Awake");
        _luaStart = LuaSvr.mainState.getFunction("Start");
        _luaFixedUpdate = LuaSvr.mainState.getFunction("FixedUpdate");
        _luaUpdate = LuaSvr.mainState.getFunction("Update");
        _luaLateUpdate = LuaSvr.mainState.getFunction("LateUpdate");
        _luaOnDisable = LuaSvr.mainState.getFunction("OnDisable");
        _luaOnDestroy = LuaSvr.mainState.getFunction("OnDestroy");
        if(_luaStart != null)
        {
            _luaStart.call();
        }
    }

    private void Update()
    {
       if(_luaUpdate != null)
        {
            _luaUpdate.call();
        }
    }

}