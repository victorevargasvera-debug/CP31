using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002E6 RID: 742
	public interface IXof : global::Org.BouncyCastle.Crypto.IDigest
	{
		// Token: 0x06001FDD RID: 8157
		int DoFinal(byte[] output, int outOff, int outLen);

		// Token: 0x06001FDE RID: 8158
		int DoOutput(byte[] output, int outOff, int outLen);
	}
}
