using System;

namespace NPOI.POIFS.Crypt.Standard
{
	// Token: 0x0200030F RID: 783
	public class NullCipher : global::NPOI.POIFS.Crypt.Cipher
	{
		// Token: 0x060016BA RID: 5818 RVA: 0x000435E7 File Offset: 0x000417E7
		public NullCipher()
		{
			this.cipherImpl = new global::NPOI.POIFS.Crypt.Standard.NullBufferedCipher();
		}
	}
}
