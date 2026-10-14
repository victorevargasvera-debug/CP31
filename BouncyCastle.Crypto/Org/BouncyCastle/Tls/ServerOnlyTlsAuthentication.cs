using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000EA RID: 234
	public abstract class ServerOnlyTlsAuthentication : global::Org.BouncyCastle.Tls.TlsAuthentication
	{
		// Token: 0x06000889 RID: 2185
		public abstract void NotifyServerCertificate(global::Org.BouncyCastle.Tls.TlsServerCertificate serverCertificate);

		// Token: 0x0600088A RID: 2186 RVA: 0x00022CD0 File Offset: 0x00020ED0
		public global::Org.BouncyCastle.Tls.TlsCredentials GetClientCredentials(global::Org.BouncyCastle.Tls.CertificateRequest certificateRequest)
		{
			return null;
		}
	}
}
