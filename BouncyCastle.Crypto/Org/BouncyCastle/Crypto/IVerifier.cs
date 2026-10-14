using System;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002E2 RID: 738
	public interface IVerifier
	{
		// Token: 0x06001FD4 RID: 8148
		bool IsVerified(byte[] data);

		// Token: 0x06001FD5 RID: 8149
		bool IsVerified(byte[] source, int off, int length);
	}
}
