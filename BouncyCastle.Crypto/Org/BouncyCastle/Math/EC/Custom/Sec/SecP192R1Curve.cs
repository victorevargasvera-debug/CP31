using System;
using Org.BouncyCastle.Math.Raw;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities.Encoders;

namespace Org.BouncyCastle.Math.EC.Custom.Sec
{
	// Token: 0x02000255 RID: 597
	internal class SecP192R1Curve : global::Org.BouncyCastle.Math.EC.AbstractFpCurve
	{
		// Token: 0x06001867 RID: 6247 RVA: 0x00074DFC File Offset: 0x00072FFC
		public SecP192R1Curve() : base(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Curve.q)
		{
			this.m_infinity = new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Point(this, null, null);
			this.m_a = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFFFFFFFFFEFFFFFFFFFFFFFFFC")));
			this.m_b = this.FromBigInteger(new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("64210519E59C80E70FA7E9AB72243049FEB8DEECC146B9B1")));
			this.m_order = new global::Org.BouncyCastle.Math.BigInteger(1, global::Org.BouncyCastle.Utilities.Encoders.Hex.DecodeStrict("FFFFFFFFFFFFFFFFFFFFFFFF99DEF836146BC9B1B4D22831"));
			this.m_cofactor = global::Org.BouncyCastle.Math.BigInteger.One;
			this.m_coord = 2;
		}

