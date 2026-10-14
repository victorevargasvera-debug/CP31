using System;
using System.Configuration;
using System.Security.Cryptography.X509Certificates;

namespace Motorola.Common.Cryptography.Configuration.AppConfig
{
	// Token: 0x0200001F RID: 31
	public class CertificateElements : global::System.Configuration.ConfigurationElementCollection
	{
		// Token: 0x06000050 RID: 80 RVA: 0x000053C0 File Offset: 0x000035C0
		protected override global::System.Configuration.ConfigurationElement CreateNewElement()
		{
			short num = (short)1872266853;
			short num2 = num;
			num = (short)1955432037;
			switch (num2 == num)
			{
			}
			num = (short)407240704;
			short num3 = num;
			num = (short)1790509057;
			if (num != 0)
			{
			}
			num = (short)1267335168;
			if (num != 0)
			{
			}
			return new global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement();
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005470 File Offset: 0x00003670
		protected override object GetElementKey(global::System.Configuration.ConfigurationElement element)
		{
			short num = (short)1317807937;
			short num2 = num;
			num = (short)2081105729;
			switch (num2 == num)
			{
			}
			num = (short)463798272;
			short num3 = num;
			num = (short)175243265;
			if (num != 0)
			{
			}
			num = (short)1959854080;
			if (num != 0)
			{
			}
			return this.a((global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement)element);
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005528 File Offset: 0x00003728
		private object a(global::Motorola.Common.Cryptography.Configuration.AppConfig.CertificateElement A_0)
		{
			short num = (short)202030616;
			short num2 = num;
			num = (short)175357464;
			switch (num2 == num)
			{
			}
			num = (short)151126016;
			short num3 = num;
			num = (short)545521665;
			if (num != 0)
			{
			}
			num = (short)497287168;
			if (num != 0)
			{
			}
			return new global::a<string, global::System.Security.Cryptography.X509Certificates.StoreName, global::System.Security.Cryptography.X509Certificates.StoreLocation, global::System.Security.Cryptography.X509Certificates.X509FindType>(A_0.Value, A_0.StoreName, A_0.StoreLocation, A_0.X509FindType);
		}
	}
}
