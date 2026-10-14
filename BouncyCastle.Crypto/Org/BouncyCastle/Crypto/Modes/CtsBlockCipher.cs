using System;

namespace Org.BouncyCastle.Crypto.Modes
{
	// Token: 0x02000435 RID: 1077
	public class CtsBlockCipher : global::Org.BouncyCastle.Crypto.BufferedBlockCipher
	{
		// Token: 0x06002982 RID: 10626 RVA: 0x000B07AC File Offset: 0x000AE9AC
		public CtsBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			if (cipher is global::Org.BouncyCastle.Crypto.Modes.OfbBlockCipher || cipher is global::Org.BouncyCastle.Crypto.Modes.CfbBlockCipher)
			{
				throw new global::System.ArgumentException("CtsBlockCipher can only accept ECB, or CBC ciphers");
			}
			this.cipher = cipher;
			this.blockSize = cipher.GetBlockSize();
			this.buf = new byte[this.blockSize * 2];
			this.bufOff = 0;
		}

		// Token: 0x06002983 RID: 10627 RVA: 0x000B0808 File Offset: 0x000AEA08
		public override int GetUpdateOutputSize(int length)
		{
			int total = length + this.bufOff;
			int leftOver = total % this.buf.Length;
			if (leftOver == 0)
			{
				return total - this.buf.Length;
			}
			return total - leftOver;
		}

		// Token: 0x06002984 RID: 10628 RVA: 0x000B083A File Offset: 0x000AEA3A
		public override int GetOutputSize(int length)
		{
			return length + this.bufOff;
		}

		// Token: 0x06002985 RID: 10629 RVA: 0x000B0844 File Offset: 0x000AEA44
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			int resultLen = 0;
			if (this.bufOff == this.buf.Length)
			{
				resultLen = this.cipher.ProcessBlock(this.buf, 0, output, outOff);
				global::System.Array.Copy(this.buf, this.blockSize, this.buf, 0, this.blockSize);
				this.bufOff = this.blockSize;
			}
			byte[] buf = this.buf;
			int bufOff = this.bufOff;
			this.bufOff = bufOff + 1;
			buf[bufOff] = input;
			return resultLen;
		}

		// Token: 0x06002986 RID: 10630 RVA: 0x000B08BC File Offset: 0x000AEABC
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			if (length < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input outLength!");
			}
			int blockSize = this.GetBlockSize();
			int outLength = this.GetUpdateOutputSize(length);
			if (outLength > 0 && outOff + outLength > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			int resultLen = 0;
			int gapLen = this.buf.Length - this.bufOff;
			if (length > gapLen)
			{
				global::System.Array.Copy(input, inOff, this.buf, this.bufOff, gapLen);
				resultLen += this.cipher.ProcessBlock(this.buf, 0, output, outOff);
				global::System.Array.Copy(this.buf, blockSize, this.buf, 0, blockSize);
				this.bufOff = blockSize;
				length -= gapLen;
				inOff += gapLen;
				while (length > blockSize)
				{
					global::System.Array.Copy(input, inOff, this.buf, this.bufOff, blockSize);
					resultLen += this.cipher.ProcessBlock(this.buf, 0, output, outOff + resultLen);
					global::System.Array.Copy(this.buf, blockSize, this.buf, 0, blockSize);
					length -= blockSize;
					inOff += blockSize;
				}
			}
			global::System.Array.Copy(input, inOff, this.buf, this.bufOff, length);
			this.bufOff += length;
			return resultLen;
		}

		// Token: 0x06002987 RID: 10631 RVA: 0x000B09E4 File Offset: 0x000AEBE4
		public override int DoFinal(byte[] output, int outOff)
		{
			if (this.bufOff + outOff > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too small in doFinal");
			}
			int blockSize = this.cipher.GetBlockSize();
			int length = this.bufOff - blockSize;
			byte[] block = new byte[blockSize];
			if (this.forEncryption)
			{
				this.cipher.ProcessBlock(this.buf, 0, block, 0);
				if (this.bufOff < blockSize)
				{
					throw new global::Org.BouncyCastle.Crypto.DataLengthException("need at least one block of input for CTS");
				}
				for (int i = this.bufOff; i != this.buf.Length; i++)
				{
					this.buf[i] = block[i - blockSize];
				}
				for (int j = blockSize; j != this.bufOff; j++)
				{
					byte[] buf = this.buf;
					int num = j;
					buf[num] ^= block[j - blockSize];
				}
				((this.cipher is global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher) ? ((global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher)this.cipher).GetUnderlyingCipher() : this.cipher).ProcessBlock(this.buf, blockSize, output, outOff);
				global::System.Array.Copy(block, 0, output, outOff + blockSize, length);
			}
			else
			{
				byte[] lastBlock = new byte[blockSize];
				((this.cipher is global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher) ? ((global::Org.BouncyCastle.Crypto.Modes.CbcBlockCipher)this.cipher).GetUnderlyingCipher() : this.cipher).ProcessBlock(this.buf, 0, block, 0);
				for (int k = blockSize; k != this.bufOff; k++)
				{
					lastBlock[k - blockSize] = (block[k - blockSize] ^ this.buf[k]);
				}
				global::System.Array.Copy(this.buf, blockSize, block, 0, length);
				this.cipher.ProcessBlock(block, 0, output, outOff);
				global::System.Array.Copy(lastBlock, 0, output, outOff + blockSize, length);
			}
			int bufOff = this.bufOff;
			this.Reset();
			return bufOff;
		}

		// Token: 0x040010E1 RID: 4321
		private readonly int blockSize;
	}
}
