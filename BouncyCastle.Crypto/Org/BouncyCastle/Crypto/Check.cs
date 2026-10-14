using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002BD RID: 701
	internal class Check
	{
		// Token: 0x06001F51 RID: 8017 RVA: 0x0008FF8F File Offset: 0x0008E18F
		internal static void DataLength(bool condition, string msg)
		{
			if (condition)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException(msg);
			}
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x0008FF9B File Offset: 0x0008E19B
		internal static void DataLength(byte[] buf, int off, int len, string msg)
		{
			if (off > buf.Length - len)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException(msg);
			}
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x0008FFAC File Offset: 0x0008E1AC
		internal static void OutputLength(byte[] buf, int off, int len, string msg)
		{
			if (off > buf.Length - len)
			{
				throw new global::Org.BouncyCastle.Crypto.OutputLengthException(msg);
			}
		}
	}
}
