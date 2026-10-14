using System;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x02000414 RID: 1044
	public interface IBlockCipherPadding
	{
		// Token: 0x060028C2 RID: 10434
		void Init(global::Org.BouncyCastle.Security.SecureRandom random);

		// Token: 0x170005B0 RID: 1456
		// (get) Token: 0x060028C3 RID: 10435
		string PaddingName { get; }

		// Token: 0x060028C4 RID: 10436
		int AddPadding(byte[] input, int inOff);

		// Token: 0x060028C5 RID: 10437
		int PadCount(byte[] input);
	}
}
