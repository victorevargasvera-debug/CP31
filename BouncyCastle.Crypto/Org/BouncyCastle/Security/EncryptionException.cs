using System;
using System.IO;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001BE RID: 446
	[global::System.Serializable]
	public class EncryptionException : global::System.IO.IOException
	{
		// Token: 0x060010AE RID: 4270 RVA: 0x0004432F File Offset: 0x0004252F
		public EncryptionException(string message) : base(message)
		{
		}

		// Token: 0x060010AF RID: 4271 RVA: 0x00044338 File Offset: 0x00042538
		public EncryptionException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
