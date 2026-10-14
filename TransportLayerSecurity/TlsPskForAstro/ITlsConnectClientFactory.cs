using System;
using System.IO;

namespace Motorola.Common.Communication.TLS.TlsPskForAstro
{
	// Token: 0x02000023 RID: 35
	public interface ITlsConnectClientFactory
	{
		// Token: 0x060000CA RID: 202
		global::Motorola.Common.Communication.TLS.TlsClientProtocol Create(global::System.IO.Stream stream);
	}
}
