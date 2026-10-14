using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x0200010C RID: 268
	public class TlsException : global::System.IO.IOException
	{
		// Token: 0x060009A9 RID: 2473 RVA: 0x00026336 File Offset: 0x00024536
		public TlsException()
		{
		}

		// Token: 0x060009AA RID: 2474 RVA: 0x0002633E File Offset: 0x0002453E
		public TlsException(string message) : base(message)
		{
		}

		// Token: 0x060009AB RID: 2475 RVA: 0x00026347 File Offset: 0x00024547
		public TlsException(string message, global::System.Exception cause) : base(message, cause)
		{
		}
	}
}
