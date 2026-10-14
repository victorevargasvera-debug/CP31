using System;

namespace AcpCryptoLib
{
	// Token: 0x0200000F RID: 15
	public interface IAcpEncryptDecrypt
	{
		// Token: 0x06000025 RID: 37
		byte[] Encrypt(byte[] plainData);

		// Token: 0x06000026 RID: 38
		byte[] Decrypt(byte[] encryptedData);
	}
}
