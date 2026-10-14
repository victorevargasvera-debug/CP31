using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003DA RID: 986
	public class ECNamedDomainParameters : global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters
	{
		// Token: 0x17000557 RID: 1367
		// (get) Token: 0x0600278E RID: 10126 RVA: 0x000AB296 File Offset: 0x000A9496
		public global::Org.BouncyCastle.Asn1.DerObjectIdentifier Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x0600278F RID: 10127 RVA: 0x000AB29E File Offset: 0x000A949E
		public ECNamedDomainParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier name, global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters dp) : this(name, dp.Curve, dp.G, dp.N, dp.H, dp.GetSeed())
		{
		}

		// Token: 0x06002790 RID: 10128 RVA: 0x000AB2C5 File Offset: 0x000A94C5
		public ECNamedDomainParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier name, global::Org.BouncyCastle.Asn1.X9.X9ECParameters x9) : base(x9)
		{
			this.name = name;
		}

		// Token: 0x06002791 RID: 10129 RVA: 0x000AB2D5 File Offset: 0x000A94D5
		public ECNamedDomainParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier name, global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECPoint g, global::Org.BouncyCastle.Math.BigInteger n) : base(curve, g, n)
		{
			this.name = name;
		}

		// Token: 0x06002792 RID: 10130 RVA: 0x000AB2E8 File Offset: 0x000A94E8
		public ECNamedDomainParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier name, global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECPoint g, global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger h) : base(curve, g, n, h)
		{
			this.name = name;
		}

		// Token: 0x06002793 RID: 10131 RVA: 0x000AB2FD File Offset: 0x000A94FD
		public ECNamedDomainParameters(global::Org.BouncyCastle.Asn1.DerObjectIdentifier name, global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECPoint g, global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger h, byte[] seed) : base(curve, g, n, h, seed)
		{
			this.name = name;
		}

		// Token: 0x0400100C RID: 4108
		private readonly global::Org.BouncyCastle.Asn1.DerObjectIdentifier name;
	}
}
