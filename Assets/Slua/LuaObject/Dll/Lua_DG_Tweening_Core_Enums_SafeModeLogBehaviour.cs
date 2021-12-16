using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_Core_Enums_SafeModeLogBehaviour : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"DG.Tweening.Core.Enums.SafeModeLogBehaviour");
		addMember(l,0,"None");
		addMember(l,1,"Normal");
		addMember(l,2,"Warning");
		addMember(l,3,"Error");
		LuaDLL.lua_pop(l, 1);
	}
}
