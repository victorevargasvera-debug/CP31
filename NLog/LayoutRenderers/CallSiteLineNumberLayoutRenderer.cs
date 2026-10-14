using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000AD RID: 173
	[global::NLog.LayoutRenderers.LayoutRenderer("callsite-linenumber")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class CallSiteLineNumberLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer, global::NLog.Internal.IUsesStackTrace
	{
		// Token: 0x170001CE RID: 462
		// (get) Token: 0x06000A7E RID: 2686 RVA: 0x0001AC5F File Offset: 0x00018E5F
		// (set) Token: 0x06000A7F RID: 2687 RVA: 0x0001AC67 File Offset: 0x00018E67
		[global::System.ComponentModel.DefaultValue(0)]
		public int SkipFrames { get; set; }

		// Token: 0x170001CF RID: 463
		// (get) Token: 0x06000A80 RID: 2688 RVA: 0x0001AC70 File Offset: 0x00018E70
		global::NLog.Config.StackTraceUsage global::NLog.Internal.IUsesStackTrace.StackTraceUsage
		{
			get
			{
				return global::NLog.Config.StackTraceUsage.WithSource;
			}
		}

		// Token: 0x06000A81 RID: 2689 RVA: 0x0001AC74 File Offset: 0x00018E74
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (logEvent.CallSiteInformation != null)
			{
				int callerLineNumber = logEvent.CallSiteInformation.GetCallerLineNumber(this.SkipFrames);
				builder.AppendInvariant(callerLineNumber);
			}
		}
	}
}
