using System;
using Org.BouncyCastle.Tls.Crypto;

namespace Org.BouncyCastle.Tls
{
	// Token: 0x02000100 RID: 256
	public interface TlsCredentialedDecryptor : global::Org.BouncyCastle.Tls.TlsCredentials
	{
		// Token: 0x06000935 RID: 2357
		global::Org.BouncyCastle.Tls.Crypto.TlsSecret Decrypt(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, byte[] ciphertext);
	}
}
