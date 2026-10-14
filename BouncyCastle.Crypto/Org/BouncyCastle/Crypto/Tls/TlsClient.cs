using System;
using System.Collections;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200035B RID: 859
	public interface TlsClient : global::Org.BouncyCastle.Crypto.Tls.TlsPeer
	{
		// Token: 0x06002300 RID: 8960
		void Init(global::Org.BouncyCastle.Crypto.Tls.TlsClientContext context);

		// Token: 0x06002301 RID: 8961
		global::Org.BouncyCastle.Crypto.Tls.TlsSession GetSessionToResume();

		// Token: 0x170004D6 RID: 1238
		// (get) Token: 0x06002302 RID: 8962
		global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientHelloRecordLayerVersion { get; }

		// Token: 0x170004D7 RID: 1239
		// (get) Token: 0x06002303 RID: 8963
		global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion ClientVersion { get; }

		// Token: 0x170004D8 RID: 1240
		// (get) Token: 0x06002304 RID: 8964
		bool IsFallback { get; }

		// Token: 0x06002305 RID: 8965
		int[] GetCipherSuites();

		// Token: 0x06002306 RID: 8966
		byte[] GetCompressionMethods();

		// Token: 0x06002307 RID: 8967
		global::System.Collections.IDictionary GetClientExtensions();

		// Token: 0x06002308 RID: 8968
		void NotifyServerVersion(global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion selectedVersion);

		// Token: 0x06002309 RID: 8969
		void NotifySessionID(byte[] sessionID);

		// Token: 0x0600230A RID: 8970
		void NotifySelectedCipherSuite(int selectedCipherSuite);

		// Token: 0x0600230B RID: 8971
		void NotifySelectedCompressionMethod(byte selectedCompressionMethod);

		// Token: 0x0600230C RID: 8972
		void ProcessServerExtensions(global::System.Collections.IDictionary serverExtensions);

		// Token: 0x0600230D RID: 8973
		void ProcessServerSupplementalData(global::System.Collections.IList serverSupplementalData);

		// Token: 0x0600230E RID: 8974
		global::Org.BouncyCastle.Crypto.Tls.TlsKeyExchange GetKeyExchange();

		// Token: 0x0600230F RID: 8975
		global::Org.BouncyCastle.Crypto.Tls.TlsAuthentication GetAuthentication();

		// Token: 0x06002310 RID: 8976
		global::System.Collections.IList GetClientSupplementalData();

		// Token: 0x06002311 RID: 8977
		void NotifyNewSessionTicket(global::Org.BouncyCastle.Crypto.Tls.NewSessionTicket newSessionTicket);
	}
}
