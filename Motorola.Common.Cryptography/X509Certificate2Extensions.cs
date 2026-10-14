using System;
using System.Security.Cryptography.X509Certificates;

namespace Motorola.Common.Cryptography
{
	// Token: 0x02000007 RID: 7
	public static class X509Certificate2Extensions
	{
		// Token: 0x06000015 RID: 21 RVA: 0x000030EC File Offset: 0x000012EC
		public static global::Motorola.Common.Cryptography.CertificateType GetCertificateType(this global::System.Security.Cryptography.X509Certificates.X509Certificate2 cert)
		{
			short num = (short)1094428656;
			short num2 = num;
			num = (short)1479387120;
			switch (num2 == num)
			{
			}
			num = (short)1947729921;
			if (num != 0)
			{
			}
			num = (short)1435435008;
			short num3 = num;
			num = (short)641859584;
			if (num != 0)
			{
			}
			return (global::Motorola.Common.Cryptography.CertificateType)global::System.Enum.Parse(typeof(global::Motorola.Common.Cryptography.CertificateType), cert.SignatureAlgorithm.FriendlyName, true);
		}
	}
}
