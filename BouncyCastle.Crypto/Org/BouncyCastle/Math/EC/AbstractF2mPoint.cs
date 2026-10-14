using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000215 RID: 533
	public abstract class AbstractF2mPoint : global::Org.BouncyCastle.Math.EC.ECPointBase
	{
		// Token: 0x0600155E RID: 5470 RVA: 0x00063F60 File Offset: 0x00062160
		protected AbstractF2mPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
		}

		// Token: 0x0600155F RID: 5471 RVA: 0x00063F6D File Offset: 0x0006216D
		protected AbstractF2mPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001560 RID: 5472 RVA: 0x00063F7C File Offset: 0x0006217C
		protected override bool SatisfiesCurveEquation()
		{
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement A = curve.A;
			global::Org.BouncyCastle.Math.EC.ECFieldElement B = curve.B;
			int coord = curve.CoordinateSystem;
			global::Org.BouncyCastle.Math.EC.ECFieldElement lhs;
			global::Org.BouncyCastle.Math.EC.ECFieldElement rhs;
			if (coord == 6)
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				bool ZIsOne = Z.IsOne;
				if (X.IsZero)
				{
					lhs = Y.Square();
					rhs = B;
					if (!ZIsOne)
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = Z.Square();
						rhs = rhs.Multiply(Z2);
					}
				}
				else
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement L = Y;
					global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = X.Square();
					if (ZIsOne)
					{
						lhs = L.Square().Add(L).Add(A);
						rhs = X2.Square().Add(B);
					}
					else
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement Z3 = Z.Square();
						global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = Z3.Square();
						lhs = L.Add(Z).MultiplyPlusProduct(L, A, Z3);
						rhs = X2.SquarePlusProduct(B, Z4);
					}
					lhs = lhs.Multiply(X2);
				}
			}
			else
			{
				lhs = Y.Add(X).Multiply(Y);
				if (coord != 0)
				{
					if (coord != 1)
					{
						throw new global::System.InvalidOperationException("unsupported coordinate system");
					}
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z5 = base.RawZCoords[0];
					if (!Z5.IsOne)
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement Z6 = Z5.Square();
						global::Org.BouncyCastle.Math.EC.ECFieldElement Z7 = Z5.Multiply(Z6);
						lhs = lhs.Multiply(Z5);
						A = A.Multiply(Z5);
						B = B.Multiply(Z7);
					}
				}
				rhs = X.Add(A).Multiply(X.Square()).Add(B);
			}
			return lhs.Equals(rhs);
		}

		// Token: 0x06001561 RID: 5473 RVA: 0x00064108 File Offset: 0x00062308
		protected override bool SatisfiesOrder()
		{
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.BigInteger cofactor = curve.Cofactor;
			if (global::Org.BouncyCastle.Math.BigInteger.Two.Equals(cofactor))
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = this.Normalize().AffineXCoord;
				return ((global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement)X).Trace() != 0;
			}
			if (!global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L).Equals(cofactor))
			{
				return base.SatisfiesOrder();
			}
			global::Org.BouncyCastle.Math.EC.ECPoint N = this.Normalize();
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = N.AffineXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement L = ((global::Org.BouncyCastle.Math.EC.AbstractF2mCurve)curve).SolveQuadraticEquation(X2.Add(curve.A));
			if (L == null)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y = N.AffineYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement T = X2.Multiply(L).Add(Y);
			return ((global::Org.BouncyCastle.Math.EC.AbstractF2mFieldElement)T).Trace() == 0;
		}

		// Token: 0x06001562 RID: 5474 RVA: 0x000641BC File Offset: 0x000623BC
		public override global::Org.BouncyCastle.Math.EC.ECPoint ScaleX(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			if (base.IsInfinity)
			{
				return this;
			}
			int curveCoordinateSystem = this.CurveCoordinateSystem;
			if (curveCoordinateSystem == 5)
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement rawYCoord = base.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = X.Multiply(scale);
				global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = rawYCoord.Add(X).Divide(scale).Add(X2);
				return this.Curve.CreateRawPoint(X, L2, base.RawZCoords, base.IsCompressed);
			}
			if (curveCoordinateSystem != 6)
			{
				return base.ScaleX(scale);
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement rawYCoord2 = base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.ECFieldElement X4 = X3.Multiply(scale.Square());
			global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = rawYCoord2.Add(X3).Add(X4);
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = Z.Multiply(scale);
			return this.Curve.CreateRawPoint(X3, L3, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x06001563 RID: 5475 RVA: 0x00064292 File Offset: 0x00062492
		public override global::Org.BouncyCastle.Math.EC.ECPoint ScaleXNegateY(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			return this.ScaleX(scale);
		}

		// Token: 0x06001564 RID: 5476 RVA: 0x0006429C File Offset: 0x0006249C
		public override global::Org.BouncyCastle.Math.EC.ECPoint ScaleY(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			if (base.IsInfinity)
			{
				return this;
			}
			int curveCoordinateSystem = this.CurveCoordinateSystem;
			if (curveCoordinateSystem - 5 <= 1)
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = base.RawYCoord.Add(X).Multiply(scale).Add(X);
				return this.Curve.CreateRawPoint(X, L2, base.RawZCoords, base.IsCompressed);
			}
			return base.ScaleY(scale);
		}

		// Token: 0x06001565 RID: 5477 RVA: 0x00064301 File Offset: 0x00062501
		public override global::Org.BouncyCastle.Math.EC.ECPoint ScaleYNegateX(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			return this.ScaleY(scale);
		}

		// Token: 0x06001566 RID: 5478 RVA: 0x0006430A File Offset: 0x0006250A
		public override global::Org.BouncyCastle.Math.EC.ECPoint Subtract(global::Org.BouncyCastle.Math.EC.ECPoint b)
		{
			if (b.IsInfinity)
			{
				return this;
			}
			return this.Add(b.Negate());
		}

		// Token: 0x06001567 RID: 5479 RVA: 0x00064324 File Offset: 0x00062524
		public virtual global::Org.BouncyCastle.Math.EC.AbstractF2mPoint Tau()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			int coord = curve.CoordinateSystem;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			switch (coord)
			{
			case 0:
			case 5:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
				return (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)curve.CreateRawPoint(X.Square(), Y.Square(), base.IsCompressed);
			}
			case 1:
			case 6:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = base.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				return (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)curve.CreateRawPoint(X.Square(), Y2.Square(), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z.Square()
				}, base.IsCompressed);
			}
			}
			throw new global::System.InvalidOperationException("unsupported coordinate system");
		}

		// Token: 0x06001568 RID: 5480 RVA: 0x000643E4 File Offset: 0x000625E4
		public virtual global::Org.BouncyCastle.Math.EC.AbstractF2mPoint TauPow(int pow)
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			int coord = curve.CoordinateSystem;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			switch (coord)
			{
			case 0:
			case 5:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
				return (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)curve.CreateRawPoint(X.SquarePow(pow), Y.SquarePow(pow), base.IsCompressed);
			}
			case 1:
			case 6:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = base.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				return (global::Org.BouncyCastle.Math.EC.AbstractF2mPoint)curve.CreateRawPoint(X.SquarePow(pow), Y2.SquarePow(pow), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z.SquarePow(pow)
				}, base.IsCompressed);
			}
			}
			throw new global::System.InvalidOperationException("unsupported coordinate system");
		}
	}
}
