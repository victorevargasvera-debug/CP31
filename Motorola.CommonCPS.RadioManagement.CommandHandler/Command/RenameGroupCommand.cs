using System;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000BC RID: 188
	internal class RenameGroupCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000400 RID: 1024 RVA: 0x000432AC File Offset: 0x000414AC
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1557135360;
			short num2 = num;
			num = (short)1186701707;
			short num3 = num;
			num = (short)1568907659;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)289210369;
				if (num != 0)
				{
				}
				num = (short)242417664;
				if (num != 0)
				{
				}
				num = (short)1689649152;
				int num4 = (int)num;
				switch (num4)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_D7;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.Group group;
					for (;;)
					{
						IL_C4:
						string text;
						switch (num4)
						{
						case 0:
							if (group == null)
							{
								num = (short)825491458;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1F8;
						case 1:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_138;
								}
								global::Motorola.CommonCPS.RadioManagement.SharedServices.IGroupService groupService;
								string empty;
								object result;
								for (;;)
								{
									IL_121:
									switch (num4)
									{
									case 0:
										if (!groupService.ValidateGroupName(group, text, out empty))
										{
											num = (short)1782841345;
											num4 = (int)((global::System.IntPtr)num);
											continue;
										}
										group.Name = text;
										group.Timestamp = groupService.UpdatedGroup(group);
										result = true;
										num = (short)881000450;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										base.Interaction.ShowNotificationDialog(empty, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
										result = false;
										num = (short)1175584771;
										num4 = (int)((global::System.IntPtr)num);
										continue;
									case 2:
										goto IL_1EB;
									case 3:
										goto IL_1B5;
									}
									goto IL_138;
								}
								IL_1B5:
								IL_1EB:
								return result;
								IL_138:
								empty = string.Empty;
								groupService = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.GroupService;
								num = (short)486211584;
								num4 = (int)((global::System.IntPtr)num);
								goto IL_121;
							}
							catch
							{
								return false;
							}
							goto IL_1F8;
						case 2:
							goto IL_112;
						}
						goto IL_D7;
						IL_1F8:
						text = (paras[1] as string);
						num = (short)167182337;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_112:
					break;
					IL_D7:
					group = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.Group);
					num = (short)616169472;
					num4 = (int)((global::System.IntPtr)num);
					goto IL_C4;
				}
				}
				break;
			}
			}
			return false;
		}
	}
}
