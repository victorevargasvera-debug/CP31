using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200026C RID: 620
	internal class SecP384R1Point : global::Org.BouncyCastle.Math.EC.AbstractFpPoint
	{
		// Token: 0x060019F6 RID: 6646 RVA: 0x0007AD02 File Offset: 0x00078F02
		public SecP384R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x060019F7 RID: 6647 RVA: 0x0007AD0E File Offset: 0x00078F0E
		public SecP384R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x060019F8 RID: 6648 RVA: 0x0007AD30 File Offset: 0x00078F30
		internal SecP384R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x060019F9 RID: 6649 RVA: 0x0007AD3F File Offset: 0x00078F3F
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x060019FA RID: 6650 RVA: 0x0007AD54 File Offset: 0x00078F54
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
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement X2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)b.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Y2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)b.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Z2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)b.RawZCoords[0];
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat.Create(24);
			uint[] tt2 = global::Org.BouncyCastle.Math.Raw.Nat.Create(24);
			uint[] t3 = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			uint[] t4 = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
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
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(Z.x, S2);
				U2 = tt2;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(S2, X2.x, U2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(S2, Z.x, S2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(S2, Y2.x, S2);
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
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(Z2.x, S3);
				U3 = tt;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(S3, X.x, U3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(S3, Z2.x, S3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(S3, Y.x, S3);
			}
			uint[] H = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(U3, U2, H);
			uint[] R = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(S3, S2, R);
			if (!global::Org.BouncyCastle.Math.Raw.Nat.IsZero(12, H))
			{
				uint[] HSquared = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(H, HSquared);
				uint[] G = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(HSquared, H, G);
				uint[] V = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(HSquared, U3, V);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Negate(G, G);
				global::Org.BouncyCastle.Math.Raw.Nat384.Mul(S3, G, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.AddBothTo(12, V, V, G), G);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement X3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(t4);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(R, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(X3.x, G, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Y3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(G);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(V, X3.x, Y3.x);
				global::Org.BouncyCastle.Math.Raw.Nat384.Mul(Y3.x, R, tt2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.AddExt(tt, tt2, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce(tt, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Z3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(H);
				if (!Z1IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(Z3.x, Z.x, Z3.x);
				}
				if (!Z2IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(Z3.x, Z2.x, Z3.x);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z3
				};
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(curve, X3, Y3, zs, base.IsCompressed);
			}
			if (global::Org.BouncyCastle.Math.Raw.Nat.IsZero(12, R))
			{
				return this.Twice();
			}
			return curve.Infinity;
		}

		// Token: 0x060019FB RID: 6651 RVA: 0x0007B040 File Offset: 0x00079240
		public override global::Org.BouncyCastle.Math.EC.ECPoint Twice()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)base.RawYCoord;
			if (Y.IsZero)
			{
				return curve.Infinity;
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)base.RawZCoords[0];
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			uint[] Y1Squared = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(Y.x, Y1Squared);
			uint[] T = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(Y1Squared, T);
			bool isOne = Z.IsOne;
			uint[] Z1Squared = Z.x;
			if (!isOne)
			{
				Z1Squared = t2;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(Z.x, Z1Squared);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(X.x, Z1Squared, t);
			uint[] M = t2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Add(X.x, Z1Squared, M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(M, t, M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.AddBothTo(12, M, M, M), M);
			uint[] S = Y1Squared;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(Y1Squared, X.x, S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(12, S, 2, 0U), S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(12, T, 3, 0U, t), t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement X2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(T);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Square(M, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Y2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(S, X2.x, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(Y2.x, M, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Subtract(Y2.x, t, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement Z2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Twice(Y.x, Z2.x);
			if (!isOne)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Multiply(Z2.x, Z.x, Z2.x);
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(curve, X2, Y2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x060019FC RID: 6652 RVA: 0x0007B244 File Offset: 0x00079444
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

		// Token: 0x060019FD RID: 6653 RVA: 0x0007B290 File Offset: 0x00079490
		public override global::Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
		{
			if (base.IsInfinity || base.RawYCoord.IsZero)
			{
				return this;
			}
			return this.Twice().Add(this);
		}

		// Token: 0x060019FE RID: 6654 RVA: 0x0007B2B5 File Offset: 0x000794B5
		public override global::Org.BouncyCastle.Math.EC.ECPoint Negate()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(this.Curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
		}
	}
}
