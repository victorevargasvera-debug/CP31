using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003EC RID: 1004
	public class Gost3410PrivateKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters
	{
		// Token: 0x060027FD RID: 10237 RVA: 0x000ABFF8 File Offset: 0x000AA1F8
		public Gost3410PrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters) : base(true, parameters)
		{
			if (x.SignValue < 1 || x.BitLength > 256 || x.CompareTo(base.Parameters.Q) >= 0)
			{
				throw new global::System.ArgumentException("Invalid x for GOST3410 private key", "x");
			}
			this.x = x;
		}

		// Token: 0x060027FE RID: 10238 RVA: 0x000AC050 File Offset: 0x000AA250
		public Gost3410PrivateKeyParameters(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet) : base(true, publicKeyParamSet)
		{
			if (x.SignValue < 1 || x.BitLength > 256 || x.CompareTo(base.Parameters.Q) >= 0)
			{
				throw new global::System.ArgumentException("Invalid x for GOST3410 private key", "x");
			}
			this.x = x;
		}

		// Token: 0x1700056C RID: 1388
		// (get) Token: 0x060027FF RID: 10239 RVA: 0x000AC0A6 File Offset: 0x000AA2A6
		public global::Org.BouncyCastle.Math.BigInteger X
		{
			get
			{
				return this.x;
			}
		}

		// Token: 0x0400102E RID: 4142
		private readonly global::Org.BouncyCastle.Math.BigInteger x;
	}
}
