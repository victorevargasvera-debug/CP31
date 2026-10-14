using System;

namespace Org.BouncyCastle.Pkcs
{
	// Token: 0x020001B3 RID: 435
	public class PkcsException : global::System.Exception
	{
		// Token: 0x06001079 RID: 4217 RVA: 0x00042BE8 File Offset: 0x00040DE8
		public PkcsException(string message) : base(message)
		{
		}

		// Token: 0x0600107A RID: 4218 RVA: 0x00042BF1 File Offset: 0x00040DF1
		public PkcsException(string message, global::System.Exception underlying) : base(message, underlying)
		{
		}
	}
}
