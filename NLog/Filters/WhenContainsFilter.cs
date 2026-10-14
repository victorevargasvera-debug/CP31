using System;
using System.ComponentModel;
using NLog.Config;

namespace NLog.Filters
{
	// Token: 0x02000151 RID: 337
	[global::NLog.Filters.Filter("whenContains")]
	public class WhenContainsFilter : global::NLog.Filters.LayoutBasedFilter
	{
		// Token: 0x170002CB RID: 715
		// (get) Token: 0x06000EF9 RID: 3833 RVA: 0x00026147 File Offset: 0x00024347
		// (set) Token: 0x06000EFA RID: 3834 RVA: 0x0002614F File Offset: 0x0002434F
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IgnoreCase { get; set; }

		// Token: 0x170002CC RID: 716
		// (get) Token: 0x06000EFB RID: 3835 RVA: 0x00026158 File Offset: 0x00024358
		// (set) Token: 0x06000EFC RID: 3836 RVA: 0x00026160 File Offset: 0x00024360
		[global::NLog.Config.RequiredParameter]
		public string Substring { get; set; }

		// Token: 0x06000EFD RID: 3837 RVA: 0x0002616C File Offset: 0x0002436C
		protected override global::NLog.Filters.FilterResult Check(global::NLog.LogEventInfo logEvent)
		{
			global::System.StringComparison comparisonType = this.IgnoreCase ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal;
			if (base.Layout.Render(logEvent).IndexOf(this.Substring, comparisonType) >= 0)
			{
				return base.Action;
			}
			return global::NLog.Filters.FilterResult.Neutral;
		}
	}
}
