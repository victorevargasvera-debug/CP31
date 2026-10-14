using System;
using Org.BouncyCastle.Math.Raw;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020002A6 RID: 678
	internal class SecT571R1Point : global::Org.BouncyCastle.Math.EC.AbstractF2mPoint
	{
		// Token: 0x06001E16 RID: 7702 RVA: 0x0008B533 File Offset: 0x00089733
		public SecT571R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y) : this(curve, x, y, false)
		{
		}

		// Token: 0x06001E17 RID: 7703 RVA: 0x0008B53F File Offset: 0x0008973F
		public SecT571R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : base(curve, x, y, withCompression)
		{
			if (x == null != (y == null))
			{
				throw new global::System.ArgumentException("Exactly one of the field elements is null");
			}
		}

		// Token: 0x06001E18 RID: 7704 RVA: 0x0008B561 File Offset: 0x00089761
		internal SecT571R1Point(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression) : base(curve, x, y, zs, withCompression)
		{
		}

		// Token: 0x06001E19 RID: 7705 RVA: 0x0008B570 File Offset: 0x00089770
		protected override global::Org.BouncyCastle.Math.EC.ECPoint Detach()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(null, this.AffineXCoord, this.AffineYCoord);
		}

		// Token: 0x1700042D RID: 1069
		// (get) Token: 0x06001E1A RID: 7706 RVA: 0x0008B584 File Offset: 0x00089784
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

		// Token: 0x1700042E RID: 1070
		// (get) Token: 0x06001E1B RID: 7707 RVA: 0x0008B5DC File Offset: 0x000897DC
		protected internal override bool CompressionYTilde
		{
			get
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = base.RawXCoord;
				return !X.IsZero && base.RawYCoord.TestBitZero() != X.TestBitZero();
			}
		}

		// Token: 0x06001E1C RID: 7708 RVA: 0x0008B610 File Offset: 0x00089810
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
						X3 = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)L3.Square().Add(L3).Add(X).AddOne();
						if (X3.IsZero)
						{
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve, X3, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B_SQRT, base.IsCompressed);
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
							return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve, X3, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B_SQRT, base.IsCompressed);
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
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve, X3, L4, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
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

		// Token: 0x06001E1D RID: 7709 RVA: 0x0008B98C File Offset: 0x00089B8C
		public override global::Org.BouncyCastle.Math.EC.ECPoint Twice()
		{
			if (base.IsInfinity)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve curve = this.Curve;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement X = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)base.RawXCoord;
			if (X.IsZero)
			{
				return curve.Infinity;
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement L = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)base.RawYCoord;
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement Z = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)base.RawZCoords[0];
			ulong[] t = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			ulong[] t2 = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			ulong[] Z1Precomp = Z.IsOne ? null : global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.PrecompMultiplicand(Z.x);
			ulong[] L1Z;
			ulong[] Z1Sq;
			if (Z1Precomp == null)
			{
				L1Z = L.x;
				Z1Sq = Z.x;
			}
			else
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(L.x, Z1Precomp, L1Z = t);
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(Z.x, Z1Sq = t2);
			}
			ulong[] T = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(L.x, T);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddBothTo(L1Z, Z1Sq, T);
			if (global::Org.BouncyCastle.Math.Raw.Nat576.IsZero64(T))
			{
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve, new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(T), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B_SQRT, base.IsCompressed);
			}
			ulong[] tt = global::Org.BouncyCastle.Math.Raw.Nat576.CreateExt64();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyAddToExt(T, L1Z, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement X2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(t);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Square(T, X2.x);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement Z2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(T);
			if (Z1Precomp != null)
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Multiply(Z2.x, Z1Sq, Z2.x);
			}
			ulong[] X1Z;
			if (Z1Precomp == null)
			{
				X1Z = X.x;
			}
			else
			{
				global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.MultiplyPrecomp(X.x, Z1Precomp, X1Z = t2);
			}
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.SquareAddToExt(X1Z, tt);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.Reduce(tt, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571Field.AddBothTo(X2.x, Z2.x, t2);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement L2 = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(t2);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve, X2, L2, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z2
			}, base.IsCompressed);
		}

		// Token: 0x06001E1E RID: 7710 RVA: 0x0008BB34 File Offset: 0x00089D34
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
					return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve, A, global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B_SQRT, base.IsCompressed);
				}
				global::Org.BouncyCastle.Math.EC.ECFieldElement X3 = A.Square().Multiply(X2Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement Z4 = A.Multiply(B).Multiply(Z1Sq);
				global::Org.BouncyCastle.Math.EC.ECFieldElement L3 = A.Add(B).Square().MultiplyPlusProduct(T, L2.AddOne(), Z4);
				return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(curve, X3, L3, new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					Z4
				}, base.IsCompressed);
			}
		}

		// Token: 0x06001E1F RID: 7711 RVA: 0x0008BCBC File Offset: 0x00089EBC
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(this.Curve, X, L.Add(Z), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
			{
				Z
			}, base.IsCompressed);
		}
	}
}
