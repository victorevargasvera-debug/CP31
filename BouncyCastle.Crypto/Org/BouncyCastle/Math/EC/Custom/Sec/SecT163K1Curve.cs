using System;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200027F RID: 639
	internal class SecT163K1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001B51 RID: 6993 RVA: 0x000800B4 File Offset: 0x0007E2B4
		public SecT163K1Curve() : base(163, 3, 6, 7)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_b = this.m_a;
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("04000000000000000000020108A2E0CC0D99F8A5EF"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001B52 RID: 6994 RVA: 0x00080122 File Offset: 0x0007E322
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Curve();
		}

		// Token: 0x06001B53 RID: 6995 RVA: 0x00080129 File Offset: 0x0007E329
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x06001B54 RID: 6996 RVA: 0x00080132 File Offset: 0x0007E332
		protected override global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
		}

		// Token: 0x17000367 RID: 871
		// (get) Token: 0x06001B55 RID: 6997 RVA: 0x00080139 File Offset: 0x0007E339
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000368 RID: 872
		// (get) Token: 0x06001B56 RID: 6998 RVA: 0x00080141 File Offset: 0x0007E341
		public override int FieldSize
		{
			get
			{
				return 163;
			}
		}

		// Token: 0x06001B57 RID: 6999 RVA: 0x00080148 File Offset: 0x0007E348
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(x);
		}

		// Token: 0x06001B58 RID: 7000 RVA: 0x00080150 File Offset: 0x0007E350
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point(this, x, y, withCompression);
		}

		// Token: 0x06001B59 RID: 7001 RVA: 0x0008015B File Offset: 0x0007E35B
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x17000369 RID: 873
		// (get) Token: 0x06001B5A RID: 7002 RVA: 0x00080168 File Offset: 0x0007E368
		public override bool IsKoblitz
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700036A RID: 874
		// (get) Token: 0x06001B5B RID: 7003 RVA: 0x0008016B File Offset: 0x0007E36B
		public virtual int M
		{
			get
			{
				return 163;
			}
		}

		// Token: 0x1700036B RID: 875
		// (get) Token: 0x06001B5C RID: 7004 RVA: 0x00080172 File Offset: 0x0007E372
		public virtual bool IsTrinomial
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700036C RID: 876
		// (get) Token: 0x06001B5D RID: 7005 RVA: 0x00080175 File Offset: 0x0007E375
		public virtual int K1
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x1700036D RID: 877
		// (get) Token: 0x06001B5E RID: 7006 RVA: 0x00080178 File Offset: 0x0007E378
		public virtual int K2
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x1700036E RID: 878
		// (get) Token: 0x06001B5F RID: 7007 RVA: 0x0008017B File Offset: 0x0007E37B
		public virtual int K3
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x06001B60 RID: 7008 RVA: 0x00080180 File Offset: 0x0007E380
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 3 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat192.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 3;
				global::Org.BouncyCastle.Math.Raw.Nat192.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 3;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Curve.SecT163K1LookupTable(this, table, len);
		}

		// Token: 0x04000AA2 RID: 2722
		private const int SECT163K1_DEFAULT_COORDS = 6;

		// Token: 0x04000AA3 RID: 2723
		private const int SECT163K1_FE_LONGS = 3;

		// Token: 0x04000AA4 RID: 2724
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT163K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AA5 RID: 2725
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Point m_infinity;

		// Token: 0x020007E4 RID: 2020
		private class SecT163K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045D8 RID: 17880 RVA: 0x00134FE6 File Offset: 0x001331E6
			internal SecT163K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A92 RID: 2706
			// (get) Token: 0x060045D9 RID: 17881 RVA: 0x00135003 File Offset: 0x00133203
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045DA RID: 17882 RVA: 0x0013500C File Offset: 0x0013320C
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

			// Token: 0x060045DB RID: 17883 RVA: 0x00135098 File Offset: 0x00133298
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

			// Token: 0x060045DC RID: 17884 RVA: 0x001350E7 File Offset: 0x001332E7
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Curve.SECT163K1_AFFINE_ZS, false);
			}

			// Token: 0x0400244D RID: 9293
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163K1Curve m_outer;

			// Token: 0x0400244E RID: 9294
			private readonly ulong[] m_table;

			// Token: 0x0400244F RID: 9295
			private readonly int m_size;
		}
	}
}
