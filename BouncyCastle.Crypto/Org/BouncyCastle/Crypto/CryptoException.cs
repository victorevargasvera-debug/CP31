using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002BF RID: 703
	[global::System.Serializable]
	public class CryptoException : global::System.Exception
	{
		// Token: 0x06001F5C RID: 8028 RVA: 0x000900A3 File Offset: 0x0008E2A3
		public CryptoException()
		{
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x000900AB File Offset: 0x0008E2AB
		public CryptoException(string message) : base(message)
		{
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000900B4 File Offset: 0x0008E2B4
		public CryptoException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
