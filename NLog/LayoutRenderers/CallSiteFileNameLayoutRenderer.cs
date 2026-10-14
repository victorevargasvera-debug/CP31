using System;
using System.ComponentModel;
using System.IO;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000AB RID: 171
	[global::NLog.LayoutRenderers.LayoutRenderer("callsite-filename")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class CallSiteFileNameLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer, global::NLog.Internal.IUsesStackTrace
	{
		// Token: 0x06000A63 RID: 2659 RVA: 0x0001A9B6 File Offset: 0x00018BB6
		public CallSiteFileNameLayoutRenderer()
		{
			this.IncludeSourcePath = true;
		}

		// Token: 0x170001C2 RID: 450
		// (get) Token: 0x06000A64 RID: 2660 RVA: 0x0001A9C5 File Offset: 0x00018BC5
		// (set) Token: 0x06000A65 RID: 2661 RVA: 0x0001A9CD File Offset: 0x00018BCD
		[global::System.ComponentModel.DefaultValue(true)]
		public bool IncludeSourcePath { get; set; }

		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000A66 RID: 2662 RVA: 0x0001A9D6 File Offset: 0x00018BD6
		// (set) Token: 0x06000A67 RID: 2663 RVA: 0x0001A9DE File Offset: 0x00018BDE
		[global::System.ComponentModel.DefaultValue(0)]
		public int SkipFrames { get; set; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000A68 RID: 2664 RVA: 0x0001A9E7 File Offset: 0x00018BE7
		global::NLog.Config.StackTraceUsage global::NLog.Internal.IUsesStackTrace.StackTraceUsage
		{
			get
			{
				return global::NLog.Config.StackTraceUsage.WithSource;
			}
		}

		// Token: 0x06000A69 RID: 2665 RVA: 0x0001A9EC File Offset: 0x00018BEC
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (logEvent.CallSiteInformation != null)
			{
				string callerFilePath = logEvent.CallSiteInformation.GetCallerFilePath(this.SkipFrames);
				if (!string.IsNullOrEmpty(callerFilePath))
				{
					if (this.IncludeSourcePath)
					{
						builder.Append(callerFilePath);
						return;
					}
					builder.Append(global::System.IO.Path.GetFileName(callerFilePath));
				}
			}
		}
	}
}
