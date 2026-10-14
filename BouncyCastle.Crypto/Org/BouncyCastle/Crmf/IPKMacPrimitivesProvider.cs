using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x0200050F RID: 1295
	public interface IPKMacPrimitivesProvider
	{
		// Token: 0x06003297 RID: 12951
		global::Org.BouncyCastle.Crypto.IDigest CreateDigest(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlg);

		// Token: 0x06003298 RID: 12952
		global::Org.BouncyCastle.Crypto.IMac CreateMac(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlg);
	}
}
