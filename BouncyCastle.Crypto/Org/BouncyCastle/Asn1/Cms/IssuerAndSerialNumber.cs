using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Asn1.Cms
{
	// Token: 0x0200074E RID: 1870
	public class IssuerAndSerialNumber : global::Org.BouncyCastle.Asn1.Asn1Encodable
	{
		// Token: 0x060042E0 RID: 17120 RVA: 0x0012CB18 File Offset: 0x0012AD18
		public static global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber GetInstance(object obj)
		{
			if (obj == null)
			{
				return null;
			}
			global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber existing = obj as global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber;
			if (existing != null)
			{
				return existing;
			}
			return new global::Org.BouncyCastle.Asn1.Cms.IssuerAndSerialNumber(global::Org.BouncyCastle.Asn1.Asn1Sequence.GetInstance(obj));
		}

		// Token: 0x060042E1 RID: 17121 RVA: 0x0012CB41 File Offset: 0x0012AD41
		[global::System.Obsolete("Use GetInstance() instead")]
		public IssuerAndSerialNumber(global::Org.BouncyCastle.Asn1.Asn1Sequence seq)
		{
			this.name = global::Org.BouncyCastle.Asn1.X509.X509Name.GetInstance(seq[0]);
			this.serialNumber = (global::Org.BouncyCastle.Asn1.DerInteger)seq[1];
		}

		// Token: 0x060042E2 RID: 17122 RVA: 0x0012CB6D File Offset: 0x0012AD6D
		public IssuerAndSerialNumber(global::Org.BouncyCastle.Asn1.X509.X509Name name, global::Org.BouncyCastle.Math.BigInteger serialNumber)
		{
			this.name = name;
			this.serialNumber = new global::Org.BouncyCastle.Asn1.DerInteger(serialNumber);
		}

		// Token: 0x060042E3 RID: 17123 RVA: 0x0012CB88 File Offset: 0x0012AD88
		public IssuerAndSerialNumber(global::Org.BouncyCastle.Asn1.X509.X509Name name, global::Org.BouncyCastle.Asn1.DerInteger serialNumber)
		{
			this.name = name;
			this.serialNumber = serialNumber;
		}

		// Token: 0x170009CD RID: 2509
		// (get) Token: 0x060042E4 RID: 17124 RVA: 0x0012CB9E File Offset: 0x0012AD9E
		public global::Org.BouncyCastle.Asn1.X509.X509Name Name
		{
			get
			{
				return this.name;
			}
		}

		// Token: 0x170009CE RID: 2510
		// (get) Token: 0x060042E5 RID: 17125 RVA: 0x0012CBA6 File Offset: 0x0012ADA6
		public global::Org.BouncyCastle.Asn1.DerInteger SerialNumber
		{
			get
			{
				return this.serialNumber;
			}
		}

		// Token: 0x060042E6 RID: 17126 RVA: 0x0012CBAE File Offset: 0x0012ADAE
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			return new global::Org.BouncyCastle.Asn1.DerSequence(new global::Org.BouncyCastle.Asn1.Asn1Encodable[]
			{
				this.name,
				this.serialNumber
			});
		}

		// Token: 0x0400203E RID: 8254
		private global::Org.BouncyCastle.Asn1.X509.X509Name name;

		// Token: 0x0400203F RID: 8255
		private global::Org.BouncyCastle.Asn1.DerInteger serialNumber;
	}
}
