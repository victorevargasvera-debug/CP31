using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003ED RID: 1005
	public class Gost3410PublicKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.Gost3410KeyParameters
	{
		// Token: 0x06002800 RID: 10240 RVA: 0x000AC0AE File Offset: 0x000AA2AE
		public Gost3410PublicKeyParameters(global::Org.BouncyCastle.Math.BigInteger y, global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters parameters) : base(false, parameters)
		{
			if (y.SignValue < 1 || y.CompareTo(base.Parameters.P) >= 0)
			{
				throw new global::System.ArgumentException("Invalid y for GOST3410 public key", "y");
			}
			this.y = y;
		}

		// Token: 0x06002801 RID: 10241 RVA: 0x000AC0EC File Offset: 0x000AA2EC
		public Gost3410PublicKeyParameters(global::Org.BouncyCastle.Math.BigInteger y, global::Org.BouncyCastle.Asn1.DerObjectIdentifier publicKeyParamSet) : base(false, publicKeyParamSet)
		{
			if (y.SignValue < 1 || y.CompareTo(base.Parameters.P) >= 0)
			{
				throw new global::System.ArgumentException("Invalid y for GOST3410 public key", "y");
			}
			this.y = y;
		}

		// Token: 0x1700056D RID: 1389
		// (get) Token: 0x06002802 RID: 10242 RVA: 0x000AC12A File Offset: 0x000AA32A
		public global::Org.BouncyCastle.Math.BigInteger Y
		{
			get
			{
				return this.y;
			}
		}

		// Token: 0x0400102F RID: 4143
		private readonly global::Org.BouncyCastle.Math.BigInteger y;
	}
}
