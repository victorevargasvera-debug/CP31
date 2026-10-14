using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000259 RID: 601
	internal class SecP224K1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x060018AB RID: 6315 RVA: 0x00075E74 File Offset: 0x00074074
		public SecP224K1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.ValueOf(5L));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("010000000000000000000000000001DCE8D2EC6184CAF0A971769FB1F7"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x060018AC RID: 6316 RVA: 0x00075EE6 File Offset: 0x000740E6
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve();
		}

		// Token: 0x060018AD RID: 6317 RVA: 0x00075EED File Offset: 0x000740ED
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x170002F7 RID: 759
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x00075EF6 File Offset: 0x000740F6
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.q;
			}
		}

		// Token: 0x170002F8 RID: 760
		// (get) Token: 0x060018AF RID: 6319 RVA: 0x00075EFD File Offset: 0x000740FD
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170002F9 RID: 761
		// (get) Token: 0x060018B0 RID: 6320 RVA: 0x00075F05 File Offset: 0x00074105
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.q.BitLength;
			}
		}

		// Token: 0x060018B1 RID: 6321 RVA: 0x00075F11 File Offset: 0x00074111
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(x);
		}

		// Token: 0x060018B2 RID: 6322 RVA: 0x00075F19 File Offset: 0x00074119
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(this, x, y, withCompression);
		}

		// Token: 0x060018B3 RID: 6323 RVA: 0x00075F24 File Offset: 0x00074124
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x060018B4 RID: 6324 RVA: 0x00075F34 File Offset: 0x00074134
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 7 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat224.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 7;
				global::Org.BouncyCastle.Math.Raw.Nat224.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 7;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.SecP224K1LookupTable(this, table, len);
		}

		// Token: 0x060018B5 RID: 6325 RVA: 0x00075FA0 File Offset: 0x000741A0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(x);
		}

		// Token: 0x060018B6 RID: 6326 RVA: 0x00075FC0 File Offset: 0x000741C0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat224.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(x);
		}

		// Token: 0x04000A40 RID: 2624
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement.Q;

		// Token: 0x04000A41 RID: 2625
		private const int SECP224K1_DEFAULT_COORDS = 2;

		// Token: 0x04000A42 RID: 2626
		private const int SECP224K1_FE_INTS = 7;

		// Token: 0x04000A43 RID: 2627
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP224K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A44 RID: 2628
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Point m_infinity;

		// Token: 0x020007DA RID: 2010
		private class SecP224K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045A6 RID: 17830 RVA: 0x0013448E File Offset: 0x0013268E
			internal SecP224K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A88 RID: 2696
			// (get) Token: 0x060045A7 RID: 17831 RVA: 0x001344AB File Offset: 0x001326AB
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045A8 RID: 17832 RVA: 0x001344B4 File Offset: 0x001326B4
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

			// Token: 0x060045A9 RID: 17833 RVA: 0x00134540 File Offset: 0x00132740
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

			// Token: 0x060045AA RID: 17834 RVA: 0x0013458F File Offset: 0x0013278F
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve.SECP224K1_AFFINE_ZS, false);
			}

			// Token: 0x0400242F RID: 9263
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP224K1Curve m_outer;

			// Token: 0x04002430 RID: 9264
			private readonly uint[] m_table;

			// Token: 0x04002431 RID: 9265
			private readonly int m_size;
		}
	}
}
