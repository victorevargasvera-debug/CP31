using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000279 RID: 633
	internal class SecT131R1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001AE4 RID: 6884 RVA: 0x0007E550 File Offset: 0x0007C750
		public SecT131R1Curve() : base(131, 2, 3, 8)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("07A11B09A76B562144418FF3FF8C2570B8")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0217C05610884B63B9C6C7291678F9D341")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0400000000000000023123953A9464B54D"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001AE5 RID: 6885 RVA: 0x0007E5D9 File Offset: 0x0007C7D9
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Curve();
		}

		// Token: 0x06001AE6 RID: 6886 RVA: 0x0007E5E0 File Offset: 0x0007C7E0
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001AE7 RID: 6887 RVA: 0x0007E5E9 File Offset: 0x0007C7E9
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001AE8 RID: 6888 RVA: 0x0007E5F1 File Offset: 0x0007C7F1
		public override int FieldSize
		{
			get
			{
				return 131;
			}
		}

		// Token: 0x06001AE9 RID: 6889 RVA: 0x0007E5F8 File Offset: 0x0007C7F8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(x);
		}

		// Token: 0x06001AEA RID: 6890 RVA: 0x0007E600 File Offset: 0x0007C800
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001AEB RID: 6891 RVA: 0x0007E60B File Offset: 0x0007C80B
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001AEC RID: 6892 RVA: 0x0007E618 File Offset: 0x0007C818
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700034C RID: 844
		// (get) Token: 0x06001AED RID: 6893 RVA: 0x0007E61B File Offset: 0x0007C81B
		public virtual int M
		{
			get
			{
				return 131;
			}
		}

		// Token: 0x1700034D RID: 845
		// (get) Token: 0x06001AEE RID: 6894 RVA: 0x0007E622 File Offset: 0x0007C822
		public virtual bool IsTrinomial
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700034E RID: 846
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0007E625 File Offset: 0x0007C825
		public virtual int K1
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x1700034F RID: 847
		// (get) Token: 0x06001AF0 RID: 6896 RVA: 0x0007E628 File Offset: 0x0007C828
		public virtual int K2
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000350 RID: 848
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0007E62B File Offset: 0x0007C82B
		public virtual int K3
		{
			get
			{
				return 8;
			}
		}

		// Token: 0x06001AF2 RID: 6898 RVA: 0x0007E630 File Offset: 0x0007C830
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Curve.SecT131R1LookupTable(this, table, len);
		}

		// Token: 0x04000A96 RID: 2710
		private const int SECT131R1_DEFAULT_COORDS = 6;

		// Token: 0x04000A97 RID: 2711
		private const int SECT131R1_FE_LONGS = 3;

		// Token: 0x04000A98 RID: 2712
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT131R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A99 RID: 2713
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Point m_infinity;

		// Token: 0x020007E2 RID: 2018
		private class SecT131R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045CE RID: 17870 RVA: 0x00134DA6 File Offset: 0x00132FA6
			internal SecT131R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A90 RID: 2704
			// (get) Token: 0x060045CF RID: 17871 RVA: 0x00134DC3 File Offset: 0x00132FC3
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045D0 RID: 17872 RVA: 0x00134DCC File Offset: 0x00132FCC
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

			// Token: 0x060045D1 RID: 17873 RVA: 0x00134E58 File Offset: 0x00133058
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

			// Token: 0x060045D2 RID: 17874 RVA: 0x00134EA7 File Offset: 0x001330A7
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Curve.SECT131R1_AFFINE_ZS, false);
			}

			// Token: 0x04002447 RID: 9287
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT131R1Curve m_outer;

			// Token: 0x04002448 RID: 9288
			private readonly ulong[] m_table;

			// Token: 0x04002449 RID: 9289
			private readonly int m_size;
		}
	}
}
