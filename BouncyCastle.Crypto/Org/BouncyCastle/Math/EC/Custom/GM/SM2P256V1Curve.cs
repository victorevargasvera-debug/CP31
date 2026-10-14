using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.GM
{
	// Token: 0x020002A7 RID: 679
	internal class SM2P256V1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x06001E20 RID: 7712 RVA: 0x0008BD18 File Offset: 0x00089F18
		public SM2P256V1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFF00000000FFFFFFFFFFFFFFFC")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("28E9FA9E9D9F5E344D5A9E4BCF6509A7F39789F515AB8F92DDBCBD414D940E93")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFEFFFFFFFFFFFFFFFFFFFFFFFF7203DF6B21C6052B53BBF40939D54123"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x06001E21 RID: 7713 RVA: 0x0008BD9E File Offset: 0x00089F9E
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Curve();
		}

		// Token: 0x06001E22 RID: 7714 RVA: 0x0008BDA5 File Offset: 0x00089FA5
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x1700042F RID: 1071
		// (get) Token: 0x06001E23 RID: 7715 RVA: 0x0008BDAE File Offset: 0x00089FAE
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Curve.q;
			}
		}

		// Token: 0x17000430 RID: 1072
		// (get) Token: 0x06001E24 RID: 7716 RVA: 0x0008BDB5 File Offset: 0x00089FB5
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x17000431 RID: 1073
		// (get) Token: 0x06001E25 RID: 7717 RVA: 0x0008BDBD File Offset: 0x00089FBD
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Curve.q.BitLength;
			}
		}

		// Token: 0x06001E26 RID: 7718 RVA: 0x0008BDC9 File Offset: 0x00089FC9
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(x);
		}

		// Token: 0x06001E27 RID: 7719 RVA: 0x0008BDD1 File Offset: 0x00089FD1
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Point(this, x, y, withCompression);
		}

		// Token: 0x06001E28 RID: 7720 RVA: 0x0008BDDC File Offset: 0x00089FDC
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x06001E29 RID: 7721 RVA: 0x0008BDEC File Offset: 0x00089FEC
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 8 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy(((global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 8;
				global::Org.BouncyCastle.Math.Raw.Nat256.Copy(((global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 8;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Curve.SM2P256V1LookupTable(this, table, len);
		}

		// Token: 0x06001E2A RID: 7722 RVA: 0x0008BE58 File Offset: 0x0008A058
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(x);
		}

		// Token: 0x06001E2B RID: 7723 RVA: 0x0008BE78 File Offset: 0x0008A078
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat256.Create();
			global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(x);
		}

		// Token: 0x04000AEF RID: 2799
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement.Q;

		// Token: 0x04000AF0 RID: 2800
		private const int SM2P256V1_DEFAULT_COORDS = 2;

		// Token: 0x04000AF1 RID: 2801
		private const int SM2P256V1_FE_INTS = 8;

		// Token: 0x04000AF2 RID: 2802
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SM2P256V1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000AF3 RID: 2803
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Point m_infinity;

		// Token: 0x020007F2 RID: 2034
		private class SM2P256V1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x0600461E RID: 17950 RVA: 0x00135FAD File Offset: 0x001341AD
			internal SM2P256V1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000AA0 RID: 2720
			// (get) Token: 0x0600461F RID: 17951 RVA: 0x00135FCA File Offset: 0x001341CA
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x06004620 RID: 17952 RVA: 0x00135FD4 File Offset: 0x001341D4
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

			// Token: 0x06004621 RID: 17953 RVA: 0x00136060 File Offset: 0x00134260
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

			// Token: 0x06004622 RID: 17954 RVA: 0x001360AF File Offset: 0x001342AF
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Curve.SM2P256V1_AFFINE_ZS, false);
			}

			// Token: 0x04002477 RID: 9335
			private readonly global::Org.BouncyCastle.Math.EC.Custom.GM.SM2P256V1Curve m_outer;

			// Token: 0x04002478 RID: 9336
			private readonly uint[] m_table;

			// Token: 0x04002479 RID: 9337
			private readonly int m_size;
		}
	}
}
