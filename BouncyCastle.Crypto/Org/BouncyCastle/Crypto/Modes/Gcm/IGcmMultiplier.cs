using System;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000446 RID: 1094
	public interface IGcmMultiplier
	{
		// Token: 0x06002A80 RID: 10880
		void Init(byte[] H);

		// Token: 0x06002A81 RID: 10881
		void MultiplyH(byte[] x);
	}
}
