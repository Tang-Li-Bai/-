using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_Core_DOTweenUtils : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int GetPointOnCircle_s(IntPtr l) {
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
			UnityEngine.Vector2 a1;
			checkType(l,1,out a1);
			System.Single a2;
			checkType(l,2,out a2);
			System.Single a3;
			checkType(l,3,out a3);
			var ret=DG.Tweening.Core.DOTweenUtils.GetPointOnCircle(a1,a2,a3);
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
		getTypeTable(l,"DG.Tweening.Core.DOTweenUtils");
		addMember(l,GetPointOnCircle_s);
		createTypeMetatable(l,null, typeof(DG.Tweening.Core.DOTweenUtils));
	}
}
