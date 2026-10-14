using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003EB RID: 1003
	public class Gost3410Parameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x060027F4 RID: 10228 RVA: 0x000ABEE8 File Offset: 0x000AA0E8
		public Gost3410Parameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger a) : this(p, q, a, null)
		{
		}

		// Token: 0x060027F5 RID: 10229 RVA: 0x000ABEF4 File Offset: 0x000AA0F4
		public Gost3410Parameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters validation)
		{
			if (p == null)
			{
				throw new global::System.ArgumentNullException("p");
			}
			if (q == null)
			{
				throw new global::System.ArgumentNullException("q");
			}
			if (a == null)
			{
				throw new global::System.ArgumentNullException("a");
			}
			this.p = p;
			this.q = q;
			this.a = a;
			this.validation = validation;
		}

		// Token: 0x17000568 RID: 1384
		// (get) Token: 0x060027F6 RID: 10230 RVA: 0x000ABF4E File Offset: 0x000AA14E
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p;
			}
		}

		// Token: 0x17000569 RID: 1385
		// (get) Token: 0x060027F7 RID: 10231 RVA: 0x000ABF56 File Offset: 0x000AA156
		public global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q;
			}
		}

		// Token: 0x1700056A RID: 1386
		// (get) Token: 0x060027F8 RID: 10232 RVA: 0x000ABF5E File Offset: 0x000AA15E
		public global::Org.BouncyCastle.Math.BigInteger A
		{
			get
			{
				return this.a;
			}
		}

		// Token: 0x1700056B RID: 1387
		// (get) Token: 0x060027F9 RID: 10233 RVA: 0x000ABF66 File Offset: 0x000AA166
		public global::Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters ValidationParameters
		{
			get
			{
				return this.validation;
			}
		}

		// Token: 0x060027FA RID: 10234 RVA: 0x000ABF70 File Offset: 0x000AA170
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x060027FB RID: 10235 RVA: 0x000ABF96 File Offset: 0x000AA196
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.Gost3410Parameters other)
		{
			return this.p.Equals(other.p) && this.q.Equals(other.q) && this.a.Equals(other.a);
		}

		// Token: 0x060027FC RID: 10236 RVA: 0x000ABFD1 File Offset: 0x000AA1D1
		public override int GetHashCode()
		{
			return this.p.GetHashCode() ^ this.q.GetHashCode() ^ this.a.GetHashCode();
		}

		// Token: 0x0400102A RID: 4138
		private readonly global::Org.BouncyCastle.Math.BigInteger p;

		// Token: 0x0400102B RID: 4139
		private readonly global::Org.BouncyCastle.Math.BigInteger q;

		// Token: 0x0400102C RID: 4140
		private readonly global::Org.BouncyCastle.Math.BigInteger a;

		// Token: 0x0400102D RID: 4141
		private readonly global::Org.BouncyCastle.Crypto.Parameters.Gost3410ValidationParameters validation;
	}
}
