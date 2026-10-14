using System;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000B8 RID: 184
	internal class DeleteGroupCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060003F5 RID: 1013 RVA: 0x0004215C File Offset: 0x0004035C
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1835925508;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::System.Guid? id;
				bool flag;
				switch (num2)
				{
				case 0:
					return false;
				case 1:
					num = (short)190709761;
					if (num != 0)
					{
					}
					flag = (id == null);
					goto IL_BE;
				case 2:
					flag = true;
					goto IL_BE;
				case 3:
					num = (short)1654521856;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
				{
					num = (short)1899478665;
					short num3 = num;
					num = (short)598261385;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C3;
					default:
						num = (short)1009909760;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					}
					break;
				}
				}
				IL_82:
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group group = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.Group;
				if (group == null)
				{
					num = (short)2134507522;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				id = group.ID;
				num = (short)1891827712;
				short num4 = num;
				num = (short)1663631361;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_C3:
				num = (short)424476675;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_BE:
				if (flag)
				{
					goto IL_C3;
				}
				return true;
			}
			return false;
		}

		// Token: 0x060003F6 RID: 1014 RVA: 0x000422C4 File Offset: 0x000404C4
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)825884672;
			short num2 = num;
			num = (short)362201464;
			short num3 = num;
			num = (short)97304952;
			int num4;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_B9:
				num = (short)1181679622;
				num4 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1502412800;
				if (num != 0)
				{
				}
				switch (0)
				{
				case 0:
					goto IL_B0;
				}
				break;
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService groupService;
				global::System.Guid? id;
				switch (num4)
				{
				case 0:
					goto IL_1CC;
				case 1:
					if (groupService.GetRadioCount(group.ID, global::Motorola.CommonCPS.Server.CommonDBConstants.WorkMode.Any, true) <= 0)
					{
						num = (short)1219952644;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_221;
				case 2:
					if (id != null)
					{
						num = (short)585695237;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26E;
				case 3:
					if (group.Children.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.Group>())
					{
						num = (short)470745096;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A1;
				case 4:
					num = (short)1060831235;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 5:
					groupService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService;
					num = (short)1904214017;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					if (group != null)
					{
						num = (short)353632266;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_26E;
				case 7:
					goto IL_269;
				case 8:
					goto IL_221;
				case 9:
					if (!base.Interaction.ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_DeviceGroup_NonEmptyDeviceGroupDeletionConfirmation, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation))
					{
						num = (short)1688403975;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A1;
				case 10:
					id = group.ID;
					num = (short)1005256705;
					if (num != 0)
					{
					}
					num = (short)195166210;
					num4 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_B0;
				IL_1A1:
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService groupService2 = groupService;
				id = group.ID;
				groupService2.DeleteGroup(id.Value);
				num = (short)830013440;
				num4 = (int)((global::System.IntPtr)num);
				continue;
				IL_221:
				num = (short)606273545;
				num4 = (int)((global::System.IntPtr)num);
			}
			IL_1CC:
			goto IL_26E;
			IL_269:
			return false;
			IL_26E:
			return true;
			IL_B0:
			group = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.Group);
			goto IL_B9;
		}
	}
}
