using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Pkcs
{
	// Token: 0x020006B2 RID: 1714
	public class IssuerAndSerialNumber : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x06003EC4 RID: 16068 RVA: 0x0011DF63 File Offset: 0x0011C163
		public static global::Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber)
			{
				return (global::Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Pkcs.IssuerAndSerialNumber((global::Org.BouncyCastle.Asn1.Asn1Sequence)obj);
			}
			throw new global::System.ArgumentException("Unknown object in factory: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x06003EC5 RID: 16069 RVA: 0x0011DFA4 File Offset: 0x0011C1A4
		private IssuerAndSerialNumber(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			if (seq.Count != 2)
			{
				throw new global::System.ArgumentException("Wrong number of elements in sequence", "seq");
			}
			this.name = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(seq[0]);
			this.certSerialNumber = global::Org.BouncyCastle.Asn1.DerInteger.GetInstance(seq[1]);
		}

		// Token: 0x06003EC6 RID: 16070 RVA: 0x0011DFF4 File Offset: 0x0011C1F4
		public IssuerAndSerialNumber(global::Org.BouncyCastle.Asn1.X509.X509Name name, global::Org.BouncyCastle.Math.BigInteger certSerialNumber)
		{
			this.name = name;
			this.certSerialNumber = new global::Org.BouncyCastle.Asn1.DerInteger(certSerialNumber);
		}

		// Token: 0x06003EC7 RID: 16071 RVA: 0x0011E00F File Offset: 0x0011C20F
		public IssuerAndSerialNumber(global::Org.BouncyCastle.Asn1.X509.X509Name name, global::Org.BouncyCastle.Asn1.DerInteger certSerialNumber)
		{
			this.name = name;
			this.certSerialNumber = certSerialNumber;
		}

		// Token: 0x170008AD RID: 2221
		// (get) Token: 0x06003EC8 RID: 16072 RVA: 0x0011E025 File Offset: 0x0011C225
		public global::Org.BouncyCastle.Asn1.X509.X509Name Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170008AE RID: 2222
		// (get) Token: 0x06003EC9 RID: 16073 RVA: 0x0011E02D File Offset: 0x0011C22D
		public global::Org.BouncyCastle.Asn1.DerInteger CertificateSerialNumber
		{
			get
			{
				return this.certSerialNumber;
			}
		}

		// Token: 0x06003ECA RID: 16074 RVA: 0x0011E035 File Offset: 0x0011C235
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.name,
				this.certSerialNumber
			});
		}

		// Token: 0x04001C76 RID: 7286
		private readonly global::Org.BouncyCastle.Asn1.X509.X509Name name;

		// Token: 0x04001C77 RID: 7287
		private readonly global::Org.BouncyCastle.Asn1.DerInteger certSerialNumber;
	}
}
