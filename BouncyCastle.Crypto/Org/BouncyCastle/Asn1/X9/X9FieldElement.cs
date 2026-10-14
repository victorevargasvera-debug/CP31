using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Math.EC;

namespace Org.BouncyCastle.Asn1.X9
{
	// Token: 0x02000639 RID: 1593
	public class X9FieldElement : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003B1A RID: 15130 RVA: 0x001108EC File Offset: 0x0010EAEC
		public X9FieldElement(global::Org.BouncyCastle.Math.EC.ECFieldElement f)
		{
			this.f = f;
		}

		// Token: 0x06003B1B RID: 15131 RVA: 0x001108FB File Offset: 0x0010EAFB
		[global::System.Obsolete("Will be removed")]
		public X9FieldElement(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Asn1.Asn1OctetString s) : this(new global::Org.BouncyCastle.Math.EC.FpFieldElement(p, new global::Org.BouncyCastle.Math.BigInteger(1, s.GetOctets())))
		{
		}

		// Token: 0x06003B1C RID: 15132 RVA: 0x00110915 File Offset: 0x0010EB15
		[global::System.Obsolete("Will be removed")]
		public X9FieldElement(int m, int k1, int k2, int k3, global::Org.BouncyCastle.Asn1.Asn1OctetString s) : this(new global::Org.BouncyCastle.Math.EC.F2mFieldElement(m, k1, k2, k3, new global::Org.BouncyCastle.Math.BigInteger(1, s.GetOctets())))
		{
		}

		// Token: 0x170007D8 RID: 2008
		// (get) Token: 0x06003B1D RID: 15133 RVA: 0x00110934 File Offset: 0x0010EB34
		public global::Org.BouncyCastle.Math.EC.ECFieldElement Value
		{
			get
			{
				return this.f;
			}
		}

		// Token: 0x06003B1E RID: 15134 RVA: 0x0011093C File Offset: 0x0010EB3C
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			int byteCount = global::Org.BouncyCastle.Asn1.X9.X9IntegerConverter.GetByteLength(this.f);
			return new global::Org.BouncyCastle.Asn1.DerOctetString(global::Org.BouncyCastle.Asn1.X9.X9IntegerConverter.IntegerToBytes(this.f.ToBigInteger(), byteCount));
		}

		// Token: 0x040019D9 RID: 6617
		private global::Org.BouncyCastle.Math.EC.ECFieldElement f;
	}
}
