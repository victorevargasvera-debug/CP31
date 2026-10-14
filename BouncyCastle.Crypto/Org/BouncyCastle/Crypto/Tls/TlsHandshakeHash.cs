using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000373 RID: 883
	public interface TlsHandshakeHash : global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x060023EA RID: 9194
		void Init(global::Org.BouncyCastle.Crypto.Tls.TlsContext context);

		// Token: 0x060023EB RID: 9195
		global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash NotifyPrfDetermined();

		// Token: 0x060023EC RID: 9196
		void TrackHashAlgorithm(byte hashAlgorithm);

		// Token: 0x060023ED RID: 9197
		void SealHashAlgorithms();

		// Token: 0x060023EE RID: 9198
		global::Org.BouncyCastle.Crypto.Tls.TlsHandshakeHash StopTracking();

		// Token: 0x060023EF RID: 9199
		global::Org.BouncyCastle.Crypto.IDigest ForkPrfHash();

		// Token: 0x060023F0 RID: 9200
		byte[] GetFinalHash(byte hashAlgorithm);
	}
}
