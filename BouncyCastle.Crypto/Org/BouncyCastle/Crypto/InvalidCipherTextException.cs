using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002DA RID: 730
	[global::System.Serializable]
	public class InvalidCipherTextException : global::Org.BouncyCastle.Crypto.CryptoException
	{
		// Token: 0x06001FB5 RID: 8117 RVA: 0x000900D9 File Offset: 0x0008E2D9
		public InvalidCipherTextException()
		{
		}

		// Token: 0x06001FB6 RID: 8118 RVA: 0x000900E1 File Offset: 0x0008E2E1
		public InvalidCipherTextException(string message) : base(message)
		{
		}

		// Token: 0x06001FB7 RID: 8119 RVA: 0x000900EA File Offset: 0x0008E2EA
		public InvalidCipherTextException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
