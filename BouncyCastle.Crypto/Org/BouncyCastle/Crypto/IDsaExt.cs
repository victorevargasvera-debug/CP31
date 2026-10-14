using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002D2 RID: 722
	public interface IDsaExt : global::Org.BouncyCastle.Crypto.IDsa
	{
		// Token: 0x17000458 RID: 1112
		// (get) Token: 0x06001FA2 RID: 8098
		global::Org.BouncyCastle.Math.BigInteger Order { get; }
	}
}
