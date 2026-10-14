using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Cms;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Cms
{
	// Token: 0x02000558 RID: 1368
	internal interface ISignerInfoGenerator
	{
		// Token: 0x0600346B RID: 13419
		global::Org.BouncyCastle.Asn1.Cms.SignerInfo Generate(global::Org.BouncyCastle.Asn1.DerObjectIdentifier contentType, global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier digestAlgorithm, byte[] calculatedDigest);
	}
}
