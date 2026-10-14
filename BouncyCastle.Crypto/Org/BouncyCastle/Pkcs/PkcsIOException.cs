using System;
using System.IO;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001B4 RID: 436
	public class PkcsIOException : global::System.IO.IOException
	{
		// Token: 0x0600107B RID: 4219 RVA: 0x00042BFB File Offset: 0x00040DFB
		public PkcsIOException(string message) : base(message)
		{
		}

		// Token: 0x0600107C RID: 4220 RVA: 0x00042C04 File Offset: 0x00040E04
		public PkcsIOException(string message, global::System.Exception underlying) : base(message, underlying)
		{
		}
	}
}
