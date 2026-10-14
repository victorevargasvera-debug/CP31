using System;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using ASK.Interface;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;
using Motorola.CommonCPS.Server.CommonDBConstants;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000047 RID: 71
	public class AstroPrepareFlashPortCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600027E RID: 638 RVA: 0x000222FC File Offset: 0x000204FC
		public override bool CanExecute(params object[] paras)
		{
			short num = (short)1745374388;
			short num2 = num;
			num = (short)745819316;
			bool result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)859570176;
				if (num != 0)
				{
				}
				num = (short)1223557120;
				short num3 = num;
				result = true;
				global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
				try
				{
					global::Motorola.CommonCPS.RadioManagement.LocalService.ILocalService localService = base.LocalService;
					result = (base.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService).CanFlashPort(selectedItems);
				}
				catch
				{
					result = false;
				}
				break;
			}
			}
			num = (short)1244659713;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x0600027F RID: 639 RVA: 0x000223EC File Offset: 0x000205EC
		protected override object ExecuteCmd(params object[] paras)
		{
			int a_ = 1;
			short num = (short)1511718912;
			switch (num)
			{
			default:
			{
				num = (short)1041760283;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> list;
					global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
					global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService iastrolocalService;
					string modelNumber;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> list2;
					string text2;
					global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> list3;
					global::System.Collections.Generic.List<string> supportedCodelugVersion;
					string maximumCpWorkingVer;
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily? productFamily2;
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily;
					global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily productFamily3;
					switch (num2)
					{
					case 0:
						if (list.Count > 0)
						{
							num = (short)839254019;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 1:
						num = (short)1087242264;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						string flashcode;
						selectFirmwareContext.IsASKDialogVisible = (iastrolocalService.AstroCheckAskEnable(flashcode, modelNumber) && !iastrolocalService.AstroCheckAskEnable((list2[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.ASTRORadio).AstroPurchasedFlashCode, modelNumber));
						num = (short)1472528407;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 3:
						selectFirmwareContext.FirmwaresForMaxCodeplugVersion = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(list);
						selectFirmwareContext.Firmwares = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(list);
						selectFirmwareContext.SelectedFirmware = selectFirmwareContext.Firmwares[0];
						selectFirmwareContext.Validator = new global::Motorola.CommonCPS.RadioManagement.LocalService.SelectFirmwareContextValidator();
						base.Interaction.ShowSelectFirmwareDialog(selectFirmwareContext);
						num = (short)1493237785;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
					{
						string text;
						if (!base.Interaction.ShowConfirmationDialog(text, global::Motorola.CommonCPS.ResourceRepository.Resources.MessageBox_Title_Confirm))
						{
							goto IL_209;
						}
						goto IL_10F;
					}
					case 5:
						goto IL_4B9;
					case 6:
						list3 = iastrolocalService.LoadAvailableFWPackagesForAMPUpgrade(list2, false, text2).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>();
						goto IL_3E6;
					case 7:
						list3 = iastrolocalService.LoadAvailableFWPackagesForASTROUpgrade(list2, false, text2).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>();
						goto IL_3E6;
					case 8:
					{
						global::System.Collections.ObjectModel.ObservableCollection<global::ASK.Interface.ISystemKeyData> loadedASKWithoutDefault = global::Motorola.CommonCPS.RadioManagement.SharedServices.ServiceContainer.Instance.DeviceOperation.GetLoadedASKWithoutDefault(false);
						selectFirmwareContext.SystemIDs = loadedASKWithoutDefault;
						num = (short)1785331726;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 9:
						text2 = supportedCodelugVersion[0];
						selectFirmwareContext.MaxCodeplugVersion = text2;
						supportedCodelugVersion.Insert(0, global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("돱飳臵駷菹迻\udefd泿持瀃挅笇縉Ⰻ砍甏怑朓缕眗琙", a_));
						selectFirmwareContext.Codeplugs = new global::System.Collections.ObjectModel.ObservableCollection<string>(supportedCodelugVersion);
						selectFirmwareContext.SelectedCodeplug = supportedCodelugVersion.First<string>();
						num = (short)1847656453;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_2BC;
					case 11:
					{
						if (paras.Length == 0)
						{
							num = (short)1306787856;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						list2 = ((global::System.Collections.ICollection)paras[0]).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
						maximumCpWorkingVer = global::Motorola.CommonCPS.RadioManagement.LocalService.LocalServiceUtility.GetMaximumCpWorkingVer(list2);
						iastrolocalService = (global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROLocalService)base.LocalService;
						string flashcode;
						string text;
						iastrolocalService.CheckDevicesIsMatchFlashKey(list2, out flashcode, out text);
						num = (short)504168474;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						num = (short)1261174814;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 13:
						num = (short)1006370816;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 14:
						goto IL_396;
					case 15:
						if (supportedCodelugVersion != null)
						{
							num = (short)1264254988;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B9;
					case 16:
						goto IL_5A5;
					case 17:
						productFamily = productFamily2.Value;
						goto IL_559;
					case 18:
						goto IL_222;
					case 19:
						if (list != null)
						{
							num = (short)2036072448;
							short num3 = num;
							num = (short)1362034701;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_28F;
					case 20:
					{
						num = (short)1780632542;
						short num4 = num;
						num = (short)1386695646;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_209;
						default:
							num = (short)1216217088;
							if (num != 0)
							{
							}
							num = (short)1519910916;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 21:
						if (productFamily3 != global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.AMP)
						{
							num = (short)1978400796;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1515651078;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 22:
						num = (short)43122699;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 23:
						if (selectFirmwareContext.IsASKDialogVisible)
						{
							num = (short)623378440;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_396;
					case 24:
						productFamily = global::Motorola.CommonCPS.Server.CommonDBConstants.ProductFamily.APX;
						goto IL_559;
					case 25:
						goto IL_4B2;
					case 26:
					{
						string text;
						if (!string.IsNullOrEmpty(text))
						{
							num = (short)2099511316;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_10F;
					}
					case 27:
						switch (0)
						{
						case 0:
							goto IL_CD;
						}
						continue;
					case 28:
						num = (short)2087649281;
						if (num != 0)
						{
						}
						num = (short)443023367;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 29:
						if (productFamily2 == null)
						{
							num = (short)1940062209;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						productFamily2 = list2[0].ProductFamily;
						num = (short)279707665;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 30:
						if (supportedCodelugVersion.Count > 0)
						{
							num = (short)940376073;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_4B9;
					case 31:
						goto IL_5BE;
					}
					IL_CD:
					if (paras != null)
					{
						num = (short)1816068118;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_5A5;
					IL_10F:
					selectFirmwareContext = new global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext
					{
						IsRefresh = false,
						Radios = new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>(list2)
					};
					modelNumber = list2[0].ModelNumber;
					num = (short)2143420418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_209:
					num = (short)1748041746;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_28F:
					base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Waring_NoCompatiblePackage, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
					num = (short)2070609930;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_396:
					productFamily2 = list2[0].ProductFamily;
					num = (short)1031929885;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_3E6:
					list = list3;
					num = (short)1581121555;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_4B9:
					num = (short)418840597;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_559:
					productFamily3 = productFamily;
					supportedCodelugVersion = iastrolocalService.GetSupportedCodelugVersion(productFamily3, maximumCpWorkingVer);
					text2 = null;
					num = (short)442892303;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_5A5:
					num = (short)719716383;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_222:
				return null;
				IL_2BC:
				IL_4B2:
				goto IL_6F1;
				IL_5BE:
				throw new global::System.ArgumentNullException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("英闳蓵駷觹", a_));
				IL_6F1:
				return null;
			}
			}
		}
	}
}
