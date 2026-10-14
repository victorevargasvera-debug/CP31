using System;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000127 RID: 295
	public interface TlsSrpIdentity
	{
		// Token: 0x06000B61 RID: 2913
		byte[] GetSrpIdentity();

		// Token: 0x06000B62 RID: 2914
		byte[] GetSrpPassword();
	}
}
