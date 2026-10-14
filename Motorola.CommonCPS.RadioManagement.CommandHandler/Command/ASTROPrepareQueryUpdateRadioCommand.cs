using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000040 RID: 64
	public class ASTROPrepareQueryUpdateRadioCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000266 RID: 614 RVA: 0x00020908 File Offset: 0x0001EB08
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_1C;
			}
			int num;
			short num2;
			bool result;
			global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					goto IL_9C;
				case 1:
					if (base.UIValidateService is global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService)
					{
						num2 = (short)1240203266;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 2:
					result = (base.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService).CanQueryUpdateRadio(selectedItems);
					num2 = (short)798556160;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_1C;
			}
			IL_9C:
			num2 = (short)1205995050;
			short num3 = num2;
			num2 = (short)905709098;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num2 = (short)330366977;
				if (num2 != 0)
				{
				}
				num2 = (short)528285696;
				if (num2 != 0)
				{
				}
				num2 = (short)301334528;
				short num4 = num2;
				break;
			}
			}
			return result;
			IL_1C:
			result = false;
			selectedItems = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
			global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService localService = base.LocalService;
			num2 = (short)347144193;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000267 RID: 615 RVA: 0x00020A50 File Offset: 0x0001EC50
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)2010316800;
			switch (num)
			{
			default:
			{
				num = (short)1820262400;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext updateRadioContext;
				for (;;)
				{
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_58;
						}
						continue;
					case 1:
					{
						object result;
						try
						{
							global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService;
							iastrolocalService.InitialQueryUpdateRadio(updateRadioContext);
							goto IL_128;
						}
						catch (global::Motorola.Common.CustomException.CommonException ex)
						{
							base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.ResourceHelper.GetCommonErrorMessageByID(ex.ErrorCode.ToString(), null), global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Error);
							result = null;
						}
						return result;
						IL_128:
						num = (short)204998444;
						short num3 = num;
						num = (short)1568999212;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_D6;
						default:
							goto IL_15E;
						}
						break;
					}
					case 2:
						num = (short)733347844;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_F8;
					case 4:
						goto IL_D6;
					}
					IL_58:
					if (paras != null)
					{
						num = (short)1850867714;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1A8;
					IL_D6:
					if (paras.Count<object>() <= 0)
					{
						num = (short)199622659;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> toUpdateRadioList = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService = base.LocalService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService;
						updateRadioContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext();
						updateRadioContext.ToUpdateRadioList = toUpdateRadioList;
						num = (short)1443823617;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_F8:
				num = (short)591790080;
				short num4 = num;
				goto IL_1A8;
				IL_15E:
				num = (short)1551302657;
				if (num != 0)
				{
				}
				num = (short)1273495552;
				if (num != 0)
				{
				}
				base.Interaction.ShowUpdateRadio(updateRadioContext);
				return null;
				IL_1A8:
				throw new global::System.ArgumentNullException();
			}
			}
		}
	}
}
