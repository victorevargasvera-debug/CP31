using System;
using System.ComponentModel;
using System.Globalization;
using System.Text;
using NLog.Config;

namespace NLog.LayoutRenderers
{
	// Token: 0x020000D7 RID: 215
	[global::NLog.LayoutRenderers.LayoutRenderer("shortdate")]
	[global::NLog.Config.ThreadAgnostic]
	[global::NLog.Config.ThreadSafe]
	public class ShortDateLayoutRenderer : global::NLog.LayoutRenderers.LayoutRenderer
	{
		// Token: 0x1700022E RID: 558
		// (get) Token: 0x06000BC5 RID: 3013 RVA: 0x0001D836 File Offset: 0x0001BA36
		// (set) Token: 0x06000BC6 RID: 3014 RVA: 0x0001D83E File Offset: 0x0001BA3E
		[global::System.ComponentModel.DefaultValue(false)]
		public bool UniversalTime { get; set; }

		// Token: 0x06000BC7 RID: 3015 RVA: 0x0001D848 File Offset: 0x0001BA48
		protected override void Append(global::System.Text.StringBuilder builder, global::NLog.LogEventInfo logEvent)
		{
			global::System.DateTime dateTime = logEvent.TimeStamp;
			if (this.UniversalTime)
			{
				dateTime = dateTime.ToUniversalTime();
			}
			global::NLog.LayoutRenderers.ShortDateLayoutRenderer.CachedDateFormatted cachedDateFormatted = this._cachedDateFormatted;
			if (cachedDateFormatted.Date != dateTime.Date)
			{
				string formattedDate = dateTime.ToString("yyyy-MM-dd", global::System.Globalization.CultureInfo.InvariantCulture);
				cachedDateFormatted = (this._cachedDateFormatted = new global::NLog.LayoutRenderers.ShortDateLayoutRenderer.CachedDateFormatted(dateTime.Date, formattedDate));
			}
			builder.Append(cachedDateFormatted.FormattedDate);
		}

		// Token: 0x0400033F RID: 831
		private global::NLog.LayoutRenderers.ShortDateLayoutRenderer.CachedDateFormatted _cachedDateFormatted = new global::NLog.LayoutRenderers.ShortDateLayoutRenderer.CachedDateFormatted(global::System.DateTime.MaxValue, string.Empty);

		// Token: 0x02000201 RID: 513
		private class CachedDateFormatted
		{
			// Token: 0x060012BE RID: 4798 RVA: 0x00030AEE File Offset: 0x0002ECEE
			public CachedDateFormatted(global::System.DateTime date, string formattedDate)
			{
				this.Date = date;
				this.FormattedDate = formattedDate;
			}

			// Token: 0x040005BF RID: 1471
			public readonly global::System.DateTime Date;

			// Token: 0x040005C0 RID: 1472
			public readonly string FormattedDate;
		}
	}
}
