using System;
using Org.BouncyCastle.Math.EC.Abc;
using Org.BouncyCastle.Math.Field;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000209 RID: 521
	public abstract class AbstractF2mCurve : global::Org.BouncyCastle.Math.EC.ECCurve
	{
		// Token: 0x0600148E RID: 5262 RVA: 0x00060D8E File Offset: 0x0005EF8E
		public static global::Org.BouncyCastle.Math.BigInteger Inverse(int m, int[] ks, global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.LongArray(x).ModInverse(m, ks).ToBigInteger();
		}

		// Token: 0x0600148F RID: 5263 RVA: 0x00060DA4 File Offset: 0x0005EFA4
		private static global::Org.BouncyCastle.Math.Field.IFiniteField BuildField(int m, int k1, int k2, int k3)
		{
			if (k1 == 0)
			{
				throw new global::System.ArgumentException("k1 must be > 0");
			}
			if (k2 == 0)
			{
				if (k3 != 0)
				{
					throw new global::System.ArgumentException("k3 must be 0 if k2 == 0");
				}
				return global::Org.BouncyCastle.Math.Field.FiniteFields.GetBinaryExtensionField(new int[]
				{
					0,
					k1,
					m
				});
			}
			else
			{
				if (k2 <= k1)
				{
					throw new global::System.ArgumentException("k2 must be > k1");
				}
				if (k3 <= k2)
				{
					throw new global::System.ArgumentException("k3 must be > k2");
				}
				return global::Org.BouncyCastle.Math.Field.FiniteFields.GetBinaryExtensionField(new int[]
				{
					0,
					k1,
					k2,
					k3,
					m
				});
			}
		}

		// Token: 0x06001490 RID: 5264 RVA: 0x00060E1D File Offset: 0x0005F01D
		protected AbstractF2mCurve(int m, int k1, int k2, int k3) : base(global::Org.BouncyCastle.Math.EC.AbstractF2mCurve.BuildField(m, k1, k2, k3))
		{
		}

		// Token: 0x06001491 RID: 5265 RVA: 0x00060E30 File Offset: 0x0005F030
		[global::System.Obsolete("Per-point compression property will be removed")]
		public override global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(global::Org.BouncyCastle.Math.BigInteger x, global::Org.BouncyCastle.Math.BigInteger y, bool withCompression)
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = this.FromBigInteger(x);
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y = this.FromBigInteger(y);
			int coordinateSystem = this.CoordinateSystem;
			if (coordinateSystem - 5 <= 1)
			{
				if (X.IsZero)
				{
					if (!Y.Square().Equals(this.B))
					{
						throw new global::System.ArgumentException();
					}
				}
				else
				{
					Y = Y.Divide(X).Add(X);
				}
			}
			return this.CreateRawPoint(X, Y, withCompression);
		}

		// Token: 0x06001492 RID: 5266 RVA: 0x00060E92 File Offset: 0x0005F092
		public override bool IsValidFieldElement(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return x != null && x.SignValue >= 0 && x.BitLength <= this.FieldSize;
		}

		// Token: 0x06001493 RID: 5267 RVA: 0x00060EB4 File Offset: 0x0005F0B4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			int i = this.FieldSize;
			return this.FromBigInteger(global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomBigInteger(i, r));
		}

		// Token: 0x06001494 RID: 5268 RVA: 0x00060ED8 File Offset: 0x0005F0D8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			int i = this.FieldSize;
			global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement = this.FromBigInteger(global::Org.BouncyCastle.Math.EC.AbstractF2mCurve.ImplRandomFieldElementMult(r, i));
			global::Org.BouncyCastle.Math.EC.ECFieldElement fe2 = this.FromBigInteger(global::Org.BouncyCastle.Math.EC.AbstractF2mCurve.ImplRandomFieldElementMult(r, i));
			return ecfieldElement.Multiply(fe2);
		}

		// Token: 0x06001495 RID: 5269 RVA: 0x00060F10 File Offset: 0x0005F110
		protected override global::Org.BouncyCastle.Math.EC.ECPoint DecompressPoint(int yTilde, global::Org.BouncyCastle.Math.BigInteger X1)
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement xp = this.FromBigInteger(X1);
			global::Org.BouncyCastle.Math.EC.ECFieldElement yp = null;
			if (xp.IsZero)
			{
				yp = this.B.Sqrt();
			}
			else
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement beta = xp.Square().Invert().Multiply(this.B).Add(this.A).Add(xp);
				global::Org.BouncyCastle.Math.EC.ECFieldElement z = this.SolveQuadraticEquation(beta);
				if (z != null)
				{
					if (z.TestBitZero() != (yTilde == 1))
					{
						z = z.AddOne();
					}
					int coordinateSystem = this.CoordinateSystem;
					if (coordinateSystem - 5 <= 1)
					{
						yp = z.Add(xp);
					}
					else
					{
						yp = z.Multiply(xp);
					}
				}
			}
			if (yp == null)
			{
				throw new global::System.ArgumentException("Invalid point compression");
			}
			return this.CreateRawPoint(xp, yp, true);
		}

		// Token: 0x06001496 RID: 5270 RVA: 0x00060FBC File Offset: 0x0005F1BC
		internal global::Org.BouncyCastle.Math.EC.ECFieldElement SolveQuadraticEquation(global::Org.BouncyCastle.Math.EC.ECFieldElement beta)
		{
			global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement betaF2m = (global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement)beta;
			bool fastTrace = betaF2m.HasFastTrace;
			if (fastTrace && betaF2m.Trace() != 0)
			{
				return null;
			}
			int i = this.FieldSize;
			if ((i & 1) != 0)
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement r = betaF2m.HalfTrace();
				if (fastTrace || r.Square().Add(r).Add(beta).IsZero)
				{
					return r;
				}
				return null;
			}
			else
			{
				if (beta.IsZero)
				{
					return beta;
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement zeroElement = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
				for (;;)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement t = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Arbitrary(i));
					global::Org.BouncyCastle.Math.EC.ECFieldElement z = zeroElement;
					global::Org.BouncyCastle.Math.EC.ECFieldElement w = beta;
					for (int j = 1; j < i; j++)
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement w2 = w.Square();
						z = z.Square().Add(w2.Multiply(t));
						w = w2.Add(beta);
					}
					if (!w.IsZero)
					{
						break;
					}
					global::Org.BouncyCastle.Math.EC.ECFieldElement gamma = z.Square().Add(z);
					if (!gamma.IsZero)
					{
						return z;
					}
				}
				return null;
			}
		}

		// Token: 0x06001497 RID: 5271 RVA: 0x000610A8 File Offset: 0x0005F2A8
		internal virtual global::Org.BouncyCastle.Math.BigInteger[] GetSi()
		{
			if (this.si == null)
			{
				lock (this)
				{
					if (this.si == null)
					{
						this.si = global::Org.BouncyCastle.Math.EC.Abc.Tnaf.GetSi(this);
					}
				}
			}
			return this.si;
		}

		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06001498 RID: 5272 RVA: 0x00061100 File Offset: 0x0005F300
		public virtual bool IsKoblitz
		{
			get
			{
				return this.m_order != null && this.m_cofactor != null && this.m_b.IsOne && (this.m_a.IsZero || this.m_a.IsOne);
			}
		}

		// Token: 0x06001499 RID: 5273 RVA: 0x0006113C File Offset: 0x0005F33C
		private static global::Org.BouncyCastle.Math.BigInteger ImplRandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r, int m)
		{
			global::Org.BouncyCastle.Math.BigInteger x;
			do
			{
				x = global::Org.BouncyCastle.Utilities.BigIntegers.CreateRandomBigInteger(m, r);
			}
			while (x.SignValue <= 0);
			return x;
		}

		// Token: 0x0400094F RID: 2383
		private global::Org.BouncyCastle.Math.BigInteger[] si;
	}
}
