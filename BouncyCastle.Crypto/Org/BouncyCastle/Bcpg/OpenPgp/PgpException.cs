using System;

namespace Org.BouncyCastle.Bcpg.OpenPgp
{
	// Token: 0x020005A7 RID: 1447
	[global::System.Serializable]
	public class PgpException : global::System.Exception
	{
		// Token: 0x06003635 RID: 13877 RVA: 0x00100FDA File Offset: 0x000FF1DA
		public PgpException()
		{
		}

		// Token: 0x06003636 RID: 13878 RVA: 0x00100FE2 File Offset: 0x000FF1E2
		public PgpException(string message) : base(message)
		{
		}

		// Token: 0x06003637 RID: 13879 RVA: 0x00100FEB File Offset: 0x000FF1EB
		public PgpException(string message, global::System.Exception exception) : base(message, exception)
		{
		}

		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x06003638 RID: 13880 RVA: 0x00100FF5 File Offset: 0x000FF1F5
		[global::System.Obsolete("Use InnerException property")]
		public global::System.Exception UnderlyingException
		{
			get
			{
				return base.InnerException;
			}
		}
	}
}
