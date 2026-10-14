using System;
using System.ComponentModel;
using System.IO;
using System.Reflection;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000AC RID: 172
	[global::NLog.LayoutRenderers.LayoutRenderer("callsite")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class CallSiteLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer, global::NLog.Internal.IUsesStackTrace
	{
		// Token: 0x06000A6A RID: 2666 RVA: 0x0001AA39 File Offset: 0x00018C39
		public CallSiteLayoutRenderer()
		{
			this.ClassName = true;
			this.MethodName = true;
			this.CleanNamesOfAnonymousDelegates = false;
			this.IncludeNamespace = true;
			this.FileName = false;
			this.IncludeSourcePath = true;
		}

		// Token: 0x170001C5 RID: 453
		// (get) Token: 0x06000A6B RID: 2667 RVA: 0x0001AA6B File Offset: 0x00018C6B
		// (set) Token: 0x06000A6C RID: 2668 RVA: 0x0001AA73 File Offset: 0x00018C73
		[global::System.ComponentModel.DefaultValue(true)]
		public bool ClassName { get; set; }

		// Token: 0x170001C6 RID: 454
		// (get) Token: 0x06000A6D RID: 2669 RVA: 0x0001AA7C File Offset: 0x00018C7C
		// (set) Token: 0x06000A6E RID: 2670 RVA: 0x0001AA84 File Offset: 0x00018C84
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IncludeNamespace { get; set; }

		// Token: 0x170001C7 RID: 455
		// (get) Token: 0x06000A6F RID: 2671 RVA: 0x0001AA8D File Offset: 0x00018C8D
		// (set) Token: 0x06000A70 RID: 2672 RVA: 0x0001AA95 File Offset: 0x00018C95
		[global::System.ComponentModel.DefaultValue(true)]
		public bool MethodName { get; set; }

		// Token: 0x170001C8 RID: 456
		// (get) Token: 0x06000A71 RID: 2673 RVA: 0x0001AA9E File Offset: 0x00018C9E
		// (set) Token: 0x06000A72 RID: 2674 RVA: 0x0001AAA6 File Offset: 0x00018CA6
		[global::System.ComponentModel.DefaultValue(false)]
		public bool CleanNamesOfAnonymousDelegates { get; set; }

		// Token: 0x170001C9 RID: 457
		// (get) Token: 0x06000A73 RID: 2675 RVA: 0x0001AAAF File Offset: 0x00018CAF
		// (set) Token: 0x06000A74 RID: 2676 RVA: 0x0001AAB7 File Offset: 0x00018CB7
		[global::System.ComponentModel.DefaultValue(false)]
		public bool CleanNamesOfAsyncContinuations { get; set; }

		// Token: 0x170001CA RID: 458
		// (get) Token: 0x06000A75 RID: 2677 RVA: 0x0001AAC0 File Offset: 0x00018CC0
		// (set) Token: 0x06000A76 RID: 2678 RVA: 0x0001AAC8 File Offset: 0x00018CC8
		[global::System.ComponentModel.DefaultValue(0)]
		public int SkipFrames { get; set; }

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000A77 RID: 2679 RVA: 0x0001AAD1 File Offset: 0x00018CD1
		// (set) Token: 0x06000A78 RID: 2680 RVA: 0x0001AAD9 File Offset: 0x00018CD9
		[global::System.ComponentModel.DefaultValue(false)]
		public bool FileName { get; set; }

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000A79 RID: 2681 RVA: 0x0001AAE2 File Offset: 0x00018CE2
		// (set) Token: 0x06000A7A RID: 2682 RVA: 0x0001AAEA File Offset: 0x00018CEA
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IncludeSourcePath { get; set; }

		// Token: 0x170001CD RID: 461
		// (get) Token: 0x06000A7B RID: 2683 RVA: 0x0001AAF3 File Offset: 0x00018CF3
		global::NLog.Config.StackTraceUsage global::NLog.Internal.IUsesStackTrace.StackTraceUsage
		{
			get
			{
				if (this.FileName)
				{
					return global::NLog.Config.StackTraceUsage.WithSource;
				}
				return global::NLog.Config.StackTraceUsage.WithoutSource;
			}
		}

		// Token: 0x06000A7C RID: 2684 RVA: 0x0001AB00 File Offset: 0x00018D00
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (logEvent.CallSiteInformation != null)
			{
				if (this.ClassName || this.MethodName)
				{
					global::System.Reflection.MethodBase callerStackFrameMethod = logEvent.CallSiteInformation.GetCallerStackFrameMethod(this.SkipFrames);
					if (this.ClassName)
					{
						string value = logEvent.CallSiteInformation.GetCallerClassName(callerStackFrameMethod, this.IncludeNamespace, this.CleanNamesOfAsyncContinuations, this.CleanNamesOfAnonymousDelegates);
						if (string.IsNullOrEmpty(value))
						{
							value = "<no type>";
						}
						builder.Append(value);
					}
					if (this.MethodName)
					{
						string value2 = logEvent.CallSiteInformation.GetCallerMemberName(callerStackFrameMethod, false, this.CleanNamesOfAsyncContinuations, this.CleanNamesOfAnonymousDelegates);
						if (string.IsNullOrEmpty(value2))
						{
							value2 = "<no method>";
						}
						if (this.ClassName)
						{
							builder.Append(".");
						}
						builder.Append(value2);
					}
				}
				if (this.FileName)
				{
					string callerFilePath = logEvent.CallSiteInformation.GetCallerFilePath(this.SkipFrames);
					if (!string.IsNullOrEmpty(callerFilePath))
					{
						int callerLineNumber = logEvent.CallSiteInformation.GetCallerLineNumber(this.SkipFrames);
						this.AppendFileName(builder, callerFilePath, callerLineNumber);
					}
				}
			}
		}

		// Token: 0x06000A7D RID: 2685 RVA: 0x0001AC08 File Offset: 0x00018E08
		private void AppendFileName(global::System.Text.StringBuilder builder, string fileName, int lineNumber)
		{
			builder.Append("(");
			if (this.IncludeSourcePath)
			{
				builder.Append(fileName);
			}
			else
			{
				builder.Append(global::System.IO.Path.GetFileName(fileName));
			}
			builder.Append(":");
			builder.AppendInvariant(lineNumber);
			builder.Append(")");
		}
	}
}
