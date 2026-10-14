using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x0200028F RID: 655
	internal class SecT233R1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001C61 RID: 7265 RVA: 0x000845A0 File Offset: 0x000827A0
		public SecT233R1Curve() : base(233, 74, 0, 0)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("0066647EDE6C332C7F8C0923BB58213B333B20E9CE4281FE115F7D8F90AD")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("01000000000000000000000000000013E974E72F8A6922031D2603CFE0D7"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.Two;
			this.m_coord = 6;
		}

		// Token: 0x06001C62 RID: 7266 RVA: 0x0008461F File Offset: 0x0008281F
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Curve();
		}

		// Token: 0x06001C63 RID: 7267 RVA: 0x00084626 File Offset: 0x00082826
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x06001C64 RID: 7268 RVA: 0x0008462F File Offset: 0x0008282F
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x06001C65 RID: 7269 RVA: 0x00084637 File Offset: 0x00082837
		public override int FieldSize
		{
			get
			{
				return 233;
			}
		}

		// Token: 0x06001C66 RID: 7270 RVA: 0x0008463E File Offset: 0x0008283E
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(x);
		}

		// Token: 0x06001C67 RID: 7271 RVA: 0x00084646 File Offset: 0x00082846
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001C68 RID: 7272 RVA: 0x00084651 File Offset: 0x00082851
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x06001C69 RID: 7273 RVA: 0x0008465E File Offset: 0x0008285E
		public override bool IsKoblitz
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x06001C6A RID: 7274 RVA: 0x00084661 File Offset: 0x00082861
		public virtual int M
		{
			get
			{
				return 233;
			}
		}

		// Token: 0x170003BB RID: 955
		// (get) Token: 0x06001C6B RID: 7275 RVA: 0x00084668 File Offset: 0x00082868
		public virtual bool IsTrinomial
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06001C6C RID: 7276 RVA: 0x0008466B File Offset: 0x0008286B
		public virtual int K1
		{
			get
			{
				return 74;
			}
		}

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06001C6D RID: 7277 RVA: 0x0008466F File Offset: 0x0008286F
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170003BE RID: 958
		// (get) Token: 0x06001C6E RID: 7278 RVA: 0x00084672 File Offset: 0x00082872
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001C6F RID: 7279 RVA: 0x00084678 File Offset: 0x00082878
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 4 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 4;
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 4;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Curve.SecT233R1LookupTable(this, table, len);
		}

		// Token: 0x04000AC0 RID: 2752
		private const int SECT233R1_DEFAULT_COORDS = 6;

		// Token: 0x04000AC1 RID: 2753
		private const int SECT233R1_FE_LONGS = 4;

		// Token: 0x04000AC2 RID: 2754
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT233R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AC3 RID: 2755
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Point m_infinity;

		// Token: 0x020007EA RID: 2026
		private class SecT233R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045F6 RID: 17910 RVA: 0x001356A6 File Offset: 0x001338A6
			internal SecT233R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A98 RID: 2712
			// (get) Token: 0x060045F7 RID: 17911 RVA: 0x001356C3 File Offset: 0x001338C3
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045F8 RID: 17912 RVA: 0x001356CC File Offset: 0x001338CC
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					ulong MASK = (ulong)((long)((i ^ index) - 1 >> 31));
					for (int j = 0; j < 4; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 4 + j] & MASK);
					}
					pos += 8;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045F9 RID: 17913 RVA: 0x00135758 File Offset: 0x00133958
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create64();
				int pos = index * 4 * 2;
				for (int i = 0; i < 4; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 4 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045FA RID: 17914 RVA: 0x001357A7 File Offset: 0x001339A7
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Curve.SECT233R1_AFFINE_ZS, false);
			}

			// Token: 0x0400245F RID: 9311
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT233R1Curve m_outer;

			// Token: 0x04002460 RID: 9312
			private readonly ulong[] m_table;

			// Token: 0x04002461 RID: 9313
			private readonly int m_size;
		}
	}
}
