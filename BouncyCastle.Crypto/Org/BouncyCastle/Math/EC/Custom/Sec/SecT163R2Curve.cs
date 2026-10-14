using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000283 RID: 643
	internal class SecT163R2Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001B86 RID: 7046 RVA: 0x00080FF8 File Offset: 0x0007F1F8
		public SecT163R2Curve() : base(163, 3, 6, 7)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("020A601907B8C953CA1481EB10512F78744A3205FD")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("040000000000000000000292FE77E70C12A4234C33"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001B87 RID: 7047 RVA: 0x00081076 File Offset: 0x0007F276
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Curve();
		}

		// Token: 0x06001B88 RID: 7048 RVA: 0x0008107D File Offset: 0x0007F27D
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06001B89 RID: 7049 RVA: 0x00081086 File Offset: 0x0007F286
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06001B8A RID: 7050 RVA: 0x0008108E File Offset: 0x0007F28E
		public override int FieldSize
		{
			get
			{
				return 163;
			}
		}

		// Token: 0x06001B8B RID: 7051 RVA: 0x00081095 File Offset: 0x0007F295
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(x);
		}

		// Token: 0x06001B8C RID: 7052 RVA: 0x0008109D File Offset: 0x0007F29D
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Point(this, x, y, withCompression);
		}

		// Token: 0x06001B8D RID: 7053 RVA: 0x000810A8 File Offset: 0x0007F2A8
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Point(this, x, y, zs, withCompression);
		}

		// Token: 0x1700037D RID: 893
		// (get) Token: 0x06001B8E RID: 7054 RVA: 0x000810B5 File Offset: 0x0007F2B5
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700037E RID: 894
		// (get) Token: 0x06001B8F RID: 7055 RVA: 0x000810B8 File Offset: 0x0007F2B8
		public virtual int M
		{
			get
			{
				return 163;
			}
		}

		// Token: 0x1700037F RID: 895
		// (get) Token: 0x06001B90 RID: 7056 RVA: 0x000810BF File Offset: 0x0007F2BF
		public virtual bool IsTrinomial
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000380 RID: 896
		// (get) Token: 0x06001B91 RID: 7057 RVA: 0x000810C2 File Offset: 0x0007F2C2
		public virtual int K1
		{
			get
			{
				return 3;
			}
		}

		// Token: 0x17000381 RID: 897
		// (get) Token: 0x06001B92 RID: 7058 RVA: 0x000810C5 File Offset: 0x0007F2C5
		public virtual int K2
		{
			get
			{
				return 6;
			}
		}

		// Token: 0x17000382 RID: 898
		// (get) Token: 0x06001B93 RID: 7059 RVA: 0x000810C8 File Offset: 0x0007F2C8
		public virtual int K3
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x06001B94 RID: 7060 RVA: 0x000810CC File Offset: 0x0007F2CC
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Curve.SecT163R2LookupTable(this, table, len);
		}

		// Token: 0x04000AAA RID: 2730
		private const int SECT163R2_DEFAULT_COORDS = 6;

		// Token: 0x04000AAB RID: 2731
		private const int SECT163R2_FE_LONGS = 3;

		// Token: 0x04000AAC RID: 2732
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT163R2_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AAD RID: 2733
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Point m_infinity;

		// Token: 0x020007E6 RID: 2022
		private class SecT163R2LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045E2 RID: 17890 RVA: 0x00135226 File Offset: 0x00133426
			internal SecT163R2LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A94 RID: 2708
			// (get) Token: 0x060045E3 RID: 17891 RVA: 0x00135243 File Offset: 0x00133443
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045E4 RID: 17892 RVA: 0x0013524C File Offset: 0x0013344C
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

			// Token: 0x060045E5 RID: 17893 RVA: 0x001352D8 File Offset: 0x001334D8
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

			// Token: 0x060045E6 RID: 17894 RVA: 0x00135327 File Offset: 0x00133527
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Curve.SECT163R2_AFFINE_ZS, false);
			}

			// Token: 0x04002453 RID: 9299
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT163R2Curve m_outer;

			// Token: 0x04002454 RID: 9300
			private readonly ulong[] m_table;

			// Token: 0x04002455 RID: 9301
			private readonly int m_size;
		}
	}
}
