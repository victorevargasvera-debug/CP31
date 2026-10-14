using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000275 RID: 629
	internal class SecT113R2Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001A91 RID: 6801 RVA: 0x0007D1BC File Offset: 0x0007B3BC
		public SecT113R2Curve() : base(113, 9, 0, 0)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("00689918DBEC7E5A0DD6DFC0AA55C7")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0095E9A9EC9B297BD4BF36E059184F")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("010000000000000108789B2496AF93"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001A92 RID: 6802 RVA: 0x0007D243 File Offset: 0x0007B443
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve();
		}

		// Token: 0x06001A93 RID: 6803 RVA: 0x0007D24A File Offset: 0x0007B44A
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x17000335 RID: 821
		// (get) Token: 0x06001A94 RID: 6804 RVA: 0x0007D253 File Offset: 0x0007B453
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000336 RID: 822
		// (get) Token: 0x06001A95 RID: 6805 RVA: 0x0007D25B File Offset: 0x0007B45B
		public override int FieldSize
		{
			get
			{
				return 113;
			}
		}

		// Token: 0x06001A96 RID: 6806 RVA: 0x0007D25F File Offset: 0x0007B45F
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(x);
		}

		// Token: 0x06001A97 RID: 6807 RVA: 0x0007D267 File Offset: 0x0007B467
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Point(this, x, y, withCompression);
		}

		// Token: 0x06001A98 RID: 6808 RVA: 0x0007D272 File Offset: 0x0007B472
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Point(this, x, y, zs, withCompression);
		}

		// Token: 0x17000337 RID: 823
		// (get) Token: 0x06001A99 RID: 6809 RVA: 0x0007D27F File Offset: 0x0007B47F
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000338 RID: 824
		// (get) Token: 0x06001A9A RID: 6810 RVA: 0x0007D282 File Offset: 0x0007B482
		public virtual int M
		{
			get
			{
				return 113;
			}
		}

		// Token: 0x17000339 RID: 825
		// (get) Token: 0x06001A9B RID: 6811 RVA: 0x0007D286 File Offset: 0x0007B486
		public virtual bool IsTrinomial
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700033A RID: 826
		// (get) Token: 0x06001A9C RID: 6812 RVA: 0x0007D289 File Offset: 0x0007B489
		public virtual int K1
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x1700033B RID: 827
		// (get) Token: 0x06001A9D RID: 6813 RVA: 0x0007D28D File Offset: 0x0007B48D
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700033C RID: 828
		// (get) Token: 0x06001A9E RID: 6814 RVA: 0x0007D290 File Offset: 0x0007B490
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A9F RID: 6815 RVA: 0x0007D294 File Offset: 0x0007B494
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 2 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat128.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 2;
				global::Org.BouncyCastle.Math.Raw.Nat128.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 2;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve.SecT113R2LookupTable(this, table, len);
		}

		// Token: 0x04000A8E RID: 2702
		private const int SECT113R2_DEFAULT_COORDS = 6;

		// Token: 0x04000A8F RID: 2703
		private const int SECT113R2_FE_LONGS = 2;

		// Token: 0x04000A90 RID: 2704
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT113R2_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A91 RID: 2705
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Point m_infinity;

		// Token: 0x020007E1 RID: 2017
		private class SecT113R2LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045C9 RID: 17865 RVA: 0x00134C86 File Offset: 0x00132E86
			internal SecT113R2LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A8F RID: 2703
			// (get) Token: 0x060045CA RID: 17866 RVA: 0x00134CA3 File Offset: 0x00132EA3
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045CB RID: 17867 RVA: 0x00134CAC File Offset: 0x00132EAC
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					ulong MASK = (ulong)((long)((i ^ index) - 1 >> 31));
					for (int j = 0; j < 2; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 2 + j] & MASK);
					}
					pos += 4;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045CC RID: 17868 RVA: 0x00134D38 File Offset: 0x00132F38
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat128.Create64();
				int pos = index * 2 * 2;
				for (int i = 0; i < 2; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 2 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045CD RID: 17869 RVA: 0x00134D87 File Offset: 0x00132F87
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve.SECT113R2_AFFINE_ZS, false);
			}

			// Token: 0x04002444 RID: 9284
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R2Curve m_outer;

			// Token: 0x04002445 RID: 9285
			private readonly ulong[] m_table;

			// Token: 0x04002446 RID: 9286
			private readonly int m_size;
		}
	}
}
