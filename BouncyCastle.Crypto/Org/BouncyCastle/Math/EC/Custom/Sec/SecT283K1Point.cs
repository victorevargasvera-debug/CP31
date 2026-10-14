using System;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000298 RID: 664
	internal class SecT283K1Point : global::Org.BouncyCastle.Math.EC.AbstractF2mPoint
	{
		// Token: 0x06001D1A RID: 7450 RVA: 0x00086FFC File Offset: 0x000851FC
		public SecT283K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x06001D1B RID: 7451 RVA: 0x00087008 File Offset: 0x00085208
		public SecT283K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x06001D1C RID: 7452 RVA: 0x0008702A File Offset: 0x0008522A
		internal SecT283K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001D1D RID: 7453 RVA: 0x00087039 File Offset: 0x00085239
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x170003E7 RID: 999
		// (get) Token: 0x06001D1E RID: 7454 RVA: 0x00087050 File Offset: 0x00085250
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

		// Token: 0x170003E8 RID: 1000
		// (get) Token: 0x06001D1F RID: 7455 RVA: 0x000870A8 File Offset: 0x000852A8
		protected internal override bool CompressionYTilde
		{
			get
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				return !X.IsZero && base.RawYCoord.TestBitZero() != X.TestBitZero();
			}
		}

		// Token: 0x06001D20 RID: 7456 RVA: 0x000870DC File Offset: 0x000852DC
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
						X3 = L3.Square().Add(L3).Add(X);
						if (X3.IsZero)
						{
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(curve, X3, curve.B, base.IsCompressed);
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
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(curve, X3, curve.B, base.IsCompressed);
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
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(curve, X3, L4, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
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

		// Token: 0x06001D21 RID: 7457 RVA: 0x00087330 File Offset: 0x00085530
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
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z1Sq = Z1IsOne ? Z : Z.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement T;
			if (Z1IsOne)
			{
				T = L.Square().Add(L);
			}
			else
			{
				T = L.Add(Z).Multiply(L);
			}
			if (T.IsZero)
			{
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(curve, T, curve.B, base.IsCompressed);
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = T.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = Z1IsOne ? T : T.Multiply(Z1Sq);
			global::Org.BouncyCastle.Math.EC.ECFieldElement t = L.Add(X).Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement t2 = Z1IsOne ? Z : Z1Sq.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = t.Add(T).Add(Z1Sq).Multiply(t).Add(t2).Add(X2).Add(Z2);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(curve, X2, L2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x06001D22 RID: 7458 RVA: 0x00087450 File Offset: 0x00085650
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
			global::Org.BouncyCastle.Math.EC.ECFieldElement T = L1Sq.Add(L1Z);
			global::Org.BouncyCastle.Math.EC.ECFieldElement L2plus = L2.AddOne();
			global::Org.BouncyCastle.Math.EC.ECFieldElement A = L2plus.Multiply(Z1Sq).Add(L1Sq).MultiplyPlusProduct(T, X1Sq, Z1Sq);
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
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(curve, A, curve.B, base.IsCompressed);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = A.Square().Multiply(X2Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = A.Multiply(B).Multiply(Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = A.Add(B).Square().MultiplyPlusProduct(T, L2plus, Z4);
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(curve, X3, L3, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z4
				}, base.IsCompressed);
			}
		}

		// Token: 0x06001D23 RID: 7459 RVA: 0x000875D8 File Offset: 0x000857D8
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(this.Curve, X, L.Add(Z), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z
			}, base.IsCompressed);
		}
	}
}
