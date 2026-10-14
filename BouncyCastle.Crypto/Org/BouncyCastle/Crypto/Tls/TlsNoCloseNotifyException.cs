using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000376 RID: 886
	public class TlsNoCloseNotifyException : global::System.IO.EndOfStreamException
	{
		// Token: 0x06002407 RID: 9223 RVA: 0x0009CC72 File Offset: 0x0009AE72
		public TlsNoCloseNotifyException() : base("No close_notify alert received before connection closed")
		{
		}
	}
}
