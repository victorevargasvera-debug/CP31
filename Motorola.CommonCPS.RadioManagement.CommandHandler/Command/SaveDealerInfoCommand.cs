using System;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x02000028 RID: 40
	internal class SaveDealerInfoCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x06000203 RID: 515 RVA: 0x0001A3CC File Offset: 0x000185CC
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_3C;
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
					if (!string.Equals((paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).DealerInfo.Center, global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoMiddle, global::System.StringComparison.Ordinal))
					{
						num2 = (short)1624244228;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_A3;
				case 1:
					if (!string.Equals((paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).DealerInfo.Left, global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoLeft, global::System.StringComparison.Ordinal))
					{
						num2 = (short)1996554245;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_127;
				case 2:
					if (paras[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)
					{
						num2 = (short)851968000;
						short num3 = num2;
						num2 = (short)491388931;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 3:
					goto IL_182;
				case 4:
					result = true;
					num2 = (short)2052390920;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					result = true;
					num2 = (short)419627018;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					return result;
				case 7:
					if (!string.Equals((paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).DealerInfo.Right, global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoRight, global::System.StringComparison.Ordinal))
					{
						num2 = (short)888537097;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					return result;
				case 8:
					goto IL_A3;
				case 9:
				{
					num2 = (short)1498628729;
					short num4 = num2;
					num2 = (short)1319453305;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_182;
					default:
						num2 = (short)1779761152;
						if (num2 != 0)
						{
						}
						result = true;
						num2 = (short)54657030;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 10:
					goto IL_127;
				}
				goto IL_3C;
				IL_A3:
				num2 = (short)1892286465;
				if (num2 != 0)
				{
				}
				num2 = (short)1981743111;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_127:
				num2 = (short)1645412352;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_182:
				num2 = (short)201719809;
				num = (int)((global::System.IntPtr)num2);
			}
			return result;
			IL_3C:
			result = false;
			num2 = (short)1551171586;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000204 RID: 516 RVA: 0x0001A660 File Offset: 0x00018860
		protected override object ExecuteCmd(params object[] paras)
		{
			short num = (short)756800048;
			short num2 = num;
			num = (short)986438192;
			int num3;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_184:
				if (!(paras[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext))
				{
					goto IL_1AA;
				}
				num = (short)1278541828;
				num3 = (int)((global::System.IntPtr)num);
				break;
			default:
				num = (short)1569718272;
				if (num != 0)
				{
				}
				num = (short)1917255681;
				if (num != 0)
				{
				}
				num = (short)894435329;
				num3 = (int)((global::System.IntPtr)num);
				break;
			}
			for (;;)
			{
				switch (num3)
				{
				case 0:
					goto IL_141;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_A9;
					}
					continue;
				case 2:
					goto IL_184;
				case 3:
					num = (short)1047920642;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoLeft = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).DealerInfo.Left;
					global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoMiddle = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).DealerInfo.Center;
					global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.DealerInfoRight = (paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).DealerInfo.Right;
					global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.Save();
					num = (short)455671808;
					num3 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_A9:
				if (paras.Length != 1)
				{
					goto IL_1AA;
				}
				num = (short)1085079555;
				num3 = (int)((global::System.IntPtr)num);
			}
			IL_141:
			num = (short)1493630976;
			short num4 = num;
			IL_1AA:
			return true;
		}
	}
}
