using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000B0 RID: 176
	[global::NLog.LayoutRenderers.LayoutRenderer("date")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class DateLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x06000A93 RID: 2707 RVA: 0x0001AE10 File Offset: 0x00019010
		public DateLayoutRenderer()
		{
			this.Format = "yyyy/MM/dd HH:mm:ss.fff";
			this.Culture = global::System.Globalization.CultureInfo.InvariantCulture;
		}

		// Token: 0x170001D5 RID: 469
		// (get) Token: 0x06000A94 RID: 2708 RVA: 0x0001AE43 File Offset: 0x00019043
		// (set) Token: 0x06000A95 RID: 2709 RVA: 0x0001AE4B File Offset: 0x0001904B
		public global::System.Globalization.CultureInfo Culture { get; set; }

		// Token: 0x170001D6 RID: 470
		// (get) Token: 0x06000A96 RID: 2710 RVA: 0x0001AE54 File Offset: 0x00019054
		// (set) Token: 0x06000A97 RID: 2711 RVA: 0x0001AE5C File Offset: 0x0001905C
		[global::NLog.Config.DefaultParameter]
		public string Format
		{
			get
			{
				return this._format;
			}
			set
			{
				this._format = value;
				if (global::NLog.LayoutRenderers.DateLayoutRenderer.IsLowTimeResolutionLayout(this._format))
				{
					this._cachedDateFormatted = new global::NLog.LayoutRenderers.DateLayoutRenderer.CachedDateFormatted(global::System.DateTime.MaxValue, string.Empty);
					return;
				}
				this._cachedDateFormatted = new global::NLog.LayoutRenderers.DateLayoutRenderer.CachedDateFormatted(global::System.DateTime.MinValue, string.Empty);
			}
		}

		// Token: 0x170001D7 RID: 471
		// (get) Token: 0x06000A98 RID: 2712 RVA: 0x0001AEA8 File Offset: 0x000190A8
		// (set) Token: 0x06000A99 RID: 2713 RVA: 0x0001AEB0 File Offset: 0x000190B0
		[global::System.ComponentModel.DefaultValue(false)]
		public bool UniversalTime { get; set; }

		// Token: 0x06000A9A RID: 2714 RVA: 0x0001AEBC File Offset: 0x000190BC
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.IFormatProvider formatProvider = base.GetFormatProvider(logEvent, this.Culture);
			global::System.DateTime dateTime = logEvent.TimeStamp;
			if (this.UniversalTime)
			{
				dateTime = dateTime.ToUniversalTime();
			}
			global::NLog.LayoutRenderers.DateLayoutRenderer.CachedDateFormatted cachedDateFormatted = this._cachedDateFormatted;
			if (formatProvider != global::System.Globalization.CultureInfo.InvariantCulture || cachedDateFormatted.Date == global::System.DateTime.MinValue)
			{
				cachedDateFormatted = null;
			}
			else if (cachedDateFormatted.Date == dateTime.Date.AddHours((double)dateTime.Hour))
			{
				builder.Append(cachedDateFormatted.FormattedDate);
				return;
			}
			string text = dateTime.ToString(this._format, formatProvider);
			if (cachedDateFormatted != null)
			{
				this._cachedDateFormatted = new global::NLog.LayoutRenderers.DateLayoutRenderer.CachedDateFormatted(dateTime.Date.AddHours((double)dateTime.Hour), text);
			}
			builder.Append(text);
		}

		// Token: 0x06000A9B RID: 2715 RVA: 0x0001AF84 File Offset: 0x00019184
		private static bool IsLowTimeResolutionLayout(string dateTimeFormat)
		{
			foreach (char c in dateTimeFormat)
			{
				if (char.IsLetter(c) && "YyMDdHh".IndexOf(c) < 0)
				{
					return false;
				}
			}
			return true;
		}

		// Token: 0x0400029B RID: 667
		private string _format;

		// Token: 0x0400029C RID: 668
		private const string _lowTimeResolutionChars = "YyMDdHh";

		// Token: 0x0400029D RID: 669
		private global::NLog.LayoutRenderers.DateLayoutRenderer.CachedDateFormatted _cachedDateFormatted = new global::NLog.LayoutRenderers.DateLayoutRenderer.CachedDateFormatted(global::System.DateTime.MinValue, string.Empty);

		// Token: 0x020001FE RID: 510
		private class CachedDateFormatted
		{
			// Token: 0x060012B5 RID: 4789 RVA: 0x00030A88 File Offset: 0x0002EC88
			public CachedDateFormatted(global::System.DateTime date, string formattedDate)
			{
				this.Date = date;
				this.FormattedDate = formattedDate;
			}

			// Token: 0x040005BA RID: 1466
			public readonly global::System.DateTime Date;

			// Token: 0x040005BB RID: 1467
			public readonly string FormattedDate;
		}
	}
}
