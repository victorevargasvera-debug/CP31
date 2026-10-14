using System;
using Motorola.CommonCPS.RadioManagement.CommonBase.Utility;
using Motorola.CommonCPS.RadioManagement.Global;
using Motorola.CommonCPS.RadioManagement.UIModels;

namespace Motorola.CommonCPS.RadioManagement.Command
{
	// Token: 0x020000C6 RID: 198
	internal class SaveSettingsCommand : global::Motorola.CommonCPS.RadioManagement.Command.CommandBase
	{
		// Token: 0x0600041C RID: 1052 RVA: 0x00045D2C File Offset: 0x00043F2C
		public override bool CanExecute(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_BE;
			}
			short num;
			int num4;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Connection connection;
			for (;;)
			{
				IL_0A:
				num = (short)943753120;
				short num2 = num;
				num = (short)240289696;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)1086128128;
					if (num != 0)
					{
					}
					num = (short)2101149697;
					if (num != 0)
					{
					}
					num = (short)1655701504;
					short num3 = num;
					switch (num4)
					{
					case 0:
						num = (short)1271398402;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						goto IL_DD;
					case 2:
						goto IL_135;
					case 3:
						goto IL_11A;
					}
					goto IL_BE;
				}
				}
				IL_DD:
				if (!string.IsNullOrWhiteSpace(connection.Address))
				{
					num = (short)253689856;
					num4 = (int)((global::System.IntPtr)num);
				}
				else
				{
					num = (short)1996685315;
					num4 = (int)((global::System.IntPtr)num);
				}
			}
			IL_11A:
			int num5 = 1;
			goto IL_143;
			IL_135:
			num5 = ((connection.Port <= 0) ? 1 : 0);
			IL_143:
			return num5 == 0;
			IL_BE:
			connection = this.a(paras);
			num = (short)2004942849;
			num4 = (int)((global::System.IntPtr)num);
			goto IL_0A;
		}

		// Token: 0x0600041D RID: 1053 RVA: 0x00045E80 File Offset: 0x00044080
		protected override object ExecuteCmd(params object[] paras)
		{
			switch (0)
			{
			case 0:
				goto IL_50;
			}
			global::Motorola.CommonCPS.RadioManagement.UIModels.Connection connection;
			short num2;
			for (;;)
			{
				IL_0A:
				int num;
				switch (num)
				{
				case 0:
					goto IL_2CD;
				case 1:
					goto IL_1A8;
				case 2:
					goto IL_270;
				case 3:
					goto IL_2CD;
				case 4:
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckIfLocalHost(connection.Address.Trim()))
					{
						num2 = (short)1755971591;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)422051845;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 5:
					if (global::Motorola.CommonCPS.RadioManagement.CommonBase.Utility.Utility.CheckIfActiveDirectory())
					{
						num2 = (short)160694285;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.UserName.ToString();
					num2 = (short)1644167183;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					if (global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerPort != connection.Port)
					{
						num2 = (short)1368391681;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCurrentSessionConnected = global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsConnected;
					num2 = (short)560660483;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 7:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString();
					num2 = (short)642711554;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 8:
					num2 = (short)32047110;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_1F6;
				case 10:
					if (string.Equals(global::Motorola.CommonCPS.RadioManagement.Global.UserConfig.Settings.ServerAddress, connection.Address.Trim(), global::System.StringComparison.OrdinalIgnoreCase))
					{
						num2 = (short)248578048;
						short num3 = num2;
						num2 = (short)1244069896;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1A8;
				case 11:
					if (global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsHostedDeployment)
					{
						num2 = (short)1869414412;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)1018888196;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.JwtToken.ToString();
					num2 = (short)1848377358;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.AuthenticationMethodType = global::Motorola.CommonCPS.RadioManagement.Global.AuthMethod.Windows.ToString();
					num2 = (short)1445593097;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					goto IL_359;
				case 15:
					goto IL_2A0;
				}
				goto IL_50;
				IL_1A8:
				global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.IsCurrentSessionConnected = false;
				num2 = (short)291766272;
				num = (int)((global::System.IntPtr)num2);
				continue;
				IL_2CD:
				num2 = (short)1566507019;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_270:
			goto IL_35B;
			IL_2A0:
			num2 = (short)382271489;
			if (num2 != 0)
			{
			}
			IL_359:
			goto IL_35B;
			IL_50:
			connection = this.a(paras);
			num2 = (short)1032913766;
			short num4 = num2;
			num2 = (short)2000552806;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_1F6:
				break;
			default:
			{
				num2 = (short)989986816;
				if (num2 != 0)
				{
				}
				num2 = (short)1623326730;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			}
			IL_35B:
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerAddress = connection.Address.Trim();
			global::Motorola.CommonCPS.RadioManagement.Global.RuntimeInfo.ServerPort = connection.Port;
			(paras[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).IsSaved = true;
			return true;
		}

		// Token: 0x0600041E RID: 1054 RVA: 0x00046218 File Offset: 0x00044418
		private global::Motorola.CommonCPS.RadioManagement.UIModels.Connection a(object[] A_0)
		{
			int a_ = 7;
			short num = (short)1298202020;
			short num2 = num;
			num = (short)1965620644;
			global::Motorola.CommonCPS.RadioManagement.UIModels.Connection result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				return result;
			case 1:
				break;
			default:
			{
				num = (short)440729600;
				short num3 = num;
				break;
			}
			}
			num = (short)363462657;
			if (num != 0)
			{
			}
			num = (short)342360064;
			if (num != 0)
			{
			}
			result = null;
			try
			{
				num = (short)164757507;
				int num4 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					switch (num4)
					{
					case 0:
						num = (short)817561601;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						if (A_0[0] is global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext)
						{
							num = (short)1570111492;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_15B;
					case 2:
						goto IL_172;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_E4;
						}
						continue;
					case 4:
						result = (A_0[0] as global::Motorola.CommonCPS.RadioManagement.UIModels.SettingsContext).Connection;
						num = (short)1414070277;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_15B;
					}
					IL_E4:
					if (A_0.Length == 1)
					{
						num = (short)246677504;
						num4 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_15B:
					num = (short)398917634;
					num4 = (int)((global::System.IntPtr)num);
				}
				IL_172:;
			}
			catch (global::System.Exception)
			{
				throw new global::System.ArgumentException(global::Motorola.CommonCPS.RadioManagement.Command.ShowTemplateVADetailInfomationCommand.b("뇷雹郻鯽柿持栃★椇砉欋笍紏眑稓戕㠗渙攛渝䔟డУ挥倧娩䤫䴭䐯࠱ᐳ挵男ᐹ缻儽⸿ⱁ⅃╅㱇⍉⍋⁍繏", a_));
			}
			return result;
		}
	}
}
