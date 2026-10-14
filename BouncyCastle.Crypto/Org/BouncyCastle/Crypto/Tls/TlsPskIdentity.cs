using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200037C RID: 892
	public interface TlsPskIdentity
	{
		// Token: 0x0600245E RID: 9310
		void SkipIdentityHint();

		// Token: 0x0600245F RID: 9311
		void NotifyIdentityHint(byte[] psk_identity_hint);

		// Token: 0x06002460 RID: 9312
		byte[] GetPskIdentity();

		// Token: 0x06002461 RID: 9313
		byte[] GetPsk();
	}
}
