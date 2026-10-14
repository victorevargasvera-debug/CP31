using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C3 RID: 195
	[global::NLog.LayoutRenderers.LayoutRenderer("logger")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class LoggerNameLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000B42 RID: 2882 RVA: 0x0001C8EA File Offset: 0x0001AAEA
		// (set) Token: 0x06000B43 RID: 2883 RVA: 0x0001C8F2 File Offset: 0x0001AAF2
		[global::System.ComponentModel.DefaultValue(false)]
		public bool ShortName { get; set; }

		// Token: 0x06000B44 RID: 2884 RVA: 0x0001C8FC File Offset: 0x0001AAFC
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (!this.ShortName)
			{
				builder.Append(logEvent.LoggerName);
				return;
			}
			int num = logEvent.LoggerName.LastIndexOf('.');
			if (num < 0)
			{
				builder.Append(logEvent.LoggerName);
				return;
			}
			builder.Append(logEvent.LoggerName, num + 1, logEvent.LoggerName.Length - num - 1);
		}
	}
}
