using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002D4 RID: 724
	public interface IEntropySourceProvider
	{
		// Token: 0x06001FA6 RID: 8102
		global::Org.BouncyCastle.Crypto.IEntropySource Get(int bitsRequired);
	}
}
