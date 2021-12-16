using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_Core_Enums_NestedTweenFailureBehaviour : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"DG.Tweening.Core.Enums.NestedTweenFailureBehaviour");
		addMember(l,0,"TryToPreserveSequence");
		addMember(l,1,"KillWholeSequence");
		LuaDLL.lua_pop(l, 1);
	}
}
