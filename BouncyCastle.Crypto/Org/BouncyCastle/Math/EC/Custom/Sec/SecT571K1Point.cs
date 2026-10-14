using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020002A4 RID: 676
	internal class SecT571K1Point : global::Org.BouncyCastle.Math.EC.AbstractF2mPoint
	{
		// Token: 0x06001DFC RID: 7676 RVA: 0x0008AC53 File Offset: 0x00088E53
		public SecT571K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x06001DFD RID: 7677 RVA: 0x0008AC5F File Offset: 0x00088E5F
		public SecT571K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x06001DFE RID: 7678 RVA: 0x0008AC81 File Offset: 0x00088E81
		internal SecT571K1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001DFF RID: 7679 RVA: 0x0008AC90 File Offset: 0x00088E90
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x17000423 RID: 1059
		// (get) Token: 0x06001E00 RID: 7680 RVA: 0x0008ACA4 File Offset: 0x00088EA4
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

		// Token: 0x17000424 RID: 1060
		// (get) Token: 0x06001E01 RID: 7681 RVA: 0x0008ACFC File Offset: 0x00088EFC
		protected internal override bool CompressionYTilde
		{
			get
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				return !X.IsZero && base.RawYCoord.TestBitZero() != X.TestBitZero();
			}
		}

		// Token: 0x06001E02 RID: 7682 RVA: 0x0008AD30 File Offset: 0x00088F30
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
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)base.RawXCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement X2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)b.RawXCoord;
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
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement L = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)base.RawYCoord;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)base.RawZCoords[0];
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement L2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)b.RawYCoord;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement Z2 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)b.RawZCoords[0];
				ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				ulong[] t2 = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				ulong[] t3 = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				ulong[] t4 = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				ulong[] Z1Precomp = Z.IsOne ? null : global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.PrecompMultiplicand(Z.x);
				ulong[] U2;
				ulong[] S2;
				if (Z1Precomp == null)
				{
					U2 = X2.x;
					S2 = L2.x;
				}
				else
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(X2.x, Z1Precomp, U2 = t2);
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(L2.x, Z1Precomp, S2 = t4);
				}
				ulong[] Z2Precomp = Z2.IsOne ? null : global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.PrecompMultiplicand(Z2.x);
				ulong[] U3;
				ulong[] S3;
				if (Z2Precomp == null)
				{
					U3 = X.x;
					S3 = L.x;
				}
				else
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(X.x, Z2Precomp, U3 = t);
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(L.x, Z2Precomp, S3 = t3);
				}
				ulong[] A = t3;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Add(S3, S2, A);
				ulong[] B = t4;
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Add(U3, U2, B);
				if (!global::Org.BouncyCastle.Math.Raw.Nat576.IsZero64(B))
				{
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement X3;
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement L4;
					global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement Z3;
					if (X2.IsZero)
					{
						global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = this.Normalize();
						X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)ecpoint.XCoord;
						global::Org.BouncyCastle.Math.EC.ECFieldElement Y = ecpoint.YCoord;
						global::Org.BouncyCastle.Math.EC.ECFieldElement Y2 = L2;
						global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = Y.Add(Y2).Divide(X);
						X3 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)L3.Square().Add(L3).Add(X);
						if (X3.IsZero)
						{
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve, X3, curve.B, base.IsCompressed);
						}
						L4 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)L3.Multiply(X.Add(X3)).Add(X3).Add(Y).Divide(X3).Add(X3);
						Z3 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)curve.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
					}
					else
					{
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(B, B);
						ulong[] APrecomp = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.PrecompMultiplicand(A);
						ulong[] AU = t;
						ulong[] AU2 = t2;
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(U3, APrecomp, AU);
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(U2, APrecomp, AU2);
						X3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(t);
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(AU, AU2, X3.x);
						if (X3.IsZero)
						{
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve, X3, curve.B, base.IsCompressed);
						}
						Z3 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(t3);
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(B, APrecomp, Z3.x);
						if (Z2Precomp != null)
						{
							global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(Z3.x, Z2Precomp, Z3.x);
						}
						ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Add(AU2, B, t4);
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareAddToExt(t4, tt);
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Add(L.x, Z.x, t4);
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyAddToExt(t4, Z3.x, tt);
						L4 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(t4);
						global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, L4.x);
						if (Z1Precomp != null)
						{
							global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(Z3.x, Z1Precomp, Z3.x);
						}
					}
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve, X3, L4, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
					{
						Z3
					}, base.IsCompressed);
				}
				if (global::Org.BouncyCastle.Math.Raw.Nat576.IsZero64(A))
				{
					return this.Twice();
				}
				return curve.Infinity;
			}
		}

		// Token: 0x06001E03 RID: 7683 RVA: 0x0008B0A8 File Offset: 0x000892A8
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
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve, T, curve.B, base.IsCompressed);
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement X2 = T.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement Z2 = Z1IsOne ? T : T.Multiply(Z1Sq);
			global::Org.BouncyCastle.Math.EC.ECFieldElement t = L.Add(X).Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement t2 = Z1IsOne ? Z : Z1Sq.Square();
			global::Org.BouncyCastle.Math.EC.ECFieldElement L2 = t.Add(T).Add(Z1Sq).Multiply(t).Add(t2).Add(X2).Add(Z2);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve, X2, L2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x06001E04 RID: 7684 RVA: 0x0008B1C8 File Offset: 0x000893C8
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
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve, A, curve.B, base.IsCompressed);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = A.Square().Multiply(X2Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = A.Multiply(B).Multiply(Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = A.Add(B).Square().MultiplyPlusProduct(T, L2plus, Z4);
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(curve, X3, L3, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z4
				}, base.IsCompressed);
			}
		}

		// Token: 0x06001E05 RID: 7685 RVA: 0x0008B350 File Offset: 0x00089550
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(this.Curve, X, L.Add(Z), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z
			}, base.IsCompressed);
		}
	}
}
