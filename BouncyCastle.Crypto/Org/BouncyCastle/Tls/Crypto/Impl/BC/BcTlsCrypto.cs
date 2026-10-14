using System;
using Org.BouncyCastle.Crypto;
using Org.BouncyCastle.Crypto.Agreement.Srp;
using Org.BouncyCastle.Crypto.Digests;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Prng;
using Org.BouncyCastle.Math;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl.BC
{
	// Token: 0x0200016C RID: 364
	public class BcTlsCrypto : global::Org.BouncyCastle.Tls.Crypto.Impl.AbstractTlsCrypto
	{
		// Token: 0x06000E20 RID: 3616 RVA: 0x00034DEC File Offset: 0x00032FEC
		public BcTlsCrypto(global::Org.BouncyCastle.Security.SecureRandom entropySource)
		{
			this.m_entropySource = entropySource;
		}

		// Token: 0x06000E21 RID: 3617 RVA: 0x00034DFB File Offset: 0x00032FFB
		internal virtual global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret AdoptLocalSecret(byte[] data)
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSecret(this, data);
		}

		// Token: 0x17000206 RID: 518
		// (get) Token: 0x06000E22 RID: 3618 RVA: 0x00034E04 File Offset: 0x00033004
		public override global::Org.BouncyCastle.Security.SecureRandom SecureRandom
		{
			get
			{
				return this.m_entropySource;
			}
		}

		// Token: 0x06000E23 RID: 3619 RVA: 0x00034E0C File Offset: 0x0003300C
		public override global::Org.BouncyCastle.Tls.Crypto.TlsCertificate CreateCertificate(byte[] encoding)
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsCertificate(this, encoding);
		}

		// Token: 0x06000E24 RID: 3620 RVA: 0x00034E18 File Offset: 0x00033018
		public override global::Org.BouncyCastle.Tls.Crypto.TlsCipher CreateCipher(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int encryptionAlgorithm, int macAlgorithm)
		{
			switch (encryptionAlgorithm)
			{
			case 0:
				return this.CreateNullCipher(cryptoParams, macAlgorithm);
			case 7:
				return this.CreateCipher_Cbc(cryptoParams, encryptionAlgorithm, 24, macAlgorithm);
			case 8:
			case 12:
			case 14:
			case 22:
			case 28:
				return this.CreateCipher_Cbc(cryptoParams, encryptionAlgorithm, 16, macAlgorithm);
			case 9:
			case 13:
			case 23:
				return this.CreateCipher_Cbc(cryptoParams, encryptionAlgorithm, 32, macAlgorithm);
			case 10:
				return this.CreateCipher_Aes_Gcm(cryptoParams, 16, 16);
			case 11:
				return this.CreateCipher_Aes_Gcm(cryptoParams, 32, 16);
			case 15:
				return this.CreateCipher_Aes_Ccm(cryptoParams, 16, 16);
			case 16:
				return this.CreateCipher_Aes_Ccm(cryptoParams, 16, 8);
			case 17:
				return this.CreateCipher_Aes_Ccm(cryptoParams, 32, 16);
			case 18:
				return this.CreateCipher_Aes_Ccm(cryptoParams, 32, 8);
			case 19:
				return this.CreateCipher_Camellia_Gcm(cryptoParams, 16, 16);
			case 20:
				return this.CreateCipher_Camellia_Gcm(cryptoParams, 32, 16);
			case 21:
				return this.CreateChaCha20Poly1305(cryptoParams);
			case 24:
				return this.CreateCipher_Aria_Gcm(cryptoParams, 16, 16);
			case 25:
				return this.CreateCipher_Aria_Gcm(cryptoParams, 32, 16);
			case 26:
				return this.CreateCipher_SM4_Ccm(cryptoParams);
			case 27:
				return this.CreateCipher_SM4_Gcm(cryptoParams);
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000E25 RID: 3621 RVA: 0x00034F66 File Offset: 0x00033166
		public override global::Org.BouncyCastle.Tls.Crypto.TlsDHDomain CreateDHDomain(global::Org.BouncyCastle.Tls.Crypto.TlsDHConfig dhConfig)
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsDHDomain(this, dhConfig);
		}

		// Token: 0x06000E26 RID: 3622 RVA: 0x00034F70 File Offset: 0x00033170
		public override global::Org.BouncyCastle.Tls.Crypto.TlsECDomain CreateECDomain(global::Org.BouncyCastle.Tls.Crypto.TlsECConfig ecConfig)
		{
			int namedGroup = ecConfig.NamedGroup;
			if (namedGroup == 29)
			{
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcX25519Domain(this);
			}
			if (namedGroup != 30)
			{
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsECDomain(this, ecConfig);
			}
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcX448Domain(this);
		}

		// Token: 0x06000E27 RID: 3623 RVA: 0x00034FA8 File Offset: 0x000331A8
		public override global::Org.BouncyCastle.Tls.Crypto.TlsNonceGenerator CreateNonceGenerator(byte[] additionalSeedMaterial)
		{
			global::Org.BouncyCastle.Crypto.IDigest digest = this.CreateDigest(4);
			byte[] seed = new byte[digest.GetDigestSize()];
			this.SecureRandom.NextBytes(seed);
			global::Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator digestRandomGenerator = new global::Org.BouncyCastle.Crypto.Prng.DigestRandomGenerator(digest);
			digestRandomGenerator.AddSeedMaterial(additionalSeedMaterial);
			digestRandomGenerator.AddSeedMaterial(seed);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsNonceGenerator(digestRandomGenerator);
		}

		// Token: 0x06000E28 RID: 3624 RVA: 0x00034FEC File Offset: 0x000331EC
		public override bool HasAllRawSignatureAlgorithms()
		{
			return !this.HasSignatureAlgorithm(7) && !this.HasSignatureAlgorithm(8);
		}

		// Token: 0x06000E29 RID: 3625 RVA: 0x00035003 File Offset: 0x00033203
		public override bool HasDHAgreement()
		{
			return true;
		}

		// Token: 0x06000E2A RID: 3626 RVA: 0x00035006 File Offset: 0x00033206
		public override bool HasECDHAgreement()
		{
			return true;
		}

		// Token: 0x06000E2B RID: 3627 RVA: 0x00035009 File Offset: 0x00033209
		public override bool HasEncryptionAlgorithm(int encryptionAlgorithm)
		{
			return encryptionAlgorithm - 1 > 5;
		}

		// Token: 0x06000E2C RID: 3628 RVA: 0x00035014 File Offset: 0x00033214
		public override bool HasCryptoHashAlgorithm(int cryptoHashAlgorithm)
		{
			return true;
		}

		// Token: 0x06000E2D RID: 3629 RVA: 0x00035017 File Offset: 0x00033217
		public override bool HasCryptoSignatureAlgorithm(int cryptoSignatureAlgorithm)
		{
			if (cryptoSignatureAlgorithm - 1 > 10)
			{
				if (cryptoSignatureAlgorithm - 64 > 1 && cryptoSignatureAlgorithm != 200)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000E2E RID: 3630 RVA: 0x00035034 File Offset: 0x00033234
		public override bool HasMacAlgorithm(int macAlgorithm)
		{
			return true;
		}

		// Token: 0x06000E2F RID: 3631 RVA: 0x00035037 File Offset: 0x00033237
		public override bool HasNamedGroup(int namedGroup)
		{
			return global::Org.BouncyCastle.Tls.NamedGroup.RefersToASpecificGroup(namedGroup);
		}

		// Token: 0x06000E30 RID: 3632 RVA: 0x0003503F File Offset: 0x0003323F
		public override bool HasRsaEncryption()
		{
			return true;
		}

		// Token: 0x06000E31 RID: 3633 RVA: 0x00035042 File Offset: 0x00033242
		public override bool HasSignatureAlgorithm(short signatureAlgorithm)
		{
			if (signatureAlgorithm - 1 > 10 && signatureAlgorithm - 26 > 2)
			{
				if (signatureAlgorithm - 64 > 1)
				{
				}
				return false;
			}
			return true;
		}

		// Token: 0x06000E32 RID: 3634 RVA: 0x00035060 File Offset: 0x00033260
		public override bool HasSignatureAndHashAlgorithm(global::Org.BouncyCastle.Tls.SignatureAndHashAlgorithm sigAndHashAlgorithm)
		{
			short signature = sigAndHashAlgorithm.Signature;
			if (sigAndHashAlgorithm.Hash == 1)
			{
				return 1 == signature && this.HasSignatureAlgorithm(signature);
			}
			return this.HasSignatureAlgorithm(signature);
		}

		// Token: 0x06000E33 RID: 3635 RVA: 0x00035094 File Offset: 0x00033294
		public override bool HasSignatureScheme(int signatureScheme)
		{
			if (signatureScheme == 1800)
			{
				return false;
			}
			short signature = global::Org.BouncyCastle.Tls.SignatureScheme.GetSignatureAlgorithm(signatureScheme);
			if (global::Org.BouncyCastle.Tls.SignatureScheme.GetCryptoHashAlgorithm(signatureScheme) == 1)
			{
				return 1 == signature && this.HasSignatureAlgorithm(signature);
			}
			return this.HasSignatureAlgorithm(signature);
		}

		// Token: 0x06000E34 RID: 3636 RVA: 0x000350D0 File Offset: 0x000332D0
		public override bool HasSrpAuthentication()
		{
			return true;
		}

		// Token: 0x06000E35 RID: 3637 RVA: 0x000350D3 File Offset: 0x000332D3
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret CreateSecret(byte[] data)
		{
			return this.AdoptLocalSecret(global::Org.BouncyCastle.Utilities.Arrays.Clone(data));
		}

		// Token: 0x06000E36 RID: 3638 RVA: 0x000350E4 File Offset: 0x000332E4
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret GenerateRsaPreMasterSecret(global::Org.BouncyCastle.Tls.ProtocolVersion version)
		{
			byte[] data = new byte[48];
			this.SecureRandom.NextBytes(data);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(version, data, 0);
			return this.AdoptLocalSecret(data);
		}

		// Token: 0x06000E37 RID: 3639 RVA: 0x00035114 File Offset: 0x00033314
		public virtual global::Org.BouncyCastle.Crypto.IDigest CloneDigest(int cryptoHashAlgorithm, global::Org.BouncyCastle.Crypto.IDigest digest)
		{
			switch (cryptoHashAlgorithm)
			{
			case 1:
				return new global::Org.BouncyCastle.Crypto.Digests.MD5Digest((global::Org.BouncyCastle.Crypto.Digests.MD5Digest)digest);
			case 2:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest((global::Org.BouncyCastle.Crypto.Digests.Sha1Digest)digest);
			case 3:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha224Digest((global::Org.BouncyCastle.Crypto.Digests.Sha224Digest)digest);
			case 4:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest((global::Org.BouncyCastle.Crypto.Digests.Sha256Digest)digest);
			case 5:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha384Digest((global::Org.BouncyCastle.Crypto.Digests.Sha384Digest)digest);
			case 6:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha512Digest((global::Org.BouncyCastle.Crypto.Digests.Sha512Digest)digest);
			case 7:
				return new global::Org.BouncyCastle.Crypto.Digests.SM3Digest((global::Org.BouncyCastle.Crypto.Digests.SM3Digest)digest);
			default:
				throw new global::System.ArgumentException("invalid CryptoHashAlgorithm: " + cryptoHashAlgorithm.ToString());
			}
		}

		// Token: 0x06000E38 RID: 3640 RVA: 0x000351B4 File Offset: 0x000333B4
		public virtual global::Org.BouncyCastle.Crypto.IDigest CreateDigest(int cryptoHashAlgorithm)
		{
			switch (cryptoHashAlgorithm)
			{
			case 1:
				return new global::Org.BouncyCastle.Crypto.Digests.MD5Digest();
			case 2:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha1Digest();
			case 3:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha224Digest();
			case 4:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha256Digest();
			case 5:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha384Digest();
			case 6:
				return new global::Org.BouncyCastle.Crypto.Digests.Sha512Digest();
			case 7:
				return new global::Org.BouncyCastle.Crypto.Digests.SM3Digest();
			default:
				throw new global::System.ArgumentException("invalid CryptoHashAlgorithm: " + cryptoHashAlgorithm.ToString());
			}
		}

		// Token: 0x06000E39 RID: 3641 RVA: 0x00035227 File Offset: 0x00033427
		public override global::Org.BouncyCastle.Tls.Crypto.TlsHash CreateHash(int cryptoHashAlgorithm)
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsHash(this, cryptoHashAlgorithm);
		}

		// Token: 0x06000E3A RID: 3642 RVA: 0x00035230 File Offset: 0x00033430
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateBlockCipher(int encryptionAlgorithm)
		{
			switch (encryptionAlgorithm)
			{
			case 7:
				return this.CreateDesEdeEngine();
			case 8:
			case 9:
				return this.CreateAesEngine();
			case 10:
			case 11:
				break;
			case 12:
			case 13:
				return this.CreateCamelliaEngine();
			case 14:
				return this.CreateSeedEngine();
			default:
				if (encryptionAlgorithm - 22 <= 1)
				{
					return this.CreateAriaEngine();
				}
				if (encryptionAlgorithm == 28)
				{
					return this.CreateSM4Engine();
				}
				break;
			}
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000E3B RID: 3643 RVA: 0x000352A4 File Offset: 0x000334A4
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateCbcBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher blockCipher)
		{
			return new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(blockCipher);
		}

		// Token: 0x06000E3C RID: 3644 RVA: 0x000352AC File Offset: 0x000334AC
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateCbcBlockCipher(int encryptionAlgorithm)
		{
			return this.CreateCbcBlockCipher(this.CreateBlockCipher(encryptionAlgorithm));
		}

		// Token: 0x06000E3D RID: 3645 RVA: 0x000352BC File Offset: 0x000334BC
		protected virtual global::Org.BouncyCastle.Tls.Crypto.TlsCipher CreateChaCha20Poly1305(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams)
		{
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcChaCha20Poly1305 encrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcChaCha20Poly1305(true);
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcChaCha20Poly1305 decrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcChaCha20Poly1305(false);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher(cryptoParams, encrypt, decrypt, 32, 16, 2);
		}

		// Token: 0x06000E3E RID: 3646 RVA: 0x000352E4 File Offset: 0x000334E4
		protected virtual global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher CreateCipher_Aes_Ccm(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
		{
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl encrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_Aes_Ccm(), true);
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl decrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_Aes_Ccm(), false);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher(cryptoParams, encrypt, decrypt, cipherKeySize, macSize, 1);
		}

		// Token: 0x06000E3F RID: 3647 RVA: 0x00035318 File Offset: 0x00033518
		protected virtual global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher CreateCipher_Aes_Gcm(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
		{
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl encrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_Aes_Gcm(), true);
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl decrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_Aes_Gcm(), false);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher(cryptoParams, encrypt, decrypt, cipherKeySize, macSize, 3);
		}

		// Token: 0x06000E40 RID: 3648 RVA: 0x0003534C File Offset: 0x0003354C
		protected virtual global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher CreateCipher_Aria_Gcm(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
		{
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl encrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_Aria_Gcm(), true);
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl decrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_Aria_Gcm(), false);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher(cryptoParams, encrypt, decrypt, cipherKeySize, macSize, 3);
		}

		// Token: 0x06000E41 RID: 3649 RVA: 0x00035380 File Offset: 0x00033580
		protected virtual global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher CreateCipher_Camellia_Gcm(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int cipherKeySize, int macSize)
		{
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl encrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_Camellia_Gcm(), true);
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl decrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_Camellia_Gcm(), false);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher(cryptoParams, encrypt, decrypt, cipherKeySize, macSize, 3);
		}

		// Token: 0x06000E42 RID: 3650 RVA: 0x000353B4 File Offset: 0x000335B4
		protected virtual global::Org.BouncyCastle.Tls.Crypto.TlsCipher CreateCipher_Cbc(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int encryptionAlgorithm, int cipherKeySize, int macAlgorithm)
		{
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsBlockCipherImpl encrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsBlockCipherImpl(this.CreateCbcBlockCipher(encryptionAlgorithm), true);
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsBlockCipherImpl decrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsBlockCipherImpl(this.CreateCbcBlockCipher(encryptionAlgorithm), false);
			global::Org.BouncyCastle.Tls.Crypto.TlsHmac clientMac = this.CreateMac(cryptoParams, macAlgorithm);
			global::Org.BouncyCastle.Tls.Crypto.TlsHmac serverMac = this.CreateMac(cryptoParams, macAlgorithm);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsBlockCipher(cryptoParams, encrypt, decrypt, clientMac, serverMac, cipherKeySize);
		}

		// Token: 0x06000E43 RID: 3651 RVA: 0x000353FC File Offset: 0x000335FC
		protected virtual global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher CreateCipher_SM4_Ccm(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams)
		{
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl encrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_SM4_Ccm(), true);
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl decrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_SM4_Ccm(), false);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher(cryptoParams, encrypt, decrypt, 16, 16, 1);
		}

		// Token: 0x06000E44 RID: 3652 RVA: 0x00035430 File Offset: 0x00033630
		protected virtual global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher CreateCipher_SM4_Gcm(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams)
		{
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl encrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_SM4_Gcm(), true);
			global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl decrypt = new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsAeadCipherImpl(this.CreateAeadBlockCipher_SM4_Gcm(), false);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher(cryptoParams, encrypt, decrypt, 16, 16, 3);
		}

		// Token: 0x06000E45 RID: 3653 RVA: 0x00035464 File Offset: 0x00033664
		protected virtual global::Org.BouncyCastle.Tls.Crypto.Impl.TlsNullCipher CreateNullCipher(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int macAlgorithm)
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsNullCipher(cryptoParams, this.CreateMac(cryptoParams, macAlgorithm), this.CreateMac(cryptoParams, macAlgorithm));
		}

		// Token: 0x06000E46 RID: 3654 RVA: 0x0003547C File Offset: 0x0003367C
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateAesEngine()
		{
			return new global::Org.BouncyCastle.Crypto.Engines.AesEngine();
		}

		// Token: 0x06000E47 RID: 3655 RVA: 0x00035483 File Offset: 0x00033683
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateAriaEngine()
		{
			return new global::Org.BouncyCastle.Crypto.Engines.AriaEngine();
		}

		// Token: 0x06000E48 RID: 3656 RVA: 0x0003548A File Offset: 0x0003368A
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateCamelliaEngine()
		{
			return new global::Org.BouncyCastle.Crypto.Engines.CamelliaEngine();
		}

		// Token: 0x06000E49 RID: 3657 RVA: 0x00035491 File Offset: 0x00033691
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateDesEdeEngine()
		{
			return new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine();
		}

		// Token: 0x06000E4A RID: 3658 RVA: 0x00035498 File Offset: 0x00033698
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateSeedEngine()
		{
			return new global::Org.BouncyCastle.Crypto.Engines.SeedEngine();
		}

		// Token: 0x06000E4B RID: 3659 RVA: 0x0003549F File Offset: 0x0003369F
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateSM4Engine()
		{
			return new global::Org.BouncyCastle.Crypto.Engines.SM4Engine();
		}

		// Token: 0x06000E4C RID: 3660 RVA: 0x000354A6 File Offset: 0x000336A6
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateCcmMode(global::Org.BouncyCastle.Crypto.IBlockCipher engine)
		{
			return new global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher(engine);
		}

		// Token: 0x06000E4D RID: 3661 RVA: 0x000354AE File Offset: 0x000336AE
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateGcmMode(global::Org.BouncyCastle.Crypto.IBlockCipher engine)
		{
			return new global::Org.BouncyCastle.Crypto.Modes.GcmBlockCipher(engine);
		}

		// Token: 0x06000E4E RID: 3662 RVA: 0x000354B6 File Offset: 0x000336B6
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Aes_Ccm()
		{
			return this.CreateCcmMode(this.CreateAesEngine());
		}

		// Token: 0x06000E4F RID: 3663 RVA: 0x000354C4 File Offset: 0x000336C4
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Aes_Gcm()
		{
			return this.CreateGcmMode(this.CreateAesEngine());
		}

		// Token: 0x06000E50 RID: 3664 RVA: 0x000354D2 File Offset: 0x000336D2
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Aria_Gcm()
		{
			return this.CreateGcmMode(this.CreateAriaEngine());
		}

		// Token: 0x06000E51 RID: 3665 RVA: 0x000354E0 File Offset: 0x000336E0
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Camellia_Gcm()
		{
			return this.CreateGcmMode(this.CreateCamelliaEngine());
		}

		// Token: 0x06000E52 RID: 3666 RVA: 0x000354EE File Offset: 0x000336EE
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_SM4_Ccm()
		{
			return this.CreateCcmMode(this.CreateSM4Engine());
		}

		// Token: 0x06000E53 RID: 3667 RVA: 0x000354FC File Offset: 0x000336FC
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_SM4_Gcm()
		{
			return this.CreateGcmMode(this.CreateSM4Engine());
		}

		// Token: 0x06000E54 RID: 3668 RVA: 0x0003550A File Offset: 0x0003370A
		public override global::Org.BouncyCastle.Tls.Crypto.TlsHmac CreateHmac(int macAlgorithm)
		{
			return this.CreateHmacForHash(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashForHmac(macAlgorithm));
		}

		// Token: 0x06000E55 RID: 3669 RVA: 0x00035518 File Offset: 0x00033718
		public override global::Org.BouncyCastle.Tls.Crypto.TlsHmac CreateHmacForHash(int cryptoHashAlgorithm)
		{
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsHmac(new global::Org.BouncyCastle.Crypto.Macs.HMac(this.CreateDigest(cryptoHashAlgorithm)));
		}

		// Token: 0x06000E56 RID: 3670 RVA: 0x0003552C File Offset: 0x0003372C
		protected virtual global::Org.BouncyCastle.Tls.Crypto.TlsHmac CreateHmac_Ssl(int macAlgorithm)
		{
			switch (macAlgorithm)
			{
			case 1:
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcSsl3Hmac(this.CreateDigest(1));
			case 2:
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcSsl3Hmac(this.CreateDigest(2));
			case 3:
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcSsl3Hmac(this.CreateDigest(4));
			case 4:
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcSsl3Hmac(this.CreateDigest(5));
			case 5:
				return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcSsl3Hmac(this.CreateDigest(6));
			default:
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x0003559F File Offset: 0x0003379F
		protected virtual global::Org.BouncyCastle.Tls.Crypto.TlsHmac CreateMac(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, int macAlgorithm)
		{
			if (global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsSsl(cryptoParams))
			{
				return this.CreateHmac_Ssl(macAlgorithm);
			}
			return this.CreateHmac(macAlgorithm);
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x000355B8 File Offset: 0x000337B8
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Client CreateSrp6Client(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig)
		{
			global::Org.BouncyCastle.Math.BigInteger[] ng = srpConfig.GetExplicitNG();
			global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters srpGroup = new global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters(ng[0], ng[1]);
			global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Client srp6Client = new global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Client();
			srp6Client.Init(srpGroup, this.CreateDigest(2), this.SecureRandom);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSrp6Client(srp6Client);
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x000355F8 File Offset: 0x000337F8
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSrp6Server CreateSrp6Server(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig, global::Org.BouncyCastle.Math.BigInteger srpVerifier)
		{
			global::Org.BouncyCastle.Math.BigInteger[] ng = srpConfig.GetExplicitNG();
			global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters srpGroup = new global::Org.BouncyCastle.Crypto.Parameters.Srp6GroupParameters(ng[0], ng[1]);
			global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Server srp6Server = new global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6Server();
			srp6Server.Init(srpGroup, srpVerifier, this.CreateDigest(2), this.SecureRandom);
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSrp6Server(srp6Server);
		}

		// Token: 0x06000E5A RID: 3674 RVA: 0x00035638 File Offset: 0x00033838
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSrp6VerifierGenerator CreateSrp6VerifierGenerator(global::Org.BouncyCastle.Tls.Crypto.TlsSrpConfig srpConfig)
		{
			global::Org.BouncyCastle.Math.BigInteger[] ng = srpConfig.GetExplicitNG();
			global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6VerifierGenerator srp6VerifierGenerator = new global::Org.BouncyCastle.Crypto.Agreement.Srp.Srp6VerifierGenerator();
			srp6VerifierGenerator.Init(ng[0], ng[1], this.CreateDigest(2));
			return new global::Org.BouncyCastle.Tls.Crypto.Impl.BC.BcTlsSrp6VerifierGenerator(srp6VerifierGenerator);
		}

		// Token: 0x06000E5B RID: 3675 RVA: 0x00035669 File Offset: 0x00033869
		public override global::Org.BouncyCastle.Tls.Crypto.TlsSecret HkdfInit(int cryptoHashAlgorithm)
		{
			return this.AdoptLocalSecret(new byte[global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.GetHashOutputSize(cryptoHashAlgorithm)]);
		}

		// Token: 0x0400081C RID: 2076
		private readonly global::Org.BouncyCastle.Security.SecureRandom m_entropySource;
	}
}
