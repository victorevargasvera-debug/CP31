using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003FC RID: 1020
	public class NaccacheSternKeyParameters : global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter
	{
		// Token: 0x06002849 RID: 10313 RVA: 0x000AC84B File Offset: 0x000AAA4B
		public NaccacheSternKeyParameters(bool privateKey, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Math.BigInteger n, int lowerSigmaBound) : base(privateKey)
		{
			this.g = g;
			this.n = n;
			this.lowerSigmaBound = lowerSigmaBound;
		}

		// Token: 0x1700058B RID: 1419
		// (get) Token: 0x0600284A RID: 10314 RVA: 0x000AC86A File Offset: 0x000AAA6A
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x1700058C RID: 1420
		// (get) Token: 0x0600284B RID: 10315 RVA: 0x000AC872 File Offset: 0x000AAA72
		public int LowerSigmaBound
		{
			get
			{
				return this.lowerSigmaBound;
			}
		}

		// Token: 0x1700058D RID: 1421
		// (get) Token: 0x0600284C RID: 10316 RVA: 0x000AC87A File Offset: 0x000AAA7A
		public global::Org.BouncyCastle.Math.BigInteger Modulus
		{
			get
			{
				return this.n;
			}
		}

		// Token: 0x04001057 RID: 4183
		private readonly global::Org.BouncyCastle.Math.BigInteger g;

		// Token: 0x04001058 RID: 4184
		private readonly global::Org.BouncyCastle.Math.BigInteger n;

		// Token: 0x04001059 RID: 4185
		private readonly int lowerSigmaBound;
	}
}
