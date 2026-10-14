using System;
using System.ComponentModel;
using NLog.Config;

namespace NLog.Filters
{
	// Token: 0x02000154 RID: 340
	[global::NLog.Filters.Filter("whenNotEqual")]
	public class WhenNotEqualFilter : global::NLog.Filters.LayoutBasedFilter
	{
		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x06000F0C RID: 3852 RVA: 0x00026289 File Offset: 0x00024489
		// (set) Token: 0x06000F0D RID: 3853 RVA: 0x00026291 File Offset: 0x00024491
		[global::NLog.Config.RequiredParameter]
		public string CompareTo { get; set; }

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x06000F0E RID: 3854 RVA: 0x0002629A File Offset: 0x0002449A
		// (set) Token: 0x06000F0F RID: 3855 RVA: 0x000262A2 File Offset: 0x000244A2
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IgnoreCase { get; set; }

		// Token: 0x06000F10 RID: 3856 RVA: 0x000262AC File Offset: 0x000244AC
		protected override global::NLog.Filters.FilterResult Check(global::NLog.LogEventInfo logEvent)
		{
			global::System.StringComparison comparisonType = this.IgnoreCase ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal;
			if (!base.Layout.Render(logEvent).Equals(this.CompareTo, comparisonType))
			{
				return base.Action;
			}
			return global::NLog.Filters.FilterResult.Neutral;
		}
	}
}
