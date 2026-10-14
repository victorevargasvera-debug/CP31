using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Security.Certificates;

namespace Org.BouncyCastle.X509.Extension
{
	// Token: 0x0200002F RID: 47
	public class AuthorityKeyIdentifierStructure : global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier
	{
		// Token: 0x06000218 RID: 536 RVA: 0x0000B160 File Offset: 0x00009360
		public AuthorityKeyIdentifierStructure(global::Org.BouncyCastle.Asn1.Asn1OctetString encodedValue) : base((global::Org.BouncyCastle.Asn1.Asn1Sequence)global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(encodedValue))
		{
		}

		// Token: 0x06000219 RID: 537 RVA: 0x0000B174 File Offset: 0x00009374
		private static global::Org.BouncyCastle.Asn1.Asn1Sequence FromCertificate(global::Org.BouncyCastle.X509.X509Certificate certificate)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence result;
			try
			{
				global::Org.BouncyCastle.Asn1.X509.GeneralName genName = new global::Org.BouncyCastle.Asn1.X509.GeneralName(global::Org.BouncyCastle.X509.PrincipalUtilities.GetIssuerX509Principal(certificate));
				if (certificate.Version == 3)
				{
					global::Org.BouncyCastle.Asn1.Asn1OctetString ext = certificate.GetExtensionValue(global::Org.BouncyCastle.Asn1.X509.X509Extensions.SubjectKeyIdentifier);
					if (ext != null)
					{
						return (global::Org.BouncyCastle.Asn1.Asn1Sequence)new global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier(((global::Org.BouncyCastle.Asn1.Asn1OctetString)global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(ext)).GetOctets(), new global::Org.BouncyCastle.Asn1.X509.GeneralNames(genName), certificate.SerialNumber).ToAsn1Object();
					}
				}
				result = (global::Org.BouncyCastle.Asn1.Asn1Sequence)new global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier(global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(certificate.GetPublicKey()), new global::Org.BouncyCastle.Asn1.X509.GeneralNames(genName), certificate.SerialNumber).ToAsn1Object();
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException("Exception extracting certificate details", e);
			}
			return result;
		}

		// Token: 0x0600021A RID: 538 RVA: 0x0000B21C File Offset: 0x0000941C
		private static global::Org.BouncyCastle.Asn1.Asn1Sequence FromKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey)
		{
			global::Org.BouncyCastle.Asn1.Asn1Sequence result;
			try
			{
				result = (global::Org.BouncyCastle.Asn1.Asn1Sequence)new global::Org.BouncyCastle.Asn1.X509.AuthorityKeyIdentifier(global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(pubKey)).ToAsn1Object();
			}
			catch (global::System.Exception e)
			{
				string str = "can't process key: ";
				global::System.Exception ex = e;
				throw new global::Org.BouncyCastle.Security.InvalidKeyException(str + ((ex != null) ? ex.ToString() : null));
			}
			return result;
		}

		// Token: 0x0600021B RID: 539 RVA: 0x0000B270 File Offset: 0x00009470
		public AuthorityKeyIdentifierStructure(global::Org.BouncyCastle.X509.X509Certificate certificate) : base(global::Org.BouncyCastle.X509.Extension.AuthorityKeyIdentifierStructure.FromCertificate(certificate))
		{
		}

		// Token: 0x0600021C RID: 540 RVA: 0x0000B27E File Offset: 0x0000947E
		public AuthorityKeyIdentifierStructure(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey) : base(global::Org.BouncyCastle.X509.Extension.AuthorityKeyIdentifierStructure.FromKey(pubKey))
		{
		}
	}
}
