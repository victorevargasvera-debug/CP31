using System;
using System.Collections.Generic;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;
using Motorola.CommonCPS.Server.EntityModel;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000058 RID: 88
	public class ModifyCodeplugPasswordCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x060002D6 RID: 726 RVA: 0x0002A380 File Offset: 0x00028580
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)828243972;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext modifyCodeplugPasswordContext;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_17B;
				case 1:
					return true;
				case 2:
					if (paras.Length == 0)
					{
						num = (short)10551296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					modifyCodeplugPasswordContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext);
					num = (short)243138567;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					num = (short)1679225010;
					short num3 = num;
					num = (short)2138108082;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_196;
					default:
						goto IL_102;
					}
					break;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_4D;
					}
					continue;
				case 5:
					num = (short)596377602;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_196;
				case 7:
					if (!modifyCodeplugPasswordContext.ContextIsChanged)
					{
						num = (short)1917190152;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)984088585;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					return false;
				case 9:
					if (!modifyCodeplugPasswordContext.IsPasswordCorrect)
					{
						num = (short)1887436801;
						if (num != 0)
						{
						}
						num = (short)1209335811;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1112145926;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_4D:
				if (paras != null)
				{
					num = (short)902955013;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				return false;
				IL_196:
				if (modifyCodeplugPasswordContext.PasswordPerDevice)
				{
					goto IL_1FE;
				}
				num = (short)1540227073;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_102:
			num = (short)341901312;
			if (num != 0)
			{
			}
			num = (short)1635123200;
			short num4 = num;
			return false;
			IL_17B:
			return false;
			IL_1FE:
			return string.IsNullOrEmpty(modifyCodeplugPasswordContext.NewRadioPasswordError);
		}

		// Token: 0x060002D7 RID: 727 RVA: 0x0002A598 File Offset: 0x00028798
		protected override object ExecuteCmd(params object[] paras)
		{
			object obj = paras[0];
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radio = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext).Radio;
			string text;
			short num;
			if (!base.UIValidateService.ValidateNewRadio(radio, out text))
			{
				num = (short)348556472;
				short num2 = num;
				num = (short)190090424;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					goto IL_9C;
				case 1:
					break;
				default:
				{
					num = (short)1604386816;
					short num3 = num;
					break;
				}
				}
				num = (short)830930944;
				if (num != 0)
				{
				}
				IL_9C:
				base.Interaction.ShowNotificationDialog(text, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
				return text;
			}
			num = (short)556204033;
			if (num != 0)
			{
			}
			return null;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x0002A680 File Offset: 0x00028880
		protected object UpdatePassword(global::Motorola.CommonCPS.RadioManagement.UIModels.ModifyCodeplugPasswordContext modifyInfo, global::Motorola.CommonCPS.Server.EntityModel.PasswordInfo pwdInfo)
		{
			short num = (short)253231105;
			if (num != 0)
			{
			}
			num = (short)544415162;
			short num2 = num;
			num = (short)1430592954;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1652817920;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1018757120;
			if (num != 0)
			{
			}
			global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet validateEntitySet = new global::Motorola.CommonCPS.Server.EntityModel.ValidateEntitySet();
			validateEntitySet.RelatedObject = new global::System.Guid?(modifyInfo.ID.Value);
			validateEntitySet.ValidateEntityList.Add(new global::Motorola.CommonCPS.Server.EntityModel.ValidatedField(modifyInfo.ID.Value, global::Motorola.CommonCPS.Server.CommonDBConstants.ValidateFieldType.Radio, modifyInfo.Radio.RadioTimestamp));
			global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase radioBase = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.RadioService.UpdateCodeplugPassword(pwdInfo, validateEntitySet).ToUiModel(true);
			base.ViewCacheNotifier.NotifyViewCacheAddItems<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>
			{
				radioBase
			});
			return radioBase;
		}
	}
}
