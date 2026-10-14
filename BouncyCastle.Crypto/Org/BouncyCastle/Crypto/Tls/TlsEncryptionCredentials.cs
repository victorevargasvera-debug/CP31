using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200036E RID: 878
	public interface TlsEncryptionCredentials : global::Org.BouncyCastle.Crypto.Tls.TlsCredentials
	{
		// Token: 0x060023B1 RID: 9137
		byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret);
	}
}
