using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000265 RID: 613
	internal class SecP256R1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x06001978 RID: 6520 RVA: 0x00078F68 File Offset: 0x00077168
		public SecP256R1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFF00000001000000000000000000000000FFFFFFFFFFFFFFFFFFFFFFFC")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("5AC635D8AA3A93E7B3EBBD55769886BC651D06B0CC53B0F63BCE3C3E27D2604B")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFF00000000FFFFFFFFFFFFFFFFBCE6FAADA7179E84F3B9CAC2FC632551"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x06001979 RID: 6521 RVA: 0x00078FEE File Offset: 0x000771EE
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve();
		}

		// Token: 0x0600197A RID: 6522 RVA: 0x00078FF5 File Offset: 0x000771F5
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x1700030C RID: 780
		// (get) Token: 0x0600197B RID: 6523 RVA: 0x00078FFE File Offset: 0x000771FE
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve.q;
			}
		}

		// Token: 0x1700030D RID: 781
		// (get) Token: 0x0600197C RID: 6524 RVA: 0x00079005 File Offset: 0x00077205
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x1700030E RID: 782
		// (get) Token: 0x0600197D RID: 6525 RVA: 0x0007900D File Offset: 0x0007720D
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve.q.BitLength;
			}
		}

		// Token: 0x0600197E RID: 6526 RVA: 0x00079019 File Offset: 0x00077219
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(x);
		}

		// Token: 0x0600197F RID: 6527 RVA: 0x00079021 File Offset: 0x00077221
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Point(this, x, y, withCompression);
		}

		// Token: 0x06001980 RID: 6528 RVA: 0x0007902C File Offset: 0x0007722C
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x06001981 RID: 6529 RVA: 0x0007903C File Offset: 0x0007723C
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 8 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 8;
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 8;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve.SecP256R1LookupTable(this, table, len);
		}

		// Token: 0x06001982 RID: 6530 RVA: 0x000790A8 File Offset: 0x000772A8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(x);
		}

		// Token: 0x06001983 RID: 6531 RVA: 0x000790C8 File Offset: 0x000772C8
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(x);
		}

		// Token: 0x04000A67 RID: 2663
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement.Q;

		// Token: 0x04000A68 RID: 2664
		private const int SECP256R1_DEFAULT_COORDS = 2;

		// Token: 0x04000A69 RID: 2665
		private const int SECP256R1_FE_INTS = 8;

		// Token: 0x04000A6A RID: 2666
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP256R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A6B RID: 2667
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Point m_infinity;

		// Token: 0x020007DD RID: 2013
		private class SecP256R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045B5 RID: 17845 RVA: 0x001347EE File Offset: 0x001329EE
			internal SecP256R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A8B RID: 2699
			// (get) Token: 0x060045B6 RID: 17846 RVA: 0x0013480B File Offset: 0x00132A0B
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045B7 RID: 17847 RVA: 0x00134814 File Offset: 0x00132A14
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

			// Token: 0x060045B8 RID: 17848 RVA: 0x001348A0 File Offset: 0x00132AA0
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

			// Token: 0x060045B9 RID: 17849 RVA: 0x001348EF File Offset: 0x00132AEF
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve.SECP256R1_AFFINE_ZS, false);
			}

			// Token: 0x04002438 RID: 9272
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP256R1Curve m_outer;

			// Token: 0x04002439 RID: 9273
			private readonly uint[] m_table;

			// Token: 0x0400243A RID: 9274
			private readonly int m_size;
		}
	}
}
