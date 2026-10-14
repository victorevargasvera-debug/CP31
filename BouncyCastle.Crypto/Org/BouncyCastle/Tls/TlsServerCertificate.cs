using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200011F RID: 287
	public interface TlsServerCertificate
	{
		// Token: 0x170001C3 RID: 451
		// (get) Token: 0x06000B2E RID: 2862
		global::Org.BouncyCastle.Tls.Certificate Certificate { get; }

		// Token: 0x170001C4 RID: 452
		// (get) Token: 0x06000B2F RID: 2863
		global::Org.BouncyCastle.Tls.CertificateStatus CertificateStatus { get; }
	}
}
