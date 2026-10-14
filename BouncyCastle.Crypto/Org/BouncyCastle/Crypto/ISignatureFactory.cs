using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002DD RID: 733
	public interface ISignatureFactory
	{
		// Token: 0x17000460 RID: 1120
		// (get) Token: 0x06001FC1 RID: 8129
		object AlgorithmDetails { get; }

		// Token: 0x06001FC2 RID: 8130
		global::Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator();
	}
}
