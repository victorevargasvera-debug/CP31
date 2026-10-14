using System;
using Org.BouncyCastle.Crypto.Prng.Drbg;

namespace Org.BouncyCastle.Crypto.Prng
{
	// Token: 0x020003B6 RID: 950
	internal interface IDrbgProvider
	{
		// Token: 0x06002697 RID: 9879
		global::Org.BouncyCastle.Crypto.Prng.Drbg.ISP80090Drbg Get(global::Org.BouncyCastle.Crypto.IEntropySource entropySource);
	}
}
