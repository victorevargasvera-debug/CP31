using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200024D RID: 589
	internal class SecP160R2Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x060017E3 RID: 6115 RVA: 0x00072F7C File Offset: 0x0007117C
		public SecP160R2Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFAC70")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("B4E134D3FB59EB8BAB57274904664D5AF50388BA")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0100000000000000000000351EE786A818F3A1A16B"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x060017E4 RID: 6116 RVA: 0x00073002 File Offset: 0x00071202
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve();
		}

		// Token: 0x060017E5 RID: 6117 RVA: 0x00073009 File Offset: 0x00071209
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x170002E2 RID: 738
		// (get) Token: 0x060017E6 RID: 6118 RVA: 0x00073012 File Offset: 0x00071212
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve.q;
			}
		}

		// Token: 0x170002E3 RID: 739
		// (get) Token: 0x060017E7 RID: 6119 RVA: 0x00073019 File Offset: 0x00071219
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170002E4 RID: 740
		// (get) Token: 0x060017E8 RID: 6120 RVA: 0x00073021 File Offset: 0x00071221
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve.q.BitLength;
			}
		}

		// Token: 0x060017E9 RID: 6121 RVA: 0x0007302D File Offset: 0x0007122D
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(x);
		}

		// Token: 0x060017EA RID: 6122 RVA: 0x00073035 File Offset: 0x00071235
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Point(this, x, y, withCompression);
		}

		// Token: 0x060017EB RID: 6123 RVA: 0x00073040 File Offset: 0x00071240
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Point(this, x, y, zs, withCompression);
		}

		// Token: 0x060017EC RID: 6124 RVA: 0x00073050 File Offset: 0x00071250
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
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve.SecP160R2LookupTable(this, table, len);
		}

		// Token: 0x060017ED RID: 6125 RVA: 0x000730BC File Offset: 0x000712BC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(x);
		}

		// Token: 0x060017EE RID: 6126 RVA: 0x000730DC File Offset: 0x000712DC
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat160.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(x);
		}

		// Token: 0x04000A1A RID: 2586
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement.Q;

		// Token: 0x04000A1B RID: 2587
		private const int SECP160R2_DEFAULT_COORDS = 2;

		// Token: 0x04000A1C RID: 2588
		private const int SECP160R2_FE_INTS = 5;

		// Token: 0x04000A1D RID: 2589
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP160R2_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A1E RID: 2590
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Point m_infinity;

		// Token: 0x020007D7 RID: 2007
		private class SecP160R2LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x06004597 RID: 17815 RVA: 0x0013412E File Offset: 0x0013232E
			internal SecP160R2LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A85 RID: 2693
			// (get) Token: 0x06004598 RID: 17816 RVA: 0x0013414B File Offset: 0x0013234B
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x06004599 RID: 17817 RVA: 0x00134154 File Offset: 0x00132354
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

			// Token: 0x0600459A RID: 17818 RVA: 0x001341E0 File Offset: 0x001323E0
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

			// Token: 0x0600459B RID: 17819 RVA: 0x0013422F File Offset: 0x0013242F
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve.SECP160R2_AFFINE_ZS, false);
			}

			// Token: 0x04002426 RID: 9254
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP160R2Curve m_outer;

			// Token: 0x04002427 RID: 9255
			private readonly uint[] m_table;

			// Token: 0x04002428 RID: 9256
			private readonly int m_size;
		}
	}
}
