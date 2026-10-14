using System;
using System.Diagnostics;
using System.Reflection;

namespace NLog.Internal
{
	// Token: 0x020000FA RID: 250
	internal class CallSiteInformation
	{
		// Token: 0x06000C97 RID: 3223 RVA: 0x0001EFD0 File Offset: 0x0001D1D0
		public void SetStackTrace(global::System.Diagnostics.StackTrace stackTrace, int userStackFrame, int? userStackFrameLegacy)
		{
			this.StackTrace = stackTrace;
			this.UserStackFrameNumber = userStackFrame;
			this.UserStackFrameNumberLegacy = ((userStackFrameLegacy != userStackFrame) ? userStackFrameLegacy : null);
		}

		// Token: 0x06000C98 RID: 3224 RVA: 0x0001F01A File Offset: 0x0001D21A
		public void SetCallerInfo(string callerClassName, string callerMemberName, string callerFilePath, int callerLineNumber)
		{
			this.CallerClassName = callerClassName;
			this.CallerMemberName = callerMemberName;
			this.CallerFilePath = callerFilePath;
			this.CallerLineNumber = new int?(callerLineNumber);
		}

		// Token: 0x17000260 RID: 608
		// (get) Token: 0x06000C99 RID: 3225 RVA: 0x0001F040 File Offset: 0x0001D240
		public global::System.Diagnostics.StackFrame UserStackFrame
		{
			get
			{
				global::System.Diagnostics.StackTrace stackTrace = this.StackTrace;
				if (stackTrace == null)
				{
					return null;
				}
				return stackTrace.GetFrame(this.UserStackFrameNumberLegacy ?? this.UserStackFrameNumber);
			}
		}

		// Token: 0x17000261 RID: 609
		// (get) Token: 0x06000C9A RID: 3226 RVA: 0x0001F07D File Offset: 0x0001D27D
		// (set) Token: 0x06000C9B RID: 3227 RVA: 0x0001F085 File Offset: 0x0001D285
		public int UserStackFrameNumber { get; private set; }

		// Token: 0x17000262 RID: 610
		// (get) Token: 0x06000C9C RID: 3228 RVA: 0x0001F08E File Offset: 0x0001D28E
		// (set) Token: 0x06000C9D RID: 3229 RVA: 0x0001F096 File Offset: 0x0001D296
		public int? UserStackFrameNumberLegacy { get; private set; }

		// Token: 0x17000263 RID: 611
		// (get) Token: 0x06000C9E RID: 3230 RVA: 0x0001F09F File Offset: 0x0001D29F
		// (set) Token: 0x06000C9F RID: 3231 RVA: 0x0001F0A7 File Offset: 0x0001D2A7
		public global::System.Diagnostics.StackTrace StackTrace { get; private set; }

		// Token: 0x06000CA0 RID: 3232 RVA: 0x0001F0B0 File Offset: 0x0001D2B0
		public global::System.Reflection.MethodBase GetCallerStackFrameMethod(int skipFrames)
		{
			global::System.Diagnostics.StackTrace stackTrace = this.StackTrace;
			global::System.Diagnostics.StackFrame stackFrame = (stackTrace != null) ? stackTrace.GetFrame(this.UserStackFrameNumber + skipFrames) : null;
			if (stackFrame == null)
			{
				return null;
			}
			return stackFrame.GetMethod();
		}

		// Token: 0x06000CA1 RID: 3233 RVA: 0x0001F0D8 File Offset: 0x0001D2D8
		public string GetCallerClassName(global::System.Reflection.MethodBase method, bool includeNameSpace, bool cleanAsyncMoveNext, bool cleanAnonymousDelegates)
		{
			if (!string.IsNullOrEmpty(this.CallerClassName))
			{
				if (includeNameSpace)
				{
					return this.CallerClassName;
				}
				int num = this.CallerClassName.LastIndexOf('.');
				if (num < 0 || num >= this.CallerClassName.Length - 1)
				{
					return this.CallerClassName;
				}
				return this.CallerClassName.Substring(num + 1);
			}
			else
			{
				method = (method ?? this.GetCallerStackFrameMethod(0));
				if (method == null)
				{
					return string.Empty;
				}
				cleanAsyncMoveNext = (cleanAsyncMoveNext || this.UserStackFrameNumberLegacy != null);
				cleanAnonymousDelegates = (cleanAnonymousDelegates || this.UserStackFrameNumberLegacy != null);
				return global::NLog.Internal.StackTraceUsageUtils.GetStackFrameMethodClassName(method, includeNameSpace, cleanAsyncMoveNext, cleanAnonymousDelegates) ?? string.Empty;
			}
		}

