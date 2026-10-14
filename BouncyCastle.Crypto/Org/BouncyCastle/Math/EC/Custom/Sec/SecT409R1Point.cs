using System;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020002A0 RID: 672
	internal class SecT409R1Point : global::Org.BouncyCastle.Math.EC.AbstractF2mPoint
	{
		// Token: 0x06001DA2 RID: 7586 RVA: 0x00089564 File Offset: 0x00087764
		public SecT409R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x06001DA3 RID: 7587 RVA: 0x00089570 File Offset: 0x00087770
		public SecT409R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x06001DA4 RID: 7588 RVA: 0x00089592 File Offset: 0x00087792
		internal SecT409R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001DA5 RID: 7589 RVA: 0x000895A1 File Offset: 0x000877A1
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x1700040F RID: 1039
		// (get) Token: 0x06001DA6 RID: 7590 RVA: 0x000895B8 File Offset: 0x000877B8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement YCoord
		{
			get
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement L = base.RawYCoord;
				if (base.IsInfinity || X.IsZero)
				{
					return L;
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y = L.Add(X).Multiply(X);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				if (!Z.IsOne)
				{
					Y = Y.Divide(Z);
				}
				return Y;
			}
		}

		// Token: 0x17000410 RID: 1040
		// (get) Token: 0x06001DA7 RID: 7591 RVA: 0x00089610 File Offset: 0x00087810
		protected internal override bool CompressionYTilde
		{
			get
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				return !X.IsZero && base.RawYCoord.TestBitZero() != X.TestBitZero();
			}
		}

		// Token: 0x06001DA8 RID: 7592 RVA: 0x00089644 File Offset: 0x00087844
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
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = b.RawXCoord;
			if (X.IsZero)
			{
				if (X2.IsZero)
				{
					return curve.Infinity;
				}
				return b.Add(this);
			}
			else
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement L = base.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = b.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = b.RawZCoords[0];
				bool Z1IsOne = Z.IsOne;
				global::Org.BouncyCastle.Math.EC.ECFieldElement U2 = X2;
				global::Org.BouncyCastle.Math.EC.ECFieldElement S2 = L2;
				if (!Z1IsOne)
				{
					U2 = U2.Multiply(Z);
					S2 = S2.Multiply(Z);
				}
				bool Z2IsOne = Z2.IsOne;
				global::Org.BouncyCastle.Math.EC.ECFieldElement U3 = X;
				global::Org.BouncyCastle.Math.EC.ECFieldElement S3 = L;
				if (!Z2IsOne)
				{
					U3 = U3.Multiply(Z2);
					S3 = S3.Multiply(Z2);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement A = S3.Add(S2);
				global::Org.BouncyCastle.Math.EC.ECFieldElement B = U3.Add(U2);
				if (!B.IsZero)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement X3;
					global::Org.BouncyCastle.Math.EC.ECFieldElement L4;
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z3;
					if (X2.IsZero)
					{
						global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = this.Normalize();
						X = ecpoint.XCoord;
						global::Org.BouncyCastle.Math.EC.ECFieldElement Y = ecpoint.YCoord;
						global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = L2;
						global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = Y.Add(Y2).Divide(X);
						X3 = L3.Square().Add(L3).Add(X).AddOne();
						if (X3.IsZero)
						{
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(curve, X3, curve.B.Sqrt(), base.IsCompressed);
						}
						L4 = L3.Multiply(X.Add(X3)).Add(X3).Add(Y).Divide(X3).Add(X3);
						Z3 = curve.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
					}
					else
					{
						B = B.Square();
						global::Org.BouncyCastle.Math.EC.ECFieldElement AU = A.Multiply(U3);
						global::Org.BouncyCastle.Math.EC.ECFieldElement AU2 = A.Multiply(U2);
						X3 = AU.Multiply(AU2);
						if (X3.IsZero)
						{
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(curve, X3, curve.B.Sqrt(), base.IsCompressed);
						}
						global::Org.BouncyCastle.Math.EC.ECFieldElement ABZ2 = A.Multiply(B);
						if (!Z2IsOne)
						{
							ABZ2 = ABZ2.Multiply(Z2);
						}
						L4 = AU2.Add(B).SquarePlusProduct(ABZ2, L.Add(Z));
						Z3 = ABZ2;
						if (!Z1IsOne)
						{
							Z3 = Z3.Multiply(Z);
						}
					}
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(curve, X3, L4, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
					{
						Z3
					}, base.IsCompressed);
				}
				if (A.IsZero)
				{
					return this.Twice();
				}
				return curve.Infinity;
			}
		}

		// Token: 0x06001DA9 RID: 7593 RVA: 0x000898A8 File Offset: 0x00087AA8
		public override global::Org.BouncyCastle.Math.EC.ECPoint Twice()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			if (X.IsZero)
			{
				return curve.Infinity;
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement L = base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
			bool Z1IsOne = Z.IsOne;
			global::Org.BouncyCastle.Math.EC.ECFieldElement L1Z = Z1IsOne ? L : L.Multiply(Z);
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z1Sq = Z1IsOne ? Z : Z.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement T = L.Square().Add(L1Z).Add(Z1Sq);
			if (T.IsZero)
			{
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(curve, T, curve.B.Sqrt(), base.IsCompressed);
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = T.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = Z1IsOne ? T : T.Multiply(Z1Sq);
			global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = (Z1IsOne ? X : X.Multiply(Z)).SquarePlusProduct(T, L1Z).Add(X2).Add(Z2);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(curve, X2, L2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x06001DAA RID: 7594 RVA: 0x000899AC File Offset: 0x00087BAC
		public override global::Org.BouncyCastle.Math.EC.ECPoint TwicePlus(global::Org.BouncyCastle.Math.EC.ECPoint b)
		{
			if (base.IsInfinity)
			{
				return b;
			}
			if (b.IsInfinity)
			{
				return this.Twice();
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			if (X.IsZero)
			{
				return b;
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = b.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = b.RawZCoords[0];
			if (X2.IsZero || !Z2.IsOne)
			{
				return this.Twice().Add(b);
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement rawYCoord = base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z3 = base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = b.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X1Sq = X.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement L1Sq = rawYCoord.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z1Sq = Z3.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement L1Z = rawYCoord.Multiply(Z3);
			global::Org.BouncyCastle.Math.EC.ECFieldElement T = Z1Sq.Add(L1Sq).Add(L1Z);
			global::Org.BouncyCastle.Math.EC.ECFieldElement A = L2.Multiply(Z1Sq).Add(L1Sq).MultiplyPlusProduct(T, X1Sq, Z1Sq);
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2Z1Sq = X2.Multiply(Z1Sq);
			global::Org.BouncyCastle.Math.EC.ECFieldElement B = X2Z1Sq.Add(T).Square();
			if (B.IsZero)
			{
				if (A.IsZero)
				{
					return b.Twice();
				}
				return curve.Infinity;
			}
			else
			{
				if (A.IsZero)
				{
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(curve, A, curve.B.Sqrt(), base.IsCompressed);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = A.Square().Multiply(X2Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = A.Multiply(B).Multiply(Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = A.Add(B).Square().MultiplyPlusProduct(T, L2.AddOne(), Z4);
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(curve, X3, L3, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z4
				}, base.IsCompressed);
			}
		}

		// Token: 0x06001DAB RID: 7595 RVA: 0x00089B3C File Offset: 0x00087D3C
		public override global::Org.BouncyCastle.Math.EC.ECPoint Negate()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			if (X.IsZero)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement L = base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(this.Curve, X, L.Add(Z), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z
			}, base.IsCompressed);
		}
	}
}
