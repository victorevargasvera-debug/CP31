using System;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200020D RID: 525
	public class FpFieldElement : global::Org.BouncyCastle.Math.EC.AbstractFpFieldElement
	{
		// Token: 0x060014C9 RID: 5321 RVA: 0x00061544 File Offset: 0x0005F744
		internal static global::Org.BouncyCastle.Math.BigInteger CalculateResidue(global::Org.BouncyCastle.Math.BigInteger p)
		{
			int bitLength = p.BitLength;
			if (bitLength >= 96)
			{
				if (p.ShiftRight(bitLength - 64).LongValue == -1L)
				{
					return global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(bitLength).Subtract(p);
				}
				if ((bitLength & 7) == 0)
				{
					return global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(bitLength << 1).Divide(p).Negate();
				}
			}
			return null;
		}

		// Token: 0x060014CA RID: 5322 RVA: 0x000615A1 File Offset: 0x0005F7A1
		[global::System.Obsolete("Use ECCurve.FromBigInteger to construct field elements")]
		public FpFieldElement(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger x) : this(q, global::Org.BouncyCastle.Math.EC.FpFieldElement.CalculateResidue(q), x)
		{
		}

		// Token: 0x060014CB RID: 5323 RVA: 0x000615B4 File Offset: 0x0005F7B4
		internal FpFieldElement(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x == null || x.SignValue < 0 || x.CompareTo(q) >= 0)
			{
				throw new global::System.ArgumentException("value invalid in Fp field element", "x");
			}
			this.q = q;
			this.r = r;
			this.x = x;
		}

		// Token: 0x060014CC RID: 5324 RVA: 0x00061602 File Offset: 0x0005F802
		public override global::Org.BouncyCastle.Math.BigInteger ToBigInteger()
		{
			return this.x;
		}

		// Token: 0x1700028C RID: 652
		// (get) Token: 0x060014CD RID: 5325 RVA: 0x0006160A File Offset: 0x0005F80A
		public override string FieldName
		{
			get
			{
				return "Fp";
			}
		}

		// Token: 0x1700028D RID: 653
		// (get) Token: 0x060014CE RID: 5326 RVA: 0x00061611 File Offset: 0x0005F811
		public override int FieldSize
		{
			get
			{
				return this.q.BitLength;
			}
		}

		// Token: 0x1700028E RID: 654
		// (get) Token: 0x060014CF RID: 5327 RVA: 0x0006161E File Offset: 0x0005F81E
		public global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.q;
			}
		}

		// Token: 0x060014D0 RID: 5328 RVA: 0x00061626 File Offset: 0x0005F826
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Add(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModAdd(this.x, b.ToBigInteger()));
		}

		// Token: 0x060014D1 RID: 5329 RVA: 0x0006164C File Offset: 0x0005F84C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement AddOne()
		{
			global::Org.BouncyCastle.Math.BigInteger x2 = this.x.Add(global::Org.BouncyCastle.Math.BigInteger.One);
			if (x2.CompareTo(this.q) == 0)
			{
				x2 = global::Org.BouncyCastle.Math.BigInteger.Zero;
			}
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, x2);
		}

		// Token: 0x060014D2 RID: 5330 RVA: 0x00061690 File Offset: 0x0005F890
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Subtract(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModSubtract(this.x, b.ToBigInteger()));
		}

		// Token: 0x060014D3 RID: 5331 RVA: 0x000616B5 File Offset: 0x0005F8B5
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Multiply(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModMult(this.x, b.ToBigInteger()));
		}

		// Token: 0x060014D4 RID: 5332 RVA: 0x000616DC File Offset: 0x0005F8DC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			global::Org.BouncyCastle.Math.BigInteger ax = this.x;
			global::Org.BouncyCastle.Math.BigInteger bx = b.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger bigInteger = x.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger yx = y.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger ab = ax.Multiply(bx);
			global::Org.BouncyCastle.Math.BigInteger xy = bigInteger.Multiply(yx);
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModReduce(ab.Subtract(xy)));
		}

		// Token: 0x060014D5 RID: 5333 RVA: 0x00061734 File Offset: 0x0005F934
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement MultiplyPlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			global::Org.BouncyCastle.Math.BigInteger bigInteger = this.x;
			global::Org.BouncyCastle.Math.BigInteger bx = b.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger xx = x.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger yx = y.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger bigInteger2 = bigInteger.Multiply(bx);
			global::Org.BouncyCastle.Math.BigInteger xy = xx.Multiply(yx);
			global::Org.BouncyCastle.Math.BigInteger sum = bigInteger2.Add(xy);
			if (this.r != null && this.r.SignValue < 0 && sum.BitLength > this.q.BitLength << 1)
			{
				sum = sum.Subtract(this.q.ShiftLeft(this.q.BitLength));
			}
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModReduce(sum));
		}

		// Token: 0x060014D6 RID: 5334 RVA: 0x000617D6 File Offset: 0x0005F9D6
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Divide(global::Org.BouncyCastle.Math.EC.ECFieldElement b)
		{
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModMult(this.x, this.ModInverse(b.ToBigInteger())));
		}

		// Token: 0x060014D7 RID: 5335 RVA: 0x00061801 File Offset: 0x0005FA01
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Negate()
		{
			if (this.x.SignValue != 0)
			{
				return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.q.Subtract(this.x));
			}
			return this;
		}

		// Token: 0x060014D8 RID: 5336 RVA: 0x00061834 File Offset: 0x0005FA34
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Square()
		{
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModMult(this.x, this.x));
		}

		// Token: 0x060014D9 RID: 5337 RVA: 0x0006185C File Offset: 0x0005FA5C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquareMinusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			global::Org.BouncyCastle.Math.BigInteger bigInteger = this.x;
			global::Org.BouncyCastle.Math.BigInteger xx = x.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger yx = y.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger aa = bigInteger.Multiply(bigInteger);
			global::Org.BouncyCastle.Math.BigInteger xy = xx.Multiply(yx);
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModReduce(aa.Subtract(xy)));
		}

		// Token: 0x060014DA RID: 5338 RVA: 0x000618AC File Offset: 0x0005FAAC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement SquarePlusProduct(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y)
		{
			global::Org.BouncyCastle.Math.BigInteger bigInteger = this.x;
			global::Org.BouncyCastle.Math.BigInteger xx = x.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger yx = y.ToBigInteger();
			global::Org.BouncyCastle.Math.BigInteger bigInteger2 = bigInteger.Multiply(bigInteger);
			global::Org.BouncyCastle.Math.BigInteger xy = xx.Multiply(yx);
			global::Org.BouncyCastle.Math.BigInteger sum = bigInteger2.Add(xy);
			if (this.r != null && this.r.SignValue < 0 && sum.BitLength > this.q.BitLength << 1)
			{
				sum = sum.Subtract(this.q.ShiftLeft(this.q.BitLength));
			}
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModReduce(sum));
		}

		// Token: 0x060014DB RID: 5339 RVA: 0x00061942 File Offset: 0x0005FB42
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Invert()
		{
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModInverse(this.x));
		}

		// Token: 0x060014DC RID: 5340 RVA: 0x00061964 File Offset: 0x0005FB64
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement Sqrt()
		{
			if (this.IsZero || this.IsOne)
			{
				return this;
			}
			if (!this.q.TestBit(0))
			{
				throw global::Org.BouncyCastle.Utilities.Platform.CreateNotImplementedException("even value of q");
			}
			if (this.q.TestBit(1))
			{
				global::Org.BouncyCastle.Math.BigInteger e = this.q.ShiftRight(2).Add(global::Org.BouncyCastle.Math.BigInteger.One);
				return this.CheckSqrt(new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.x.ModPow(e, this.q)));
			}
			if (this.q.TestBit(2))
			{
				global::Org.BouncyCastle.Math.BigInteger t = this.x.ModPow(this.q.ShiftRight(3), this.q);
				global::Org.BouncyCastle.Math.BigInteger t2 = this.ModMult(t, this.x);
				if (this.ModMult(t2, t).Equals(global::Org.BouncyCastle.Math.BigInteger.One))
				{
					return this.CheckSqrt(new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, t2));
				}
				global::Org.BouncyCastle.Math.BigInteger t3 = global::Org.BouncyCastle.Math.BigInteger.Two.ModPow(this.q.ShiftRight(2), this.q);
				global::Org.BouncyCastle.Math.BigInteger y = this.ModMult(t2, t3);
				return this.CheckSqrt(new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, y));
			}
			else
			{
				global::Org.BouncyCastle.Math.BigInteger legendreExponent = this.q.ShiftRight(1);
				if (!this.x.ModPow(legendreExponent, this.q).Equals(global::Org.BouncyCastle.Math.BigInteger.One))
				{
					return null;
				}
				global::Org.BouncyCastle.Math.BigInteger X = this.x;
				global::Org.BouncyCastle.Math.BigInteger fourX = this.ModDouble(this.ModDouble(X));
				global::Org.BouncyCastle.Math.BigInteger i = legendreExponent.Add(global::Org.BouncyCastle.Math.BigInteger.One);
				global::Org.BouncyCastle.Math.BigInteger qMinusOne = this.q.Subtract(global::Org.BouncyCastle.Math.BigInteger.One);
				global::Org.BouncyCastle.Math.BigInteger V;
				for (;;)
				{
					global::Org.BouncyCastle.Math.BigInteger P = global::Org.BouncyCastle.Math.BigInteger.Arbitrary(this.q.BitLength);
					if (P.CompareTo(this.q) < 0 && this.ModReduce(P.Multiply(P).Subtract(fourX)).ModPow(legendreExponent, this.q).Equals(qMinusOne))
					{
						global::Org.BouncyCastle.Math.BigInteger[] array = this.LucasSequence(P, X, i);
						global::Org.BouncyCastle.Math.BigInteger U = array[0];
						V = array[1];
						if (this.ModMult(V, V).Equals(fourX))
						{
							break;
						}
						if (!U.Equals(global::Org.BouncyCastle.Math.BigInteger.One) && !U.Equals(qMinusOne))
						{
							goto Block_11;
						}
					}
				}
				return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.q, this.r, this.ModHalfAbs(V));
				Block_11:
				return null;
			}
		}

		// Token: 0x060014DD RID: 5341 RVA: 0x00061BAC File Offset: 0x0005FDAC
		private global::Org.BouncyCastle.Math.EC.ECFieldElement CheckSqrt(global::Org.BouncyCastle.Math.EC.ECFieldElement z)
		{
			if (!z.Square().Equals(this))
			{
				return null;
			}
			return z;
		}

		// Token: 0x060014DE RID: 5342 RVA: 0x00061BC0 File Offset: 0x0005FDC0
		private global::Org.BouncyCastle.Math.BigInteger[] LucasSequence(global::Org.BouncyCastle.Math.BigInteger P, global::Org.BouncyCastle.Math.BigInteger Q, global::Org.BouncyCastle.Math.BigInteger k)
		{
			int bitLength = k.BitLength;
			int s = k.GetLowestSetBit();
			global::Org.BouncyCastle.Math.BigInteger Uh = global::Org.BouncyCastle.Math.BigInteger.One;
			global::Org.BouncyCastle.Math.BigInteger Vl = global::Org.BouncyCastle.Math.BigInteger.Two;
			global::Org.BouncyCastle.Math.BigInteger Vh = P;
			global::Org.BouncyCastle.Math.BigInteger Ql = global::Org.BouncyCastle.Math.BigInteger.One;
			global::Org.BouncyCastle.Math.BigInteger Qh = global::Org.BouncyCastle.Math.BigInteger.One;
			for (int i = bitLength - 1; i >= s + 1; i--)
			{
				Ql = this.ModMult(Ql, Qh);
				if (k.TestBit(i))
				{
					Qh = this.ModMult(Ql, Q);
					Uh = this.ModMult(Uh, Vh);
					Vl = this.ModReduce(Vh.Multiply(Vl).Subtract(P.Multiply(Ql)));
					Vh = this.ModReduce(Vh.Multiply(Vh).Subtract(Qh.ShiftLeft(1)));
				}
				else
				{
					Qh = Ql;
					Uh = this.ModReduce(Uh.Multiply(Vl).Subtract(Ql));
					Vh = this.ModReduce(Vh.Multiply(Vl).Subtract(P.Multiply(Ql)));
					Vl = this.ModReduce(Vl.Multiply(Vl).Subtract(Ql.ShiftLeft(1)));
				}
			}
			Ql = this.ModMult(Ql, Qh);
			Qh = this.ModMult(Ql, Q);
			Uh = this.ModReduce(Uh.Multiply(Vl).Subtract(Ql));
			Vl = this.ModReduce(Vh.Multiply(Vl).Subtract(P.Multiply(Ql)));
			Ql = this.ModMult(Ql, Qh);
			for (int j = 1; j <= s; j++)
			{
				Uh = this.ModMult(Uh, Vl);
				Vl = this.ModReduce(Vl.Multiply(Vl).Subtract(Ql.ShiftLeft(1)));
				Ql = this.ModMult(Ql, Ql);
			}
			return new global::Org.BouncyCastle.Math.BigInteger[]
			{
				Uh,
				Vl
			};
		}

		// Token: 0x060014DF RID: 5343 RVA: 0x00061D64 File Offset: 0x0005FF64
		protected virtual global::Org.BouncyCastle.Math.BigInteger ModAdd(global::Org.BouncyCastle.Math.BigInteger x1, global::Org.BouncyCastle.Math.BigInteger x2)
		{
			global::Org.BouncyCastle.Math.BigInteger x3 = x1.Add(x2);
			if (x3.CompareTo(this.q) >= 0)
			{
				x3 = x3.Subtract(this.q);
			}
			return x3;
		}

		// Token: 0x060014E0 RID: 5344 RVA: 0x00061D98 File Offset: 0x0005FF98
		protected virtual global::Org.BouncyCastle.Math.BigInteger ModDouble(global::Org.BouncyCastle.Math.BigInteger x)
		{
			global::Org.BouncyCastle.Math.BigInteger _2x = x.ShiftLeft(1);
			if (_2x.CompareTo(this.q) >= 0)
			{
				_2x = _2x.Subtract(this.q);
			}
			return _2x;
		}

		// Token: 0x060014E1 RID: 5345 RVA: 0x00061DCA File Offset: 0x0005FFCA
		protected virtual global::Org.BouncyCastle.Math.BigInteger ModHalf(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x.TestBit(0))
			{
				x = this.q.Add(x);
			}
			return x.ShiftRight(1);
		}

		// Token: 0x060014E2 RID: 5346 RVA: 0x00061DEA File Offset: 0x0005FFEA
		protected virtual global::Org.BouncyCastle.Math.BigInteger ModHalfAbs(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (x.TestBit(0))
			{
				x = this.q.Subtract(x);
			}
			return x.ShiftRight(1);
		}

		// Token: 0x060014E3 RID: 5347 RVA: 0x00061E0A File Offset: 0x0006000A
		protected virtual global::Org.BouncyCastle.Math.BigInteger ModInverse(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return global::Org.BouncyCastle.Utilities.BigIntegers.ModOddInverse(this.q, x);
		}

		// Token: 0x060014E4 RID: 5348 RVA: 0x00061E18 File Offset: 0x00060018
		protected virtual global::Org.BouncyCastle.Math.BigInteger ModMult(global::Org.BouncyCastle.Math.BigInteger x1, global::Org.BouncyCastle.Math.BigInteger x2)
		{
			return this.ModReduce(x1.Multiply(x2));
		}

		// Token: 0x060014E5 RID: 5349 RVA: 0x00061E28 File Offset: 0x00060028
		protected virtual global::Org.BouncyCastle.Math.BigInteger ModReduce(global::Org.BouncyCastle.Math.BigInteger x)
		{
			if (this.r == null)
			{
				x = x.Mod(this.q);
			}
			else
			{
				bool negative = x.SignValue < 0;
				if (negative)
				{
					x = x.Abs();
				}
				int qLen = this.q.BitLength;
				if (this.r.SignValue > 0)
				{
					global::Org.BouncyCastle.Math.BigInteger qMod = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(qLen);
					bool rIsOne = this.r.Equals(global::Org.BouncyCastle.Math.BigInteger.One);
					while (x.BitLength > qLen + 1)
					{
						global::Org.BouncyCastle.Math.BigInteger u = x.ShiftRight(qLen);
						global::Org.BouncyCastle.Math.BigInteger v = x.Remainder(qMod);
						if (!rIsOne)
						{
							u = u.Multiply(this.r);
						}
						x = u.Add(v);
					}
				}
				else
				{
					int d = (qLen - 1 & 31) + 1;
					global::Org.BouncyCastle.Math.BigInteger v2 = this.r.Negate().Multiply(x.ShiftRight(qLen - d)).ShiftRight(qLen + d).Multiply(this.q);
					global::Org.BouncyCastle.Math.BigInteger bk = global::Org.BouncyCastle.Math.BigInteger.One.ShiftLeft(qLen + d);
					v2 = v2.Remainder(bk);
					x = x.Remainder(bk);
					x = x.Subtract(v2);
					if (x.SignValue < 0)
					{
						x = x.Add(bk);
					}
				}
				while (x.CompareTo(this.q) >= 0)
				{
					x = x.Subtract(this.q);
				}
				if (negative && x.SignValue != 0)
				{
					x = this.q.Subtract(x);
				}
			}
			return x;
		}

		// Token: 0x060014E6 RID: 5350 RVA: 0x00061F94 File Offset: 0x00060194
		protected virtual global::Org.BouncyCastle.Math.BigInteger ModSubtract(global::Org.BouncyCastle.Math.BigInteger x1, global::Org.BouncyCastle.Math.BigInteger x2)
		{
			global::Org.BouncyCastle.Math.BigInteger x3 = x1.Subtract(x2);
			if (x3.SignValue < 0)
			{
				x3 = x3.Add(this.q);
			}
			return x3;
		}

		// Token: 0x060014E7 RID: 5351 RVA: 0x00061FC0 File Offset: 0x000601C0
		public override bool Equals(object obj)
		{
			if (obj == this)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.EC.FpFieldElement other = obj as global::Org.BouncyCastle.Math.EC.FpFieldElement;
			return other != null && this.Equals(other);
		}

		// Token: 0x060014E8 RID: 5352 RVA: 0x00061FE6 File Offset: 0x000601E6
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.FpFieldElement other)
		{
			return this.q.Equals(other.q) && base.Equals(other);
		}

		// Token: 0x060014E9 RID: 5353 RVA: 0x00062004 File Offset: 0x00060204
		public override int GetHashCode()
		{
			return this.q.GetHashCode() ^ base.GetHashCode();
		}

		// Token: 0x04000956 RID: 2390
		private readonly global::Org.BouncyCastle.Math.BigInteger q;

		// Token: 0x04000957 RID: 2391
		private readonly global::Org.BouncyCastle.Math.BigInteger r;

		// Token: 0x04000958 RID: 2392
		private readonly global::Org.BouncyCastle.Math.BigInteger x;
	}
}
