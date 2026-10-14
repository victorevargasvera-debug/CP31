using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200032B RID: 811
	public abstract class ECBasisType
	{
		// Token: 0x06002219 RID: 8729 RVA: 0x000974E5 File Offset: 0x000956E5
		public static bool IsValid(byte ecBasisType)
		{
			return ecBasisType >= 1 && ecBasisType <= 2;
		}

		// Token: 0x04000D16 RID: 3350
		public const byte ec_basis_trinomial = 1;

		// Token: 0x04000D17 RID: 3351
		public const byte ec_basis_pentanomial = 2;
	}
}
