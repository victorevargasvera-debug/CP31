using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002D9 RID: 729
	public interface IMacFactory
	{
		// Token: 0x1700045E RID: 1118
		// (get) Token: 0x06001FB3 RID: 8115
		object AlgorithmDetails { get; }

		// Token: 0x06001FB4 RID: 8116
		global::Org.BouncyCastle.Crypto.IStreamCalculator CreateCalculator();
	}
}
