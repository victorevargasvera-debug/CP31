using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000391 RID: 913
	public class TlsStreamCipher : global::Org.BouncyCastle.Crypto.Tls.TlsCipher
	{
		// Token: 0x060024FA RID: 9466 RVA: 0x000A03DC File Offset: 0x0009E5DC
		public TlsStreamCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.IStreamCipher clientWriteCipher, global::Org.BouncyCastle.Crypto.IStreamCipher serverWriteCipher, global::Org.BouncyCastle.Crypto.IDigest clientWriteDigest, global::Org.BouncyCastle.Crypto.IDigest serverWriteDigest, int cipherKeySize, bool usesNonce)
		{
			bool isServer = context.IsServer;
			this.context = context;
			this.usesNonce = usesNonce;
			this.encryptCipher = clientWriteCipher;
			this.decryptCipher = serverWriteCipher;
			int key_block_size = 2 * cipherKeySize + clientWriteDigest.GetDigestSize() + serverWriteDigest.GetDigestSize();
			byte[] key_block = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock(context, key_block_size);
			int offset = 0;
			global::Org.BouncyCastle.Crypto.Tls.TlsMac clientWriteMac = new global::Org.BouncyCastle.Crypto.Tls.TlsMac(context, clientWriteDigest, key_block, offset, clientWriteDigest.GetDigestSize());
			offset += clientWriteDigest.GetDigestSize();
			global::Org.BouncyCastle.Crypto.Tls.TlsMac serverWriteMac = new global::Org.BouncyCastle.Crypto.Tls.TlsMac(context, serverWriteDigest, key_block, offset, serverWriteDigest.GetDigestSize());
			offset += serverWriteDigest.GetDigestSize();
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter clientWriteKey = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key_block, offset, cipherKeySize);
			offset += cipherKeySize;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter serverWriteKey = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key_block, offset, cipherKeySize);
			offset += cipherKeySize;
			if (offset != key_block_size)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.ICipherParameters encryptParams;
			global::Org.BouncyCastle.Crypto.ICipherParameters decryptParams;
			if (isServer)
			{
				this.writeMac = serverWriteMac;
				this.readMac = clientWriteMac;
				this.encryptCipher = serverWriteCipher;
				this.decryptCipher = clientWriteCipher;
				encryptParams = serverWriteKey;
				decryptParams = clientWriteKey;
			}
			else
			{
				this.writeMac = clientWriteMac;
				this.readMac = serverWriteMac;
				this.encryptCipher = clientWriteCipher;
				this.decryptCipher = serverWriteCipher;
				encryptParams = clientWriteKey;
				decryptParams = serverWriteKey;
			}
			if (usesNonce)
			{
				byte[] dummyNonce = new byte[8];
				encryptParams = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(encryptParams, dummyNonce);
				decryptParams = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(decryptParams, dummyNonce);
			}
			this.encryptCipher.Init(true, encryptParams);
			this.decryptCipher.Init(false, decryptParams);
		}

		// Token: 0x060024FB RID: 9467 RVA: 0x000A0522 File Offset: 0x0009E722
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			return ciphertextLimit - this.writeMac.Size;
		}

		// Token: 0x060024FC RID: 9468 RVA: 0x000A0534 File Offset: 0x0009E734
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			if (this.usesNonce)
			{
				this.UpdateIV(this.encryptCipher, true, seqNo);
			}
			byte[] outBuf = new byte[len + this.writeMac.Size];
			this.encryptCipher.ProcessBytes(plaintext, offset, len, outBuf, 0);
			byte[] mac = this.writeMac.CalculateMac(seqNo, type, plaintext, offset, len);
			this.encryptCipher.ProcessBytes(mac, 0, mac.Length, outBuf, len);
			return outBuf;
		}

		// Token: 0x060024FD RID: 9469 RVA: 0x000A05A4 File Offset: 0x0009E7A4
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			if (this.usesNonce)
			{
				this.UpdateIV(this.decryptCipher, false, seqNo);
			}
			int macSize = this.readMac.Size;
			if (len < macSize)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			int plaintextLength = len - macSize;
			byte[] deciphered = new byte[len];
			this.decryptCipher.ProcessBytes(ciphertext, offset, len, deciphered, 0);
			this.CheckMac(seqNo, type, deciphered, plaintextLength, len, deciphered, 0, plaintextLength);
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(deciphered, 0, plaintextLength);
		}

		// Token: 0x060024FE RID: 9470 RVA: 0x000A0618 File Offset: 0x0009E818
		protected virtual void CheckMac(long seqNo, byte type, byte[] recBuf, int recStart, int recEnd, byte[] calcBuf, int calcOff, int calcLen)
		{
			byte[] a = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(recBuf, recStart, recEnd);
			byte[] computedMac = this.readMac.CalculateMac(seqNo, type, calcBuf, calcOff, calcLen);
			if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(a, computedMac))
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(20);
			}
		}

		// Token: 0x060024FF RID: 9471 RVA: 0x000A0654 File Offset: 0x0009E854
		protected virtual void UpdateIV(global::Org.BouncyCastle.Crypto.IStreamCipher cipher, bool forEncryption, long seqNo)
		{
			byte[] nonce = new byte[8];
			global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.WriteUint64(seqNo, nonce, 0);
			cipher.Init(forEncryption, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(null, nonce));
		}

		// Token: 0x04000ED7 RID: 3799
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsContext context;

		// Token: 0x04000ED8 RID: 3800
		protected readonly global::Org.BouncyCastle.Crypto.IStreamCipher encryptCipher;

		// Token: 0x04000ED9 RID: 3801
		protected readonly global::Org.BouncyCastle.Crypto.IStreamCipher decryptCipher;

		// Token: 0x04000EDA RID: 3802
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsMac writeMac;

		// Token: 0x04000EDB RID: 3803
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsMac readMac;

		// Token: 0x04000EDC RID: 3804
		protected readonly bool usesNonce;
	}
}
