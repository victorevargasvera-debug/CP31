using System;
using System.Net;
using CommonUtility;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.Communication.TLS.TlsPskForAstro;

namespace Motorola.Common.Communication.CommunicationManager
{
	// Token: 0x02000015 RID: 21
	[global::Motorola.Common.Communication.CommunicationManager.Initializer(global::Motorola.Common.Communication.CommonUtil.ConnectionType.Otap, global::Motorola.Common.Communication.CommonUtil.ProductFamily.AstroRadio, global::Motorola.Common.Communication.CommonUtil.RadioStorage.Any, (global::Motorola.Common.Communication.CommonUtil.RadioOperation)59391UL)]
	internal class AstroOtapCommPipeCreator : global::Motorola.Common.Communication.CommunicationManager.ICommunicationPipeCreator
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00009BC0 File Offset: 0x00007DC0
		public global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe Create(global::Motorola.Common.Communication.CommonUtil.DeviceInfo deviceInfo, global::Motorola.Common.Communication.CommonUtil.SessionParameter sessionParameter)
		{
			int a_ = 7;
			short num = (short)865402880;
			switch (num)
			{
			default:
			{
				num = (short)1954021381;
				int num2 = (int)((global::System.IntPtr)num);
				global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe tcpClientCommPipe;
				for (;;)
				{
					string value;
					switch (num2)
					{
					case 0:
						if (!deviceInfo.ConnectionInfo.IsTlsPskCompatible)
						{
							num = (short)221773841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)90963978;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 1:
						sessionParameter.Psk = (string.IsNullOrEmpty(sessionParameter.Psk) ? sessionParameter.Psk : global::CommonUtility.TlsPskHashManager.Hash(sessionParameter.Psk, 4000, 16));
						num = (short)1565786126;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						num = (short)660996112;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						if (sessionParameter.ArchiveSession)
						{
							num = (short)1664352267;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_292;
					case 4:
					{
						num = (short)2109669376;
						short num3 = num;
						num = (short)1278672914;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 5:
						switch (0)
						{
						case 0:
							goto IL_9C;
						}
						continue;
					case 6:
						num = (short)982253568;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 7:
						num = (short)1096876033;
						if (num != 0)
						{
						}
						value = null;
						goto IL_379;
					case 8:
						value = sessionParameter.Psk;
						goto IL_379;
					case 9:
						num = (short)1557004291;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						if (deviceInfo.ConnectionInfo.IsTlsPskCompatible)
						{
							num = (short)1964572674;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_292;
					case 11:
						num = (short)1049559041;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 12:
						goto IL_3FD;
					case 13:
					{
						if (sessionParameter != null)
						{
							num = (short)900399112;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)85884253;
						short num4 = num;
						num = (short)1260682589;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_380;
						default:
							num = (short)127401984;
							if (num != 0)
							{
							}
							num = (short)708837391;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 14:
						goto IL_292;
					case 15:
						num = (short)871956487;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 16:
						if (sessionParameter != null)
						{
							num = (short)1959329801;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_292;
					case 17:
						return tcpClientCommPipe;
					case 18:
						goto IL_3DD;
					case 19:
						if (deviceInfo.ConnectionInfo.OtapConnectionType == global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LTE)
						{
							num = (short)553385990;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						return tcpClientCommPipe;
					}
					IL_9C:
					global::System.Net.IPAddress ipaddress = global::Motorola.Common.Communication.CommunicationManager.Utilities.GetIPAddress(deviceInfo);
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo = deviceInfo.ConnectionInfo;
					int portNumber;
					if (!int.TryParse((connectionInfo != null) ? connectionInfo.Location : null, out portNumber))
					{
						goto IL_E0;
					}
					global::Motorola.Common.Communication.CommonUtil.ConnectionInfo connectionInfo2 = deviceInfo.ConnectionInfo;
					if (connectionInfo2 != null && connectionInfo2.OtapConnectionType == global::Motorola.Common.Communication.CommonUtil.OTAPConnectionType.LMR)
					{
						goto IL_E0;
					}
					IL_E8:
					tcpClientCommPipe = new global::Motorola.Common.Communication.CommunicationPipe.TcpClientCommPipe(ipaddress, portNumber, false);
					num = (short)851987;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_E0:
					portNumber = 8003;
					goto IL_E8;
					IL_292:
					num = (short)169934861;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_380:
					num = (short)1731133444;
					num2 = (int)((global::System.IntPtr)num);
					continue;
					IL_379:
					if (!string.IsNullOrWhiteSpace(value))
					{
						goto IL_380;
					}
					num = (short)838664204;
					num2 = (int)((global::System.IntPtr)num);
				}
				return tcpClientCommPipe;
				IL_3DD:
				string text = sessionParameter.Psk;
				goto IL_40D;
				IL_3FD:
				text = global::Motorola.Common.Communication.CommunicationManager.Creators.SequenceManager.AMP.AmpFileFlashSequenceManagerCreator.b("汛湝偟剡呣噥塧婩屫幭䁯䉱䑳䙵䡷䩹䱻乽끿늁", a_);
				IL_40D:
				string psk = text;
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory connectClientFactory = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsConnectClientFactory();
				global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient identityClient = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsIdentityClient(tcpClientCommPipe, connectClientFactory);
				return new global::Motorola.Common.Communication.CommunicationPipe.SecureTlsCommPipe(new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsHandler(tcpClientCommPipe, connectClientFactory, identityClient, psk));
			}
			}
		}
	}
}
