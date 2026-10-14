using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C8 RID: 200
	[global::NLog.LayoutRenderers.LayoutRenderer("message")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class MessageLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000B5B RID: 2907 RVA: 0x0001CB8C File Offset: 0x0001AD8C
		public MessageLayoutRenderer()
		{
			this.ExceptionSeparator = global::NLog.Internal.EnvironmentHelper.NewLine;
		}

		// Token: 0x1700020D RID: 525
		// (get) Token: 0x06000B5C RID: 2908 RVA: 0x0001CB9F File Offset: 0x0001AD9F
		// (set) Token: 0x06000B5D RID: 2909 RVA: 0x0001CBA7 File Offset: 0x0001ADA7
		public bool WithException { get; set; }

		// Token: 0x1700020E RID: 526
		// (get) Token: 0x06000B5E RID: 2910 RVA: 0x0001CBB0 File Offset: 0x0001ADB0
		// (set) Token: 0x06000B5F RID: 2911 RVA: 0x0001CBB8 File Offset: 0x0001ADB8
		public string ExceptionSeparator { get; set; }

		// Token: 0x1700020F RID: 527
		// (get) Token: 0x06000B60 RID: 2912 RVA: 0x0001CBC1 File Offset: 0x0001ADC1
		// (set) Token: 0x06000B61 RID: 2913 RVA: 0x0001CBC9 File Offset: 0x0001ADC9
		public bool Raw { get; set; }

		// Token: 0x06000B62 RID: 2914 RVA: 0x0001CBD4 File Offset: 0x0001ADD4
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (this.Raw)
			{
				builder.Append(logEvent.Message);
			}
			else if (logEvent.MessageFormatter == global::NLog.Internal.LogMessageTemplateFormatter.DefaultAutoSingleTarget.MessageFormatter)
			{
				logEvent.AppendFormattedMessage(global::NLog.Internal.LogMessageTemplateFormatter.DefaultAutoSingleTarget, builder);
			}
			else
			{
				builder.Append(logEvent.FormattedMessage);
			}
			if (this.WithException && logEvent.Exception != null)
			{
				builder.Append(this.ExceptionSeparator);
				builder.Append(logEvent.Exception.ToString());
			}
		}
	}
}
