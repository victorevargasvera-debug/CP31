using System;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200029D RID: 669
	internal class SecT409K1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001D77 RID: 7543 RVA: 0x00088C78 File Offset: 0x00086E78
		public SecT409K1Curve() : base(409, 87, 0, 0)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("7FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE5F83B2D4EA20400EC4557D5ED3E3E7CA5B4B5C83B8E01E5FCF"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
			this.m_coord = 6;
		}

		// Token: 0x06001D78 RID: 7544 RVA: 0x00088CEE File Offset: 0x00086EEE
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve();
		}

		// Token: 0x06001D79 RID: 7545 RVA: 0x00088CF5 File Offset: 0x00086EF5
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x06001D7A RID: 7546 RVA: 0x00088CFE File Offset: 0x00086EFE
		protected override global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x06001D7B RID: 7547 RVA: 0x00088D05 File Offset: 0x00086F05
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06001D7C RID: 7548 RVA: 0x00088D0D File Offset: 0x00086F0D
		public override int FieldSize
		{
			get
			{
				return 409;
			}
		}

		// Token: 0x06001D7D RID: 7549 RVA: 0x00088D14 File Offset: 0x00086F14
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(x);
		}

		// Token: 0x06001D7E RID: 7550 RVA: 0x00088D1C File Offset: 0x00086F1C
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Point(this, x, y, withCompression);
		}

		// Token: 0x06001D7F RID: 7551 RVA: 0x00088D27 File Offset: 0x00086F27
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06001D80 RID: 7552 RVA: 0x00088D34 File Offset: 0x00086F34
		public override bool IsKoblitz
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06001D81 RID: 7553 RVA: 0x00088D37 File Offset: 0x00086F37
		public virtual int M
		{
			get
			{
				return 409;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x06001D82 RID: 7554 RVA: 0x00088D3E File Offset: 0x00086F3E
		public virtual bool IsTrinomial
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x06001D83 RID: 7555 RVA: 0x00088D41 File Offset: 0x00086F41
		public virtual int K1
		{
			get
			{
				return 87;
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06001D84 RID: 7556 RVA: 0x00088D45 File Offset: 0x00086F45
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06001D85 RID: 7557 RVA: 0x00088D48 File Offset: 0x00086F48
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001D86 RID: 7558 RVA: 0x00088D4C File Offset: 0x00086F4C
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve.SecT409K1LookupTable(this, table, len);
		}

		// Token: 0x04000ADA RID: 2778
		private const int SECT409K1_DEFAULT_COORDS = 6;

		// Token: 0x04000ADB RID: 2779
		private const int SECT409K1_FE_LONGS = 7;

		// Token: 0x04000ADC RID: 2780
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT409K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000ADD RID: 2781
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Point m_infinity;

		// Token: 0x020007EE RID: 2030
		private class SecT409K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x0600460A RID: 17930 RVA: 0x00135B26 File Offset: 0x00133D26
			internal SecT409K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A9C RID: 2716
			// (get) Token: 0x0600460B RID: 17931 RVA: 0x00135B43 File Offset: 0x00133D43
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x0600460C RID: 17932 RVA: 0x00135B4C File Offset: 0x00133D4C
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

			// Token: 0x0600460D RID: 17933 RVA: 0x00135BD8 File Offset: 0x00133DD8
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

			// Token: 0x0600460E RID: 17934 RVA: 0x00135C27 File Offset: 0x00133E27
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve.SECT409K1_AFFINE_ZS, false);
			}

			// Token: 0x0400246B RID: 9323
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT409K1Curve m_outer;

			// Token: 0x0400246C RID: 9324
			private readonly ulong[] m_table;

			// Token: 0x0400246D RID: 9325
			private readonly int m_size;
		}
	}
}
