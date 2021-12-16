using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_Core_Enums_RewindCallbackMode : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"DG.Tweening.Core.Enums.RewindCallbackMode");
		addMember(l,0,"FireIfPositionChanged");
		addMember(l,1,"FireAlwaysWithRewind");
		addMember(l,2,"FireAlways");
		LuaDLL.lua_pop(l, 1);
	}
}
