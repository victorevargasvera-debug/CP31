using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000249 RID: 585
	internal class SecP160R1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x060017A1 RID: 6049 RVA: 0x00072024 File Offset: 0x00070224
		public SecP160R1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF7FFFFFFC")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("1C97BEFC54BD7A8B65ACF89F81D4D4ADC565FA45")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0100000000000000000001F4C8F927AED3CA752257"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x060017A2 RID: 6050 RVA: 0x000720AA File Offset: 0x000702AA
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Curve();
		}

		// Token: 0x060017A3 RID: 6051 RVA: 0x000720B1 File Offset: 0x000702B1
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x170002DB RID: 731
		// (get) Token: 0x060017A4 RID: 6052 RVA: 0x000720BA File Offset: 0x000702BA
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Curve.q;
			}
		}

		// Token: 0x170002DC RID: 732
		// (get) Token: 0x060017A5 RID: 6053 RVA: 0x000720C1 File Offset: 0x000702C1
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170002DD RID: 733
		// (get) Token: 0x060017A6 RID: 6054 RVA: 0x000720C9 File Offset: 0x000702C9
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Curve.q.BitLength;
			}
		}

		// Token: 0x060017A7 RID: 6055 RVA: 0x000720D5 File Offset: 0x000702D5
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(x);
		}

		// Token: 0x060017A8 RID: 6056 RVA: 0x000720DD File Offset: 0x000702DD
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Point(this, x, y, withCompression);
		}

		// Token: 0x060017A9 RID: 6057 RVA: 0x000720E8 File Offset: 0x000702E8
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x060017AA RID: 6058 RVA: 0x000720F8 File Offset: 0x000702F8
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 5 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat160.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 5;
				global::Org.BouncyCastle.Math.Raw.Nat160.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 5;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Curve.SecP160R1LookupTable(this, table, len);
		}

		// Token: 0x060017AB RID: 6059 RVA: 0x00072164 File Offset: 0x00070364
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(x);
		}

		// Token: 0x060017AC RID: 6060 RVA: 0x00072184 File Offset: 0x00070384
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(x);
		}

		// Token: 0x04000A0D RID: 2573
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement.Q;

		// Token: 0x04000A0E RID: 2574
		private const int SECP160R1_DEFAULT_COORDS = 2;

		// Token: 0x04000A0F RID: 2575
		private const int SECP160R1_FE_INTS = 5;

		// Token: 0x04000A10 RID: 2576
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP160R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A11 RID: 2577
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Point m_infinity;

		// Token: 0x020007D6 RID: 2006
		private class SecP160R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x06004592 RID: 17810 RVA: 0x0013400E File Offset: 0x0013220E
			internal SecP160R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A84 RID: 2692
			// (get) Token: 0x06004593 RID: 17811 RVA: 0x0013402B File Offset: 0x0013222B
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x06004594 RID: 17812 RVA: 0x00134034 File Offset: 0x00132234
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
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

			// Token: 0x06004595 RID: 17813 RVA: 0x001340C0 File Offset: 0x001322C0
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
				int pos = index * 5 * 2;
				for (int i = 0; i < 5; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 5 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004596 RID: 17814 RVA: 0x0013410F File Offset: 0x0013230F
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Curve.SECP160R1_AFFINE_ZS, false);
			}

			// Token: 0x04002423 RID: 9251
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R1Curve m_outer;

			// Token: 0x04002424 RID: 9252
			private readonly uint[] m_table;

			// Token: 0x04002425 RID: 9253
			private readonly int m_size;
		}
	}
}
