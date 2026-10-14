using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x0200013B RID: 315
	public interface TlsCertificate
	{
		// Token: 0x06000CE3 RID: 3299
		global::Org.BouncyCastle.Tls.Crypto.TlsEncryptor CreateEncryptor(int tlsCertificateRole);

		// Token: 0x06000CE4 RID: 3300
		global::Org.BouncyCastle.Tls.Crypto.TlsVerifier CreateVerifier(short signatureAlgorithm);

		// Token: 0x06000CE5 RID: 3301
		global::Org.BouncyCastle.Tls.Crypto.TlsVerifier CreateVerifier(int signatureScheme);

		// Token: 0x06000CE6 RID: 3302
		byte[] GetEncoded();

		// Token: 0x06000CE7 RID: 3303
		byte[] GetExtension(global::Org.BouncyCastle.Asn1.DerObjectIdentifier extensionOid);

		// Token: 0x170001E6 RID: 486
		// (get) Token: 0x06000CE8 RID: 3304
		global::Org.BouncyCastle.Math.BigInteger SerialNumber { get; }

		// Token: 0x170001E7 RID: 487
		// (get) Token: 0x06000CE9 RID: 3305
		string SigAlgOid { get; }

		// Token: 0x06000CEA RID: 3306
		global::Org.BouncyCastle.Asn1.Asn1Encodable GetSigAlgParams();

		// Token: 0x06000CEB RID: 3307
		short GetLegacySignatureAlgorithm();

		// Token: 0x06000CEC RID: 3308
		bool SupportsSignatureAlgorithm(short signatureAlgorithm);

		// Token: 0x06000CED RID: 3309
		bool SupportsSignatureAlgorithmCA(short signatureAlgorithm);

		// Token: 0x06000CEE RID: 3310
		global::Org.BouncyCastle.Tls.Crypto.TlsCertificate CheckUsageInRole(int tlsCertificateRole);
	}
}
