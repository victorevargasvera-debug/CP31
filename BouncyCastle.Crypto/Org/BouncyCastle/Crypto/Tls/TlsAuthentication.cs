using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000357 RID: 855
	public interface TlsAuthentication
	{
		// Token: 0x060022F1 RID: 8945
		void NotifyServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate);

		// Token: 0x060022F2 RID: 8946
		global::Org.BouncyCastle.Crypto.Tls.TlsCredentials GetClientCredentials(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest);
	}
}
