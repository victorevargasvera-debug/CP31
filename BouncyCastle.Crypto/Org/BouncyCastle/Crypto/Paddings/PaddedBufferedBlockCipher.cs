using System;
using Org.BouncyCastle.Crypto.Parameters;
using Org.BouncyCastle.Security;

namespace Org.BouncyCastle.Crypto.Paddings
{
	// Token: 0x02000417 RID: 1047
	public class PaddedBufferedBlockCipher : global::Org.BouncyCastle.Crypto.BufferedBlockCipher
	{
		// Token: 0x060028D0 RID: 10448 RVA: 0x000AD748 File Offset: 0x000AB948
		public PaddedBufferedBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher, global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding)
		{
			this.cipher = cipher;
			this.padding = padding;
			this.buf = new byte[cipher.GetBlockSize()];
			this.bufOff = 0;
		}

		// Token: 0x060028D1 RID: 10449 RVA: 0x000AD776 File Offset: 0x000AB976
		public PaddedBufferedBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher) : this(cipher, new global::Org.BouncyCastle.Crypto.Paddings.Pkcs7Padding())
		{
		}

		// Token: 0x060028D2 RID: 10450 RVA: 0x000AD784 File Offset: 0x000AB984
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
			global::Org.BouncyCastle.Security.SecureRandom initRandom = null;
			if (parameters is global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)
			{
				global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom parametersWithRandom = (global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom)parameters;
				initRandom = parametersWithRandom.Random;
				parameters = parametersWithRandom.Parameters;
			}
			this.Reset();
			this.padding.Init(initRandom);
			this.cipher.Init(forEncryption, parameters);
		}

		// Token: 0x060028D3 RID: 10451 RVA: 0x000AD7D8 File Offset: 0x000AB9D8
		public override int GetOutputSize(int length)
		{
			int total = length + this.bufOff;
			int leftOver = total % this.buf.Length;
			if (leftOver != 0)
			{
				return total - leftOver + this.buf.Length;
			}
			if (this.forEncryption)
			{
				return total + this.buf.Length;
			}
			return total;
		}

		// Token: 0x060028D4 RID: 10452 RVA: 0x000AD820 File Offset: 0x000ABA20
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

		// Token: 0x060028D5 RID: 10453 RVA: 0x000AD854 File Offset: 0x000ABA54
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			int resultLen = 0;
			if (this.bufOff == this.buf.Length)
			{
				resultLen = this.cipher.ProcessBlock(this.buf, 0, output, outOff);
				this.bufOff = 0;
			}
			byte[] buf = this.buf;
			int bufOff = this.bufOff;
			this.bufOff = bufOff + 1;
			buf[bufOff] = input;
			return resultLen;
		}

		// Token: 0x060028D6 RID: 10454 RVA: 0x000AD8AC File Offset: 0x000ABAAC
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			if (length < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input length!");
			}
			int blockSize = this.GetBlockSize();
			int outLength = this.GetUpdateOutputSize(length);
			if (outLength > 0)
			{
				global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, outLength, "output buffer too short");
			}
			int resultLen = 0;
			int gapLen = this.buf.Length - this.bufOff;
			if (length > gapLen)
			{
				global::System.Array.Copy(input, inOff, this.buf, this.bufOff, gapLen);
				resultLen += this.cipher.ProcessBlock(this.buf, 0, output, outOff);
				this.bufOff = 0;
				length -= gapLen;
				inOff += gapLen;
				while (length > this.buf.Length)
				{
					resultLen += this.cipher.ProcessBlock(input, inOff, output, outOff + resultLen);
					length -= blockSize;
					inOff += blockSize;
				}
			}
			global::System.Array.Copy(input, inOff, this.buf, this.bufOff, length);
			this.bufOff += length;
			return resultLen;
		}

		// Token: 0x060028D7 RID: 10455 RVA: 0x000AD990 File Offset: 0x000ABB90
		public override int DoFinal(byte[] output, int outOff)
		{
			int blockSize = this.cipher.GetBlockSize();
			int resultLen = 0;
			if (this.forEncryption)
			{
				if (this.bufOff == blockSize)
				{
					if (outOff + 2 * blockSize > output.Length)
					{
						this.Reset();
						throw new global::Org.BouncyCastle.Crypto.OutputLengthException("output buffer too short");
					}
					resultLen = this.cipher.ProcessBlock(this.buf, 0, output, outOff);
					this.bufOff = 0;
				}
				this.padding.AddPadding(this.buf, this.bufOff);
				resultLen += this.cipher.ProcessBlock(this.buf, 0, output, outOff + resultLen);
				this.Reset();
			}
			else
			{
				if (this.bufOff != blockSize)
				{
					this.Reset();
					throw new global::Org.BouncyCastle.Crypto.DataLengthException("last block incomplete in decryption");
				}
				resultLen = this.cipher.ProcessBlock(this.buf, 0, this.buf, 0);
				this.bufOff = 0;
				try
				{
					resultLen -= this.padding.PadCount(this.buf);
					global::System.Array.Copy(this.buf, 0, output, outOff, resultLen);
				}
				finally
				{
					this.Reset();
				}
			}
			return resultLen;
		}

		// Token: 0x04001094 RID: 4244
		private readonly global::Org.BouncyCastle.Crypto.Paddings.IBlockCipherPadding padding;
	}
}
