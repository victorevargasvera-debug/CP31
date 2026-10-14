using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Djb
{
	// Token: 0x020002AB RID: 683
	internal class Curve25519 : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x06001E64 RID: 7780 RVA: 0x0008CEB8 File Offset: 0x0008B0B8
		public Curve25519() : base(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.C_a);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.C_b);
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("1000000000000000000000000000000014DEF9DEA2F79CD65812631A5CF5D3ED"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.ValueOf(8L);
			this.m_coord = 4;
		}

		// Token: 0x06001E65 RID: 7781 RVA: 0x0008CF2A File Offset: 0x0008B12A
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519();
		}

		// Token: 0x06001E66 RID: 7782 RVA: 0x0008CF31 File Offset: 0x0008B131
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 4;
		}

		// Token: 0x17000436 RID: 1078
		// (get) Token: 0x06001E67 RID: 7783 RVA: 0x0008CF3A File Offset: 0x0008B13A
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.q;
			}
		}

		// Token: 0x17000437 RID: 1079
		// (get) Token: 0x06001E68 RID: 7784 RVA: 0x0008CF41 File Offset: 0x0008B141
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000438 RID: 1080
		// (get) Token: 0x06001E69 RID: 7785 RVA: 0x0008CF49 File Offset: 0x0008B149
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.q.BitLength;
			}
		}

		// Token: 0x06001E6A RID: 7786 RVA: 0x0008CF55 File Offset: 0x0008B155
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(x);
		}

		// Token: 0x06001E6B RID: 7787 RVA: 0x0008CF5D File Offset: 0x0008B15D
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(this, x, y, withCompression);
		}

		// Token: 0x06001E6C RID: 7788 RVA: 0x0008CF68 File Offset: 0x0008B168
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point(this, x, y, zs, withCompression);
		}

		// Token: 0x06001E6D RID: 7789 RVA: 0x0008CF78 File Offset: 0x0008B178
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 8 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 8;
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 8;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.Curve25519LookupTable(this, table, len);
		}

		// Token: 0x06001E6E RID: 7790 RVA: 0x0008CFE4 File Offset: 0x0008B1E4
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(x);
		}

		// Token: 0x06001E6F RID: 7791 RVA: 0x0008D004 File Offset: 0x0008B204
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(x);
		}

		// Token: 0x04000AFA RID: 2810
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement.Q;

		// Token: 0x04000AFB RID: 2811
		private static readonly global::Org.BouncyCastle.Math.BigInteger C_a = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("2AAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAAA984914A144"));

		// Token: 0x04000AFC RID: 2812
		private static readonly global::Org.BouncyCastle.Math.BigInteger C_b = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("7B425ED097B425ED097B425ED097B425ED097B425ED097B4260B5E9C7710C864"));

		// Token: 0x04000AFD RID: 2813
		private const int CURVE25519_DEFAULT_COORDS = 4;

		// Token: 0x04000AFE RID: 2814
		private const int CURVE25519_FE_INTS = 8;

		// Token: 0x04000AFF RID: 2815
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] CURVE25519_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(global::Org.BouncyCastle.Math.BigInteger.One),
			new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.C_a)
		};

		// Token: 0x04000B00 RID: 2816
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519Point m_infinity;

		// Token: 0x020007F3 RID: 2035
		private class Curve25519LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x06004623 RID: 17955 RVA: 0x001360CE File Offset: 0x001342CE
			internal Curve25519LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519 outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000AA1 RID: 2721
			// (get) Token: 0x06004624 RID: 17956 RVA: 0x001360EB File Offset: 0x001342EB
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x06004625 RID: 17957 RVA: 0x001360F4 File Offset: 0x001342F4
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					uint MASK = (uint)((i ^ index) - 1 >> 31);
					for (int j = 0; j < 8; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 8 + j] & MASK);
					}
					pos += 16;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004626 RID: 17958 RVA: 0x00136180 File Offset: 0x00134380
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				int pos = index * 8 * 2;
				for (int i = 0; i < 8; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 8 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004627 RID: 17959 RVA: 0x001361CF File Offset: 0x001343CF
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519.CURVE25519_AFFINE_ZS, false);
			}

			// Token: 0x0400247A RID: 9338
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Djb.Curve25519 m_outer;

			// Token: 0x0400247B RID: 9339
			private readonly uint[] m_table;

			// Token: 0x0400247C RID: 9340
			private readonly int m_size;
		}
	}
}
