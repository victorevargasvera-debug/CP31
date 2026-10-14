using System;
using System.ComponentModel;
using NLog.Config;

namespace NLog.Filters
{
	// Token: 0x02000153 RID: 339
	[global::NLog.Filters.Filter("whenNotContains")]
	public class WhenNotContainsFilter : global::NLog.Filters.LayoutBasedFilter
	{
		// Token: 0x170002CF RID: 719
		// (get) Token: 0x06000F05 RID: 3845 RVA: 0x00026218 File Offset: 0x00024418
		// (set) Token: 0x06000F06 RID: 3846 RVA: 0x00026220 File Offset: 0x00024420
		[global::NLog.Config.RequiredParameter]
		public string Substring { get; set; }

		// Token: 0x170002D0 RID: 720
		// (get) Token: 0x06000F07 RID: 3847 RVA: 0x00026229 File Offset: 0x00024429
		// (set) Token: 0x06000F08 RID: 3848 RVA: 0x00026231 File Offset: 0x00024431
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IgnoreCase { get; set; }

		// Token: 0x06000F09 RID: 3849 RVA: 0x0002623C File Offset: 0x0002443C
		protected override global::NLog.Filters.FilterResult Check(global::NLog.LogEventInfo logEvent)
		{
			global::System.StringComparison comparisonType = this.IgnoreCase ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal;
			if (base.Layout.Render(logEvent).IndexOf(this.Substring, comparisonType) < 0)
			{
				return base.Action;
			}
			return global::NLog.Filters.FilterResult.Neutral;
		}
	}
}
