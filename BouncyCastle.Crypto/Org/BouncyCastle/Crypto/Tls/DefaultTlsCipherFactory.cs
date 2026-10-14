using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Modes;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000317 RID: 791
	public class DefaultTlsCipherFactory : global::Org.BouncyCastle.Crypto.Tls.AbstractTlsCipherFactory
	{
		// Token: 0x06002146 RID: 8518 RVA: 0x000932C8 File Offset: 0x000914C8
		public override global::Org.BouncyCastle.Crypto.Tls.TlsCipher CreateCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int encryptionAlgorithm, int macAlgorithm)
		{
			switch (encryptionAlgorithm)
			{
			case 0:
				return this.CreateNullCipher(context, macAlgorithm);
			case 1:
			case 3:
			case 4:
			case 5:
			case 6:
				break;
			case 2:
				return this.CreateRC4Cipher(context, 16, macAlgorithm);
			case 7:
				return this.CreateDesEdeCipher(context, macAlgorithm);
			case 8:
				return this.CreateAESCipher(context, 16, macAlgorithm);
			case 9:
				return this.CreateAESCipher(context, 32, macAlgorithm);
			case 10:
				return this.CreateCipher_Aes_Gcm(context, 16, 16);
			case 11:
				return this.CreateCipher_Aes_Gcm(context, 32, 16);
			case 12:
				return this.CreateCamelliaCipher(context, 16, macAlgorithm);
			case 13:
				return this.CreateCamelliaCipher(context, 32, macAlgorithm);
			case 14:
				return this.CreateSeedCipher(context, macAlgorithm);
			case 15:
				return this.CreateCipher_Aes_Ccm(context, 16, 16);
			case 16:
				return this.CreateCipher_Aes_Ccm(context, 16, 8);
			case 17:
				return this.CreateCipher_Aes_Ccm(context, 32, 16);
			case 18:
				return this.CreateCipher_Aes_Ccm(context, 32, 8);
			case 19:
				return this.CreateCipher_Camellia_Gcm(context, 16, 16);
			case 20:
				return this.CreateCipher_Camellia_Gcm(context, 32, 16);
			case 21:
				return this.CreateChaCha20Poly1305(context);
			default:
				if (encryptionAlgorithm == 103)
				{
					return this.CreateCipher_Aes_Ocb(context, 16, 12);
				}
				if (encryptionAlgorithm == 104)
				{
					return this.CreateCipher_Aes_Ocb(context, 32, 12);
				}
				break;
			}
			throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06002147 RID: 8519 RVA: 0x00093419 File Offset: 0x00091619
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher CreateAESCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher(context, this.CreateAesBlockCipher(), this.CreateAesBlockCipher(), this.CreateHMacDigest(macAlgorithm), this.CreateHMacDigest(macAlgorithm), cipherKeySize);
		}

		// Token: 0x06002148 RID: 8520 RVA: 0x0009343C File Offset: 0x0009163C
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher CreateCamelliaCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher(context, this.CreateCamelliaBlockCipher(), this.CreateCamelliaBlockCipher(), this.CreateHMacDigest(macAlgorithm), this.CreateHMacDigest(macAlgorithm), cipherKeySize);
		}

		// Token: 0x06002149 RID: 8521 RVA: 0x0009345F File Offset: 0x0009165F
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsCipher CreateChaCha20Poly1305(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.Chacha20Poly1305(context);
		}

		// Token: 0x0600214A RID: 8522 RVA: 0x00093467 File Offset: 0x00091667
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsAeadCipher CreateCipher_Aes_Ccm(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macSize)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsAeadCipher(context, this.CreateAeadBlockCipher_Aes_Ccm(), this.CreateAeadBlockCipher_Aes_Ccm(), cipherKeySize, macSize);
		}

		// Token: 0x0600214B RID: 8523 RVA: 0x0009347D File Offset: 0x0009167D
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsAeadCipher CreateCipher_Aes_Gcm(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macSize)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsAeadCipher(context, this.CreateAeadBlockCipher_Aes_Gcm(), this.CreateAeadBlockCipher_Aes_Gcm(), cipherKeySize, macSize);
		}

		// Token: 0x0600214C RID: 8524 RVA: 0x00093493 File Offset: 0x00091693
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsAeadCipher CreateCipher_Aes_Ocb(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macSize)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsAeadCipher(context, this.CreateAeadBlockCipher_Aes_Ocb(), this.CreateAeadBlockCipher_Aes_Ocb(), cipherKeySize, macSize, 2);
		}

		// Token: 0x0600214D RID: 8525 RVA: 0x000934AA File Offset: 0x000916AA
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsAeadCipher CreateCipher_Camellia_Gcm(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macSize)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsAeadCipher(context, this.CreateAeadBlockCipher_Camellia_Gcm(), this.CreateAeadBlockCipher_Camellia_Gcm(), cipherKeySize, macSize);
		}

		// Token: 0x0600214E RID: 8526 RVA: 0x000934C0 File Offset: 0x000916C0
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher CreateDesEdeCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int macAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher(context, this.CreateDesEdeBlockCipher(), this.CreateDesEdeBlockCipher(), this.CreateHMacDigest(macAlgorithm), this.CreateHMacDigest(macAlgorithm), 24);
		}

		// Token: 0x0600214F RID: 8527 RVA: 0x000934E4 File Offset: 0x000916E4
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsNullCipher CreateNullCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int macAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsNullCipher(context, this.CreateHMacDigest(macAlgorithm), this.CreateHMacDigest(macAlgorithm));
		}

		// Token: 0x06002150 RID: 8528 RVA: 0x000934FA File Offset: 0x000916FA
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsStreamCipher CreateRC4Cipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int cipherKeySize, int macAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsStreamCipher(context, this.CreateRC4StreamCipher(), this.CreateRC4StreamCipher(), this.CreateHMacDigest(macAlgorithm), this.CreateHMacDigest(macAlgorithm), cipherKeySize, false);
		}

		// Token: 0x06002151 RID: 8529 RVA: 0x0009351E File Offset: 0x0009171E
		protected virtual global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher CreateSeedCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, int macAlgorithm)
		{
			return new global::Org.BouncyCastle.Crypto.Tls.TlsBlockCipher(context, this.CreateSeedBlockCipher(), this.CreateSeedBlockCipher(), this.CreateHMacDigest(macAlgorithm), this.CreateHMacDigest(macAlgorithm), 16);
		}

		// Token: 0x06002152 RID: 8530 RVA: 0x00093542 File Offset: 0x00091742
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateAesEngine()
		{
			return new global::Org.BouncyCastle.Crypto.Engines.AesEngine();
		}

		// Token: 0x06002153 RID: 8531 RVA: 0x00093549 File Offset: 0x00091749
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateCamelliaEngine()
		{
			return new global::Org.BouncyCastle.Crypto.Engines.CamelliaEngine();
		}

		// Token: 0x06002154 RID: 8532 RVA: 0x00093550 File Offset: 0x00091750
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateAesBlockCipher()
		{
			return new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(this.CreateAesEngine());
		}

		// Token: 0x06002155 RID: 8533 RVA: 0x0009355D File Offset: 0x0009175D
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Aes_Ccm()
		{
			return new global::Org.BouncyCastle.Crypto.Modes.CcmBlockCipher(this.CreateAesEngine());
		}

		// Token: 0x06002156 RID: 8534 RVA: 0x0009356A File Offset: 0x0009176A
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Aes_Gcm()
		{
			return new global::Org.BouncyCastle.Crypto.Modes.GcmBlockCipher(this.CreateAesEngine());
		}

		// Token: 0x06002157 RID: 8535 RVA: 0x00093577 File Offset: 0x00091777
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Aes_Ocb()
		{
			return new global::Org.BouncyCastle.Crypto.Modes.OcbBlockCipher(this.CreateAesEngine(), this.CreateAesEngine());
		}

		// Token: 0x06002158 RID: 8536 RVA: 0x0009358A File Offset: 0x0009178A
		protected virtual global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher CreateAeadBlockCipher_Camellia_Gcm()
		{
			return new global::Org.BouncyCastle.Crypto.Modes.GcmBlockCipher(this.CreateCamelliaEngine());
		}

		// Token: 0x06002159 RID: 8537 RVA: 0x00093597 File Offset: 0x00091797
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateCamelliaBlockCipher()
		{
			return new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(this.CreateCamelliaEngine());
		}

		// Token: 0x0600215A RID: 8538 RVA: 0x000935A4 File Offset: 0x000917A4
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateDesEdeBlockCipher()
		{
			return new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.DesEdeEngine());
		}

		// Token: 0x0600215B RID: 8539 RVA: 0x000935B0 File Offset: 0x000917B0
		protected virtual global::Org.BouncyCastle.Crypto.IStreamCipher CreateRC4StreamCipher()
		{
			return new global::Org.BouncyCastle.Crypto.Engines.RC4Engine();
		}

		// Token: 0x0600215C RID: 8540 RVA: 0x000935B7 File Offset: 0x000917B7
		protected virtual global::Org.BouncyCastle.Crypto.IBlockCipher CreateSeedBlockCipher()
		{
			return new global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher(new global::Org.BouncyCastle.Crypto.Engines.SeedEngine());
		}

		// Token: 0x0600215D RID: 8541 RVA: 0x000935C4 File Offset: 0x000917C4
		protected virtual global::Org.BouncyCastle.Crypto.IDigest CreateHMacDigest(int macAlgorithm)
		{
			switch (macAlgorithm)
			{
			case 0:
				return null;
			case 1:
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(1);
			case 2:
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(2);
			case 3:
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(4);
			case 4:
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(5);
			case 5:
				return global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CreateHash(6);
			default:
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
		}
	}
}
