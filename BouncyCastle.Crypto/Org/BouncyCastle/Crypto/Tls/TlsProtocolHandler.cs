using System;
using System.IO;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200037B RID: 891
	[global::System.Obsolete("Use 'TlsClientProtocol' instead")]
	public class TlsProtocolHandler : global::Org.BouncyCastle.Crypto.Tls.TlsClientProtocol
	{
		// Token: 0x0600245C RID: 9308 RVA: 0x0009E37B File Offset: 0x0009C57B
		public TlsProtocolHandler(global::System.IO.Stream stream, global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(stream, stream, secureRandom)
		{
		}

		// Token: 0x0600245D RID: 9309 RVA: 0x0009E386 File Offset: 0x0009C586
		public TlsProtocolHandler(global::System.IO.Stream input, global::System.IO.Stream output, global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(input, output, secureRandom)
		{
		}
	}
}
