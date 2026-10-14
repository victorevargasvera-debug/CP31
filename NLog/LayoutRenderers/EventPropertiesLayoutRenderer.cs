using System;
using System.Globalization;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000B3 RID: 179
	[global::NLog.LayoutRenderers.LayoutRenderer("event-properties")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	[global::NLog.Config.MutableUnsafe]
	public class EventPropertiesLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000AA6 RID: 2726 RVA: 0x0001B0BD File Offset: 0x000192BD
		public EventPropertiesLayoutRenderer()
		{
			this.Culture = global::System.Globalization.CultureInfo.InvariantCulture;
		}

		// Token: 0x170001DB RID: 475
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0001B0D0 File Offset: 0x000192D0
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0001B0D8 File Offset: 0x000192D8
		[global::NLog.Config.RequiredParameter]
		[global::NLog.Config.DefaultParameter]
		public string Item { get; set; }

		// Token: 0x170001DC RID: 476
		// (get) Token: 0x06000AA9 RID: 2729 RVA: 0x0001B0E1 File Offset: 0x000192E1
		// (set) Token: 0x06000AAA RID: 2730 RVA: 0x0001B0E9 File Offset: 0x000192E9
		public string Format { get; set; }

		// Token: 0x170001DD RID: 477
		// (get) Token: 0x06000AAB RID: 2731 RVA: 0x0001B0F2 File Offset: 0x000192F2
		// (set) Token: 0x06000AAC RID: 2732 RVA: 0x0001B0FA File Offset: 0x000192FA
		public global::System.Globalization.CultureInfo Culture { get; set; }

		// Token: 0x06000AAD RID: 2733 RVA: 0x0001B104 File Offset: 0x00019304
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			object value;
			if (logEvent.HasProperties && logEvent.Properties.TryGetValue(this.Item, out value))
			{
				global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, this.Culture);
				builder.AppendFormattedValue(value, this.Format, formatProvider);
			}
		}
	}
}
