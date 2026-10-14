using System;
using System.ComponentModel;
using System.Text;
using NLog.Config;
using NLog.Internal;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000C4 RID: 196
	[global::NLog.LayoutRenderers.LayoutRenderer("longdate")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class LongDateLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x17000207 RID: 519
		// (get) Token: 0x06000B46 RID: 2886 RVA: 0x0001C966 File Offset: 0x0001AB66
		// (set) Token: 0x06000B47 RID: 2887 RVA: 0x0001C96E File Offset: 0x0001AB6E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool UniversalTime { get; set; }

		// Token: 0x06000B48 RID: 2888 RVA: 0x0001C978 File Offset: 0x0001AB78
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.DateTime dateTime = logEvent.TimeStamp;
			if (this.UniversalTime)
			{
				dateTime = dateTime.ToUniversalTime();
			}
			builder.Append4DigitsZeroPadded(dateTime.Year);
			builder.Append('-');
			builder.Append2DigitsZeroPadded(dateTime.Month);
			builder.Append('-');
			builder.Append2DigitsZeroPadded(dateTime.Day);
			builder.Append(' ');
			builder.Append2DigitsZeroPadded(dateTime.Hour);
			builder.Append(':');
			builder.Append2DigitsZeroPadded(dateTime.Minute);
			builder.Append(':');
			builder.Append2DigitsZeroPadded(dateTime.Second);
			builder.Append('.');
			builder.Append4DigitsZeroPadded((int)(dateTime.Ticks % 10000000L) / 1000);
		}
	}
}
