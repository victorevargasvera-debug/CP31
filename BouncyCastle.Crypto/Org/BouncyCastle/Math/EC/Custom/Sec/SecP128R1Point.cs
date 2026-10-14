using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000246 RID: 582
	internal class SecP128R1Point : global::Org.BouncyCastle.Math.EC.AbstractFpPoint
	{
		// Token: 0x06001782 RID: 6018 RVA: 0x00071358 File Offset: 0x0006F558
		public SecP128R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x06001783 RID: 6019 RVA: 0x00071364 File Offset: 0x0006F564
		public SecP128R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x06001784 RID: 6020 RVA: 0x00071386 File Offset: 0x0006F586
		internal SecP128R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001785 RID: 6021 RVA: 0x00071395 File Offset: 0x0006F595
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x06001786 RID: 6022 RVA: 0x000713AC File Offset: 0x0006F5AC
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
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement X2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)b.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Y2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)b.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Z2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)b.RawZCoords[0];
			uint[] tt = global::Org.BouncyCastle.Math.Raw.Nat128.CreateExt();
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			uint[] t3 = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			uint[] t4 = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
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
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(Z.x, S2);
				U2 = t2;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(S2, X2.x, U2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(S2, Z.x, S2);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(S2, Y2.x, S2);
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
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(Z2.x, S3);
				U3 = tt;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(S3, X.x, U3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(S3, Z2.x, S3);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(S3, Y.x, S3);
			}
			uint[] H = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(U3, U2, H);
			uint[] R = t2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(S3, S2, R);
			if (!global::Org.BouncyCastle.Math.Raw.Nat128.IsZero(H))
			{
				uint[] HSquared = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(H, HSquared);
				uint[] G = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(HSquared, H, G);
				uint[] V = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(HSquared, U3, V);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Negate(G, G);
				global::Org.BouncyCastle.Math.Raw.Nat128.Mul(S3, G, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat128.AddBothTo(V, V, G), G);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement X3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(t4);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(R, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(X3.x, G, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Y3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(G);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(V, X3.x, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.MultiplyAddToExt(Y3.x, R, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce(tt, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Z3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(H);
				if (!Z1IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(Z3.x, Z.x, Z3.x);
				}
				if (!Z2IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(Z3.x, Z2.x, Z3.x);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z3
				};
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Point(curve, X3, Y3, zs, base.IsCompressed);
			}
			if (global::Org.BouncyCastle.Math.Raw.Nat128.IsZero(R))
			{
				return this.Twice();
			}
			return curve.Infinity;
		}

		// Token: 0x06001787 RID: 6023 RVA: 0x00071674 File Offset: 0x0006F874
		public override global::Org.BouncyCastle.Math.EC.ECPoint Twice()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)base.RawYCoord;
			if (Y.IsZero)
			{
				return curve.Infinity;
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)base.RawZCoords[0];
			uint[] t = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			uint[] t2 = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			uint[] Y1Squared = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(Y.x, Y1Squared);
			uint[] T = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(Y1Squared, T);
			bool isOne = Z.IsOne;
			uint[] Z1Squared = Z.x;
			if (!isOne)
			{
				Z1Squared = t2;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(Z.x, Z1Squared);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(X.x, Z1Squared, t);
			uint[] M = t2;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Add(X.x, Z1Squared, M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(M, t, M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat128.AddBothTo(M, M, M), M);
			uint[] S = Y1Squared;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(Y1Squared, X.x, S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(4, S, 2, 0U), S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Reduce32(global::Org.BouncyCastle.Math.Raw.Nat.ShiftUpBits(4, T, 3, 0U, t), t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement X2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(T);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Square(M, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Y2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(S);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(S, X2.x, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(Y2.x, M, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Subtract(Y2.x, t, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement Z2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(M);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Twice(Y.x, Z2.x);
			if (!isOne)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Multiply(Z2.x, Z.x, Z2.x);
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Point(curve, X2, Y2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x06001788 RID: 6024 RVA: 0x0007186C File Offset: 0x0006FA6C
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

		// Token: 0x06001789 RID: 6025 RVA: 0x000718B8 File Offset: 0x0006FAB8
		public override global::Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
		{
			if (base.IsInfinity || base.RawYCoord.IsZero)
			{
				return this;
			}
			return this.Twice().Add(this);
		}

		// Token: 0x0600178A RID: 6026 RVA: 0x000718DD File Offset: 0x0006FADD
		public override global::Org.BouncyCastle.Math.EC.ECPoint Negate()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Point(this.Curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
		}
	}
}
