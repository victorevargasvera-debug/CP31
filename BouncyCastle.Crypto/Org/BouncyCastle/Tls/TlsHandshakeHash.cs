using System;
using System.IO;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000110 RID: 272
	public interface TlsHandshakeHash : global::Org.BouncyCastle.Tls.Crypto.TlsHash
	{
		// Token: 0x06000A4E RID: 2638
		void CopyBufferTo(global::System.IO.Stream output);

		// Token: 0x06000A4F RID: 2639
		void ForceBuffering();

		// Token: 0x06000A50 RID: 2640
		void NotifyPrfDetermined();

		// Token: 0x06000A51 RID: 2641
		void TrackHashAlgorithm(int cryptoHashAlgorithm);

		// Token: 0x06000A52 RID: 2642
		void SealHashAlgorithms();

		// Token: 0x06000A53 RID: 2643
		global::Org.BouncyCastle.Tls.TlsHandshakeHash StopTracking();

		// Token: 0x06000A54 RID: 2644
		global::Org.BouncyCastle.Tls.Crypto.TlsHash ForkPrfHash();

		// Token: 0x06000A55 RID: 2645
		byte[] GetFinalHash(int cryptoHashAlgorithm);
	}
}
