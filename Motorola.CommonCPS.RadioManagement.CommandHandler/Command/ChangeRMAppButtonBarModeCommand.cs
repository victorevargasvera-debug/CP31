using System;
using Microsoft.Practices.Prism.Events;
using Microsoft.Practices.ServiceLocation;
using Motorola.CommonCPS.RadioManagement.Events;
using Motorola.CommonCPS.RadioManagement.Global.Properties;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000095 RID: 149
	internal class ChangeRMAppButtonBarModeCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000380 RID: 896 RVA: 0x0003797C File Offset: 0x00035B7C
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_77;
			}
			short num;
			bool result;
			int num3;
			for (;;)
			{
				IL_0A:
				num = (short)712642436;
				short num2 = num;
				num = (short)934809476;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					return result;
				default:
					num = (short)331284480;
					if (num != 0)
					{
					}
					switch (num3)
					{
					case 0:
						num = (short)252641281;
						if (num != 0)
						{
						}
						goto IL_E3;
					case 1:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum selectedMode;
						if (selectedMode.ToString() != global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ButtonMode)
						{
							num = (short)861732864;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					}
					case 2:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode buttonBarMode;
						if (buttonBarMode.SelectedMode == buttonBarMode.InitialModeSelection)
						{
							num = (short)898039813;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_E3;
					}
					case 3:
						if (paras[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)
						{
							num = (short)1197473792;
							short num4 = num;
							num = (short)1416691718;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return result;
					case 4:
						return result;
					case 5:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode buttonBarMode;
						global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarModeEnum selectedMode = buttonBarMode.SelectedMode;
						num = (short)1364590593;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 6:
					{
						global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode buttonBarMode = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).ButtonBarMode;
						num = (short)137953282;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					goto IL_77;
					IL_E3:
					result = true;
					num = (short)1532100612;
					num3 = (int)((global::System.IntPtr)num);
					break;
				}
			}
			return result;
			IL_77:
			result = false;
			num = (short)1218117635;
			num3 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x06000381 RID: 897 RVA: 0x00037B64 File Offset: 0x00035D64
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)1183318020;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				switch (num2)
				{
				case 0:
					goto IL_C1;
				case 1:
				{
					num = (short)60162048;
					short num3 = num;
					num = (short)1773988344;
					short num4 = num;
					num = (short)2095049208;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_AA;
					default:
						num = (short)1845690369;
						if (num != 0)
						{
						}
						num = (short)1552613376;
						if (num != 0)
						{
						}
						if (paras[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)
						{
							num = (short)1464729603;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_1A0;
					}
					break;
				}
				case 2:
					num = (short)1684799489;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 3:
				{
					global::Motorola.CommonCPS.RadioManagement.UIModels.ButtonBarMode buttonBarMode = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).ButtonBarMode;
					global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.ButtonMode = buttonBarMode.SelectedMode.ToString();
					global::Motorola.CommonCPS.RadioManagement.Global.Properties.Settings.Default.Save();
					global::Microsoft.Practices.ServiceLocation.ServiceLocator.Current.GetInstance<global::Microsoft.Practices.Prism.Events.IEventAggregator>().GetEvent<global::Motorola.CommonCPS.RadioManagement.Events.ChangeButtonBarModeEvent>().Publish(buttonBarMode.SelectedMode);
					goto IL_AA;
				}
				case 4:
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					continue;
				}
				IL_3A:
				if (paras.Length == 1)
				{
					num = (short)1190068226;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				break;
				IL_AA:
				num = (short)606863360;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_C1:
			IL_1A0:
			return true;
		}
	}
}
