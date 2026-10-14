using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000180 RID: 384
	internal sealed class BcTlsRsaEncryptor : global::Org.BouncyCastle.Tls.Crypto.TlsEncryptor
	{
		// Token: 0x06000EAF RID: 3759 RVA: 0x00036149 File Offset: 0x00034349
		private static global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters CheckPublicKey(global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters pubKeyRsa)
		{
			if (pubKeyRsa == null || pubKeyRsa.IsPrivate)
			{
				throw new global::System.ArgumentException("No public RSA key provided", "pubKeyRsa");
			}
			return pubKeyRsa;
		}

		// Token: 0x06000EB0 RID: 3760 RVA: 0x00036167 File Offset: 0x00034367
		internal BcTlsRsaEncryptor(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters pubKeyRsa)
		{
			this.m_crypto = crypto;
			this.m_pubKeyRsa = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsRsaEncryptor.CheckPublicKey(pubKeyRsa);
		}

		// Token: 0x06000EB1 RID: 3761 RVA: 0x00036184 File Offset: 0x00034384
		public byte[] Encrypt(byte[] input, int inOff, int length)
		{
			byte[] result;
			try
			{
				global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding pkcs1Encoding = new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine());
				pkcs1Encoding.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(this.m_pubKeyRsa, this.m_crypto.SecureRandom));
				result = pkcs1Encoding.ProcessBlock(input, inOff, length);
			}
			catch (global::Org.BouncyCastle.Crypto.InvalidCipherTextException e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			return result;
		}

		// Token: 0x04000830 RID: 2096
		private readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

		// Token: 0x04000831 RID: 2097
		private readonly global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters m_pubKeyRsa;
	}
}
