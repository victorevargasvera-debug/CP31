using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Motorola.CommonCPS.RadioManagement.LocalService;
using Motorola.CommonCPS.RadioManagement.UIModels;
using Motorola.CommonCPS.ResourceRepository;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x0200004A RID: 74
	public class AstroPrepareUpgradeFirmwareCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000292 RID: 658 RVA: 0x000242F8 File Offset: 0x000224F8
		public override bool CanExecute(params object[] paras)
		{
			bool result;
			short num;
			for (;;)
			{
				global::System.Collections.ICollection source = paras[0] as global::System.Collections.ICollection;
				try
				{
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> selectedItems = source.Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
					result = (base.UIValidateService as global::Motorola.CommonCPS.RadioManagement.LocalService.IASTROUIValidationService).CanUpgradeFirmware(selectedItems);
				}
				catch
				{
					result = false;
				}
				num = (short)1420361728;
				short num2 = num;
				num = (short)341942527;
				short num3 = num;
				num = (short)452763903;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					goto IL_8D;
				}
			}
			IL_8D:
			num = (short)1734475776;
			if (num != 0)
			{
			}
			num = (short)2071330817;
			if (num != 0)
			{
			}
			return result;
		}

		// Token: 0x06000293 RID: 659 RVA: 0x000243E0 File Offset: 0x000225E0
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1139277827;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					num = (short)1209073665;
					if (num != 0)
					{
					}
					if (!paras.Any<object>())
					{
						num = (short)1409548296;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1939341321;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 1:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
					if (selectFirmwareContext.Firmwares != null)
					{
						num = (short)311689222;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_6F;
				}
				case 2:
				{
					num = (short)1500453779;
					short num3 = num;
					num = (short)1242700691;
					switch ((num3 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)709492736;
						if (num != 0)
						{
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
						if (!selectFirmwareContext.Firmwares.Any<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>())
						{
							goto IL_6F;
						}
						break;
					}
					}
					num = (short)1359347716;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 3:
					switch (0)
					{
					case 0:
						goto IL_50;
					}
					continue;
				case 4:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
					base.Interaction.ShowSelectFirmwareDialog(selectFirmwareContext);
					num = (short)1262616583;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 5:
					goto IL_C5;
				case 6:
					num = (short)1356988418;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 7:
					goto IL_295;
				case 8:
					goto IL_251;
				case 9:
				{
					global::System.Collections.Generic.IList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase> radios = (paras[0] as global::System.Collections.ICollection).Cast<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>().Select(delegate(global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase d)
					{
						short num5 = (short)596246529;
						if (num5 != 0)
						{
						}
						num5 = (short)2104322334;
						short num6 = num5;
						num5 = (short)58353950;
						switch (num6 == num5)
						{
						}
						num5 = (short)764346368;
						short num7 = num5;
						num5 = (short)1420296192;
						if (num5 != 0)
						{
						}
						return d.Clone() as global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase;
					}).ToList<global::Motorola.CommonCPS.RadioManagement.UIModels.RadioBase>();
					global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext = base.LocalService.GenerateSelectFirmwareContext(radios);
					num = (short)1084293121;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				case 10:
					num = (short)1067057152;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_50:
				if (paras != null)
				{
					num = (short)123273226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				goto IL_192;
				IL_6F:
				base.Interaction.ShowNotificationDialog(global::Motorola.CommonCPS.ResourceRepository.Resources.Waring_NoCompatiblePackage, global::Motorola.CommonCPS.ResourceRepository.Resources.Validator_MessageBox_Caption);
				num = (short)1878261760;
				short num4 = num;
				num = (short)718864389;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C5:
			goto IL_297;
			IL_192:
			throw new global::System.ArgumentNullException();
			IL_251:
			goto IL_192;
			IL_295:
			IL_297:
			return null;
		}
	}
}
