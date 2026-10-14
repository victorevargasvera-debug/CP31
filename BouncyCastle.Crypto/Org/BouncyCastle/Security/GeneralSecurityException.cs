using System;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C4 RID: 452
	[global::System.Serializable]
	public class GeneralSecurityException : global::System.Exception
	{
		// Token: 0x060010E9 RID: 4329 RVA: 0x00046D76 File Offset: 0x00044F76
		public GeneralSecurityException()
		{
		}

		// Token: 0x060010EA RID: 4330 RVA: 0x00046D7E File Offset: 0x00044F7E
		public GeneralSecurityException(string message) : base(message)
		{
		}

		// Token: 0x060010EB RID: 4331 RVA: 0x00046D87 File Offset: 0x00044F87
		public GeneralSecurityException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
