using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000386 RID: 902
	public interface TlsSession
	{
		// Token: 0x060024B2 RID: 9394
		global::Org.BouncyCastle.Crypto.Tls.SessionParameters ExportSessionParameters();

		// Token: 0x170004FA RID: 1274
		// (get) Token: 0x060024B3 RID: 9395
		byte[] SessionID { get; }

		// Token: 0x060024B4 RID: 9396
		void Invalidate();

		// Token: 0x170004FB RID: 1275
		// (get) Token: 0x060024B5 RID: 9397
		bool IsResumable { get; }
	}
}
