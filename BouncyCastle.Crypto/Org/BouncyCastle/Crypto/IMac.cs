using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002D7 RID: 727
	public interface IMac
	{
		// Token: 0x06001FAB RID: 8107
		void Init(global::Org.BouncyCastle.Crypto.ICipherParameters parameters);

		// Token: 0x1700045D RID: 1117
		// (get) Token: 0x06001FAC RID: 8108
		string AlgorithmName { get; }

		// Token: 0x06001FAD RID: 8109
		int GetMacSize();

		// Token: 0x06001FAE RID: 8110
		void Update(byte input);

		// Token: 0x06001FAF RID: 8111
		void BlockUpdate(byte[] input, int inOff, int len);

		// Token: 0x06001FB0 RID: 8112
		int DoFinal(byte[] output, int outOff);

		// Token: 0x06001FB1 RID: 8113
		void Reset();
	}
}
