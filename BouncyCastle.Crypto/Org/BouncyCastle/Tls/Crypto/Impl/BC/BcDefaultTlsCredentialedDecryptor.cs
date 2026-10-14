using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Encodings;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000166 RID: 358
	public class BcDefaultTlsCredentialedDecryptor : global::Org.BouncyCastle.Tls.TlsCredentialedDecryptor, global::Org.BouncyCastle.Tls.TlsCredentials
	{
		// Token: 0x06000DE4 RID: 3556 RVA: 0x00034164 File Offset: 0x00032364
		public BcDefaultTlsCredentialedDecryptor(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Tls.Certificate certificate, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey)
		{
			if (crypto == null)
			{
				throw new global::System.ArgumentNullException("crypto");
			}
			if (certificate == null)
			{
				throw new global::System.ArgumentNullException("certificate");
			}
			if (certificate.IsEmpty)
			{
				throw new global::System.ArgumentException("cannot be empty", "certificate");
			}
			if (privateKey == null)
			{
				throw new global::System.ArgumentNullException("privateKey");
			}
			if (!privateKey.IsPrivate)
			{
				throw new global::System.ArgumentException("must be private", "privateKey");
			}
			if (!(privateKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters))
			{
				throw new global::System.ArgumentException("'privateKey' type not supported: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(privateKey));
			}
			this.m_crypto = crypto;
			this.m_certificate = certificate;
			this.m_privateKey = privateKey;
		}

		// Token: 0x17000201 RID: 513
		// (get) Token: 0x06000DE5 RID: 3557 RVA: 0x00034204 File Offset: 0x00032404
		public virtual global::Org.BouncyCastle.Tls.Certificate Certificate
		{
			get
			{
				return this.m_certificate;
			}
		}

		// Token: 0x06000DE6 RID: 3558 RVA: 0x0003420C File Offset: 0x0003240C
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret Decrypt(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, byte[] ciphertext)
		{
			return this.SafeDecryptPreMasterSecret(cryptoParams, (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)this.m_privateKey, ciphertext);
		}

		// Token: 0x06000DE7 RID: 3559 RVA: 0x00034224 File Offset: 0x00032424
		protected virtual global::Org.BouncyCastle.Tls.Crypto.TlsSecret SafeDecryptPreMasterSecret(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters rsaServerPrivateKey, byte[] encryptedPreMasterSecret)
		{
			global::Org.BouncyCastle.Security.SecureRandom secureRandom = this.m_crypto.SecureRandom;
			global::Org.BouncyCastle.Tls.ProtocolVersion expectedVersion = cryptoParams.RsaPreMasterSecretVersion;
			bool versionNumberCheckDisabled = false;
			byte[] fallback = new byte[48];
			secureRandom.NextBytes(fallback);
			byte[] M = global::Org.BouncyCastle.Utilities.Arrays.Clone(fallback);
			try
			{
				global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding pkcs1Encoding = new global::Org.BouncyCastle.Crypto.Encodings.Pkcs1Encoding(new global::Org.BouncyCastle.Crypto.Engines.RsaBlindedEngine(), fallback);
				pkcs1Encoding.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom(rsaServerPrivateKey, secureRandom));
				M = pkcs1Encoding.ProcessBlock(encryptedPreMasterSecret, 0, encryptedPreMasterSecret.Length);
			}
			catch (global::System.Exception)
			{
			}
			if (!versionNumberCheckDisabled || global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV11(expectedVersion))
			{
				int mask = (expectedVersion.MajorVersion ^ (int)(M[0] & byte.MaxValue)) | (expectedVersion.MinorVersion ^ (int)(M[1] & byte.MaxValue));
				mask = mask - 1 >> 31;
				for (int i = 0; i < 48; i++)
				{
					M[i] = (byte)(((int)M[i] & mask) | ((int)fallback[i] & ~mask));
				}
			}
			return this.m_crypto.CreateSecret(M);
		}

		// Token: 0x04000805 RID: 2053
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto m_crypto;

		// Token: 0x04000806 RID: 2054
		protected readonly global::Org.BouncyCastle.Tls.Certificate m_certificate;

		// Token: 0x04000807 RID: 2055
		protected readonly global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter m_privateKey;
	}
}
