using System;
using System.IO;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002C8 RID: 712
	public interface ICipher
	{
		// Token: 0x06001F89 RID: 8073
		int GetMaxOutputSize(int inputLen);

		// Token: 0x06001F8A RID: 8074
		int GetUpdateOutputSize(int inputLen);

		// Token: 0x17000450 RID: 1104
		// (get) Token: 0x06001F8B RID: 8075
		global::System.IO.Stream Stream { get; }
	}
}
