using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
	// Token: 0x020002AE RID: 686
	internal class Curve25519Point : global::Org.BouncyCastle.Math.EC.AbstractFpPoint
	{
		// Token: 0x06001EA1 RID: 7841 RVA: 0x0008D980 File Offset: 0x0008BB80
		public Curve25519Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x06001EA2 RID: 7842 RVA: 0x0008D98C File Offset: 0x0008BB8C
		public Curve25519Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x06001EA3 RID: 7843 RVA: 0x0008D9AE File Offset: 0x0008BBAE
		internal Curve25519Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001EA4 RID: 7844 RVA: 0x0008D9BD File Offset: 0x0008BBBD
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x06001EA5 RID: 7845 RVA: 0x0008D9D1 File Offset: 0x0008BBD1
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement GetZCoord(int index)
		{
			if (index == 1)
			{
				return this.GetJacobianModifiedW();
			}
			return base.GetZCoord(index);
		}

		// Token: 0x06001EA6 RID: 7846 RVA: 0x0008D9E8 File Offset: 0x0008BBE8
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
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement X2 = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)b.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Y2 = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)b.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Z2 = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)b.RawZCoords[0];
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
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(Z.x, S2);
				U2 = t2;
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(S2, X2.x, U2);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(S2, Z.x, S2);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(S2, Y2.x, S2);
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
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(Z2.x, S3);
				U3 = tt;
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(S3, X.x, U3);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(S3, Z2.x, S3);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(S3, Y.x, S3);
			}
			uint[] H = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(U3, U2, H);
			uint[] R = t2;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(S3, S2, R);
			if (!global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(H))
			{
				uint[] HSquared = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(H, HSquared);
				uint[] G = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(HSquared, H, G);
				uint[] V = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(HSquared, U3, V);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Negate(G, G);
				global::Org.BouncyCastle.Math.Raw.Nat256.Mul(S3, G, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce27(global::Org.BouncyCastle.Math.Raw.Nat256.AddBothTo(V, V, G), G);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement X3 = new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(t4);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(R, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(X3.x, G, X3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Y3 = new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(G);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(V, X3.x, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.MultiplyAddToExt(Y3.x, R, tt);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce(tt, Y3.x);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Z3 = new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(H);
				if (!Z1IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(Z3.x, Z.x, Z3.x);
				}
				if (!Z2IsOne)
				{
					global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(Z3.x, Z2.x, Z3.x);
				}
				uint[] Z3Squared = (Z1IsOne && Z2IsOne) ? HSquared : null;
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement W3 = this.CalculateJacobianModifiedW(Z3, Z3Squared);
				global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z3,
					W3
				};
				return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(curve, X3, Y3, zs, base.IsCompressed);
			}
			if (global::Org.BouncyCastle.Math.Raw.Nat256.IsZero(R))
			{
				return this.Twice();
			}
			return curve.Infinity;
		}

		// Token: 0x06001EA7 RID: 7847 RVA: 0x0008DCD0 File Offset: 0x0008BED0
		public override global::Org.BouncyCastle.Math.EC.ECPoint Twice()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			if (base.RawYCoord.IsZero)
			{
				return curve.Infinity;
			}
			return this.TwiceJacobianModified(true);
		}

		// Token: 0x06001EA8 RID: 7848 RVA: 0x0008DD0C File Offset: 0x0008BF0C
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
			return this.TwiceJacobianModified(false).Add(b);
		}

		// Token: 0x06001EA9 RID: 7849 RVA: 0x0008DD59 File Offset: 0x0008BF59
		public override global::Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
		{
			if (base.IsInfinity || base.RawYCoord.IsZero)
			{
				return this;
			}
			return this.TwiceJacobianModified(false).Add(this);
		}

		// Token: 0x06001EAA RID: 7850 RVA: 0x0008DD7F File Offset: 0x0008BF7F
		public override global::Org.BouncyCastle.Math.EC.ECPoint Negate()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(this.Curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
		}

		// Token: 0x06001EAB RID: 7851 RVA: 0x0008DDB4 File Offset: 0x0008BFB4
		protected virtual global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement CalculateJacobianModifiedW(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Z, uint[] ZSquared)
		{
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement a4 = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)this.Curve.A;
			if (Z.IsOne)
			{
				return a4;
			}
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement W = new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement();
			if (ZSquared == null)
			{
				ZSquared = W.x;
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(Z.x, ZSquared);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(ZSquared, W.x);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(W.x, a4.x, W.x);
			return W;
		}

		// Token: 0x06001EAC RID: 7852 RVA: 0x0008DE20 File Offset: 0x0008C020
		protected virtual global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement GetJacobianModifiedW()
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement[] ZZ = base.RawZCoords;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement W = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)ZZ[1];
			if (W == null)
			{
				W = (ZZ[1] = this.CalculateJacobianModifiedW((global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)ZZ[0], null));
			}
			return W;
		}

		// Token: 0x06001EAD RID: 7853 RVA: 0x0008DE58 File Offset: 0x0008C058
		protected virtual global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point TwiceJacobianModified(bool calculateW)
		{
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Y = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement W = this.GetJacobianModifiedW();
			uint[] M = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(X.x, M);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Reduce27(global::Org.BouncyCastle.Math.Raw.Nat256.AddBothTo(M, M, M) + global::Org.BouncyCastle.Math.Raw.Nat256.AddTo(W.x, M), M);
			uint[] _2Y = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Twice(Y.x, _2Y);
			uint[] _2Y1Squared = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(_2Y, Y.x, _2Y1Squared);
			uint[] S = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(_2Y1Squared, X.x, S);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Twice(S, S);
			uint[] _8T = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(_2Y1Squared, _8T);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Twice(_8T, _8T);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement X2 = new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(_2Y1Squared);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Square(M, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(X2.x, S, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Y2 = new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(S);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(S, X2.x, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(Y2.x, M, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Subtract(Y2.x, _8T, Y2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement Z2 = new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(_2Y);
			if (!global::Org.BouncyCastle.Math.Raw.Nat256.IsOne(Z.x))
			{
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(Z2.x, Z.x, Z2.x);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement W2 = null;
			if (calculateW)
			{
				W2 = new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(_8T);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Multiply(W2.x, W.x, W2.x);
				global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Twice(W2.x, W2.x);
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(this.Curve, X2, Y2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2,
				W2
			}, base.IsCompressed);
		}
	}
}
