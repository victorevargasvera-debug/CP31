using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Security.Certificates;

namespace Org.BouncyCastle.X509
{
	// Token: 0x0200000F RID: 15
	public class PrincipalUtilities
	{
		// Token: 0x060000A4 RID: 164 RVA: 0x00005D54 File Offset: 0x00003F54
		public static global::Org.BouncyCastle.Asn1.X509.X509Name GetIssuerX509Principal(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Name issuer;
			try
			{
				issuer = global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(cert.GetTbsCertificate())).Issuer;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("Could not extract issuer", e);
			}
			return issuer;
		}

		// Token: 0x060000A5 RID: 165 RVA: 0x00005D98 File Offset: 0x00003F98
		public static global::Org.BouncyCastle.Asn1.X509.X509Name GetSubjectX509Principal(global::Org.BouncyCastle.X509.X509Certificate cert)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Name subject;
			try
			{
				subject = global::Org.BouncyCastle.Asn1.X509.TbsCertificateStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(cert.GetTbsCertificate())).Subject;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateEncodingException("Could not extract subject", e);
			}
			return subject;
		}

		// Token: 0x060000A6 RID: 166 RVA: 0x00005DDC File Offset: 0x00003FDC
		public static global::Org.BouncyCastle.Asn1.X509.X509Name GetIssuerX509Principal(global::Org.BouncyCastle.X509.X509Crl crl)
		{
			global::Org.BouncyCastle.Asn1.X509.X509Name issuer;
			try
			{
				issuer = global::Org.BouncyCastle.Asn1.X509.TbsCertificateList.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Object.FromByteArray(crl.GetTbsCertList())).Issuer;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CrlException("Could not extract issuer", e);
			}
			return issuer;
		}
	}
}
