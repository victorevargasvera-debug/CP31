using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x020000FF RID: 255
	public interface TlsCredentialedAgreement : global::Org.BouncyCastle.Tls.TlsCredentials
	{
		// Token: 0x06000934 RID: 2356
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret GenerateAgreement(global::Org.BouncyCastle.Tls.Crypto.TlsCertificate peerCertificate);
	}
}
