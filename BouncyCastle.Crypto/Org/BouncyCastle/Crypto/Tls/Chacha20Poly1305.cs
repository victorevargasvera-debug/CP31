using System;
using Org.BouncyCastle.Crypto.Engines;
using Org.BouncyCastle.Crypto.Macs;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x0200030B RID: 779
	public class Chacha20Poly1305 : global::Org.BouncyCastle.Crypto.Tls.TlsCipher
	{
		// Token: 0x06002119 RID: 8473 RVA: 0x00092BC8 File Offset: 0x00090DC8
		public Chacha20Poly1305(global::Org.BouncyCastle.Crypto.Tls.TlsContext context)
		{
			if (!global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV12(context))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			this.context = context;
			int cipherKeySize = 32;
			int fixed_iv_length = 12;
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
			this.encryptCipher = new global::Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine();
			this.decryptCipher = new global::Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine();
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter encryptKey;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter decryptKey;
			if (context.IsServer)
			{
				encryptKey = server_write_key;
				decryptKey = client_write_key;
				this.encryptIV = server_write_IV;
				this.decryptIV = client_write_IV;
			}
			else
			{
				encryptKey = client_write_key;
				decryptKey = server_write_key;
				this.encryptIV = client_write_IV;
				this.decryptIV = server_write_IV;
			}
			this.encryptCipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(encryptKey, this.encryptIV));
			this.decryptCipher.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(decryptKey, this.decryptIV));
		}

		// Token: 0x0600211A RID: 8474 RVA: 0x00092CD2 File Offset: 0x00090ED2
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return ciphertextLimit - 16;
		}

		// Token: 0x0600211B RID: 8475 RVA: 0x00092CD8 File Offset: 0x00090ED8
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter macKey = this.InitRecord(this.encryptCipher, true, seqNo, this.encryptIV);
			byte[] output = new byte[len + 16];
			this.encryptCipher.ProcessBytes(plaintext, offset, len, output, 0);
			byte[] additionalData = this.GetAdditionalData(seqNo, type, len);
			byte[] mac = this.CalculateRecordMac(macKey, additionalData, output, 0, len);
			global::System.Array.Copy(mac, 0, output, len, mac.Length);
			return output;
		}

		// Token: 0x0600211C RID: 8476 RVA: 0x00092D40 File Offset: 0x00090F40
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			if (this.GetPlaintextLimit(len) < 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter macKey = this.InitRecord(this.decryptCipher, false, seqNo, this.decryptIV);
			int plaintextLength = len - 16;
			byte[] additionalData = this.GetAdditionalData(seqNo, type, plaintextLength);
			byte[] a = this.CalculateRecordMac(macKey, additionalData, ciphertext, offset, plaintextLength);
			byte[] receivedMac = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(ciphertext, offset + plaintextLength, offset + len);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a, receivedMac))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(20);
			}
			byte[] output = new byte[plaintextLength];
			this.decryptCipher.ProcessBytes(ciphertext, offset, plaintextLength, output, 0);
			return output;
		}

		// Token: 0x0600211D RID: 8477 RVA: 0x00092DD0 File Offset: 0x00090FD0
		protected virtual global::Org.BouncyCastle.Crypto.Parameters.KeyParameter InitRecord(global::Org.BouncyCastle.Crypto.IStreamCipher cipher, bool forEncryption, long seqNo, byte[] iv)
		{
			byte[] nonce = this.CalculateNonce(seqNo, iv);
			cipher.Init(forEncryption, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(null, nonce));
			return this.GenerateRecordMacKey(cipher);
		}

		// Token: 0x0600211E RID: 8478 RVA: 0x00092DFC File Offset: 0x00090FFC
		protected virtual byte[] CalculateNonce(long seqNo, byte[] iv)
		{
			byte[] nonce = new byte[12];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(seqNo, nonce, 4);
			for (int i = 0; i < 12; i++)
			{
				byte[] array = nonce;
				int num = i;
				array[num] ^= iv[i];
			}
			return nonce;
		}

		// Token: 0x0600211F RID: 8479 RVA: 0x00092E38 File Offset: 0x00091038
		protected virtual global::Org.BouncyCastle.Crypto.Parameters.KeyParameter GenerateRecordMacKey(global::Org.BouncyCastle.Crypto.IStreamCipher cipher)
		{
			byte[] firstBlock = new byte[64];
			cipher.ProcessBytes(firstBlock, 0, firstBlock.Length, firstBlock, 0);
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter result = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(firstBlock, 0, 32);
			global::Org.BouncyCastle.Utilities.Arrays.Fill(firstBlock, 0);
			return result;
		}

		// Token: 0x06002120 RID: 8480 RVA: 0x00092E6C File Offset: 0x0009106C
		protected virtual byte[] CalculateRecordMac(global::Org.BouncyCastle.Crypto.Parameters.KeyParameter macKey, byte[] additionalData, byte[] buf, int off, int len)
		{
			global::Org.BouncyCastle.Crypto.IMac mac = new global::Org.BouncyCastle.Crypto.Macs.Poly1305();
			mac.Init(macKey);
			this.UpdateRecordMacText(mac, additionalData, 0, additionalData.Length);
			this.UpdateRecordMacText(mac, buf, off, len);
			this.UpdateRecordMacLength(mac, additionalData.Length);
			this.UpdateRecordMacLength(mac, len);
			return global::Org.BouncyCastle.Security.MacUtilities.DoFinal(mac);
		}

		// Token: 0x06002121 RID: 8481 RVA: 0x00092EB8 File Offset: 0x000910B8
		protected virtual void UpdateRecordMacLength(global::Org.BouncyCastle.Crypto.IMac mac, int len)
		{
			byte[] longLen = global::Org.BouncyCastle.Crypto.Utilities.Pack.UInt64_To_LE((ulong)((long)len));
			mac.BlockUpdate(longLen, 0, longLen.Length);
		}

		// Token: 0x06002122 RID: 8482 RVA: 0x00092ED8 File Offset: 0x000910D8
		protected virtual void UpdateRecordMacText(global::Org.BouncyCastle.Crypto.IMac mac, byte[] buf, int off, int len)
		{
			mac.BlockUpdate(buf, off, len);
			int partial = len % 16;
			if (partial != 0)
			{
				mac.BlockUpdate(global::Org.BouncyCastle.Crypto.Tls.Chacha20Poly1305.Zeroes, 0, 16 - partial);
			}
		}

		// Token: 0x06002123 RID: 8483 RVA: 0x00092F08 File Offset: 0x00091108
		protected virtual byte[] GetAdditionalData(long seqNo, byte type, int len)
		{
			byte[] additional_data = new byte[13];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(seqNo, additional_data, 0);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint8(type, additional_data, 8);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteVersion(this.context.ServerVersion, additional_data, 9);
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint16(len, additional_data, 11);
			return additional_data;
		}

		// Token: 0x04000BA6 RID: 2982
		private static readonly byte[] Zeroes = new byte[15];

		// Token: 0x04000BA7 RID: 2983
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsContext context;

		// Token: 0x04000BA8 RID: 2984
		protected readonly global::Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine encryptCipher;

		// Token: 0x04000BA9 RID: 2985
		protected readonly global::Org.BouncyCastle.Crypto.Engines.ChaCha7539Engine decryptCipher;

		// Token: 0x04000BAA RID: 2986
		protected readonly byte[] encryptIV;

		// Token: 0x04000BAB RID: 2987
		protected readonly byte[] decryptIV;
	}
}
