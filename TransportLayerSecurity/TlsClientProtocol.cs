using System;
using System.IO;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Security;

namespace Motorola.Common.Communication.TLS
{
	// Token: 0x02000016 RID: 22
	public sealed class TlsClientProtocol : global::Org.BouncyCastle.Crypto.Tls.TlsClientProtocol, global::Motorola.Common.Communication.TLS.ITlsConnectClient
	{
		// Token: 0x0600005F RID: 95 RVA: 0x00005B50 File Offset: 0x00003D50
		public TlsClientProtocol(global::System.IO.Stream stream, global::Org.BouncyCastle.Security.SecureRandom secureRandom) : base(stream, secureRandom)
		{
			this.SetAppDataSplitMode(2);
		}
	}
}
