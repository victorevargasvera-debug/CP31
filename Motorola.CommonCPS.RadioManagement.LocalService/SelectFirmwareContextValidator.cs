using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Motorola.CommonCPS.RadioManagement.SharedServices;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.LocalService
{
	// Token: 0x0200003E RID: 62
	public class SelectFirmwareContextValidator : global::Motorola.CommonCPS.RadioManagement.UIModels.IUIModelValidate
	{
		// Token: 0x06000228 RID: 552 RVA: 0x00028284 File Offset: 0x00026484
		public virtual void Validate(global::Motorola.CommonCPS.RadioManagement.UIModels.UIModelBase uiModel, global::System.ComponentModel.PropertyChangedEventArgs e)
		{
			int a_ = 13;
			switch (0)
			{
			case 0:
				goto IL_4D;
			}
			int num;
			global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext selectFirmwareContext;
			short num2;
			for (;;)
			{
				IL_13:
				string a_2;
				switch (num)
				{
				case 0:
				{
					if (!selectFirmwareContext.Firmwares.Contains(selectFirmwareContext.SelectedFirmware))
					{
						num2 = (short)356843530;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1778141671;
					short num3 = num2;
					num2 = (short)404900327;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_110;
					default:
						num2 = (short)20840448;
						if (num2 != 0)
						{
						}
						selectFirmwareContext.SelectedFirmware = selectFirmwareContext.Firmwares[selectFirmwareContext.Firmwares.IndexOf(selectFirmwareContext.SelectedFirmware)];
						num2 = (short)413990915;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (selectFirmwareContext.SelectedCodeplug == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("昦䔨尪䰬嘮䈰ጲ头嘶䴸帺丼䬾慀㕂⁄㕆㩈≊≌ⅎ", a_))
					{
						num2 = (short)1482817545;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					a_2 = selectFirmwareContext.SelectedCodeplug;
					num2 = (short)2125463560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					goto IL_9A;
				case 3:
					return;
				case 4:
					a_2 = null;
					num2 = (short)223674369;
					if (num2 != 0)
					{
					}
					num2 = (short)1011154945;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (e == null)
					{
						num2 = (short)1008861195;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)338427910;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					goto IL_110;
				case 7:
					goto IL_1BA;
				case 8:
					goto IL_9A;
				case 9:
					a_2 = selectFirmwareContext.MaxCodeplugVersion;
					num2 = (short)2050490370;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 10:
					num2 = (short)1959919628;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					goto IL_82;
				case 12:
					if (selectFirmwareContext.Firmwares.Count > 0)
					{
						num2 = (short)799539207;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_14B;
				}
				goto IL_4D;
				IL_9A:
				global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> firmwares = this.a(selectFirmwareContext.FirmwaresForMaxCodeplugVersion, a_2);
				selectFirmwareContext.Firmwares = firmwares;
				num2 = (short)726269952;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_110:
				if (!(e.PropertyName == global::Motorola.CommonCPS.RadioManagement.LocalService.RadioProvider.b("琦䰨䜪䠬䰮䔰嘲儴琶嘸强堼伾ⵀ㙂≄", a_)))
				{
					return;
				}
				num2 = (short)1678180356;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_82:
			num2 = (short)2044592128;
			short num4 = num2;
			return;
			IL_14B:
			selectFirmwareContext.SelectedFirmware = null;
			return;
			IL_1BA:
			selectFirmwareContext.SelectedFirmware = selectFirmwareContext.Firmwares[0];
			return;
			IL_4D:
			selectFirmwareContext = (global::Motorola.CommonCPS.RadioManagement.UIModels.SelectFirmwareContext)uiModel;
			num2 = (short)2105671685;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x06000229 RID: 553 RVA: 0x0002859C File Offset: 0x0002679C
		private global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> a(global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> A_0, string A_1)
		{
			short num = (short)937426944;
			short num2 = num;
			global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> list = new global::System.Collections.Generic.List<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>();
			global::System.Collections.Generic.IEnumerator<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware> enumerator = A_0.GetEnumerator();
			try
			{
				num = (short)1763508229;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_155;
					case 1:
						num = (short)970391552;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
						list.Add(firmware);
						num = (short)97845251;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 4:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware;
						if (global::Motorola.CommonCPS.RadioManagement.SharedServices.RadioFeatureOperationFactory.GetInstance().CheckAstroUpgradeFWIsSupported(firmware.Version, A_1))
						{
							num = (short)1947336706;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 5:
						num = (short)1782317057;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_9F;
						}
						continue;
					case 6:
					{
						if (!enumerator.MoveNext())
						{
							num = (short)833748993;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware firmware = enumerator.Current;
						num = (short)1271726084;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_E7:
					num = (short)1889796102;
					num3 = (int)((global::System.IntPtr)num);
					continue;
					IL_9F:
					goto IL_E7;
				}
				IL_155:;
			}
			finally
			{
				num = (short)1751056385;
				int num3 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num3)
					{
					case 0:
						goto IL_210;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_18B;
						}
						continue;
					case 2:
					{
						num = (short)1674880501;
						short num4 = num;
						num = (short)815375861;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							num = (short)57671680;
							if (num != 0)
							{
							}
							enumerator.Dispose();
							num = (short)793247744;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					}
					IL_18B:
					if (enumerator == null)
					{
						break;
					}
					num = (short)455868418;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_210:;
			}
			list.Sort();
			return new global::System.Collections.ObjectModel.ObservableCollection<global::Motorola.CommonCPS.RadioManagement.UIModels.Firmware>(list);
		}
	}
}
