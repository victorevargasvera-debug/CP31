using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200006C RID: 108
	public class HistoricalJobsProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob>
	{
		// Token: 0x06000364 RID: 868 RVA: 0x00051FF8 File Offset: 0x000501F8
		public HistoricalJobsProvider(global::System.Guid radioId)
		{
			this.a = radioId;
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00052014 File Offset: 0x00050214
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)1562206696;
			short num2 = num;
			num = (short)1166238184;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1751646208;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)964362241;
			if (num != 0)
			{
			}
			num = (short)1994719232;
			if (num != 0)
			{
			}
			global::System.DateTime now = global::System.DateTime.Now;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob> radioHistoricalJobs = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.GetRadioHistoricalJobs(this.a, startIndex, length);
			milliseconds = (global::System.DateTime.Now - now).Milliseconds;
			return radioHistoricalJobs;
		}

		// Token: 0x06000366 RID: 870 RVA: 0x000520F0 File Offset: 0x000502F0
		public int GetTotalCount()
		{
			short num = (short)1380785433;
			short num2 = num;
			num = (short)1026759961;
			switch (num2 == num)
			{
			default:
			{
				num = (short)32047104;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)882245632;
			if (num != 0)
			{
			}
			num = (short)753664001;
			if (num != 0)
			{
			}
			return global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService.GetDeviceRWJobsCount(this.a);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x000521AC File Offset: 0x000503AC
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.HistoricalJob item)
		{
			short num = (short)1217081696;
			short num2 = num;
			num = (short)1685795168;
			switch (num2 == num)
			{
			default:
			{
				num = (short)628948992;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2046951424;
			if (num != 0)
			{
			}
			num = (short)2056650753;
			if (num != 0)
			{
			}
			item.a();
		}

		// Token: 0x0400009A RID: 154
		private readonly global::System.Guid a;
	}
}
