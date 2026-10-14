using System;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B3 RID: 1715
	public class KeyDerivationFunc : global::Org.BouncyCastle.Asn1.X509.AlgorithmIdentifier
	{
		// Token: 0x06003ECB RID: 16075 RVA: 0x0011E054 File Offset: 0x0011C254
		internal KeyDerivationFunc(global::Org.BouncyCastle.Asn1.Asn1Sequence seq) : base(seq)
		{
		}

		// Token: 0x06003ECC RID: 16076 RVA: 0x0011E05D File Offset: 0x0011C25D
		public KeyDerivationFunc(global::Org.BouncyCastle.Asn1.DerObjectIdentifier id, global::Org.BouncyCastle.Asn1.Asn1Encodable parameters) : base(id, parameters)
		{
		}
	}
}
