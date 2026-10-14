using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Crypto.Tls
{
	// Token: 0x02000358 RID: 856
	public class TlsBlockCipher : global::Org.BouncyCastle.Crypto.Tls.TlsCipher
	{
		// Token: 0x170004D4 RID: 1236
		// (get) Token: 0x060022F3 RID: 8947 RVA: 0x00099546 File Offset: 0x00097746
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsMac WriteMac
		{
			get
			{
				return this.mWriteMac;
			}
		}

		// Token: 0x170004D5 RID: 1237
		// (get) Token: 0x060022F4 RID: 8948 RVA: 0x0009954E File Offset: 0x0009774E
		public virtual global::Org.BouncyCastle.Crypto.Tls.TlsMac ReadMac
		{
			get
			{
				return this.mReadMac;
			}
		}

		// Token: 0x060022F5 RID: 8949 RVA: 0x00099558 File Offset: 0x00097758
		public TlsBlockCipher(global::Org.BouncyCastle.Crypto.Tls.TlsContext context, global::Org.BouncyCastle.Crypto.IBlockCipher clientWriteCipher, global::Org.BouncyCastle.Crypto.IBlockCipher serverWriteCipher, global::Org.BouncyCastle.Crypto.IDigest clientWriteDigest, global::Org.BouncyCastle.Crypto.IDigest serverWriteDigest, int cipherKeySize)
		{
			this.context = context;
			this.randomData = new byte[256];
			context.NonceRandomGenerator.NextBytes(this.randomData);
			this.useExplicitIV = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsTlsV11(context);
			this.encryptThenMac = context.SecurityParameters.encryptThenMac;
			int key_block_size = 2 * cipherKeySize + clientWriteDigest.GetDigestSize() + serverWriteDigest.GetDigestSize();
			if (!this.useExplicitIV)
			{
				key_block_size += clientWriteCipher.GetBlockSize() + serverWriteCipher.GetBlockSize();
			}
			byte[] key_block = global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.CalculateKeyBlock(context, key_block_size);
			int offset = 0;
			global::Org.BouncyCastle.Crypto.Tls.TlsMac clientWriteMac = new global::Org.BouncyCastle.Crypto.Tls.TlsMac(context, clientWriteDigest, key_block, offset, clientWriteDigest.GetDigestSize());
			offset += clientWriteDigest.GetDigestSize();
			global::Org.BouncyCastle.Crypto.Tls.TlsMac serverWriteMac = new global::Org.BouncyCastle.Crypto.Tls.TlsMac(context, serverWriteDigest, key_block, offset, serverWriteDigest.GetDigestSize());
			offset += serverWriteDigest.GetDigestSize();
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter client_write_key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key_block, offset, cipherKeySize);
			offset += cipherKeySize;
			global::Org.BouncyCastle.Crypto.Parameters.KeyParameter server_write_key = new global::Org.BouncyCastle.Crypto.Parameters.KeyParameter(key_block, offset, cipherKeySize);
			offset += cipherKeySize;
			byte[] client_write_IV;
			byte[] server_write_IV;
			if (this.useExplicitIV)
			{
				client_write_IV = new byte[clientWriteCipher.GetBlockSize()];
				server_write_IV = new byte[serverWriteCipher.GetBlockSize()];
			}
			else
			{
				client_write_IV = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(key_block, offset, offset + clientWriteCipher.GetBlockSize());
				offset += clientWriteCipher.GetBlockSize();
				server_write_IV = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(key_block, offset, offset + serverWriteCipher.GetBlockSize());
				offset += serverWriteCipher.GetBlockSize();
			}
			if (offset != key_block_size)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(80);
			}
			global::Org.BouncyCastle.Crypto.ICipherParameters encryptParams;
			global::Org.BouncyCastle.Crypto.ICipherParameters decryptParams;
			if (context.IsServer)
			{
				this.mWriteMac = serverWriteMac;
				this.mReadMac = clientWriteMac;
				this.encryptCipher = serverWriteCipher;
				this.decryptCipher = clientWriteCipher;
				encryptParams = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(server_write_key, server_write_IV);
				decryptParams = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(client_write_key, client_write_IV);
			}
			else
			{
				this.mWriteMac = clientWriteMac;
				this.mReadMac = serverWriteMac;
				this.encryptCipher = clientWriteCipher;
				this.decryptCipher = serverWriteCipher;
				encryptParams = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(client_write_key, client_write_IV);
				decryptParams = new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(server_write_key, server_write_IV);
			}
			this.encryptCipher.Init(true, encryptParams);
			this.decryptCipher.Init(false, decryptParams);
		}

		// Token: 0x060022F6 RID: 8950 RVA: 0x00099730 File Offset: 0x00097930
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			int blockSize = this.encryptCipher.GetBlockSize();
			int macSize = this.mWriteMac.Size;
			int plaintextLimit = ciphertextLimit;
			if (this.useExplicitIV)
			{
				plaintextLimit -= blockSize;
			}
			if (this.encryptThenMac)
			{
				plaintextLimit -= macSize;
				plaintextLimit -= plaintextLimit % blockSize;
			}
			else
			{
				plaintextLimit -= plaintextLimit % blockSize;
				plaintextLimit -= macSize;
			}
			return plaintextLimit - 1;
		}

		// Token: 0x060022F7 RID: 8951 RVA: 0x00099788 File Offset: 0x00097988
		public virtual byte[] EncodePlaintext(long seqNo, byte type, byte[] plaintext, int offset, int len)
		{
			int blockSize = this.encryptCipher.GetBlockSize();
			int macSize = this.mWriteMac.Size;
			global::Org.BouncyCastle.Crypto.Tls.ProtocolVersion version = this.context.ServerVersion;
			int enc_input_length = len;
			if (!this.encryptThenMac)
			{
				enc_input_length += macSize;
			}
			int padding_length = blockSize - 1 - enc_input_length % blockSize;
			if ((this.encryptThenMac || !this.context.SecurityParameters.truncatedHMac) && !version.IsDtls && !version.IsSsl)
			{
				int maxExtraPadBlocks = (255 - padding_length) / blockSize;
				int actualExtraPadBlocks = this.ChooseExtraPadBlocks(this.context.SecureRandom, maxExtraPadBlocks);
				padding_length += actualExtraPadBlocks * blockSize;
			}
			int totalSize = len + macSize + padding_length + 1;
			if (this.useExplicitIV)
			{
				totalSize += blockSize;
			}
			byte[] outBuf = new byte[totalSize];
			int outOff = 0;
			if (this.useExplicitIV)
			{
				byte[] explicitIV = new byte[blockSize];
				this.context.NonceRandomGenerator.NextBytes(explicitIV);
				this.encryptCipher.Init(true, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(null, explicitIV));
				global::System.Array.Copy(explicitIV, 0, outBuf, outOff, blockSize);
				outOff += blockSize;
			}
			int blocks_start = outOff;
			global::System.Array.Copy(plaintext, offset, outBuf, outOff, len);
			outOff += len;
			if (!this.encryptThenMac)
			{
				byte[] mac = this.mWriteMac.CalculateMac(seqNo, type, plaintext, offset, len);
				global::System.Array.Copy(mac, 0, outBuf, outOff, mac.Length);
				outOff += mac.Length;
			}
			for (int i = 0; i <= padding_length; i++)
			{
				outBuf[outOff++] = (byte)padding_length;
			}
			for (int j = blocks_start; j < outOff; j += blockSize)
			{
				this.encryptCipher.ProcessBlock(outBuf, j, outBuf, j);
			}
			if (this.encryptThenMac)
			{
				byte[] mac2 = this.mWriteMac.CalculateMac(seqNo, type, outBuf, 0, outOff);
				global::System.Array.Copy(mac2, 0, outBuf, outOff, mac2.Length);
				outOff += mac2.Length;
			}
			return outBuf;
		}

		// Token: 0x060022F8 RID: 8952 RVA: 0x0009995C File Offset: 0x00097B5C
		public virtual byte[] DecodeCiphertext(long seqNo, byte type, byte[] ciphertext, int offset, int len)
		{
			int blockSize = this.decryptCipher.GetBlockSize();
			int macSize = this.mReadMac.Size;
			int minLen = blockSize;
			if (this.encryptThenMac)
			{
				minLen += macSize;
			}
			else
			{
				minLen = global::System.Math.Max(minLen, macSize + 1);
			}
			if (this.useExplicitIV)
			{
				minLen += blockSize;
			}
			if (len < minLen)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(50);
			}
			int blocks_length = len;
			if (this.encryptThenMac)
			{
				blocks_length -= macSize;
			}
			if (blocks_length % blockSize != 0)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(21);
			}
			if (this.encryptThenMac)
			{
				int end = offset + len;
				byte[] receivedMac = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(ciphertext, end - macSize, end);
				if (!global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(this.mReadMac.CalculateMac(seqNo, type, ciphertext, offset, len - macSize), receivedMac))
				{
					throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(20);
				}
			}
			if (this.useExplicitIV)
			{
				this.decryptCipher.Init(false, new global::Org.BouncyCastle.Crypto.Parameters.ParametersWithIV(null, ciphertext, offset, blockSize));
				offset += blockSize;
				blocks_length -= blockSize;
			}
			for (int i = 0; i < blocks_length; i += blockSize)
			{
				this.decryptCipher.ProcessBlock(ciphertext, offset + i, ciphertext, offset + i);
			}
			int totalPad = this.CheckPaddingConstantTime(ciphertext, offset, blocks_length, blockSize, this.encryptThenMac ? 0 : macSize);
			bool badMac = totalPad == 0;
			int dec_output_length = blocks_length - totalPad;
			if (!this.encryptThenMac)
			{
				dec_output_length -= macSize;
				int macInputLen = dec_output_length;
				int macOff = offset + macInputLen;
				byte[] receivedMac2 = global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(ciphertext, macOff, macOff + macSize);
				byte[] calculatedMac = this.mReadMac.CalculateMacConstantTime(seqNo, type, ciphertext, offset, macInputLen, blocks_length - macSize, this.randomData);
				badMac |= !global::Org.BouncyCastle.Utilities.Arrays.ConstantTimeAreEqual(calculatedMac, receivedMac2);
			}
			if (badMac)
			{
				throw new global::Org.BouncyCastle.Crypto.Tls.TlsFatalAlert(20);
			}
			return global::Org.BouncyCastle.Utilities.Arrays.CopyOfRange(ciphertext, offset, offset + dec_output_length);
		}

		// Token: 0x060022F9 RID: 8953 RVA: 0x00099AFC File Offset: 0x00097CFC
		protected virtual int CheckPaddingConstantTime(byte[] buf, int off, int len, int blockSize, int macSize)
		{
			int end = off + len;
			byte lastByte = buf[end - 1];
			int totalPad = (int)((lastByte & byte.MaxValue) + 1);
			int dummyIndex = 0;
			byte padDiff = 0;
			if ((global::Org.BouncyCastle.Crypto.Tls.TlsUtilities.IsSsl(this.context) && totalPad > blockSize) || macSize + totalPad > len)
			{
				totalPad = 0;
			}
			else
			{
				int padPos = end - totalPad;
				do
				{
					padDiff |= (buf[padPos++] ^ lastByte);
				}
				while (padPos < end);
				dummyIndex = totalPad;
				if (padDiff != 0)
				{
					totalPad = 0;
				}
			}
			byte[] dummyPad = this.randomData;
			while (dummyIndex < 256)
			{
				padDiff |= (dummyPad[dummyIndex++] ^ lastByte);
			}
			byte[] array = dummyPad;
			int num = 0;
			array[num] ^= padDiff;
			return totalPad;
		}

		// Token: 0x060022FA RID: 8954 RVA: 0x00099B98 File Offset: 0x00097D98
		protected virtual int ChooseExtraPadBlocks(global::Org.BouncyCastle.Security.SecureRandom r, int max)
		{
			int x = r.NextInt();
			return global::System.Math.Min(this.LowestBitSet(x), max);
		}

		// Token: 0x060022FB RID: 8955 RVA: 0x00099BBC File Offset: 0x00097DBC
		protected virtual int LowestBitSet(int x)
		{
			if (x == 0)
			{
				return 32;
			}
			uint ux = (uint)x;
			int i = 0;
			while ((ux & 1U) == 0U)
			{
				i++;
				ux >>= 1;
			}
			return i;
		}

		// Token: 0x04000E3A RID: 3642
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsContext context;

		// Token: 0x04000E3B RID: 3643
		protected readonly byte[] randomData;

		// Token: 0x04000E3C RID: 3644
		protected readonly bool useExplicitIV;

		// Token: 0x04000E3D RID: 3645
		protected readonly bool encryptThenMac;

		// Token: 0x04000E3E RID: 3646
		protected readonly global::Org.BouncyCastle.Crypto.IBlockCipher encryptCipher;

		// Token: 0x04000E3F RID: 3647
		protected readonly global::Org.BouncyCastle.Crypto.IBlockCipher decryptCipher;

		// Token: 0x04000E40 RID: 3648
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsMac mWriteMac;

		// Token: 0x04000E41 RID: 3649
		protected readonly global::Org.BouncyCastle.Crypto.Tls.TlsMac mReadMac;
	}
}
