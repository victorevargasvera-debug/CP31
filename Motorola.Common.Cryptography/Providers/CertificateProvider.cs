using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using Motorola.Common.Cryptography.Autofac;
using Motorola.Common.Cryptography.Configuration.Registry;
using Motorola.Common.Cryptography.Exceptions;

namespace Motorola.Common.Cryptography.Providers
{
	// Token: 0x0200000D RID: 13
	public class CertificateProvider : global::Motorola.Common.Cryptography.Providers.ICertificateProvider
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00003978 File Offset: 0x00001B78
		public CertificateProvider(global::Motorola.Common.Cryptography.Configuration.Registry.IRegistryConfig registry, global::Motorola.Common.Cryptography.Providers.ICertificateStore certificateStore)
		{
			int a_ = 0;
			base..ctor();
			this.a = registry;
			if (registry == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("⑕㵗㵙㕛ⵝᑟၡᵣ", a_));
			}
			this.b = certificateStore;
			if (certificateStore == null)
			{
				throw new global::System.ArgumentNullException(global::Motorola.Common.Cryptography.Autofac.CryptographyModule.b("㕕㵗⡙⡛㝝ٟୡݣݥᱧཀྵ㽫ᩭὯqᅳ", a_));
			}
		}

		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000022 RID: 34 RVA: 0x000039D8 File Offset: 0x00001BD8
		public global::System.Security.Cryptography.X509Certificates.X509Certificate2 SelectedCertificate
		{
			get
			{
				switch (0)
				{
				case 0:
					goto IL_A1;
				}
				short num;
				int num3;
				global::System.Security.Cryptography.X509Certificates.X509Certificate2[] array2;
				global::Motorola.Common.Cryptography.Providers.CertificateProvider.a a;
				for (;;)
				{
					IL_0A:
					num = (short)162782714;
					short num2 = num;
					num = (short)819518970;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)238747648;
						if (num != 0)
						{
						}
						num = (short)1094909953;
						if (num != 0)
						{
						}
						global::System.Security.Cryptography.X509Certificates.X509Certificate2[] array;
						switch (num3)
						{
						case 0:
							array = null;
							goto IL_1CE;
						case 1:
							if (array2.Length > 1)
							{
								num = (short)1392443394;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							goto IL_209;
						case 2:
							goto IL_1CC;
						case 3:
						{
							global::System.Collections.Generic.IEnumerable<global::System.Security.Cryptography.X509Certificates.X509Certificate2> availableCertificates = this.b.AvailableCertificates;
							if (availableCertificates == null)
							{
								num = (short)1463287808;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							array = availableCertificates.Where(new global::System.Func<global::System.Security.Cryptography.X509Certificates.X509Certificate2, bool>(a.b)).ToArray<global::System.Security.Cryptography.X509Certificates.X509Certificate2>();
							goto IL_1CE;
						}
						case 4:
							goto IL_14F;
						case 5:
							if (!array2.Any<global::System.Security.Cryptography.X509Certificates.X509Certificate2>())
							{
								num = (short)982843396;
								num3 = (int)((global::System.IntPtr)num);
								continue;
							}
							num = (short)759169025;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 6:
							num = (short)736296965;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						case 7:
							if (array2 != null)
							{
								goto IL_1ED;
							}
							goto IL_107;
						}
						goto IL_A1;
						IL_1CE:
						array2 = array;
						num = (short)1905590279;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					}
					}
					IL_1ED:
					num = (short)1879375878;
					num3 = (int)((global::System.IntPtr)num);
				}
				IL_107:
				throw new global::Motorola.Common.Cryptography.Exceptions.NoCertificatesFoundException(new global::Motorola.Common.Cryptography.CertificateType?(a.a));
				IL_14F:
				goto IL_107;
				IL_1CC:
				throw new global::Motorola.Common.Cryptography.Exceptions.ToManyCertificatesException(new global::Motorola.Common.Cryptography.CertificateType?(a.a));
				IL_209:
				return array2.SingleOrDefault<global::System.Security.Cryptography.X509Certificates.X509Certificate2>();
				IL_A1:
				num = (short)24772608;
				short num4 = num;
				a = new global::Motorola.Common.Cryptography.Providers.CertificateProvider.a();
				a.a = this.a.SelectedCertificateTypeOrDefault();
				num = (short)1761083395;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_0A;
			}
		}

		// Token: 0x0400000D RID: 13
		private readonly global::Motorola.Common.Cryptography.Configuration.Registry.IRegistryConfig a;

		// Token: 0x0400000E RID: 14
		private readonly global::Motorola.Common.Cryptography.Providers.ICertificateStore b;

		// Token: 0x0200000E RID: 14
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private sealed class a
		{
			// Token: 0x06000024 RID: 36 RVA: 0x00003C08 File Offset: 0x00001E08
			internal bool b(global::System.Security.Cryptography.X509Certificates.X509Certificate2 A_0)
			{
				while (A_0 == null)
				{
					short num = (short)1890036372;
					short num2 = num;
					num = (short)2059709076;
					switch ((num2 == num) ? 1 : 0)
					{
					case 0:
					case 2:
						break;
					default:
					{
						num = (short)2057306112;
						short num3 = num;
						num = (short)1960968192;
						if (num != 0)
						{
						}
						num = (short)1536294913;
						if (num != 0)
						{
						}
						return false;
					}
					}
				}
				return A_0.GetCertificateType() == this.a;
			}

			// Token: 0x0400000F RID: 15
			public global::Motorola.Common.Cryptography.CertificateType a;
		}
	}
}
