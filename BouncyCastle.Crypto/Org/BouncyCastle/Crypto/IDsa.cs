using System;
using Org.BouncyCastle.Math;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002D1 RID: 721
	public interface IDsa
	{
		// Token: 0x17000457 RID: 1111
		// (get) Token: 0x06001F9E RID: 8094
		string AlgorithmName { get; }

		// Token: 0x06001F9F RID: 8095
		void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001FA0 RID: 8096
		global::Org.BouncyCastle.Math.BigInteger[] GenerateSignature(byte[] message);

		// Token: 0x06001FA1 RID: 8097
		bool VerifySignature(byte[] message, global::Org.BouncyCastle.Math.BigInteger r, global::Org.BouncyCastle.Math.BigInteger s);
	}
}
