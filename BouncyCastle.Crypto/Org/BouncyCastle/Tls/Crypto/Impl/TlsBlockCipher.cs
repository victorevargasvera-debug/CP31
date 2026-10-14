using System;
using Org.BouncyCastle.Crypto.Utilities;
using Org.BouncyCastle.Utilities;

namespace Org.BouncyCastle.Tls.Crypto.Impl
{
	// Token: 0x0200015E RID: 350
	public class TlsBlockCipher : global::Org.BouncyCastle.Tls.Crypto.TlsCipher
	{
		// Token: 0x06000DA9 RID: 3497 RVA: 0x000332B0 File Offset: 0x000314B0
		public TlsBlockCipher(global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters cryptoParams, global::Org.BouncyCastle.Tls.Crypto.Impl.TlsBlockCipherImpl encryptCipher, global::Org.BouncyCastle.Tls.Crypto.Impl.TlsBlockCipherImpl decryptCipher, global::Org.BouncyCastle.Tls.Crypto.TlsHmac clientMac, global::Org.BouncyCastle.Tls.Crypto.TlsHmac serverMac, int cipherKeySize)
		{
			global::Org.BouncyCastle.Tls.SecurityParameters securityParameters = cryptoParams.SecurityParameters;
			global::Org.BouncyCastle.Tls.ProtocolVersion negotiatedVersion = securityParameters.NegotiatedVersion;
			if (global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV13(negotiatedVersion))
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			this.m_cryptoParams = cryptoParams;
			this.m_randomData = cryptoParams.NonceGenerator.GenerateNonce(256);
			this.m_encryptThenMac = securityParameters.IsEncryptThenMac;
			this.m_useExplicitIV = global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.IsTlsV11(negotiatedVersion);
			this.m_acceptExtraPadding = !negotiatedVersion.IsSsl;
			this.m_useExtraPadding = (securityParameters.IsExtendedPadding && global::Org.BouncyCastle.Tls.ProtocolVersion.TLSv10.IsEqualOrEarlierVersionOf(negotiatedVersion) && (this.m_encryptThenMac || !securityParameters.IsTruncatedHmac));
			this.m_encryptCipher = encryptCipher;
			this.m_decryptCipher = decryptCipher;
			global::Org.BouncyCastle.Tls.Crypto.Impl.TlsBlockCipherImpl clientCipher;
			global::Org.BouncyCastle.Tls.Crypto.Impl.TlsBlockCipherImpl serverCipher;
			if (cryptoParams.IsServer)
			{
				clientCipher = decryptCipher;
				serverCipher = encryptCipher;
			}
			else
			{
				clientCipher = encryptCipher;
				serverCipher = decryptCipher;
			}
			int key_block_size = 2 * cipherKeySize + clientMac.MacLength + serverMac.MacLength;
			if (!this.m_useExplicitIV)
			{
				key_block_size += clientCipher.GetBlockSize() + serverCipher.GetBlockSize();
			}
			byte[] key_block = global::Org.BouncyCastle.Tls.Crypto.Impl.TlsImplUtilities.CalculateKeyBlock(cryptoParams, key_block_size);
			int offset = 0;
			clientMac.SetKey(key_block, offset, clientMac.MacLength);
			offset += clientMac.MacLength;
			serverMac.SetKey(key_block, offset, serverMac.MacLength);
			offset += serverMac.MacLength;
			clientCipher.SetKey(key_block, offset, cipherKeySize);
			offset += cipherKeySize;
			serverCipher.SetKey(key_block, offset, cipherKeySize);
			offset += cipherKeySize;
			int clientIVLength = clientCipher.GetBlockSize();
			int serverIVLength = serverCipher.GetBlockSize();
			if (this.m_useExplicitIV)
			{
				clientCipher.Init(new byte[clientIVLength], 0, clientIVLength);
				serverCipher.Init(new byte[serverIVLength], 0, serverIVLength);
			}
			else
			{
				clientCipher.Init(key_block, offset, clientIVLength);
				offset += clientIVLength;
				serverCipher.Init(key_block, offset, serverIVLength);
				offset += serverIVLength;
			}
			if (offset != key_block_size)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			if (cryptoParams.IsServer)
			{
				this.m_writeMac = new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac(cryptoParams, serverMac);
				this.m_readMac = new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac(cryptoParams, clientMac);
				return;
			}
			this.m_writeMac = new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac(cryptoParams, clientMac);
			this.m_readMac = new global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteHmac(cryptoParams, serverMac);
		}

		// Token: 0x06000DAA RID: 3498 RVA: 0x000334C8 File Offset: 0x000316C8
		public virtual int GetCiphertextDecodeLimit(int plaintextLimit)
		{
			int blockSize = this.m_decryptCipher.GetBlockSize();
			int macSize = this.m_readMac.Size;
			int maxPadding = 256;
			return this.GetCiphertextLength(blockSize, macSize, maxPadding, plaintextLimit);
		}

