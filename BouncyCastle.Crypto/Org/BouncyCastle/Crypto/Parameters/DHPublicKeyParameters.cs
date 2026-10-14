using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Parameters
{
	// Token: 0x020003CD RID: 973
	public class DHPublicKeyParameters : global::Org.BouncyCastle.Crypto.Parameters.DHKeyParameters
	{
		// Token: 0x06002731 RID: 10033 RVA: 0x000AA64C File Offset: 0x000A884C
		private static global::Org.BouncyCastle.Math.BigInteger Validate(global::Org.BouncyCastle.Math.BigInteger y, global::Org.BouncyCastle.Crypto.Parameters.DHParameters dhParams)
		{
			if (y == null)
			{
				throw new global::System.ArgumentNullException("y");
			}
			global::Org.BouncyCastle.Math.BigInteger p = dhParams.P;
			if (y.CompareTo(global::Org.BouncyCastle.Math.BigInteger.Two) < 0 || y.CompareTo(p.Subtract(global::Org.BouncyCastle.Math.BigInteger.Two)) > 0)
			{
				throw new global::System.ArgumentException("invalid DH public key", "y");
			}
			global::Org.BouncyCastle.Math.BigInteger q = dhParams.Q;
			if (q == null)
			{
				return y;
			}
			if (p.TestBit(0) && p.BitLength - 1 == q.BitLength && p.ShiftRight(1).Equals(q))
			{
				if (1 == global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters.Legendre(y, p))
				{
					return y;
				}
			}
			else if (global::Org.BouncyCastle.Math.BigInteger.One.Equals(y.ModPow(q, p)))
			{
				return y;
			}
			throw new global::System.ArgumentException("value does not appear to be in correct group", "y");
		}

		// Token: 0x06002732 RID: 10034 RVA: 0x000AA705 File Offset: 0x000A8905
		public DHPublicKeyParameters(global::Org.BouncyCastle.Math.BigInteger y, global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters) : base(false, parameters)
		{
			this.y = global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters.Validate(y, parameters);
		}

		// Token: 0x06002733 RID: 10035 RVA: 0x000AA71C File Offset: 0x000A891C
		public DHPublicKeyParameters(global::Org.BouncyCastle.Math.BigInteger y, global::Org.BouncyCastle.Crypto.Parameters.DHParameters parameters, global::Org.BouncyCastle.Asn1.DerObjectIdentifier algorithmOid) : base(false, parameters, algorithmOid)
		{
			this.y = global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters.Validate(y, parameters);
		}

		// Token: 0x17000539 RID: 1337
		// (get) Token: 0x06002734 RID: 10036 RVA: 0x000AA734 File Offset: 0x000A8934
		public virtual global::Org.BouncyCastle.Math.BigInteger Y
		{
			get
			{
				return this.y;
			}
		}

		// Token: 0x06002735 RID: 10037 RVA: 0x000AA73C File Offset: 0x000A893C
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters other = obj as global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters;
			return other != null && this.Equals(other);
		}

		// Token: 0x06002736 RID: 10038 RVA: 0x000AA762 File Offset: 0x000A8962
		protected bool Equals(global::Org.BouncyCastle.Crypto.Parameters.DHPublicKeyParameters other)
		{
			return this.y.Equals(other.y) && base.Equals(other);
		}

		// Token: 0x06002737 RID: 10039 RVA: 0x000AA780 File Offset: 0x000A8980
		public override int GetHashCode()
		{
			return this.y.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x06002738 RID: 10040 RVA: 0x000AA794 File Offset: 0x000A8994
		private static int Legendre(global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b)
		{
			int bitLength = b.BitLength;
			uint[] A = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bitLength, a);
			uint[] B = global::Org.BouncyCastle.Math.Raw.Nat.FromBigInteger(bitLength, b);
			int r = 0;
			int len = B.Length;
			for (;;)
			{
				if (A[0] != 0U)
				{
					int shift = global::Org.BouncyCastle.Utilities.Integers.NumberOfTrailingZeros((int)A[0]);
					if (shift > 0)
					{
						global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownBits(len, A, shift, 0U);
						int bits = (int)B[0];
						r ^= ((bits ^ bits >> 1) & shift << 1);
					}
					int cmp = global::Org.BouncyCastle.Math.Raw.Nat.Compare(len, A, B);
					if (cmp == 0)
					{
						break;
					}
					if (cmp < 0)
					{
						r ^= (int)(A[0] & B[0]);
						uint[] array = A;
						A = B;
						B = array;
					}
					while (A[len - 1] == 0U)
					{
						len--;
					}
					global::Org.BouncyCastle.Math.Raw.Nat.Sub(len, A, B, A);
				}
				else
				{
					global::Org.BouncyCastle.Math.Raw.Nat.ShiftDownWord(len, A, 0U);
				}
			}
			if (!global::Org.BouncyCastle.Math.Raw.Nat.IsOne(len, B))
			{
				return 0;
			}
			return 1 - (r & 2);
		}

		// Token: 0x04000FE8 RID: 4072
		private readonly global::Org.BouncyCastle.Math.BigInteger y;
	}
}
