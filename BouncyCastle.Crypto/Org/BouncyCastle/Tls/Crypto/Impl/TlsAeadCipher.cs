using System;
using System.IO;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x0200015C RID: 348
	public class TlsAeadCipher : global::Org.BouncyCastle.Tls.Crypto.TlsCipher
	{
		// Token: 0x06000D98 RID: 3480 RVA: 0x00032AE4 File Offset: 0x00030CE4
		public TlsAeadCipher(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipherImpl encryptCipher, global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipherImpl decryptCipher, int keySize, int macSize, int aeadType)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = cryptoParams.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			if (!global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV12(negotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_isTlsV13 = global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV13(negotiatedVersion);
			this.m_nonceMode = global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipher.GetNonceMode(this.m_isTlsV13, aeadType);
			int nonceMode = this.m_nonceMode;
			if (nonceMode != 1)
			{
				if (nonceMode != 2)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				this.m_fixed_iv_length = 12;
				this.m_record_iv_length = 0;
			}
			else
			{
				this.m_fixed_iv_length = 4;
				this.m_record_iv_length = 8;
			}
			this.m_cryptoParams = cryptoParams;
			this.m_keySize = keySize;
			this.m_macSize = macSize;
			this.m_decryptCipher = decryptCipher;
			this.m_encryptCipher = encryptCipher;
			this.m_decryptNonce = new byte[this.m_fixed_iv_length];
			this.m_encryptNonce = new byte[this.m_fixed_iv_length];
			bool isServer = cryptoParams.IsServer;
			if (this.m_isTlsV13)
			{
				this.RekeyCipher(securityParameters, decryptCipher, this.m_decryptNonce, !isServer);
				this.RekeyCipher(securityParameters, encryptCipher, this.m_encryptNonce, isServer);
				return;
			}
			int keyBlockSize = 2 * keySize + 2 * this.m_fixed_iv_length;
			byte[] keyBlock = global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.CalculateKeyBlock(cryptoParams, keyBlockSize);
			int pos = 0;
			if (isServer)
			{
				decryptCipher.SetKey(keyBlock, pos, keySize);
				pos += keySize;
				encryptCipher.SetKey(keyBlock, pos, keySize);
				pos += keySize;
				global::System.Array.Copy(keyBlock, pos, this.m_decryptNonce, 0, this.m_fixed_iv_length);
				pos += this.m_fixed_iv_length;
				global::System.Array.Copy(keyBlock, pos, this.m_encryptNonce, 0, this.m_fixed_iv_length);
				pos += this.m_fixed_iv_length;
			}
			else
			{
				encryptCipher.SetKey(keyBlock, pos, keySize);
				pos += keySize;
				decryptCipher.SetKey(keyBlock, pos, keySize);
				pos += keySize;
				global::System.Array.Copy(keyBlock, pos, this.m_encryptNonce, 0, this.m_fixed_iv_length);
				pos += this.m_fixed_iv_length;
				global::System.Array.Copy(keyBlock, pos, this.m_decryptNonce, 0, this.m_fixed_iv_length);
				pos += this.m_fixed_iv_length;
			}
			if (keyBlockSize != pos)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			byte[] dummyNonce = new byte[this.m_fixed_iv_length + this.m_record_iv_length];
			dummyNonce[0] = ~this.m_encryptNonce[0];
			dummyNonce[1] = ~this.m_decryptNonce[1];
			encryptCipher.Init(dummyNonce, macSize, null);
			decryptCipher.Init(dummyNonce, macSize, null);
		}

		// Token: 0x06000D99 RID: 3481 RVA: 0x00032D2B File Offset: 0x00030F2B
		public virtual int GetCiphertextDecodeLimit(int plaintextLimit)
		{
			return plaintextLimit + this.m_macSize + this.m_record_iv_length + (this.m_isTlsV13 ? 1 : 0);
		}

		// Token: 0x06000D9A RID: 3482 RVA: 0x00032D4C File Offset: 0x00030F4C
		public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
		{
			int innerPlaintextLimit = plaintextLength;
			if (this.m_isTlsV13)
			{
				int maxPadding = 0;
				innerPlaintextLimit = 1 + global::System.Math.Min(plaintextLimit, plaintextLength + maxPadding);
			}
			return innerPlaintextLimit + this.m_macSize + this.m_record_iv_length;
		}

		// Token: 0x06000D9B RID: 3483 RVA: 0x00032D80 File Offset: 0x00030F80
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return ciphertextLimit - this.m_macSize - this.m_record_iv_length - (this.m_isTlsV13 ? 1 : 0);
		}

		// Token: 0x06000D9C RID: 3484 RVA: 0x00032DA0 File Offset: 0x00030FA0
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult EncodePlaintext(long seqNo, short contentType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int plaintextOffset, int plaintextLength)
		{
			byte[] nonce = new byte[this.m_encryptNonce.Length + this.m_record_iv_length];
			int nonceMode = this.m_nonceMode;
			if (nonceMode != 1)
			{
				if (nonceMode != 2)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint64(seqNo, nonce, nonce.Length - 8);
				for (int i = 0; i < this.m_encryptNonce.Length; i++)
				{
					byte[] array = nonce;
					int num = i;
					array[num] ^= this.m_encryptNonce[i];
				}
			}
			else
			{
				global::System.Array.Copy(this.m_encryptNonce, 0, nonce, 0, this.m_encryptNonce.Length);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint64(seqNo, nonce, this.m_encryptNonce.Length);
			}
			int extraLength = this.m_isTlsV13 ? 1 : 0;
			int encryptionLength = this.m_encryptCipher.GetOutputSize(plaintextLength + extraLength);
			int ciphertextLength = this.m_record_iv_length + encryptionLength;
			byte[] output = new byte[headerAllocation + ciphertextLength];
			int outputPos = headerAllocation;
			if (this.m_record_iv_length != 0)
			{
				global::System.Array.Copy(nonce, nonce.Length - this.m_record_iv_length, output, outputPos, this.m_record_iv_length);
				outputPos += this.m_record_iv_length;
			}
			short recordType = this.m_isTlsV13 ? 23 : contentType;
			byte[] additionalData = this.GetAdditionalData(seqNo, recordType, recordVersion, ciphertextLength, plaintextLength);
			try
			{
				this.m_encryptCipher.Init(nonce, this.m_macSize, additionalData);
				global::System.Array.Copy(plaintext, plaintextOffset, output, outputPos, plaintextLength);
				if (this.m_isTlsV13)
				{
					output[outputPos + plaintextLength] = (byte)contentType;
				}
				outputPos += this.m_encryptCipher.DoFinal(output, outputPos, plaintextLength + extraLength, output, outputPos);
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80, e);
			}
			if (outputPos != output.Length)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return new global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult(output, 0, output.Length, recordType);
		}

		// Token: 0x06000D9D RID: 3485 RVA: 0x00032F5C File Offset: 0x0003115C
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, byte[] ciphertext, int ciphertextOffset, int ciphertextLength)
		{
			if (this.GetPlaintextLimit(ciphertextLength) < 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			byte[] nonce = new byte[this.m_decryptNonce.Length + this.m_record_iv_length];
			int nonceMode = this.m_nonceMode;
			if (nonceMode != 1)
			{
				if (nonceMode != 2)
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
				}
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint64(seqNo, nonce, nonce.Length - 8);
				for (int i = 0; i < this.m_decryptNonce.Length; i++)
				{
					byte[] array = nonce;
					int num = i;
					array[num] ^= this.m_decryptNonce[i];
				}
			}
			else
			{
				global::System.Array.Copy(this.m_decryptNonce, 0, nonce, 0, this.m_decryptNonce.Length);
				global::System.Array.Copy(ciphertext, ciphertextOffset, nonce, nonce.Length - this.m_record_iv_length, this.m_record_iv_length);
			}
			int encryptionOffset = ciphertextOffset + this.m_record_iv_length;
			int encryptionLength = ciphertextLength - this.m_record_iv_length;
			int plaintextLength = this.m_decryptCipher.GetOutputSize(encryptionLength);
			byte[] additionalData = this.GetAdditionalData(seqNo, recordType, recordVersion, ciphertextLength, plaintextLength);
			int outputPos;
			try
			{
				this.m_decryptCipher.Init(nonce, this.m_macSize, additionalData);
				outputPos = this.m_decryptCipher.DoFinal(ciphertext, encryptionOffset, encryptionLength, ciphertext, encryptionOffset);
			}
			catch (global::System.IO.IOException ex)
			{
				throw ex;
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(20, e);
			}
			if (outputPos != plaintextLength)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			short contentType = recordType;
			if (this.m_isTlsV13)
			{
				int pos = plaintextLength;
				while (--pos >= 0)
				{
					byte octet = ciphertext[encryptionOffset + pos];
					if (octet != 0)
					{
						contentType = (short)(octet & byte.MaxValue);
						plaintextLength = pos;
						goto IL_15F;
					}
				}
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(10);
			}
			IL_15F:
			return new global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult(ciphertext, encryptionOffset, plaintextLength, contentType);
		}

		// Token: 0x06000D9E RID: 3486 RVA: 0x000330F0 File Offset: 0x000312F0
		public virtual void RekeyDecoder()
		{
			this.RekeyCipher(this.m_cryptoParams.SecurityParameters, this.m_decryptCipher, this.m_decryptNonce, !this.m_cryptoParams.IsServer);
		}

		// Token: 0x06000D9F RID: 3487 RVA: 0x0003311D File Offset: 0x0003131D
		public virtual void RekeyEncoder()
		{
			this.RekeyCipher(this.m_cryptoParams.SecurityParameters, this.m_encryptCipher, this.m_encryptNonce, this.m_cryptoParams.IsServer);
		}

		// Token: 0x170001FB RID: 507
		// (get) Token: 0x06000DA0 RID: 3488 RVA: 0x00033147 File Offset: 0x00031347
		public virtual bool UsesOpaqueRecordType
		{
			get
			{
				return this.m_isTlsV13;
			}
		}

		// Token: 0x06000DA1 RID: 3489 RVA: 0x00033150 File Offset: 0x00031350
		protected virtual byte[] GetAdditionalData(long seqNo, short recordType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, int ciphertextLength, int plaintextLength)
		{
			if (this.m_isTlsV13)
			{
				byte[] additional_data = new byte[5];
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(recordType, additional_data, 0);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(recordVersion, additional_data, 1);
				global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(ciphertextLength, additional_data, 3);
				return additional_data;
			}
			byte[] additional_data2 = new byte[13];
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint64(seqNo, additional_data2, 0);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint8(recordType, additional_data2, 8);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteVersion(recordVersion, additional_data2, 9);
			global::Org.BouncyCastle.Tls.TlsUtilities.WriteUint16(plaintextLength, additional_data2, 11);
			return additional_data2;
		}

		// Token: 0x06000DA2 RID: 3490 RVA: 0x000331B4 File Offset: 0x000313B4
		protected virtual void RekeyCipher(global::Org.BouncyCastle.Tls.SecurityParameters securityParameters, global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipherImpl cipher, byte[] nonce, bool serverSecret)
		{
			if (!this.m_isTlsV13)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret = serverSecret ? securityParameters.TrafficSecretServer : securityParameters.TrafficSecretClient;
			if (secret == null)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.Setup13Cipher(cipher, nonce, secret, securityParameters.PrfCryptoHashAlgorithm);
		}

		// Token: 0x06000DA3 RID: 3491 RVA: 0x00033200 File Offset: 0x00031400
		protected virtual void Setup13Cipher(global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipherImpl cipher, byte[] nonce, global::Org.BouncyCastle.Tls.Crypto.TlsSecret secret, int cryptoHashAlgorithm)
		{
			byte[] key = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.HkdfExpandLabel(secret, cryptoHashAlgorithm, "key", global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, this.m_keySize).Extract();
			byte[] iv = global::Org.BouncyCastle.Tls.Crypto.TlsCryptoUtilities.HkdfExpandLabel(secret, cryptoHashAlgorithm, "iv", global::Org.BouncyCastle.Tls.TlsUtilities.EmptyBytes, this.m_fixed_iv_length).Extract();
			cipher.SetKey(key, 0, this.m_keySize);
			global::System.Array.Copy(iv, 0, nonce, 0, this.m_fixed_iv_length);
			byte[] array = iv;
			int num = 0;
			array[num] ^= 128;
			cipher.Init(iv, this.m_macSize, null);
		}

		// Token: 0x06000DA4 RID: 3492 RVA: 0x00033285 File Offset: 0x00031485
		private static int GetNonceMode(bool isTLSv13, int aeadType)
		{
			switch (aeadType)
			{
			case 1:
			case 3:
				if (!isTLSv13)
				{
					return 1;
				}
				return 2;
			case 2:
				return 2;
			default:
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
		}

		// Token: 0x040007DD RID: 2013
		public const int AEAD_CCM = 1;

		// Token: 0x040007DE RID: 2014
		public const int AEAD_CHACHA20_POLY1305 = 2;

		// Token: 0x040007DF RID: 2015
		public const int AEAD_GCM = 3;

		// Token: 0x040007E0 RID: 2016
		private const int NONCE_RFC5288 = 1;

		// Token: 0x040007E1 RID: 2017
		private const int NONCE_RFC7905 = 2;

		// Token: 0x040007E2 RID: 2018
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters m_cryptoParams;

		// Token: 0x040007E3 RID: 2019
		protected readonly int m_keySize;

		// Token: 0x040007E4 RID: 2020
		protected readonly int m_macSize;

		// Token: 0x040007E5 RID: 2021
		protected readonly int m_fixed_iv_length;

		// Token: 0x040007E6 RID: 2022
		protected readonly int m_record_iv_length;

		// Token: 0x040007E7 RID: 2023
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipherImpl m_decryptCipher;

		// Token: 0x040007E8 RID: 2024
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.TlsAeadCipherImpl m_encryptCipher;

		// Token: 0x040007E9 RID: 2025
		protected readonly byte[] m_decryptNonce;

		// Token: 0x040007EA RID: 2026
		protected readonly byte[] m_encryptNonce;

		// Token: 0x040007EB RID: 2027
		protected readonly bool m_isTlsV13;

		// Token: 0x040007EC RID: 2028
		protected readonly int m_nonceMode;
	}
}
