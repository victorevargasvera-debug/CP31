using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020002A5 RID: 677
	internal class SecT571R1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001E06 RID: 7686 RVA: 0x0008B3AC File Offset: 0x000895AC
		public SecT571R1Curve() : base(571, 2, 5, 10)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_b = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B;
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("03FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE661CE18FF55987308059B186823851EC7DD9CA1161DE93D5174D66E8382E9BB2FE84E47"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001E07 RID: 7687 RVA: 0x0008B41A File Offset: 0x0008961A
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve();
		}

		// Token: 0x06001E08 RID: 7688 RVA: 0x0008B421 File Offset: 0x00089621
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x17000425 RID: 1061
		// (get) Token: 0x06001E09 RID: 7689 RVA: 0x0008B42A File Offset: 0x0008962A
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000426 RID: 1062
		// (get) Token: 0x06001E0A RID: 7690 RVA: 0x0008B432 File Offset: 0x00089632
		public override int FieldSize
		{
			get
			{
				return 571;
			}
		}

		// Token: 0x06001E0B RID: 7691 RVA: 0x0008B439 File Offset: 0x00089639
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(x);
		}

		// Token: 0x06001E0C RID: 7692 RVA: 0x0008B441 File Offset: 0x00089641
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001E0D RID: 7693 RVA: 0x0008B44C File Offset: 0x0008964C
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x17000427 RID: 1063
		// (get) Token: 0x06001E0E RID: 7694 RVA: 0x0008B459 File Offset: 0x00089659
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000428 RID: 1064
		// (get) Token: 0x06001E0F RID: 7695 RVA: 0x0008B45C File Offset: 0x0008965C
		public virtual int M
		{
			get
			{
				return 571;
			}
		}

		// Token: 0x17000429 RID: 1065
		// (get) Token: 0x06001E10 RID: 7696 RVA: 0x0008B463 File Offset: 0x00089663
		public virtual bool IsTrinomial
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700042A RID: 1066
		// (get) Token: 0x06001E11 RID: 7697 RVA: 0x0008B466 File Offset: 0x00089666
		public virtual int K1
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700042B RID: 1067
		// (get) Token: 0x06001E12 RID: 7698 RVA: 0x0008B469 File Offset: 0x00089669
		public virtual int K2
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x1700042C RID: 1068
		// (get) Token: 0x06001E13 RID: 7699 RVA: 0x0008B46C File Offset: 0x0008966C
		public virtual int K3
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x06001E14 RID: 7700 RVA: 0x0008B470 File Offset: 0x00089670
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 9 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat576.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 9;
				global::Org.BouncyCastle.Math.Raw.Nat576.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 9;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1LookupTable(this, table, len);
		}

		// Token: 0x04000AE9 RID: 2793
		private const int SECT571R1_DEFAULT_COORDS = 6;

		// Token: 0x04000AEA RID: 2794
		private const int SECT571R1_FE_LONGS = 9;

		// Token: 0x04000AEB RID: 2795
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT571R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AEC RID: 2796
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Point m_infinity;

		// Token: 0x04000AED RID: 2797
		internal static readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement SecT571R1_B = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("02F40E7E2221F295DE297117B7F3D62F5C6A97FFCB8CEFF1CD6BA8CE4A9A18AD84FFABBD8EFA59332BE7AD6756A66E294AFD185A78FF12AA520E4DE739BACA0C7FFEFF7F2955727A")));

		// Token: 0x04000AEE RID: 2798
		internal static readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement SecT571R1_B_SQRT = (global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SecT571R1_B.Sqrt();

		// Token: 0x020007F1 RID: 2033
		private class SecT571R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x06004619 RID: 17945 RVA: 0x00135E89 File Offset: 0x00134089
			internal SecT571R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A9F RID: 2719
			// (get) Token: 0x0600461A RID: 17946 RVA: 0x00135EA6 File Offset: 0x001340A6
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x0600461B RID: 17947 RVA: 0x00135EB0 File Offset: 0x001340B0
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					ulong MASK = (ulong)((long)((i ^ index) - 1 >> 31));
					for (int j = 0; j < 9; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 9 + j] & MASK);
					}
					pos += 18;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x0600461C RID: 17948 RVA: 0x00135F3C File Offset: 0x0013413C
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				int pos = index * 9 * 2;
				for (int i = 0; i < 9; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 9 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x0600461D RID: 17949 RVA: 0x00135F8E File Offset: 0x0013418E
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve.SECT571R1_AFFINE_ZS, false);
			}

			// Token: 0x04002474 RID: 9332
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571R1Curve m_outer;

			// Token: 0x04002475 RID: 9333
			private readonly ulong[] m_table;

			// Token: 0x04002476 RID: 9334
			private readonly int m_size;
		}
	}
}
