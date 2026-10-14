using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000299 RID: 665
	internal class SecT283R1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001D24 RID: 7460 RVA: 0x00087634 File Offset: 0x00085834
		public SecT283R1Curve() : base(283, 5, 7, 12)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("027B680AC8B8596DA5A4AF8A19A0303FCA97FD7645309FA2A581485AF6263E313B79A2F5")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("03FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEF90399660FC938A90165B042A7CEFADB307"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001D25 RID: 7461 RVA: 0x000876B3 File Offset: 0x000858B3
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Curve();
		}

		// Token: 0x06001D26 RID: 7462 RVA: 0x000876BA File Offset: 0x000858BA
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x170003E9 RID: 1001
		// (get) Token: 0x06001D27 RID: 7463 RVA: 0x000876C3 File Offset: 0x000858C3
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170003EA RID: 1002
		// (get) Token: 0x06001D28 RID: 7464 RVA: 0x000876CB File Offset: 0x000858CB
		public override int FieldSize
		{
			get
			{
				return 283;
			}
		}

		// Token: 0x06001D29 RID: 7465 RVA: 0x000876D2 File Offset: 0x000858D2
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(x);
		}

		// Token: 0x06001D2A RID: 7466 RVA: 0x000876DA File Offset: 0x000858DA
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001D2B RID: 7467 RVA: 0x000876E5 File Offset: 0x000858E5
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x170003EB RID: 1003
		// (get) Token: 0x06001D2C RID: 7468 RVA: 0x000876F2 File Offset: 0x000858F2
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003EC RID: 1004
		// (get) Token: 0x06001D2D RID: 7469 RVA: 0x000876F5 File Offset: 0x000858F5
		public virtual int M
		{
			get
			{
				return 283;
			}
		}

		// Token: 0x170003ED RID: 1005
		// (get) Token: 0x06001D2E RID: 7470 RVA: 0x000876FC File Offset: 0x000858FC
		public virtual bool IsTrinomial
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003EE RID: 1006
		// (get) Token: 0x06001D2F RID: 7471 RVA: 0x000876FF File Offset: 0x000858FF
		public virtual int K1
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x170003EF RID: 1007
		// (get) Token: 0x06001D30 RID: 7472 RVA: 0x00087702 File Offset: 0x00085902
		public virtual int K2
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x170003F0 RID: 1008
		// (get) Token: 0x06001D31 RID: 7473 RVA: 0x00087705 File Offset: 0x00085905
		public virtual int K3
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x06001D32 RID: 7474 RVA: 0x0008770C File Offset: 0x0008590C
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 5 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat320.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 5;
				global::Org.BouncyCastle.Math.Raw.Nat320.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 5;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Curve.SecT283R1LookupTable(this, table, len);
		}

		// Token: 0x04000AD3 RID: 2771
		private const int SECT283R1_DEFAULT_COORDS = 6;

		// Token: 0x04000AD4 RID: 2772
		private const int SECT283R1_FE_LONGS = 5;

		// Token: 0x04000AD5 RID: 2773
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT283R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AD6 RID: 2774
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Point m_infinity;

		// Token: 0x020007ED RID: 2029
		private class SecT283R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x06004605 RID: 17925 RVA: 0x00135A06 File Offset: 0x00133C06
			internal SecT283R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A9B RID: 2715
			// (get) Token: 0x06004606 RID: 17926 RVA: 0x00135A23 File Offset: 0x00133C23
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x06004607 RID: 17927 RVA: 0x00135A2C File Offset: 0x00133C2C
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					ulong MASK = (ulong)((long)((i ^ index) - 1 >> 31));
					for (int j = 0; j < 5; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 5 + j] & MASK);
					}
					pos += 10;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004608 RID: 17928 RVA: 0x00135AB8 File Offset: 0x00133CB8
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
				int pos = index * 5 * 2;
				for (int i = 0; i < 5; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 5 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004609 RID: 17929 RVA: 0x00135B07 File Offset: 0x00133D07
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Curve.SECT283R1_AFFINE_ZS, false);
			}

			// Token: 0x04002468 RID: 9320
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283R1Curve m_outer;

			// Token: 0x04002469 RID: 9321
			private readonly ulong[] m_table;

			// Token: 0x0400246A RID: 9322
			private readonly int m_size;
		}
	}
}
