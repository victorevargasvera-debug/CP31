using System;
using Org.BouncyCastle.Math.EC.Multiplier;

namespace Org.BouncyCastle.Math.EC
{
	// Token: 0x0200020A RID: 522
	public class F2mCurve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x0600149A RID: 5274 RVA: 0x0006115C File Offset: 0x0005F35C
		[global::System.Obsolete("Use constructor taking order/cofactor")]
		public F2mCurve(int m, int k, global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b) : this(m, k, 0, 0, a, b, null, null)
		{
		}

		// Token: 0x0600149B RID: 5275 RVA: 0x00061178 File Offset: 0x0005F378
		public F2mCurve(int m, int k, global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b, global::Org.BouncyCastle.Math.BigInteger order, global::Org.BouncyCastle.Math.BigInteger cofactor) : this(m, k, 0, 0, a, b, order, cofactor)
		{
		}

		// Token: 0x0600149C RID: 5276 RVA: 0x00061198 File Offset: 0x0005F398
		[global::System.Obsolete("Use constructor taking order/cofactor")]
		public F2mCurve(int m, int k1, int k2, int k3, global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b) : this(m, k1, k2, k3, a, b, null, null)
		{
		}

		// Token: 0x0600149D RID: 5277 RVA: 0x000611B8 File Offset: 0x0005F3B8
		public F2mCurve(int m, int k1, int k2, int k3, global::Org.BouncyCastle.Math.BigInteger a, global::Org.BouncyCastle.Math.BigInteger b, global::Org.BouncyCastle.Math.BigInteger order, global::Org.BouncyCastle.Math.BigInteger cofactor) : base(m, k1, k2, k3)
		{
			this.m = m;
			this.k1 = k1;
			this.k2 = k2;
			this.k3 = k3;
			this.m_order = order;
			this.m_cofactor = cofactor;
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.F2mPoint(this, null, null, false);
			if (k1 == 0)
			{
				throw new global::System.ArgumentException("k1 must be > 0");
			}
			if (k2 == 0)
			{
				if (k3 != 0)
				{
					throw new global::System.ArgumentException("k3 must be 0 if k2 == 0");
				}
			}
			else
			{
				if (k2 <= k1)
				{
					throw new global::System.ArgumentException("k2 must be > k1");
				}
				if (k3 <= k2)
				{
					throw new global::System.ArgumentException("k3 must be > k2");
				}
			}
			this.m_a = this.FromBigInteger(a);
			this.m_b = this.FromBigInteger(b);
			this.m_coord = 6;
		}

		// Token: 0x0600149E RID: 5278 RVA: 0x00061270 File Offset: 0x0005F470
		protected F2mCurve(int m, int k1, int k2, int k3, global::Org.BouncyCastle.Math.EC.ECFieldElement a, global::Org.BouncyCastle.Math.EC.ECFieldElement b, global::Org.BouncyCastle.Math.BigInteger order, global::Org.BouncyCastle.Math.BigInteger cofactor) : base(m, k1, k2, k3)
		{
			this.m = m;
			this.k1 = k1;
			this.k2 = k2;
			this.k3 = k3;
			this.m_order = order;
			this.m_cofactor = cofactor;
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.F2mPoint(this, null, null, false);
			this.m_a = a;
			this.m_b = b;
			this.m_coord = 6;
		}

