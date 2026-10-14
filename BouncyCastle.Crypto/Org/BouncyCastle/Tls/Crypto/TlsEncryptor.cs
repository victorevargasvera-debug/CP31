using System;

namespace Org.BouncyCastle.Tls.Crypto
{
	// Token: 0x02000148 RID: 328
	public interface TlsEncryptor
	{
		// Token: 0x06000D31 RID: 3377
		byte[] Encrypt(byte[] input, int inOff, int length);
	}
}
