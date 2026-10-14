using System;
using NLog.Config;

namespace NLog.Filters
{
	// Token: 0x0200014D RID: 333
	[global::NLog.Config.NLogConfigurationItem]
	public abstract class Filter
	{
		// Token: 0x06000EF0 RID: 3824 RVA: 0x000260FC File Offset: 0x000242FC
		protected Filter()
		{
			this.Action = global::NLog.Filters.FilterResult.Neutral;
		}

		// Token: 0x170002C9 RID: 713
		// (get) Token: 0x06000EF1 RID: 3825 RVA: 0x0002610B File Offset: 0x0002430B
		// (set) Token: 0x06000EF2 RID: 3826 RVA: 0x00026113 File Offset: 0x00024313
		[global::NLog.Config.RequiredParameter]
		public global::NLog.Filters.FilterResult Action { get; set; }

		// Token: 0x06000EF3 RID: 3827 RVA: 0x0002611C File Offset: 0x0002431C
		internal global::NLog.Filters.FilterResult GetFilterResult(global::NLog.LogEventInfo logEvent)
		{
			return this.Check(logEvent);
		}

		// Token: 0x06000EF4 RID: 3828
		protected abstract global::NLog.Filters.FilterResult Check(global::NLog.LogEventInfo logEvent);
	}
}
