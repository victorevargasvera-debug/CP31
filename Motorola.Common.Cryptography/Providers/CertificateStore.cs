using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Motorola.Common.Cryptography.Configuration.AppConfig;

namespace Motorola.Common.Cryptography.Providers
{
	// Token: 0x02000009 RID: 9
	public class CertificateStore : global::Motorola.Common.Cryptography.Providers.ICertificateStore
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00003518 File Offset: 0x00001718
		public CertificateStore(global::Motorola.Common.Cryptography.Configuration.AppConfig.ICertificateSection appConfig, string group)
		{
			this.b = appConfig;
			this.a = group;
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000019 RID: 25 RVA: 0x0000353C File Offset: 0x0000173C
		public global::System.Collections.Generic.IEnumerable<global::System.Security.Cryptography.X509Certificates.X509Certificate2> AvailableCertificates
		{
			get
			{
				short num = (short)610716012;
				short num2 = num;
				num = (short)1986251116;
				switch (num2 == num)
				{
				}
				num = (short)1815412737;
				if (num != 0)
				{
				}
				num = (short)1431502848;
				short num3 = num;
				num = (short)1689583616;
				if (num != 0)
				{
				}
				return this.AvailableCertificateElements.Select(new global::System.Func<global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement, global::System.Security.Cryptography.X509Certificates.X509Certificate2>(global::Motorola.Common.Cryptography.Providers.CertificateStore.GetX509Certificate2));
			}
		}

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x0600001A RID: 26 RVA: 0x000035FC File Offset: 0x000017FC
		protected global::System.Collections.Generic.IEnumerable<global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement> AvailableCertificateElements
		{
			get
			{
				short num = (short)349052158;
				short num2 = num;
				num = (short)1760435454;
				switch (num2 == num)
				{
				}
				num = (short)1380515840;
				short num3 = num;
				num = (short)1748369408;
				if (num != 0)
				{
				}
				num = (short)861929473;
				if (num != 0)
				{
				}
				return this.b.GetCertificates(this.a);
			}
		}

		// Token: 0x0600001B RID: 27 RVA: 0x000036B8 File Offset: 0x000018B8
		public static global::System.Security.Cryptography.X509Certificates.X509Certificate2 GetX509Certificate2(global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement certificateElement)
		{
			short num = (short)1186366605;
			short num2 = num;
			num = (short)1592165517;
			global::System.Security.Cryptography.X509Certificates.X509Certificate2 result;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
			{
				num = (short)1086390272;
				short num3 = num;
				num = (short)208601089;
				if (num != 0)
				{
				}
				num = (short)1939603456;
				if (num != 0)
				{
				}
				global::System.Security.Cryptography.X509Certificates.X509Store x509Store = global::Motorola.Common.Cryptography.Providers.CertificateStore.OpenStore(certificateElement, global::System.Security.Cryptography.X509Certificates.OpenFlags.ReadOnly);
				try
				{
					result = global::Motorola.Common.Cryptography.Providers.CertificateStore.Find(x509Store, certificateElement);
				}
				finally
				{
					num = (short)734330880;
					int num4 = (int)((global::System.IntPtr)num);
					for (;;)
					{
						switch (num4)
						{
						case 0:
							switch (0)
							{
							case 0:
								goto IL_E0;
							}
							continue;
						case 1:
							((global::System.IDisposable)x509Store).Dispose();
							num = (short)637272066;
							num4 = (int)((global::System.IntPtr)num);
							continue;
						case 2:
							goto IL_113;
						}
						IL_E0:
						if (x509Store == null)
						{
							break;
						}
						num = (short)50987009;
						num4 = (int)((global::System.IntPtr)num);
					}
					IL_113:;
				}
				break;
			}
			}
			return result;
		}

		// Token: 0x0600001C RID: 28 RVA: 0x000037EC File Offset: 0x000019EC
		protected static global::System.Security.Cryptography.X509Certificates.X509Certificate2 Find(global::System.Security.Cryptography.X509Certificates.X509Store store, global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement certificateElement)
		{
			short num = (short)1821279899;
			short num2 = num;
			num = (short)253003419;
			switch (num2 == num)
			{
			}
			num = (short)776994816;
			short num3 = num;
			num = (short)1671626753;
			if (num != 0)
			{
			}
			num = (short)1545797632;
			if (num != 0)
			{
			}
			return store.Certificates.Find(certificateElement.X509FindType, certificateElement.Value, false).Cast<global::System.Security.Cryptography.X509Certificates.X509Certificate2>().SingleOrDefault<global::System.Security.Cryptography.X509Certificates.X509Certificate2>();
		}

		// Token: 0x0600001D RID: 29 RVA: 0x000038B4 File Offset: 0x00001AB4
		protected static global::System.Security.Cryptography.X509Certificates.X509Store OpenStore(global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement certificateElement, global::System.Security.Cryptography.X509Certificates.OpenFlags openFlags)
		{
			short num = (short)483176488;
			short num2 = num;
			num = (short)220770344;
			switch (num2 == num)
			{
			}
			num = (short)1587937280;
			short num3 = num;
			num = (short)1842085888;
			if (num != 0)
			{
			}
			num = (short)13959169;
			if (num != 0)
			{
			}
			global::System.Security.Cryptography.X509Certificates.X509Store x509Store = new global::System.Security.Cryptography.X509Certificates.X509Store(certificateElement.StoreName, certificateElement.StoreLocation);
			x509Store.Open(openFlags);
			return x509Store;
		}

		// Token: 0x0400000B RID: 11
		private readonly string a;

		// Token: 0x0400000C RID: 12
		private readonly global::Motorola.Common.Cryptography.Configuration.AppConfig.ICertificateSection b;
	}
}
