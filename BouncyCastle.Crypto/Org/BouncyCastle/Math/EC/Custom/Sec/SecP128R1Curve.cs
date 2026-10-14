using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000243 RID: 579
	internal class SecP128R1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x06001747 RID: 5959 RVA: 0x0007096C File Offset: 0x0006EB6C
		public SecP128R1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFDFFFFFFFFFFFFFFFFFFFFFFFC")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("E87579C11079F43DD824993C2CEE5ED3")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFE0000000075A30D1B9038A115"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x06001748 RID: 5960 RVA: 0x000709F2 File Offset: 0x0006EBF2
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve();
		}

		// Token: 0x06001749 RID: 5961 RVA: 0x000709F9 File Offset: 0x0006EBF9
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x170002D1 RID: 721
		// (get) Token: 0x0600174A RID: 5962 RVA: 0x00070A02 File Offset: 0x0006EC02
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve.q;
			}
		}

		// Token: 0x170002D2 RID: 722
		// (get) Token: 0x0600174B RID: 5963 RVA: 0x00070A09 File Offset: 0x0006EC09
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170002D3 RID: 723
		// (get) Token: 0x0600174C RID: 5964 RVA: 0x00070A11 File Offset: 0x0006EC11
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve.q.BitLength;
			}
		}

		// Token: 0x0600174D RID: 5965 RVA: 0x00070A1D File Offset: 0x0006EC1D
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(x);
		}

		// Token: 0x0600174E RID: 5966 RVA: 0x00070A25 File Offset: 0x0006EC25
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Point(this, x, y, withCompression);
		}

		// Token: 0x0600174F RID: 5967 RVA: 0x00070A30 File Offset: 0x0006EC30
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x06001750 RID: 5968 RVA: 0x00070A40 File Offset: 0x0006EC40
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 4 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat128.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 4;
				global::Org.BouncyCastle.Math.Raw.Nat128.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 4;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve.SecP128R1LookupTable(this, table, len);
		}

		// Token: 0x06001751 RID: 5969 RVA: 0x00070AAC File Offset: 0x0006ECAC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(x);
		}

		// Token: 0x06001752 RID: 5970 RVA: 0x00070ACC File Offset: 0x0006ECCC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(x);
		}

		// Token: 0x040009FC RID: 2556
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement.Q;

		// Token: 0x040009FD RID: 2557
		private const int SECP128R1_DEFAULT_COORDS = 2;

		// Token: 0x040009FE RID: 2558
		private const int SECP128R1_FE_INTS = 4;

		// Token: 0x040009FF RID: 2559
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP128R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A00 RID: 2560
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Point m_infinity;

		// Token: 0x020007D4 RID: 2004
		private class SecP128R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x06004588 RID: 17800 RVA: 0x00133DD1 File Offset: 0x00131FD1
			internal SecP128R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A82 RID: 2690
			// (get) Token: 0x06004589 RID: 17801 RVA: 0x00133DEE File Offset: 0x00131FEE
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x0600458A RID: 17802 RVA: 0x00133DF8 File Offset: 0x00131FF8
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					uint MASK = (uint)((i ^ index) - 1 >> 31);
					for (int j = 0; j < 4; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 4 + j] & MASK);
					}
					pos += 8;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x0600458B RID: 17803 RVA: 0x00133E80 File Offset: 0x00132080
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat128.Create();
				int pos = index * 4 * 2;
				for (int i = 0; i < 4; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 4 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x0600458C RID: 17804 RVA: 0x00133ECF File Offset: 0x001320CF
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve.SECP128R1_AFFINE_ZS, false);
			}

			// Token: 0x0400241D RID: 9245
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP128R1Curve m_outer;

			// Token: 0x0400241E RID: 9246
			private readonly uint[] m_table;

			// Token: 0x0400241F RID: 9247
			private readonly int m_size;
		}
	}
}
