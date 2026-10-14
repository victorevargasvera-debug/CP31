using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x02000167 RID: 359
	public class BcDefaultTlsCredentialedSigner : global::Org.BouncyCastle.Tls.DefaultTlsCredentialedSigner
	{
		// Token: 0x06000DE8 RID: 3560 RVA: 0x00034308 File Offset: 0x00032508
		private static global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate GetEndEntity(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Tls.Certificate certificate)
		{
			if (certificate == null || certificate.IsEmpty)
			{
				throw new global::System.ArgumentException("No certificate");
			}
			return global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate.Convert(crypto, certificate.GetCertificateAt(0));
		}

		// Token: 0x06000DE9 RID: 3561 RVA: 0x00034330 File Offset: 0x00032530
		private static global::Org.BouncyCastle.Tls.Crypto.TlsSigner MakeSigner(global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Tls.Certificate certificate, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm)
		{
			global::Org.BouncyCastle.Tls.Crypto.TlsSigner signer;
			if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters privKeyRsa = (global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters)privateKey;
				if (signatureAndHashAlgorithm != null)
				{
					int signatureScheme = global::Org.BouncyCastle.Tls.SignatureScheme.From(signatureAndHashAlgorithm);
					if (global::Org.BouncyCastle.Tls.SignatureScheme.IsRsaPss(signatureScheme))
					{
						return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsRsaPssSigner(crypto, privKeyRsa, signatureScheme);
					}
				}
				global::Org.BouncyCastle.Crypto.Parameters.RsaKeyParameters pubKeyRsa = global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcDefaultTlsCredentialedSigner.GetEndEntity(crypto, certificate).GetPubKeyRsa();
				signer = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsRsaSigner(crypto, privKeyRsa, pubKeyRsa);
			}
			else if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)
			{
				signer = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDsaSigner(crypto, (global::Org.BouncyCastle.Crypto.Parameters.DsaPrivateKeyParameters)privateKey);
			}
			else if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters privKeyEC = (global::Org.BouncyCastle.Crypto.Parameters.ECPrivateKeyParameters)privateKey;
				if (signatureAndHashAlgorithm != null)
				{
					int signatureScheme2 = global::Org.BouncyCastle.Tls.SignatureScheme.From(signatureAndHashAlgorithm);
					if (global::Org.BouncyCastle.Tls.SignatureScheme.IsECDsa(signatureScheme2))
					{
						return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDsa13Signer(crypto, privKeyEC, signatureScheme2);
					}
				}
				signer = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDsaSigner(crypto, privKeyEC);
			}
			else if (privateKey is global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters)
			{
				signer = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsEd25519Signer(crypto, (global::Org.BouncyCastle.Crypto.Parameters.Ed25519PrivateKeyParameters)privateKey);
			}
			else
			{
				if (!(privateKey is global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters))
				{
					throw new global::System.ArgumentException("'privateKey' type not supported: " + global::Org.BouncyCastle.Utilities.Platform.GetTypeName(privateKey));
				}
				signer = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsEd448Signer(crypto, (global::Org.BouncyCastle.Crypto.Parameters.Ed448PrivateKeyParameters)privateKey);
			}
			return signer;
		}

		// Token: 0x06000DEA RID: 3562 RVA: 0x00034418 File Offset: 0x00032618
		public BcDefaultTlsCredentialedSigner(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCrypto crypto, global::Org.BouncyCastle.Crypto.AsymmetricKeyParameter privateKey, global::Org.BouncyCastle.Tls.Certificate certificate, global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm signatureAndHashAlgorithm) : base(cryptoParams, global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcDefaultTlsCredentialedSigner.MakeSigner(crypto, privateKey, certificate, signatureAndHashAlgorithm), certificate, signatureAndHashAlgorithm)
		{
		}
	}
}
