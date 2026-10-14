using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200011A RID: 282
	public interface TlsPskIdentity
	{
		// Token: 0x06000AF2 RID: 2802
		void SkipIdentityHint();

		// Token: 0x06000AF3 RID: 2803
		void NotifyIdentityHint(byte[] psk_identity_hint);

		// Token: 0x06000AF4 RID: 2804
		byte[] GetPskIdentity();

		// Token: 0x06000AF5 RID: 2805
		byte[] GetPsk();
	}
}
