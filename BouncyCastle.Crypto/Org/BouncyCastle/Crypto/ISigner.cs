using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002DE RID: 734
	public interface ISigner
	{
		// Token: 0x17000461 RID: 1121
		// (get) Token: 0x06001FC3 RID: 8131
		string AlgorithmName { get; }

		// Token: 0x06001FC4 RID: 8132
		void Init(bool forSigning, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001FC5 RID: 8133
		void Update(byte input);

		// Token: 0x06001FC6 RID: 8134
		void BlockUpdate(byte[] input, int inOff, int length);

		// Token: 0x06001FC7 RID: 8135
		byte[] GenerateSignature();

		// Token: 0x06001FC8 RID: 8136
		bool VerifySignature(byte[] signature);

		// Token: 0x06001FC9 RID: 8137
		void Reset();
	}
}
