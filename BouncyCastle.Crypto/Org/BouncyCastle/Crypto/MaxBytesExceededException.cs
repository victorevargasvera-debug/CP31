using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002E8 RID: 744
	[global::System.Serializable]
	public class MaxBytesExceededException : global::Org.BouncyCastle.Crypto.CryptoException
	{
		// Token: 0x06001FE2 RID: 8162 RVA: 0x0009013C File Offset: 0x0008E33C
		public MaxBytesExceededException()
		{
		}

		// Token: 0x06001FE3 RID: 8163 RVA: 0x00090144 File Offset: 0x0008E344
		public MaxBytesExceededException(string message) : base(message)
		{
		}

		// Token: 0x06001FE4 RID: 8164 RVA: 0x0009014D File Offset: 0x0008E34D
		public MaxBytesExceededException(string message, global::System.Exception e) : base(message, e)
		{
		}
	}
}
