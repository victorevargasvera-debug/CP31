using System;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C6 RID: 454
	[global::System.Serializable]
	public class InvalidKeyException : global::Org.BouncyCastle.Security.KeyException
	{
		// Token: 0x060010FB RID: 4347 RVA: 0x00047D77 File Offset: 0x00045F77
		public InvalidKeyException()
		{
		}

		// Token: 0x060010FC RID: 4348 RVA: 0x00047D7F File Offset: 0x00045F7F
		public InvalidKeyException(string message) : base(message)
		{
		}

		// Token: 0x060010FD RID: 4349 RVA: 0x00047D88 File Offset: 0x00045F88
		public InvalidKeyException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
