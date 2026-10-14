using System;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000B2 RID: 178
	[global::NLog.LayoutRenderers.LayoutRenderer("event-context")]
	[global::NLog.Config.MutableUnsafe]
	[global::System.Obsolete("Use EventPropertiesLayoutRenderer class instead. Marked obsolete on NLog 2.0")]
	public class EventContextLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x170001DA RID: 474
		// (get) Token: 0x06000AA2 RID: 2722 RVA: 0x0001B062 File Offset: 0x00019262
		// (set) Token: 0x06000AA3 RID: 2723 RVA: 0x0001B06A File Offset: 0x0001926A
		[global::NLog.Config.RequiredParameter]
		[global::NLog.Config.DefaultParameter]
		public string Item { get; set; }

		// Token: 0x06000AA4 RID: 2724 RVA: 0x0001B074 File Offset: 0x00019274
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			object value;
			if (logEvent.HasProperties && logEvent.Properties.TryGetValue(this.Item, out value))
			{
				global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
				builder.Append(global::System.Convert.ToString(value, formatProvider));
			}
		}
	}
}
