using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x02000082 RID: 130
	public class RadioConversionViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x060003A6 RID: 934 RVA: 0x00055988 File Offset: 0x00053B88
		public RadioConversionViewCache(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider(group, workMode), null, 500)
		{
			this.a = ((group != null) ? group.ID : null);
		}

		// Token: 0x060003A7 RID: 935 RVA: 0x000559C8 File Offset: 0x00053BC8
		public override void ItemChanged<TV>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<TV> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters)
		{
			short num = (short)45744129;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (operationType == global::System.Data.Linq.ChangeAction.Update)
					{
						num = (short)1757544450;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_191;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_3C;
					}
					continue;
				case 2:
					goto IL_9B;
				case 3:
				{
					num = (short)54067200;
					short num3 = num;
					num = (short)563806209;
					if (num != 0)
					{
					}
					if (operationType == global::System.Data.Linq.ChangeAction.Insert)
					{
						num = (short)2117795844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)494862336;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 4:
				{
					num = (short)163870284;
					short num4 = num;
					num = (short)1960539724;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_101;
					default:
						goto IL_D3;
					}
					break;
				}
				case 5:
					return;
				}
				IL_3C:
				if (!base.IsTypeMatchViewCache(typeof(TV)))
				{
					num = (short)1724776453;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_101:
				list = (changedItem as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
				num = (short)132448259;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_9B:
			this.a(list);
			return;
			IL_D3:
			num = (short)1792475136;
			if (num != 0)
			{
			}
			list = this.FilterItemsByTemplateWorkMode(list);
			this.b(list);
			return;
			IL_191:
			base.ItemChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(operationType, list, legacyGuidList, otherParameters);
		}

		// Token: 0x060003A8 RID: 936 RVA: 0x00055B74 File Offset: 0x00053D74
		protected global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> FilterItemsByTemplateWorkMode(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> items)
		{
			short num = (short)1541406721;
			if (num != 0)
			{
			}
			num = (short)1601241092;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					return items;
				case 1:
				{
					num = (short)462608006;
					short num3 = num;
					num = (short)1407768198;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_65;
					default:
					{
						num = (short)997064704;
						if (num != 0)
						{
						}
						num = (short)181403648;
						short num4 = num;
						if (!items.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>())
						{
							num = (short)126550016;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)304939011;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					break;
				}
				case 2:
					num = (short)1849229313;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_13E;
				case 4:
					switch (0)
					{
					case 0:
						goto IL_5F;
					}
					continue;
				}
				goto IL_5F;
				IL_65:
				num = (short)653197314;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_5F:
				if (items != null)
				{
					goto IL_65;
				}
				break;
			}
			return items;
			IL_13E:
			return items.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::a<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>>(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioConversionViewCache.<>c.<>9.a)).Where(new global::System.Func<global::a<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>, bool>(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioConversionViewCache.<>c.<>9.a)).Select(new global::System.Func<global::a<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioConversionViewCache.<>c.<>9.b)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
		}

		// Token: 0x060003A9 RID: 937 RVA: 0x00055D40 File Offset: 0x00053F40
		private void b(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			if (this.a == null)
			{
				short num = (short)216662017;
				if (num != 0)
				{
				}
				num = (short)1864279364;
				short num2 = num;
				num = (short)1485940036;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)222625792;
					if (num != 0)
					{
					}
					num = (short)1028653056;
					short num3 = num;
					break;
				}
				}
				base.NotifyAddItems(A_0);
				return;
			}
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> items = A_0.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(this.c)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			base.NotifyAddItems(items);
		}

		// Token: 0x060003AA RID: 938 RVA: 0x00055E24 File Offset: 0x00054024
		private void a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)1035010050;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)1964900353;
					if (num != 0)
					{
					}
					num = (short)1906370714;
					short num3 = num;
					num = (short)874375322;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_11A;
					case 1:
						goto IL_DD;
					}
					goto Block_2;
				}
				case 1:
					goto IL_132;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_30;
					}
					continue;
				}
				IL_30:
				if (this.a == null)
				{
					num = (short)1845952512;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> items = A_0.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(this.b)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				base.NotifyModifyItems(items);
				IL_11A:
				num = (short)831193089;
				num2 = (int)((global::System.IntPtr)num);
			}
			Block_2:
			num = (short)240975872;
			short num4 = num;
			IL_DD:
			num = (short)47644672;
			if (num != 0)
			{
			}
			base.NotifyModifyItems(A_0);
			return;
			IL_132:
			global::System.Collections.Generic.List<global::System.Guid> ids = A_0.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(this.a)).Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioConversionViewCache.<>c.<>9.b)).ToList<global::System.Guid>();
			base.NotifyRemoveItems(ids);
		}

		// Token: 0x060003AB RID: 939 RVA: 0x00055FAC File Offset: 0x000541AC
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::System.Guid? curentGroupID;
			short num2;
			global::System.Guid? guid;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_66;
				case 1:
					if (curentGroupID == null)
					{
						num2 = (short)499449856;
						short num3 = num2;
						num2 = (short)1269366786;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_148;
				case 2:
					return true;
				case 3:
				{
					if (curentGroupID != null != (guid != null))
					{
						num2 = (short)257687552;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)110696890;
					short num4 = num2;
					num2 = (short)2052331962;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)919666689;
						if (num2 != 0)
						{
						}
						num2 = (short)1681784832;
						if (num2 != 0)
						{
						}
						num2 = (short)2062548993;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_66:
			return false;
			IL_148:
			return curentGroupID.GetValueOrDefault() == guid.GetValueOrDefault();
			IL_20:
			curentGroupID = A_0.CurentGroupID;
			guid = this.a;
			num2 = (short)1125842947;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003AC RID: 940 RVA: 0x00056114 File Offset: 0x00054314
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::System.Guid? curentGroupID;
			short num2;
			global::System.Guid? guid;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_66;
				case 1:
					if (curentGroupID == null)
					{
						num2 = (short)1807155200;
						short num3 = num2;
						num2 = (short)1547042818;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_147;
				case 2:
					return true;
				case 3:
				{
					if (curentGroupID != null != (guid != null))
					{
						num2 = (short)1533739008;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1490681857;
					if (num2 != 0)
					{
					}
					num2 = (short)763426254;
					short num4 = num2;
					num2 = (short)1718810062;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return false;
					default:
						num2 = (short)1162674176;
						if (num2 != 0)
						{
						}
						num2 = (short)936837121;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_66:
			return false;
			IL_147:
			return curentGroupID.GetValueOrDefault() == guid.GetValueOrDefault();
			IL_20:
			curentGroupID = A_0.CurentGroupID;
			guid = this.a;
			num2 = (short)610795523;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x060003AD RID: 941 RVA: 0x0005627C File Offset: 0x0005447C
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			int num;
			global::System.Guid? curentGroupID;
			short num2;
			global::System.Guid? guid;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_68;
				case 1:
					if (curentGroupID == null)
					{
						num2 = (short)1933312000;
						short num3 = num2;
						num2 = (short)792920066;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_148;
				case 2:
					return false;
				case 3:
				{
					if (curentGroupID != null != (guid != null))
					{
						num2 = (short)644415488;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)915802781;
					short num4 = num2;
					num2 = (short)1911687837;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						return true;
					default:
						num2 = (short)853671936;
						if (num2 != 0)
						{
						}
						num2 = (short)1117323265;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				}
				goto IL_20;
			}
			IL_68:
			num2 = (short)947585025;
			if (num2 != 0)
			{
			}
			return true;
			IL_148:
			return curentGroupID.GetValueOrDefault() != guid.GetValueOrDefault();
			IL_20:
			curentGroupID = A_0.CurentGroupID;
			guid = this.a;
			num2 = (short)2091057155;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x040000B2 RID: 178
		private readonly global::System.Guid? a;
	}
}
