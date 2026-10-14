using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200038B RID: 907
	public interface TlsSrpIdentityManager
	{
		// Token: 0x060024C8 RID: 9416
		global::Org.BouncyCastle.Crypto.Tls.TlsSrpLoginParameters GetLoginParameters(byte[] identity);
	}
}
