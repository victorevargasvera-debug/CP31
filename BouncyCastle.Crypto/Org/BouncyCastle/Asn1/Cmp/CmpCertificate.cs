using System;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Asn1.Cmp
{
	// Token: 0x02000773 RID: 1907
	public class CmpCertificate : global::Org.BouncyCastle.Asn1.Asn1Encodable, global::Org.BouncyCastle.Asn1.IAsn1Choice
	{
		// Token: 0x06004402 RID: 17410 RVA: 0x0012FA9C File Offset: 0x0012DC9C
		public CmpCertificate(global::Org.BouncyCastle.Asn1.X509.AttributeCertificate x509v2AttrCert)
		{
			this.x509v2AttrCert = x509v2AttrCert;
		}

		// Token: 0x06004403 RID: 17411 RVA: 0x0012FAAB File Offset: 0x0012DCAB
		public CmpCertificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure x509v3PKCert)
		{
			if (x509v3PKCert.Version != 3)
			{
				throw new global::System.ArgumentException("only version 3 certificates allowed", "x509v3PKCert");
			}
			this.x509v3PKCert = x509v3PKCert;
		}

		// Token: 0x06004404 RID: 17412 RVA: 0x0012FAD4 File Offset: 0x0012DCD4
		public static global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate GetInstance(object obj)
		{
			if (obj is global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate)
			{
				return (global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate)obj;
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1Sequence)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate(global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure.GetInstance(obj));
			}
			if (obj is global::Org.BouncyCastle.Asn1.Asn1TaggedObject)
			{
				return new global::Org.BouncyCastle.Asn1.Cmp.CmpCertificate(global::Org.BouncyCastle.Asn1.X509.AttributeCertificate.GetInstance(((global::Org.BouncyCastle.Asn1.Asn1TaggedObject)obj).GetObject()));
			}
			throw new global::System.ArgumentException("Invalid object: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(obj), "obj");
		}

		// Token: 0x17000A30 RID: 2608
		// (get) Token: 0x06004405 RID: 17413 RVA: 0x0012FB3C File Offset: 0x0012DD3C
		public virtual bool IsX509v3PKCert
		{
			get
			{
				return this.x509v3PKCert != null;
			}
		}

		// Token: 0x17000A31 RID: 2609
		// (get) Token: 0x06004406 RID: 17414 RVA: 0x0012FB47 File Offset: 0x0012DD47
		public virtual global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure X509v3PKCert
		{
			get
			{
				return this.x509v3PKCert;
			}
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06004407 RID: 17415 RVA: 0x0012FB4F File Offset: 0x0012DD4F
		public virtual global::Org.BouncyCastle.Asn1.X509.AttributeCertificate X509v2AttrCert
		{
			get
			{
				return this.x509v2AttrCert;
			}
		}

		// Token: 0x06004408 RID: 17416 RVA: 0x0012FB57 File Offset: 0x0012DD57
		public override global::Org.BouncyCastle.Asn1.Asn1Object ToAsn1Object()
		{
			if (this.x509v2AttrCert != null)
			{
				return new global::Org.BouncyCastle.Asn1.DerTaggedObject(true, 1, this.x509v2AttrCert);
			}
			return this.x509v3PKCert.ToAsn1Object();
		}

		// Token: 0x040020AD RID: 8365
		private readonly global::Org.BouncyCastle.Asn1.X509.X509CertificateStructure x509v3PKCert;

		// Token: 0x040020AE RID: 8366
		private readonly global::Org.BouncyCastle.Asn1.X509.AttributeCertificate x509v2AttrCert;
	}
}
