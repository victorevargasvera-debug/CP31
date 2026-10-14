using System;
using System.IO;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Security;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x0200001C RID: 28
	internal sealed class TlsServerProtocol : global::Org.BouncyCastle.Crypto.Tls.TlsServerProtocol
	{
		// Token: 0x06000094 RID: 148 RVA: 0x00008194 File Offset: 0x00006394
		public TlsServerProtocol(global::System.IO.Stream stream, global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(stream, secureRandom)
		{
			this.SetAppDataSplitMode(2);
		}
	}
}
