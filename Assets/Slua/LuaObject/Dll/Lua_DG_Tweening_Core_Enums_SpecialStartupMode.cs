using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_Core_Enums_SpecialStartupMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"DG.Tweening.Core.Enums.SpecialStartupMode");
		addMember(l,0,"None");
		addMember(l,1,"SetLookAt");
		addMember(l,2,"SetShake");
		addMember(l,3,"SetPunch");
		addMember(l,4,"SetCameraShakePosition");
		LuaDLL.lua_pop(l, 1);
	}
}
