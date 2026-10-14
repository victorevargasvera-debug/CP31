using System;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x020002A3 RID: 675
	internal class SecT571K1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001DEB RID: 7659 RVA: 0x0008AAF8 File Offset: 0x00088CF8
		public SecT571K1Curve() : base(571, 2, 5, 10)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("020000000000000000000000000000000000000000000000000000000000000000000000131850E1F19A63E4B391A8DB917F4138B630D84BE5D639381E91DEB45CFE778F637C1001"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
			this.m_coord = 6;
		}

		// Token: 0x06001DEC RID: 7660 RVA: 0x0008AB6E File Offset: 0x00088D6E
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Curve();
		}

		// Token: 0x06001DED RID: 7661 RVA: 0x0008AB75 File Offset: 0x00088D75
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x06001DEE RID: 7662 RVA: 0x0008AB7E File Offset: 0x00088D7E
		protected override global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
		}

		// Token: 0x1700041B RID: 1051
		// (get) Token: 0x06001DEF RID: 7663 RVA: 0x0008AB85 File Offset: 0x00088D85
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x1700041C RID: 1052
		// (get) Token: 0x06001DF0 RID: 7664 RVA: 0x0008AB8D File Offset: 0x00088D8D
		public override int FieldSize
		{
			get
			{
				return 571;
			}
		}

		// Token: 0x06001DF1 RID: 7665 RVA: 0x0008AB94 File Offset: 0x00088D94
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(x);
		}

		// Token: 0x06001DF2 RID: 7666 RVA: 0x0008AB9C File Offset: 0x00088D9C
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(this, x, y, withCompression);
		}

		// Token: 0x06001DF3 RID: 7667 RVA: 0x0008ABA7 File Offset: 0x00088DA7
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x1700041D RID: 1053
		// (get) Token: 0x06001DF4 RID: 7668 RVA: 0x0008ABB4 File Offset: 0x00088DB4
		public override bool IsKoblitz
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700041E RID: 1054
		// (get) Token: 0x06001DF5 RID: 7669 RVA: 0x0008ABB7 File Offset: 0x00088DB7
		public virtual int M
		{
			get
			{
				return 571;
			}
		}

		// Token: 0x1700041F RID: 1055
		// (get) Token: 0x06001DF6 RID: 7670 RVA: 0x0008ABBE File Offset: 0x00088DBE
		public virtual bool IsTrinomial
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000420 RID: 1056
		// (get) Token: 0x06001DF7 RID: 7671 RVA: 0x0008ABC1 File Offset: 0x00088DC1
		public virtual int K1
		{
			get
			{
				return 2;
			}
		}

		// Token: 0x17000421 RID: 1057
		// (get) Token: 0x06001DF8 RID: 7672 RVA: 0x0008ABC4 File Offset: 0x00088DC4
		public virtual int K2
		{
			get
			{
				return 5;
			}
		}

		// Token: 0x17000422 RID: 1058
		// (get) Token: 0x06001DF9 RID: 7673 RVA: 0x0008ABC7 File Offset: 0x00088DC7
		public virtual int K3
		{
			get
			{
				return 10;
			}
		}

		// Token: 0x06001DFA RID: 7674 RVA: 0x0008ABCC File Offset: 0x00088DCC
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 9 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat576.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 9;
				global::Org.BouncyCastle.Math.Raw.Nat576.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 9;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Curve.SecT571K1LookupTable(this, table, len);
		}

		// Token: 0x04000AE5 RID: 2789
		private const int SECT571K1_DEFAULT_COORDS = 6;

		// Token: 0x04000AE6 RID: 2790
		private const int SECT571K1_FE_LONGS = 9;

		// Token: 0x04000AE7 RID: 2791
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT571K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AE8 RID: 2792
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Point m_infinity;

		// Token: 0x020007F0 RID: 2032
		private class SecT571K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x06004614 RID: 17940 RVA: 0x00135D66 File Offset: 0x00133F66
			internal SecT571K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A9E RID: 2718
			// (get) Token: 0x06004615 RID: 17941 RVA: 0x00135D83 File Offset: 0x00133F83
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x06004616 RID: 17942 RVA: 0x00135D8C File Offset: 0x00133F8C
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					ulong MASK = (ulong)((long)((i ^ index) - 1 >> 31));
					for (int j = 0; j < 9; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 9 + j] & MASK);
					}
					pos += 18;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004617 RID: 17943 RVA: 0x00135E18 File Offset: 0x00134018
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				ulong[] x = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				ulong[] y = global::Org.BouncyCastle.Math.Raw.Nat576.Create64();
				int pos = index * 9 * 2;
				for (int i = 0; i < 9; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 9 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x06004618 RID: 17944 RVA: 0x00135E6A File Offset: 0x0013406A
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Curve.SECT571K1_AFFINE_ZS, false);
			}

			// Token: 0x04002471 RID: 9329
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT571K1Curve m_outer;

			// Token: 0x04002472 RID: 9330
			private readonly ulong[] m_table;

			// Token: 0x04002473 RID: 9331
			private readonly int m_size;
		}
	}
}
