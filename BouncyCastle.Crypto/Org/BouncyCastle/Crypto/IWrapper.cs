using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002E5 RID: 741
	public interface IWrapper
	{
		// Token: 0x17000465 RID: 1125
		// (get) Token: 0x06001FD9 RID: 8153
		string AlgorithmName { get; }

		// Token: 0x06001FDA RID: 8154
		void Init(bool forWrapping, global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x06001FDB RID: 8155
		byte[] Wrap(byte[] input, int inOff, int length);

		// Token: 0x06001FDC RID: 8156
		byte[] Unwrap(byte[] input, int inOff, int length);
	}
}
