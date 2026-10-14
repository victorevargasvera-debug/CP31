using System;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.X509
{
	// Token: 0x02000669 RID: 1641
	public class RsaPublicKeyStructure : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003C8C RID: 15500 RVA: 0x00115071 File Offset: 0x00113271
		public static global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure GetInstance(global::Org.BouncyCastle.Asn1.Asn1TaggedObject obj, bool explicitly)
		{
			return global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure.GetInstance(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj, explicitly));
		}

		// Token: 0x06003C8D RID: 15501 RVA: 0x0011507F File Offset: 0x0011327F
		public static global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure GetInstance(object obj)
		{
			if (obj == null || obj is global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure)
			{
				return (global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.X509.RsaPublicKeyStructure((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Invalid RsaPublicKeyStructure: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj));
		}

		// Token: 0x06003C8E RID: 15502 RVA: 0x001150BC File Offset: 0x001132BC
		public RsaPublicKeyStructure(global::Org.BouncyCastle.Math.BigInteger modulus, global::Org.BouncyCastle.Math.BigInteger publicExponent)
		{
			if (modulus == null)
			{
				throw new global::System.ArgumentNullException("modulus");
			}
			if (publicExponent == null)
			{
				throw new global::System.ArgumentNullException("publicExponent");
			}
			if (modulus.SignValue <= 0)
			{
				throw new global::System.ArgumentException("Not a valid RSA modulus", "modulus");
			}
			if (publicExponent.SignValue <= 0)
			{
				throw new global::System.ArgumentException("Not a valid RSA public exponent", "publicExponent");
			}
			this.modulus = modulus;
			this.publicExponent = publicExponent;
		}

		// Token: 0x06003C8F RID: 15503 RVA: 0x0011512C File Offset: 0x0011332C
		private RsaPublicKeyStructure(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Bad sequence size: " + seq.Count.ToString());
			}
			this.modulus = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[0]).PositiveValue;
			this.publicExponent = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]).PositiveValue;
		}

		// Token: 0x1700082D RID: 2093
		// (get) Token: 0x06003C90 RID: 15504 RVA: 0x00115194 File Offset: 0x00113394
		public global::Org.BouncyCastle.Math.BigInteger Modulus
		{
			get
			{
				return this.modulus;
			}
		}

		// Token: 0x1700082E RID: 2094
		// (get) Token: 0x06003C91 RID: 15505 RVA: 0x0011519C File Offset: 0x0011339C
		public global::Org.BouncyCastle.Math.BigInteger PublicExponent
		{
			get
			{
				return this.publicExponent;
			}
		}

		// Token: 0x06003C92 RID: 15506 RVA: 0x001151A4 File Offset: 0x001133A4
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				new global::Org.BouncyCastle.Asn1.DerInteger(this.Modulus),
				new global::Org.BouncyCastle.Asn1.DerInteger(this.PublicExponent)
			});
		}

		// Token: 0x04001ABF RID: 6847
		private global::Org.BouncyCastle.Math.BigInteger modulus;

		// Token: 0x04001AC0 RID: 6848
		private global::Org.BouncyCastle.Math.BigInteger publicExponent;
	}
}
