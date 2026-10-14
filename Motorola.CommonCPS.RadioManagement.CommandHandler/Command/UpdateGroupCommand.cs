using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000036 RID: 54
	internal class UpdateGroupCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000237 RID: 567 RVA: 0x0001D5B0 File Offset: 0x0001B7B0
		protected override object ExecuteCmd(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_20;
			}
			short num2;
			string empty;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
				{
					num2 = (short)1585184768;
					short num3 = num2;
					global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
					if (group == null)
					{
						num2 = (short)2126381057;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					empty = string.Empty;
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService groupService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService;
					num2 = (short)1835859971;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 1:
					goto IL_CC;
				case 2:
					goto IL_135;
				case 3:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
					global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService groupService;
					if (!groupService.ValidateGroupName(group, group.Name, out empty))
					{
						num2 = (short)1320353794;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_165;
				}
				}
				goto IL_20;
			}
			IL_CC:
			return null;
			IL_135:
			num2 = (short)1698365441;
			if (num2 != 0)
			{
			}
			base.Interaction.ShowNotificationDialog(empty, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
			return null;
			IL_20:
			num2 = (short)1714253305;
			short num4 = num2;
			num2 = (short)832859641;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_165:
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
				global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService groupService;
				group.Timestamp = groupService.UpdatedGroup(group);
				return group;
			}
			default:
			{
				num2 = (short)180682752;
				if (num2 != 0)
				{
				}
				global::Motorola.CommonCPS.RadioManagement.UIModels.Group group = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.Group;
				num2 = (short)165150720;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
		}
	}
}
