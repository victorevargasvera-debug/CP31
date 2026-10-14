using System;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000208 RID: 520
	public class FpCurve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x06001481 RID: 5249 RVA: 0x00060BA6 File Offset: 0x0005EDA6
		[global::System.Obsolete("Use constructor taking order/cofactor")]
		public FpCurve(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b) : this(q, a, b, null, null)
		{
		}

		// Token: 0x06001482 RID: 5250 RVA: 0x00060BB4 File Offset: 0x0005EDB4
		public FpCurve(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b, global::Org.BouncyCastle.Math.BigInteger order, global::Org.BouncyCastle.Math.BigInteger cofactor) : base(q)
		{
			this.m_q = q;
			this.m_r = global::Org.BouncyCastle.Math.EC.FpFieldElement.CalculateResidue(q);
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.FpPoint(this, null, null, false);
			this.m_a = this.FromBigInteger(a);
			this.m_b = this.FromBigInteger(b);
			this.m_order = order;
			this.m_cofactor = cofactor;
			this.m_coord = 4;
		}

		// Token: 0x06001483 RID: 5251 RVA: 0x00060C1B File Offset: 0x0005EE1B
		[global::System.Obsolete("Use constructor taking order/cofactor")]
		protected FpCurve(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.EC.ECFieldElement a, global::Org.BouncyCastle.Math.EC.ECFieldElement b) : this(q, r, a, b, null, null)
		{
		}

		// Token: 0x06001484 RID: 5252 RVA: 0x00060C2C File Offset: 0x0005EE2C
		protected FpCurve(global::Org.BouncyCastle.Math.BigInteger q, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.EC.ECFieldElement a, global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.BigInteger order, global::Org.BouncyCastle.Math.BigInteger cofactor) : base(q)
		{
			this.m_q = q;
			this.m_r = r;
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.FpPoint(this, null, null, false);
			this.m_a = a;
			this.m_b = b;
			this.m_order = order;
			this.m_cofactor = cofactor;
			this.m_coord = 4;
		}

		// Token: 0x06001485 RID: 5253 RVA: 0x00060C83 File Offset: 0x0005EE83
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.FpCurve(this.m_q, this.m_r, this.m_a, this.m_b, this.m_order, this.m_cofactor);
		}

		// Token: 0x06001486 RID: 5254 RVA: 0x00060CAE File Offset: 0x0005EEAE
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord <= 2 || coord == 4;
		}

		// Token: 0x1700027D RID: 637
		// (get) Token: 0x06001487 RID: 5255 RVA: 0x00060CBB File Offset: 0x0005EEBB
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return this.m_q;
			}
		}

		// Token: 0x1700027E RID: 638
		// (get) Token: 0x06001488 RID: 5256 RVA: 0x00060CC3 File Offset: 0x0005EEC3
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x1700027F RID: 639
		// (get) Token: 0x06001489 RID: 5257 RVA: 0x00060CCB File Offset: 0x0005EECB
		public override int FieldSize
		{
			get
			{
				return this.m_q.BitLength;
			}
		}

		// Token: 0x0600148A RID: 5258 RVA: 0x00060CD8 File Offset: 0x0005EED8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.FpFieldElement(this.m_q, this.m_r, x);
		}

		// Token: 0x0600148B RID: 5259 RVA: 0x00060CEC File Offset: 0x0005EEEC
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.FpPoint(this, x, y, withCompression);
		}

		// Token: 0x0600148C RID: 5260 RVA: 0x00060CF7 File Offset: 0x0005EEF7
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.FpPoint(this, x, y, zs, withCompression);
		}

		// Token: 0x0600148D RID: 5261 RVA: 0x00060D04 File Offset: 0x0005EF04
		public override global::Org.BouncyCastle.Math.EC.ECPoint ImportPoint(global::Org.BouncyCastle.Math.EC.ECPoint p)
		{
			if (this != p.Curve && this.CoordinateSystem == 2 && !p.IsInfinity)
			{
				int coordinateSystem = p.Curve.CoordinateSystem;
				if (coordinateSystem - 2 <= 2)
				{
					return new global::Org.BouncyCastle.Math.EC.FpPoint(this, this.FromBigInteger(p.RawXCoord.ToBigInteger()), this.FromBigInteger(p.RawYCoord.ToBigInteger()), new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
					{
						this.FromBigInteger(p.GetZCoord(0).ToBigInteger())
					}, p.IsCompressed);
				}
			}
			return base.ImportPoint(p);
		}

		// Token: 0x0400094B RID: 2379
		private const int FP_DEFAULT_COORDS = 4;

		// Token: 0x0400094C RID: 2380
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_q;

		// Token: 0x0400094D RID: 2381
		protected readonly global::Org.BouncyCastle.Math.BigInteger m_r;

		// Token: 0x0400094E RID: 2382
		protected readonly global::Org.BouncyCastle.Math.EC.FpPoint m_infinity;
	}
}
