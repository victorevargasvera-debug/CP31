using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x0200040C RID: 1036
	public sealed class Srp6GroupParameters
	{
		// Token: 0x06002898 RID: 10392 RVA: 0x000AD153 File Offset: 0x000AB353
		public Srp6GroupParameters(global::Org.BouncyCastle.Math.BigInteger N, global::Org.BouncyCastle.Math.BigInteger g)
		{
			this.n = N;
			this.g = g;
		}

		// Token: 0x170005AC RID: 1452
		// (get) Token: 0x06002899 RID: 10393 RVA: 0x000AD169 File Offset: 0x000AB369
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x170005AD RID: 1453
		// (get) Token: 0x0600289A RID: 10394 RVA: 0x000AD171 File Offset: 0x000AB371
		public global::Org.BouncyCastle.Math.BigInteger N
		{
			get
			{
				return this.n;
			}
		}

		// Token: 0x04001085 RID: 4229
		private readonly global::Org.BouncyCastle.Math.BigInteger n;

		// Token: 0x04001086 RID: 4230
		private readonly global::Org.BouncyCastle.Math.BigInteger g;
	}
}
