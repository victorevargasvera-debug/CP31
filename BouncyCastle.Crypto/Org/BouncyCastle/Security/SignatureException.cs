using System;

namespace Org.BouncyCastle.Security
{
	// Token: 0x020001D1 RID: 465
	[global::System.Serializable]
	public class SignatureException : global::Org.BouncyCastle.Security.GeneralSecurityException
	{
		// Token: 0x06001163 RID: 4451 RVA: 0x0004B639 File Offset: 0x00049839
		public SignatureException()
		{
		}

		// Token: 0x06001164 RID: 4452 RVA: 0x0004B641 File Offset: 0x00049841
		public SignatureException(string message) : base(message)
		{
		}

		// Token: 0x06001165 RID: 4453 RVA: 0x0004B64A File Offset: 0x0004984A
		public SignatureException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
