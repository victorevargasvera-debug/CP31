using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security.Certificates;

namespace Org.BouncyCastle.X509.Extension
{
	// Token: 0x02000030 RID: 48
	public class SubjectKeyIdentifierStructure : global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier
	{
		// Token: 0x0600021D RID: 541 RVA: 0x0000B28C File Offset: 0x0000948C
		public SubjectKeyIdentifierStructure(global::Org.BouncyCastle.Asn1.Asn1OctetString encodedValue) : base((global::Org.BouncyCastle.Asn1.Asn1OctetString)global::Org.BouncyCastle.X509.Extension.X509ExtensionUtilities.FromExtensionValue(encodedValue))
		{
		}

		// Token: 0x0600021E RID: 542 RVA: 0x0000B2A0 File Offset: 0x000094A0
		private static global::Org.BouncyCastle.Asn1.Asn1OctetString FromPublicKey(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey)
		{
			global::Org.BouncyCastle.Asn1.Asn1OctetString result;
			try
			{
				result = (global::Org.BouncyCastle.Asn1.Asn1OctetString)new global::Org.BouncyCastle.Asn1.X509.SubjectKeyIdentifier(global::Org.BouncyCastle.X509.SubjectPublicKeyInfoFactory.CreateSubjectPublicKeyInfo(pubKey)).ToAsn1Object();
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Security.Certificates.CertificateParsingException("Exception extracting certificate details: " + e.ToString());
			}
			return result;
		}

		// Token: 0x0600021F RID: 543 RVA: 0x0000B2F0 File Offset: 0x000094F0
		public SubjectKeyIdentifierStructure(global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter pubKey) : base(global::Org.BouncyCastle.X509.Extension.SubjectKeyIdentifierStructure.FromPublicKey(pubKey))
		{
		}
	}
}
