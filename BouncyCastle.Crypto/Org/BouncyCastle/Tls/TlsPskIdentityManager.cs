using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200011B RID: 283
	public interface TlsPskIdentityManager
	{
		// Token: 0x06000AF6 RID: 2806
		byte[] GetHint();

		// Token: 0x06000AF7 RID: 2807
		byte[] GetPsk(byte[] identity);
	}
}
