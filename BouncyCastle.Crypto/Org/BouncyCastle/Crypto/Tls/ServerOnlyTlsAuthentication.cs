using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000347 RID: 839
	public abstract class ServerOnlyTlsAuthentication : global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication
	{
		// Token: 0x0600229C RID: 8860
		public abstract void NotifyServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate);

		// Token: 0x0600229D RID: 8861 RVA: 0x00098759 File Offset: 0x00096959
		public global::Org.BouncyCastle.Crypto.Tls.TlsCredentials GetClientCredentials(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest)
		{
			return null;
		}
	}
}
