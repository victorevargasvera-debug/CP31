using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000DF RID: 223
	[global::NLog.LayoutRenderers.LayoutRenderer("time")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class TimeLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x17000239 RID: 569
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0001DC3B File Offset: 0x0001BE3B
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0001DC43 File Offset: 0x0001BE43
		[global::System.ComponentModel.DefaultValue(false)]
		public bool UniversalTime { get; set; }

		// Token: 0x1700023A RID: 570
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0001DC4C File Offset: 0x0001BE4C
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0001DC54 File Offset: 0x0001BE54
		[global::System.ComponentModel.DefaultValue(false)]
		public bool Invariant { get; set; }

		// Token: 0x06000BF0 RID: 3056 RVA: 0x0001DC60 File Offset: 0x0001BE60
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.DateTime dateTime = logEvent.TimeStamp;
			if (this.UniversalTime)
			{
				dateTime = dateTime.ToUniversalTime();
			}
			string value = ":";
			string value2 = ".";
			if (!this.Invariant)
			{
				global::System.Globalization.CultureInfo culture = base.GetCulture(logEvent, null);
				if (culture != null)
				{
					value = culture.DateTimeFormat.TimeSeparator;
					value2 = culture.NumberFormat.NumberDecimalSeparator;
				}
			}
			builder.Append2DigitsZeroPadded(dateTime.Hour);
			builder.Append(value);
			builder.Append2DigitsZeroPadded(dateTime.Minute);
			builder.Append(value);
			builder.Append2DigitsZeroPadded(dateTime.Second);
			builder.Append(value2);
			builder.Append4DigitsZeroPadded((int)(dateTime.Ticks % 10000000L) / 1000);
		}
	}
}
