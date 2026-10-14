using System;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000297 RID: 663
	internal class SecT283K1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001D09 RID: 7433 RVA: 0x00086EA4 File Offset: 0x000850A4
		public SecT283K1Curve() : base(283, 5, 7, 12)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("01FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFE9AE2ED07577265DFF7F94451E061E163C61"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
			this.m_coord = 6;
		}

		// Token: 0x06001D0A RID: 7434 RVA: 0x00086F1A File Offset: 0x0008511A
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve();
		}

		// Token: 0x06001D0B RID: 7435 RVA: 0x00086F21 File Offset: 0x00085121
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x06001D0C RID: 7436 RVA: 0x00086F2A File Offset: 0x0008512A
		protected override global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
		}

		// Token: 0x170003DF RID: 991
		// (get) Token: 0x06001D0D RID: 7437 RVA: 0x00086F31 File Offset: 0x00085131
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170003E0 RID: 992
		// (get) Token: 0x06001D0E RID: 7438 RVA: 0x00086F39 File Offset: 0x00085139
		public override int FieldSize
		{
			get
			{
				return 283;
			}
		}

		// Token: 0x06001D0F RID: 7439 RVA: 0x00086F40 File Offset: 0x00085140
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(x);
		}

		// Token: 0x06001D10 RID: 7440 RVA: 0x00086F48 File Offset: 0x00085148
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(this, x, y, withCompression);
		}

		// Token: 0x06001D11 RID: 7441 RVA: 0x00086F53 File Offset: 0x00085153
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x170003E1 RID: 993
		// (get) Token: 0x06001D12 RID: 7442 RVA: 0x00086F60 File Offset: 0x00085160
		public override bool IsKoblitz
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003E2 RID: 994
		// (get) Token: 0x06001D13 RID: 7443 RVA: 0x00086F63 File Offset: 0x00085163
		public virtual int M
		{
			get
			{
				return 283;
			}
		}

		// Token: 0x170003E3 RID: 995
		// (get) Token: 0x06001D14 RID: 7444 RVA: 0x00086F6A File Offset: 0x0008516A
		public virtual bool IsTrinomial
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170003E4 RID: 996
		// (get) Token: 0x06001D15 RID: 7445 RVA: 0x00086F6D File Offset: 0x0008516D
		public virtual int K1
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x170003E5 RID: 997
		// (get) Token: 0x06001D16 RID: 7446 RVA: 0x00086F70 File Offset: 0x00085170
		public virtual int K2
		{
			get
			{
				return 7;
			}
		}

		// Token: 0x170003E6 RID: 998
		// (get) Token: 0x06001D17 RID: 7447 RVA: 0x00086F73 File Offset: 0x00085173
		public virtual int K3
		{
			get
			{
				return 12;
			}
		}

		// Token: 0x06001D18 RID: 7448 RVA: 0x00086F78 File Offset: 0x00085178
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 5 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat320.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 5;
				global::Org.BouncyCastle.Math.Raw.Nat320.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 5;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve.SecT283K1LookupTable(this, table, len);
		}

		// Token: 0x04000ACF RID: 2767
		private const int SECT283K1_DEFAULT_COORDS = 6;

		// Token: 0x04000AD0 RID: 2768
		private const int SECT283K1_FE_LONGS = 5;

		// Token: 0x04000AD1 RID: 2769
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT283K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AD2 RID: 2770
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Point m_infinity;

		// Token: 0x020007EC RID: 2028
		private class SecT283K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x06004600 RID: 17920 RVA: 0x001358E6 File Offset: 0x00133AE6
			internal SecT283K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A9A RID: 2714
			// (get) Token: 0x06004601 RID: 17921 RVA: 0x00135903 File Offset: 0x00133B03
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x06004602 RID: 17922 RVA: 0x0013590C File Offset: 0x00133B0C
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					ulong MASK = (ulong)((long)((i ^ index) - 1 >> 31));
					for (int j = 0; j < 5; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 5 + j] & MASK);
					}
					pos += 10;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004603 RID: 17923 RVA: 0x00135998 File Offset: 0x00133B98
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat320.Create64();
				int pos = index * 5 * 2;
				for (int i = 0; i < 5; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 5 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004604 RID: 17924 RVA: 0x001359E7 File Offset: 0x00133BE7
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve.SECT283K1_AFFINE_ZS, false);
			}

			// Token: 0x04002465 RID: 9317
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT283K1Curve m_outer;

			// Token: 0x04002466 RID: 9318
			private readonly ulong[] m_table;

			// Token: 0x04002467 RID: 9319
			private readonly int m_size;
		}
	}
}
