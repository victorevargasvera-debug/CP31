using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D2 RID: 978
	public class DsaParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x0600274D RID: 10061 RVA: 0x000AAA0E File Offset: 0x000A8C0E
		public DsaParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger g) : this(p, q, g, null)
		{
		}

		// Token: 0x0600274E RID: 10062 RVA: 0x000AAA1C File Offset: 0x000A8C1C
		public DsaParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger g, global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters parameters)
		{
			if (p == null)
			{
				throw new global::System.ArgumentNullException("p");
			}
			if (q == null)
			{
				throw new global::System.ArgumentNullException("q");
			}
			if (g == null)
			{
				throw new global::System.ArgumentNullException("g");
			}
			this.p = p;
			this.q = q;
			this.g = g;
			this.validation = parameters;
		}

		// Token: 0x17000542 RID: 1346
		// (get) Token: 0x0600274F RID: 10063 RVA: 0x000AAA76 File Offset: 0x000A8C76
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p;
			}
		}

		// Token: 0x17000543 RID: 1347
		// (get) Token: 0x06002750 RID: 10064 RVA: 0x000AAA7E File Offset: 0x000A8C7E
		public global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q;
			}
		}

		// Token: 0x17000544 RID: 1348
		// (get) Token: 0x06002751 RID: 10065 RVA: 0x000AAA86 File Offset: 0x000A8C86
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x17000545 RID: 1349
		// (get) Token: 0x06002752 RID: 10066 RVA: 0x000AAA8E File Offset: 0x000A8C8E
		public global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters ValidationParameters
		{
			get
			{
				return this.validation;
			}
		}

		// Token: 0x06002753 RID: 10067 RVA: 0x000AAA98 File Offset: 0x000A8C98
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DsaParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DsaParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x06002754 RID: 10068 RVA: 0x000AAABE File Offset: 0x000A8CBE
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DsaParameters other)
		{
			return this.p.Equals(other.p) && this.q.Equals(other.q) && this.g.Equals(other.g);
		}

		// Token: 0x06002755 RID: 10069 RVA: 0x000AAAF9 File Offset: 0x000A8CF9
		public override int GetHashCode()
		{
			return this.p.GetHashCode() ^ this.q.GetHashCode() ^ this.g.GetHashCode();
		}

		// Token: 0x04000FF4 RID: 4084
		private readonly global::Org.BouncyCastle.Math.BigInteger p;

		// Token: 0x04000FF5 RID: 4085
		private readonly global::Org.BouncyCastle.Math.BigInteger q;

		// Token: 0x04000FF6 RID: 4086
		private readonly global::Org.BouncyCastle.Math.BigInteger g;

		// Token: 0x04000FF7 RID: 4087
		private readonly global::Org.BouncyCastle.Crypto.Parameters.DsaValidationParameters validation;
	}
}
