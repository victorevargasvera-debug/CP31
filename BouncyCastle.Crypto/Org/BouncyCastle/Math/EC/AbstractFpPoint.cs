using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000213 RID: 531
	public abstract class AbstractFpPoint : global::Org.BouncyCastle.Math.EC.ECPointBase
	{
		// Token: 0x06001546 RID: 5446 RVA: 0x00062DD4 File Offset: 0x00060FD4
		protected AbstractFpPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
		}

		// Token: 0x06001547 RID: 5447 RVA: 0x00062DE1 File Offset: 0x00060FE1
		protected AbstractFpPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x170002A7 RID: 679
		// (get) Token: 0x06001548 RID: 5448 RVA: 0x00062DF0 File Offset: 0x00060FF0
		protected internal override bool CompressionYTilde
		{
			get
			{
				return this.AffineYCoord.TestBitZero();
			}
		}

		// Token: 0x06001549 RID: 5449 RVA: 0x00062E00 File Offset: 0x00061000
		protected override bool SatisfiesCurveEquation()
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement rawYCoord = base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement A = this.Curve.A;
			global::Org.BouncyCastle.Math.EC.ECFieldElement B = this.Curve.B;
			global::Org.BouncyCastle.Math.EC.ECFieldElement lhs = rawYCoord.Square();
			switch (this.CurveCoordinateSystem)
			{
			case 0:
				break;
			case 1:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				if (!Z.IsOne)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = Z.Square();
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z3 = Z.Multiply(Z2);
					lhs = lhs.Multiply(Z);
					A = A.Multiply(Z2);
					B = B.Multiply(Z3);
				}
				break;
			}
			case 2:
			case 3:
			case 4:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = base.RawZCoords[0];
				if (!Z4.IsOne)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement = Z4.Square();
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z5 = ecfieldElement.Square();
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z6 = ecfieldElement.Multiply(Z5);
					A = A.Multiply(Z5);
					B = B.Multiply(Z6);
				}
				break;
			}
			default:
				throw new global::System.InvalidOperationException("unsupported coordinate system");
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement rhs = X.Square().Add(A).Multiply(X).Add(B);
			return lhs.Equals(rhs);
		}

		// Token: 0x0600154A RID: 5450 RVA: 0x00062F10 File Offset: 0x00061110
		public override global::Org.BouncyCastle.Math.EC.ECPoint Subtract(global::Org.BouncyCastle.Math.EC.ECPoint b)
		{
			if (b.IsInfinity)
			{
				return this;
			}
			return this.Add(b.Negate());
		}
	}
}
