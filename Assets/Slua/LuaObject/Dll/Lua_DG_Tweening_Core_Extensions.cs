using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_Core_Extensions : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetSpecialStartupMode_s(IntPtr l) {
		try {
			#if DEBUG
			var method = System.Reflection.MethodBase.GetCurrentMethod();
			string methodName = GetMethodName(method);
			#if UNITY_5_5_OR_NEWER
			UnityEngine.Profiling.Profiler.BeginSample(methodName);
			#else
			Profiler.BeginSample(methodName);
			#endif
			#endif
			DG.Tweening.Tween a1;
			checkType(l,1,out a1);
			DG.Tweening.Core.Enums.SpecialStartupMode a2;
			a2 = (DG.Tweening.Core.Enums.SpecialStartupMode)LuaDLL.luaL_checkinteger(l, 2);
			var ret=DG.Tweening.Core.Extensions.SetSpecialStartupMode<DG.Tweening.Tween>(a1,a2);
			pushValue(l,true);
			pushValue(l,ret);
			return 2;
		}
		catch(Exception e) {
			return error(l,e);
		}
		#if DEBUG
		finally {
			#if UNITY_5_5_OR_NEWER
			UnityEngine.Profiling.Profiler.EndSample();
			#else
			Profiler.EndSample();
			#endif
		}
		#endif
	}
	[UnityEngine.Scripting.Preserve]
	static public void reg(IntPtr l) {
		getTypeTable(l,"DG.Tweening.Core.Extensions");
		addMember(l,SetSpecialStartupMode_s);
		createTypeMetatable(l,null, typeof(DG.Tweening.Core.Extensions));
	}
}
