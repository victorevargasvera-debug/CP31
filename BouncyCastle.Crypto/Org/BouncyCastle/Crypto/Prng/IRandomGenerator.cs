using System;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003B7 RID: 951
	public interface IRandomGenerator
	{
		// Token: 0x06002698 RID: 9880
		void AddSeedMaterial(byte[] seed);

		// Token: 0x06002699 RID: 9881
		void AddSeedMaterial(long seed);

		// Token: 0x0600269A RID: 9882
		void NextBytes(byte[] bytes);

		// Token: 0x0600269B RID: 9883
		void NextBytes(byte[] bytes, int start, int len);
	}
}
