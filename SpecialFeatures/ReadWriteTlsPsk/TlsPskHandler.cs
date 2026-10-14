using System;
using System.Windows;
using CommonResources;
using CommonUtility;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Service;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.Comms;
using SpecialFeatures.ReadWritePassword;

namespace SpecialFeatures.ReadWriteTlsPsk
{
	// Token: 0x0200005D RID: 93
	public class TlsPskHandler : global::System.IDisposable
	{
		// Token: 0x0600086A RID: 2154 RVA: 0x0000296A File Offset: 0x00000B6A
		public TlsPskHandler(global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp readWritePasswordApp)
		{
			this.a = readWritePasswordApp;
		}

		// Token: 0x0600086B RID: 2155 RVA: 0x0008DF50 File Offset: 0x0008C150
		public void HandlePsk(global::Motorola.Common.Communication.Service.IDeviceDiscovery deviceDiscovery, global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, out string psk)
		{
			int a_ = 6;
			int num;
			short num2;
			string pskId;
			switch (0)
			{
			case 0:
				break;
			default:
				for (;;)
				{
					IL_13:
					switch (num)
					{
					case 0:
					{
						bool flag;
						if (flag)
						{
							num2 = (short)1915289604;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)311164928;
						short num3 = num2;
						global::SpecialFeatures.ReadWritePassword.PromptReadWritePassword promptPassword = this.a.ShowPopup(pskId, global::CommonResources.AppResources.Please_enter_password);
						num2 = (short)2063859717;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					case 1:
						goto IL_219;
					case 2:
						global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Please_enter_a_valid_password, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
						num2 = (short)65208321;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 3:
						return;
					case 4:
						return;
					case 5:
						if (CS$<>8__locals1.promptPassword.IsCanceled)
						{
							num2 = (short)1731526668;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)454295560;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 6:
					{
						if (this.a(deviceInfo, deviceDiscovery, out psk))
						{
							num2 = (short)1539899402;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)445912762;
						short num4 = num2;
						num2 = (short)1099175610;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_86;
						default:
						{
							num2 = (short)1225326592;
							if (num2 != 0)
							{
							}
							bool flag = false;
							num2 = (short)776142862;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						}
						break;
					}
					case 7:
						goto IL_118;
					case 8:
						if (string.IsNullOrEmpty(CS$<>8__locals1.promptPassword.UserEnteredPassword))
						{
							num2 = (short)1885208578;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						psk = global::CommonUtility.TlsPskHashManager.Hash(CS$<>8__locals1.promptPassword.UserEnteredPassword, 4000, 16);
						num2 = (short)1990197261;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 9:
						goto IL_219;
					case 10:
						return;
					case 11:
						if (global::CommonUtility.TlsPskUtility.TryGetDefaultPsk(pskId, out psk))
						{
							num2 = (short)2121662467;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)914227206;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 12:
						goto IL_2DA;
					case 13:
						if (deviceDiscovery.EstablishSecureConnection(deviceInfo, psk))
						{
							num2 = (short)666894343;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						global::System.Windows.MessageBox.Show(global::CommonResources.AppResources.Incorrect_Password, global::CommonResources.AppResources.APX_CPS, global::System.Windows.MessageBoxButton.OK, global::System.Windows.MessageBoxImage.Exclamation, global::System.Windows.MessageBoxResult.OK);
						global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud988力年릘ﲜ튠풢쪤햦춨讪쒬\udcae醰\udab2\udbb4풶횸즺쾼\udabeꋀ럂", a_));
						num2 = (short)531693577;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 14:
						goto IL_219;
					}
					goto IL_55;
					IL_219:
					num2 = (short)993329152;
					num = (int)((global::System.IntPtr)num2);
				}
				return;
				IL_118:
				CS$<>8__locals1.isPasswordRemembered = false;
				global::System.Windows.Application.Current.Dispatcher.Invoke<bool>(delegate()
				{
					short num5 = (short)484009203;
					short num6 = num5;
					num5 = (short)1586521331;
					switch (num6 == num5)
					{
					default:
					{
						num5 = (short)544997376;
						short num7 = num5;
						break;
					}
					case true:
						break;
					}
					num5 = (short)2002255873;
					if (num5 != 0)
					{
					}
					num5 = (short)1333723136;
					if (num5 != 0)
					{
					}
					return CS$<>8__locals1.isPasswordRemembered = CS$<>8__locals1.promptPassword.RememberPasswordSession.IsChecked.Value;
				});
				this.a.IsPasswordStoredForCurrentSession = CS$<>8__locals1.isPasswordRemembered;
				this.a.ReadWritePassword = CS$<>8__locals1.promptPassword.UserEnteredPassword;
				this.a.IsPasswordValidatedForCurrentInteraction = true;
				global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\uda88搜떔풖爵슠힢첤좦잨讪얬캮슰鎲ힴ튶\udcb8햺鶼\udabe닀럂꓄ꗆꗈꋊ뻌꟎듐럒", a_));
				return;
				IL_2DA:
				global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("\ud988꾎손杖殺붜삠킢薤얦첨캪쎬辮튰튲\udbb4풶\udcb8ힺ\ud8bc\udbbe", a_));
				throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.OperationCanceled);
			}
			IL_55:
			num2 = (short)1314062337;
			if (num2 != 0)
			{
			}
			pskId = deviceDiscovery.GetPskId(deviceInfo);
			IL_86:
			num2 = (short)427819019;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x0600086C RID: 2156 RVA: 0x0008E330 File Offset: 0x0008C530
		private bool a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.Service.IDeviceDiscovery A_1, out string A_2)
		{
			int a_ = 3;
			short num = (short)1881669636;
			int num2 = (int)((global::System.IntPtr)num);
			string text;
			for (;;)
			{
				switch (num2)
				{
				case 0:
					if (A_1.EstablishSecureConnection(A_0, text))
					{
						num = (short)1184890882;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1E7;
				case 1:
					num = (short)997523459;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					goto IL_11D;
				case 3:
				{
					num = (short)912588800;
					short num3 = num;
					if (!this.a.IsPasswordValidatedForCurrentInteraction)
					{
						num = (short)1515192325;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_B6;
				}
				case 4:
				{
					num = (short)1323605338;
					short num4 = num;
					num = (short)1295555930;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_B6;
					default:
						num = (short)166526976;
						if (num != 0)
						{
						}
						switch (0)
						{
						case 0:
							goto IL_90;
						}
						continue;
					}
					break;
				}
				case 5:
					goto IL_1A3;
				}
				IL_90:
				if (!this.a.IsPasswordStoredForCurrentSession)
				{
					num = (short)1914961921;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				IL_B6:
				global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("횅黎ﾋ轢ﾏ뚕ﺗ肟송얣얥삧쾩", a_));
				text = global::CommonUtility.TlsPskHashManager.Hash(this.a.ReadWritePassword, 4000, 16);
				num = (short)1093337088;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11D:
			global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("햅ﶇ뺝얟톡킣장쪧용얫\uddad\ud8afힱ킳隵\udbb7햹튻킽ꖿꇁ냃꿅Ꟈ꓉맍맏ꛑ볓곗닙맛ﻝ郟菡韣闥鿧藩黫諭탯铱蛳駵闷\udaf9鿻鿽揿樁愃⠅", a_));
			A_2 = text;
			return true;
			IL_1A3:
			num = (short)1636958209;
			if (num != 0)
			{
			}
			global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튅ﺋ낏ﮑ뚕벛솟톡힣톥잧\ud8a9좫躭\ud9af\udcb1钳햵\ud9b7\ud9b9풻\udbbd", a_));
			A_2 = null;
			return false;
			IL_1E7:
			global::SpecialFeatures.Comms.Logger.LogWithDateTime(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("얅겋ﾏ뒓ﶛﲝ첟쮡힣캥袧즩쎫삭\udeafힱힳ습톷햹튻", a_));
			A_2 = null;
			return false;
		}

		// Token: 0x0600086D RID: 2157 RVA: 0x0008E53C File Offset: 0x0008C73C
		public void Dispose()
		{
			short num = (short)1446888969;
			short num2 = num;
			num = (short)2090190345;
			switch (num2 == num)
			{
			default:
			{
				num = (short)511705088;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1701052416;
			if (num != 0)
			{
			}
			num = (short)1024000001;
			if (num != 0)
			{
			}
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x04000343 RID: 835
		private readonly global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp a;
	}
}
