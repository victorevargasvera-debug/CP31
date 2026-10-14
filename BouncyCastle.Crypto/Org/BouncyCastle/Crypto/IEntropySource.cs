using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002D3 RID: 723
	public interface IEntropySource
	{
		// Token: 0x17000459 RID: 1113
		// (get) Token: 0x06001FA3 RID: 8099
		bool IsPredictionResistant { get; }

		// Token: 0x06001FA4 RID: 8100
		byte[] GetEntropy();

		// Token: 0x1700045A RID: 1114
		// (get) Token: 0x06001FA5 RID: 8101
		int EntropySize { get; }
	}
}
