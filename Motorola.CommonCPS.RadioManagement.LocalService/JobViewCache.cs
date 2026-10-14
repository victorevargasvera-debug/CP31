using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000098 RID: 152
	public class JobViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>
	{
		// Token: 0x060003E7 RID: 999 RVA: 0x00058D9C File Offset: 0x00056F9C
		public JobViewCache(global::Motorola.CommonCPS.Server.EntityModel.JobContainerSummary jbc) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.m(jbc), null, 500)
		{
			this.a = jbc.Uuid;
		}

		// Token: 0x060003E8 RID: 1000 RVA: 0x00058DC8 File Offset: 0x00056FC8
		public override void ItemChanged<V>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<V> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters)
		{
			short num = (short)764215298;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				IL_1F:
				switch (num2)
				{
				case 0:
				{
					num = (short)15925248;
					short num3 = num;
					num = (short)1850802179;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 1:
					while (operationType == global::System.Data.Linq.ChangeAction.Insert)
					{
						num = (short)30682984;
						short num4 = num;
						num = (short)1832791912;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)1180565504;
							if (num != 0)
							{
							}
							num = (short)1248329728;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1F;
						}
					}
					goto IL_170;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_39;
					}
					continue;
				case 3:
					goto IL_123;
				case 4:
					return;
				}
				IL_39:
				if (!base.IsTypeMatchViewCache(typeof(V)))
				{
					num = (short)1813970948;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)350617601;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_123:
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase> items = changedItem.Select(new global::System.Func<V, global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>(global::Motorola.CommonCPS.RadioManagement.LocalService.JobViewCache.<>c__2<V>.<>9.a)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>().Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase, bool>(this.a<V>)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase>();
			base.NotifyAddItems(items);
			return;
			IL_170:
			num = (short)1563492353;
			if (num != 0)
			{
			}
			base.ItemChanged<V>(operationType, changedItem, legacyGuidList, otherParameters);
		}

		// Token: 0x060003E9 RID: 1001 RVA: 0x00058F78 File Offset: 0x00057178
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a<a>(global::Motorola.CommonCPS.RadioManagement.UIModels.JobBase A_0) where a : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			short num2;
			global::System.Guid? jobContainerSummaryUUID;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_113;
				case 1:
				{
					num2 = (short)152906392;
					short num3 = num2;
					num2 = (short)188295832;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_68;
					default:
						num2 = (short)2076180480;
						if (num2 != 0)
						{
						}
						if (jobContainerSummaryUUID == null)
						{
							num2 = (short)1197801472;
							short num4 = num2;
							num2 = (short)660144128;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_142;
					}
					break;
				}
				case 2:
					if (jobContainerSummaryUUID == null)
					{
						num2 = (short)1695481859;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_68;
				case 3:
					return false;
				}
				goto IL_20;
				IL_68:
				num2 = (short)1694171137;
				num = (int)((global::System.IntPtr)num2);
			}
			return false;
			IL_113:
			num2 = (short)934739969;
			if (num2 != 0)
			{
			}
			return true;
			IL_142:
			global::System.Guid b;
			return jobContainerSummaryUUID.GetValueOrDefault() == b;
			IL_20:
			jobContainerSummaryUUID = A_0.JobContainerSummaryUUID;
			b = this.a;
			num2 = (short)679149570;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000C7 RID: 199
		private global::System.Guid a;
	}
}
