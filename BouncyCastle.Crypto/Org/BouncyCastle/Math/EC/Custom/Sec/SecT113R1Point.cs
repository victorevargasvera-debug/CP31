using System;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000274 RID: 628
	internal class SecT113R1Point : global::Org.BouncyCastle.Math.EC.AbstractF2mPoint
	{
		// Token: 0x06001A87 RID: 6791 RVA: 0x0007CB50 File Offset: 0x0007AD50
		public SecT113R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x06001A88 RID: 6792 RVA: 0x0007CB5C File Offset: 0x0007AD5C
		public SecT113R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x06001A89 RID: 6793 RVA: 0x0007CB7E File Offset: 0x0007AD7E
		internal SecT113R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001A8A RID: 6794 RVA: 0x0007CB8D File Offset: 0x0007AD8D
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x17000333 RID: 819
		// (get) Token: 0x06001A8B RID: 6795 RVA: 0x0007CBA4 File Offset: 0x0007ADA4
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

		// Token: 0x17000334 RID: 820
		// (get) Token: 0x06001A8C RID: 6796 RVA: 0x0007CBFC File Offset: 0x0007ADFC
		protected internal override bool CompressionYTilde
		{
			get
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				return !X.IsZero && base.RawYCoord.TestBitZero() != X.TestBitZero();
			}
		}

		// Token: 0x06001A8D RID: 6797 RVA: 0x0007CC30 File Offset: 0x0007AE30
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
						X3 = L3.Square().Add(L3).Add(X).Add(curve.A);
						if (X3.IsZero)
						{
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve, X3, curve.B.Sqrt(), base.IsCompressed);
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
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve, X3, curve.B.Sqrt(), base.IsCompressed);
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
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve, X3, L4, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
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

		// Token: 0x06001A8E RID: 6798 RVA: 0x0007CE98 File Offset: 0x0007B098
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
			global::Org.BouncyCastle.Math.EC.ECFieldElement a = curve.A;
			global::Org.BouncyCastle.Math.EC.ECFieldElement aZ1Sq = Z1IsOne ? a : a.Multiply(Z1Sq);
			global::Org.BouncyCastle.Math.EC.ECFieldElement T = L.Square().Add(L1Z).Add(aZ1Sq);
			if (T.IsZero)
			{
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve, T, curve.B.Sqrt(), base.IsCompressed);
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = T.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = Z1IsOne ? T : T.Multiply(Z1Sq);
			global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = (Z1IsOne ? X : X.Multiply(Z)).SquarePlusProduct(T, L1Z).Add(X2).Add(Z2);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve, X2, L2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x06001A8F RID: 6799 RVA: 0x0007CFB8 File Offset: 0x0007B1B8
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
			global::Org.BouncyCastle.Math.EC.ECFieldElement T = curve.A.Multiply(Z1Sq).Add(L1Sq).Add(L1Z);
			global::Org.BouncyCastle.Math.EC.ECFieldElement L2plus = L2.AddOne();
			global::Org.BouncyCastle.Math.EC.ECFieldElement A = curve.A.Add(L2plus).Multiply(Z1Sq).Add(L1Sq).MultiplyPlusProduct(T, X1Sq, Z1Sq);
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
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve, A, curve.B.Sqrt(), base.IsCompressed);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = A.Square().Multiply(X2Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = A.Multiply(B).Multiply(Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = A.Add(B).Square().MultiplyPlusProduct(T, L2plus, Z4);
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(curve, X3, L3, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z4
				}, base.IsCompressed);
			}
		}

		// Token: 0x06001A90 RID: 6800 RVA: 0x0007D160 File Offset: 0x0007B360
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(this.Curve, X, L.Add(Z), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z
			}, base.IsCompressed);
		}
	}
}
