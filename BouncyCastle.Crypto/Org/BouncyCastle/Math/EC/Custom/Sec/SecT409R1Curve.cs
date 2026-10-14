using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200029F RID: 671
	internal class SecT409R1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001D92 RID: 7570 RVA: 0x00089408 File Offset: 0x00087608
		public SecT409R1Curve() : base(409, 87, 0, 0)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0021A5C2C8EE9FEB5C4B9A753B7B476B7FD6422EF1F3DD674761FA99D6AC27C8A9A197B272822F6CD57A55AA4F50AE317B13545F")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("010000000000000000000000000000000000000000000000000001E2AAD6A612F33307BE5FA47C3C9E052F838164CD37D9A21173"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001D93 RID: 7571 RVA: 0x00089487 File Offset: 0x00087687
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Curve();
		}

		// Token: 0x06001D94 RID: 7572 RVA: 0x0008948E File Offset: 0x0008768E
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06001D95 RID: 7573 RVA: 0x00089497 File Offset: 0x00087697
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06001D96 RID: 7574 RVA: 0x0008949F File Offset: 0x0008769F
		public override int FieldSize
		{
			get
			{
				return 409;
			}
		}

		// Token: 0x06001D97 RID: 7575 RVA: 0x000894A6 File Offset: 0x000876A6
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(x);
		}

		// Token: 0x06001D98 RID: 7576 RVA: 0x000894AE File Offset: 0x000876AE
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001D99 RID: 7577 RVA: 0x000894B9 File Offset: 0x000876B9
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06001D9A RID: 7578 RVA: 0x000894C6 File Offset: 0x000876C6
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06001D9B RID: 7579 RVA: 0x000894C9 File Offset: 0x000876C9
		public virtual int M
		{
			get
			{
				return 409;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06001D9C RID: 7580 RVA: 0x000894D0 File Offset: 0x000876D0
		public virtual bool IsTrinomial
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x06001D9D RID: 7581 RVA: 0x000894D3 File Offset: 0x000876D3
		public virtual int K1
		{
			get
			{
				return 87;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x06001D9E RID: 7582 RVA: 0x000894D7 File Offset: 0x000876D7
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x1700040E RID: 1038
		// (get) Token: 0x06001D9F RID: 7583 RVA: 0x000894DA File Offset: 0x000876DA
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001DA0 RID: 7584 RVA: 0x000894E0 File Offset: 0x000876E0
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 7 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat448.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 7;
				global::Org.BouncyCastle.Math.Raw.Nat448.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 7;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Curve.SecT409R1LookupTable(this, table, len);
		}

		// Token: 0x04000ADE RID: 2782
		private const int SECT409R1_DEFAULT_COORDS = 6;

		// Token: 0x04000ADF RID: 2783
		private const int SECT409R1_FE_LONGS = 7;

		// Token: 0x04000AE0 RID: 2784
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT409R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AE1 RID: 2785
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Point m_infinity;

		// Token: 0x020007EF RID: 2031
		private class SecT409R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x0600460F RID: 17935 RVA: 0x00135C46 File Offset: 0x00133E46
			internal SecT409R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A9D RID: 2717
			// (get) Token: 0x06004610 RID: 17936 RVA: 0x00135C63 File Offset: 0x00133E63
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x06004611 RID: 17937 RVA: 0x00135C6C File Offset: 0x00133E6C
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					ulong MASK = (ulong)((long)((i ^ index) - 1 >> 31));
					for (int j = 0; j < 7; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 7 + j] & MASK);
					}
					pos += 14;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004612 RID: 17938 RVA: 0x00135CF8 File Offset: 0x00133EF8
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat448.Create64();
				int pos = index * 7 * 2;
				for (int i = 0; i < 7; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 7 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004613 RID: 17939 RVA: 0x00135D47 File Offset: 0x00133F47
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Curve.SECT409R1_AFFINE_ZS, false);
			}

			// Token: 0x0400246E RID: 9326
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409R1Curve m_outer;

			// Token: 0x0400246F RID: 9327
			private readonly ulong[] m_table;

			// Token: 0x04002470 RID: 9328
			private readonly int m_size;
		}
	}
}
