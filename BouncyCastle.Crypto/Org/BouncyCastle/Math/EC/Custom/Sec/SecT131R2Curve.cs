using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200027B RID: 635
	internal class SecT131R2Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001AFE RID: 6910 RVA: 0x0007ED20 File Offset: 0x0007CF20
		public SecT131R2Curve() : base(131, 2, 3, 8)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("03E5A88919D7CAFCBF415F07C2176573B2")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("04B8266A46C55657AC734CE38F018F2192")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0400000000000000016954A233049BA98F"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001AFF RID: 6911 RVA: 0x0007EDA9 File Offset: 0x0007CFA9
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Curve();
		}

		// Token: 0x06001B00 RID: 6912 RVA: 0x0007EDB0 File Offset: 0x0007CFB0
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x17000353 RID: 851
		// (get) Token: 0x06001B01 RID: 6913 RVA: 0x0007EDB9 File Offset: 0x0007CFB9
		public override int FieldSize
		{
			get
			{
				return 131;
			}
		}

		// Token: 0x06001B02 RID: 6914 RVA: 0x0007EDC0 File Offset: 0x0007CFC0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(x);
		}

		// Token: 0x06001B03 RID: 6915 RVA: 0x0007EDC8 File Offset: 0x0007CFC8
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point(this, x, y, withCompression);
		}

		// Token: 0x06001B04 RID: 6916 RVA: 0x0007EDD3 File Offset: 0x0007CFD3
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point(this, x, y, zs, withCompression);
		}

		// Token: 0x17000354 RID: 852
		// (get) Token: 0x06001B05 RID: 6917 RVA: 0x0007EDE0 File Offset: 0x0007CFE0
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000355 RID: 853
		// (get) Token: 0x06001B06 RID: 6918 RVA: 0x0007EDE8 File Offset: 0x0007CFE8
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000356 RID: 854
		// (get) Token: 0x06001B07 RID: 6919 RVA: 0x0007EDEB File Offset: 0x0007CFEB
		public virtual int M
		{
			get
			{
				return 131;
			}
		}

		// Token: 0x17000357 RID: 855
		// (get) Token: 0x06001B08 RID: 6920 RVA: 0x0007EDF2 File Offset: 0x0007CFF2
		public virtual bool IsTrinomial
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000358 RID: 856
		// (get) Token: 0x06001B09 RID: 6921 RVA: 0x0007EDF5 File Offset: 0x0007CFF5
		public virtual int K1
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000359 RID: 857
		// (get) Token: 0x06001B0A RID: 6922 RVA: 0x0007EDF8 File Offset: 0x0007CFF8
		public virtual int K2
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x1700035A RID: 858
		// (get) Token: 0x06001B0B RID: 6923 RVA: 0x0007EDFB File Offset: 0x0007CFFB
		public virtual int K3
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x06001B0C RID: 6924 RVA: 0x0007EE00 File Offset: 0x0007D000
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 3 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat192.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 3;
				global::Org.BouncyCastle.Math.Raw.Nat192.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 3;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Curve.SecT131R2LookupTable(this, table, len);
		}

		// Token: 0x04000A9A RID: 2714
		private const int SECT131R2_DEFAULT_COORDS = 6;

		// Token: 0x04000A9B RID: 2715
		private const int SECT131R2_FE_LONGS = 3;

		// Token: 0x04000A9C RID: 2716
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT131R2_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A9D RID: 2717
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Point m_infinity;

		// Token: 0x020007E3 RID: 2019
		private class SecT131R2LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045D3 RID: 17875 RVA: 0x00134EC6 File Offset: 0x001330C6
			internal SecT131R2LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A91 RID: 2705
			// (get) Token: 0x060045D4 RID: 17876 RVA: 0x00134EE3 File Offset: 0x001330E3
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045D5 RID: 17877 RVA: 0x00134EEC File Offset: 0x001330EC
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					ulong MASK = (ulong)((long)((i ^ index) - 1 >> 31));
					for (int j = 0; j < 3; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 3 + j] & MASK);
					}
					pos += 6;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045D6 RID: 17878 RVA: 0x00134F78 File Offset: 0x00133178
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat192.Create64();
				int pos = index * 3 * 2;
				for (int i = 0; i < 3; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 3 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045D7 RID: 17879 RVA: 0x00134FC7 File Offset: 0x001331C7
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Curve.SECT131R2_AFFINE_ZS, false);
			}

			// Token: 0x0400244A RID: 9290
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R2Curve m_outer;

			// Token: 0x0400244B RID: 9291
			private readonly ulong[] m_table;

			// Token: 0x0400244C RID: 9292
			private readonly int m_size;
		}
	}
}
