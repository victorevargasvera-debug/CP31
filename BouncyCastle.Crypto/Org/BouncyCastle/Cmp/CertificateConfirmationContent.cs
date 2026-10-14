using System;
using Org.BouncyCastle.Asn1.Cmp;
using Org.BouncyCastle.Cms;

namespace Org.BouncyCastle.Cmp
{
	// Token: 0x0200055E RID: 1374
	public class CertificateConfirmationContent
	{
		// Token: 0x0600349E RID: 13470 RVA: 0x000FB7A1 File Offset: 0x000F99A1
		public CertificateConfirmationContent(global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent content)
		{
			this.content = content;
		}

		// Token: 0x0600349F RID: 13471 RVA: 0x000FB7B0 File Offset: 0x000F99B0
		public CertificateConfirmationContent(global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent content, global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder digestAlgFinder)
		{
			this.content = content;
			this.digestAlgFinder = digestAlgFinder;
		}

		// Token: 0x060034A0 RID: 13472 RVA: 0x000FB7C6 File Offset: 0x000F99C6
		public global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent ToAsn1Structure()
		{
			return this.content;
		}

		// Token: 0x060034A1 RID: 13473 RVA: 0x000FB7D0 File Offset: 0x000F99D0
		public global::Org.BouncyCastle.Cmp.CertificateStatus[] GetStatusMessages()
		{
			global::Org.BouncyCastle.Asn1.Cmp.CertStatus[] statusArray = this.content.ToCertStatusArray();
			global::Org.BouncyCastle.Cmp.CertificateStatus[] ret = new global::Org.BouncyCastle.Cmp.CertificateStatus[statusArray.Length];
			for (int i = 0; i != ret.Length; i++)
			{
				ret[i] = new global::Org.BouncyCastle.Cmp.CertificateStatus(this.digestAlgFinder, statusArray[i]);
			}
			return ret;
		}

		// Token: 0x04001788 RID: 6024
		private readonly global::Org.BouncyCastle.Cms.DefaultDigestAlgorithmIdentifierFinder digestAlgFinder;

		// Token: 0x04001789 RID: 6025
		private readonly global::Org.BouncyCastle.Asn1.Cmp.CertConfirmContent content;
	}
}
