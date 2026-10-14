using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TLS.TlsPskForAstro;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000017 RID: 23
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Bluetooth, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, (global::Motorola.Common.Communication.CommonUtil.RadioOperation)59391UL)]
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.NetAdapter, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, (global::Motorola.Common.Communication.CommonUtil.RadioOperation)59391UL)]
	internal class AstroUsbBtCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000063 RID: 99 RVA: 0x0000A1B0 File Offset: 0x000083B0
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int a_ = 13;
			short num = (short)1974468608;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				int portNumber;
				global::System.Net.IPAddress ipaddress;
				for (;;)
				{
					IL_27:
					switch (0)
					{
					case 0:
						goto IL_60;
					}
					for (;;)
					{
						IL_31:
						string value;
						switch (num2)
						{
						case 0:
						{
							if (sessionParameter != null)
							{
								num = (short)845086722;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)843669386;
							short num3 = num;
							num = (short)1415470986;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_27;
							default:
								num = (short)338886656;
								if (num != 0)
								{
								}
								num = (short)251985927;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							num = (short)1560543235;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							value = sessionParameter.Psk;
							goto IL_23E;
						case 3:
							goto IL_231;
						case 4:
							num = (short)714997768;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 5:
							if (!deviceInfo.ConnectionInfo.IsTlsPskCompatible)
							{
								num = (short)1759117313;
								if (num != 0)
								{
								}
								num = (short)58982401;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							portNumber = int.Parse(deviceInfo.ConnectionInfo.Location);
							num = (short)1549336576;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_1C4;
						case 7:
						{
							num = (short)1573257216;
							short num4 = num;
							num = (short)912982025;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 8:
							goto IL_1F1;
						case 9:
							value = null;
							goto IL_23E;
						}
						break;
						IL_23E:
						if (!string.IsNullOrWhiteSpace(value))
						{
							num = (short)427491332;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)528089094;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_60:
					ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
					num = (short)763166725;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_31;
				}
				IL_1C4:
				string text = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("剡呣噥塧婩屫幭䁯䉱䑳䙵䡷䩹䱻乽끿늁뒃뚅뢇", a_);
				goto IL_266;
				IL_1F1:
				text = sessionParameter.Psk;
				goto IL_266;
				IL_231:
				return new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipaddress, 8002, false);
				IL_266:
				string psk = text;
				global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe tcpClientCommPipe = new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipaddress, portNumber, false);
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory connectClientFactory = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory();
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient identityClient = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient(tcpClientCommPipe, connectClientFactory);
				return new global::Motorola.Common.Communication.CommunicationPipe.SecureTlsCommPipe(new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsHandler(tcpClientCommPipe, connectClientFactory, identityClient, psk));
			}
			}
		}
	}
}
