using System;
using Org.BouncyCastle.Asn1;
using Org.BouncyCastle.Asn1.Ocsp;
using Org.BouncyCastle.Asn1.X509;

namespace Org.BouncyCastle.Ocsp
{
	// Token: 0x020001E9 RID: 489
	public class RevokedStatus : global::Org.BouncyCastle.Ocsp.CertificateStatus
	{
		// Token: 0x060011F9 RID: 4601 RVA: 0x0004F455 File Offset: 0x0004D655
		public RevokedStatus(global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo info)
		{
			this.info = info;
		}

		// Token: 0x060011FA RID: 4602 RVA: 0x0004F464 File Offset: 0x0004D664
		public RevokedStatus(global::System.DateTime revocationDate, int reason)
		{
			this.info = new global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo(new global::Org.BouncyCastle.Asn1.DerGeneralizedTime(revocationDate), new global::Org.BouncyCastle.Asn1.X509.CrlReason(reason));
		}

		// Token: 0x17000259 RID: 601
		// (get) Token: 0x060011FB RID: 4603 RVA: 0x0004F483 File Offset: 0x0004D683
		public global::System.DateTime RevocationTime
		{
			get
			{
				return this.info.RevocationTime.ToDateTime();
			}
		}

		// Token: 0x1700025A RID: 602
		// (get) Token: 0x060011FC RID: 4604 RVA: 0x0004F495 File Offset: 0x0004D695
		public bool HasRevocationReason
		{
			get
			{
				return this.info.RevocationReason != null;
			}
		}

		// Token: 0x1700025B RID: 603
		// (get) Token: 0x060011FD RID: 4605 RVA: 0x0004F4A5 File Offset: 0x0004D6A5
		public int RevocationReason
		{
			get
			{
				if (this.info.RevocationReason == null)
				{
					throw new global::System.InvalidOperationException("attempt to get a reason where none is available");
				}
				return this.info.RevocationReason.IntValueExact;
			}
		}

		// Token: 0x040008FF RID: 2303
		internal readonly global::Org.BouncyCastle.Asn1.Ocsp.RevokedInfo info;
	}
}
