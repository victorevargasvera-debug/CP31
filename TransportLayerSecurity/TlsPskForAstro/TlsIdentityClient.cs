using System;
using CommonUtility;
using Motorola.Common.Communication.CommunicationPipe;
using Motorola.Common.CustomException;
using Org.BouncyCastle.Crypto.Tls;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro
{
	// Token: 0x02000027 RID: 39
	public class TlsIdentityClient : global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsIdentityClient
	{
		// Token: 0x060000D9 RID: 217 RVA: 0x0000C088 File Offset: 0x0000A288
		public TlsIdentityClient(global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe communicationPipe, global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsConnectClientFactory connectClientFactory)
		{
			this.a = communicationPipe;
			this.b = connectClientFactory;
		}

		// Token: 0x060000DA RID: 218 RVA: 0x0000C0AC File Offset: 0x0000A2AC
		public byte[] GetIdentityHint()
		{
			short num = (short)1140850688;
			switch (num)
			{
			default:
			{
				num = (short)1838481408;
				short num2 = num;
				global::Motorola.Common.Communication.TLS.TlsClientProtocol tlsClientProtocol = null;
				goto IL_4A;
				byte[] identityHint;
				try
				{
					global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient tlsPskClient;
					for (;;)
					{
						IL_4A:
						this.a.OpenPort(-1);
						tlsClientProtocol = this.b.Create(this.a.GetStream());
						tlsPskClient = new global::Motorola.Common.Communication.TLS.TlsPskForAstro.TlsPskClient();
						try
						{
							tlsClientProtocol.Connect(tlsPskClient);
						}
						catch (global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert tlsFatalAlert) when (tlsFatalAlert.AlertDescription == 80)
						{
						}
						num = (short)657987162;
						short num3 = num;
						num = (short)624105050;
						switch ((num3 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							break;
						default:
							goto IL_D4;
						}
					}
					IL_D4:
					num = (short)386924545;
					if (num != 0)
					{
					}
					num = (short)1226899456;
					if (num != 0)
					{
					}
					identityHint = tlsPskClient.GetIdentityHint();
				}
				catch (global::System.InvalidOperationException systemException)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Security_OpenSSL_Initialize_Failed, systemException);
				}
				finally
				{
					num = (short)1888288774;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							goto IL_1E6;
						case 1:
							goto IL_1E8;
						case 2:
							tlsClientProtocol.Close();
							num = (short)185794561;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
							if (this.a.IsOpen)
							{
								num = (short)886439941;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_247;
						case 4:
							if (!tlsClientProtocol.IsClosed)
							{
								num = (short)297009154;
								num4 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_1E8;
						case 5:
							this.a.ClosePort();
							num = (short)1074462720;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							switch (0)
							{
							case 0:
								goto IL_170;
							}
							continue;
						case 7:
							num = (short)2000945156;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_170:
						if (tlsClientProtocol != null)
						{
							num = (short)1144848391;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_1E8:
						num = (short)796917763;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_1E6:
					IL_247:;
				}
				return identityHint;
			}
			}
		}

		// Token: 0x060000DB RID: 219 RVA: 0x0000C350 File Offset: 0x0000A550
		public string GetPskId()
		{
			short num = (short)1668884246;
			short num2 = num;
			num = (short)1726752534;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1500446720;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1914306560;
			if (num != 0)
			{
			}
			num = (short)1101201409;
			if (num != 0)
			{
			}
			return global::CommonUtility.TlsPskUtility.GetPskId(this.GetIdentityHint());
		}

		// Token: 0x04000056 RID: 86
		private readonly global::Motorola.Common.Communication.CommunicationPipe.ICommunicationPipe a;

		// Token: 0x04000057 RID: 87
		private readonly global::Motorola.Common.Communication.TLS.TlsPskForAstro.ITlsConnectClientFactory b;
	}
}
