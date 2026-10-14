using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000273 RID: 627
	internal class SecT113R1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001A77 RID: 6775 RVA: 0x0007C9F4 File Offset: 0x0007ABF4
		public SecT113R1Curve() : base(113, 9, 0, 0)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("003088250CA6E7C7FE649CE85820F7")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("00E8BEE4D3E2260744188BE0E9C723")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0100000000000000D9CCEC8A39E56F"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001A78 RID: 6776 RVA: 0x0007CA7B File Offset: 0x0007AC7B
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve();
		}

		// Token: 0x06001A79 RID: 6777 RVA: 0x0007CA82 File Offset: 0x0007AC82
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x1700032B RID: 811
		// (get) Token: 0x06001A7A RID: 6778 RVA: 0x0007CA8B File Offset: 0x0007AC8B
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x1700032C RID: 812
		// (get) Token: 0x06001A7B RID: 6779 RVA: 0x0007CA93 File Offset: 0x0007AC93
		public override int FieldSize
		{
			get
			{
				return 113;
			}
		}

		// Token: 0x06001A7C RID: 6780 RVA: 0x0007CA97 File Offset: 0x0007AC97
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(x);
		}

		// Token: 0x06001A7D RID: 6781 RVA: 0x0007CA9F File Offset: 0x0007AC9F
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001A7E RID: 6782 RVA: 0x0007CAAA File Offset: 0x0007ACAA
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x1700032D RID: 813
		// (get) Token: 0x06001A7F RID: 6783 RVA: 0x0007CAB7 File Offset: 0x0007ACB7
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700032E RID: 814
		// (get) Token: 0x06001A80 RID: 6784 RVA: 0x0007CABA File Offset: 0x0007ACBA
		public virtual int M
		{
			get
			{
				return 113;
			}
		}

		// Token: 0x1700032F RID: 815
		// (get) Token: 0x06001A81 RID: 6785 RVA: 0x0007CABE File Offset: 0x0007ACBE
		public virtual bool IsTrinomial
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000330 RID: 816
		// (get) Token: 0x06001A82 RID: 6786 RVA: 0x0007CAC1 File Offset: 0x0007ACC1
		public virtual int K1
		{
			get
			{
				return 9;
			}
		}

		// Token: 0x17000331 RID: 817
		// (get) Token: 0x06001A83 RID: 6787 RVA: 0x0007CAC5 File Offset: 0x0007ACC5
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000332 RID: 818
		// (get) Token: 0x06001A84 RID: 6788 RVA: 0x0007CAC8 File Offset: 0x0007ACC8
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001A85 RID: 6789 RVA: 0x0007CACC File Offset: 0x0007ACCC
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve.SecT113R1LookupTable(this, table, len);
		}

		// Token: 0x04000A8A RID: 2698
		private const int SECT113R1_DEFAULT_COORDS = 6;

		// Token: 0x04000A8B RID: 2699
		private const int SECT113R1_FE_LONGS = 2;

		// Token: 0x04000A8C RID: 2700
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT113R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A8D RID: 2701
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Point m_infinity;

		// Token: 0x020007E0 RID: 2016
		private class SecT113R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045C4 RID: 17860 RVA: 0x00134B65 File Offset: 0x00132D65
			internal SecT113R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A8E RID: 2702
			// (get) Token: 0x060045C5 RID: 17861 RVA: 0x00134B82 File Offset: 0x00132D82
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045C6 RID: 17862 RVA: 0x00134B8C File Offset: 0x00132D8C
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

			// Token: 0x060045C7 RID: 17863 RVA: 0x00134C18 File Offset: 0x00132E18
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

			// Token: 0x060045C8 RID: 17864 RVA: 0x00134C67 File Offset: 0x00132E67
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve.SECT113R1_AFFINE_ZS, false);
			}

			// Token: 0x04002441 RID: 9281
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT113R1Curve m_outer;

			// Token: 0x04002442 RID: 9282
			private readonly ulong[] m_table;

			// Token: 0x04002443 RID: 9283
			private readonly int m_size;
		}
	}
}
