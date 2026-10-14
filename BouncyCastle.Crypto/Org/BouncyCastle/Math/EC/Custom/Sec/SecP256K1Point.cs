using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000264 RID: 612
	internal class SecP256K1Point : global::Org.BouncyCastle.Math.EC.AbstractFpPoint
	{
		// Token: 0x0600196F RID: 6511 RVA: 0x000789E9 File Offset: 0x00076BE9
		public SecP256K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x06001970 RID: 6512 RVA: 0x000789F5 File Offset: 0x00076BF5
		public SecP256K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x06001971 RID: 6513 RVA: 0x00078A17 File Offset: 0x00076C17
		internal SecP256K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001972 RID: 6514 RVA: 0x00078A26 File Offset: 0x00076C26
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x06001973 RID: 6515 RVA: 0x00078A3C File Offset: 0x00076C3C
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
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement X2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)b.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Y2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)b.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Z2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)b.RawZCoords[0];
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat256.CreateExt();
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			uint[] t3 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			uint[] t4 = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
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
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(Z.x, S2);
				U2 = t2;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(S2, X2.x, U2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(S2, Z.x, S2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(S2, Y2.x, S2);
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
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(Z2.x, S3);
				U3 = tt;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(S3, X.x, U3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(S3, Z2.x, S3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(S3, Y.x, S3);
			}
			uint[] H = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Subtract(U3, U2, H);
			uint[] R = t2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Subtract(S3, S2, R);
			if (!global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(H))
			{
				uint[] HSquared = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(H, HSquared);
				uint[] G = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(HSquared, H, G);
				uint[] V = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(HSquared, U3, V);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Negate(G, G);
				global::Org.BouncyCastle.Math.Raw.Nat256.Mul(S3, G, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat256.AddBothTo(V, V, G), G);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement X3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(t4);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(R, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Subtract(X3.x, G, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Y3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(G);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Subtract(V, X3.x, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.MultiplyAddToExt(Y3.x, R, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce(tt, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Z3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(H);
				if (!Z1IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(Z3.x, Z.x, Z3.x);
				}
				if (!Z2IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(Z3.x, Z2.x, Z3.x);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z3
				};
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Point(curve, X3, Y3, zs, base.IsCompressed);
			}
			if (global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(R))
			{
				return this.Twice();
			}
			return curve.Infinity;
		}

		// Token: 0x06001974 RID: 6516 RVA: 0x00078D04 File Offset: 0x00076F04
		public override global::Org.BouncyCastle.Math.EC.ECPoint Twice()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)base.RawYCoord;
			if (Y.IsZero)
			{
				return curve.Infinity;
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)base.RawZCoords[0];
			uint[] Y1Squared = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(Y.x, Y1Squared);
			uint[] T = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(Y1Squared, T);
			uint[] M = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(X.x, M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat256.AddBothTo(M, M, M), M);
			uint[] S = Y1Squared;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(Y1Squared, X.x, S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(8, S, 2, 0U), S);
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(8, T, 3, 0U, t), t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement X2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(T);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Square(M, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Y2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Subtract(S, X2.x, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(Y2.x, M, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Subtract(Y2.x, t, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement Z2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Twice(Y.x, Z2.x);
			if (!Z.IsOne)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Multiply(Z2.x, Z.x, Z2.x);
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Point(curve, X2, Y2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x06001975 RID: 6517 RVA: 0x00078EC0 File Offset: 0x000770C0
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

		// Token: 0x06001976 RID: 6518 RVA: 0x00078F0C File Offset: 0x0007710C
		public override global::Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
		{
			if (base.IsInfinity || base.RawYCoord.IsZero)
			{
				return this;
			}
			return this.Twice().Add(this);
		}

		// Token: 0x06001977 RID: 6519 RVA: 0x00078F31 File Offset: 0x00077131
		public override global::Org.BouncyCastle.Math.EC.ECPoint Negate()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Point(this.Curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
		}
	}
}
