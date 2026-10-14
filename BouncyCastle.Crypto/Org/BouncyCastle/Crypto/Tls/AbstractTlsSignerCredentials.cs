using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002FC RID: 764
	public abstract class AbstractTlsSignerCredentials : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsCredentials, global::Org.BouncyCastle.Crypto.Tls.TlsSignerCredentials, global::Org.BouncyCastle.Crypto.Tls.TlsCredentials
	{
		// Token: 0x060020C3 RID: 8387
		public abstract byte[] GenerateCertificateSignature(byte[] hash);

		// Token: 0x17000480 RID: 1152
		// (get) Token: 0x060020C4 RID: 8388 RVA: 0x00091D56 File Offset: 0x0008FF56
		public virtual global::Org.BouncyCastle.Crypto.Tls.SignatureAndHashAlgorithm SignatureAndHashAlgorithm
		{
			get
			{
				throw new global::System.InvalidOperationException("TlsSignerCredentials implementation does not support (D)TLS 1.2+");
			}
		}
	}
}
