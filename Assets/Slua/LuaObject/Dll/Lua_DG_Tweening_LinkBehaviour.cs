using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_LinkBehaviour : LuaObject {
	static public void reg(IntPtr l) {
		getEnumTable(l,"DG.Tweening.LinkBehaviour");
		addMember(l,0,"PauseOnDisable");
		addMember(l,1,"PauseOnDisablePlayOnEnable");
		addMember(l,2,"PauseOnDisableRestartOnEnable");
		addMember(l,3,"PlayOnEnable");
		addMember(l,4,"RestartOnEnable");
		addMember(l,5,"KillOnDisable");
		addMember(l,6,"KillOnDestroy");
		addMember(l,7,"CompleteOnDisable");
		addMember(l,8,"CompleteAndKillOnDisable");
		addMember(l,9,"RewindOnDisable");
		addMember(l,10,"RewindAndKillOnDisable");
		LuaDLL.lua_pop(l, 1);
	}
}
