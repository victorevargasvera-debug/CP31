using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000269 RID: 617
	internal class SecP384R1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x060019BC RID: 6588 RVA: 0x0007A080 File Offset: 0x00078280
		public SecP384R1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFF0000000000000000FFFFFFFC")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("B3312FA7E23EE7E4988E056BE3F82D19181D9C6EFE8141120314088F5013875AC656398D8A2ED19D2A85C8EDD3EC2AEF")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC7634D81F4372DDF581A0DB248B0A77AECEC196ACCC52973"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x060019BD RID: 6589 RVA: 0x0007A106 File Offset: 0x00078306
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve();
		}

		// Token: 0x060019BE RID: 6590 RVA: 0x0007A10D File Offset: 0x0007830D
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x17000313 RID: 787
		// (get) Token: 0x060019BF RID: 6591 RVA: 0x0007A116 File Offset: 0x00078316
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve.q;
			}
		}

		// Token: 0x17000314 RID: 788
		// (get) Token: 0x060019C0 RID: 6592 RVA: 0x0007A11D File Offset: 0x0007831D
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000315 RID: 789
		// (get) Token: 0x060019C1 RID: 6593 RVA: 0x0007A125 File Offset: 0x00078325
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve.q.BitLength;
			}
		}

		// Token: 0x060019C2 RID: 6594 RVA: 0x0007A131 File Offset: 0x00078331
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(x);
		}

		// Token: 0x060019C3 RID: 6595 RVA: 0x0007A139 File Offset: 0x00078339
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(this, x, y, withCompression);
		}

		// Token: 0x060019C4 RID: 6596 RVA: 0x0007A144 File Offset: 0x00078344
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x060019C5 RID: 6597 RVA: 0x0007A154 File Offset: 0x00078354
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 12 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint p = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat.Copy(12, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)p.RawXCoord).x, 0, table, pos);
				pos += 12;
				global::Org.BouncyCastle.Math.Raw.Nat.Copy(12, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement)p.RawYCoord).x, 0, table, pos);
				pos += 12;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve.SecP384R1LookupTable(this, table, len);
		}

		// Token: 0x060019C6 RID: 6598 RVA: 0x0007A1C8 File Offset: 0x000783C8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(x);
		}

		// Token: 0x060019C7 RID: 6599 RVA: 0x0007A1EC File Offset: 0x000783EC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(x);
		}

		// Token: 0x04000A72 RID: 2674
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement.Q;

		// Token: 0x04000A73 RID: 2675
		private const int SECP384R1_DEFAULT_COORDS = 2;

		// Token: 0x04000A74 RID: 2676
		private const int SECP384R1_FE_INTS = 12;

		// Token: 0x04000A75 RID: 2677
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP384R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A76 RID: 2678
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Point m_infinity;

		// Token: 0x020007DE RID: 2014
		private class SecP384R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045BA RID: 17850 RVA: 0x0013490E File Offset: 0x00132B0E
			internal SecP384R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A8C RID: 2700
			// (get) Token: 0x060045BB RID: 17851 RVA: 0x0013492B File Offset: 0x00132B2B
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045BC RID: 17852 RVA: 0x00134934 File Offset: 0x00132B34
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					uint MASK = (uint)((i ^ index) - 1 >> 31);
					for (int j = 0; j < 12; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 12 + j] & MASK);
					}
					pos += 24;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045BD RID: 17853 RVA: 0x001349C4 File Offset: 0x00132BC4
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat.Create(12);
				int pos = index * 12 * 2;
				for (int i = 0; i < 12; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 12 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045BE RID: 17854 RVA: 0x00134A1A File Offset: 0x00132C1A
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve.SECP384R1_AFFINE_ZS, false);
			}

			// Token: 0x0400243B RID: 9275
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP384R1Curve m_outer;

			// Token: 0x0400243C RID: 9276
			private readonly uint[] m_table;

			// Token: 0x0400243D RID: 9277
			private readonly int m_size;
		}
	}
}
