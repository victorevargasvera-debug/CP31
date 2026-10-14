using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000374 RID: 884
	public interface TlsKeyExchange
	{
		// Token: 0x060023F1 RID: 9201
		void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context);

		// Token: 0x060023F2 RID: 9202
		void SkipServerCredentials();

		// Token: 0x060023F3 RID: 9203
		void ProcessServerCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials serverCredentials);

		// Token: 0x060023F4 RID: 9204
		void ProcessServerCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate serverCertificate);

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x060023F5 RID: 9205
		bool RequiresServerKeyExchange { get; }

		// Token: 0x060023F6 RID: 9206
		byte[] GenerateServerKeyExchange();

		// Token: 0x060023F7 RID: 9207
		void SkipServerKeyExchange();

		// Token: 0x060023F8 RID: 9208
		void ProcessServerKeyExchange(global::System.IO.Stream input);

		// Token: 0x060023F9 RID: 9209
		void ValidateCertificateRequest(global::Org.BouncyCastle.Crypto.Tls.CertificateRequest certificateRequest);

		// Token: 0x060023FA RID: 9210
		void SkipClientCredentials();

		// Token: 0x060023FB RID: 9211
		void ProcessClientCredentials(global::Org.BouncyCastle.Crypto.Tls.TlsCredentials clientCredentials);

		// Token: 0x060023FC RID: 9212
		void ProcessClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate);

		// Token: 0x060023FD RID: 9213
		void GenerateClientKeyExchange(global::System.IO.Stream output);

		// Token: 0x060023FE RID: 9214
		void ProcessClientKeyExchange(global::System.IO.Stream input);

		// Token: 0x060023FF RID: 9215
		byte[] GeneratePremasterSecret();
	}
}
