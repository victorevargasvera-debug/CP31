using System;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.InteractionHelper;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000086 RID: 134
	internal class RegistRadioFeatureGroupChangeCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000352 RID: 850 RVA: 0x00034478 File Offset: 0x00032678
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1378031607;
			short num2 = num;
			num = (short)488183799;
			global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_121:
				registerRadioLicenseContext.SelectedListBoxSelctedItems.Clear();
				registerRadioLicenseContext.AvailableListBoxSelectedItems.Clear();
				registerRadioLicenseContext.SelectedDevices.Clear();
				registerRadioLicenseContext.AvailableDevices.Clear();
				num = (short)1552941064;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)460849153;
				if (num != 0)
				{
				}
				num = (short)730267648;
				if (num != 0)
				{
				}
				num = (short)1024720899;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					return false;
				case 1:
					if (registerRadioLicenseContext == null)
					{
						num = (short)1595998208;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)2055077890;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					if (registerRadioLicenseContext.SelectedDevices.Count > 0)
					{
						num = (short)169017350;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return true;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_BD;
					}
					continue;
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.InteractionHelper.InteractionFactory.GetInstance().ShowConfirmationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_Warning_Radio_Feature_Mismatch, global::Motorola.CommonCPS.ResourceRepository.Resources.RMC_Confirmation))
					{
						num = (short)1202716677;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					return false;
				case 5:
					goto IL_121;
				case 6:
					num = (short)1946681348;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					return false;
				case 8:
					return true;
				}
				IL_BD:
				if (paras.Length == 0)
				{
					num = (short)254214151;
					num3 = (int)((global::System.IntPtr)num);
				}
				else
				{
					registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
					num = (short)1495990272;
					short num4 = num;
					num = (short)1527054337;
					num3 = (int)((global::System.IntPtr)num);
				}
			}
			return false;
		}

		// Token: 0x06000353 RID: 851 RVA: 0x000346AC File Offset: 0x000328AC
		protected override object ExecuteCmd(params object[] paras)
		{
			for (;;)
			{
				IL_00:
				short num = (short)59375616;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext registerRadioLicenseContext;
					int featureType;
					switch (num2)
					{
					case 0:
						switch (0)
						{
						case 0:
							goto IL_54;
						}
						continue;
					case 1:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list;
						if (list.Count > 0)
						{
							num = (short)1710686211;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_243;
					}
					case 2:
						goto IL_266;
					case 3:
					{
						num = (short)1186624685;
						short num3 = num;
						num = (short)1898738861;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num = (short)1268645888;
							if (num != 0)
							{
							}
							registerRadioLicenseContext.NoDeviceWarning = global::Motorola.CommonCPS.ResourceRepository.Resources.Licenses_No_Available_Radio;
							num = (short)1660420100;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 4:
						goto IL_1F5;
					case 5:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list = registerRadioLicenseContext.EIDDetails.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>().Where(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail eidDetail)
						{
							short num5 = (short)294390958;
							short num6 = num5;
							num5 = (short)931204270;
							switch (num6 == num5)
							{
							}
							num5 = (short)1505296385;
							if (num5 != 0)
							{
							}
							num5 = (short)1706950656;
							short num7 = num5;
							num5 = (short)2117009408;
							if (num5 != 0)
							{
							}
							return eidDetail.IsSelected;
						}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail>();
						num = (short)1592918022;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list;
						if (list.Count > 0)
						{
							num = (short)2057895947;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_201;
					}
					case 7:
						num = (short)684982273;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_201;
					case 9:
						if (registerRadioLicenseContext.AvailableDevices.Count == 0)
						{
							num = (short)485031943;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_243;
					case 10:
						goto IL_72;
					case 11:
					{
						num = (short)607584257;
						if (num != 0)
						{
						}
						global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.EIDDetail> list;
						base.LocalService.GetAvailableDevices(registerRadioLicenseContext.AvailableDevices, registerRadioLicenseContext.SelectedGroup.ID, list, featureType);
						num = (short)886308864;
						short num4 = num;
						num = (short)852754440;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_54:
					if (paras.Length < 2)
					{
						num = (short)620822538;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					registerRadioLicenseContext = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.RegisterRadioLicenseContext);
					featureType = (int)paras[1];
					num = (short)1711996933;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_201:
					num = (short)126353417;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_243:
					registerRadioLicenseContext.NoDeviceWarning = string.Empty;
					num = (short)641794050;
					num2 = (int)((global::System.IntPtr)num);
				}
			}
			IL_72:
			return false;
			IL_1F5:
			IL_266:
			return false;
		}
	}
}
