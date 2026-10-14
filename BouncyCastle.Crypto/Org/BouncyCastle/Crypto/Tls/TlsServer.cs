using System;
using System.Collections;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000382 RID: 898
	public interface TlsServer : global::Org.BouncyCastle.Crypto.Tls.TlsPeer
	{
		// Token: 0x06002488 RID: 9352
		void Init(global::Org.BouncyCastle.Crypto.Tls.TlsServerContext context);

		// Token: 0x06002489 RID: 9353
		void NotifyClientVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion clientVersion);

		// Token: 0x0600248A RID: 9354
		void NotifyFallback(bool isFallback);

		// Token: 0x0600248B RID: 9355
		void NotifyOfferedCipherSuites(int[] offeredCipherSuites);

		// Token: 0x0600248C RID: 9356
		void NotifyOfferedCompressionMethods(byte[] offeredCompressionMethods);

		// Token: 0x0600248D RID: 9357
		void ProcessClientExtensions(global::System.Collections.IDictionary clientExtensions);

		// Token: 0x0600248E RID: 9358
		global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion GetServerVersion();

		// Token: 0x0600248F RID: 9359
		int GetSelectedCipherSuite();

		// Token: 0x06002490 RID: 9360
		byte GetSelectedCompressionMethod();

		// Token: 0x06002491 RID: 9361
		global::System.Collections.IDictionary GetServerExtensions();

		// Token: 0x06002492 RID: 9362
		global::System.Collections.IList GetServerSupplementalData();

		// Token: 0x06002493 RID: 9363
		global::Org.BouncyCastle.Crypto.Tls.TlsCredentials GetCredentials();

		// Token: 0x06002494 RID: 9364
		global::Org.BouncyCastle.Crypto.Tls.CertificateStatus GetCertificateStatus();

		// Token: 0x06002495 RID: 9365
		global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange();

		// Token: 0x06002496 RID: 9366
		global::Org.BouncyCastle.Crypto.Tls.CertificateRequest GetCertificateRequest();

		// Token: 0x06002497 RID: 9367
		void ProcessClientSupplementalData(global::System.Collections.IList clientSupplementalData);

		// Token: 0x06002498 RID: 9368
		void NotifyClientCertificate(global::Org.BouncyCastle.Crypto.Tls.Certificate clientCertificate);

		// Token: 0x06002499 RID: 9369
		global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket GetNewSessionTicket();
	}
}
