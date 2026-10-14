using System;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000079 RID: 121
	internal class ClearAllCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600032F RID: 815 RVA: 0x00031158 File Offset: 0x0002F358
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1178402823;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
				switch (num2)
				{
				case 0:
					if (registerRadioLicenseContext.EIDDetails.Count == 0)
					{
						num = (short)685113355;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 1:
					return false;
				case 2:
					if (registerRadioLicenseContext.AvailableDevices.Count == 0)
					{
						num = (short)1308950533;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					goto IL_75;
				case 4:
					goto IL_1AA;
				case 5:
					num = (short)194707465;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					return false;
				case 7:
					switch (0)
					{
					case 0:
						goto IL_54;
					}
					continue;
				case 8:
					if (registerRadioLicenseContext == null)
					{
						num = (short)523763712;
						short num3 = num;
						num = (short)1132593156;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)116523010;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					if (registerRadioLicenseContext.SelectedDevices.Count == 0)
					{
						num = (short)106102787;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 10:
					if (string.IsNullOrEmpty(registerRadioLicenseContext.EIDString))
					{
						num = (short)349700097;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 11:
					num = (short)1729167370;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_54:
				if (paras.Length == 0)
				{
					num = (short)1364000774;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
				num = (short)884761420;
				short num4 = num;
				num = (short)142566220;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1314193408;
					if (num != 0)
					{
					}
					num = (short)266076168;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_75:
				num = (short)1655767040;
				num2 = (int)((global::System.IntPtr)num);
			}
			return false;
			IL_1AA:
			num = (short)336396289;
			if (num != 0)
			{
			}
			return false;
		}

		// Token: 0x06000330 RID: 816 RVA: 0x000313C8 File Offset: 0x0002F5C8
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1883701251;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (registerRadioLicenseContext.SelectedDevices.Count > 0)
					{
						num = (short)1309933573;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CB;
				case 1:
					goto IL_60;
				case 2:
					if (registerRadioLicenseContext == null)
					{
						num = (short)475660294;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1234894848;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_45;
					}
					continue;
				case 4:
					goto IL_A6;
				case 5:
					num = (short)1647640583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 6:
					goto IL_185;
				case 7:
					if (!global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Warning_ClearAll, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation))
					{
						num = (short)1454309380;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1CB;
				}
				IL_45:
				if (paras.Length == 0)
				{
					num = (short)1194721281;
					num2 = (int)((global::System.IntPtr)num);
				}
				else
				{
					registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
					num = (short)569245698;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_60:
			goto IL_AA;
			IL_A6:
			num = (short)732130693;
			short num3 = num;
			num = (short)1059351941;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_AA:
				return null;
			default:
			{
				num = (short)2092957697;
				if (num != 0)
				{
				}
				num = (short)589627392;
				if (num != 0)
				{
				}
				num = (short)1916207104;
				short num4 = num;
				return null;
			}
			}
			IL_185:
			return null;
			IL_1CB:
			registerRadioLicenseContext.SelectedListBoxSelctedItems.Clear();
			registerRadioLicenseContext.AvailableListBoxSelectedItems.Clear();
			registerRadioLicenseContext.AvailableDevices.Clear();
			registerRadioLicenseContext.SelectedDevices.Clear();
			registerRadioLicenseContext.EIDHistory.Clear();
			registerRadioLicenseContext.EIDDetails.Clear();
			registerRadioLicenseContext.SelectChangeSource = null;
			registerRadioLicenseContext.EIDString = string.Empty;
			registerRadioLicenseContext.NoDeviceWarning = string.Empty;
			return null;
		}
	}
}
