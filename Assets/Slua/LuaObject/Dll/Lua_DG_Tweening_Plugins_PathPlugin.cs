using System;
using SLua;
using System.Collections.Generic;
[UnityEngine.Scripting.Preserve]
public class Lua_DG_Tweening_Plugins_PathPlugin : LuaObject {
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
			DG.Tweening.Plugins.PathPlugin o;
			o=new DG.Tweening.Plugins.PathPlugin();
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
	static public int Reset(IntPtr l) {
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
			DG.Tweening.Plugins.PathPlugin self=(DG.Tweening.Plugins.PathPlugin)checkSelf(l);
			DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> a1;
			checkType(l,2,out a1);
			self.Reset(a1);
			pushValue(l,true);
			return 1;
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
	static public int SetFrom(IntPtr l) {
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
			if(argc==3){
				DG.Tweening.Plugins.PathPlugin self=(DG.Tweening.Plugins.PathPlugin)checkSelf(l);
				DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> a1;
				checkType(l,2,out a1);
				System.Boolean a2;
				checkType(l,3,out a2);
				self.SetFrom(a1,a2);
				pushValue(l,true);
				return 1;
			}
			else if(argc==5){
				DG.Tweening.Plugins.PathPlugin self=(DG.Tweening.Plugins.PathPlugin)checkSelf(l);
				DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> a1;
				checkType(l,2,out a1);
				DG.Tweening.Plugins.Core.PathCore.Path a2;
				checkType(l,3,out a2);
				System.Boolean a3;
				checkType(l,4,out a3);
				System.Boolean a4;
				checkType(l,5,out a4);
				self.SetFrom(a1,a2,a3,a4);
				pushValue(l,true);
				return 1;
			}
			pushValue(l,false);
			LuaDLL.lua_pushstring(l,"No matched override function SetFrom to call");
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
	static public int ConvertToStartValue(IntPtr l) {
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
			DG.Tweening.Plugins.PathPlugin self=(DG.Tweening.Plugins.PathPlugin)checkSelf(l);
			DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> a1;
			checkType(l,2,out a1);
			UnityEngine.Vector3 a2;
			checkType(l,3,out a2);
			var ret=self.ConvertToStartValue(a1,a2);
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int SetRelativeEndValue(IntPtr l) {
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
			DG.Tweening.Plugins.PathPlugin self=(DG.Tweening.Plugins.PathPlugin)checkSelf(l);
			DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> a1;
			checkType(l,2,out a1);
			self.SetRelativeEndValue(a1);
			pushValue(l,true);
			return 1;
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
	static public int SetChangeValue(IntPtr l) {
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
			DG.Tweening.Plugins.PathPlugin self=(DG.Tweening.Plugins.PathPlugin)checkSelf(l);
			DG.Tweening.Core.TweenerCore<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions> a1;
			checkType(l,2,out a1);
			self.SetChangeValue(a1);
			pushValue(l,true);
			return 1;
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
	static public int GetSpeedBasedDuration(IntPtr l) {
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
			DG.Tweening.Plugins.PathPlugin self=(DG.Tweening.Plugins.PathPlugin)checkSelf(l);
			DG.Tweening.Plugins.Options.PathOptions a1;
			checkValueType(l,2,out a1);
			System.Single a2;
			checkType(l,3,out a2);
			DG.Tweening.Plugins.Core.PathCore.Path a3;
			checkType(l,4,out a3);
			var ret=self.GetSpeedBasedDuration(a1,a2,a3);
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int EvaluateAndApply(IntPtr l) {
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
			DG.Tweening.Plugins.PathPlugin self=(DG.Tweening.Plugins.PathPlugin)checkSelf(l);
			DG.Tweening.Plugins.Options.PathOptions a1;
			checkValueType(l,2,out a1);
			DG.Tweening.Tween a2;
			checkType(l,3,out a2);
			System.Boolean a3;
			checkType(l,4,out a3);
			DG.Tweening.Core.DOGetter<UnityEngine.Vector3> a4;
			checkDelegate(l,5,out a4);
			DG.Tweening.Core.DOSetter<UnityEngine.Vector3> a5;
			checkDelegate(l,6,out a5);
			System.Single a6;
			checkType(l,7,out a6);
			DG.Tweening.Plugins.Core.PathCore.Path a7;
			checkType(l,8,out a7);
			DG.Tweening.Plugins.Core.PathCore.Path a8;
			checkType(l,9,out a8);
			System.Single a9;
			checkType(l,10,out a9);
			System.Boolean a10;
			checkType(l,11,out a10);
			DG.Tweening.Core.Enums.UpdateNotice a11;
			a11 = (DG.Tweening.Core.Enums.UpdateNotice)LuaDLL.luaL_checkinteger(l, 12);
			self.EvaluateAndApply(a1,a2,a3,a4,a5,a6,a7,a8,a9,a10,a11);
			pushValue(l,true);
			return 1;
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
	static public int SetOrientation(IntPtr l) {
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
			DG.Tweening.Plugins.PathPlugin self=(DG.Tweening.Plugins.PathPlugin)checkSelf(l);
			DG.Tweening.Plugins.Options.PathOptions a1;
			checkValueType(l,2,out a1);
			DG.Tweening.Tween a2;
			checkType(l,3,out a2);
			DG.Tweening.Plugins.Core.PathCore.Path a3;
			checkType(l,4,out a3);
			System.Single a4;
			checkType(l,5,out a4);
			UnityEngine.Vector3 a5;
			checkType(l,6,out a5);
			DG.Tweening.Core.Enums.UpdateNotice a6;
			a6 = (DG.Tweening.Core.Enums.UpdateNotice)LuaDLL.luaL_checkinteger(l, 7);
			self.SetOrientation(a1,a2,a3,a4,a5,a6);
			pushValue(l,true);
			return 1;
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
	static public int Get_s(IntPtr l) {
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
			var ret=DG.Tweening.Plugins.PathPlugin.Get();
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
	[SLua.MonoPInvokeCallbackAttribute(typeof(LuaCSFunction))]
	[UnityEngine.Scripting.Preserve]
	static public int get_MinLookAhead(IntPtr l) {
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
			pushValue(l,true);
			pushValue(l,DG.Tweening.Plugins.PathPlugin.MinLookAhead);
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
		getTypeTable(l,"DG.Tweening.Plugins.PathPlugin");
		addMember(l,Reset);
		addMember(l,SetFrom);
		addMember(l,ConvertToStartValue);
		addMember(l,SetRelativeEndValue);
		addMember(l,SetChangeValue);
		addMember(l,GetSpeedBasedDuration);
		addMember(l,EvaluateAndApply);
		addMember(l,SetOrientation);
		addMember(l,Get_s);
		addMember(l,"MinLookAhead",get_MinLookAhead,null,false);
		createTypeMetatable(l,constructor, typeof(DG.Tweening.Plugins.PathPlugin),typeof(DG.Tweening.Plugins.Core.ABSTweenPlugin<UnityEngine.Vector3,DG.Tweening.Plugins.Core.PathCore.Path,DG.Tweening.Plugins.Options.PathOptions>));
	}
}
