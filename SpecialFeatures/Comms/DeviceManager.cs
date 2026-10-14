using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading;
using System.Windows;
using CommonResources;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.Service;
using Motorola.Common.CustomException;
using Motorola.CommonCPS.ResourceRepository;
using SpecialFeatures.AcpReportManagerLib;
using SpecialFeatures.ReadWritePassword;
using SpecialFeatures.ReadWriteTlsPsk;
using SSLMangrComp;

namespace SpecialFeatures.Comms
{
	// Token: 0x0200015E RID: 350
	public class DeviceManager : global::SpecialFeatures.Comms.IDeviceManager
	{
		// Token: 0x060011BB RID: 4539 RVA: 0x00183D30 File Offset: 0x00181F30
		public DeviceManager()
		{
			int a_ = 17;
			base..ctor();
			this.c = (bool)global::System.Windows.Application.Current.Properties[global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("힓秊ﶛ쒟춣좥춧ﲫﶭ", a_)];
			if (!this.c)
			{
				this.b = new global::SpecialFeatures.Comms.DeviceDiscoveryHandler();
				this.a = global::SpecialFeatures.Comms.DeviceServiceManagerProvider.Instance.GetDeviceDiscoveryService(global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio | global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.WorkMode.Lazy, this.b);
			}
			this.d = global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp.GetInstance();
		}

		// Token: 0x1400000F RID: 15
		// (add) Token: 0x060011BC RID: 4540 RVA: 0x00183DB4 File Offset: 0x00181FB4
		// (remove) Token: 0x060011BD RID: 4541 RVA: 0x00183E7C File Offset: 0x0018207C
		public event global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceConnectedEvent
		{
			add
			{
				short num = (short)506789888;
				short num2 = num;
				num = (short)968035421;
				short num3 = num;
				num = (short)2125335645;
				switch (num3 == num)
				{
				}
				num = (short)769392641;
				if (num != 0)
				{
				}
				num = (short)374079488;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Comms.DeviceDiscoveryHandler deviceDiscoveryHandler = this.b;
				deviceDiscoveryHandler.DeviceConnectedEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Combine(deviceDiscoveryHandler.DeviceConnectedEventHandler, value);
			}
			remove
			{
				short num = (short)1121058816;
				short num2 = num;
				num = (short)416215062;
				short num3 = num;
				num = (short)249425942;
				switch (num3 == num)
				{
				}
				num = (short)1507590144;
				if (num != 0)
				{
				}
				num = (short)1282277377;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Comms.DeviceDiscoveryHandler deviceDiscoveryHandler = this.b;
				deviceDiscoveryHandler.DeviceConnectedEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Remove(deviceDiscoveryHandler.DeviceConnectedEventHandler, value);
			}
		}

		// Token: 0x14000010 RID: 16
		// (add) Token: 0x060011BE RID: 4542 RVA: 0x00183F40 File Offset: 0x00182140
		// (remove) Token: 0x060011BF RID: 4543 RVA: 0x00184008 File Offset: 0x00182208
		public event global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs> DeviceLostEvent
		{
			add
			{
				short num = (short)1369309184;
				short num2 = num;
				num = (short)2132142153;
				short num3 = num;
				num = (short)1156180041;
				switch (num3 == num)
				{
				}
				num = (short)1762131969;
				if (num != 0)
				{
				}
				num = (short)2025193472;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Comms.DeviceDiscoveryHandler deviceDiscoveryHandler = this.b;
				deviceDiscoveryHandler.DeviceLostEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Combine(deviceDiscoveryHandler.DeviceLostEventHandler, value);
			}
			remove
			{
				short num = (short)855769088;
				short num2 = num;
				num = (short)1599980871;
				short num3 = num;
				num = (short)2075313479;
				switch (num3 == num)
				{
				}
				num = (short)1783169025;
				if (num != 0)
				{
				}
				num = (short)1013841920;
				if (num != 0)
				{
				}
				global::SpecialFeatures.Comms.DeviceDiscoveryHandler deviceDiscoveryHandler = this.b;
				deviceDiscoveryHandler.DeviceLostEventHandler = (global::System.EventHandler<global::Motorola.Common.Communication.CommonUtil.DeviceEventArgs>)global::System.Delegate.Remove(deviceDiscoveryHandler.DeviceLostEventHandler, value);
			}
		}

