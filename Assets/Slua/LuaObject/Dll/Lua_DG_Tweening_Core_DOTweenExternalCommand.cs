using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_Core_DOTweenExternalCommand : LuaObject {
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"DG.Tweening.Core.DOTweenExternalCommand");
		createTypeMetatable(l,null, typeof(DG.Tweening.Core.DOTweenExternalCommand));
	}
}
