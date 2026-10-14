using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000270 RID: 624
	internal class SecP521R1Point : global::Org.BouncyCastle.Math.EC.AbstractFpPoint
	{
		// Token: 0x06001A37 RID: 6711 RVA: 0x0007BBBA File Offset: 0x00079DBA
		public SecP521R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x06001A38 RID: 6712 RVA: 0x0007BBC6 File Offset: 0x00079DC6
		public SecP521R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x06001A39 RID: 6713 RVA: 0x0007BBE8 File Offset: 0x00079DE8
		internal SecP521R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001A3A RID: 6714 RVA: 0x0007BBF7 File Offset: 0x00079DF7
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x06001A3B RID: 6715 RVA: 0x0007BC0C File Offset: 0x00079E0C
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
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement X2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)b.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Y2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)b.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Z2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)b.RawZCoords[0];
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			uint[] t3 = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			uint[] t4 = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
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
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(Z.x, S2);
				U2 = t2;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(S2, X2.x, U2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(S2, Z.x, S2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(S2, Y2.x, S2);
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
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(Z2.x, S3);
				U3 = t;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(S3, X.x, U3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(S3, Z2.x, S3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(S3, Y.x, S3);
			}
			uint[] H = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(U3, U2, H);
			uint[] R = t2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(S3, S2, R);
			if (!global::Org.BouncyCastle.Math.Raw.Nat.IsZero(17, H))
			{
				uint[] HSquared = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(H, HSquared);
				uint[] G = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(HSquared, H, G);
				uint[] V = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(HSquared, U3, V);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(S3, G, t);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement X3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(t4);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(R, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Add(X3.x, G, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(X3.x, V, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(X3.x, V, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Y3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(G);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(V, X3.x, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(Y3.x, R, t2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(t2, t, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Z3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(H);
				if (!Z1IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(Z3.x, Z.x, Z3.x);
				}
				if (!Z2IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(Z3.x, Z2.x, Z3.x);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z3
				};
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Point(curve, X3, Y3, zs, base.IsCompressed);
			}
			if (global::Org.BouncyCastle.Math.Raw.Nat.IsZero(17, R))
			{
				return this.Twice();
			}
			return curve.Infinity;
		}

		// Token: 0x06001A3C RID: 6716 RVA: 0x0007BEF4 File Offset: 0x0007A0F4
		public override global::Org.BouncyCastle.Math.EC.ECPoint Twice()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)base.RawYCoord;
			if (Y.IsZero)
			{
				return curve.Infinity;
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)base.RawZCoords[0];
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			uint[] Y1Squared = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(Y.x, Y1Squared);
			uint[] T = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(Y1Squared, T);
			bool isOne = Z.IsOne;
			uint[] Z1Squared = Z.x;
			if (!isOne)
			{
				Z1Squared = t2;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(Z.x, Z1Squared);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(X.x, Z1Squared, t);
			uint[] M = t2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Add(X.x, Z1Squared, M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(M, t, M);
			global::Org.BouncyCastle.Math.Raw.Nat.AddBothTo(17, M, M, M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce23(M);
			uint[] S = Y1Squared;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(Y1Squared, X.x, S);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(17, S, 2, 0U);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce23(S);
			global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(17, T, 3, 0U, t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Reduce23(t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement X2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(T);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Square(M, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Y2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(S, X2.x, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(Y2.x, M, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Subtract(Y2.x, t, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement Z2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Twice(Y.x, Z2.x);
			if (!isOne)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Multiply(Z2.x, Z.x, Z2.x);
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Point(curve, X2, Y2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x06001A3D RID: 6717 RVA: 0x0007C0FC File Offset: 0x0007A2FC
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

		// Token: 0x06001A3E RID: 6718 RVA: 0x0007C148 File Offset: 0x0007A348
		public override global::Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
		{
			if (base.IsInfinity || base.RawYCoord.IsZero)
			{
				return this;
			}
			return this.Twice().Add(this);
		}

		// Token: 0x06001A3F RID: 6719 RVA: 0x0007C16D File Offset: 0x0007A36D
		public override global::Org.BouncyCastle.Math.EC.ECPoint Negate()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Point(this.Curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
		}
	}
}
