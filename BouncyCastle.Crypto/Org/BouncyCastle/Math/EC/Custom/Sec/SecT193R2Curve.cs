using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000289 RID: 649
	internal class SecT193R2Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001BF3 RID: 7155 RVA: 0x00082A4C File Offset: 0x00080C4C
		public SecT193R2Curve() : base(193, 15, 0, 0)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0163F35A5137C2CE3EA6ED8667190B0BC43ECD69977702709B")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("00C9BB9E8927D4D64C377E2AB2856A5B16E3EFB7F61D4316AE")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("010000000000000000000000015AAB561B005413CCD4EE99D5"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001BF4 RID: 7156 RVA: 0x00082AD6 File Offset: 0x00080CD6
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Curve();
		}

		// Token: 0x06001BF5 RID: 7157 RVA: 0x00082ADD File Offset: 0x00080CDD
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x17000399 RID: 921
		// (get) Token: 0x06001BF6 RID: 7158 RVA: 0x00082AE6 File Offset: 0x00080CE6
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x1700039A RID: 922
		// (get) Token: 0x06001BF7 RID: 7159 RVA: 0x00082AEE File Offset: 0x00080CEE
		public override int FieldSize
		{
			get
			{
				return 193;
			}
		}

		// Token: 0x06001BF8 RID: 7160 RVA: 0x00082AF5 File Offset: 0x00080CF5
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(x);
		}

		// Token: 0x06001BF9 RID: 7161 RVA: 0x00082AFD File Offset: 0x00080CFD
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point(this, x, y, withCompression);
		}

		// Token: 0x06001BFA RID: 7162 RVA: 0x00082B08 File Offset: 0x00080D08
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point(this, x, y, zs, withCompression);
		}

		// Token: 0x1700039B RID: 923
		// (get) Token: 0x06001BFB RID: 7163 RVA: 0x00082B15 File Offset: 0x00080D15
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700039C RID: 924
		// (get) Token: 0x06001BFC RID: 7164 RVA: 0x00082B18 File Offset: 0x00080D18
		public virtual int M
		{
			get
			{
				return 193;
			}
		}

		// Token: 0x1700039D RID: 925
		// (get) Token: 0x06001BFD RID: 7165 RVA: 0x00082B1F File Offset: 0x00080D1F
		public virtual bool IsTrinomial
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700039E RID: 926
		// (get) Token: 0x06001BFE RID: 7166 RVA: 0x00082B22 File Offset: 0x00080D22
		public virtual int K1
		{
			get
			{
				return 15;
			}
		}

		// Token: 0x1700039F RID: 927
		// (get) Token: 0x06001BFF RID: 7167 RVA: 0x00082B26 File Offset: 0x00080D26
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170003A0 RID: 928
		// (get) Token: 0x06001C00 RID: 7168 RVA: 0x00082B29 File Offset: 0x00080D29
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C01 RID: 7169 RVA: 0x00082B2C File Offset: 0x00080D2C
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 4 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 4;
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 4;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Curve.SecT193R2LookupTable(this, table, len);
		}

		// Token: 0x04000AB5 RID: 2741
		private const int SECT193R2_DEFAULT_COORDS = 6;

		// Token: 0x04000AB6 RID: 2742
		private const int SECT193R2_FE_LONGS = 4;

		// Token: 0x04000AB7 RID: 2743
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT193R2_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AB8 RID: 2744
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Point m_infinity;

		// Token: 0x020007E8 RID: 2024
		private class SecT193R2LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045EC RID: 17900 RVA: 0x00135466 File Offset: 0x00133666
			internal SecT193R2LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A96 RID: 2710
			// (get) Token: 0x060045ED RID: 17901 RVA: 0x00135483 File Offset: 0x00133683
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045EE RID: 17902 RVA: 0x0013548C File Offset: 0x0013368C
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					ulong MASK = (ulong)((long)((i ^ index) - 1 >> 31));
					for (int j = 0; j < 4; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 4 + j] & MASK);
					}
					pos += 8;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045EF RID: 17903 RVA: 0x00135518 File Offset: 0x00133718
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
				int pos = index * 4 * 2;
				for (int i = 0; i < 4; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 4 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045F0 RID: 17904 RVA: 0x00135567 File Offset: 0x00133767
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Curve.SECT193R2_AFFINE_ZS, false);
			}

			// Token: 0x04002459 RID: 9305
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R2Curve m_outer;

			// Token: 0x0400245A RID: 9306
			private readonly ulong[] m_table;

			// Token: 0x0400245B RID: 9307
			private readonly int m_size;
		}
	}
}
