using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000054 RID: 84
	public class ASTROPrepareModifyCodeplugPasswordCommand : global::Motorola.CommonCPS.RadioManagement.Command.PrepareModifyCodeplugPasswordCommand
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x00029200 File Offset: 0x00027400
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)980746240;
			switch (num)
			{
			default:
			{
				num = (short)822607879;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RadioDetails radioDetails;
					global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROModifyCodeplugPasswordContext astromodifyCodeplugPasswordContext;
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> list;
					global::System.Collections.Generic.IEnumerable<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> source;
					global::System.Func<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio, global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio> selector;
					switch (num2)
					{
					case 0:
						if (radioDetails == null)
						{
							num = (short)141033477;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						astromodifyCodeplugPasswordContext.RadioPassword = (radioDetails.Radio as global::Motorola.CommonCPS.Server.EntityModel.APXRadio).ReadPassword;
						astromodifyCodeplugPasswordContext.Radio = list[0];
						num = (short)288423938;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_299;
					case 2:
					{
						num = (short)586462889;
						short num3 = num;
						num = (short)199145129;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_32;
						default:
							num = (short)360972288;
							if (num != 0)
							{
							}
							if (list[0].PasswordPerDevice)
							{
								num = (short)1658585096;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_299;
						}
						break;
					}
					case 3:
						num = (short)178651145;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						source = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>();
						if ((selector = global::Motorola.CommonCPS.RadioManagement.Command.ASTROPrepareModifyCodeplugPasswordCommand.<>c.<>9__0_0) == null)
						{
							goto IL_34E;
						}
						goto IL_3A2;
					case 5:
						goto IL_39D;
					case 6:
						try
						{
							radioDetails = (global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceProxy.GetInstance().LocalService as global::Motorola.CommonCPS.RadioManagement.LocalService.ASTROLocalService).GetRadioDetailsBySerialNumber(list[0].SerialNumber);
							goto IL_367;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							if (ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.SERVER_DEVICE_NOT_FOUND || ex.ErrorCode == global::Motorola.Common.CustomException.CommonErrorCode.RMC_Local_Data_Outof_Date)
							{
								base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Device_Deleted_By_Other_User_Refresh_Try_Again, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
							}
							goto IL_367;
						}
						goto IL_34E;
						IL_367:
						num = (short)1776812032;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						goto IL_32;
					case 8:
					{
						num = (short)1535508480;
						short num4 = num;
						astromodifyCodeplugPasswordContext.AstroReadPasswordEnabled = ((list[0].PasswordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Read) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None);
						astromodifyCodeplugPasswordContext.AstroWritePasswordEnabled = ((list[0].PasswordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Write) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None);
						astromodifyCodeplugPasswordContext.AstroOpenFilePasswordEnabled = ((list[0].PasswordPolicy & global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.Open) > global::Motorola.CommonCPS.Server.CommonDBConstants.ASTROPasswordPolicy.None);
						astromodifyCodeplugPasswordContext.NewRadioPassword = list[0].CodeplugPassword;
						num = (short)1755578369;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						num = (short)817954817;
						if (num != 0)
						{
						}
						if (paras.Length != 0)
						{
							num = (short)587857930;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_3CE;
					case 10:
						astromodifyCodeplugPasswordContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTROModifyCodeplugPasswordContext
						{
							Radio = new global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio()
						};
						num = (short)650051588;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 11:
						goto IL_2EC;
					}
					goto IL_73;
					IL_32:
					switch (0)
					{
					case 0:
						IL_73:
						if (paras == null)
						{
							goto IL_3CE;
						}
						num = (short)1769475;
						num2 = (int)((global::System.IntPtr)num);
						break;
					}
					continue;
					IL_299:
					astromodifyCodeplugPasswordContext.PasswordPerDevice = list[0].PasswordPerDevice;
					astromodifyCodeplugPasswordContext.ID = list[0].ID;
					astromodifyCodeplugPasswordContext.Validator = this.CreateContextValidator();
					global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowModifyCodeplugPasswordDialog(astromodifyCodeplugPasswordContext);
					num = (short)1735196683;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3A2:
					list = source.Select(selector).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio>();
					radioDetails = null;
					num = (short)615120902;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_34E:
					selector = (global::Motorola.CommonCPS.RadioManagement.Command.ASTROPrepareModifyCodeplugPasswordCommand.<>c.<>9__0_0 = delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio d)
					{
						short num5 = (short)1445068801;
						if (num5 != 0)
						{
						}
						num5 = (short)778108928;
						short num6 = num5;
						num5 = (short)984441454;
						short num7 = num5;
						num5 = (short)1643668078;
						switch (num7 == num5)
						{
						}
						num5 = (short)1035927552;
						if (num5 != 0)
						{
						}
						return d.Clone() as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio;
					});
					goto IL_3A2;
				}
				IL_2EC:
				return true;
				IL_39D:
				return false;
				IL_3CE:
				return false;
			}
			}
		}

		// Token: 0x060002CA RID: 714 RVA: 0x000295F4 File Offset: 0x000277F4
		protected virtual global::Motorola.CommonCPS.RadioManagement.LocalService.ModifyPasswrodContextValidator CreateContextValidator()
		{
			short num = (short)878739635;
			short num2 = num;
			num = (short)519798963;
			switch (num2 == num)
			{
			default:
			{
				num = (short)344719360;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)732561408;
			if (num != 0)
			{
			}
			num = (short)415694849;
			if (num != 0)
			{
			}
			return new global::Motorola.CommonCPS.RadioManagement.LocalService.ModifyPasswrodContextValidator();
		}
	}
}
