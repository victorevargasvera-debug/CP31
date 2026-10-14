using System;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001E6 RID: 486
	public class Req : global::Org.BouncyCastle.X509.X509ExtensionBase
	{
		// Token: 0x060011E8 RID: 4584 RVA: 0x0004F29C File Offset: 0x0004D49C
		public Req(global::Org.BouncyCastle.Asn1.Ocsp.Request req)
		{
			this.req = req;
		}

		// Token: 0x060011E9 RID: 4585 RVA: 0x0004F2AB File Offset: 0x0004D4AB
		public global::Org.BouncyCastle.Ocsp.CertificateID GetCertID()
		{
			return new global::Org.BouncyCastle.Ocsp.CertificateID(this.req.ReqCert);
		}

		// Token: 0x17000255 RID: 597
		// (get) Token: 0x060011EA RID: 4586 RVA: 0x0004F2BD File Offset: 0x0004D4BD
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions SingleRequestExtensions
		{
			get
			{
				return this.req.SingleRequestExtensions;
			}
		}

		// Token: 0x060011EB RID: 4587 RVA: 0x0004F2CA File Offset: 0x0004D4CA
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			return this.SingleRequestExtensions;
		}

		// Token: 0x040008FC RID: 2300
		private global::Org.BouncyCastle.Asn1.Ocsp.Request req;
	}
}
