using System;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x0200043A RID: 1082
	public interface IAeadBlockCipher : global::Org.BouncyCastle.Crypto.Modes.IAeadCipher
	{
		// Token: 0x060029E0 RID: 10720
		int GetBlockSize();

		// Token: 0x060029E1 RID: 10721
		global::Org.BouncyCastle.Crypto.IBlockCipher GetUnderlyingCipher();
	}
}
