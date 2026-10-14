using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000BA RID: 186
	[global::NLog.LayoutRenderers.LayoutRenderer("guid")]
	[global::NLog.Config.ThreadSafe]
	public class GuidLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000AE5 RID: 2789 RVA: 0x0001B9D4 File Offset: 0x00019BD4
		public GuidLayoutRenderer()
		{
			this.Format = "N";
		}

		// Token: 0x170001ED RID: 493
		// (get) Token: 0x06000AE6 RID: 2790 RVA: 0x0001B9E7 File Offset: 0x00019BE7
		// (set) Token: 0x06000AE7 RID: 2791 RVA: 0x0001B9EF File Offset: 0x00019BEF
		[global::System.ComponentModel.DefaultValue("N")]
		public string Format { get; set; }

		// Token: 0x170001EE RID: 494
		// (get) Token: 0x06000AE8 RID: 2792 RVA: 0x0001B9F8 File Offset: 0x00019BF8
		// (set) Token: 0x06000AE9 RID: 2793 RVA: 0x0001BA00 File Offset: 0x00019C00
		[global::System.ComponentModel.DefaultValue(false)]
		public bool GeneratedFromLogEvent { get; set; }

		// Token: 0x06000AEA RID: 2794 RVA: 0x0001BA0C File Offset: 0x00019C0C
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			if (this.GeneratedFromLogEvent)
			{
				int hashCode = logEvent.GetHashCode();
				short b = (short)(hashCode >> 16 & 65535);
				short c = (short)(hashCode & 65535);
				long ticks = global::NLog.LogEventInfo.ZeroDate.Ticks;
				byte d = (byte)(ticks >> 56 & 255L);
				byte e = (byte)(ticks >> 48 & 255L);
				byte f = (byte)(ticks >> 40 & 255L);
				byte g = (byte)(ticks >> 32 & 255L);
				byte h = (byte)(ticks >> 24 & 255L);
				byte i = (byte)(ticks >> 16 & 255L);
				byte j = (byte)(ticks >> 8 & 255L);
				byte k = (byte)(ticks & 255L);
				builder.Append(new global::System.Guid(logEvent.SequenceID, b, c, d, e, f, g, h, i, j, k).ToString(this.Format));
				return;
			}
			builder.Append(global::System.Guid.NewGuid().ToString(this.Format));
		}
	}
}
