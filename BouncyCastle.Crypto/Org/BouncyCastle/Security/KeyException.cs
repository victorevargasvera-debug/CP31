using System;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001C8 RID: 456
	[global::System.Serializable]
	public class KeyException : global::Org.BouncyCastle.Security.GeneralSecurityException
	{
		// Token: 0x06001101 RID: 4353 RVA: 0x00047DAD File Offset: 0x00045FAD
		public KeyException()
		{
		}

		// Token: 0x06001102 RID: 4354 RVA: 0x00047DB5 File Offset: 0x00045FB5
		public KeyException(string message) : base(message)
		{
		}

		// Token: 0x06001103 RID: 4355 RVA: 0x00047DBE File Offset: 0x00045FBE
		public KeyException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
