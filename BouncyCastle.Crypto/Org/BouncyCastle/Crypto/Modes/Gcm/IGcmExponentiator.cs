using System;

namespace Org.BouncyCastle.Crypto.Modes.Gcm
{
	// Token: 0x02000445 RID: 1093
	public interface IGcmExponentiator
	{
		// Token: 0x06002A7E RID: 10878
		void Init(byte[] x);

		// Token: 0x06002A7F RID: 10879
		void ExponentiateX(long pow, byte[] output);
	}
}
