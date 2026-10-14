using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000214 RID: 532
	public class FpPoint : global::Org.BouncyCastle.Math.EC.AbstractFpPoint
	{
		// Token: 0x0600154B RID: 5451 RVA: 0x00062F28 File Offset: 0x00061128
		[global::System.Obsolete("Use ECCurve.CreatePoint to construct points")]
		public FpPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x0600154C RID: 5452 RVA: 0x00062F34 File Offset: 0x00061134
		[global::System.Obsolete("Per-point compression property will be removed, see GetEncoded(bool)")]
		public FpPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x0600154D RID: 5453 RVA: 0x00062F56 File Offset: 0x00061156
		internal FpPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x0600154E RID: 5454 RVA: 0x00062F65 File Offset: 0x00061165
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.FpPoint(null, this.AffineXCoord, this.AffineYCoord, false);
		}

		// Token: 0x0600154F RID: 5455 RVA: 0x00062F7A File Offset: 0x0006117A
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement GetZCoord(int index)
		{
			if (index == 1 && 4 == this.CurveCoordinateSystem)
			{
				return this.GetJacobianModifiedW();
			}
			return base.GetZCoord(index);
		}

		// Token: 0x06001550 RID: 5456 RVA: 0x00062F98 File Offset: 0x00061198
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
			int coord = curve.CoordinateSystem;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = b.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = b.RawYCoord;
			switch (coord)
			{
			case 0:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement dx = X2.Subtract(X);
				global::Org.BouncyCastle.Math.EC.ECFieldElement dy = Y2.Subtract(Y);
				if (!dx.IsZero)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement = dy.Divide(dx);
					global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = ecfieldElement.Square().Subtract(X).Subtract(X2);
					global::Org.BouncyCastle.Math.EC.ECFieldElement Y3 = ecfieldElement.Multiply(X.Subtract(X3)).Subtract(Y);
					return new global::Org.BouncyCastle.Math.EC.FpPoint(this.Curve, X3, Y3, base.IsCompressed);
				}
				if (dy.IsZero)
				{
					return this.Twice();
				}
				return this.Curve.Infinity;
			}
			case 1:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = b.RawZCoords[0];
				bool Z1IsOne = Z.IsOne;
				bool Z2IsOne = Z2.IsOne;
				global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement2 = Z1IsOne ? Y2 : Y2.Multiply(Z);
				global::Org.BouncyCastle.Math.EC.ECFieldElement u2 = Z2IsOne ? Y : Y.Multiply(Z2);
				global::Org.BouncyCastle.Math.EC.ECFieldElement u3 = ecfieldElement2.Subtract(u2);
				global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement3 = Z1IsOne ? X2 : X2.Multiply(Z);
				global::Org.BouncyCastle.Math.EC.ECFieldElement v2 = Z2IsOne ? X : X.Multiply(Z2);
				global::Org.BouncyCastle.Math.EC.ECFieldElement v3 = ecfieldElement3.Subtract(v2);
				if (!v3.IsZero)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement w = Z1IsOne ? Z2 : (Z2IsOne ? Z : Z.Multiply(Z2));
					global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement4 = v3.Square();
					global::Org.BouncyCastle.Math.EC.ECFieldElement vCubed = ecfieldElement4.Multiply(v3);
					global::Org.BouncyCastle.Math.EC.ECFieldElement vSquaredV2 = ecfieldElement4.Multiply(v2);
					global::Org.BouncyCastle.Math.EC.ECFieldElement A = u3.Square().Multiply(w).Subtract(vCubed).Subtract(this.Two(vSquaredV2));
					global::Org.BouncyCastle.Math.EC.ECFieldElement X4 = v3.Multiply(A);
					global::Org.BouncyCastle.Math.EC.ECFieldElement Y4 = vSquaredV2.Subtract(A).MultiplyMinusProduct(u3, u2, vCubed);
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z3 = vCubed.Multiply(w);
					return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, X4, Y4, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
					{
						Z3
					}, base.IsCompressed);
				}
				if (u3.IsZero)
				{
					return this.Twice();
				}
				return curve.Infinity;
			}
			case 2:
			case 4:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = base.RawZCoords[0];
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z5 = b.RawZCoords[0];
				bool Z1IsOne2 = Z4.IsOne;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z3Squared = null;
				global::Org.BouncyCastle.Math.EC.ECFieldElement X5;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y5;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z6;
				if (!Z1IsOne2 && Z4.Equals(Z5))
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement dx2 = X.Subtract(X2);
					global::Org.BouncyCastle.Math.EC.ECFieldElement dy2 = Y.Subtract(Y2);
					if (dx2.IsZero)
					{
						if (dy2.IsZero)
						{
							return this.Twice();
						}
						return curve.Infinity;
					}
					else
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement C = dx2.Square();
						global::Org.BouncyCastle.Math.EC.ECFieldElement W = X.Multiply(C);
						global::Org.BouncyCastle.Math.EC.ECFieldElement W2 = X2.Multiply(C);
						global::Org.BouncyCastle.Math.EC.ECFieldElement A2 = W.Subtract(W2).Multiply(Y);
						X5 = dy2.Square().Subtract(W).Subtract(W2);
						Y5 = W.Subtract(X5).Multiply(dy2).Subtract(A2);
						Z6 = dx2;
						if (Z1IsOne2)
						{
							Z3Squared = C;
						}
						else
						{
							Z6 = Z6.Multiply(Z4);
						}
					}
				}
				else
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement U2;
					global::Org.BouncyCastle.Math.EC.ECFieldElement S2;
					if (Z1IsOne2)
					{
						U2 = X2;
						S2 = Y2;
					}
					else
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement5 = Z4.Square();
						U2 = ecfieldElement5.Multiply(X2);
						S2 = ecfieldElement5.Multiply(Z4).Multiply(Y2);
					}
					bool Z2IsOne2 = Z5.IsOne;
					global::Org.BouncyCastle.Math.EC.ECFieldElement U3;
					global::Org.BouncyCastle.Math.EC.ECFieldElement S3;
					if (Z2IsOne2)
					{
						U3 = X;
						S3 = Y;
					}
					else
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement6 = Z5.Square();
						U3 = ecfieldElement6.Multiply(X);
						S3 = ecfieldElement6.Multiply(Z5).Multiply(Y);
					}
					global::Org.BouncyCastle.Math.EC.ECFieldElement H = U3.Subtract(U2);
					global::Org.BouncyCastle.Math.EC.ECFieldElement R = S3.Subtract(S2);
					if (H.IsZero)
					{
						if (R.IsZero)
						{
							return this.Twice();
						}
						return curve.Infinity;
					}
					else
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement HSquared = H.Square();
						global::Org.BouncyCastle.Math.EC.ECFieldElement G = HSquared.Multiply(H);
						global::Org.BouncyCastle.Math.EC.ECFieldElement V = HSquared.Multiply(U3);
						X5 = R.Square().Add(G).Subtract(this.Two(V));
						Y5 = V.Subtract(X5).MultiplyMinusProduct(R, G, S3);
						Z6 = H;
						if (!Z1IsOne2)
						{
							Z6 = Z6.Multiply(Z4);
						}
						if (!Z2IsOne2)
						{
							Z6 = Z6.Multiply(Z5);
						}
						if (Z6 == H)
						{
							Z3Squared = HSquared;
						}
					}
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs;
				if (coord == 4)
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement W3 = this.CalculateJacobianModifiedW(Z6, Z3Squared);
					zs = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
					{
						Z6,
						W3
					};
				}
				else
				{
					zs = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
					{
						Z6
					};
				}
				return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, X5, Y5, zs, base.IsCompressed);
			}
			}
			throw new global::System.InvalidOperationException("unsupported coordinate system");
		}

		// Token: 0x06001551 RID: 5457 RVA: 0x0006341C File Offset: 0x0006161C
		public override global::Org.BouncyCastle.Math.EC.ECPoint Twice()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
			if (Y.IsZero)
			{
				return curve.Infinity;
			}
			int coord = curve.CoordinateSystem;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			switch (coord)
			{
			case 0:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X1Squared = X.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement = this.Three(X1Squared).Add(this.Curve.A).Divide(this.Two(Y));
				global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = ecfieldElement.Square().Subtract(this.Two(X));
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = ecfieldElement.Multiply(X.Subtract(X2)).Subtract(Y);
				return new global::Org.BouncyCastle.Math.EC.FpPoint(this.Curve, X2, Y2, base.IsCompressed);
			}
			case 1:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
				bool Z1IsOne = Z.IsOne;
				global::Org.BouncyCastle.Math.EC.ECFieldElement w = curve.A;
				if (!w.IsZero && !Z1IsOne)
				{
					w = w.Multiply(Z.Square());
				}
				w = w.Add(this.Three(X.Square()));
				global::Org.BouncyCastle.Math.EC.ECFieldElement s = Z1IsOne ? Y : Y.Multiply(Z);
				global::Org.BouncyCastle.Math.EC.ECFieldElement t = Z1IsOne ? Y.Square() : s.Multiply(Y);
				global::Org.BouncyCastle.Math.EC.ECFieldElement B = X.Multiply(t);
				global::Org.BouncyCastle.Math.EC.ECFieldElement _4B = this.Four(B);
				global::Org.BouncyCastle.Math.EC.ECFieldElement h = w.Square().Subtract(this.Two(_4B));
				global::Org.BouncyCastle.Math.EC.ECFieldElement _2s = this.Two(s);
				global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = h.Multiply(_2s);
				global::Org.BouncyCastle.Math.EC.ECFieldElement _2t = this.Two(t);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y3 = _4B.Subtract(h).Multiply(w).Subtract(this.Two(_2t.Square()));
				global::Org.BouncyCastle.Math.EC.ECFieldElement _4sSquared = Z1IsOne ? this.Two(_2t) : _2s.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = this.Two(_4sSquared).Multiply(s);
				return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, X3, Y3, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z2
				}, base.IsCompressed);
			}
			case 2:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z3 = base.RawZCoords[0];
				bool Z1IsOne2 = Z3.IsOne;
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y1Squared = Y.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement T = Y1Squared.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement a4 = curve.A;
				global::Org.BouncyCastle.Math.EC.ECFieldElement a4Neg = a4.Negate();
				global::Org.BouncyCastle.Math.EC.ECFieldElement M;
				global::Org.BouncyCastle.Math.EC.ECFieldElement S;
				if (a4Neg.ToBigInteger().Equals(global::Org.BouncyCastle.Math.BigInteger.ValueOf(3L)))
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z1Squared = Z1IsOne2 ? Z3 : Z3.Square();
					M = this.Three(X.Add(Z1Squared).Multiply(X.Subtract(Z1Squared)));
					S = this.Four(Y1Squared.Multiply(X));
				}
				else
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement X1Squared2 = X.Square();
					M = this.Three(X1Squared2);
					if (Z1IsOne2)
					{
						M = M.Add(a4);
					}
					else if (!a4.IsZero)
					{
						global::Org.BouncyCastle.Math.EC.ECFieldElement Z1Pow4 = (Z1IsOne2 ? Z3 : Z3.Square()).Square();
						if (a4Neg.BitLength < a4.BitLength)
						{
							M = M.Subtract(Z1Pow4.Multiply(a4Neg));
						}
						else
						{
							M = M.Add(Z1Pow4.Multiply(a4));
						}
					}
					S = this.Four(X.Multiply(Y1Squared));
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement X4 = M.Square().Subtract(this.Two(S));
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y4 = S.Subtract(X4).Multiply(M).Subtract(this.Eight(T));
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = this.Two(Y);
				if (!Z1IsOne2)
				{
					Z4 = Z4.Multiply(Z3);
				}
				return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, X4, Y4, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z4
				}, base.IsCompressed);
			}
			case 4:
				return this.TwiceJacobianModified(true);
			}
			throw new global::System.InvalidOperationException("unsupported coordinate system");
		}

		// Token: 0x06001552 RID: 5458 RVA: 0x000637A0 File Offset: 0x000619A0
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
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
			if (Y.IsZero)
			{
				return b;
			}
			int coord = this.Curve.CoordinateSystem;
			if (coord != 0)
			{
				if (coord != 4)
				{
					return this.Twice().Add(b);
				}
				return this.TwiceJacobianModified(false).Add(b);
			}
			else
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = b.RawXCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement rawYCoord = b.RawYCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement dx = X2.Subtract(X);
				global::Org.BouncyCastle.Math.EC.ECFieldElement dy = rawYCoord.Subtract(Y);
				if (dx.IsZero)
				{
					if (dy.IsZero)
					{
						return this.ThreeTimes();
					}
					return this;
				}
				else
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = dx.Square();
					global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = dy.Square();
					global::Org.BouncyCastle.Math.EC.ECFieldElement d = X3.Multiply(this.Two(X).Add(X2)).Subtract(Y2);
					if (d.IsZero)
					{
						return this.Curve.Infinity;
					}
					global::Org.BouncyCastle.Math.EC.ECFieldElement I = d.Multiply(dx).Invert();
					global::Org.BouncyCastle.Math.EC.ECFieldElement L = d.Multiply(I).Multiply(dy);
					global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = this.Two(Y).Multiply(X3).Multiply(dx).Multiply(I).Subtract(L);
					global::Org.BouncyCastle.Math.EC.ECFieldElement X4 = L2.Subtract(L).Multiply(L.Add(L2)).Add(X2);
					global::Org.BouncyCastle.Math.EC.ECFieldElement Y3 = X.Subtract(X4).Multiply(L2).Subtract(Y);
					return new global::Org.BouncyCastle.Math.EC.FpPoint(this.Curve, X4, Y3, base.IsCompressed);
				}
			}
		}

		// Token: 0x06001553 RID: 5459 RVA: 0x00063930 File Offset: 0x00061B30
		public override global::Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
			if (Y.IsZero)
			{
				return this;
			}
			int coord = this.Curve.CoordinateSystem;
			if (coord != 0)
			{
				if (coord != 4)
				{
					return this.Twice().Add(this);
				}
				return this.TwiceJacobianModified(false).Add(this);
			}
			else
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				global::Org.BouncyCastle.Math.EC.ECFieldElement _2Y = this.Two(Y);
				global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = _2Y.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z = this.Three(X.Square()).Add(this.Curve.A);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = Z.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement d = this.Three(X).Multiply(X2).Subtract(Y2);
				if (d.IsZero)
				{
					return this.Curve.Infinity;
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement I = d.Multiply(_2Y).Invert();
				global::Org.BouncyCastle.Math.EC.ECFieldElement L = d.Multiply(I).Multiply(Z);
				global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = X2.Square().Multiply(I).Subtract(L);
				global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = L2.Subtract(L).Multiply(L.Add(L2)).Add(X);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y3 = X.Subtract(X3).Multiply(L2).Subtract(Y);
				return new global::Org.BouncyCastle.Math.EC.FpPoint(this.Curve, X3, Y3, base.IsCompressed);
			}
		}

		// Token: 0x06001554 RID: 5460 RVA: 0x00063A7C File Offset: 0x00061C7C
		public override global::Org.BouncyCastle.Math.EC.ECPoint TimesPow2(int e)
		{
			if (e < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "e");
			}
			if (e == 0 || base.IsInfinity)
			{
				return this;
			}
			if (e == 1)
			{
				return this.Twice();
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
			if (Y.IsZero)
			{
				return curve.Infinity;
			}
			int coord = curve.CoordinateSystem;
			global::Org.BouncyCastle.Math.EC.ECFieldElement W = curve.A;
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z = (base.RawZCoords.Length < 1) ? curve.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One) : base.RawZCoords[0];
			if (!Z.IsOne)
			{
				switch (coord)
				{
				case 1:
				{
					global::Org.BouncyCastle.Math.EC.ECFieldElement Z1Sq = Z.Square();
					X = X.Multiply(Z);
					Y = Y.Multiply(Z1Sq);
					W = this.CalculateJacobianModifiedW(Z, Z1Sq);
					break;
				}
				case 2:
					W = this.CalculateJacobianModifiedW(Z, null);
					break;
				case 4:
					W = this.GetJacobianModifiedW();
					break;
				}
			}
			for (int i = 0; i < e; i++)
			{
				if (Y.IsZero)
				{
					return curve.Infinity;
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement X1Squared = X.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement M = this.Three(X1Squared);
				global::Org.BouncyCastle.Math.EC.ECFieldElement _2Y = this.Two(Y);
				global::Org.BouncyCastle.Math.EC.ECFieldElement _2Y1Squared = _2Y.Multiply(Y);
				global::Org.BouncyCastle.Math.EC.ECFieldElement S = this.Two(X.Multiply(_2Y1Squared));
				global::Org.BouncyCastle.Math.EC.ECFieldElement _4T = _2Y1Squared.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement _8T = this.Two(_4T);
				if (!W.IsZero)
				{
					M = M.Add(W);
					W = this.Two(_8T.Multiply(W));
				}
				X = M.Square().Subtract(this.Two(S));
				Y = M.Multiply(S.Subtract(X)).Subtract(_8T);
				Z = (Z.IsOne ? _2Y : _2Y.Multiply(Z));
			}
			switch (coord)
			{
			case 0:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement zInv = Z.Invert();
				global::Org.BouncyCastle.Math.EC.ECFieldElement zInv2 = zInv.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement zInv3 = zInv2.Multiply(zInv);
				return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, X.Multiply(zInv2), Y.Multiply(zInv3), base.IsCompressed);
			}
			case 1:
				X = X.Multiply(Z);
				Z = Z.Multiply(Z.Square());
				return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, X, Y, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z
				}, base.IsCompressed);
			case 2:
				return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, X, Y, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z
				}, base.IsCompressed);
			case 4:
				return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, X, Y, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z,
					W
				}, base.IsCompressed);
			}
			throw new global::System.InvalidOperationException("unsupported coordinate system");
		}

		// Token: 0x06001555 RID: 5461 RVA: 0x00063D14 File Offset: 0x00061F14
		protected virtual global::Org.BouncyCastle.Math.EC.ECFieldElement Two(global::Org.BouncyCastle.Math.EC.ECFieldElement x)
		{
			return x.Add(x);
		}

		// Token: 0x06001556 RID: 5462 RVA: 0x00063D1D File Offset: 0x00061F1D
		protected virtual global::Org.BouncyCastle.Math.EC.ECFieldElement Three(global::Org.BouncyCastle.Math.EC.ECFieldElement x)
		{
			return this.Two(x).Add(x);
		}

		// Token: 0x06001557 RID: 5463 RVA: 0x00063D2C File Offset: 0x00061F2C
		protected virtual global::Org.BouncyCastle.Math.EC.ECFieldElement Four(global::Org.BouncyCastle.Math.EC.ECFieldElement x)
		{
			return this.Two(this.Two(x));
		}

		// Token: 0x06001558 RID: 5464 RVA: 0x00063D3B File Offset: 0x00061F3B
		protected virtual global::Org.BouncyCastle.Math.EC.ECFieldElement Eight(global::Org.BouncyCastle.Math.EC.ECFieldElement x)
		{
			return this.Four(this.Two(x));
		}

		// Token: 0x06001559 RID: 5465 RVA: 0x00063D4A File Offset: 0x00061F4A
		protected virtual global::Org.BouncyCastle.Math.EC.ECFieldElement DoubleProductFromSquares(global::Org.BouncyCastle.Math.EC.ECFieldElement a, global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.EC.ECFieldElement aSquared, global::Org.BouncyCastle.Math.EC.ECFieldElement bSquared)
		{
			return a.Add(b).Square().Subtract(aSquared).Subtract(bSquared);
		}

		// Token: 0x0600155A RID: 5466 RVA: 0x00063D68 File Offset: 0x00061F68
		public override global::Org.BouncyCastle.Math.EC.ECPoint Negate()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			int coord = curve.CoordinateSystem;
			if (coord != 0)
			{
				return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, base.RawXCoord, base.RawYCoord.Negate(), base.RawZCoords, base.IsCompressed);
			}
			return new global::Org.BouncyCastle.Math.EC.FpPoint(curve, base.RawXCoord, base.RawYCoord.Negate(), base.IsCompressed);
		}

		// Token: 0x0600155B RID: 5467 RVA: 0x00063DD4 File Offset: 0x00061FD4
		protected virtual global::Org.BouncyCastle.Math.EC.ECFieldElement CalculateJacobianModifiedW(global::Org.BouncyCastle.Math.EC.ECFieldElement Z, global::Org.BouncyCastle.Math.EC.ECFieldElement ZSquared)
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement a4 = this.Curve.A;
			if (a4.IsZero || Z.IsOne)
			{
				return a4;
			}
			if (ZSquared == null)
			{
				ZSquared = Z.Square();
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement W = ZSquared.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement a4Neg = a4.Negate();
			if (a4Neg.BitLength < a4.BitLength)
			{
				W = W.Multiply(a4Neg).Negate();
			}
			else
			{
				W = W.Multiply(a4);
			}
			return W;
		}

		// Token: 0x0600155C RID: 5468 RVA: 0x00063E40 File Offset: 0x00062040
		protected virtual global::Org.BouncyCastle.Math.EC.ECFieldElement GetJacobianModifiedW()
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement[] ZZ = base.RawZCoords;
			global::Org.BouncyCastle.Math.EC.ECFieldElement W = ZZ[1];
			if (W == null)
			{
				W = (ZZ[1] = this.CalculateJacobianModifiedW(ZZ[0], null));
			}
			return W;
		}

		// Token: 0x0600155D RID: 5469 RVA: 0x00063E6C File Offset: 0x0006206C
		protected virtual global::Org.BouncyCastle.Math.EC.FpPoint TwiceJacobianModified(bool calculateW)
		{
			global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y = base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z = base.RawZCoords[0];
			global::Org.BouncyCastle.Math.EC.ECFieldElement W = this.GetJacobianModifiedW();
			global::Org.BouncyCastle.Math.EC.ECFieldElement X1Squared = X.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement ecfieldElement = this.Three(X1Squared).Add(W);
			global::Org.BouncyCastle.Math.EC.ECFieldElement _2Y = this.Two(Y);
			global::Org.BouncyCastle.Math.EC.ECFieldElement _2Y1Squared = _2Y.Multiply(Y);
			global::Org.BouncyCastle.Math.EC.ECFieldElement S = this.Two(X.Multiply(_2Y1Squared));
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = ecfieldElement.Square().Subtract(this.Two(S));
			global::Org.BouncyCastle.Math.EC.ECFieldElement _4T = _2Y1Squared.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement _8T = this.Two(_4T);
			global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = ecfieldElement.Multiply(S.Subtract(X2)).Subtract(_8T);
			global::Org.BouncyCastle.Math.EC.ECFieldElement W2 = calculateW ? this.Two(_8T.Multiply(W)) : null;
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = Z.IsOne ? _2Y : _2Y.Multiply(Z);
			return new global::Org.BouncyCastle.Math.EC.FpPoint(this.Curve, X2, Y2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2,
				W2
			}, base.IsCompressed);
		}
	}
}
