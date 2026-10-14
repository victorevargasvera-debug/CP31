using System;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using NLog.Config;

namespace NLog.Internal
{
	// Token: 0x02000125 RID: 293
	internal static class StackTraceUsageUtils
	{
		// Token: 0x06000DA1 RID: 3489 RVA: 0x000224AC File Offset: 0x000206AC
		internal static global::NLog.Config.StackTraceUsage Max(global::NLog.Config.StackTraceUsage u1, global::NLog.Config.StackTraceUsage u2)
		{
			return (global::NLog.Config.StackTraceUsage)global::System.Math.Max((int)u1, (int)u2);
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000224B5 File Offset: 0x000206B5
		public static int GetFrameCount(this global::System.Diagnostics.StackTrace strackTrace)
		{
			return strackTrace.FrameCount;
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x000224C0 File Offset: 0x000206C0
		public static string GetStackFrameMethodName(global::System.Reflection.MethodBase method, bool includeMethodInfo, bool cleanAsyncMoveNext, bool cleanAnonymousDelegates)
		{
			if (method == null)
			{
				return null;
			}
			string text = method.Name;
			global::System.Type declaringType = method.DeclaringType;
			if (cleanAsyncMoveNext && text == "MoveNext" && ((declaringType != null) ? declaringType.DeclaringType : null) != null && declaringType.Name.StartsWith("<"))
			{
				int num = declaringType.Name.IndexOf('>', 1);
				if (num > 1)
				{
					text = declaringType.Name.Substring(1, num - 1);
				}
			}
			if (cleanAnonymousDelegates && text.StartsWith("<") && text.Contains("__") && text.Contains(">"))
			{
				int num2 = text.IndexOf('<') + 1;
				int num3 = text.IndexOf('>');
				text = text.Substring(num2, num3 - num2);
			}
			if (includeMethodInfo && text == method.Name)
			{
				text = method.ToString();
			}
			return text;
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x000225A4 File Offset: 0x000207A4
		public static string GetStackFrameMethodClassName(global::System.Reflection.MethodBase method, bool includeNameSpace, bool cleanAsyncMoveNext, bool cleanAnonymousDelegates)
		{
			if (method == null)
			{
				return null;
			}
			global::System.Type declaringType = method.DeclaringType;
			if (cleanAsyncMoveNext && method.Name == "MoveNext" && ((declaringType != null) ? declaringType.DeclaringType : null) != null && declaringType.Name.StartsWith("<") && declaringType.Name.IndexOf('>', 1) > 1)
			{
				declaringType = declaringType.DeclaringType;
			}
			if (!includeNameSpace && ((declaringType != null) ? declaringType.DeclaringType : null) != null && declaringType.IsNested && declaringType.GetCustomAttribute<global::System.Runtime.CompilerServices.CompilerGeneratedAttribute>() != null)
			{
				return declaringType.DeclaringType.Name;
			}
			string text = includeNameSpace ? ((declaringType != null) ? declaringType.FullName : null) : ((declaringType != null) ? declaringType.Name : null);
			if (cleanAnonymousDelegates && text != null)
			{
				int num = text.IndexOf("+<>", global::System.StringComparison.Ordinal);
				if (num >= 0)
				{
					text = text.Substring(0, num);
				}
			}
			return text;
		}

		// Token: 0x06000DA5 RID: 3493 RVA: 0x00022688 File Offset: 0x00020888
		[global::System.Runtime.CompilerServices.MethodImpl(global::System.Runtime.CompilerServices.MethodImplOptions.NoInlining)]
		public static string GetClassFullName()
		{
			int skipFrames = 2;
			string empty = string.Empty;
			return global::NLog.Internal.StackTraceUsageUtils.GetClassFullName(new global::System.Diagnostics.StackFrame(skipFrames, false));
		}

		// Token: 0x06000DA6 RID: 3494 RVA: 0x0002269C File Offset: 0x0002089C
		public static string GetClassFullName(global::System.Diagnostics.StackFrame stackFrame)
		{
			string text = global::NLog.Internal.StackTraceUsageUtils.LookupClassNameFromStackFrame(stackFrame);
			if (string.IsNullOrEmpty(text))
			{
				text = global::NLog.Internal.StackTraceUsageUtils.GetClassFullName(new global::System.Diagnostics.StackTrace(false));
			}
			return text;
		}

		// Token: 0x06000DA7 RID: 3495 RVA: 0x000226C8 File Offset: 0x000208C8
		private static string GetClassFullName(global::System.Diagnostics.StackTrace stackTrace)
		{
			global::System.Diagnostics.StackFrame[] frames = stackTrace.GetFrames();
			for (int i = 0; i < frames.Length; i++)
			{
				string text = global::NLog.Internal.StackTraceUsageUtils.LookupClassNameFromStackFrame(frames[i]);
				if (!string.IsNullOrEmpty(text))
				{
					return text;
				}
			}
			return string.Empty;
		}

		// Token: 0x06000DA8 RID: 3496 RVA: 0x00022704 File Offset: 0x00020904
		public static global::System.Reflection.Assembly LookupAssemblyFromStackFrame(global::System.Diagnostics.StackFrame stackFrame)
		{
			global::System.Reflection.MethodBase method = stackFrame.GetMethod();
			if (method == null)
			{
				return null;
			}
			global::System.Type declaringType = method.DeclaringType;
			global::System.Reflection.Assembly assembly;
			if ((assembly = ((declaringType != null) ? declaringType.GetAssembly() : null)) == null)
			{
				global::System.Reflection.Module module = method.Module;
				assembly = ((module != null) ? module.Assembly : null);
			}
			global::System.Reflection.Assembly assembly2 = assembly;
			if (assembly2 == global::NLog.Internal.StackTraceUsageUtils.nlogAssembly)
			{
				return null;
			}
			if (assembly2 == global::NLog.Internal.StackTraceUsageUtils.mscorlibAssembly)
			{
				return null;
			}
			if (assembly2 == global::NLog.Internal.StackTraceUsageUtils.systemAssembly)
			{
				return null;
			}
			return assembly2;
		}

		// Token: 0x06000DA9 RID: 3497 RVA: 0x0002277C File Offset: 0x0002097C
		public static string LookupClassNameFromStackFrame(global::System.Diagnostics.StackFrame stackFrame)
		{
			global::System.Reflection.MethodBase method = stackFrame.GetMethod();
			if (method != null && global::NLog.Internal.StackTraceUsageUtils.LookupAssemblyFromStackFrame(stackFrame) != null)
			{
				string text = global::NLog.Internal.StackTraceUsageUtils.GetStackFrameMethodClassName(method, true, true, true) ?? method.Name;
				if (!string.IsNullOrEmpty(text) && !text.StartsWith("System.", global::System.StringComparison.Ordinal))
				{
					return text;
				}
			}
			return string.Empty;
		}

		// Token: 0x040003C1 RID: 961
		private static readonly global::System.Reflection.Assembly nlogAssembly = typeof(global::NLog.Internal.StackTraceUsageUtils).GetAssembly();

		// Token: 0x040003C2 RID: 962
		private static readonly global::System.Reflection.Assembly mscorlibAssembly = typeof(string).GetAssembly();

		// Token: 0x040003C3 RID: 963
		private static readonly global::System.Reflection.Assembly systemAssembly = typeof(global::System.Diagnostics.Debug).GetAssembly();
	}
}