		// Token: 0x06001868 RID: 6248 RVA: 0x00074E82 File Offset: 0x00073082
		protected override global::Org.BouncyCastle.Math.EC.ECCurve CloneCurve()
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Curve();
		}

		// Token: 0x06001869 RID: 6249 RVA: 0x00074E89 File Offset: 0x00073089
		public override bool SupportsCoordinateSystem(int coord)
		{
			return coord == 2;
		}

		// Token: 0x170002F0 RID: 752
		// (get) Token: 0x0600186A RID: 6250 RVA: 0x00074E92 File Offset: 0x00073092
		public virtual global::Org.BouncyCastle.Math.BigInteger Q
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Curve.q;
			}
		}

		// Token: 0x170002F1 RID: 753
		// (get) Token: 0x0600186B RID: 6251 RVA: 0x00074E99 File Offset: 0x00073099
		public override global::Org.BouncyCastle.Math.EC.ECPoint Infinity
		{
			get
			{
				return this.m_infinity;
			}
		}

		// Token: 0x170002F2 RID: 754
		// (get) Token: 0x0600186C RID: 6252 RVA: 0x00074EA1 File Offset: 0x000730A1
		public override int FieldSize
		{
			get
			{
				return global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Curve.q.BitLength;
			}
		}

		// Token: 0x0600186D RID: 6253 RVA: 0x00074EAD File Offset: 0x000730AD
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement FromBigInteger(global::Org.BouncyCastle.Math.BigInteger x)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(x);
		}

		// Token: 0x0600186E RID: 6254 RVA: 0x00074EB5 File Offset: 0x000730B5
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Point(this, x, y, withCompression);
		}

		// Token: 0x0600186F RID: 6255 RVA: 0x00074EC0 File Offset: 0x000730C0
		protected internal override global::Org.BouncyCastle.Math.EC.ECPoint CreateRawPoint(global::Org.BouncyCastle.Math.EC.ECFieldElement x, global::Org.BouncyCastle.Math.EC.ECFieldElement y, global::Org.BouncyCastle.Math.EC.ECFieldElement[] zs, bool withCompression)
		{
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Point(this, x, y, zs, withCompression);
		}

		// Token: 0x06001870 RID: 6256 RVA: 0x00074ED0 File Offset: 0x000730D0
		public override global::Org.BouncyCastle.Math.EC.ECLookupTable CreateCacheSafeLookupTable(global::Org.BouncyCastle.Math.EC.ECPoint[] points, int off, int len)
		{
			uint[] table = new uint[len * 6 * 2];
			int pos = 0;
			for (int i = 0; i < len; i++)
			{
				global::Org.BouncyCastle.Math.EC.ECPoint ecpoint = points[off + i];
				global::Org.BouncyCastle.Math.Raw.Nat192.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement)ecpoint.RawXCoord).x, 0, table, pos);
				pos += 6;
				global::Org.BouncyCastle.Math.Raw.Nat192.Copy(((global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement)ecpoint.RawYCoord).x, 0, table, pos);
				pos += 6;
			}
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Curve.SecP192R1LookupTable(this, table, len);
		}

		// Token: 0x06001871 RID: 6257 RVA: 0x00074F3C File Offset: 0x0007313C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElement(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.Random(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(x);
		}

		// Token: 0x06001872 RID: 6258 RVA: 0x00074F5C File Offset: 0x0007315C
		public override global::Org.BouncyCastle.Math.EC.ECFieldElement RandomFieldElementMult(global::Org.BouncyCastle.Security.SecureRandom r)
		{
			uint[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
			global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Field.RandomMult(r, x);
			return new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(x);
		}

		// Token: 0x04000A34 RID: 2612
		public static readonly global::Org.BouncyCastle.Math.BigInteger q = global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement.Q;

		// Token: 0x04000A35 RID: 2613
		private const int SECP192R1_DEFAULT_COORDS = 2;

		// Token: 0x04000A36 RID: 2614
		private const int SECP192R1_FE_INTS = 6;

		// Token: 0x04000A37 RID: 2615
		private static readonly global::Org.BouncyCastle.Math.EC.ECFieldElement[] SECP192R1_AFFINE_ZS = new global::Org.BouncyCastle.Math.EC.ECFieldElement[]
		{
			new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(global::Org.BouncyCastle.Math.BigInteger.One)
		};

		// Token: 0x04000A38 RID: 2616
		protected readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Point m_infinity;

		// Token: 0x020007D9 RID: 2009
		private class SecP192R1LookupTable : global::Org.BouncyCastle.Math.EC.AbstractECLookupTable
		{
			// Token: 0x060045A1 RID: 17825 RVA: 0x0013436E File Offset: 0x0013256E
			internal SecP192R1LookupTable(global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Curve outer, uint[] table, int size)
			{
				this.m_outer = outer;
				this.m_table = table;
				this.m_size = size;
			}

			// Token: 0x17000A87 RID: 2695
			// (get) Token: 0x060045A2 RID: 17826 RVA: 0x0013438B File Offset: 0x0013258B
			public override int Size
			{
				get
				{
					return this.m_size;
				}
			}

			// Token: 0x060045A3 RID: 17827 RVA: 0x00134394 File Offset: 0x00132594
			public override global::Org.BouncyCastle.Math.EC.ECPoint Lookup(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
				int pos = 0;
				for (int i = 0; i < this.m_size; i++)
				{
					uint MASK = (uint)((i ^ index) - 1 >> 31);
					for (int j = 0; j < 6; j++)
					{
						x[j] ^= (this.m_table[pos + j] & MASK);
						y[j] ^= (this.m_table[pos + 6 + j] & MASK);
					}
					pos += 12;
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045A4 RID: 17828 RVA: 0x00134420 File Offset: 0x00132620
			public override global::Org.BouncyCastle.Math.EC.ECPoint LookupVar(int index)
			{
				uint[] x = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
				uint[] y = global::Org.BouncyCastle.Math.Raw.Nat192.Create();
				int pos = index * 6 * 2;
				for (int i = 0; i < 6; i++)
				{
					x[i] = this.m_table[pos + i];
					y[i] = this.m_table[pos + 6 + i];
				}
				return this.CreatePoint(x, y);
			}

			// Token: 0x060045A5 RID: 17829 RVA: 0x0013446F File Offset: 0x0013266F
			private global::Org.BouncyCastle.Math.EC.ECPoint CreatePoint(uint[] x, uint[] y)
			{
				return this.m_outer.CreateRawPoint(new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(x), new global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1FieldElement(y), global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Curve.SECP192R1_AFFINE_ZS, false);
			}

			// Token: 0x0400242C RID: 9260
			private readonly global::Org.BouncyCastle.Math.EC.Custom.Sec.SecP192R1Curve m_outer;

			// Token: 0x0400242D RID: 9261
			private readonly uint[] m_table;

			// Token: 0x0400242E RID: 9262
			private readonly int m_size;
		}
	}
}
