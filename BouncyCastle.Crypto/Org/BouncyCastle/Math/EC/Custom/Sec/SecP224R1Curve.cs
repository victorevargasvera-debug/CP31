using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200025D RID: 605
	internal class SecP224R1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x060018ED RID: 6381 RVA: 0x00076DE8 File Offset: 0x00074FE8
		public SecP224R1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFE")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("B4050A850C04B3ABF54132565044B0B7D7BFD8BA270B39432355FFB4")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFF16A2E0B8F03E13DD29455C5C2A3D"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x060018EE RID: 6382 RVA: 0x00076E6E File Offset: 0x0007506E
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve();
		}

		// Token: 0x060018EF RID: 6383 RVA: 0x00076E75 File Offset: 0x00075075
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x170002FE RID: 766
		// (get) Token: 0x060018F0 RID: 6384 RVA: 0x00076E7E File Offset: 0x0007507E
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.q;
			}
		}

		// Token: 0x170002FF RID: 767
		// (get) Token: 0x060018F1 RID: 6385 RVA: 0x00076E85 File Offset: 0x00075085
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000300 RID: 768
		// (get) Token: 0x060018F2 RID: 6386 RVA: 0x00076E8D File Offset: 0x0007508D
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.q.BitLength;
			}
		}

		// Token: 0x060018F3 RID: 6387 RVA: 0x00076E99 File Offset: 0x00075099
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(x);
		}

		// Token: 0x060018F4 RID: 6388 RVA: 0x00076EA1 File Offset: 0x000750A1
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(this, x, y, withCompression);
		}

		// Token: 0x060018F5 RID: 6389 RVA: 0x00076EAC File Offset: 0x000750AC
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x060018F6 RID: 6390 RVA: 0x00076EBC File Offset: 0x000750BC
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 7 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat224.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 7;
				global::Org.BouncyCastle.Math.Raw.Nat224.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 7;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.SecP224R1LookupTable(this, table, len);
		}

		// Token: 0x060018F7 RID: 6391 RVA: 0x00076F28 File Offset: 0x00075128
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(x);
		}

		// Token: 0x060018F8 RID: 6392 RVA: 0x00076F48 File Offset: 0x00075148
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(x);
		}

		// Token: 0x04000A4E RID: 2638
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement.Q;

		// Token: 0x04000A4F RID: 2639
		private const int SECP224R1_DEFAULT_COORDS = 2;

		// Token: 0x04000A50 RID: 2640
		private const int SECP224R1_FE_INTS = 7;

		// Token: 0x04000A51 RID: 2641
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP224R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A52 RID: 2642
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Point m_infinity;

		// Token: 0x020007DB RID: 2011
		private class SecP224R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045AB RID: 17835 RVA: 0x001345AE File Offset: 0x001327AE
			internal SecP224R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A89 RID: 2697
			// (get) Token: 0x060045AC RID: 17836 RVA: 0x001345CB File Offset: 0x001327CB
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045AD RID: 17837 RVA: 0x001345D4 File Offset: 0x001327D4
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					uint MASK = (uint)((i ^ index) - 1 >> 31);
					for (int j = 0; j < 7; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 7 + j] & MASK);
					}
					pos += 14;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045AE RID: 17838 RVA: 0x00134660 File Offset: 0x00132860
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
				int pos = index * 7 * 2;
				for (int i = 0; i < 7; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 7 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045AF RID: 17839 RVA: 0x001346AF File Offset: 0x001328AF
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve.SECP224R1_AFFINE_ZS, false);
			}

			// Token: 0x04002432 RID: 9266
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224R1Curve m_outer;

			// Token: 0x04002433 RID: 9267
			private readonly uint[] m_table;

			// Token: 0x04002434 RID: 9268
			private readonly int m_size;
		}
	}
}
