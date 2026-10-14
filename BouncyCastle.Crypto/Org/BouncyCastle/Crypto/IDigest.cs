using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002CF RID: 719
	public interface IDigest
	{
		// Token: 0x17000454 RID: 1108
		// (get) Token: 0x06001F94 RID: 8084
		string AlgorithmName { get; }

		// Token: 0x06001F95 RID: 8085
		int GetDigestSize();

		// Token: 0x06001F96 RID: 8086
		int GetByteLength();

		// Token: 0x06001F97 RID: 8087
		void Update(byte input);

		// Token: 0x06001F98 RID: 8088
		void BlockUpdate(byte[] input, int inOff, int length);

		// Token: 0x06001F99 RID: 8089
		int DoFinal(byte[] output, int outOff);

		// Token: 0x06001F9A RID: 8090
		void Reset();
	}
}
