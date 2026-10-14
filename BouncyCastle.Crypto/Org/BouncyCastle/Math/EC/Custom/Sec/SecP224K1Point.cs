using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200025C RID: 604
	internal class SecP224K1Point : global::Org.BouncyCastle.Math.EC.AbstractFpPoint
	{
		// Token: 0x060018E4 RID: 6372 RVA: 0x0007686A File Offset: 0x00074A6A
		public SecP224K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x060018E5 RID: 6373 RVA: 0x00076876 File Offset: 0x00074A76
		public SecP224K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x060018E6 RID: 6374 RVA: 0x00076898 File Offset: 0x00074A98
		internal SecP224K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x060018E7 RID: 6375 RVA: 0x000768A7 File Offset: 0x00074AA7
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x060018E8 RID: 6376 RVA: 0x000768BC File Offset: 0x00074ABC
		public override global::Org.BouncyCastle.Math.EC.ECPoint Add(global::Org.BouncyCastle.Math.EC.ECPoint b)
		{
			if (base.IsInfinity)
			{
				return b;
			}
			if (b.IsInfinity)
			{
				return this;
			}
			if (this == b)
			{
				return this.Twice();
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement X2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)b.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Y2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)b.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Z2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)b.RawZCoords[0];
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat224.CreateExt();
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			uint[] t3 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			uint[] t4 = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			bool Z1IsOne = Z.IsOne;
			uint[] U2;
			uint[] S2;
			if (Z1IsOne)
			{
				U2 = X2.x;
				S2 = Y2.x;
			}
			else
			{
				S2 = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(Z.x, S2);
				U2 = t2;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(S2, X2.x, U2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(S2, Z.x, S2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(S2, Y2.x, S2);
			}
			bool Z2IsOne = Z2.IsOne;
			uint[] U3;
			uint[] S3;
			if (Z2IsOne)
			{
				U3 = X.x;
				S3 = Y.x;
			}
			else
			{
				S3 = t4;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(Z2.x, S3);
				U3 = tt;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(S3, X.x, U3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(S3, Z2.x, S3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(S3, Y.x, S3);
			}
			uint[] H = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(U3, U2, H);
			uint[] R = t2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(S3, S2, R);
			if (!global::Org.BouncyCastle.Math.Raw.Nat224.IsZero(H))
			{
				uint[] HSquared = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(H, HSquared);
				uint[] G = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(HSquared, H, G);
				uint[] V = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(HSquared, U3, V);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Negate(G, G);
				global::Org.BouncyCastle.Math.Raw.Nat224.Mul(S3, G, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat224.AddBothTo(V, V, G), G);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement X3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(t4);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(R, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(X3.x, G, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Y3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(G);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(V, X3.x, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.MultiplyAddToExt(Y3.x, R, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Reduce(tt, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Z3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(H);
				if (!Z1IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(Z3.x, Z.x, Z3.x);
				}
				if (!Z2IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(Z3.x, Z2.x, Z3.x);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z3
				};
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(curve, X3, Y3, zs, base.IsCompressed);
			}
			if (global::Org.BouncyCastle.Math.Raw.Nat224.IsZero(R))
			{
				return this.Twice();
			}
			return curve.Infinity;
		}

		// Token: 0x060018E9 RID: 6377 RVA: 0x00076B84 File Offset: 0x00074D84
		public override global::Org.BouncyCastle.Math.EC.ECPoint Twice()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)base.RawYCoord;
			if (Y.IsZero)
			{
				return curve.Infinity;
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)base.RawZCoords[0];
			uint[] Y1Squared = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(Y.x, Y1Squared);
			uint[] T = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(Y1Squared, T);
			uint[] M = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(X.x, M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat224.AddBothTo(M, M, M), M);
			uint[] S = Y1Squared;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(Y1Squared, X.x, S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(7, S, 2, 0U), S);
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(7, T, 3, 0U, t), t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement X2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(T);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Square(M, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Y2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(S, X2.x, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(Y2.x, M, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Subtract(Y2.x, t, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement Z2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Twice(Y.x, Z2.x);
			if (!Z.IsOne)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Multiply(Z2.x, Z.x, Z2.x);
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(curve, X2, Y2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x060018EA RID: 6378 RVA: 0x00076D40 File Offset: 0x00074F40
		public override global::Org.BouncyCastle.Math.EC.ECPoint TwicePlus(global::Org.BouncyCastle.Math.EC.ECPoint b)
		{
			if (this == b)
			{
				return this.ThreeTimes();
			}
			if (base.IsInfinity)
			{
				return b;
			}
			if (b.IsInfinity)
			{
				return this.Twice();
			}
			if (base.RawYCoord.IsZero)
			{
				return b;
			}
			return this.Twice().Add(b);
		}

		// Token: 0x060018EB RID: 6379 RVA: 0x00076D8C File Offset: 0x00074F8C
		public override global::Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
		{
			if (base.IsInfinity || base.RawYCoord.IsZero)
			{
				return this;
			}
			return this.Twice().Add(this);
		}

		// Token: 0x060018EC RID: 6380 RVA: 0x00076DB1 File Offset: 0x00074FB1
		public override global::Org.BouncyCastle.Math.EC.ECPoint Negate()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(this.Curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
		}
	}
}
