using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000D3 RID: 211
	[global::NLog.LayoutRenderers.LayoutRenderer("processtime")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class ProcessTimeLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x17000223 RID: 547
		// (get) Token: 0x06000BA2 RID: 2978 RVA: 0x0001D278 File Offset: 0x0001B478
		// (set) Token: 0x06000BA3 RID: 2979 RVA: 0x0001D280 File Offset: 0x0001B480
		[global::System.ComponentModel.DefaultValue(false)]
		public bool Invariant { get; set; }

		// Token: 0x06000BA4 RID: 2980 RVA: 0x0001D28C File Offset: 0x0001B48C
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.TimeSpan ts = logEvent.TimeStamp.ToUniversalTime() - global::NLog.LogEventInfo.ZeroDate;
			global::System.Globalization.CultureInfo culture = this.Invariant ? null : base.GetCulture(logEvent, null);
			global::NLog.LayoutRenderers.ProcessTimeLayoutRenderer.WritetTimestamp(builder, ts, culture);
		}

		// Token: 0x06000BA5 RID: 2981 RVA: 0x0001D2D0 File Offset: 0x0001B4D0
		internal static void WritetTimestamp(global::System.Text.StringBuilder builder, global::System.TimeSpan ts, global::System.Globalization.CultureInfo culture)
		{
			string value = ":";
			string value2 = ".";
			if (culture != null)
			{
				value = culture.DateTimeFormat.TimeSeparator;
				value2 = culture.NumberFormat.NumberDecimalSeparator;
			}
			builder.Append2DigitsZeroPadded(ts.Hours);
			builder.Append(value);
			builder.Append2DigitsZeroPadded(ts.Minutes);
			builder.Append(value);
			builder.Append2DigitsZeroPadded(ts.Seconds);
			builder.Append(value2);
			int milliseconds = ts.Milliseconds;
			if (milliseconds < 100)
			{
				builder.Append('0');
				if (milliseconds < 10)
				{
					builder.Append('0');
					if (milliseconds < 0)
					{
						builder.Append('0');
						return;
					}
				}
			}
			builder.AppendInvariant(milliseconds);
		}
	}
}
