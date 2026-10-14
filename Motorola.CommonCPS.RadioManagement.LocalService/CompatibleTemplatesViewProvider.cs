using System;
using System.Collections.Generic;
using System.Diagnostics;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000085 RID: 133
	public class CompatibleTemplatesViewProvider : global::Motorola.CommonCPS.RadioManagement.ViewCache.IItemsProvider<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase>
	{
		// Token: 0x060003B5 RID: 949 RVA: 0x00056798 File Offset: 0x00054998
		public CompatibleTemplatesViewProvider(global::System.Collections.Generic.List<global::System.Guid> radioUUIDList)
		{
			this.a = radioUUIDList;
		}

		// Token: 0x060003B6 RID: 950 RVA: 0x000567B4 File Offset: 0x000549B4
		public global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> FetchRange(int startIndex, int length, out int milliseconds)
		{
			short num = (short)836697357;
			short num2 = num;
			num = (short)1944976653;
			switch (num2 == num)
			{
			}
			num = (short)2019491840;
			if (num != 0)
			{
			}
			num = (short)1458700289;
			if (num != 0)
			{
			}
			num = (short)31850496;
			short num3 = num;
			global::System.Diagnostics.Stopwatch stopwatch = new global::System.Diagnostics.Stopwatch();
			stopwatch.Start();
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase> result = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetCompatibleTemplateSummaryList(this.a, startIndex, length).ToUiModel(false);
			stopwatch.Stop();
			milliseconds = (int)stopwatch.ElapsedMilliseconds;
			return result;
		}

		// Token: 0x060003B7 RID: 951 RVA: 0x00056894 File Offset: 0x00054A94
		public int GetTotalCount()
		{
			short num = (short)1737938184;
			short num2 = num;
			num = (short)700699912;
			switch (num2 == num)
			{
			}
			num = (short)1297678337;
			if (num != 0)
			{
			}
			num = (short)967114752;
			if (num != 0)
			{
			}
			num = (short)775290880;
			short num3 = num;
			return (int)global::Motorola.CommonCPS.RadioManagement.SharedServices.ServerAccessor.GetInstance(true, false).GetCompatibleTemplateCount(this.a);
		}

		// Token: 0x060003B8 RID: 952 RVA: 0x00056954 File Offset: 0x00054B54
		public void SetValidator(global::Motorola.CommonCPS.RadioManagement.UIModels.TemplateBase item)
		{
			short num = (short)1453719553;
			if (num != 0)
			{
			}
			num = (short)275649723;
			short num2 = num;
			num = (short)73667771;
			switch (num2 == num)
			{
			}
			num = (short)1752367104;
			if (num != 0)
			{
			}
			num = (short)703463424;
			short num3 = num;
			item.a();
		}

		// Token: 0x040000B8 RID: 184
		private global::System.Collections.Generic.List<global::System.Guid> a;
	}
}
