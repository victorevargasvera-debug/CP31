using System;
using System.IO;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200036F RID: 879
	public class TlsException : global::System.IO.IOException
	{
		// Token: 0x060023B2 RID: 9138 RVA: 0x0009C542 File Offset: 0x0009A742
		public TlsException()
		{
		}

		// Token: 0x060023B3 RID: 9139 RVA: 0x0009C54A File Offset: 0x0009A74A
		public TlsException(string message) : base(message)
		{
		}

		// Token: 0x060023B4 RID: 9140 RVA: 0x0009C553 File Offset: 0x0009A753
		public TlsException(string message, global::System.Exception cause) : base(message, cause)
		{
		}
	}
}
