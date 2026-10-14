using System;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200006D RID: 109
	public class HistoricalJobViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>
	{
		// Token: 0x06000368 RID: 872 RVA: 0x00052260 File Offset: 0x00050460
		public HistoricalJobViewCache(global::System.Guid radioId) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.HistoricalJobsProvider(radioId), null, 10)
		{
		}
	}
}
