using System;
using System.Net;
using System.Net.Security;
using System.Net.Sockets;
using System.Security.Authentication;
using System.Security.Cryptography.X509Certificates;
using IACustomException;
using SSLMangrComp.Connectors;

namespace SSLMangrComp.ConnectionLayer
{
	// Token: 0x02000045 RID: 69
	internal class h : global::SSLMangrComp.Connectors.c
	{
		// Token: 0x060001AD RID: 429 RVA: 0x00019E38 File Offset: 0x00018038
		public void Connect(global::SSLMangrComp.PNConnectionInfo connInfo)
		{
			short num;
			for (;;)
			{
				IL_00:
				num = (short)1923284992;
				int num2 = (int)num;
				switch (num2)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_3A;
					}
					for (;;)
					{
						IL_27:
						switch (num2)
						{
						case 0:
						{
							if (this.b != null)
							{
								num = (short)1273561090;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)601161729;
							if (num != 0)
							{
							}
							num = (short)1641228350;
							short num3 = num;
							num = (short)751970366;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)1115357184;
								if (num != 0)
								{
								}
								num = (short)1450115073;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 1:
							goto IL_461;
						case 2:
							goto IL_95;
						}
						break;
					}
					IL_3A:
					global::System.Net.IPAddress pnIp = connInfo.PNConnectionConfig.PnIp;
					int pnPort = connInfo.PNConnectionConfig.PnPort;
					this.c = connInfo.TLSClientConfig;
					num = (short)1883439104;
					num2 = (int)((global::System.IntPtr)num);
					goto IL_27;
				}
				}
			}
			IL_95:
			num = (short)73531392;
			short num4 = num;
			return;
			IL_461:
			try
			{
				switch (0)
				{
				case 0:
					goto IL_10B;
				}
				int num2;
				global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection x509Certificate2Collection;
				for (;;)
				{
					IL_CC:
					switch (num2)
					{
					case 0:
						if (string.IsNullOrEmpty(this.c.ClientKeyPassphrase))
						{
							num = (short)1239351307;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29C;
					case 1:
						if (!string.IsNullOrEmpty(this.c.ClientCertificate))
						{
							num = (short)2142765058;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_29C;
					case 2:
						num = (short)480116736;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 3:
						goto IL_1A0;
					case 4:
						if (this.b.CipherAlgorithm != global::System.Security.Authentication.CipherAlgorithmType.Aes256)
						{
							num = (short)1936457740;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1920663562;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 5:
						goto IL_331;
					case 6:
						goto IL_1F8;
					case 7:
						if (this.b.CipherStrength < 256)
						{
							num = (short)1656029187;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)664272900;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 8:
						goto IL_29C;
					case 9:
						if (!this.b.IsEncrypted)
						{
							num = (short)1372258310;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1038221319;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					case 10:
						goto IL_3B9;
					case 11:
					{
						global::System.Security.Cryptography.X509Certificates.X509Certificate2 certificate = global::SSLMangrComp.CertificateLoader.LoadPfxCertificate(global::System.Convert.FromBase64String(this.c.ClientCertificate), this.c.ClientKeyPassphrase);
						x509Certificate2Collection.Add(certificate);
						num = (short)1943011336;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					case 12:
						goto IL_286;
					case 13:
						if (!this.b.IsMutuallyAuthenticated)
						{
							num = (short)72024069;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						num = (short)1965293577;
						num2 = (int)((global::System.IntPtr)num);
						continue;
					}
					goto IL_10B;
					IL_29C:
					global::System.Net.IPAddress pnIp;
					int pnPort;
					global::SSLMangrComp.ConnectionLayer.h.a = new global::System.Net.Sockets.TcpClient(pnIp.ToString(), pnPort);
					this.b = new global::System.Net.Security.SslStream(global::SSLMangrComp.ConnectionLayer.h.a.GetStream(), false, new global::System.Net.Security.RemoteCertificateValidationCallback(this.a), new global::System.Net.Security.LocalCertificateSelectionCallback(this.a));
					this.b.AuthenticateAsClient(pnIp.ToString(), x509Certificate2Collection, global::System.Security.Authentication.SslProtocols.None, false);
					num = (short)1337655309;
					num2 = (int)((global::System.IntPtr)num);
				}
				IL_1A0:
				this.ShutdownClient();
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_CipherStrengthFail);
				IL_1F8:
				this.ShutdownClient();
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_CE_EncryptionFailed);
				IL_286:
				this.ShutdownClient();
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_AESCipherFail);
				IL_331:
				this.ShutdownClient();
				throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_MutualAuthenticationFail);
				IL_3B9:
				return;
				IL_10B:
				x509Certificate2Collection = new global::System.Security.Cryptography.X509Certificates.X509Certificate2Collection();
				num = (short)839647233;
				num2 = (int)((global::System.IntPtr)num);
				goto IL_CC;
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
		}

		// Token: 0x060001AE RID: 430 RVA: 0x0001A2E0 File Offset: 0x000184E0
		public void ShutdownClient()
		{
			short num;
			try
			{
				for (;;)
				{
					IL_00:
					num = (short)1773469696;
					int num2 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num2)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_40;
							}
							continue;
						case 1:
							goto IL_DA;
						case 2:
						{
							this.b.Close();
							this.b = null;
							num = (short)573360721;
							short num3 = num;
							num = (short)277793361;
							switch ((num3 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)985792512;
								if (num != 0)
								{
								}
								num = (short)1274150913;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 3:
							goto IL_14C;
						case 4:
							goto IL_135;
						case 5:
						{
							global::System.Net.Sockets.TcpClient tcpClient = global::SSLMangrComp.ConnectionLayer.h.a;
							if (tcpClient == null)
							{
								num = (short)1449984006;
								num2 = (int)((global::System.IntPtr)num);
								continue;
							}
							tcpClient.Close();
							num = (short)828112900;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						case 6:
							goto IL_135;
						}
						IL_40:
						if (this.b != null)
						{
							num = (short)1080229890;
							num2 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_DA:
						num = (short)1697054725;
						num2 = (int)((global::System.IntPtr)num);
						continue;
						IL_135:
						num = (short)739966979;
						num2 = (int)((global::System.IntPtr)num);
					}
				}
				IL_14C:;
			}
			catch
			{
			}
			num = (short)1348009984;
			short num4 = num;
			num = (short)1941307393;
			if (num != 0)
			{
			}
		}

		// Token: 0x060001AF RID: 431 RVA: 0x0001A4AC File Offset: 0x000186AC
		public void WriteData(byte[] dataToWrite)
		{
			short num = (short)866416677;
			short num2 = num;
			num = (short)59013157;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)2139029504;
				if (num != 0)
				{
				}
				num = (short)984612864;
				short num3 = num;
				num = (short)1178271745;
				if (num != 0)
				{
				}
				if (this.b == null)
				{
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_UDPDataSendFail);
				}
				try
				{
					this.b.Write(dataToWrite, 0, dataToWrite.Length);
				}
				catch (global::System.Exception systemException)
				{
					throw new global::IACustomException.IACommonException(global::IACustomException.IACommonErrorCode.SSL_PE_UDPDataSendFail, systemException);
				}
				break;
			}
			}
		}

		// Token: 0x060001B0 RID: 432 RVA: 0x0001A598 File Offset: 0x00018798
		public bool a(object A_0, global::System.Security.Cryptography.X509Certificates.X509Certificate A_1, global::System.Security.Cryptography.X509Certificates.X509Chain A_2, global::System.Net.Security.SslPolicyErrors A_3)
		{
			short num = (short)481755136;
			short num2 = num;
			num = (short)71477420;
			short num3 = num;
			num = (short)1284483244;
			switch (num3 == num)
			{
			}
			num = (short)49217536;
			if (num != 0)
			{
			}
			num = (short)1414135809;
			if (num != 0)
			{
			}
			return global::SSLMangrComp.CertificateValidator.ValidateRemoteCertificate(new global::System.Security.Cryptography.X509Certificates.X509Certificate2(A_1), A_2, A_3);
		}

		// Token: 0x060001B1 RID: 433 RVA: 0x0001A650 File Offset: 0x00018850
		public global::System.Security.Cryptography.X509Certificates.X509Certificate a(object A_0, string A_1, global::System.Security.Cryptography.X509Certificates.X509CertificateCollection A_2, global::System.Security.Cryptography.X509Certificates.X509Certificate A_3, string[] A_4)
		{
			global::System.Security.Cryptography.X509Certificates.X509Certificate result;
			for (;;)
			{
				IL_00:
				short num = (short)664928256;
				short num2 = num;
				num = (short)1297678336;
				int num3 = (int)num;
				switch (num3)
				{
				default:
				{
					switch (0)
					{
					case 0:
						goto IL_6C;
					}
					int num4;
					for (;;)
					{
						IL_51:
						switch (num3)
						{
						case 0:
							goto IL_13E;
						case 1:
							goto IL_13E;
						case 2:
							return result;
						case 3:
						{
							try
							{
								num = (short)1812791297;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									switch (num3)
									{
									case 0:
										num = (short)1091633156;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1C4;
										}
										continue;
									case 2:
									{
										global::System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator enumerator;
										if (!enumerator.MoveNext())
										{
											num = (short)9240576;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										global::System.Security.Cryptography.X509Certificates.X509Certificate x509Certificate = enumerator.Current;
										num = (short)668991495;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 4:
										goto IL_29E;
									case 5:
									{
										global::System.Security.Cryptography.X509Certificates.X509Certificate x509Certificate;
										result = x509Certificate;
										num = (short)1431633926;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									case 6:
										goto IL_232;
									case 7:
									{
										global::System.Security.Cryptography.X509Certificates.X509Certificate x509Certificate;
										if (string.Compare(x509Certificate.Issuer, A_4[num4], global::System.StringComparison.Ordinal) == 0)
										{
											num = (short)1507983365;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										x509Certificate.Dispose();
										num = (short)2036858883;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									}
									IL_1E3:
									num = (short)447217666;
									num3 = (int)((global::System.IntPtr)num);
									continue;
									IL_1C4:
									goto IL_1E3;
								}
								IL_232:
								IL_29E:
								goto IL_8B;
							}
							finally
							{
								switch (0)
								{
								case 0:
									goto IL_2C0;
								}
								global::System.IDisposable disposable;
								for (;;)
								{
									IL_2AD:
									switch (num3)
									{
									case 0:
										if (disposable != null)
										{
											num = (short)1530593282;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_317;
									case 1:
										goto IL_315;
									case 2:
										disposable.Dispose();
										num = (short)266534913;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									}
									goto IL_2C0;
								}
								IL_315:
								IL_317:
								goto EndFinally_6;
								IL_2C0:
								global::System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator enumerator;
								disposable = (enumerator as global::System.IDisposable);
								num = (short)1704591360;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_2AD;
								EndFinally_6:;
							}
							return result;
							IL_8B:
							num4++;
							num = (short)623196784;
							short num5 = num;
							num = (short)665336432;
							switch ((num5 == num) ? 1 : 0)
							{
							case 0:
							case 2:
								goto IL_00;
							default:
								num = (short)225050624;
								if (num != 0)
								{
								}
								num = (short)1794768897;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							break;
						}
						case 4:
						{
							if (num4 >= A_4.GetLength(0))
							{
								num = (short)970260482;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::System.Security.Cryptography.X509Certificates.X509CertificateCollection.X509CertificateEnumerator enumerator = A_2.GetEnumerator();
							num = (short)230424577;
							if (num != 0)
							{
							}
							num = (short)236847107;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						break;
						IL_13E:
						num = (short)1231683588;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_6C:
					result = null;
					num4 = 0;
					num = (short)1064435712;
					num3 = (int)((global::System.IntPtr)num);
					goto IL_51;
				}
				}
			}
			return result;
		}

		// Token: 0x040000E9 RID: 233
		private static global::System.Net.Sockets.TcpClient a;

		// Token: 0x040000EA RID: 234
		private global::System.Net.Security.SslStream b;

		// Token: 0x040000EB RID: 235
		private global::SSLMangrComp.SecureClientConfiguration c;
	}
}
