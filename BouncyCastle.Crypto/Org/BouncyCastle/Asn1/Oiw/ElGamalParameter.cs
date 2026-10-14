using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Oiw
{
	// Token: 0x020006C3 RID: 1731
	public class ElGamalParameter : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003F50 RID: 16208 RVA: 0x0011FFA4 File Offset: 0x0011E1A4
		public ElGamalParameter(global::Org.BouncyCastle.Math.BigInteger p, global::Org.BouncyCastle.Math.BigInteger g)
		{
			this.p = new global::Org.BouncyCastle.Asn1.DerInteger(p);
			this.g = new global::Org.BouncyCastle.Asn1.DerInteger(g);
		}

		// Token: 0x06003F51 RID: 16209 RVA: 0x0011FFC4 File Offset: 0x0011E1C4
		public ElGamalParameter(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.p = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]);
			this.g = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
		}

		// Token: 0x170008E1 RID: 2273
		// (get) Token: 0x06003F52 RID: 16210 RVA: 0x00120014 File Offset: 0x0011E214
		public global::Org.BouncyCastle.Math.BigInteger P
		{
			get
			{
				return this.p.PositiveValue;
			}
		}

		// Token: 0x170008E2 RID: 2274
		// (get) Token: 0x06003F53 RID: 16211 RVA: 0x00120021 File Offset: 0x0011E221
		public global::Org.BouncyCastle.Math.BigInteger G
		{
			get
			{
				return this.g.PositiveValue;
			}
		}

		// Token: 0x06003F54 RID: 16212 RVA: 0x0012002E File Offset: 0x0011E22E
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.p,
				this.g
			});
		}

		// Token: 0x04001D47 RID: 7495
		internal global::Org.BouncyCastle.Asn1.DerInteger p;

		// Token: 0x04001D48 RID: 7496
		internal global::Org.BouncyCastle.Asn1.DerInteger g;
	}
}
