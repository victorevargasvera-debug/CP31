using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002E9 RID: 745
	[global::System.Serializable]
	public class OutputLengthException : global::Org.BouncyCastle.Crypto.DataLengthException
	{
		// Token: 0x06001FE5 RID: 8165 RVA: 0x00090157 File Offset: 0x0008E357
		public OutputLengthException()
		{
		}

		// Token: 0x06001FE6 RID: 8166 RVA: 0x0009015F File Offset: 0x0008E35F
		public OutputLengthException(string message) : base(message)
		{
		}

		// Token: 0x06001FE7 RID: 8167 RVA: 0x00090168 File Offset: 0x0008E368
		public OutputLengthException(string message, global::System.Exception exception) : base(message, exception)
		{
		}
	}
}
