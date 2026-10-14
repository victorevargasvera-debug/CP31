using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using JetBrains.Annotations;
using NLog.Common;
using NLog.Config;
using NLog.Filters;
using NLog.Internal;
using NLog.Targets;

namespace NLog
{
	// Token: 0x0200000F RID: 15
	internal static class LoggerImpl
	{
		// Token: 0x060003C7 RID: 967 RVA: 0x0000784C File Offset: 0x00005A4C
		internal static void Write([global::JetBrains.Annotations.NotNull] global::System.Type loggerType, global::NLog.Internal.TargetWithFilterChain targets, global::NLog.LogEventInfo logEvent, global::NLog.LogFactory factory)
		{
			if (targets == null)
			{
				return;
			}
			global::NLog.Config.StackTraceUsage stackTraceUsage = targets.GetStackTraceUsage();
			if (stackTraceUsage != global::NLog.Config.StackTraceUsage.None && !logEvent.HasStackTrace)
			{
				global::System.Diagnostics.StackTrace stackTrace = new global::System.Diagnostics.StackTrace(0, stackTraceUsage == global::NLog.Config.StackTraceUsage.WithSource);
				global::System.Diagnostics.StackFrame[] frames = stackTrace.GetFrames();
				int? num = global::NLog.LoggerImpl.FindCallingMethodOnStackTrace(frames, loggerType);
				int? userStackFrameLegacy = (num != null) ? new int?(global::NLog.LoggerImpl.SkipToUserStackFrameLegacy(frames, num.Value)) : null;
				logEvent.GetCallSiteInformationInternal().SetStackTrace(stackTrace, num ?? 0, userStackFrameLegacy);
			}
			global::NLog.Common.AsyncContinuation onException = delegate(global::System.Exception ex)
			{
			};
			if (factory.ThrowExceptions)
			{
				int originalThreadId = global::NLog.Common.AsyncHelpers.GetManagedThreadId();
				onException = delegate(global::System.Exception ex)
				{
					if (ex != null && global::NLog.Common.AsyncHelpers.GetManagedThreadId() == originalThreadId)
					{
						throw new global::NLog.NLogRuntimeException("Exception occurred in NLog", ex);
					}
				};
			}
			if (targets.NextInChain == null && logEvent.CanLogEventDeferMessageFormat())
			{
				logEvent.MessageFormatter = global::NLog.Internal.LogMessageTemplateFormatter.DefaultAutoSingleTarget.MessageFormatter;
			}
			global::System.Collections.Generic.IList<global::NLog.Filters.Filter> list = null;
			global::NLog.Filters.FilterResult filterResult = global::NLog.Filters.FilterResult.Neutral;
			for (global::NLog.Internal.TargetWithFilterChain targetWithFilterChain = targets; targetWithFilterChain != null; targetWithFilterChain = targetWithFilterChain.NextInChain)
			{
				global::NLog.Filters.FilterResult filterResult2 = (list == targetWithFilterChain.FilterChain) ? filterResult : global::NLog.LoggerImpl.GetFilterResult(targetWithFilterChain.FilterChain, logEvent);
				if (!global::NLog.LoggerImpl.WriteToTargetWithFilterChain(targetWithFilterChain.Target, filterResult2, logEvent, onException))
				{
					break;
				}
				filterResult = filterResult2;
				list = targetWithFilterChain.FilterChain;
			}
		}

		// Token: 0x060003C8 RID: 968 RVA: 0x00007994 File Offset: 0x00005B94
		internal static int? FindCallingMethodOnStackTrace(global::System.Diagnostics.StackFrame[] stackFrames, [global::JetBrains.Annotations.NotNull] global::System.Type loggerType)
		{
			if (stackFrames == null || stackFrames.Length == 0)
			{
				return null;
			}
			int? num = null;
			int? result = null;
			for (int i = 0; i < stackFrames.Length; i++)
			{
				global::System.Diagnostics.StackFrame frame = stackFrames[i];
				if (!global::NLog.LoggerImpl.SkipAssembly(frame))
				{
					if (result == null)
					{
						result = new int?(i);
					}
					if (global::NLog.LoggerImpl.IsLoggerType(frame, loggerType))
					{
						num = null;
					}
					else if (num == null)
					{
						num = new int?(i);
					}
				}
			}
			int? result2 = num;
			if (result2 == null)
			{
				return result;
			}
			return result2;
		}

