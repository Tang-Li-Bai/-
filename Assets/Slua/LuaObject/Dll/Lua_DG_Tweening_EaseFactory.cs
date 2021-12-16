using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_EaseFactory : LuaObject {
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int constructor(IntPtr l) {
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
			DG.Tweening.EaseFactory o;
			o=new DG.Tweening.EaseFactory();
			pushValue(l,true);
			pushValue(l,o);
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int StopMotion_s(IntPtr l) {
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
			int argc = LuaDLL.lua_gettop(l);
			if(matchType(l,argc,1,typeof(int),typeof(DG.Tweening.EaseFunction))){
				System.Int32 a1;
				checkType(l,1,out a1);
				DG.Tweening.EaseFunction a2;
				checkDelegate(l,2,out a2);
				var ret=DG.Tweening.EaseFactory.StopMotion(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(UnityEngine.AnimationCurve))){
				System.Int32 a1;
				checkType(l,1,out a1);
				UnityEngine.AnimationCurve a2;
				checkType(l,2,out a2);
				var ret=DG.Tweening.EaseFactory.StopMotion(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			else if(matchType(l,argc,1,typeof(int),typeof(System.Nullable<DG.Tweening.Ease>))){
				System.Int32 a1;
				checkType(l,1,out a1);
				System.Nullable<DG.Tweening.Ease> a2;
				checkNullable(l,2,out a2);
				var ret=DG.Tweening.EaseFactory.StopMotion(a1,a2);
				pushValue(l,true);
				pushValue(l,ret);
				return 2;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function StopMotion to call");
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
		getTypeTable(l,"DG.Tweening.EaseFactory");
		addMember(l,StopMotion_s);
		createTypeMetatable(l,constructor, typeof(DG.Tweening.EaseFactory));
	}
}
