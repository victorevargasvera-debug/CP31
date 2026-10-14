using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using Motorola.Common.Cryptography.Autofac;
using Motorola.Common.Cryptography.Configuration.AppConfig;

namespace Motorola.Common.Cryptography.Providers
{
	// Token: 0x02000008 RID: 8
	public class CertificateRemover : global::Motorola.Common.Cryptography.Providers.CertificateStore, global::Motorola.Common.Cryptography.Providers.ICertificateRemover, global::Motorola.Common.Cryptography.Providers.ICertificateStore
	{
		// Token: 0x06000016 RID: 22 RVA: 0x000031B8 File Offset: 0x000013B8
		public CertificateRemover(global::Motorola.Common.Cryptography.Configuration.AppConfig.ICertificateSection appConfig)
		{
			int a_ = 5;
			base..ctor(appConfig, global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("⽚㉜൞Ѡ๢੤ᅦ౨", a_));
		}

		// Token: 0x06000017 RID: 23 RVA: 0x000031E4 File Offset: 0x000013E4
		public void RemoveAll()
		{
			short num = (short)1229586432;
			switch (num)
			{
			default:
			{
				num = (short)1166606336;
				short num2 = num;
				num = (short)1491664897;
				if (num != 0)
				{
				}
				global::System.Collections.Generic.IEnumerator<global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement> enumerator = base.AvailableCertificateElements.GetEnumerator();
				try
				{
					num = (short)85917698;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_26C;
						case 1:
							goto IL_284;
						case 2:
							switch (0)
							{
							case 0:
								goto IL_B8;
							}
							continue;
						case 3:
							try
							{
								switch (0)
								{
								case 0:
									goto IL_13B;
								}
								global::System.Security.Cryptography.X509Certificates.X509Store x509Store;
								global::System.Security.Cryptography.X509Certificates.X509Certificate2 x509Certificate;
								for (;;)
								{
									IL_124:
									switch (num3)
									{
									case 0:
										x509Store.Remove(x509Certificate);
										num = (short)85655555;
										num3 = (int)((global::System.IntPtr)num);
										continue;
									case 1:
										goto IL_1AB;
									case 2:
										if (x509Certificate != null)
										{
											num = (short)194248704;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										goto IL_191;
									case 3:
										goto IL_191;
									}
									goto IL_13B;
									IL_191:
									num = (short)1654849537;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_1AB:
								break;
								IL_13B:
								global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement certificateElement;
								x509Certificate = global::Motorola.Common.Cryptography.Providers.CertificateStore.Find(x509Store, certificateElement);
								num = (short)70516738;
								num3 = (int)((global::System.IntPtr)num);
								goto IL_124;
							}
							finally
							{
								num = (short)1521156097;
								num3 = (int)((global::System.IntPtr)num);
								for (;;)
								{
									global::System.Security.Cryptography.X509Certificates.X509Store x509Store;
									switch (num3)
									{
									case 0:
										goto IL_269;
									case 1:
										switch (0)
										{
										case 0:
											goto IL_1E3;
										}
										continue;
									case 2:
									{
										num = (short)387392569;
										short num4 = num;
										num = (short)1931617337;
										switch ((num4 == num) ? 1 : 0)
										{
										case 0:
										case 2:
											goto IL_269;
										default:
											num = (short)391053312;
											if (num != 0)
											{
											}
											((global::System.IDisposable)x509Store).Dispose();
											num = (short)1504903168;
											num3 = (int)((global::System.IntPtr)num);
											continue;
										}
										break;
									}
									}
									IL_1E3:
									if (x509Store == null)
									{
										break;
									}
									num = (short)789381122;
									num3 = (int)((global::System.IntPtr)num);
								}
								IL_269:;
							}
							goto IL_26C;
						case 4:
						{
							if (!enumerator.MoveNext())
							{
								num = (short)638713856;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement certificateElement = enumerator.Current;
							global::System.Security.Cryptography.X509Certificates.X509Store x509Store = global::Motorola.Common.Cryptography.Providers.CertificateStore.OpenStore(certificateElement, global::System.Security.Cryptography.X509Certificates.OpenFlags.ReadWrite);
							num = (short)1901920259;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						}
						IL_E2:
						num = (short)1895956484;
						num3 = (int)((global::System.IntPtr)num);
						continue;
						IL_B8:
						goto IL_E2;
						IL_26C:
						num = (short)866058241;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_284:;
				}
				finally
				{
					num = (short)1087045633;
					int num3 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num3)
						{
						case 0:
							goto IL_2ED;
						case 1:
							switch (0)
							{
							case 0:
								goto IL_2B8;
							}
							continue;
						case 2:
							enumerator.Dispose();
							num = (short)2145124352;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						IL_2B8:
						if (enumerator == null)
						{
							break;
						}
						num = (short)76611586;
						num3 = (int)((global::System.IntPtr)num);
					}
					IL_2ED:;
				}
				return;
			}
			}
		}
	}
}
