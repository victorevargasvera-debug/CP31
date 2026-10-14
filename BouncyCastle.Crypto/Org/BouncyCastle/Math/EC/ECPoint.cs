using System;
using System.Collections;
using System.Text;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x02000211 RID: 529
	public abstract class ECPoint
	{
		// Token: 0x06001512 RID: 5394 RVA: 0x00062640 File Offset: 0x00060840
		protected static global::Org.BouncyCastle.Math.EC.ECFieldElement[] GetInitialZCoords(global::Org.BouncyCastle.Math.EC.ECCurve curve)
		{
			int coord = (curve == null) ? 0 : curve.CoordinateSystem;
			if (coord == 0 || coord == 5)
			{
				return global::Org.BouncyCastle.Math.EC.ECPoint.EMPTY_ZS;
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement one = curve.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			switch (coord)
			{
			case 1:
			case 2:
			case 6:
				return new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					one
				};
			case 3:
				return new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					one,
					one,
					one
				};
			case 4:
				return new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
				{
					one,
					curve.A
				};
			}
			throw new global::System.ArgumentException("unknown coordinate system");
		}

		// Token: 0x06001513 RID: 5395 RVA: 0x000626D1 File Offset: 0x000608D1
		protected ECPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression) : this(curve, x, y, global::Org.BouncyCastle.Math.EC.ECPoint.GetInitialZCoords(curve), withCompression)
		{
		}

		// Token: 0x06001514 RID: 5396 RVA: 0x000626E4 File Offset: 0x000608E4
		internal ECPoint(global::Org.BouncyCastle.Math.EC.ECCurve curve, global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			this.m_curve = curve;
			this.m_x = x;
			this.m_y = y;
			this.m_zs = zs;
			this.m_withCompression = withCompression;
		}

		// Token: 0x06001515 RID: 5397
		protected abstract bool SatisfiesCurveEquation();

		// Token: 0x06001516 RID: 5398 RVA: 0x00062714 File Offset: 0x00060914
		protected virtual bool SatisfiesOrder()
		{
			if (global::Org.BouncyCastle.Math.BigInteger.One.Equals(this.Curve.Cofactor))
			{
				return true;
			}
			global::Org.BouncyCastle.Math.BigInteger i = this.Curve.Order;
			return i == null || global::Org.BouncyCastle.Math.EC.ECAlgorithms.ReferenceMultiply(this, i).IsInfinity;
		}

		// Token: 0x06001517 RID: 5399 RVA: 0x00062757 File Offset: 0x00060957
		public global::Org.BouncyCastle.Math.EC.ECPoint GetDetachedPoint()
		{
			return this.Normalize().Detach();
		}

		// Token: 0x1700029B RID: 667
		// (get) Token: 0x06001518 RID: 5400 RVA: 0x00062764 File Offset: 0x00060964
		public virtual global::Org.BouncyCastle.Math.EC.ECCurve Curve
		{
			get
			{
				return this.m_curve;
			}
		}

		// Token: 0x06001519 RID: 5401
		protected abstract global::Org.BouncyCastle.Math.EC.ECPoint Detach();

		// Token: 0x1700029C RID: 668
		// (get) Token: 0x0600151A RID: 5402 RVA: 0x0006276C File Offset: 0x0006096C
		protected virtual int CurveCoordinateSystem
		{
			get
			{
				if (this.m_curve != null)
				{
					return this.m_curve.CoordinateSystem;
				}
				return 0;
			}
		}

		// Token: 0x1700029D RID: 669
		// (get) Token: 0x0600151B RID: 5403 RVA: 0x00062783 File Offset: 0x00060983
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement AffineXCoord
		{
			get
			{
				this.CheckNormalized();
				return this.XCoord;
			}
		}

		// Token: 0x1700029E RID: 670
		// (get) Token: 0x0600151C RID: 5404 RVA: 0x00062791 File Offset: 0x00060991
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement AffineYCoord
		{
			get
			{
				this.CheckNormalized();
				return this.YCoord;
			}
		}

		// Token: 0x1700029F RID: 671
		// (get) Token: 0x0600151D RID: 5405 RVA: 0x0006279F File Offset: 0x0006099F
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement XCoord
		{
			get
			{
				return this.m_x;
			}
		}

		// Token: 0x170002A0 RID: 672
		// (get) Token: 0x0600151E RID: 5406 RVA: 0x000627A7 File Offset: 0x000609A7
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement YCoord
		{
			get
			{
				return this.m_y;
			}
		}

		// Token: 0x0600151F RID: 5407 RVA: 0x000627AF File Offset: 0x000609AF
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement GetZCoord(int index)
		{
			if (index >= 0 && index < this.m_zs.Length)
			{
				return this.m_zs[index];
			}
			return null;
		}

		// Token: 0x06001520 RID: 5408 RVA: 0x000627CC File Offset: 0x000609CC
		public virtual global::Org.BouncyCastle.Math.EC.ECFieldElement[] GetZCoords()
		{
			int zsLen = this.m_zs.Length;
			if (zsLen == 0)
			{
				return this.m_zs;
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement[] copy = new global::Org.BouncyCastle.Math.EC.ECFieldElement[zsLen];
			global::System.Array.Copy(this.m_zs, 0, copy, 0, zsLen);
			return copy;
		}

		// Token: 0x170002A1 RID: 673
		// (get) Token: 0x06001521 RID: 5409 RVA: 0x00062803 File Offset: 0x00060A03
		protected internal global::Org.BouncyCastle.Math.EC.ECFieldElement RawXCoord
		{
			get
			{
				return this.m_x;
			}
		}

		// Token: 0x170002A2 RID: 674
		// (get) Token: 0x06001522 RID: 5410 RVA: 0x0006280B File Offset: 0x00060A0B
		protected internal global::Org.BouncyCastle.Math.EC.ECFieldElement RawYCoord
		{
			get
			{
				return this.m_y;
			}
		}

		// Token: 0x170002A3 RID: 675
		// (get) Token: 0x06001523 RID: 5411 RVA: 0x00062813 File Offset: 0x00060A13
		protected internal global::Org.BouncyCastle.Math.EC.ECFieldElement[] RawZCoords
		{
			get
			{
				return this.m_zs;
			}
		}

		// Token: 0x06001524 RID: 5412 RVA: 0x0006281B File Offset: 0x00060A1B
		protected virtual void CheckNormalized()
		{
			if (!this.IsNormalized())
			{
				throw new global::System.InvalidOperationException("point not in normal form");
			}
		}

		// Token: 0x06001525 RID: 5413 RVA: 0x00062830 File Offset: 0x00060A30
		public virtual bool IsNormalized()
		{
			int coord = this.CurveCoordinateSystem;
			return coord == 0 || coord == 5 || this.IsInfinity || this.RawZCoords[0].IsOne;
		}

		// Token: 0x06001526 RID: 5414 RVA: 0x00062864 File Offset: 0x00060A64
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint Normalize()
		{
			if (this.IsInfinity)
			{
				return this;
			}
			int curveCoordinateSystem = this.CurveCoordinateSystem;
			if (curveCoordinateSystem == 0 || curveCoordinateSystem == 5)
			{
				return this;
			}
			global::Org.BouncyCastle.Math.EC.ECFieldElement z = this.RawZCoords[0];
			if (z.IsOne)
			{
				return this;
			}
			if (this.m_curve == null)
			{
				throw new global::System.InvalidOperationException("Detached points must be in affine coordinates");
			}
			global::Org.BouncyCastle.Security.SecureRandom r = global::Org.BouncyCastle.Math.EC.ECPoint.Random;
			global::Org.BouncyCastle.Math.EC.ECFieldElement b = this.m_curve.RandomFieldElementMult(r);
			global::Org.BouncyCastle.Math.EC.ECFieldElement zInv = z.Multiply(b).Invert().Multiply(b);
			return this.Normalize(zInv);
		}

		// Token: 0x06001527 RID: 5415 RVA: 0x000628E0 File Offset: 0x00060AE0
		internal virtual global::Org.BouncyCastle.Math.EC.ECPoint Normalize(global::Org.BouncyCastle.Math.EC.ECFieldElement zInv)
		{
			switch (this.CurveCoordinateSystem)
			{
			case 1:
			case 6:
				return this.CreateScaledPoint(zInv, zInv);
			case 2:
			case 3:
			case 4:
			{
				global::Org.BouncyCastle.Math.EC.ECFieldElement zInv2 = zInv.Square();
				global::Org.BouncyCastle.Math.EC.ECFieldElement zInv3 = zInv2.Multiply(zInv);
				return this.CreateScaledPoint(zInv2, zInv3);
			}
			}
			throw new global::System.InvalidOperationException("not a projective coordinate system");
		}

		// Token: 0x06001528 RID: 5416 RVA: 0x00062941 File Offset: 0x00060B41
		protected virtual global::Org.BouncyCastle.Math.EC.ECPoint CreateScaledPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement sx, global::Org.BouncyCastle.Math.EC.ECFieldElement sy)
		{
			return this.Curve.CreateRawPoint(this.RawXCoord.Multiply(sx), this.RawYCoord.Multiply(sy), this.IsCompressed);
		}

		// Token: 0x170002A4 RID: 676
		// (get) Token: 0x06001529 RID: 5417 RVA: 0x0006296C File Offset: 0x00060B6C
		public bool IsInfinity
		{
			get
			{
				return this.m_x == null && this.m_y == null;
			}
		}

		// Token: 0x170002A5 RID: 677
		// (get) Token: 0x0600152A RID: 5418 RVA: 0x00062981 File Offset: 0x00060B81
		public bool IsCompressed
		{
			get
			{
				return this.m_withCompression;
			}
		}

		// Token: 0x0600152B RID: 5419 RVA: 0x00062989 File Offset: 0x00060B89
		public bool IsValid()
		{
			return this.ImplIsValid(false, true);
		}

		// Token: 0x0600152C RID: 5420 RVA: 0x00062993 File Offset: 0x00060B93
		internal bool IsValidPartial()
		{
			return this.ImplIsValid(false, false);
		}

		// Token: 0x0600152D RID: 5421 RVA: 0x000629A0 File Offset: 0x00060BA0
		internal bool ImplIsValid(bool decompressed, bool checkOrder)
		{
			if (this.IsInfinity)
			{
				return true;
			}
			global::Org.BouncyCastle.Math.EC.ECPoint.ValidityCallback callback = new global::Org.BouncyCastle.Math.EC.ECPoint.ValidityCallback(this, decompressed, checkOrder);
			return !((global::Org.BouncyCastle.Math.EC.Multiplier.ValidityPreCompInfo)this.Curve.Precompute(this, global::Org.BouncyCastle.Math.EC.Multiplier.ValidityPreCompInfo.PRECOMP_NAME, callback)).HasFailed();
		}

		// Token: 0x0600152E RID: 5422 RVA: 0x000629DF File Offset: 0x00060BDF
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint ScaleX(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			if (!this.IsInfinity)
			{
				return this.Curve.CreateRawPoint(this.RawXCoord.Multiply(scale), this.RawYCoord, this.RawZCoords, this.IsCompressed);
			}
			return this;
		}

		// Token: 0x0600152F RID: 5423 RVA: 0x00062A14 File Offset: 0x00060C14
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint ScaleXNegateY(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			if (!this.IsInfinity)
			{
				return this.Curve.CreateRawPoint(this.RawXCoord.Multiply(scale), this.RawYCoord.Negate(), this.RawZCoords, this.IsCompressed);
			}
			return this;
		}

		// Token: 0x06001530 RID: 5424 RVA: 0x00062A4E File Offset: 0x00060C4E
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint ScaleY(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			if (!this.IsInfinity)
			{
				return this.Curve.CreateRawPoint(this.RawXCoord, this.RawYCoord.Multiply(scale), this.RawZCoords, this.IsCompressed);
			}
			return this;
		}

		// Token: 0x06001531 RID: 5425 RVA: 0x00062A83 File Offset: 0x00060C83
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint ScaleYNegateX(global::Org.BouncyCastle.Math.EC.ECFieldElement scale)
		{
			if (!this.IsInfinity)
			{
				return this.Curve.CreateRawPoint(this.RawXCoord.Negate(), this.RawYCoord.Multiply(scale), this.RawZCoords, this.IsCompressed);
			}
			return this;
		}

		// Token: 0x06001532 RID: 5426 RVA: 0x00062ABD File Offset: 0x00060CBD
		public override bool Equals(object obj)
		{
			return this.Equals(obj as global::Org.BouncyCastle.Math.EC.ECPoint);
		}

		// Token: 0x06001533 RID: 5427 RVA: 0x00062ACC File Offset: 0x00060CCC
		public virtual bool Equals(global::Org.BouncyCastle.Math.EC.ECPoint other)
		{
			if (this == other)
			{
				return true;
			}
			if (other == null)
			{
				return false;
			}
			global::Org.BouncyCastle.Math.EC.ECCurve c = this.Curve;
			global::Org.BouncyCastle.Math.EC.ECCurve c2 = other.Curve;
			bool n = c == null;
			bool n2 = c2 == null;
			bool i = this.IsInfinity;
			bool i2 = other.IsInfinity;
			if (i || i2)
			{
				return i && i2 && (n || n2 || c.Equals(c2));
			}
			global::Org.BouncyCastle.Math.EC.ECPoint p = this;
			global::Org.BouncyCastle.Math.EC.ECPoint p2 = other;
			if (!n || !n2)
			{
				if (n)
				{
					p2 = p2.Normalize();
				}
				else if (n2)
				{
					p = p.Normalize();
				}
				else
				{
					if (!c.Equals(c2))
					{
						return false;
					}
					global::Org.BouncyCastle.Math.EC.ECPoint[] points = new global::Org.BouncyCastle.Math.EC.ECPoint[]
					{
						this,
						c.ImportPoint(p2)
					};
					c.NormalizeAll(points);
					p = points[0];
					p2 = points[1];
				}
			}
			return p.XCoord.Equals(p2.XCoord) && p.YCoord.Equals(p2.YCoord);
		}

		// Token: 0x06001534 RID: 5428 RVA: 0x00062BB4 File Offset: 0x00060DB4
		public override int GetHashCode()
		{
			global::Org.BouncyCastle.Math.EC.ECCurve c = this.Curve;
			int hc = (c == null) ? 0 : (~c.GetHashCode());
			if (!this.IsInfinity)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint p = this.Normalize();
				hc ^= p.XCoord.GetHashCode() * 17;
				hc ^= p.YCoord.GetHashCode() * 257;
			}
			return hc;
		}

		// Token: 0x06001535 RID: 5429 RVA: 0x00062C0C File Offset: 0x00060E0C
		public override string ToString()
		{
			if (this.IsInfinity)
			{
				return "INF";
			}
			global::System.Text.StringBuilder sb = new global::System.Text.StringBuilder();
			sb.Append('(');
			sb.Append(this.RawXCoord);
			sb.Append(',');
			sb.Append(this.RawYCoord);
			for (int i = 0; i < this.m_zs.Length; i++)
			{
				sb.Append(',');
				sb.Append(this.m_zs[i]);
			}
			sb.Append(')');
			return sb.ToString();
		}

		// Token: 0x06001536 RID: 5430 RVA: 0x00062C93 File Offset: 0x00060E93
		public virtual byte[] GetEncoded()
		{
			return this.GetEncoded(this.m_withCompression);
		}

		// Token: 0x06001537 RID: 5431
		public abstract byte[] GetEncoded(bool compressed);

		// Token: 0x170002A6 RID: 678
		// (get) Token: 0x06001538 RID: 5432
		protected internal abstract bool CompressionYTilde { get; }

		// Token: 0x06001539 RID: 5433
		public abstract global::Org.BouncyCastle.Math.EC.ECPoint Add(global::Org.BouncyCastle.Math.EC.ECPoint b);

		// Token: 0x0600153A RID: 5434
		public abstract global::Org.BouncyCastle.Math.EC.ECPoint Subtract(global::Org.BouncyCastle.Math.EC.ECPoint b);

		// Token: 0x0600153B RID: 5435
		public abstract global::Org.BouncyCastle.Math.EC.ECPoint Negate();

		// Token: 0x0600153C RID: 5436 RVA: 0x00062CA4 File Offset: 0x00060EA4
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint TimesPow2(int e)
		{
			if (e < 0)
			{
				throw new global::System.ArgumentException("cannot be negative", "e");
			}
			global::Org.BouncyCastle.Math.EC.ECPoint p = this;
			while (--e >= 0)
			{
				p = p.Twice();
			}
			return p;
		}

		// Token: 0x0600153D RID: 5437
		public abstract global::Org.BouncyCastle.Math.EC.ECPoint Twice();

		// Token: 0x0600153E RID: 5438
		public abstract global::Org.BouncyCastle.Math.EC.ECPoint Multiply(global::Org.BouncyCastle.Math.BigInteger b);

		// Token: 0x0600153F RID: 5439 RVA: 0x00062CDA File Offset: 0x00060EDA
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint TwicePlus(global::Org.BouncyCastle.Math.EC.ECPoint b)
		{
			return this.Twice().Add(b);
		}

		// Token: 0x06001540 RID: 5440 RVA: 0x00062CE8 File Offset: 0x00060EE8
		public virtual global::Org.BouncyCastle.Math.EC.ECPoint ThreeTimes()
		{
			return this.TwicePlus(this);
		}

		// Token: 0x04000960 RID: 2400
		private static readonly global::Org.BouncyCastle.Security.SecureRandom Random = new global::Org.BouncyCastle.Security.SecureRandom();

		// Token: 0x04000961 RID: 2401
		protected static global::Org.BouncyCastle.Math.EC.ECFieldElement[] EMPTY_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[0];

		// Token: 0x04000962 RID: 2402
		protected internal readonly global::Org.BouncyCastle.Math.EC.ECCurve m_curve;

		// Token: 0x04000963 RID: 2403
		protected internal readonly global::Org.BouncyCastle.Math.EC.ECFieldElement m_x;

		// Token: 0x04000964 RID: 2404
		protected internal readonly global::Org.BouncyCastle.Math.EC.ECFieldElement m_y;

		// Token: 0x04000965 RID: 2405
		protected internal readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] m_zs;

		// Token: 0x04000966 RID: 2406
		protected internal readonly bool m_withCompression;

		// Token: 0x04000967 RID: 2407
		protected internal global::System.Collections.IDictionary m_preCompTable;

		// Token: 0x020007C0 RID: 1984
		private class ValidityCallback : global::Org.BouncyCastle.Math.EC.Multiplier.IPreCompCallback
		{
			// Token: 0x06004567 RID: 17767 RVA: 0x001333F3 File Offset: 0x001315F3
			internal ValidityCallback(global::Org.BouncyCastle.Math.EC.ECPoint outer, bool decompressed, bool checkOrder)
			{
				this.m_outer = outer;
				this.m_decompressed = decompressed;
				this.m_checkOrder = checkOrder;
			}

			// Token: 0x06004568 RID: 17768 RVA: 0x00133410 File Offset: 0x00131610
			public global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo Precompute(global::Org.BouncyCastle.Math.EC.Multiplier.PreCompInfo existing)
			{
				global::Org.BouncyCastle.Math.EC.Multiplier.ValidityPreCompInfo info = existing as global::Org.BouncyCastle.Math.EC.Multiplier.ValidityPreCompInfo;
				if (info == null)
				{
					info = new global::Org.BouncyCastle.Math.EC.Multiplier.ValidityPreCompInfo();
				}
				if (info.HasFailed())
				{
					return info;
				}
				if (!info.HasCurveEquationPassed())
				{
					if (!this.m_decompressed && !this.m_outer.SatisfiesCurveEquation())
					{
						info.ReportFailed();
						return info;
					}
					info.ReportCurveEquationPassed();
				}
				if (this.m_checkOrder && !info.HasOrderPassed())
				{
					if (!this.m_outer.SatisfiesOrder())
					{
						info.ReportFailed();
						return info;
					}
					info.ReportOrderPassed();
				}
				return info;
			}

			// Token: 0x040023EF RID: 9199
			private readonly global::Org.BouncyCastle.Math.EC.ECPoint m_outer;

			// Token: 0x040023F0 RID: 9200
			private readonly bool m_decompressed;

			// Token: 0x040023F1 RID: 9201
			private readonly bool m_checkOrder;
		}
	}
}