		// Token: 0x06000CA2 RID: 3234 RVA: 0x0001F194 File Offset: 0x0001D394
		public string GetCallerMemberName(global::System.Reflection.MethodBase method, bool includeMethodInfo, bool cleanAsyncMoveNext, bool cleanAnonymousDelegates)
		{
			if (!string.IsNullOrEmpty(this.CallerMemberName))
			{
				return this.CallerMemberName;
			}
			method = (method ?? this.GetCallerStackFrameMethod(0));
			if (method == null)
			{
				return string.Empty;
			}
			cleanAsyncMoveNext = (cleanAsyncMoveNext || this.UserStackFrameNumberLegacy != null);
			cleanAnonymousDelegates = (cleanAnonymousDelegates || this.UserStackFrameNumberLegacy != null);
			return global::NLog.Internal.StackTraceUsageUtils.GetStackFrameMethodName(method, includeMethodInfo, cleanAsyncMoveNext, cleanAnonymousDelegates) ?? string.Empty;
		}

		// Token: 0x06000CA3 RID: 3235 RVA: 0x0001F214 File Offset: 0x0001D414
		public string GetCallerFilePath(int skipFrames)
		{
			if (!string.IsNullOrEmpty(this.CallerFilePath))
			{
				return this.CallerFilePath;
			}
			global::System.Diagnostics.StackTrace stackTrace = this.StackTrace;
			global::System.Diagnostics.StackFrame stackFrame = (stackTrace != null) ? stackTrace.GetFrame(this.UserStackFrameNumber + skipFrames) : null;
			return ((stackFrame != null) ? stackFrame.GetFileName() : null) ?? string.Empty;
		}

		// Token: 0x06000CA4 RID: 3236 RVA: 0x0001F264 File Offset: 0x0001D464
		public int GetCallerLineNumber(int skipFrames)
		{
			if (this.CallerLineNumber != null)
			{
				return this.CallerLineNumber.Value;
			}
			global::System.Diagnostics.StackTrace stackTrace = this.StackTrace;
			global::System.Diagnostics.StackFrame stackFrame = (stackTrace != null) ? stackTrace.GetFrame(this.UserStackFrameNumber + skipFrames) : null;
			if (stackFrame == null)
			{
				return 0;
			}
			return stackFrame.GetFileLineNumber();
		}

		// Token: 0x17000264 RID: 612
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0001F2B5 File Offset: 0x0001D4B5
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x0001F2BD File Offset: 0x0001D4BD
		public string CallerClassName { get; private set; }

		// Token: 0x17000265 RID: 613
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0001F2C6 File Offset: 0x0001D4C6
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x0001F2CE File Offset: 0x0001D4CE
		public string CallerMemberName { get; private set; }

		// Token: 0x17000266 RID: 614
		// (get) Token: 0x06000CA9 RID: 3241 RVA: 0x0001F2D7 File Offset: 0x0001D4D7
		// (set) Token: 0x06000CAA RID: 3242 RVA: 0x0001F2DF File Offset: 0x0001D4DF
		public string CallerFilePath { get; private set; }

		// Token: 0x17000267 RID: 615
		// (get) Token: 0x06000CAB RID: 3243 RVA: 0x0001F2E8 File Offset: 0x0001D4E8
		// (set) Token: 0x06000CAC RID: 3244 RVA: 0x0001F2F0 File Offset: 0x0001D4F0
		public int? CallerLineNumber { get; private set; }
	}
}
