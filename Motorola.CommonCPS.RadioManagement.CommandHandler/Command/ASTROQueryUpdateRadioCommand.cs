using System;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.BatchOp;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200003F RID: 63
	internal class ASTROQueryUpdateRadioCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000263 RID: 611 RVA: 0x00020564 File Offset: 0x0001E764
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			bool result;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
					num2 = (short)896925698;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 1:
				{
					num2 = (short)396131842;
					short num3 = num2;
					num2 = (short)516455938;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_CA;
					case 1:
						break;
					default:
					{
						num2 = (short)1036255232;
						short num4 = num2;
						break;
					}
					}
					num2 = (short)1190920192;
					if (num2 != 0)
					{
					}
					result = ((paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext).SelectSystemKeyData.SystemID != 0);
					num2 = (short)499777540;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				case 2:
					goto IL_CA;
				case 3:
					num2 = (short)432865281;
					if (num2 != 0)
					{
					}
					if (paras != null)
					{
						num2 = (short)650248192;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 4:
					return result;
				}
				goto IL_24;
				IL_CA:
				if (paras.Length == 0)
				{
					break;
				}
				num2 = (short)360906753;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_24:
			result = false;
			num2 = (short)774176771;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000264 RID: 612 RVA: 0x000206D8 File Offset: 0x0001E8D8
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)28311553;
			if (num != 0)
			{
			}
			num = (short)1244921862;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
				{
					num = (short)517306276;
					short num3 = num;
					num = (short)1098479524;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_C3;
					default:
						goto IL_17C;
					}
					break;
				}
				case 1:
					goto IL_B5;
				case 2:
					base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Warning_ServerData_Changed, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					num = (short)326762497;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					goto IL_205;
				case 4:
				{
					if (paras.Count<object>() <= 0)
					{
						num = (short)555876352;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext updateRadioContext = paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext;
					goto IL_C3;
				}
				case 5:
					num = (short)1588264964;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					continue;
				case 7:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.UpdateRadioContext updateRadioContext;
					if (!(base.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService).CanQueryUpdateRadio(updateRadioContext.ToUpdateRadioList))
					{
						num = (short)1155006466;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.BatchOp.UpdateRadioBatchOp op = new global::Motorola.CommonCPS.RadioManagement.BatchOp.UpdateRadioBatchOp(updateRadioContext.ToUpdateRadioList, updateRadioContext.SelectSystemKeyData.SystemID, updateRadioContext.SelectedkeyType, updateRadioContext.WriteProtect, updateRadioContext.AttachedKeys);
					base.ExecuteBatchOp<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(op);
					num = (short)1419509763;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				}
				IL_6C:
				if (paras != null)
				{
					num = (short)1727397893;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_207;
				IL_C3:
				num = (short)1092419591;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_B5:
			goto IL_20D;
			IL_17C:
			num = (short)1448017920;
			if (num != 0)
			{
			}
			num = (short)1764818944;
			short num4 = num;
			goto IL_207;
			IL_205:
			goto IL_20D;
			IL_207:
			throw new global::System.ArgumentNullException();
			IL_20D:
			return null;
		}
	}
}
