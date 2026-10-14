using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200007B RID: 123
	public class SelectMVOViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000391 RID: 913 RVA: 0x000548D8 File Offset: 0x00052AD8
		public SelectMVOViewCache() : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.h(), null, 500)
		{
		}

		// Token: 0x06000392 RID: 914 RVA: 0x000548F8 File Offset: 0x00052AF8
		public override void ItemChanged<TV>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<TV> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters)
		{
			short num = (short)293535750;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)235274241;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					goto IL_10A;
				case 2:
				{
					if (operationType == global::System.Data.Linq.ChangeAction.Insert)
					{
						num = (short)992083968;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1976600295;
					short num3 = num;
					num = (short)1023641319;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_25D;
					default:
						num = (short)1369571328;
						if (num != 0)
						{
						}
						num = (short)319160325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					break;
				}
				case 3:
					return;
				case 4:
					num = (short)475201545;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
				{
					num = (short)874577920;
					short num4 = num;
					if (operationType == global::System.Data.Linq.ChangeAction.Update)
					{
						num = (short)1840185348;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25D;
				}
				case 6:
					switch (0)
					{
					case 0:
						goto IL_51;
					}
					continue;
				case 7:
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> items = changedItem.Select(new global::System.Func<TV, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(global::Motorola.CommonCPS.RadioManagement.LocalService.SelectMVOViewCache.<>c__1<TV>.<>9.b)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
					base.NotifyModifyOrAddItems(items);
					num = (short)1522663427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 8:
					num = (short)232521735;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (legacyGuidList == null)
					{
						num = (short)598605832;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_25D;
				case 10:
					return;
				}
				IL_51:
				if (!base.IsTypeMatchViewCache(typeof(TV)))
				{
					num = (short)1205338122;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)747307010;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_10A:
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> items2 = changedItem.Select(new global::System.Func<TV, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(global::Motorola.CommonCPS.RadioManagement.LocalService.SelectMVOViewCache.<>c__1<TV>.<>9.a)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			base.NotifyAddItems(items2);
			return;
			IL_25D:
			num = (short)135593985;
			if (num != 0)
			{
			}
			base.ItemChanged<TV>(operationType, changedItem, legacyGuidList, otherParameters);
		}
	}
}
