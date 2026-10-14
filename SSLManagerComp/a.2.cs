using System;
using System.IO;
using Org.BouncyCastle.Crypto.Tls;
using Org.BouncyCastle.Security;

namespace SSLMangrComp
{
	// Token: 0x02000009 RID: 9
	internal sealed class a : global::Org.BouncyCastle.Crypto.Tls.TlsServerProtocol
	{
		// Token: 0x06000023 RID: 35 RVA: 0x00003D54 File Offset: 0x00001F54
		public a(global::System.IO.Stream A_0, global::Org.BouncyCastle.Security.SecureRandom A_1) : base(A_0, A_1)
		{
			this.SetAppDataSplitMode(2);
			byte[] sessionID = global::System.Guid.NewGuid().ToByteArray();
			this.mTlsSession = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.ImportSession(sessionID, null);
		}
	}
}
