using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000116 RID: 278
	public interface TlsPeer
	{
		// Token: 0x170001B2 RID: 434
		// (get) Token: 0x06000A7B RID: 2683
		global::Org.BouncyCastle.Tls.Crypto.TlsCrypto Crypto { get; }

		// Token: 0x06000A7C RID: 2684
		void NotifyCloseHandle(global::Org.BouncyCastle.Tls.TlsCloseable closehandle);

		// Token: 0x06000A7D RID: 2685
		void Cancel();

		// Token: 0x06000A7E RID: 2686
		global::Org.BouncyCastle.Tls.ProtocolVersion[] GetProtocolVersions();

		// Token: 0x06000A7F RID: 2687
		int[] GetCipherSuites();

		// Token: 0x06000A80 RID: 2688
		void NotifyHandshakeBeginning();

		// Token: 0x06000A81 RID: 2689
		int GetHandshakeTimeoutMillis();

		// Token: 0x06000A82 RID: 2690
		bool AllowLegacyResumption();

		// Token: 0x06000A83 RID: 2691
		int GetMaxCertificateChainLength();

		// Token: 0x06000A84 RID: 2692
		int GetMaxHandshakeMessageSize();

		// Token: 0x06000A85 RID: 2693
		short[] GetPskKeyExchangeModes();

		// Token: 0x06000A86 RID: 2694
		bool RequiresCloseNotify();

		// Token: 0x06000A87 RID: 2695
		bool RequiresExtendedMasterSecret();

		// Token: 0x06000A88 RID: 2696
		bool ShouldUseExtendedMasterSecret();

		// Token: 0x06000A89 RID: 2697
		bool ShouldUseExtendedPadding();

		// Token: 0x06000A8A RID: 2698
		bool ShouldUseGmtUnixTime();

		// Token: 0x06000A8B RID: 2699
		void NotifySecureRenegotiation(bool secureRenegotiation);

		// Token: 0x06000A8C RID: 2700
		global::Org.BouncyCastle.Tls.TlsKeyExchangeFactory GetKeyExchangeFactory();

		// Token: 0x06000A8D RID: 2701
		void NotifyAlertRaised(short alertLevel, short alertDescription, string message, global::System.Exception cause);

		// Token: 0x06000A8E RID: 2702
		void NotifyAlertReceived(short alertLevel, short alertDescription);

		// Token: 0x06000A8F RID: 2703
		void NotifyHandshakeComplete();

		// Token: 0x06000A90 RID: 2704
		global::Org.BouncyCastle.Tls.TlsHeartbeat GetHeartbeat();

		// Token: 0x06000A91 RID: 2705
		short GetHeartbeatPolicy();
	}
}
