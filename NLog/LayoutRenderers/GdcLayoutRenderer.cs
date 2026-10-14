using System;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000B9 RID: 185
	[global::NLog.LayoutRenderers.LayoutRenderer("gdc")]
	[global::NLog.Config.ThreadSafe]
	public class GdcLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x170001EB RID: 491
		// (get) Token: 0x06000ADF RID: 2783 RVA: 0x0001B97A File Offset: 0x00019B7A
		// (set) Token: 0x06000AE0 RID: 2784 RVA: 0x0001B982 File Offset: 0x00019B82
		[global::NLog.Config.RequiredParameter]
		[global::NLog.Config.DefaultParameter]
		public string Item { get; set; }

		// Token: 0x170001EC RID: 492
		// (get) Token: 0x06000AE1 RID: 2785 RVA: 0x0001B98B File Offset: 0x00019B8B
		// (set) Token: 0x06000AE2 RID: 2786 RVA: 0x0001B993 File Offset: 0x00019B93
		public string Format { get; set; }

		// Token: 0x06000AE3 RID: 2787 RVA: 0x0001B99C File Offset: 0x00019B9C
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			object @object = global::NLog.GlobalDiagnosticsContext.GetObject(this.Item);
			global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
			builder.AppendFormattedValue(@object, this.Format, formatProvider);
		}
	}
}