		// Token: 0x0600149F RID: 5279 RVA: 0x000612DB File Offset: 0x0005F4DB
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.F2mCurve(this.m, this.k1, this.k2, this.k3, this.m_a, this.m_b, this.m_order, this.m_cofactor);
		}

		// Token: 0x060014A0 RID: 5280 RVA: 0x00061312 File Offset: 0x0005F512
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord <= 1 || coord == 6;
		}

		// Token: 0x060014A1 RID: 5281 RVA: 0x0006131F File Offset: 0x0005F51F
		protected override global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
		{
			if (this.IsKoblitz)
			{
				return new global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
			}
			return base.CreateDefaultMultiplier();
		}

		// Token: 0x17000281 RID: 641
		// (get) Token: 0x060014A2 RID: 5282 RVA: 0x00061335 File Offset: 0x0005F535
		public override int FieldSize
		{
			get
			{
				return this.m;
			}
		}

		// Token: 0x060014A3 RID: 5283 RVA: 0x0006133D File Offset: 0x0005F53D
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.F2mFieldElement(this.m, this.k1, this.k2, this.k3, x);
		}

		// Token: 0x060014A4 RID: 5284 RVA: 0x0006135D File Offset: 0x0005F55D
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.F2mPoint(this, x, y, withCompression);
		}

		// Token: 0x060014A5 RID: 5285 RVA: 0x00061368 File Offset: 0x0005F568
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.F2mPoint(this, x, y, zs, withCompression);
		}

		// Token: 0x17000282 RID: 642
		// (get) Token: 0x060014A6 RID: 5286 RVA: 0x00061375 File Offset: 0x0005F575
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000283 RID: 643
		// (get) Token: 0x060014A7 RID: 5287 RVA: 0x0006137D File Offset: 0x0005F57D
		public int M
		{
			get
			{
				return this.m;
			}
		}

		// Token: 0x060014A8 RID: 5288 RVA: 0x00061385 File Offset: 0x0005F585
		public bool IsTrinomial()
		{
			return this.k2 == 0 && this.k3 == 0;
		}

		// Token: 0x17000284 RID: 644
		// (get) Token: 0x060014A9 RID: 5289 RVA: 0x0006139A File Offset: 0x0005F59A
		public int K1
		{
			get
			{
				return this.k1;
			}
		}

		// Token: 0x17000285 RID: 645
		// (get) Token: 0x060014AA RID: 5290 RVA: 0x000613A2 File Offset: 0x0005F5A2
		public int K2
		{
			get
			{
				return this.k2;
			}
		}

		// Token: 0x17000286 RID: 646
		// (get) Token: 0x060014AB RID: 5291 RVA: 0x000613AA File Offset: 0x0005F5AA
		public int K3
		{
			get
			{
				return this.k3;
			}
		}

		// Token: 0x060014AC RID: 5292 RVA: 0x000613B4 File Offset: 0x0005F5B4
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			int FE_LONGS = (this.m + 63) / 64;
			long[] table = new long[len * FE_LONGS * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				((global::Org.BouncyCastle.Math.EC.F2mFieldElement)ecpoint.RawXCoord).x.CopyTo(table, pos);
				pos += FE_LONGS;
				((global::Org.BouncyCastle.Math.EC.F2mFieldElement)ecpoint.RawYCoord).x.CopyTo(table, pos);
				pos += FE_LONGS;
			}
			return new global::Org.BouncyCastle.Math.EC.F2mCurve.DefaultF2mLookupTable(this, table, len);
		}

		// Token: 0x04000950 RID: 2384
		private const int F2M_DEFAULT_COORDS = 6;

		// Token: 0x04000951 RID: 2385
		private readonly int m;

		// Token: 0x04000952 RID: 2386
		private readonly int k1;

		// Token: 0x04000953 RID: 2387
		private readonly int k2;

		// Token: 0x04000954 RID: 2388
		private readonly int k3;

		// Token: 0x04000955 RID: 2389
		protected readonly global::Org.BouncyCastle.Math.EC.F2mPoint m_infinity;

		// Token: 0x020007BF RID: 1983
		private class DefaultF2mLookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x06004562 RID: 17762 RVA: 0x00133225 File Offset: 0x00131425
			internal DefaultF2mLookupTable(global::Org.BouncyCastle.Math.EC.F2mCurve outer, long[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A81 RID: 2689
			// (get) Token: 0x06004563 RID: 17763 RVA: 0x00133242 File Offset: 0x00131442
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x06004564 RID: 17764 RVA: 0x0013324C File Offset: 0x0013144C
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				int FE_LONGS = (this.m_outer.m + 63) / 64;
				long[] x = new long[FE_LONGS];
				long[] y = new long[FE_LONGS];
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					long MASK = (long)((i ^ index) - 1 >> 31);
					for (int j = 0; j < FE_LONGS; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + FE_LONGS + j] & MASK);
					}
					pos += FE_LONGS * 2;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004565 RID: 17765 RVA: 0x001332F0 File Offset: 0x001314F0
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				int FE_LONGS = (this.m_outer.m + 63) / 64;
				long[] x = new long[FE_LONGS];
				long[] y = new long[FE_LONGS];
				int pos = index * FE_LONGS * 2;
				for (int i = 0; i < FE_LONGS; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + FE_LONGS + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004566 RID: 17766 RVA: 0x0013335C File Offset: 0x0013155C
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(long[] x, long[] y)
			{
				int i = this.m_outer.m;
				int[] array2;
				if (!this.m_outer.IsTrinomial())
				{
					int[] array = new int[3];
					array[0] = this.m_outer.k1;
					array[1] = this.m_outer.k2;
					array2 = array;
					array[2] = this.m_outer.k3;
				}
				else
				{
					(array2 = new int[1])[0] = this.m_outer.k1;
				}
				int[] ks = array2;
				global::Org.BouncyCastle.Math.EC.ECFieldElement X = new global::Org.BouncyCastle.Math.EC.F2mFieldElement(i, ks, new global::Org.BouncyCastle.Math.EC.LongArray(x));
				global::Org.BouncyCastle.Math.EC.ECFieldElement Y = new global::Org.BouncyCastle.Math.EC.F2mFieldElement(i, ks, new global::Org.BouncyCastle.Math.EC.LongArray(y));
				return this.m_outer.CreateRawPoint(X, Y, false);
			}

			// Token: 0x040023EC RID: 9196
			private readonly global::Org.BouncyCastle.Math.EC.F2mCurve m_outer;

			// Token: 0x040023ED RID: 9197
			private readonly long[] m_table;

			// Token: 0x040023EE RID: 9198
			private readonly int m_size;
		}
	}
}
