using System;
using Org.BouncyCastle.Asn1.X9;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003D6 RID: 982
	public class ECDomainParameters
	{
		// Token: 0x06002769 RID: 10089 RVA: 0x000AAD5F File Offset: 0x000A8F5F
		public ECDomainParameters(global::Org.BouncyCastle.Asn1.X9.X9ECParameters x9) : this(x9.Curve, x9.G, x9.N, x9.H, x9.GetSeed())
		{
		}

		// Token: 0x0600276A RID: 10090 RVA: 0x000AAD85 File Offset: 0x000A8F85
		public ECDomainParameters(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECPoint g, global::Org.BouncyCastle.Math.BigInteger n) : this(curve, g, n, global::Org.BouncyCastle.Math.BigInteger.One, null)
		{
		}

		// Token: 0x0600276B RID: 10091 RVA: 0x000AAD96 File Offset: 0x000A8F96
		public ECDomainParameters(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECPoint g, global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger h) : this(curve, g, n, h, null)
		{
		}

		// Token: 0x0600276C RID: 10092 RVA: 0x000AADA4 File Offset: 0x000A8FA4
		public ECDomainParameters(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECPoint g, global::Org.BouncyCastle.Math.BigInteger n, global::Org.BouncyCastle.Math.BigInteger h, byte[] seed)
		{
			if (curve == null)
			{
				throw new global::System.ArgumentNullException("curve");
			}
			if (g == null)
			{
				throw new global::System.ArgumentNullException("g");
			}
			if (n == null)
			{
				throw new global::System.ArgumentNullException("n");
			}
			this.curve = curve;
			this.g = global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters.ValidatePublicPoint(curve, g);
			this.n = n;
			this.h = h;
			this.seed = global::Org.BouncyCastle.Utilities.Arrays.Clone(seed);
		}

		// Token: 0x1700054A RID: 1354
		// (get) Token: 0x0600276D RID: 10093 RVA: 0x000AAE11 File Offset: 0x000A9011
		public global::Org.BouncyCastle.Math.EC.ECCurve Curve
		{
			get
			{
				return this.curve;
			}
		}

		// Token: 0x1700054B RID: 1355
		// (get) Token: 0x0600276E RID: 10094 RVA: 0x000AAE19 File Offset: 0x000A9019
		public global::Org.BouncyCastle.Math.EC.ECPoint G
		{
			get
			{
				return this.g;
			}
		}

		// Token: 0x1700054C RID: 1356
		// (get) Token: 0x0600276F RID: 10095 RVA: 0x000AAE21 File Offset: 0x000A9021
		public global::Org.BouncyCastle.Math.BigInteger N
		{
			get
			{
				return this.n;
			}
		}

		// Token: 0x1700054D RID: 1357
		// (get) Token: 0x06002770 RID: 10096 RVA: 0x000AAE29 File Offset: 0x000A9029
		public global::Org.BouncyCastle.Math.BigInteger H
		{
			get
			{
				return this.h;
			}
		}

		// Token: 0x1700054E RID: 1358
		// (get) Token: 0x06002771 RID: 10097 RVA: 0x000AAE34 File Offset: 0x000A9034
		public global::Org.BouncyCastle.Math.BigInteger HInv
		{
			get
			{
				global::Org.BouncyCastle.Math.BigInteger result;
				lock (this)
				{
					if (this.hInv == null)
					{
						this.hInv = global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverseVar(this.n, this.h);
					}
					result = this.hInv;
				}
				return result;
			}
		}

		// Token: 0x06002772 RID: 10098 RVA: 0x000AAE90 File Offset: 0x000A9090
		public byte[] GetSeed()
		{
			return global::Org.BouncyCastle.Utilities.Arrays.Clone(this.seed);
		}

		// Token: 0x06002773 RID: 10099 RVA: 0x000AAEA0 File Offset: 0x000A90A0
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x06002774 RID: 10100 RVA: 0x000AAEC6 File Offset: 0x000A90C6
		protected virtual bool Equals(global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters other)
		{
			return this.curve.Equals(other.curve) && this.g.Equals(other.g) && this.n.Equals(other.n);
		}

		// Token: 0x06002775 RID: 10101 RVA: 0x000AAF01 File Offset: 0x000A9101
		public override int GetHashCode()
		{
			return ((4 * 257 ^ this.curve.GetHashCode()) * 257 ^ this.g.GetHashCode()) * 257 ^ this.n.GetHashCode();
		}

		// Token: 0x06002776 RID: 10102 RVA: 0x000AAF3C File Offset: 0x000A913C
		public global::Org.BouncyCastle.Math.BigInteger ValidatePrivateScalar(global::Org.BouncyCastle.Math.BigInteger d)
		{
			if (d == null)
			{
				throw new global::System.ArgumentNullException("d", "Scalar cannot be null");
			}
			if (d.CompareTo(global::Org.BouncyCastle.Math.BigInteger.One) < 0 || d.CompareTo(this.N) >= 0)
			{
				throw new global::System.ArgumentException("Scalar is not in the interval [1, n - 1]", "d");
			}
			return d;
		}

		// Token: 0x06002777 RID: 10103 RVA: 0x000AAF8A File Offset: 0x000A918A
		public global::Org.BouncyCastle.Math.EC.ECPoint ValidatePublicPoint(global::Org.BouncyCastle.Math.EC.ECPoint q)
		{
			return global::Org.BouncyCastle.Crypto.Parameters.ECDomainParameters.ValidatePublicPoint(this.Curve, q);
		}

		// Token: 0x06002778 RID: 10104 RVA: 0x000AAF98 File Offset: 0x000A9198
		internal static global::Org.BouncyCastle.Math.EC.ECPoint ValidatePublicPoint(global::Org.BouncyCastle.Math.EC.ECCurve c, global::Org.BouncyCastle.Math.EC.ECPoint q)
		{
			if (q == null)
			{
				throw new global::System.ArgumentNullException("q", "Point cannot be null");
			}
			q = global::Org.BouncyCastle.Math.EC.ECAlgorithms.ImportPoint(c, q).Normalize();
			if (q.IsInfinity)
			{
				throw new global::System.ArgumentException("Point at infinity", "q");
			}
			if (!q.IsValid())
			{
				throw new global::System.ArgumentException("Point not on curve", "q");
			}
			return q;
		}

		// Token: 0x04000FFD RID: 4093
		private readonly global::Org.BouncyCastle.Math.EC.ECCurve curve;

		// Token: 0x04000FFE RID: 4094
		private readonly byte[] seed;

		// Token: 0x04000FFF RID: 4095
		private readonly global::Org.BouncyCastle.Math.EC.ECPoint g;

		// Token: 0x04001000 RID: 4096
		private readonly global::Org.BouncyCastle.Math.BigInteger n;

		// Token: 0x04001001 RID: 4097
		private readonly global::Org.BouncyCastle.Math.BigInteger h;

		// Token: 0x04001002 RID: 4098
		private global::Org.BouncyCastle.Math.BigInteger hInv;
	}
}