		// Token: 0x06000DAB RID: 3499 RVA: 0x00033500 File Offset: 0x00031700
		public virtual int GetCiphertextEncodeLimit(int plaintextLength, int plaintextLimit)
		{
			int blockSize = this.m_encryptCipher.GetBlockSize();
			int macSize = this.m_writeMac.Size;
			int maxPadding = this.m_useExtraPadding ? 256 : blockSize;
			return this.GetCiphertextLength(blockSize, macSize, maxPadding, plaintextLength);
		}

		// Token: 0x06000DAC RID: 3500 RVA: 0x00033540 File Offset: 0x00031740
		public virtual int GetPlaintextLimit(int ciphertextLimit)
		{
			int blockSize = this.m_encryptCipher.GetBlockSize();
			int macSize = this.m_writeMac.Size;
			int plaintextLimit;
			if (this.m_encryptThenMac)
			{
				plaintextLimit = ciphertextLimit - macSize;
				plaintextLimit -= plaintextLimit % blockSize;
			}
			else
			{
				plaintextLimit = ciphertextLimit - ciphertextLimit % blockSize;
				plaintextLimit -= macSize;
			}
			plaintextLimit--;
			if (this.m_useExplicitIV)
			{
				plaintextLimit -= blockSize;
			}
			return plaintextLimit;
		}

		// Token: 0x06000DAD RID: 3501 RVA: 0x00033598 File Offset: 0x00031798
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult EncodePlaintext(long seqNo, short contentType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, int headerAllocation, byte[] plaintext, int offset, int len)
		{
			int blockSize = this.m_encryptCipher.GetBlockSize();
			int macSize = this.m_writeMac.Size;
			int enc_input_length = len;
			if (!this.m_encryptThenMac)
			{
				enc_input_length += macSize;
			}
			int padding_length = blockSize - enc_input_length % blockSize;
			if (this.m_useExtraPadding)
			{
				int maxExtraPadBlocks = (256 - padding_length) / blockSize;
				int actualExtraPadBlocks = this.ChooseExtraPadBlocks(maxExtraPadBlocks);
				padding_length += actualExtraPadBlocks * blockSize;
			}
			int totalSize = len + macSize + padding_length;
			if (this.m_useExplicitIV)
			{
				totalSize += blockSize;
			}
			byte[] outBuf = new byte[headerAllocation + totalSize];
			int outOff = headerAllocation;
			if (this.m_useExplicitIV)
			{
				global::System.Array.Copy(this.m_cryptoParams.NonceGenerator.GenerateNonce(blockSize), 0, outBuf, outOff, blockSize);
				outOff += blockSize;
			}
			global::System.Array.Copy(plaintext, offset, outBuf, outOff, len);
			outOff += len;
			if (!this.m_encryptThenMac)
			{
				byte[] mac = this.m_writeMac.CalculateMac(seqNo, contentType, plaintext, offset, len);
				global::System.Array.Copy(mac, 0, outBuf, outOff, mac.Length);
				outOff += mac.Length;
			}
			byte padByte = (byte)(padding_length - 1);
			for (int i = 0; i < padding_length; i++)
			{
				outBuf[outOff++] = padByte;
			}
			this.m_encryptCipher.DoFinal(outBuf, headerAllocation, outOff - headerAllocation, outBuf, headerAllocation);
			if (this.m_encryptThenMac)
			{
				byte[] mac2 = this.m_writeMac.CalculateMac(seqNo, contentType, outBuf, headerAllocation, outOff - headerAllocation);
				global::System.Array.Copy(mac2, 0, outBuf, outOff, mac2.Length);
				outOff += mac2.Length;
			}
			if (outOff != outBuf.Length)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
			}
			return new global::Org.BouncyCastle.Tls.Crypto.TlsEncodeResult(outBuf, 0, outBuf.Length, contentType);
		}

