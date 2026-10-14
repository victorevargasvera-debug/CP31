using System;
using System.Collections.Generic;
using System.Data.Linq;
using System.Linq;
using System.Runtime.CompilerServices;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.RadioManagement.ViewCache;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x020000B1 RID: 177
	public class RadioViewCache : global::Motorola.CommonCPS.RadioManagement.ViewCache.ViewCache<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
	{
		// Token: 0x06000428 RID: 1064 RVA: 0x0005BBF0 File Offset: 0x00059DF0
		public RadioViewCache(global::Motorola.CommonCPS.RadioManagement.UIModels.Group group, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode workMode) : base(new global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider(group, workMode), null, 500)
		{
			this.a = ((group != null) ? group.ID : null);
		}

		// Token: 0x06000429 RID: 1065 RVA: 0x0005BC30 File Offset: 0x00059E30
		public override void ItemChanged<TV>(global::System.Data.Linq.ChangeAction operationType, global::System.Collections.Generic.List<TV> changedItem, global::System.Collections.Generic.List<global::System.Guid> legacyGuidList = null, params object[] otherParameters)
		{
			short num = (short)1738145794;
			int num2 = (int)((global::System.IntPtr)num);
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_11C;
				case 1:
					if (operationType == global::System.Data.Linq.ChangeAction.Update)
					{
						num = (short)725614599;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1D5;
				case 2:
				{
					num = (short)1625990391;
					short num3 = num;
					num = (short)285713655;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_FF;
					default:
						num = (short)2137128960;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_94;
						}
						continue;
					}
					break;
				}
				case 3:
					goto IL_FF;
				case 4:
					return;
				case 5:
				{
					num = (short)512163840;
					short num4 = num;
					if (operationType == global::System.Data.Linq.ChangeAction.Insert)
					{
						num = (short)1870135302;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)613548033;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 6:
					goto IL_199;
				case 7:
					num = (short)1088094211;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_94:
				if (!base.IsTypeMatchViewCache(typeof(TV)))
				{
					num = (short)1436286977;
					if (num != 0)
					{
					}
					num = (short)599523332;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				list = (changedItem as global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>);
				list = this.FilterItemsByWorkMode(list);
				num = (short)1914699781;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_FF:
				if (legacyGuidList != null)
				{
					goto IL_1D5;
				}
				num = (short)100663296;
				num2 = (int)((global::System.IntPtr)num);
			}
			return;
			IL_11C:
			this.a(list);
			return;
			IL_199:
			this.b(list);
			return;
			IL_1D5:
			base.ItemChanged<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(operationType, list, legacyGuidList, otherParameters);
		}

		// Token: 0x0600042A RID: 1066 RVA: 0x0005BE20 File Offset: 0x0005A020
		protected virtual global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> FilterItemsByWorkMode(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> items)
		{
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_28;
				}
				short num2;
				global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode a;
				for (;;)
				{
					IL_0A:
					int num;
					switch (num)
					{
					case 0:
						return items;
					case 1:
						num2 = (short)1072955395;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 2:
						if (items != null)
						{
							num2 = (short)1545404417;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						return items;
					case 3:
						num2 = (short)2133327873;
						if (num2 != 0)
						{
						}
						if (!items.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>())
						{
							num2 = (short)661389312;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1604452356;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 4:
					{
						num2 = (short)1241186304;
						short num3 = num2;
						a = ((global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ModeIdentifier == global::Motorola.CommonCPS.RadioManagement.Global.ModeIdentifier.Configuration) ? global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Configuration : global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Template);
						num2 = (short)1520435205;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 5:
						goto IL_17B;
					}
					break;
				}
				IL_28:
				num2 = (short)2015587276;
				short num4 = num2;
				num2 = (short)159738828;
				switch ((num4 == num2) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num2 = (short)1775370240;
					if (num2 != 0)
					{
					}
					num2 = (short)589168642;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_0A;
				}
				}
			}
			return items;
			IL_17B:
			return items.Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::a<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>>(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioViewCache.<>c.<>9.a2)).Where(new global::System.Func<global::a<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>, bool>(a2.b)).Select(new global::System.Func<global::a<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary>, global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioViewCache.<>c.<>9.a2)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
		}

		// Token: 0x0600042B RID: 1067 RVA: 0x0005C010 File Offset: 0x0005A210
		private void b(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)2103114964;
			short num2 = num;
			num = (short)826539220;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)58589185;
				if (num != 0)
				{
				}
				num = (short)1770192896;
				if (num != 0)
				{
				}
				num = (short)1735458816;
				short num3 = num;
				if (this.a != null)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> items = A_0.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(this.c)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
					base.NotifyAddItems(items);
					return;
				}
				break;
			}
			}
			base.NotifyAddItems(A_0);
		}

		// Token: 0x0600042C RID: 1068 RVA: 0x0005C0F0 File Offset: 0x0005A2F0
		private void a(global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> A_0)
		{
			short num = (short)588972032;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)62715169;
					short num3 = num;
					num = (short)1100674337;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_F2;
					case 1:
						break;
					default:
					{
						num = (short)928448512;
						short num4 = num;
						break;
					}
					}
					num = (short)667615232;
					if (num != 0)
					{
					}
					switch (0)
					{
					case 0:
						goto IL_AA;
					}
					continue;
				}
				case 1:
					goto IL_133;
				case 2:
					goto IL_F2;
				}
				IL_AA:
				num = (short)1866924033;
				if (num != 0)
				{
				}
				if (this.a == null)
				{
					num = (short)1659895810;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> items = A_0.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(this.b)).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
					base.NotifyModifyOrAddItems(items);
					num = (short)1977286657;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_F2:
			base.NotifyModifyOrAddItems(A_0);
			return;
			IL_133:
			global::System.Collections.Generic.List<global::System.Guid> ids = A_0.Where(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, bool>(this.a)).Select(new global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::System.Guid>(global::Motorola.CommonCPS.RadioManagement.LocalService.RadioViewCache.<>c.<>9.b)).ToList<global::System.Guid>();
			base.NotifyRemoveItems(ids);
		}

		// Token: 0x0600042D RID: 1069 RVA: 0x0005C278 File Offset: 0x0005A478
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool c(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			global::System.Guid? curentGroupID;
			global::System.Guid? guid;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (curentGroupID != null != (guid != null))
					{
						num2 = (short)776732675;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BE;
				case 1:
				{
					num2 = (short)382468096;
					short num3 = num2;
					num2 = (short)1861419009;
					if (num2 != 0)
					{
					}
					if (curentGroupID == null)
					{
						num2 = (short)688324610;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14C;
				}
				case 2:
					return true;
				case 3:
					return false;
				}
				goto IL_20;
			}
			return false;
			IL_14C:
			return curentGroupID.GetValueOrDefault() == guid.GetValueOrDefault();
			IL_20:
			num2 = (short)70125486;
			short num4 = num2;
			num2 = (short)350095278;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BE:
				num2 = (short)1147338753;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1671299072;
				if (num2 != 0)
				{
				}
				curentGroupID = A_0.CurentGroupID;
				guid = this.a;
				num2 = (short)696188928;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600042E RID: 1070 RVA: 0x0005C3E4 File Offset: 0x0005A5E4
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool b(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			global::System.Guid? curentGroupID;
			global::System.Guid? guid;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					if (curentGroupID != null != (guid != null))
					{
						num2 = (short)1932066819;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_BD;
				case 1:
				{
					num2 = (short)1549598720;
					short num3 = num2;
					if (curentGroupID == null)
					{
						num2 = (short)2049572866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14B;
				}
				case 2:
					return true;
				case 3:
					goto IL_B9;
				}
				goto IL_20;
			}
			IL_B9:
			num2 = (short)276627457;
			if (num2 != 0)
			{
			}
			return false;
			IL_14B:
			return curentGroupID.GetValueOrDefault() == guid.GetValueOrDefault();
			IL_20:
			num2 = (short)549706233;
			short num4 = num2;
			num2 = (short)1554897401;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_BD:
				num2 = (short)1825505281;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1611071488;
				if (num2 != 0)
				{
				}
				curentGroupID = A_0.CurentGroupID;
				guid = this.a;
				num2 = (short)868220928;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x0600042F RID: 1071 RVA: 0x0005C550 File Offset: 0x0005A750
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private bool a(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase A_0)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			global::System.Guid? curentGroupID;
			global::System.Guid? guid;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					num2 = (short)41877505;
					if (num2 != 0)
					{
					}
					if (curentGroupID != null != (guid != null))
					{
						num2 = (short)1953955843;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_E5;
				case 1:
					if (curentGroupID == null)
					{
						num2 = (short)2103771138;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_149;
				case 2:
					return false;
				case 3:
					return true;
				}
				goto IL_20;
			}
			return true;
			IL_149:
			return curentGroupID.GetValueOrDefault() != guid.GetValueOrDefault();
			IL_20:
			num2 = (short)1687405779;
			short num3 = num2;
			num2 = (short)1971766483;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_E5:
				num2 = (short)338493440;
				short num4 = num2;
				num2 = (short)2009989121;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			default:
			{
				num2 = (short)1511325696;
				if (num2 != 0)
				{
				}
				curentGroupID = A_0.CurentGroupID;
				guid = this.a;
				num2 = (short)1129840640;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}

		// Token: 0x040000DE RID: 222
		private readonly global::System.Guid? a;

		// Token: 0x020000B2 RID: 178
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000431 RID: 1073 RVA: 0x0005C6D0 File Offset: 0x0005A8D0
			internal bool b(global::a<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase, global::Motorola.CommonCPS.Server.EntityModel.RadioSummary> A_0)
			{
				short num = (short)581327355;
				short num2 = num;
				num = (short)784095739;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)24379393;
					if (num != 0)
					{
					}
					num = (short)1830158336;
					if (num != 0)
					{
					}
					num = (short)1776484352;
					short num3 = num;
					if (A_0.RadioSummary.WorkMode == global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Any)
					{
						return true;
					}
					break;
				}
				}
				return A_0.RadioSummary.WorkMode == this.a;
			}

			// Token: 0x040000DF RID: 223
			public global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode a;
		}
	}
}
