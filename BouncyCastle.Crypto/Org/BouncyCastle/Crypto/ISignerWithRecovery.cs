using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002DF RID: 735
	public interface ISignerWithRecovery : global::Org.BouncyCastle.Crypto.ISigner
	{
		// Token: 0x06001FCA RID: 8138
		bool HasFullMessage();

		// Token: 0x06001FCB RID: 8139
		byte[] GetRecoveredMessage();

		// Token: 0x06001FCC RID: 8140
		void UpdateWithRecoveredMessage(byte[] signature);
	}
}