		// Token: 0x060003C9 RID: 969 RVA: 0x00007A24 File Offset: 0x00005C24
		internal static int SkipToUserStackFrameLegacy(global::System.Diagnostics.StackFrame[] stackFrames, int firstUserStackFrame)
		{
			for (int i = firstUserStackFrame; i < stackFrames.Length; i++)
			{
				global::System.Diagnostics.StackFrame stackFrame = stackFrames[i];
				if (!global::NLog.LoggerImpl.SkipAssembly(stackFrame))
				{
					global::System.Reflection.MethodBase method = stackFrame.GetMethod();
					if (((method != null) ? method.Name : null) == "MoveNext" && stackFrames.Length > i)
					{
						global::System.Reflection.MethodBase method2 = stackFrames[i + 1].GetMethod();
						global::System.Type left = (method2 != null) ? method2.DeclaringType : null;
						if (left == typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder) || left == typeof(global::System.Runtime.CompilerServices.AsyncTaskMethodBuilder<>))
						{
							goto IL_71;
						}
					}
					return i;
				}
				IL_71:;
			}
			return firstUserStackFrame;
		}

		// Token: 0x060003CA RID: 970 RVA: 0x00007AB0 File Offset: 0x00005CB0
		private static bool SkipAssembly(global::System.Diagnostics.StackFrame frame)
		{
			global::System.Reflection.Assembly assembly = global::NLog.Internal.StackTraceUsageUtils.LookupAssemblyFromStackFrame(frame);
			return assembly == null || global::NLog.LogManager.IsHiddenAssembly(assembly);
		}

		// Token: 0x060003CB RID: 971 RVA: 0x00007AD8 File Offset: 0x00005CD8
		private static bool IsLoggerType(global::System.Diagnostics.StackFrame frame, global::System.Type loggerType)
		{
			global::System.Reflection.MethodBase method = frame.GetMethod();
			global::System.Type type = (method != null) ? method.DeclaringType : null;
			return type != null && (loggerType == type || type.IsSubclassOf(loggerType) || loggerType.IsAssignableFrom(type));
		}

		// Token: 0x060003CC RID: 972 RVA: 0x00007B20 File Offset: 0x00005D20
		private static bool WriteToTargetWithFilterChain(global::NLog.Targets.Target target, global::NLog.Filters.FilterResult result, global::NLog.LogEventInfo logEvent, global::NLog.Common.AsyncContinuation onException)
		{
			if (result == global::NLog.Filters.FilterResult.Ignore || result == global::NLog.Filters.FilterResult.IgnoreFinal)
			{
				if (global::NLog.Common.InternalLogger.IsDebugEnabled)
				{
					global::NLog.Common.InternalLogger.Debug<string, global::NLog.LogLevel>("{0}.{1} Rejecting message because of a filter.", logEvent.LoggerName, logEvent.Level);
				}
				return result != global::NLog.Filters.FilterResult.IgnoreFinal;
			}
			target.WriteAsyncLogEvent(logEvent.WithContinuation(onException));
			return result != global::NLog.Filters.FilterResult.LogFinal;
		}

		// Token: 0x060003CD RID: 973 RVA: 0x00007B70 File Offset: 0x00005D70
		private static global::NLog.Filters.FilterResult GetFilterResult(global::System.Collections.Generic.IList<global::NLog.Filters.Filter> filterChain, global::NLog.LogEventInfo logEvent)
		{
			global::NLog.Filters.FilterResult filterResult = global::NLog.Filters.FilterResult.Neutral;
			if (filterChain == null || filterChain.Count == 0)
			{
				return filterResult;
			}
			global::NLog.Filters.FilterResult result;
			try
			{
				for (int i = 0; i < filterChain.Count; i++)
				{
					filterResult = filterChain[i].GetFilterResult(logEvent);
					if (filterResult != global::NLog.Filters.FilterResult.Neutral)
					{
						break;
					}
				}
				result = filterResult;
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Exception during filter evaluation. Message will be ignore.");
				if (ex.MustBeRethrown())
				{
					throw;
				}
				result = global::NLog.Filters.FilterResult.Ignore;
			}
			return result;
		}

		// Token: 0x04000031 RID: 49
		private const int StackTraceSkipMethods = 0;
	}
}
