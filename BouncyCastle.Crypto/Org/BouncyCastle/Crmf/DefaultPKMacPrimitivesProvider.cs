using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crmf
{
	// Token: 0x0200050B RID: 1291
	public class DefaultPKMacPrimitivesProvider : global::Org.BouncyCastle.Crmf.IPKMacPrimitivesProvider
	{
		// Token: 0x06003289 RID: 12937 RVA: 0x000F226B File Offset: 0x000F046B
		public global::Org.BouncyCastle.Crypto.IDigest CreateDigest(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlg)
		{
			return global::Org.BouncyCastle.Security.DigestUtilities.GetDigest(digestAlg.Algorithm);
		}

		// Token: 0x0600328A RID: 12938 RVA: 0x000F2278 File Offset: 0x000F0478
		public global::Org.BouncyCastle.Crypto.IMac CreateMac(global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier macAlg)
		{
			return global::Org.BouncyCastle.Security.MacUtilities.GetMac(macAlg.Algorithm);
		}
	}
}
