using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C0 RID: 192
	[global::NLog.LayoutRenderers.LayoutRenderer("level")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class LevelLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x06000B0F RID: 2831 RVA: 0x0001BECB File Offset: 0x0001A0CB
		// (set) Token: 0x06000B10 RID: 2832 RVA: 0x0001BED3 File Offset: 0x0001A0D3
		[global::System.ComponentModel.DefaultValue(global::NLog.LayoutRenderers.LevelFormat.Name)]
		public global::NLog.LayoutRenderers.LevelFormat Format { get; set; }

		// Token: 0x06000B11 RID: 2833 RVA: 0x0001BEDC File Offset: 0x0001A0DC
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			switch (this.Format)
			{
			case global::NLog.LayoutRenderers.LevelFormat.Name:
				builder.Append(logEvent.Level.ToString());
				return;
			case global::NLog.LayoutRenderers.LevelFormat.FirstCharacter:
				builder.Append(logEvent.Level.ToString()[0]);
				return;
			case global::NLog.LayoutRenderers.LevelFormat.Ordinal:
				builder.AppendInvariant(logEvent.Level.Ordinal);
				return;
			default:
				return;
			}
		}
	}
}
