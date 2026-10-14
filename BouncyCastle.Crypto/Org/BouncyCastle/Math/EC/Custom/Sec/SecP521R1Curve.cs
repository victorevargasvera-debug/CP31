using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200026D RID: 621
	internal class SecP521R1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x060019FF RID: 6655 RVA: 0x0007B2EC File Offset: 0x000794EC
		public SecP521R1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFC")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0051953EB9618E1C9A1F929A21A0B68540EEA2DA725B99B315F3B8B489918EF109E156193951EC7E937B1652C0BD3BB1BF073573DF883D2C34F1EF451FD46B503F00")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFA51868783BF2F966B7FCC0148F709A5D03BB5C9B8899C47AEBB6FB71E91386409"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x06001A00 RID: 6656 RVA: 0x0007B372 File Offset: 0x00079572
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Curve();
		}

		// Token: 0x06001A01 RID: 6657 RVA: 0x0007B379 File Offset: 0x00079579
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06001A02 RID: 6658 RVA: 0x0007B382 File Offset: 0x00079582
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Curve.q;
			}
		}

		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06001A03 RID: 6659 RVA: 0x0007B389 File Offset: 0x00079589
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06001A04 RID: 6660 RVA: 0x0007B391 File Offset: 0x00079591
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Curve.q.BitLength;
			}
		}

		// Token: 0x06001A05 RID: 6661 RVA: 0x0007B39D File Offset: 0x0007959D
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(x);
		}

		// Token: 0x06001A06 RID: 6662 RVA: 0x0007B3A5 File Offset: 0x000795A5
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001A07 RID: 6663 RVA: 0x0007B3B0 File Offset: 0x000795B0
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x06001A08 RID: 6664 RVA: 0x0007B3C0 File Offset: 0x000795C0
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 17 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint p = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat.Copy(17, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)p.RawXCoord).x, 0, table, pos);
				pos += 17;
				global::Org.BouncyCastle.Math.Raw.Nat.Copy(17, ((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement)p.RawYCoord).x, 0, table, pos);
				pos += 17;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Curve.SecP521R1LookupTable(this, table, len);
		}

		// Token: 0x06001A09 RID: 6665 RVA: 0x0007B434 File Offset: 0x00079634
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(x);
		}

		// Token: 0x06001A0A RID: 6666 RVA: 0x0007B458 File Offset: 0x00079658
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(x);
		}

		// Token: 0x04000A7E RID: 2686
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement.Q;

		// Token: 0x04000A7F RID: 2687
		private const int SECP521R1_DEFAULT_COORDS = 2;

		// Token: 0x04000A80 RID: 2688
		private const int SECP521R1_FE_INTS = 17;

		// Token: 0x04000A81 RID: 2689
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP521R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A82 RID: 2690
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Point m_infinity;

		// Token: 0x020007DF RID: 2015
		private class SecP521R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045BF RID: 17855 RVA: 0x00134A39 File Offset: 0x00132C39
			internal SecP521R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A8D RID: 2701
			// (get) Token: 0x060045C0 RID: 17856 RVA: 0x00134A56 File Offset: 0x00132C56
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045C1 RID: 17857 RVA: 0x00134A60 File Offset: 0x00132C60
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					uint MASK = (uint)((i ^ index) - 1 >> 31);
					for (int j = 0; j < 17; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 17 + j] & MASK);
					}
					pos += 34;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045C2 RID: 17858 RVA: 0x00134AF0 File Offset: 0x00132CF0
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat.Create(17);
				int pos = index * 17 * 2;
				for (int i = 0; i < 17; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 17 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045C3 RID: 17859 RVA: 0x00134B46 File Offset: 0x00132D46
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Curve.SECP521R1_AFFINE_ZS, false);
			}

			// Token: 0x0400243E RID: 9278
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP521R1Curve m_outer;

			// Token: 0x0400243F RID: 9279
			private readonly uint[] m_table;

			// Token: 0x04002440 RID: 9280
			private readonly int m_size;
		}
	}
}
