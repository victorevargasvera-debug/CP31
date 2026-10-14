using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000251 RID: 593
	internal class SecP192K1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x06001825 RID: 6181 RVA: 0x00073EF4 File Offset: 0x000720F4
		public SecP192K1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.ValueOf(3L));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFE26F2FC170F69466A74DEFD8D"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x06001826 RID: 6182 RVA: 0x00073F66 File Offset: 0x00072166
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve();
		}

		// Token: 0x06001827 RID: 6183 RVA: 0x00073F6D File Offset: 0x0007216D
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x170002E9 RID: 745
		// (get) Token: 0x06001828 RID: 6184 RVA: 0x00073F76 File Offset: 0x00072176
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve.q;
			}
		}

		// Token: 0x170002EA RID: 746
		// (get) Token: 0x06001829 RID: 6185 RVA: 0x00073F7D File Offset: 0x0007217D
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170002EB RID: 747
		// (get) Token: 0x0600182A RID: 6186 RVA: 0x00073F85 File Offset: 0x00072185
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve.q.BitLength;
			}
		}

		// Token: 0x0600182B RID: 6187 RVA: 0x00073F91 File Offset: 0x00072191
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(x);
		}

		// Token: 0x0600182C RID: 6188 RVA: 0x00073F99 File Offset: 0x00072199
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Point(this, x, y, withCompression);
		}

		// Token: 0x0600182D RID: 6189 RVA: 0x00073FA4 File Offset: 0x000721A4
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x0600182E RID: 6190 RVA: 0x00073FB4 File Offset: 0x000721B4
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 6 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat192.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 6;
				global::Org.BouncyCastle.Math.Raw.Nat192.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 6;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve.SecP192K1LookupTable(this, table, len);
		}

		// Token: 0x0600182F RID: 6191 RVA: 0x00074020 File Offset: 0x00072220
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(x);
		}

		// Token: 0x06001830 RID: 6192 RVA: 0x00074040 File Offset: 0x00072240
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(x);
		}

		// Token: 0x04000A27 RID: 2599
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement.Q;

		// Token: 0x04000A28 RID: 2600
		private const int SECP192K1_DEFAULT_COORDS = 2;

		// Token: 0x04000A29 RID: 2601
		private const int SECP192K1_FE_INTS = 6;

		// Token: 0x04000A2A RID: 2602
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP192K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A2B RID: 2603
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Point m_infinity;

		// Token: 0x020007D8 RID: 2008
		private class SecP192K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x0600459C RID: 17820 RVA: 0x0013424E File Offset: 0x0013244E
			internal SecP192K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A86 RID: 2694
			// (get) Token: 0x0600459D RID: 17821 RVA: 0x0013426B File Offset: 0x0013246B
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x0600459E RID: 17822 RVA: 0x00134274 File Offset: 0x00132474
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					uint MASK = (uint)((i ^ index) - 1 >> 31);
					for (int j = 0; j < 6; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 6 + j] & MASK);
					}
					pos += 12;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x0600459F RID: 17823 RVA: 0x00134300 File Offset: 0x00132500
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
				int pos = index * 6 * 2;
				for (int i = 0; i < 6; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 6 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045A0 RID: 17824 RVA: 0x0013434F File Offset: 0x0013254F
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve.SECP192K1_AFFINE_ZS, false);
			}

			// Token: 0x04002429 RID: 9257
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192K1Curve m_outer;

			// Token: 0x0400242A RID: 9258
			private readonly uint[] m_table;

			// Token: 0x0400242B RID: 9259
			private readonly int m_size;
		}
	}
}
