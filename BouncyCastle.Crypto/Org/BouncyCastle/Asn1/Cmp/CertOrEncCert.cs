using System;
using Org.BouncyCastle.Asn1.Crmf;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x0200076E RID: 1902
	public class CertOrEncCert : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x060043E1 RID: 17377 RVA: 0x0012F444 File Offset: 0x0012D644
		private CertOrEncCert(global::Org.BouncyCastle.Asn1.Asn1TaggedObject tagged)
		{
			if (tagged.TagNo == 0)
			{
				this.certificate = global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate.GetInstance(tagged.GetObject());
				return;
			}
			if (tagged.TagNo == 1)
			{
				this.encryptedCert = global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue.GetInstance(tagged.GetObject());
				return;
			}
			throw new global::System.ArgumentException("unknown tag: " + tagged.TagNo.ToString(), "tagged");
		}

		// Token: 0x060043E2 RID: 17378 RVA: 0x0012F4AE File Offset: 0x0012D6AE
		public static global::Org.BouncyCastle.Asn1.Cmp.CertOrEncCert GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.CertOrEncCert)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.CertOrEncCert)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CertOrEncCert((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj);
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x060043E3 RID: 17379 RVA: 0x0012F4ED File Offset: 0x0012D6ED
		public CertOrEncCert(global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate certificate)
		{
			if (certificate == null)
			{
				throw new global::System.ArgumentNullException("certificate");
			}
			this.certificate = certificate;
		}

		// Token: 0x060043E4 RID: 17380 RVA: 0x0012F50A File Offset: 0x0012D70A
		public CertOrEncCert(global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue encryptedCert)
		{
			if (encryptedCert == null)
			{
				throw new global::System.ArgumentNullException("encryptedCert");
			}
			this.encryptedCert = encryptedCert;
		}

		// Token: 0x17000A27 RID: 2599
		// (get) Token: 0x060043E5 RID: 17381 RVA: 0x0012F527 File Offset: 0x0012D727
		public virtual global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate Certificate
		{
			get
			{
				return this.certificate;
			}
		}

		// Token: 0x17000A28 RID: 2600
		// (get) Token: 0x060043E6 RID: 17382 RVA: 0x0012F52F File Offset: 0x0012D72F
		public virtual global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue EncryptedCert
		{
			get
			{
				return this.encryptedCert;
			}
		}

		// Token: 0x060043E7 RID: 17383 RVA: 0x0012F537 File Offset: 0x0012D737
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.certificate != null)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 0, this.certificate);
			}
			return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, this.encryptedCert);
		}

		// Token: 0x0400209F RID: 8351
		private readonly global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate certificate;

		// Token: 0x040020A0 RID: 8352
		private readonly global::Org.BouncyCastle.Asn1.Crmf.EncryptedValue encryptedCert;
	}
}
