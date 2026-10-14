using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003E5 RID: 997
	public class ElGamalParameters : global::Org.BouncyCastle.Crypto.ICipherParameters
	{
		// Token: 0x060027D2 RID: 10194 RVA: 0x000ABB97 File Offset: 0x000A9D97
		public ElGamalParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g) : this(p, g, 0)
		{
		}

		// Token: 0x060027D3 RID: 10195 RVA: 0x000ABBA2 File Offset: 0x000A9DA2
		public ElGamalParameters(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g, int l)
		{
			if (p == null)
			{
				throw new global::System.ArgumentNullException("p");
			}
			if (g == null)
			{
				throw new global::System.ArgumentNullException("g");
			}
			this.p = p;
			this.g = g;
			this.l = l;
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x060027D4 RID: 10196 RVA: 0x000ABBDB File Offset: 0x000A9DDB
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x060027D5 RID: 10197 RVA: 0x000ABBE3 File Offset: 0x000A9DE3
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x060027D6 RID: 10198 RVA: 0x000ABBEB File Offset: 0x000A9DEB
		public int L
		{
			get
			{
				return this.l;
			}
		}

		// Token: 0x060027D7 RID: 10199 RVA: 0x000ABBF4 File Offset: 0x000A9DF4
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x060027D8 RID: 10200 RVA: 0x000ABC1A File Offset: 0x000A9E1A
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.ElGamalParameters other)
		{
			return this.p.Equals(other.p) && this.g.Equals(other.g) && this.l == other.l;
		}

		// Token: 0x060027D9 RID: 10201 RVA: 0x000ABC52 File Offset: 0x000A9E52
		public override int GetHashCode()
		{
			return this.p.GetHashCode() ^ this.g.GetHashCode() ^ this.l;
		}

		// Token: 0x0400101D RID: 4125
		private readonly global::Org.BouncyCastle.Math.BigInteger p;

		// Token: 0x0400101E RID: 4126
		private readonly global::Org.BouncyCastle.Math.BigInteger g;

		// Token: 0x0400101F RID: 4127
		private readonly int l;
	}
}