		// Token: 0x060011C0 RID: 4544 RVA: 0x001840CC File Offset: 0x001822CC
		public global::SSLMangrComp.PresenceNotification RetrievePresenceInfo(global::SSLMangrComp.PNConnectionInfo connectionConfig)
		{
			short num;
			global::SSLMangrComp.PresenceNotification result;
			try
			{
				num = (short)709184808;
				short num2 = num;
				num = (short)459164968;
				switch (num2 == num)
				{
				}
				num = (short)1070268416;
				if (num != 0)
				{
				}
				result = this.a.RetrievePresenceInfo(connectionConfig);
			}
			catch (global::System.Exception ex)
			{
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, global::Motorola.CommonCPS.ResourceRepository.Resources.GenericError, ex);
			}
			num = (short)1410531329;
			if (num != 0)
			{
			}
			num = (short)1347485696;
			short num3 = num;
			return result;
		}

		// Token: 0x060011C1 RID: 4545 RVA: 0x001841A8 File Offset: 0x001823A8
		public global::SpecialFeatures.Comms.IDeviceProxy CreateDeviceProxy(global::SpecialFeatures.Comms.RadioParams radioParameter, global::Motorola.Common.Communication.CommonUtil.RadioOperation radioOperation)
		{
			short num = (short)892469249;
			int num2 = (int)((global::System.IntPtr)num);
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
			for (;;)
			{
				global::Motorola.Common.Communication.CommonUtil.ConnectionType connectionType;
				switch (num2)
				{
				case 0:
					goto IL_1B1;
				case 1:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				case 2:
					goto IL_2A9;
				case 3:
					num = (short)646250506;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 4:
					if (radioParameter.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
					{
						num = (short)1383923719;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F2;
				case 5:
					if (connectionType != global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth)
					{
						num = (short)1572339715;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_1C0;
				case 6:
					if (deviceInfo.ConnectionInfo.OtapConnectionType == global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LMR)
					{
						num = (short)120848384;
						short num3 = num;
						num = (short)1566703616;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_2F2;
				case 7:
					num = (short)871694342;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 8:
					if (radioParameter.ConnectionInfo.ConnectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter)
					{
						num = (short)1602093068;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					deviceInfo = radioParameter.WrapperDeviceInfo();
					num = (short)587333643;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 9:
					goto IL_80;
				case 10:
					if (connectionType == global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap)
					{
						num = (short)1887961102;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_85;
				case 11:
				{
					num = (short)143355199;
					short num4 = num;
					num = (short)897805631;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_2A9;
					default:
						num = (short)887750656;
						if (num != 0)
						{
						}
						goto IL_2AB;
					}
					break;
				}
				case 12:
					num = (short)1982070785;
					if (num != 0)
					{
					}
					deviceInfo = this.a(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, radioOperation);
					num = (short)1265827842;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 13:
					goto IL_85;
				case 14:
					goto IL_1C0;
				}
				IL_60:
				if (this.c)
				{
					num = (short)1866661897;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				}
				num = (short)67174408;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_85:
				num = (short)1700397060;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_1C0:
				deviceInfo = new global::SpecialFeatures.Comms.DeviceProxy(deviceInfo, global::Motorola.Common.Communication.CommonUtil.RadioOperation.Create, null).ReadDeviceInfo();
				num = (short)180158477;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2AB:
				connectionType = radioParameter.ConnectionInfo.ConnectionType;
				num = (short)864944133;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_2A9:
				goto IL_2AB;
			}
			IL_80:
			return global::SpecialFeatures.Comms.FileProxyFactory.Instance.GetDevice(radioParameter, radioOperation);
			IL_1B1:
			return new global::SpecialFeatures.Comms.DeviceProxy(deviceInfo, radioOperation, null);
			IL_2F2:
			string psk;
			this.a(deviceInfo, radioOperation, out psk);
			return new global::SpecialFeatures.Comms.DeviceProxy(deviceInfo, radioOperation, psk);
		}

		// Token: 0x060011C2 RID: 4546 RVA: 0x001844BC File Offset: 0x001826BC
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo a(global::Motorola.Common.Communication.CommonUtil.ConnectionType A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_1)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
			try
			{
				list = this.a.ListConnectedDevices((int)A_0);
				goto IL_EC;
			}
			catch (global::System.Exception ex)
			{
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceCommunicationError, global::Motorola.CommonCPS.ResourceRepository.Resources.CommunicationServiceCommunicationError, null);
			}
			goto IL_25;
			int num;
			short num2;
			for (;;)
			{
				IL_8F:
				switch (num)
				{
				case 0:
					switch (0)
					{
					case 0:
						goto IL_A5;
					}
					continue;
				case 1:
					goto IL_11C;
				case 2:
					if (list != null)
					{
						num2 = (short)1017905153;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_121;
				case 3:
					goto IL_EA;
				}
				IL_A5:
				num2 = (short)804782081;
				if (num2 != 0)
				{
				}
				if (list.Count != 0)
				{
					goto IL_12C;
				}
				num2 = (short)1281228803;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_EA:
			IL_121:
			throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Could_not_find_a_radio_connected_to_a_USB_port);
			IL_12C:
			num2 = (short)314834944;
			short num3 = num2;
			return this.a(list, A_0, A_1);
			IL_25:
			num2 = (short)1961654589;
			short num4 = num2;
			num2 = (short)1776908605;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11C:
				goto IL_25;
			default:
				num2 = (short)1836646400;
				if (num2 != 0)
				{
				}
				num2 = (short)1132396544;
				num = (int)((global::System.IntPtr)num2);
				goto IL_8F;
			}
			IL_EC:
			num2 = (short)577568770;
			num = (int)((global::System.IntPtr)num2);
			goto IL_8F;
		}

		// Token: 0x060011C3 RID: 4547 RVA: 0x00184638 File Offset: 0x00182838
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo a(global::System.Collections.Generic.IList<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> A_0, global::Motorola.Common.Communication.CommonUtil.ConnectionType A_1, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_2)
		{
			int a_ = 10;
			short num;
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo;
			for (;;)
			{
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				int num3;
				for (;;)
				{
					IL_13:
					num = (short)127074304;
					short num2 = num;
					switch (num3)
					{
					case 0:
						if (deviceInfo.Family == global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio)
						{
							num = (short)1525940228;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return deviceInfo;
					case 1:
						if (this.a.IsRadioInBpMode(deviceInfo))
						{
							num = (short)58851329;
							if (num != 0)
							{
							}
							num = (short)985268226;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						return deviceInfo;
					case 2:
						global::System.Diagnostics.Trace.TraceInformation(string.Concat(new string[]
						{
							string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("회ꆐ좔첖ꪚ슞猪\ud8a2鞤\udaa6횬鲮첰骶钸隺", a_), new object[]
							{
								deviceInfo.ConnectionInfo.ConnectionType,
								deviceInfo.Family,
								deviceInfo.SerialNumber,
								deviceInfo.ModelNumber
							}),
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("회", a_),
							deviceInfo.SoftwareVersion,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킌풎", a_),
							deviceInfo.CodeplugVersion,
							global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킌꾎떔뮚좠힢욤쾦삨얪쪬辮ﺲ鞶ﶸ\udeba쮼횾ꋀꛂꇆ믈꓊ꃌ鏐菒뫖뛘뿚룜￞闠賢엤ꛦ맨쯪胬胮闰雲\udbf4", a_)
						}));
						this.a.ChangeDeviceProcessorToAp(deviceInfo);
						deviceInfo = this.a(A_1);
						num = (short)1859846147;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_216;
					case 4:
						num = (short)200998913;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_56;
				}
				IL_216:
				num = (short)646475148;
				short num4 = num;
				num = (short)1299213708;
				switch ((num4 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					continue;
				default:
					goto IL_24B;
				}
				IL_56:
				deviceInfo = A_0[0];
				global::System.Diagnostics.Trace.TraceInformation(string.Concat(new string[]
				{
					string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("회ꆐ좔첖ꪚ슞猪\ud8a2鞤\udaa6횬鲮첰骶钸隺", a_), new object[]
					{
						deviceInfo.ConnectionInfo.ConnectionType,
						deviceInfo.Family,
						deviceInfo.SerialNumber,
						deviceInfo.ModelNumber
					}),
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("회", a_),
					deviceInfo.SoftwareVersion,
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킌풎", a_),
					deviceInfo.CodeplugVersion,
					global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("킌꾎煮뾞햠쮢삤螦춨캪\udbac욮튰횲閴톶쮸풺킼龾藀ꛂ도껆꫈껊背껎뿐닒닔닖ꯘ", a_)
				}));
				num = (short)602800128;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			IL_24B:
			num = (short)26542080;
			if (num != 0)
			{
			}
			return deviceInfo;
		}

		// Token: 0x060011C4 RID: 4548 RVA: 0x00184918 File Offset: 0x00182B18
		private void a(global::Motorola.Common.Communication.CommonUtil.DeviceInfo A_0, global::Motorola.Common.Communication.CommonUtil.RadioOperation A_1, out string A_2)
		{
			int a_ = 6;
			A_2 = null;
			goto IL_0E;
			short num2;
			try
			{
				for (;;)
				{
					IL_0E:
					switch (0)
					{
					case 0:
						goto IL_36;
					}
					int num;
					for (;;)
					{
						IL_18:
						switch (num)
						{
						case 0:
							num2 = (short)268304389;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 1:
							if (A_1 != global::Motorola.Common.Communication.CommonUtil.RadioOperation.PasswordReset)
							{
								num2 = (short)1880293376;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_169;
						case 2:
							goto IL_169;
						case 3:
							goto IL_1A6;
						case 4:
							new global::SpecialFeatures.ReadWriteTlsPsk.TlsPskHandler(this.d).HandlePsk(this.a, A_0, out A_2);
							num2 = (short)1559035906;
							num = (int)((global::System.IntPtr)num2);
							continue;
						case 5:
							if (A_0.ConnectionInfo.IsTlsPskCompatible)
							{
								num2 = (short)224854020;
								num = (int)((global::System.IntPtr)num2);
								continue;
							}
							goto IL_169;
						}
						goto IL_36;
						IL_169:
						num2 = (short)1534001153;
						if (num2 != 0)
						{
						}
						num2 = (short)1627389955;
						num = (int)((global::System.IntPtr)num2);
					}
					IL_1A6:
					num2 = (short)351466146;
					short num3 = num2;
					num2 = (short)1470493346;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						continue;
					default:
						goto IL_1DB;
					}
					IL_36:
					global::System.Diagnostics.Trace.TraceInformation(string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튈붌첐좒Ꚗ욚욜鎠\udea2ﲦ튨颪킬麲颴骶", a_), new object[]
					{
						A_0.ConnectionInfo.ConnectionType,
						A_0.Family,
						A_0.SerialNumber,
						A_0.ModelNumber
					}) + string.Format(global::SpecialFeatures.AcpReportManagerLib.RptMgrErrorHandler.b("튈붌첐좒Ꚗ욚붜횞튠莢욦춨슪슬辮ﾲ骶銾ꋀ곂꣄럆꣈뿊꓌귎뷐뛒ꋘꃜ", a_), A_0.SoftwareVersion, A_0.CodeplugVersion, A_0.ConnectionInfo.IsTlsPskCompatible));
					num2 = (short)449052673;
					num = (int)((global::System.IntPtr)num2);
					goto IL_18;
				}
				IL_1DB:
				num2 = (short)1851457536;
				if (num2 != 0)
				{
				}
			}
			catch (global::System.InvalidOperationException)
			{
				global::Motorola.Common.CustomException.CommonException ex = global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Could_not_connect_to_the_radio);
				global::SpecialFeatures.Comms.Logger.LogWithDateTime(ex.Message);
				throw ex;
			}
			num2 = (short)1964900352;
			short num4 = num2;
		}

		// Token: 0x060011C5 RID: 4549 RVA: 0x00184B74 File Offset: 0x00182D74
		private global::Motorola.Common.Communication.CommonUtil.DeviceInfo a(global::Motorola.Common.Communication.CommonUtil.ConnectionType A_0)
		{
			global::System.Collections.Generic.List<global::Motorola.Common.Communication.CommonUtil.DeviceInfo> list;
			for (;;)
			{
				IL_00:
				switch (0)
				{
				case 0:
					goto IL_30;
				}
				int num;
				short num2;
				global::System.DateTime now;
				global::System.TimeSpan t;
				for (;;)
				{
					IL_0A:
					switch (num)
					{
					case 0:
						goto IL_BE;
					case 1:
						goto IL_1E6;
					case 2:
						goto IL_1A1;
					case 3:
						if (!this.a.IsRadioInBpMode(list[0]))
						{
							num2 = (short)877658112;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						goto IL_1A1;
					case 4:
						num2 = (short)1432289281;
						if (num2 != 0)
						{
						}
						global::System.Threading.Thread.Sleep(global::System.TimeSpan.FromSeconds(1.0));
						num2 = (short)1642594309;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 5:
						goto IL_1A1;
					case 6:
						if (!(global::System.DateTime.Now - now <= t))
						{
							num2 = (short)662372353;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						list = this.a.ListConnectedDevices((int)A_0);
						num2 = (short)369295367;
						num = (int)((global::System.IntPtr)num2);
						continue;
					case 7:
					{
						if (list.Count != 0)
						{
							num2 = (short)666107907;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						num2 = (short)1020657664;
						short num3 = num2;
						num2 = (short)698518880;
						short num4 = num2;
						num2 = (short)285445472;
						switch ((num4 == num2) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_00;
						default:
							num2 = (short)1569980416;
							if (num2 != 0)
							{
							}
							num2 = (short)1903427588;
							num = (int)((global::System.IntPtr)num2);
							continue;
						}
						break;
					}
					}
					break;
					IL_1A1:
					num2 = (short)1390215174;
					num = (int)((global::System.IntPtr)num2);
				}
				IL_30:
				global::System.Threading.Thread.Sleep(global::System.TimeSpan.FromSeconds(2.0));
				t = global::System.TimeSpan.FromSeconds(60.0);
				now = global::System.DateTime.Now;
				num2 = (short)251723778;
				num = (int)((global::System.IntPtr)num2);
				goto IL_0A;
			}
			IL_BE:
			return list[0];
			IL_1E6:
			throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Radio_Connection_Failed);
		}

		// Token: 0x060011C6 RID: 4550 RVA: 0x00184DA0 File Offset: 0x00182FA0
		public global::Motorola.Common.Communication.CommonUtil.DeviceInfo[] GetAllConnectedDevice()
		{
			global::Motorola.Common.Communication.CommonUtil.DeviceInfo[] array;
			try
			{
				array = this.a.ListConnectedDevices(4).ToArray<global::Motorola.Common.Communication.CommonUtil.DeviceInfo>();
				goto IL_11A;
			}
			catch (global::System.Exception ex)
			{
				global::SpecialFeatures.CommonExceptionHelper.ConvertExceptiontAndThrow(ex);
				throw global::SpecialFeatures.CommonExceptionHelper.CreateCommonException(global::Motorola.Common.CustomException.CommonErrorCode.CommunicationServiceNotAvailabe, global::Motorola.CommonCPS.ResourceRepository.Resources.CommunicationServiceNotAvailabe, ex);
			}
			goto IL_2C;
			int num;
			short num2;
			for (;;)
			{
				IL_4A:
				switch (num)
				{
				case 0:
					goto IL_7C;
				case 1:
					if (array != null)
					{
						num2 = (short)26148866;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_150;
				case 2:
					goto IL_14B;
				case 3:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					continue;
				}
				IL_60:
				if (array.Length != 0)
				{
					return array;
				}
				num2 = (short)1145896960;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_7C:
			num2 = (short)1461387265;
			if (num2 != 0)
			{
			}
			num2 = (short)1718161825;
			short num3 = num2;
			num2 = (short)35328417;
			switch ((num3 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
				IL_11A:
				num2 = (short)706281473;
				num = (int)((global::System.IntPtr)num2);
				goto IL_4A;
			case 1:
				break;
			default:
			{
				num2 = (short)1067384832;
				short num4 = num2;
				break;
			}
			}
			num2 = (short)1628635136;
			if (num2 != 0)
			{
			}
			goto IL_150;
			IL_14B:
			goto IL_2C;
			IL_150:
			throw global::SpecialFeatures.CommonExceptionHelper.CreateDirectMessageCommonException(global::CommonResources.AppResources.Could_not_find_a_radio_connected_to_a_USB_port);
			IL_2C:
			num2 = (short)255590403;
			num = (int)((global::System.IntPtr)num2);
			goto IL_4A;
		}

		// Token: 0x040009BA RID: 2490
		private readonly global::Motorola.Common.Communication.Service.IDeviceDiscovery a;

		// Token: 0x040009BB RID: 2491
		private readonly global::SpecialFeatures.Comms.DeviceDiscoveryHandler b;

		// Token: 0x040009BC RID: 2492
		private readonly bool c;

		// Token: 0x040009BD RID: 2493
		private readonly global::SpecialFeatures.ReadWritePassword.ReadWritePasswordApp d;

		// Token: 0x040009BE RID: 2494
		public static int pos;
	}
}
