using System;
using Org.BouncyCastle.Math.EC.Multiplier;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000293 RID: 659
	internal class SecT239K1Curve : global::Org.BouncyCastle.Math.EC.AbstractF2mCurve
	{
		// Token: 0x06001CB4 RID: 7348 RVA: 0x0008598C File Offset: 0x00083B8C
		public SecT239K1Curve() : base(239, 158, 0, 0)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.One);
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("2000000000000000000000000000005A79FEC67CB6E91F1C1DA800E478A5"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.ValueOf(4L);
			this.m_coord = 6;
		}

		// Token: 0x06001CB5 RID: 7349 RVA: 0x00085A05 File Offset: 0x00083C05
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Curve();
		}

		// Token: 0x06001CB6 RID: 7350 RVA: 0x00085A0C File Offset: 0x00083C0C
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 6;
		}

		// Token: 0x06001CB7 RID: 7351 RVA: 0x00085A15 File Offset: 0x00083C15
		protected override global::Org.BouncyCastle.Math.EC.Multiplier.ECMultiplier CreateDefaultMultiplier()
		{
			return new global::Org.BouncyCastle.Math.EC.Multiplier.WTauNafMultiplier();
		}

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06001CB8 RID: 7352 RVA: 0x00085A1C File Offset: 0x00083C1C
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06001CB9 RID: 7353 RVA: 0x00085A24 File Offset: 0x00083C24
		public override int FieldSize
		{
			get
			{
				return 239;
			}
		}

		// Token: 0x06001CBA RID: 7354 RVA: 0x00085A2B File Offset: 0x00083C2B
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(x);
		}

		// Token: 0x06001CBB RID: 7355 RVA: 0x00085A33 File Offset: 0x00083C33
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point(this, x, y, withCompression);
		}

		// Token: 0x06001CBC RID: 7356 RVA: 0x00085A3E File Offset: 0x00083C3E
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06001CBD RID: 7357 RVA: 0x00085A4B File Offset: 0x00083C4B
		public override bool IsKoblitz
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06001CBE RID: 7358 RVA: 0x00085A4E File Offset: 0x00083C4E
		public virtual int M
		{
			get
			{
				return 239;
			}
		}

		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06001CBF RID: 7359 RVA: 0x00085A55 File Offset: 0x00083C55
		public virtual bool IsTrinomial
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06001CC0 RID: 7360 RVA: 0x00085A58 File Offset: 0x00083C58
		public virtual int K1
		{
			get
			{
				return 158;
			}
		}

		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06001CC1 RID: 7361 RVA: 0x00085A5F File Offset: 0x00083C5F
		public virtual int K2
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x170003D2 RID: 978
		// (get) Token: 0x06001CC2 RID: 7362 RVA: 0x00085A62 File Offset: 0x00083C62
		public virtual int K3
		{
			get
			{
				return 0;
			}
		}

		// Token: 0x06001CC3 RID: 7363 RVA: 0x00085A68 File Offset: 0x00083C68
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			ulong[] table = new ulong[len * 4 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 4;
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy64(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 4;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Curve.SecT239K1LookupTable(this, table, len);
		}

		// Token: 0x04000AC7 RID: 2759
		private const int SECT239K1_DEFAULT_COORDS = 6;

		// Token: 0x04000AC8 RID: 2760
		private const int SECT239K1_FE_LONGS = 4;

		// Token: 0x04000AC9 RID: 2761
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECT239K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000ACA RID: 2762
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Point m_infinity;

		// Token: 0x020007EB RID: 2027
		private class SecT239K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045FB RID: 17915 RVA: 0x001357C6 File Offset: 0x001339C6
			internal SecT239K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Curve outer, ulong[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A99 RID: 2713
			// (get) Token: 0x060045FC RID: 17916 RVA: 0x001357E3 File Offset: 0x001339E3
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045FD RID: 17917 RVA: 0x001357EC File Offset: 0x001339EC
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

			// Token: 0x060045FE RID: 17918 RVA: 0x00135878 File Offset: 0x00133A78
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

			// Token: 0x060045FF RID: 17919 RVA: 0x001358C7 File Offset: 0x00133AC7
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(ulong[] x, ulong[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Curve.SECT239K1_AFFINE_ZS, false);
			}

			// Token: 0x04002462 RID: 9314
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecT239K1Curve m_outer;

			// Token: 0x04002463 RID: 9315
			private readonly ulong[] m_table;

			// Token: 0x04002464 RID: 9316
			private readonly int m_size;
		}
	}
}
