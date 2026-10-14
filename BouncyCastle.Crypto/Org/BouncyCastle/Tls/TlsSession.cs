using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000124 RID: 292
	public interface TlsSession
	{
		// Token: 0x06000B57 RID: 2903
		global::Org.BouncyCastle.Tls.SessionParameters ExportSessionParameters();

		// Token: 0x170001CB RID: 459
		// (get) Token: 0x06000B58 RID: 2904
		byte[] SessionID { get; }

		// Token: 0x06000B59 RID: 2905
		void Invalidate();

		// Token: 0x170001CC RID: 460
		// (get) Token: 0x06000B5A RID: 2906
		bool IsResumable { get; }
	}
}
