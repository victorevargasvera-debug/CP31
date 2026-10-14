using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000118 RID: 280
	public interface TlsPsk
	{
		// Token: 0x170001BF RID: 447
		// (get) Token: 0x06000AEF RID: 2799
		byte[] Identity { get; }

		// Token: 0x170001C0 RID: 448
		// (get) Token: 0x06000AF0 RID: 2800
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret Key { get; }

		// Token: 0x170001C1 RID: 449
		// (get) Token: 0x06000AF1 RID: 2801
		int PrfAlgorithm { get; }
	}
}
