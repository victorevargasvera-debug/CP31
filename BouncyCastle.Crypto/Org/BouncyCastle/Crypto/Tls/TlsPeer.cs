using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000379 RID: 889
	public interface TlsPeer
	{
		// Token: 0x06002410 RID: 9232
		void NotifyCloseHandle(global::Org.BouncyCastle.Crypto.Tls.TlsCloseable closehandle);

		// Token: 0x06002411 RID: 9233
		void Cancel();

		// Token: 0x06002412 RID: 9234
		int GetHandshakeTimeoutMillis();

		// Token: 0x06002413 RID: 9235
		bool RequiresExtendedMasterSecret();

		// Token: 0x06002414 RID: 9236
		bool ShouldUseGmtUnixTime();

		// Token: 0x06002415 RID: 9237
		void NotifySecureRenegotiation(bool secureRenegotiation);

		// Token: 0x06002416 RID: 9238
		global::Org.BouncyCastle.Crypto.Tls.TlsCompression GetCompression();

		// Token: 0x06002417 RID: 9239
		global::Org.BouncyCastle.Crypto.Tls.TlsCipher GetCipher();

		// Token: 0x06002418 RID: 9240
		void NotifyAlertRaised(byte alertLevel, byte alertDescription, string message, global::System.Exception cause);

		// Token: 0x06002419 RID: 9241
		void NotifyAlertReceived(byte alertLevel, byte alertDescription);

		// Token: 0x0600241A RID: 9242
		void NotifyHandshakeComplete();
	}
}
