using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200012E RID: 302
	public class TlsTimeoutException : global::System.IO.IOException
	{
		// Token: 0x06000B93 RID: 2963 RVA: 0x0002BA2F File Offset: 0x00029C2F
		public TlsTimeoutException()
		{
		}

		// Token: 0x06000B94 RID: 2964 RVA: 0x0002BA37 File Offset: 0x00029C37
		public TlsTimeoutException(string message) : base(message)
		{
		}

		// Token: 0x06000B95 RID: 2965 RVA: 0x0002BA40 File Offset: 0x00029C40
		public TlsTimeoutException(string message, global::System.Exception cause) : base(message, cause)
		{
		}
	}
}
