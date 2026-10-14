using System;
using System.Linq;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Runtime.CompilerServices;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using IACustomException;
using SSLMangrComp.Connectors;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x0200003C RID: 60
	public class TlsClientConnector : global::SSLMangrComp.Connectors.b
	{
		// Token: 0x0600015A RID: 346 RVA: 0x00013F24 File Offset: 0x00012124
		public void Connect(global::System.Net.IPAddress pnIpAddress, int portNumber)
		{
			short num = (short)1193410561;
			if (num != 0)
			{
			}
			num = (short)380911030;
			short num2 = num;
			num = (short)2027109814;
			switch (num2 == num)
			{
			}
			num = (short)403767296;
			short num3 = num;
			num = (short)876150784;
			if (num != 0)
			{
			}
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600015B RID: 347 RVA: 0x00013FD4 File Offset: 0x000121D4
		public void Connect(global::System.Net.IPAddress pnIpAddress, int portNumber, global::SSLMangrComp.SecureClientConfiguration clientConfig)
		{
			int a_ = 4;
			short num = (short)1414725632;
			switch (num)
			{
			default:
			{
				num = (short)478740481;
				int num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					num = (short)399572992;
					short num3 = num;
					switch (num2)
					{
					case 0:
						goto IL_4B5;
					case 1:
						switch (0)
						{
						case 0:
							goto IL_82;
						}
						continue;
					case 2:
						return;
					}
					IL_82:
					num = (short)1912668081;
					short num4 = num;
					num = (short)510394289;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
						num = (short)16121856;
						if (num != 0)
						{
						}
						if (this.b == null)
						{
							num = (short)728825857;
							if (num != 0)
							{
							}
							string text = base.GetType().ToString();
							text += global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("వ笷唹刻倽┿⅁ぃ", a_);
							num = (short)1939734528;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					num = (short)1768226818;
					num2 = (int)((global::System.IntPtr)num);
				}
				return;
				IL_4B5:
				try
				{
					switch (0)
					{
					case 0:
						goto IL_145;
					}
					global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection x509Certificate2Collection;
					for (;;)
					{
						IL_FE:
						switch (num2)
						{
						case 0:
							goto IL_1D2;
						case 1:
							if (!global::SSLMangrComp.ConnectionLayer.TlsClientConnector.a.Connected)
							{
								num = (short)1296629764;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							this.b = new global::System.Net.Security.SslStream(global::SSLMangrComp.ConnectionLayer.TlsClientConnector.a.GetStream(), false, new global::System.Net.Security.RemoteCertificateValidationCallback(this.ValidateRemoteCert), new global::System.Net.Security.LocalCertificateSelectionCallback(this.ClientCertificateSelectionCallback));
							this.b.AuthenticateAsClient(pnIpAddress.ToString(), x509Certificate2Collection, global::System.Security.Authentication.SslProtocols.None, false);
							num = (short)1884946439;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							num = (short)548667407;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 3:
						{
							global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate = global::SSLMangrComp.CertificateLoader.LoadPfxCertificate(global::System.Convert.FromBase64String(clientConfig.ClientCertificate), clientConfig.ClientKeyPassphrase);
							x509Certificate2Collection.Add(certificate);
							num = (short)718209036;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 4:
							goto IL_289;
						case 5:
							if (this.b.CipherAlgorithm != global::System.Security.Authentication.CipherAlgorithmType.Aes256)
							{
								num = (short)1145634826;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1081606150;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							goto IL_43C;
						case 7:
							if (!this.b.IsMutuallyAuthenticated)
							{
								num = (short)854261768;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1311899661;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 8:
							goto IL_3C5;
						case 9:
							if (this.b.CipherStrength < 256)
							{
								num = (short)335478784;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)1613889541;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 10:
							goto IL_21C;
						case 11:
							goto IL_40A;
						case 12:
							goto IL_239;
						case 13:
							if (!this.b.IsEncrypted)
							{
								num = (short)1018757131;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)436600841;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						case 14:
							if (!string.IsNullOrEmpty(clientConfig.ClientCertificate))
							{
								num = (short)1101201410;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_239;
						case 15:
							if (!string.IsNullOrEmpty(clientConfig.ClientKeyPassphrase))
							{
								num = (short)1734475779;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_239;
						}
						goto IL_145;
						IL_239:
						global::SSLMangrComp.ConnectionLayer.TlsClientConnector.a = new global::System.Net.Sockets.TcpClient(pnIpAddress.ToString(), portNumber);
						num = (short)1842348033;
						num2 = (int)((global::System.IntPtr)num);
					}
					IL_1D2:
					this.ShutdownClient();
					string text;
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_CipherStrengthFail)
					{
						Source = text
					};
					IL_21C:
					this.ShutdownClient();
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_AESCipherFail)
					{
						Source = text
					};
					IL_289:
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket);
					IL_3C5:
					this.ShutdownClient();
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_MutualAuthenticationFail)
					{
						Source = text
					};
					IL_40A:
					this.ShutdownClient();
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_EncryptionFailed)
					{
						Source = text
					};
					IL_43C:
					return;
					IL_145:
					x509Certificate2Collection = new global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection();
					num = (short)1180434446;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_FE;
				}
				catch (global::IACustomException.IACommonException)
				{
					throw;
				}
				catch (global::System.Exception systemException)
				{
					this.ShutdownClient();
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_LE_UnableToOpenSocket, systemException);
				}
				return;
			}
			}
		}

		// Token: 0x0600015C RID: 348 RVA: 0x000144D0 File Offset: 0x000126D0
		public void ShutdownClient()
		{
			short num = (short)1434648578;
			int num2 = (int)((global::System.IntPtr)num);
			for (;;)
			{
				num = (short)1606877184;
				short num3 = num;
				num = (short)505675777;
				if (num != 0)
				{
				}
				switch (num2)
				{
				case 0:
				{
					num = (short)1922567453;
					short num4 = num;
					num = (short)1559170333;
					switch ((num4 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_8B;
					default:
						goto IL_11B;
					}
					break;
				}
				case 1:
					this.b.Close();
					this.b = null;
					num = (short)1571815427;
					num2 = (int)((global::System.IntPtr)num);
					continue;
				case 2:
					switch (0)
					{
					case 0:
						goto IL_83;
					}
					continue;
				case 3:
					goto IL_CF;
				}
				goto IL_83;
				IL_8B:
				num = (short)149815297;
				num2 = (int)((global::System.IntPtr)num);
				continue;
				IL_83:
				if (this.b != null)
				{
					goto IL_8B;
				}
				IL_CF:
				num = (short)92733440;
				num2 = (int)((global::System.IntPtr)num);
			}
			IL_11B:
			num = (short)2062417920;
			if (num != 0)
			{
			}
			global::System.Net.Sockets.TcpClient tcpClient = global::SSLMangrComp.ConnectionLayer.TlsClientConnector.a;
			if (tcpClient == null)
			{
				return;
			}
			tcpClient.Close();
		}

		// Token: 0x0600015D RID: 349 RVA: 0x00014620 File Offset: 0x00012820
		public void WriteData(byte[] dataToWrite)
		{
			int a_ = 8;
			short num;
			if (this.b == null)
			{
				num = (short)830769426;
				short num2 = num;
				num = (short)494766354;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
				{
					num = (short)397803521;
					if (num != 0)
					{
					}
					num = (short)385810432;
					if (num != 0)
					{
					}
					string text = base.GetType().ToString();
					text += global::SSLMangrComp.ConnectionLayer.UDPClientConnector.b("9欻䰽⤿㙁⅃Ʌ⥇㹉ⵋ", a_);
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_MessageCouldNotBeParsed)
					{
						Source = text
					};
				}
				}
			}
			num = (short)387514368;
			short num3 = num;
			this.b.Write(dataToWrite, 0, dataToWrite.Length);
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00014720 File Offset: 0x00012920
		public bool ValidateRemoteCert(object sender, global::System.Security.Cryptography.X509Certificates.X509Certificate certificate, global::System.Security.Cryptography.X509Certificates.X509Chain chain, global::System.Net.Security.SslPolicyErrors sslPolicyErrors)
		{
			short num = (short)1884574290;
			short num2 = num;
			num = (short)808014418;
			switch (num2 == num)
			{
			}
			num = (short)1329987584;
			if (num != 0)
			{
			}
			num = (short)298778624;
			short num3 = num;
			num = (short)1460731905;
			if (num != 0)
			{
			}
			return global::SSLMangrComp.CertificateValidator.ValidateRemoteCertificate(new global::System.Security.Cryptography.X509Certificates.X509Certificate2(certificate), chain, sslPolicyErrors);
		}

		// Token: 0x0600015F RID: 351 RVA: 0x000147D8 File Offset: 0x000129D8
		public global::System.Security.Cryptography.X509Certificates.X509Certificate ClientCertificateSelectionCallback(object sender, string targetHost, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection localCerts, global::System.Security.Cryptography.X509Certificates.X509Certificate remoteCert, string[] acceptableIssuers)
		{
			short num = (short)648740864;
			int num2 = (int)num;
			switch (num2)
			{
			default:
			{
				num = (short)1539309568;
				short num3 = num;
				num = (short)1726742531;
				num2 = (int)((global::System.IntPtr)num);
				for (;;)
				{
					global::System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator enumerator;
					switch (num2)
					{
					case 0:
						if (localCerts.Count <= 0)
						{
							num = (short)374472705;
							if (num != 0)
							{
							}
							num = (short)1657405442;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_302;
					case 1:
						num = (short)1224998912;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_300;
					case 3:
						switch (0)
						{
						case 0:
							goto IL_81;
						}
						continue;
					case 4:
						try
						{
							num = (short)1170276357;
							num2 = (int)((global::System.IntPtr)num);
							global::System.Security.Cryptography.X509Certificates.X509Certificate result;
							for (;;)
							{
								switch (num2)
								{
								case 0:
									if (acceptableIssuers.Any(new global::System.Func<string, bool>(a2.b)))
									{
										num = (short)1424293894;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									break;
								case 1:
									goto IL_104;
								case 2:
									num = (short)1434714115;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								case 3:
									goto IL_1B2;
								case 4:
								{
									if (!enumerator.MoveNext())
									{
										num = (short)899219458;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									global::System.Security.Cryptography.X509Certificates.X509Certificate a = enumerator.Current;
									num = (short)1916862464;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								case 5:
									switch (0)
									{
									case 0:
										goto IL_E6;
									}
									continue;
								case 6:
									result = a2.a;
									num = (short)496173057;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								IL_15F:
								num = (short)555024388;
								num2 = (int)((global::System.IntPtr)num);
								continue;
								IL_E6:
								goto IL_15F;
							}
							IL_104:
							return result;
							IL_1B2:
							goto IL_29B;
						}
						finally
						{
							switch (0)
							{
							case 0:
								goto IL_1D4;
							}
							global::System.IDisposable disposable;
							for (;;)
							{
								IL_1C1:
								switch (num2)
								{
								case 0:
									goto IL_228;
								case 1:
									IL_1F0:
									if (disposable != null)
									{
										num = (short)1286471682;
										num2 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_228;
								case 2:
									disposable.Dispose();
									num = (short)1570242560;
									num2 = (int)((global::System.IntPtr)num);
									continue;
								}
								goto IL_1D4;
								IL_228:
								num = (short)1442935713;
								short num4 = num;
								num = (short)1536717729;
								switch ((num4 == num) ? 1 : 0)
								{
								case 0:
								case 2:
									goto IL_1F0;
								default:
									goto IL_25D;
								}
							}
							IL_25D:
							num = (short)197984256;
							if (num != 0)
							{
							}
							goto EndFinally_8;
							IL_1D4:
							disposable = (enumerator as global::System.IDisposable);
							num = (short)1440022529;
							num2 = (int)((global::System.IntPtr)num);
							goto IL_1C1;
							EndFinally_8:;
						}
						goto IL_275;
					}
					IL_81:
					if (acceptableIssuers.Length == 0)
					{
						num = (short)1502085121;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					IL_275:
					enumerator = localCerts.GetEnumerator();
					num = (short)243597316;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_29B:
				return null;
				IL_300:
				return null;
				IL_302:
				return localCerts[0];
			}
			}
		}

		// Token: 0x040000C0 RID: 192
		private static global::System.Net.Sockets.TcpClient a;

		// Token: 0x040000C1 RID: 193
		private global::System.Net.Security.SslStream b;

		// Token: 0x0200003D RID: 61
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000162 RID: 354 RVA: 0x00014B34 File Offset: 0x00012D34
			internal bool b(string A_0)
			{
				short num = (short)527884087;
				short num2 = num;
				num = (short)1962467127;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1113980928;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)860946432;
				if (num != 0)
				{
				}
				num = (short)1944649729;
				if (num != 0)
				{
				}
				return string.Compare(this.a.Issuer, A_0, global::System.StringComparison.Ordinal) == 0;
			}

			// Token: 0x040000C2 RID: 194
			public global::System.Security.Cryptography.X509Certificates.X509Certificate a;
		}
	}
}
