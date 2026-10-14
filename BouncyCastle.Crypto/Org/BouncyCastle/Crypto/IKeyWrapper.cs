using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002D6 RID: 726
	public interface IKeyWrapper
	{
		// Token: 0x1700045C RID: 1116
		// (get) Token: 0x06001FA9 RID: 8105
		object AlgorithmDetails { get; }

		// Token: 0x06001FAA RID: 8106
		global::Org.BouncyCastle.Crypto.IBlockResult Wrap(byte[] keyData);
	}
}
