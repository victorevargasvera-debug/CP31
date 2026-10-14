using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002D0 RID: 720
	public interface IDigestFactory
	{
		// Token: 0x17000455 RID: 1109
		// (get) Token: 0x06001F9B RID: 8091
		object AlgorithmDetails { get; }

		// Token: 0x17000456 RID: 1110
		// (get) Token: 0x06001F9C RID: 8092
		int DigestLength { get; }

		// Token: 0x06001F9D RID: 8093
		global::Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator();
	}
}
