using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000128 RID: 296
	public interface TlsSrpIdentityManager
	{
		// Token: 0x06000B63 RID: 2915
		global::Org.BouncyCastle.Tls.TlsSrpLoginParameters GetLoginParameters(byte[] identity);
	}
}
