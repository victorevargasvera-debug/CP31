using System;
using Org.BouncyCastle.Crypto.Modes;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000355 RID: 853
	public class TlsAeadCipher : global::Org.BouncyCastle.Crypto.Tls.TlsCipher
	{
		// Token: 0x060022EA RID: 8938 RVA: 0x0009908C File Offset: 0x0009728C
		public TlsAeadCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher clientWriteCipher, global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher serverWriteCipher, int cipherKeySize, int macSize) : this(context, clientWriteCipher, serverWriteCipher, cipherKeySize, macSize, 1)
		{
		}

		// Token: 0x060022EB RID: 8939 RVA: 0x0009909C File Offset: 0x0009729C
		internal TlsAeadCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher clientWriteCipher, global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher serverWriteCipher, int cipherKeySize, int macSize, int nonceMode)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.nonceMode = nonceMode;
			int fixed_iv_length;
			if (nonceMode != 1)
			{
				if (nonceMode != 2)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				fixed_iv_length = 12;
				this.record_iv_length = 0;
			}
			else
			{
				fixed_iv_length = 4;
				this.record_iv_length = 8;
			}
			this.context = context;
			this.macSize = macSize;
			int key_block_size = 2 * cipherKeySize + 2 * fixed_iv_length;
			byte[] array = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock(context, key_block_size);
			int offset = 0;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter client_write_key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(array, offset, cipherKeySize);
			offset += cipherKeySize;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter server_write_key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(array, offset, cipherKeySize);
			offset += cipherKeySize;
			byte[] client_write_IV = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(array, offset, offset + fixed_iv_length);
			offset += fixed_iv_length;
			byte[] server_write_IV = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(array, offset, offset + fixed_iv_length);
			offset += fixed_iv_length;
			if (offset != key_block_size)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encryptKey;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter decryptKey;
			if (context.IsServer)
			{
				this.encryptCipher = serverWriteCipher;
				this.decryptCipher = clientWriteCipher;
				this.encryptImplicitNonce = server_write_IV;
				this.decryptImplicitNonce = client_write_IV;
				encryptKey = server_write_key;
				decryptKey = client_write_key;
			}
			else
			{
				this.encryptCipher = clientWriteCipher;
				this.decryptCipher = serverWriteCipher;
				this.encryptImplicitNonce = client_write_IV;
				this.decryptImplicitNonce = server_write_IV;
				encryptKey = client_write_key;
				decryptKey = server_write_key;
			}
			byte[] dummyNonce = new byte[fixed_iv_length + this.record_iv_length];
			dummyNonce[0] = ~this.encryptImplicitNonce[0];
			dummyNonce[1] = ~this.decryptImplicitNonce[1];
			this.encryptCipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.AeadParameters(encryptKey, 8 * macSize, dummyNonce));
			this.decryptCipher.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.AeadParameters(decryptKey, 8 * macSize, dummyNonce));
		}

		// Token: 0x060022EC RID: 8940 RVA: 0x0009920E File Offset: 0x0009740E
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return ciphertextLimit - this.macSize - this.record_iv_length;
		}

		// Token: 0x060022ED RID: 8941 RVA: 0x00099220 File Offset: 0x00097420
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			byte[] nonce = new byte[this.encryptImplicitNonce.Length + this.record_iv_length];
			int num = this.nonceMode;
			if (num != 1)
			{
				if (num != 2)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(seqNo, nonce, nonce.Length - 8);
				for (int i = 0; i < this.encryptImplicitNonce.Length; i++)
				{
					byte[] array = nonce;
					int num2 = i;
					array[num2] ^= this.encryptImplicitNonce[i];
				}
			}
			else
			{
				global::System.Array.Copy(this.encryptImplicitNonce, 0, nonce, 0, this.encryptImplicitNonce.Length);
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(seqNo, nonce, this.encryptImplicitNonce.Length);
			}
			int ciphertextLength = this.encryptCipher.GetOutputSize(len);
			byte[] output = new byte[this.record_iv_length + ciphertextLength];
			if (this.record_iv_length != 0)
			{
				global::System.Array.Copy(nonce, nonce.Length - this.record_iv_length, output, 0, this.record_iv_length);
			}
			int outputPos = this.record_iv_length;
			byte[] additionalData = this.GetAdditionalData(seqNo, type, len);
			global::Org.BouncyCastle.Crypto.Parameters.AeadParameters parameters = new global::Org.BouncyCastle.Crypto.Parameters.AeadParameters(null, 8 * this.macSize, nonce, additionalData);
			try
			{
				this.encryptCipher.Init(true, parameters);
				outputPos += this.encryptCipher.ProcessBytes(plaintext, offset, len, output, outputPos);
				outputPos += this.encryptCipher.DoFinal(output, outputPos);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80, e);
			}
			if (outputPos != output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			return output;
		}

		// Token: 0x060022EE RID: 8942 RVA: 0x00099394 File Offset: 0x00097594
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			if (this.GetPlaintextLimit(len) < 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			byte[] nonce = new byte[this.decryptImplicitNonce.Length + this.record_iv_length];
			int num = this.nonceMode;
			if (num != 1)
			{
				if (num != 2)
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
				}
				global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(seqNo, nonce, nonce.Length - 8);
				for (int i = 0; i < this.decryptImplicitNonce.Length; i++)
				{
					byte[] array = nonce;
					int num2 = i;
					array[num2] ^= this.decryptImplicitNonce[i];
				}
			}
			else
			{
				global::System.Array.Copy(this.decryptImplicitNonce, 0, nonce, 0, this.decryptImplicitNonce.Length);
				global::System.Array.Copy(ciphertext, offset, nonce, nonce.Length - this.record_iv_length, this.record_iv_length);
			}
			int ciphertextOffset = offset + this.record_iv_length;
			int ciphertextLength = len - this.record_iv_length;
			int plaintextLength = this.decryptCipher.GetOutputSize(ciphertextLength);
			byte[] output = new byte[plaintextLength];
			int outputPos = 0;
			byte[] additionalData = this.GetAdditionalData(seqNo, type, plaintextLength);
			global::Org.BouncyCastle.Crypto.Parameters.AeadParameters parameters = new global::Org.BouncyCastle.Crypto.Parameters.AeadParameters(null, 8 * this.macSize, nonce, additionalData);
			try
			{
				this.decryptCipher.Init(false, parameters);
				outputPos += this.decryptCipher.ProcessBytes(ciphertext, ciphertextOffset, ciphertextLength, output, outputPos);
				outputPos += this.decryptCipher.DoFinal(output, outputPos);
			}
			catch (global::System.Exception e)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(20, e);
			}
			if (outputPos != output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			return output;
		}

		// Token: 0x060022EF RID: 8943 RVA: 0x00099504 File Offset: 0x00097704
		protected virtual byte[] GetAdditionalData(long seqNo, byte type, int len)
		{
			byte[] additional_data = new byte[13];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(seqNo, additional_data, 0);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(type, additional_data, 8);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(this.context.ServerVersion, additional_data, 9);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(len, additional_data, 11);
			return additional_data;
		}

		// Token: 0x04000E30 RID: 3632
		public const int NONCE_RFC5288 = 1;

		// Token: 0x04000E31 RID: 3633
		internal const int NONCE_DRAFT_CHACHA20_POLY1305 = 2;

		// Token: 0x04000E32 RID: 3634
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsContext context;

		// Token: 0x04000E33 RID: 3635
		protected readonly int macSize;

		// Token: 0x04000E34 RID: 3636
		protected readonly int record_iv_length;

		// Token: 0x04000E35 RID: 3637
		protected readonly global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher encryptCipher;

		// Token: 0x04000E36 RID: 3638
		protected readonly global::Org.BouncyCastle.Crypto.Modes.IAeadBlockCipher decryptCipher;

		// Token: 0x04000E37 RID: 3639
		protected readonly byte[] encryptImplicitNonce;

		// Token: 0x04000E38 RID: 3640
		protected readonly byte[] decryptImplicitNonce;

		// Token: 0x04000E39 RID: 3641
		protected readonly int nonceMode;
	}
}
