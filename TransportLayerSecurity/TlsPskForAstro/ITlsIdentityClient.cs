using System;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro
{
	// Token: 0x02000025 RID: 37
	public interface ITlsIdentityClient
	{
		// Token: 0x060000D5 RID: 213
		byte[] GetIdentityHint();

		// Token: 0x060000D6 RID: 214
		string GetPskId();
	}
}
