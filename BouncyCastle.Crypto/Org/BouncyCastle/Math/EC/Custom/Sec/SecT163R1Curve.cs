using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000281 RID: 641
	internal class SecT163R1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001B6C RID: 7020 RVA: 0x00080828 File Offset: 0x0007EA28
		public SecT163R1Curve() : base(163, 3, 6, 7)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("07B6882CAAEFA84F9554FF8428BD88E246D2782AE2")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0713612DCDDCB40AAB946BDA29CA91F73AF958AFD9")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("03FFFFFFFFFFFFFFFFFFFF48AAB689C29CA710279B"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001B6D RID: 7021 RVA: 0x000808B1 File Offset: 0x0007EAB1
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Curve();
		}

		// Token: 0x06001B6E RID: 7022 RVA: 0x000808B8 File Offset: 0x0007EAB8
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x17000371 RID: 881
		// (get) Token: 0x06001B6F RID: 7023 RVA: 0x000808C1 File Offset: 0x0007EAC1
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000372 RID: 882
		// (get) Token: 0x06001B70 RID: 7024 RVA: 0x000808C9 File Offset: 0x0007EAC9
		public override int FieldSize
		{
			get
			{
				return 163;
			}
		}

		// Token: 0x06001B71 RID: 7025 RVA: 0x000808D0 File Offset: 0x0007EAD0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(x);
		}

		// Token: 0x06001B72 RID: 7026 RVA: 0x000808D8 File Offset: 0x0007EAD8
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001B73 RID: 7027 RVA: 0x000808E3 File Offset: 0x0007EAE3
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x17000373 RID: 883
		// (get) Token: 0x06001B74 RID: 7028 RVA: 0x000808F0 File Offset: 0x0007EAF0
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000374 RID: 884
		// (get) Token: 0x06001B75 RID: 7029 RVA: 0x000808F3 File Offset: 0x0007EAF3
		public virtual int M
		{
			get
			{
				return 163;
			}
		}

		// Token: 0x17000375 RID: 885
		// (get) Token: 0x06001B76 RID: 7030 RVA: 0x000808FA File Offset: 0x0007EAFA
		public virtual bool IsTrinomial
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000376 RID: 886
		// (get) Token: 0x06001B77 RID: 7031 RVA: 0x000808FD File Offset: 0x0007EAFD
		public virtual int K1
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000377 RID: 887
		// (get) Token: 0x06001B78 RID: 7032 RVA: 0x00080900 File Offset: 0x0007EB00
		public virtual int K2
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17000378 RID: 888
		// (get) Token: 0x06001B79 RID: 7033 RVA: 0x00080903 File Offset: 0x0007EB03
		public virtual int K3
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x06001B7A RID: 7034 RVA: 0x00080908 File Offset: 0x0007EB08
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Curve.SecT163R1LookupTable(this, table, len);
		}

		// Token: 0x04000AA6 RID: 2726
		private const int SECT163R1_DEFAULT_COORDS = 6;

		// Token: 0x04000AA7 RID: 2727
		private const int SECT163R1_FE_LONGS = 3;

		// Token: 0x04000AA8 RID: 2728
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT163R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AA9 RID: 2729
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Point m_infinity;

		// Token: 0x020007E5 RID: 2021
		private class SecT163R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045DD RID: 17885 RVA: 0x00135106 File Offset: 0x00133306
			internal SecT163R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A93 RID: 2707
			// (get) Token: 0x060045DE RID: 17886 RVA: 0x00135123 File Offset: 0x00133323
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045DF RID: 17887 RVA: 0x0013512C File Offset: 0x0013332C
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

			// Token: 0x060045E0 RID: 17888 RVA: 0x001351B8 File Offset: 0x001333B8
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

			// Token: 0x060045E1 RID: 17889 RVA: 0x00135207 File Offset: 0x00133407
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Curve.SECT163R1_AFFINE_ZS, false);
			}

			// Token: 0x04002450 RID: 9296
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R1Curve m_outer;

			// Token: 0x04002451 RID: 9297
			private readonly ulong[] m_table;

			// Token: 0x04002452 RID: 9298
			private readonly int m_size;
		}
	}
}
