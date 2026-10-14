using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000287 RID: 647
	internal class SecT193R1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001BD9 RID: 7129 RVA: 0x0008227C File Offset: 0x0008047C
		public SecT193R1Curve() : base(193, 15, 0, 0)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0017858FEB7A98975169E171F77B4087DE098AC8A911DF7B01")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("00FDFB49BFE6C3A89FACADAA7A1E5BBC7CC1C2E5D831478814")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("01000000000000000000000000C7F34A778F443ACC920EBA49"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001BDA RID: 7130 RVA: 0x00082306 File Offset: 0x00080506
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Curve();
		}

		// Token: 0x06001BDB RID: 7131 RVA: 0x0008230D File Offset: 0x0008050D
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x1700038F RID: 911
		// (get) Token: 0x06001BDC RID: 7132 RVA: 0x00082316 File Offset: 0x00080516
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000390 RID: 912
		// (get) Token: 0x06001BDD RID: 7133 RVA: 0x0008231E File Offset: 0x0008051E
		public override int FieldSize
		{
			get
			{
				return 193;
			}
		}

		// Token: 0x06001BDE RID: 7134 RVA: 0x00082325 File Offset: 0x00080525
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(x);
		}

		// Token: 0x06001BDF RID: 7135 RVA: 0x0008232D File Offset: 0x0008052D
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001BE0 RID: 7136 RVA: 0x00082338 File Offset: 0x00080538
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x17000391 RID: 913
		// (get) Token: 0x06001BE1 RID: 7137 RVA: 0x00082345 File Offset: 0x00080545
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000392 RID: 914
		// (get) Token: 0x06001BE2 RID: 7138 RVA: 0x00082348 File Offset: 0x00080548
		public virtual int M
		{
			get
			{
				return 193;
			}
		}

		// Token: 0x17000393 RID: 915
		// (get) Token: 0x06001BE3 RID: 7139 RVA: 0x0008234F File Offset: 0x0008054F
		public virtual bool IsTrinomial
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000394 RID: 916
		// (get) Token: 0x06001BE4 RID: 7140 RVA: 0x00082352 File Offset: 0x00080552
		public virtual int K1
		{
			get
			{
				return 15;
			}
		}

		// Token: 0x17000395 RID: 917
		// (get) Token: 0x06001BE5 RID: 7141 RVA: 0x00082356 File Offset: 0x00080556
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x06001BE6 RID: 7142 RVA: 0x00082359 File Offset: 0x00080559
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001BE7 RID: 7143 RVA: 0x0008235C File Offset: 0x0008055C
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Curve.SecT193R1LookupTable(this, table, len);
		}

		// Token: 0x04000AB1 RID: 2737
		private const int SECT193R1_DEFAULT_COORDS = 6;

		// Token: 0x04000AB2 RID: 2738
		private const int SECT193R1_FE_LONGS = 4;

		// Token: 0x04000AB3 RID: 2739
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT193R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AB4 RID: 2740
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Point m_infinity;

		// Token: 0x020007E7 RID: 2023
		private class SecT193R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045E7 RID: 17895 RVA: 0x00135346 File Offset: 0x00133546
			internal SecT193R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A95 RID: 2709
			// (get) Token: 0x060045E8 RID: 17896 RVA: 0x00135363 File Offset: 0x00133563
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045E9 RID: 17897 RVA: 0x0013536C File Offset: 0x0013356C
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

			// Token: 0x060045EA RID: 17898 RVA: 0x001353F8 File Offset: 0x001335F8
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

			// Token: 0x060045EB RID: 17899 RVA: 0x00135447 File Offset: 0x00133647
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Curve.SECT193R1_AFFINE_ZS, false);
			}

			// Token: 0x04002456 RID: 9302
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT193R1Curve m_outer;

			// Token: 0x04002457 RID: 9303
			private readonly ulong[] m_table;

			// Token: 0x04002458 RID: 9304
			private readonly int m_size;
		}
	}
}
