using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000F8 RID: 248
	public interface TlsAuthentication
	{
		// Token: 0x060008EB RID: 2283
		void NotifyServerCertificate(global::Org.BouncyCastle.Tls.TlsServerCertificate serverCertificate);

		// Token: 0x060008EC RID: 2284
		global::Org.BouncyCastle.Tls.TlsCredentials GetClientCredentials(global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest);
	}
}
