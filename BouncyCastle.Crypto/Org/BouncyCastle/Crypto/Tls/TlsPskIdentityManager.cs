using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200037D RID: 893
	public interface TlsPskIdentityManager
	{
		// Token: 0x06002462 RID: 9314
		byte[] GetHint();

		// Token: 0x06002463 RID: 9315
		byte[] GetPsk(byte[] identity);
	}
}
