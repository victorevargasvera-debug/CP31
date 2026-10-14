using System;
using System.IO;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001BF RID: 447
	[global::System.Serializable]
	public class PasswordException : global::System.IO.IOException
	{
		// Token: 0x060010B0 RID: 4272 RVA: 0x00044342 File Offset: 0x00042542
		public PasswordException(string message) : base(message)
		{
		}

		// Token: 0x060010B1 RID: 4273 RVA: 0x0004434B File Offset: 0x0004254B
		public PasswordException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
