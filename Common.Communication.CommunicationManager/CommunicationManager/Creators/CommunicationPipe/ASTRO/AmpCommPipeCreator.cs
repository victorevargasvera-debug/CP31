using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TLS.TlsPskForAstro;

namespace Motorola.Common.Communication.CommunicationManager.Creators.CommunicationPipe.ASTRO
{
	// Token: 0x02000041 RID: 65
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, (global::Motorola.Common.Communication.CommonUtil.RadioOperation)61439UL)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AMPRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, (global::Motorola.Common.Communication.CommonUtil.RadioOperation)61439UL)]
	internal class AmpCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000156 RID: 342 RVA: 0x0001B310 File Offset: 0x00019510
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int a_ = 4;
			short num = (short)50987008;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				switch (0)
				{
				case 0:
					goto IL_67;
				}
				global::ProcessorType processorType;
				int portNumber;
				for (;;)
				{
					IL_30:
					string value;
					switch (num2)
					{
					case 0:
						value = sessionParameter.Psk;
						goto IL_1A6;
					case 1:
						goto IL_187;
					case 2:
						num = (short)1983119370;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_15E;
					case 4:
						goto IL_F8;
					case 5:
						if (processorType != global::ProcessorType.BP)
						{
							num = (short)1510604808;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_2B2;
					case 6:
					{
						num = (short)1650982912;
						short num3 = num;
						num = (short)1214316548;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 7:
						if (sessionParameter == null)
						{
							num = (short)1192820745;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)236060672;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						num = (short)429457409;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 9:
					{
						num = (short)41804726;
						short num4 = num;
						num = (short)1056170934;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_187;
						default:
							num = (short)1582497792;
							if (num != 0)
							{
							}
							num = (short)1108213761;
							if (num != 0)
							{
							}
							num = (short)1813643275;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 10:
						goto IL_13F;
					case 11:
						value = null;
						goto IL_1A6;
					}
					goto IL_67;
					IL_1A6:
					if (!string.IsNullOrWhiteSpace(value))
					{
						num = (short)1270939654;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					num = (short)1320812547;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_187:
					if (processorType != global::ProcessorType.AP)
					{
						num = (short)214237186;
						num2 = (int)((global::System.IntPtr)num);
					}
					else
					{
						portNumber = int.Parse(deviceInfo.ConnectionInfo.Location);
						num = (short)615841799;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_F8:
				string text = sessionParameter.Psk;
				goto IL_1CC;
				IL_13F:
				global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo ampDeviceInfo;
				throw new global::System.NotSupportedException(string.Format(global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("᝘㑚⥜罞በᙢᕤᝦ٨ᥪᥬ੮ᕰ卲մնᙸ᡺᡼౾Ꞇﶈﶌꮐ뎒Ꞗ떚", a_), ampDeviceInfo.ProcessorType));
				IL_15E:
				text = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("楘歚浜潞兠卢啤坦奨孪嵬彮䅰䍲䕴䝶䥸䭺䵼佾", a_);
				IL_1CC:
				string psk = text;
				global::System.Net.IPAddress ipaddress;
				global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe tcpClientCommPipe = new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipaddress, portNumber, false);
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory connectClientFactory = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory();
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient identityClient = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient(tcpClientCommPipe, connectClientFactory);
				return new global::Motorola.Common.Communication.CommunicationPipe.SecureHttpsCommPipe(new global::Motorola.Common.Communication.TLS.TlsPskForAstro.AmpTlsHandler(tcpClientCommPipe, connectClientFactory, identityClient, psk));
				IL_2B2:
				return new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipaddress, 8002, false);
				IL_67:
				ampDeviceInfo = (deviceInfo as global::Motorola.Common.Communication.CommonUtil.AmpDeviceInfo);
				ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(ampDeviceInfo);
				processorType = ampDeviceInfo.ProcessorType;
				num = (short)277676037;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_30;
			}
			}
		}
	}
}
