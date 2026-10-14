using System;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;
using Org.BouncyCastle.Utilities.Date;
using Org.BouncyCastle.X509;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001EA RID: 490
	public class SingleResp : global::Org.BouncyCastle.X509.X509ExtensionBase
	{
		// Token: 0x060011FE RID: 4606 RVA: 0x0004F4CF File Offset: 0x0004D6CF
		public SingleResp(global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse resp)
		{
			this.resp = resp;
		}

		// Token: 0x060011FF RID: 4607 RVA: 0x0004F4DE File Offset: 0x0004D6DE
		public global::Org.BouncyCastle.Ocsp.CertificateID GetCertID()
		{
			return new global::Org.BouncyCastle.Ocsp.CertificateID(this.resp.CertId);
		}

		// Token: 0x06001200 RID: 4608 RVA: 0x0004F4F0 File Offset: 0x0004D6F0
		public object GetCertStatus()
		{
			global::Org.BouncyCastle.Asn1.Ocsp.CertStatus s = this.resp.CertStatus;
			if (s.TagNo == 0)
			{
				return null;
			}
			if (s.TagNo == 1)
			{
				return new global::Org.BouncyCastle.Ocsp.RevokedStatus(global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo.GetInstance(s.Status));
			}
			return new global::Org.BouncyCastle.Ocsp.UnknownStatus();
		}

		// Token: 0x1700025C RID: 604
		// (get) Token: 0x06001201 RID: 4609 RVA: 0x0004F532 File Offset: 0x0004D732
		public global::System.DateTime ThisUpdate
		{
			get
			{
				return this.resp.ThisUpdate.ToDateTime();
			}
		}

		// Token: 0x1700025D RID: 605
		// (get) Token: 0x06001202 RID: 4610 RVA: 0x0004F544 File Offset: 0x0004D744
		public global::Org.BouncyCastle.Utilities.Date.DateTimeObject NextUpdate
		{
			get
			{
				if (this.resp.NextUpdate != null)
				{
					return new global::Org.BouncyCastle.Utilities.Date.DateTimeObject(this.resp.NextUpdate.ToDateTime());
				}
				return null;
			}
		}

		// Token: 0x1700025E RID: 606
		// (get) Token: 0x06001203 RID: 4611 RVA: 0x0004F56A File Offset: 0x0004D76A
		public global::Org.BouncyCastle.Asn1.X509.X509Extensions SingleExtensions
		{
			get
			{
				return this.resp.SingleExtensions;
			}
		}

		// Token: 0x06001204 RID: 4612 RVA: 0x0004F577 File Offset: 0x0004D777
		protected override global::Org.BouncyCastle.Asn1.X509.X509Extensions GetX509Extensions()
		{
			return this.SingleExtensions;
		}

		// Token: 0x04000900 RID: 2304
		internal readonly global::Org.BouncyCastle.Asn1.Ocsp.SingleResponse resp;
	}
}
