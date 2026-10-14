using System;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200028D RID: 653
	internal class SecT233K1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001C46 RID: 7238 RVA: 0x00083E10 File Offset: 0x00082010
		public SecT233K1Curve() : base(233, 74, 0, 0)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("8000000000000000000000000000069D5BB915BCD46EFB1AD5F173ABDF"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
			this.m_coord = 6;
		}

		// Token: 0x06001C47 RID: 7239 RVA: 0x00083E86 File Offset: 0x00082086
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Curve();
		}

		// Token: 0x06001C48 RID: 7240 RVA: 0x00083E8D File Offset: 0x0008208D
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x06001C49 RID: 7241 RVA: 0x00083E96 File Offset: 0x00082096
		protected override global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
		}

		// Token: 0x170003AD RID: 941
		// (get) Token: 0x06001C4A RID: 7242 RVA: 0x00083E9D File Offset: 0x0008209D
		public override int FieldSize
		{
			get
			{
				return 233;
			}
		}

		// Token: 0x06001C4B RID: 7243 RVA: 0x00083EA4 File Offset: 0x000820A4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(x);
		}

		// Token: 0x06001C4C RID: 7244 RVA: 0x00083EAC File Offset: 0x000820AC
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(this, x, y, withCompression);
		}

		// Token: 0x06001C4D RID: 7245 RVA: 0x00083EB7 File Offset: 0x000820B7
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x170003AE RID: 942
		// (get) Token: 0x06001C4E RID: 7246 RVA: 0x00083EC4 File Offset: 0x000820C4
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170003AF RID: 943
		// (get) Token: 0x06001C4F RID: 7247 RVA: 0x00083ECC File Offset: 0x000820CC
		public override bool IsKoblitz
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003B0 RID: 944
		// (get) Token: 0x06001C50 RID: 7248 RVA: 0x00083ECF File Offset: 0x000820CF
		public virtual int M
		{
			get
			{
				return 233;
			}
		}

		// Token: 0x170003B1 RID: 945
		// (get) Token: 0x06001C51 RID: 7249 RVA: 0x00083ED6 File Offset: 0x000820D6
		public virtual bool IsTrinomial
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003B2 RID: 946
		// (get) Token: 0x06001C52 RID: 7250 RVA: 0x00083ED9 File Offset: 0x000820D9
		public virtual int K1
		{
			get
			{
				return 74;
			}
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001C53 RID: 7251 RVA: 0x00083EDD File Offset: 0x000820DD
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x06001C54 RID: 7252 RVA: 0x00083EE0 File Offset: 0x000820E0
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C55 RID: 7253 RVA: 0x00083EE4 File Offset: 0x000820E4
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 4 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 4;
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 4;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Curve.SecT233K1LookupTable(this, table, len);
		}

		// Token: 0x04000ABC RID: 2748
		private const int SECT233K1_DEFAULT_COORDS = 6;

		// Token: 0x04000ABD RID: 2749
		private const int SECT233K1_FE_LONGS = 4;

		// Token: 0x04000ABE RID: 2750
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT233K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000ABF RID: 2751
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Point m_infinity;

		// Token: 0x020007E9 RID: 2025
		private class SecT233K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045F1 RID: 17905 RVA: 0x00135586 File Offset: 0x00133786
			internal SecT233K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A97 RID: 2711
			// (get) Token: 0x060045F2 RID: 17906 RVA: 0x001355A3 File Offset: 0x001337A3
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045F3 RID: 17907 RVA: 0x001355AC File Offset: 0x001337AC
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

			// Token: 0x060045F4 RID: 17908 RVA: 0x00135638 File Offset: 0x00133838
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

			// Token: 0x060045F5 RID: 17909 RVA: 0x00135687 File Offset: 0x00133887
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Curve.SECT233K1_AFFINE_ZS, false);
			}

			// Token: 0x0400245C RID: 9308
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233K1Curve m_outer;

			// Token: 0x0400245D RID: 9309
			private readonly ulong[] m_table;

			// Token: 0x0400245E RID: 9310
			private readonly int m_size;
		}
	}
}
