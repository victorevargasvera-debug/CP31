using System;
using System.Net;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TLS.TlsPskForAstro;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x0200001A RID: 26
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.WIFI, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, (global::Motorola.Common.Communication.CommonUtil.RadioOperation)63487UL)]
	internal class AstroWifiCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x06000069 RID: 105 RVA: 0x0000A6D0 File Offset: 0x000088D0
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int a_ = 7;
			short num = (short)885325824;
			switch (num)
			{
			default:
			{
				global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe tcpClientCommPipe;
				for (;;)
				{
					num = (short)1633615877;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						string value;
						switch (num2)
						{
						case 0:
							return tcpClientCommPipe;
						case 1:
							if (!deviceInfo.ConnectionInfo.IsTlsPskCompatible)
							{
								num = (short)922484736;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1840578567;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)1304821763;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							goto IL_1C1;
						case 4:
							goto IL_1E5;
						case 5:
							switch (0)
							{
							case 0:
								goto IL_76;
							}
							continue;
						case 6:
						{
							num = (short)1522204672;
							short num3 = num;
							value = null;
							goto IL_187;
						}
						case 7:
							if (sessionParameter == null)
							{
								num = (short)269352969;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1413283848;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							value = sessionParameter.Psk;
							goto IL_187;
						case 9:
							num = (short)716963846;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_76:
						global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
						global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = deviceInfo.ConnectionInfo;
						int portNumber;
						if (!int.TryParse((connectionInfo != null) ? connectionInfo.Location : null, out portNumber))
						{
							portNumber = 52010;
						}
						tcpClientCommPipe = new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipaddress, portNumber, false);
						num = (short)2056060929;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_187:
						if (!string.IsNullOrWhiteSpace(value))
						{
							num = (short)251396098;
							num2 = (int)((global::System.IntPtr)num);
						}
						else
						{
							num = (short)2008023044;
							num2 = (int)((global::System.IntPtr)num);
						}
					}
					IL_1E5:
					num = (short)593879723;
					short num4 = num;
					num = (short)354738859;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						goto IL_21B;
					}
				}
				return tcpClientCommPipe;
				IL_1C1:
				string text = sessionParameter.Psk;
				goto IL_268;
				IL_21B:
				num = (short)542179329;
				if (num != 0)
				{
				}
				num = (short)765067264;
				if (num != 0)
				{
				}
				text = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("汛湝偟剡呣噥塧婩屫幭䁯䉱䑳䙵䡷䩹䱻乽끿늁", a_);
				IL_268:
				string psk = text;
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory connectClientFactory = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory();
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient identityClient = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient(tcpClientCommPipe, connectClientFactory);
				return new global::Motorola.Common.Communication.CommunicationPipe.SecureTlsCommPipe(new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsHandler(tcpClientCommPipe, connectClientFactory, identityClient, psk));
			}
			}
		}
	}
}
