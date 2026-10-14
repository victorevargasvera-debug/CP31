using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000247 RID: 583
	internal class SecP160K1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x0600178B RID: 6027 RVA: 0x00071914 File Offset: 0x0006FB14
		public SecP160K1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.ValueOf(7L));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0100000000000000000001B8FA16DFAB9ACA16B6B3"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x0600178C RID: 6028 RVA: 0x00071986 File Offset: 0x0006FB86
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve();
		}

		// Token: 0x0600178D RID: 6029 RVA: 0x0007198D File Offset: 0x0006FB8D
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x170002D8 RID: 728
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00071996 File Offset: 0x0006FB96
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.q;
			}
		}

		// Token: 0x170002D9 RID: 729
		// (get) Token: 0x0600178F RID: 6031 RVA: 0x0007199D File Offset: 0x0006FB9D
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170002DA RID: 730
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x000719A5 File Offset: 0x0006FBA5
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.q.BitLength;
			}
		}

		// Token: 0x06001791 RID: 6033 RVA: 0x000719B1 File Offset: 0x0006FBB1
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(x);
		}

		// Token: 0x06001792 RID: 6034 RVA: 0x000719B9 File Offset: 0x0006FBB9
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Point(this, x, y, withCompression);
		}

		// Token: 0x06001793 RID: 6035 RVA: 0x000719C4 File Offset: 0x0006FBC4
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x06001794 RID: 6036 RVA: 0x000719D4 File Offset: 0x0006FBD4
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 5 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat160.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 5;
				global::Org.BouncyCastle.Math.Raw.Nat160.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 5;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.SecP160K1LookupTable(this, table, len);
		}

		// Token: 0x06001795 RID: 6037 RVA: 0x00071A40 File Offset: 0x0006FC40
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(x);
		}

		// Token: 0x06001796 RID: 6038 RVA: 0x00071A60 File Offset: 0x0006FC60
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(x);
		}

		// Token: 0x04000A08 RID: 2568
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q;

		// Token: 0x04000A09 RID: 2569
		private const int SECP160K1_DEFAULT_COORDS = 2;

		// Token: 0x04000A0A RID: 2570
		private const int SECP160K1_FE_INTS = 5;

		// Token: 0x04000A0B RID: 2571
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP160K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A0C RID: 2572
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Point m_infinity;

		// Token: 0x020007D5 RID: 2005
		private class SecP160K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x0600458D RID: 17805 RVA: 0x00133EEE File Offset: 0x001320EE
			internal SecP160K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A83 RID: 2691
			// (get) Token: 0x0600458E RID: 17806 RVA: 0x00133F0B File Offset: 0x0013210B
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x0600458F RID: 17807 RVA: 0x00133F14 File Offset: 0x00132114
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					uint MASK = (uint)((i ^ index) - 1 >> 31);
					for (int j = 0; j < 5; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 5 + j] & MASK);
					}
					pos += 10;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004590 RID: 17808 RVA: 0x00133FA0 File Offset: 0x001321A0
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				int pos = index * 5 * 2;
				for (int i = 0; i < 5; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 5 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004591 RID: 17809 RVA: 0x00133FEF File Offset: 0x001321EF
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve.SECP160K1_AFFINE_ZS, false);
			}

			// Token: 0x04002420 RID: 9248
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160K1Curve m_outer;

			// Token: 0x04002421 RID: 9249
			private readonly uint[] m_table;

			// Token: 0x04002422 RID: 9250
			private readonly int m_size;
		}
	}
}
