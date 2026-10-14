using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000216 RID: 534
	public class F2mPoint : global::Org.BouncyCastle.Math.EC.AbstractF2mPoint
	{
		// Token: 0x06001569 RID: 5481 RVA: 0x000644A9 File Offset: 0x000626A9
		[global::System.Obsolete("Use ECCurve.CreatePoint to construct points")]
		public F2mPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x0600156A RID: 5482 RVA: 0x000644B5 File Offset: 0x000626B5
		[global::System.Obsolete("Per-point compression property will be removed, see GetEncoded(bool)")]
		public F2mPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
			if (x != null)
			{
				global::Org.BouncyCastle.Math.EC.F2mFieldElement.CheckFieldElements(x, y);
				if (curve != null)
				{
					global::Org.BouncyCastle.Math.EC.F2mFieldElement.CheckFieldElements(x, curve.A);
				}
			}
		}

		// Token: 0x0600156B RID: 5483 RVA: 0x000644F0 File Offset: 0x000626F0
		internal F2mPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x0600156C RID: 5484 RVA: 0x000644FF File Offset: 0x000626FF
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.F2mPoint(null, this.AffineXCoord, this.AffineYCoord, false);
		}

		// Token: 0x170002A8 RID: 680
		// (get) Token: 0x0600156D RID: 5485 RVA: 0x00064514 File Offset: 0x00062714
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement YCoord
		{
			get
			{
				int coord = this.CurveCoordinateSystem;
				if (coord - 5 > 1)
				{
					return base.RawYCoord;
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement L = base.RawYCoord;
				if (base.IsInfinity || X.IsZero)
				{
					return L;
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y = L.Add(X).Multiply(X);
				if (6 == coord)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
					if (!Z.IsOne)
					{
						Y = Y.Divide(Z);
					}
				}
				return Y;
			}
		}

		// Token: 0x170002A9 RID: 681
		// (get) Token: 0x0600156E RID: 5486 RVA: 0x00064584 File Offset: 0x00062784
		protected internal override bool CompressionYTilde
		{
			get
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				if (X.IsZero)
				{
					return false;
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
				int curveCoordinateSystem = this.CurveCoordinateSystem;
				if (curveCoordinateSystem - 5 <= 1)
				{
					return Y.TestBitZero() != X.TestBitZero();
				}
				return Y.Divide(X).TestBitZero();
			}
		}

		// Token: 0x0600156F RID: 5487 RVA: 0x000645D4 File Offset: 0x000627D4
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
			int coord = curve.CoordinateSystem;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = b.RawXCoord;
			if (coord != 0)
			{
				if (coord != 1)
				{
					if (coord != 6)
					{
						throw new global::System.InvalidOperationException("unsupported coordinate system");
					}
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
								X = ecpoint.RawXCoord;
								global::Org.BouncyCastle.Math.EC.ECFieldElement Y = ecpoint.YCoord;
								global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = L2;
								global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = Y.Add(Y2).Divide(X);
								X3 = L3.Square().Add(L3).Add(X).Add(curve.A);
								if (X3.IsZero)
								{
									return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X3, curve.B.Sqrt(), base.IsCompressed);
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
									return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X3, curve.B.Sqrt(), base.IsCompressed);
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
							return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X3, L4, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
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
				else
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement Y3 = base.RawYCoord;
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = base.RawZCoords[0];
					global::Org.BouncyCastle.Math.EC.ECFieldElement Y4 = b.RawYCoord;
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z5 = b.RawZCoords[0];
					bool Z1IsOne2 = Z4.IsOne;
					global::Org.BouncyCastle.Math.EC.ECFieldElement U4 = Y4;
					global::Org.BouncyCastle.Math.EC.ECFieldElement V = X2;
					if (!Z1IsOne2)
					{
						U4 = U4.Multiply(Z4);
						V = V.Multiply(Z4);
					}
					bool Z2IsOne2 = Z5.IsOne;
					global::Org.BouncyCastle.Math.EC.ECFieldElement U5 = Y3;
					global::Org.BouncyCastle.Math.EC.ECFieldElement V2 = X;
					if (!Z2IsOne2)
					{
						U5 = U5.Multiply(Z5);
						V2 = V2.Multiply(Z5);
					}
					global::Org.BouncyCastle.Math.EC.ECFieldElement U6 = U4.Add(U5);
					global::Org.BouncyCastle.Math.EC.ECFieldElement V3 = V.Add(V2);
					if (!V3.IsZero)
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement VSq = V3.Square();
						global::Org.BouncyCastle.Math.EC.ECFieldElement VCu = VSq.Multiply(V3);
						global::Org.BouncyCastle.Math.EC.ECFieldElement W = Z1IsOne2 ? Z5 : (Z2IsOne2 ? Z4 : Z4.Multiply(Z5));
						global::Org.BouncyCastle.Math.EC.ECFieldElement uv = U6.Add(V3);
						global::Org.BouncyCastle.Math.EC.ECFieldElement A2 = uv.MultiplyPlusProduct(U6, VSq, curve.A).Multiply(W).Add(VCu);
						global::Org.BouncyCastle.Math.EC.ECFieldElement X4 = V3.Multiply(A2);
						global::Org.BouncyCastle.Math.EC.ECFieldElement VSqZ2 = Z2IsOne2 ? VSq : VSq.Multiply(Z5);
						global::Org.BouncyCastle.Math.EC.ECFieldElement Y5 = U6.MultiplyPlusProduct(X, V3, Y3).MultiplyPlusProduct(VSqZ2, uv, A2);
						global::Org.BouncyCastle.Math.EC.ECFieldElement Z6 = VCu.Multiply(W);
						return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X4, Y5, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
						{
							Z6
						}, base.IsCompressed);
					}
					if (U6.IsZero)
					{
						return this.Twice();
					}
					return curve.Infinity;
				}
			}
			else
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y6 = base.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y7 = b.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement dx = X.Add(X2);
				global::Org.BouncyCastle.Math.EC.ECFieldElement dy = Y6.Add(Y7);
				if (!dx.IsZero)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement L5 = dy.Divide(dx);
					global::Org.BouncyCastle.Math.EC.ECFieldElement X5 = L5.Square().Add(L5).Add(dx).Add(curve.A);
					global::Org.BouncyCastle.Math.EC.ECFieldElement Y8 = L5.Multiply(X.Add(X5)).Add(X5).Add(Y6);
					return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X5, Y8, base.IsCompressed);
				}
				if (dy.IsZero)
				{
					return this.Twice();
				}
				return curve.Infinity;
			}
		}

		// Token: 0x06001570 RID: 5488 RVA: 0x00064A70 File Offset: 0x00062C70
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
			int coord = curve.CoordinateSystem;
			if (coord == 0)
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement L = base.RawYCoord.Divide(X).Add(X);
				global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = L.Square().Add(L).Add(curve.A);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y3 = X.SquarePlusProduct(X2, L.AddOne());
				return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X2, Y3, base.IsCompressed);
			}
			if (coord == 1)
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y4 = base.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				bool isOne = Z.IsOne;
				global::Org.BouncyCastle.Math.EC.ECFieldElement X1Z = isOne ? X : X.Multiply(Z);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y1Z = isOne ? Y4 : Y4.Multiply(Z);
				global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement = X.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement S = ecfieldElement.Add(Y1Z);
				global::Org.BouncyCastle.Math.EC.ECFieldElement V = X1Z;
				global::Org.BouncyCastle.Math.EC.ECFieldElement vSquared = V.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement sv = S.Add(V);
				global::Org.BouncyCastle.Math.EC.ECFieldElement h = sv.MultiplyPlusProduct(S, vSquared, curve.A);
				global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = V.Multiply(h);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y5 = ecfieldElement.Square().MultiplyPlusProduct(V, h, sv);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = V.Multiply(vSquared);
				return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X3, Y5, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z2
				}, base.IsCompressed);
			}
			if (coord != 6)
			{
				throw new global::System.InvalidOperationException("unsupported coordinate system");
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z3 = base.RawZCoords[0];
			bool Z1IsOne = Z3.IsOne;
			global::Org.BouncyCastle.Math.EC.ECFieldElement L1Z = Z1IsOne ? L2 : L2.Multiply(Z3);
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z1Sq = Z1IsOne ? Z3 : Z3.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement a = curve.A;
			global::Org.BouncyCastle.Math.EC.ECFieldElement aZ1Sq = Z1IsOne ? a : a.Multiply(Z1Sq);
			global::Org.BouncyCastle.Math.EC.ECFieldElement T = L2.Square().Add(L1Z).Add(aZ1Sq);
			if (T.IsZero)
			{
				return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, T, curve.B.Sqrt(), base.IsCompressed);
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement X4 = T.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = Z1IsOne ? T : T.Multiply(Z1Sq);
			global::Org.BouncyCastle.Math.EC.ECFieldElement b = curve.B;
			global::Org.BouncyCastle.Math.EC.ECFieldElement L3;
			if (b.BitLength < curve.FieldSize >> 1)
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement t = L2.Add(X).Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement t2;
				if (b.IsOne)
				{
					t2 = aZ1Sq.Add(Z1Sq).Square();
				}
				else
				{
					t2 = aZ1Sq.SquarePlusProduct(b, Z1Sq.Square());
				}
				L3 = t.Add(T).Add(Z1Sq).Multiply(t).Add(t2).Add(X4);
				if (a.IsZero)
				{
					L3 = L3.Add(Z4);
				}
				else if (!a.IsOne)
				{
					L3 = L3.Add(a.AddOne().Multiply(Z4));
				}
			}
			else
			{
				L3 = (Z1IsOne ? X : X.Multiply(Z3)).SquarePlusProduct(T, L1Z).Add(X4).Add(Z4);
			}
			return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X4, L3, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z4
			}, base.IsCompressed);
		}

		// Token: 0x06001571 RID: 5489 RVA: 0x00064D7C File Offset: 0x00062F7C
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
			if (curve.CoordinateSystem != 6)
			{
				return this.Twice().Add(b);
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
					return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, A, curve.B.Sqrt(), base.IsCompressed);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = A.Square().Multiply(X2Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = A.Multiply(B).Multiply(Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = A.Add(B).Square().MultiplyPlusProduct(T, L2plus, Z4);
				return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X3, L3, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z4
				}, base.IsCompressed);
			}
		}

		// Token: 0x06001572 RID: 5490 RVA: 0x00064F40 File Offset: 0x00063140
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
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			switch (curve.CoordinateSystem)
			{
			case 0:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
				return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X, Y.Add(X), base.IsCompressed);
			}
			case 1:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = base.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X, Y2.Add(X), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z
				}, base.IsCompressed);
			}
			case 5:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement L = base.RawYCoord;
				return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X, L.AddOne(), base.IsCompressed);
			}
			case 6:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = base.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = base.RawZCoords[0];
				return new global::Org.BouncyCastle.Math.EC.F2mPoint(curve, X, L2.Add(Z2), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z2
				}, base.IsCompressed);
			}
			}
			throw new global::System.InvalidOperationException("unsupported coordinate system");
		}
	}
}
