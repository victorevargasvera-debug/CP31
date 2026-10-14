using System;
using System.IO;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000114 RID: 276
	public class TlsNoCloseNotifyException : global::System.IO.EndOfStreamException
	{
		// Token: 0x06000A78 RID: 2680 RVA: 0x00027839 File Offset: 0x00025A39
		public TlsNoCloseNotifyException() : base("No close_notify alert received before connection closed")
		{
		}
	}
}
