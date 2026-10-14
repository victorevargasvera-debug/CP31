using System;
using System.Text;
using NLog.Config;
using NLog.Time;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000CB RID: 203
	[global::NLog.LayoutRenderers.LayoutRenderer("ndlctiming")]
	[global::NLog.Config.ThreadSafe]
	public class NdlcTimingLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x17000216 RID: 534
		// (get) Token: 0x06000B73 RID: 2931 RVA: 0x0001CE1C File Offset: 0x0001B01C
		// (set) Token: 0x06000B74 RID: 2932 RVA: 0x0001CE24 File Offset: 0x0001B024
		public bool CurrentScope { get; set; }

		// Token: 0x17000217 RID: 535
		// (get) Token: 0x06000B75 RID: 2933 RVA: 0x0001CE2D File Offset: 0x0001B02D
		// (set) Token: 0x06000B76 RID: 2934 RVA: 0x0001CE35 File Offset: 0x0001B035
		public bool ScopeBeginTime { get; set; }

		// Token: 0x17000218 RID: 536
		// (get) Token: 0x06000B77 RID: 2935 RVA: 0x0001CE3E File Offset: 0x0001B03E
		// (set) Token: 0x06000B78 RID: 2936 RVA: 0x0001CE46 File Offset: 0x0001B046
		public string Format { get; set; }

		// Token: 0x06000B79 RID: 2937 RVA: 0x0001CE50 File Offset: 0x0001B050
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.DateTime dateTime = this.CurrentScope ? global::NLog.NestedDiagnosticsLogicalContext.PeekTopScopeBeginTime() : global::NLog.NestedDiagnosticsLogicalContext.PeekBottomScopeBeginTime();
			if (dateTime != global::System.DateTime.MinValue)
			{
				if (this.ScopeBeginTime)
				{
					global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, null);
					builder.Append(global::NLog.Time.TimeSource.Current.FromSystemTime(dateTime).ToString(this.Format, formatProvider));
					return;
				}
				global::System.TimeSpan t = (dateTime != global::System.DateTime.MinValue) ? (global::System.DateTime.UtcNow - dateTime) : global::System.TimeSpan.Zero;
				if (t < global::System.TimeSpan.Zero)
				{
					t = global::System.TimeSpan.Zero;
				}
				global::System.IFormatProvider formatProvider2 = base.GetFormatProvider(logEvent, null);
				builder.Append(t.ToString(this.Format, formatProvider2));
			}
		}
	}
}
