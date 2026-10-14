using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000261 RID: 609
	internal class SecP256K1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x06001936 RID: 6454 RVA: 0x00078054 File Offset: 0x00076254
		public SecP256K1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Point(this, null, null);
			this.m_a = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.Zero);
			this.m_b = this.FromBigInteger(global::Org.BouncyCastle.Math.BigInteger.ValueOf(7L));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEBAAEDCE6AF48A03BBFD25E8CD0364141"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x06001937 RID: 6455 RVA: 0x000780C6 File Offset: 0x000762C6
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve();
		}

		// Token: 0x06001938 RID: 6456 RVA: 0x000780CD File Offset: 0x000762CD
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x17000305 RID: 773
		// (get) Token: 0x06001939 RID: 6457 RVA: 0x000780D6 File Offset: 0x000762D6
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve.q;
			}
		}

		// Token: 0x17000306 RID: 774
		// (get) Token: 0x0600193A RID: 6458 RVA: 0x000780DD File Offset: 0x000762DD
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000307 RID: 775
		// (get) Token: 0x0600193B RID: 6459 RVA: 0x000780E5 File Offset: 0x000762E5
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve.q.BitLength;
			}
		}

		// Token: 0x0600193C RID: 6460 RVA: 0x000780F1 File Offset: 0x000762F1
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(x);
		}

		// Token: 0x0600193D RID: 6461 RVA: 0x000780F9 File Offset: 0x000762F9
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Point(this, x, y, withCompression);
		}

		// Token: 0x0600193E RID: 6462 RVA: 0x00078104 File Offset: 0x00076304
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x0600193F RID: 6463 RVA: 0x00078114 File Offset: 0x00076314
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 8 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 8;
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 8;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve.SecP256K1LookupTable(this, table, len);
		}

		// Token: 0x06001940 RID: 6464 RVA: 0x00078180 File Offset: 0x00076380
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(x);
		}

		// Token: 0x06001941 RID: 6465 RVA: 0x000781A0 File Offset: 0x000763A0
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(x);
		}

		// Token: 0x04000A5A RID: 2650
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement.Q;

		// Token: 0x04000A5B RID: 2651
		private const int SECP256K1_DEFAULT_COORDS = 2;

		// Token: 0x04000A5C RID: 2652
		private const int SECP256K1_FE_INTS = 8;

		// Token: 0x04000A5D RID: 2653
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP256K1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A5E RID: 2654
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Point m_infinity;

		// Token: 0x020007DC RID: 2012
		private class SecP256K1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045B0 RID: 17840 RVA: 0x001346CE File Offset: 0x001328CE
			internal SecP256K1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A8A RID: 2698
			// (get) Token: 0x060045B1 RID: 17841 RVA: 0x001346EB File Offset: 0x001328EB
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045B2 RID: 17842 RVA: 0x001346F4 File Offset: 0x001328F4
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					uint MASK = (uint)((i ^ index) - 1 >> 31);
					for (int j = 0; j < 8; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 8 + j] & MASK);
					}
					pos += 16;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045B3 RID: 17843 RVA: 0x00134780 File Offset: 0x00132980
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
				int pos = index * 8 * 2;
				for (int i = 0; i < 8; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 8 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045B4 RID: 17844 RVA: 0x001347CF File Offset: 0x001329CF
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve.SECP256K1_AFFINE_ZS, false);
			}

			// Token: 0x04002435 RID: 9269
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256K1Curve m_outer;

			// Token: 0x04002436 RID: 9270
			private readonly uint[] m_table;

			// Token: 0x04002437 RID: 9271
			private readonly int m_size;
		}
	}
}
