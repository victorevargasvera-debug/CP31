using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Bcpg
{
	// Token: 0x02000573 RID: 1395
	public class ECDsaPublicBcpgKey : global::Org.BouncyCastle.Bcpg.ECPublicBcpgKey
	{
		// Token: 0x0600353F RID: 13631 RVA: 0x000FDD69 File Offset: 0x000FBF69
		protected internal ECDsaPublicBcpgKey(global::Org.BouncyCastle.Bcpg.BcpgInputStream bcpgIn) : base(bcpgIn)
		{
		}

		// Token: 0x06003540 RID: 13632 RVA: 0x000FDD72 File Offset: 0x000FBF72
		public ECDsaPublicBcpgKey(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Math.EC.ECPoint point) : base(oid, point)
		{
		}

		// Token: 0x06003541 RID: 13633 RVA: 0x000FDD7C File Offset: 0x000FBF7C
		public ECDsaPublicBcpgKey(global::Org.BouncyCastle.Asn1.DerObjectIdentifier oid, global::Org.BouncyCastle.Math.BigInteger encodedPoint) : base(oid, encodedPoint)
		{
		}
	}
}
