using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002E3 RID: 739
	public interface IVerifierFactory
	{
		// Token: 0x17000464 RID: 1124
		// (get) Token: 0x06001FD6 RID: 8150
		object AlgorithmDetails { get; }

		// Token: 0x06001FD7 RID: 8151
		global::Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator();
	}
}
