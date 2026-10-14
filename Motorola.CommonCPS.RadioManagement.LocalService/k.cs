using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000095 RID: 149
	internal class k : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>
	{
		// Token: 0x060003DC RID: 988 RVA: 0x00058494 File Offset: 0x00056694
		public k(bool? A_0 = null) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.l(A_0), null, 500)
		{
			this.a = A_0;
		}

		// Token: 0x060003DD RID: 989 RVA: 0x000584BC File Offset: 0x000566BC
		public override void ItemChanged<TV>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<TV> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters)
		{
			short num = (short)1090912261;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (changedItem == null)
					{
						num = (short)1979187202;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2818049;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
					if (this.a == null)
					{
						num = (short)1891303427;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)944963585;
					if (num != 0)
					{
					}
					num = (short)1611923462;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					base.ItemChanged<TV>(operationType, changedItem, legacyGuidList, otherParameters);
					num = (short)2144468999;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_1C8;
				case 4:
					return;
				case 5:
				{
					num = (short)43153062;
					short num3 = num;
					num = (short)660305574;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
					{
						num = (short)319815680;
						if (num != 0)
						{
						}
						num = (short)1175650304;
						short num4 = num;
						switch (0)
						{
						case 0:
							goto IL_BC;
						}
						continue;
					}
					}
					break;
				}
				case 6:
					goto IL_133;
				case 7:
					return;
				}
				IL_BC:
				if (!base.IsTypeMatchViewCache(typeof(TV)))
				{
					num = (short)353697796;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)729219072;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			return;
			IL_133:
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> changedItem2 = changedItem.Select(new global::System.Func<TV, global::b<TV, global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>>(global::Motorola.CommonCPS.RadioManagement.LocalService.k.<>c__2<TV>.<>9.a)).Where(new global::System.Func<global::b<TV, global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>, bool>(this.a<TV>)).Select(new global::System.Func<global::b<TV, global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>, global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(global::Motorola.CommonCPS.RadioManagement.LocalService.k.<>c__2<TV>.<>9.a)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>();
			base.ItemChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer>(operationType, changedItem2, legacyGuidList, otherParameters);
			return;
			IL_1C8:
			base.ItemChanged<TV>(operationType, changedItem, legacyGuidList, otherParameters);
		}

		// Token: 0x060003DE RID: 990 RVA: 0x00058718 File Offset: 0x00056918
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a<a>(global::b<a, global::Motorola.CommonCPS.RadioManagement.UIModels.JobContainer> A_0) where a : global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase
		{
			if (A_0.jobContainer == null)
			{
				short num = (short)1978687536;
				short num2 = num;
				num = (short)2009030704;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)639107073;
					if (num != 0)
					{
					}
					num = (short)473497600;
					short num3 = num;
					num = (short)249888768;
					if (num != 0)
					{
					}
					return false;
				}
				}
			}
			bool forReadWrite = A_0.jobContainer.ForReadWrite;
			bool? flag = this.a;
			return forReadWrite == flag.GetValueOrDefault() & flag != null;
		}

		// Token: 0x040000C2 RID: 194
		private readonly bool? a;
	}
}
