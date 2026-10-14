using System;
using System.ComponentModel;
using NLog.Config;

namespace NLog.Filters
{
	// Token: 0x02000152 RID: 338
	[global::NLog.Filters.Filter("whenEqual")]
	public class WhenEqualFilter : global::NLog.Filters.LayoutBasedFilter
	{
		// Token: 0x170002CD RID: 717
		// (get) Token: 0x06000EFF RID: 3839 RVA: 0x000261B1 File Offset: 0x000243B1
		// (set) Token: 0x06000F00 RID: 3840 RVA: 0x000261B9 File Offset: 0x000243B9
		[global::System.ComponentModel.DefaultValue(false)]
		public bool IgnoreCase { get; set; }

		// Token: 0x170002CE RID: 718
		// (get) Token: 0x06000F01 RID: 3841 RVA: 0x000261C2 File Offset: 0x000243C2
		// (set) Token: 0x06000F02 RID: 3842 RVA: 0x000261CA File Offset: 0x000243CA
		[global::NLog.Config.RequiredParameter]
		public string CompareTo { get; set; }

		// Token: 0x06000F03 RID: 3843 RVA: 0x000261D4 File Offset: 0x000243D4
		protected override global::NLog.Filters.FilterResult Check(global::NLog.LogEventInfo logEvent)
		{
			global::System.StringComparison comparisonType = this.IgnoreCase ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal;
			if (base.Layout.Render(logEvent).Equals(this.CompareTo, comparisonType))
			{
				return base.Action;
			}
			return global::NLog.Filters.FilterResult.Neutral;
		}
	}
}
