using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C0 RID: 704
	[global::System.Serializable]
	public class DataLengthException : global::Org.BouncyCastle.Crypto.CryptoException
	{
		// Token: 0x06001F5F RID: 8031 RVA: 0x000900BE File Offset: 0x0008E2BE
		public DataLengthException()
		{
		}

		// Token: 0x06001F60 RID: 8032 RVA: 0x000900C6 File Offset: 0x0008E2C6
		public DataLengthException(string message) : base(message)
		{
		}

		// Token: 0x06001F61 RID: 8033 RVA: 0x000900CF File Offset: 0x0008E2CF
		public DataLengthException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
