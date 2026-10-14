using System;
using System.IO;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C9 RID: 713
	public interface ICipherBuilder
	{
		// Token: 0x17000451 RID: 1105
		// (get) Token: 0x06001F8C RID: 8076
		object AlgorithmDetails { get; }

		// Token: 0x06001F8D RID: 8077
		int GetMaxOutputSize(int inputLen);

		// Token: 0x06001F8E RID: 8078
		global::Org.BouncyCastle.Crypto.ICipher BuildCipher(global::System.IO.Stream stream);
	}
}
