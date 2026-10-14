using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000111 RID: 273
	public interface TlsHeartbeat
	{
		// Token: 0x06000A56 RID: 2646
		byte[] GeneratePayload();

		// Token: 0x170001AE RID: 430
		// (get) Token: 0x06000A57 RID: 2647
		int IdleMillis { get; }

		// Token: 0x170001AF RID: 431
		// (get) Token: 0x06000A58 RID: 2648
		int TimeoutMillis { get; }
	}
}