		// Token: 0x06000DAE RID: 3502 RVA: 0x00033724 File Offset: 0x00031924
		public virtual global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult DecodeCiphertext(long seqNo, short recordType, global::Org.BouncyCastle.Tls.ProtocolVersion recordVersion, byte[] ciphertext, int offset, int len)
		{
			int blockSize = this.m_decryptCipher.GetBlockSize();
			int macSize = this.m_readMac.Size;
			int minLen = blockSize;
			if (this.m_encryptThenMac)
			{
				minLen += macSize;
			}
			else
			{
				minLen = global::System.Math.Max(minLen, macSize + 1);
			}
			if (this.m_useExplicitIV)
			{
				minLen += blockSize;
			}
			if (len < minLen)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(50);
			}
			int blocks_length = len;
			if (this.m_encryptThenMac)
			{
				blocks_length -= macSize;
			}
			if (blocks_length % blockSize != 0)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(21);
			}
			if (this.m_encryptThenMac)
			{
				byte[] expectedMac = this.m_readMac.CalculateMac(seqNo, recordType, ciphertext, offset, len - macSize);
				if (!global::Org.BouncyCastle.Tls.TlsUtilities.ConstantTimeAreEqual(macSize, expectedMac, 0, ciphertext, offset + len - macSize))
				{
					throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(20);
				}
			}
			this.m_decryptCipher.DoFinal(ciphertext, offset, blocks_length, ciphertext, offset);
			if (this.m_useExplicitIV)
			{
				offset += blockSize;
				blocks_length -= blockSize;
			}
			int totalPad = this.CheckPaddingConstantTime(ciphertext, offset, blocks_length, blockSize, this.m_encryptThenMac ? 0 : macSize);
			bool badMac = totalPad == 0;
			int dec_output_length = blocks_length - totalPad;
			if (!this.m_encryptThenMac)
			{
				dec_output_length -= macSize;
				byte[] expectedMac2 = this.m_readMac.CalculateMacConstantTime(seqNo, recordType, ciphertext, offset, dec_output_length, blocks_length - macSize, this.m_randomData);
				badMac |= !global::Org.BouncyCastle.Tls.TlsUtilities.ConstantTimeAreEqual(macSize, expectedMac2, 0, ciphertext, offset + dec_output_length);
			}
			if (badMac)
			{
				throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(20);
			}
			return new global::Org.BouncyCastle.Tls.Crypto.TlsDecodeResult(ciphertext, offset, dec_output_length, recordType);
		}

		// Token: 0x06000DAF RID: 3503 RVA: 0x0003387D File Offset: 0x00031A7D
		public virtual void RekeyDecoder()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x06000DB0 RID: 3504 RVA: 0x00033886 File Offset: 0x00031A86
		public virtual void RekeyEncoder()
		{
			throw new global::Org.BouncyCastle.Tls.TlsFatalAlert(80);
		}

		// Token: 0x170001FC RID: 508
		// (get) Token: 0x06000DB1 RID: 3505 RVA: 0x0003388F File Offset: 0x00031A8F
		public virtual bool UsesOpaqueRecordType
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000DB2 RID: 3506 RVA: 0x00033894 File Offset: 0x00031A94
		protected virtual int CheckPaddingConstantTime(byte[] buf, int off, int len, int blockSize, int macSize)
		{
			int end = off + len;
			byte lastByte = buf[end - 1];
			int totalPad = (int)((lastByte & byte.MaxValue) + 1);
			int dummyIndex = 0;
			byte padDiff = 0;
			int totalPadLimit = global::System.Math.Min(this.m_acceptExtraPadding ? 256 : blockSize, len - macSize);
			if (totalPad > totalPadLimit)
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
			byte[] dummyPad = this.m_randomData;
			while (dummyIndex < 256)
			{
				padDiff |= (dummyPad[dummyIndex++] ^ lastByte);
			}
			byte[] array = dummyPad;
			int num = 0;
			array[num] ^= padDiff;
			return totalPad;
		}

		// Token: 0x06000DB3 RID: 3507 RVA: 0x00033936 File Offset: 0x00031B36
		protected virtual int ChooseExtraPadBlocks(int max)
		{
			return global::System.Math.Min(global::Org.BouncyCastle.Utilities.Integers.NumberOfTrailingZeros((int)global::Org.BouncyCastle.Crypto.Utilities.Pack.LE_To_UInt32(this.m_cryptoParams.NonceGenerator.GenerateNonce(4), 0)), max);
		}

		// Token: 0x06000DB4 RID: 3508 RVA: 0x0003395C File Offset: 0x00031B5C
		protected virtual int GetCiphertextLength(int blockSize, int macSize, int maxPadding, int plaintextLength)
		{
			int ciphertextLength = plaintextLength;
			if (this.m_useExplicitIV)
			{
				ciphertextLength += blockSize;
			}
			ciphertextLength += maxPadding;
			if (this.m_encryptThenMac)
			{
				ciphertextLength -= ciphertextLength % blockSize;
				ciphertextLength += macSize;
			}
			else
			{
				ciphertextLength += macSize;
				ciphertextLength -= ciphertextLength % blockSize;
			}
			return ciphertextLength;
		}

		// Token: 0x040007ED RID: 2029
		protected readonly global::Org.BouncyCastle.Tls.Crypto.TlsCryptoParameters m_cryptoParams;

		// Token: 0x040007EE RID: 2030
		protected readonly byte[] m_randomData;

		// Token: 0x040007EF RID: 2031
		protected readonly bool m_encryptThenMac;

		// Token: 0x040007F0 RID: 2032
		protected readonly bool m_useExplicitIV;

		// Token: 0x040007F1 RID: 2033
		protected readonly bool m_acceptExtraPadding;

		// Token: 0x040007F2 RID: 2034
		protected readonly bool m_useExtraPadding;

		// Token: 0x040007F3 RID: 2035
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.TlsBlockCipherImpl m_decryptCipher;

		// Token: 0x040007F4 RID: 2036
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.TlsBlockCipherImpl m_encryptCipher;

		// Token: 0x040007F5 RID: 2037
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteMac m_readMac;

		// Token: 0x040007F6 RID: 2038
		protected readonly global::Org.BouncyCastle.Tls.Crypto.Impl.TlsSuiteMac m_writeMac;
	}
}
