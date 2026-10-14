using System;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x020002F7 RID: 759
	public abstract class AbstractTlsEncryptionCredentials : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsCredentials, global::Org.BouncyCastle.Crypto.Tls.TlsEncryptionCredentials, global::Org.BouncyCastle.Crypto.Tls.TlsCredentials
	{
		// Token: 0x0600207B RID: 8315
		public abstract byte[] DecryptPreMasterSecret(byte[] encryptedPreMasterSecret);
	}
}
