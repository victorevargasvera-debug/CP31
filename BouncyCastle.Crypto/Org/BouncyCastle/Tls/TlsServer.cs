using System;
using System.Collections;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200011E RID: 286
	public interface TlsServer : global::Org.BouncyCastle.Tls.TlsPeer
	{
		// Token: 0x06000B15 RID: 2837
		void Init(global::Org.BouncyCastle.Tls.TlsServerContext context);

		// Token: 0x06000B16 RID: 2838
		global::Org.BouncyCastle.Tls.TlsSession GetSessionToResume(byte[] sessionID);

		// Token: 0x06000B17 RID: 2839
		byte[] GetNewSessionID();

		// Token: 0x06000B18 RID: 2840
		global::Org.BouncyCastle.Tls.TlsPskExternal GetExternalPsk(global::System.Collections.IList identities);

		// Token: 0x06000B19 RID: 2841
		void NotifySession(global::Org.BouncyCastle.Tls.TlsSession session);

		// Token: 0x06000B1A RID: 2842
		void NotifyClientVersion(global::Org.BouncyCastle.Tls.ProtocolVersion clientVersion);

		// Token: 0x06000B1B RID: 2843
		void NotifyFallback(bool isFallback);

		// Token: 0x06000B1C RID: 2844
		void NotifyOfferedCipherSuites(int[] offeredCipherSuites);

		// Token: 0x06000B1D RID: 2845
		void ProcessClientExtensions(global::System.Collections.IDictionary clientExtensions);

		// Token: 0x06000B1E RID: 2846
		global::Org.BouncyCastle.Tls.ProtocolVersion GetServerVersion();

		// Token: 0x06000B1F RID: 2847
		int[] GetSupportedGroups();

		// Token: 0x06000B20 RID: 2848
		int GetSelectedCipherSuite();

		// Token: 0x06000B21 RID: 2849
		global::System.Collections.IDictionary GetServerExtensions();

		// Token: 0x06000B22 RID: 2850
		void GetServerExtensionsForConnection(global::System.Collections.IDictionary serverExtensions);

		// Token: 0x06000B23 RID: 2851
		global::System.Collections.IList GetServerSupplementalData();

		// Token: 0x06000B24 RID: 2852
		global::Org.BouncyCastle.Tls.TlsCredentials GetCredentials();

		// Token: 0x06000B25 RID: 2853
		global::Org.BouncyCastle.Tls.CertificateStatus GetCertificateStatus();

		// Token: 0x06000B26 RID: 2854
		global::Org.BouncyCastle.Tls.CertificateRequest GetCertificateRequest();

		// Token: 0x06000B27 RID: 2855
		global::Org.BouncyCastle.Tls.TlsPskIdentityManager GetPskIdentityManager();

		// Token: 0x06000B28 RID: 2856
		global::Org.BouncyCastle.Tls.TlsSrpLoginParameters GetSrpLoginParameters();

		// Token: 0x06000B29 RID: 2857
		global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig GetDHConfig();

		// Token: 0x06000B2A RID: 2858
		global::Org.BouncyCastle.Tls.Crypto.TlsECConfig GetECDHConfig();

		// Token: 0x06000B2B RID: 2859
		void ProcessClientSupplementalData(global::System.Collections.IList clientSupplementalData);

		// Token: 0x06000B2C RID: 2860
		void NotifyClientCertificate(global::Org.BouncyCastle.Tls.Certificate clientCertificate);

		// Token: 0x06000B2D RID: 2861
		global::Org.BouncyCastle.Tls.NewSessionTicket GetNewSessionTicket();
	}
}
