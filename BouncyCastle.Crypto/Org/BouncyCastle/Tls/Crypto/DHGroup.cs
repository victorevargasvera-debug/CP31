using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000136 RID: 310
	public class DHGroup
	{
		// Token: 0x06000CCF RID: 3279 RVA: 0x00031C65 File Offset: 0x0002FE65
		public DHGroup(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger g, int l)
		{
			this.p = p;
			this.g = g;
			this.q = q;
			this.l = l;
		}

		// Token: 0x170001E0 RID: 480
		// (get) Token: 0x06000CD0 RID: 3280 RVA: 0x00031C8A File Offset: 0x0002FE8A
		public virtual global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x170001E1 RID: 481
		// (get) Token: 0x06000CD1 RID: 3281 RVA: 0x00031C92 File Offset: 0x0002FE92
		public virtual int L
		{
			get
			{
				return this.l;
			}
		}

		// Token: 0x170001E2 RID: 482
		// (get) Token: 0x06000CD2 RID: 3282 RVA: 0x00031C9A File Offset: 0x0002FE9A
		public virtual global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p;
			}
		}

		// Token: 0x170001E3 RID: 483
		// (get) Token: 0x06000CD3 RID: 3283 RVA: 0x00031CA2 File Offset: 0x0002FEA2
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q;
			}
		}

		// Token: 0x0400077B RID: 1915
		private readonly global::Org.BouncyCastle.Math.BigInteger g;

		// Token: 0x0400077C RID: 1916
		private readonly global::Org.BouncyCastle.Math.BigInteger p;

		// Token: 0x0400077D RID: 1917
		private readonly global::Org.BouncyCastle.Math.BigInteger q;

		// Token: 0x0400077E RID: 1918
		private readonly int l;
	}
}
