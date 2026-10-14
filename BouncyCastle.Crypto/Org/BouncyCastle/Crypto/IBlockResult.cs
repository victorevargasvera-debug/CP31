using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C6 RID: 710
	public interface IBlockResult
	{
		// Token: 0x06001F75 RID: 8053
		byte[] Collect();

		// Token: 0x06001F76 RID: 8054
		int Collect(byte[] destination, int offset);
	}
}
