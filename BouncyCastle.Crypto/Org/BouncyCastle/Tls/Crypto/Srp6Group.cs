using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000138 RID: 312
	public class Srp6Group
	{
		// Token: 0x06000CD9 RID: 3289 RVA: 0x00031F71 File Offset: 0x00030171
		public Srp6Group(global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger g)
		{
			this.n = n;
			this.g = g;
		}

		// Token: 0x170001E4 RID: 484
		// (get) Token: 0x06000CDA RID: 3290 RVA: 0x00031F87 File Offset: 0x00030187
		public virtual global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x170001E5 RID: 485
		// (get) Token: 0x06000CDB RID: 3291 RVA: 0x00031F8F File Offset: 0x0003018F
		public virtual global::Org.BouncyCastle.Math.BigInteger N
		{
			get
			{
				return this.n;
			}
		}

		// Token: 0x040007A9 RID: 1961
		private readonly global::Org.BouncyCastle.Math.BigInteger n;

		// Token: 0x040007AA RID: 1962
		private readonly global::Org.BouncyCastle.Math.BigInteger g;
	}
}
