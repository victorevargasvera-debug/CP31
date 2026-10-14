using System;
using Org.BouncyCastle.Crypto.Parameters;

namespace Org.BouncyCastle.Crypto
{
	// Token: 0x020002B9 RID: 697
	public class BufferedBlockCipher : global::Org.BouncyCastle.Crypto.BufferedCipherBase
	{
		// Token: 0x06001F16 RID: 7958 RVA: 0x0008F790 File Offset: 0x0008D990
		protected BufferedBlockCipher()
		{
		}

		// Token: 0x06001F17 RID: 7959 RVA: 0x0008F798 File Offset: 0x0008D998
		public BufferedBlockCipher(global::Org.BouncyCastle.Crypto.IBlockCipher cipher)
		{
			if (cipher == null)
			{
				throw new global::System.ArgumentNullException("cipher");
			}
			this.cipher = cipher;
			this.buf = new byte[cipher.GetBlockSize()];
			this.bufOff = 0;
		}

		// Token: 0x17000446 RID: 1094
		// (get) Token: 0x06001F18 RID: 7960 RVA: 0x0008F7CD File Offset: 0x0008D9CD
		public override string AlgorithmName
		{
			get
			{
				return this.cipher.AlgorithmName;
			}
		}

		// Token: 0x06001F19 RID: 7961 RVA: 0x0008F7DC File Offset: 0x0008D9DC
		public override void Init(bool forEncryption, global::Org.BouncyCastle.Crypto.ICipherParameters parameters)
		{
			this.forEncryption = forEncryption;
			global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom pwr = parameters as global::Org.BouncyCastle.Crypto.Parameters.ParametersWithRandom;
			if (pwr != null)
			{
				parameters = pwr.Parameters;
			}
			this.Reset();
			this.cipher.Init(forEncryption, parameters);
		}

		// Token: 0x06001F1A RID: 7962 RVA: 0x0008F815 File Offset: 0x0008DA15
		public override int GetBlockSize()
		{
			return this.cipher.GetBlockSize();
		}

		// Token: 0x06001F1B RID: 7963 RVA: 0x0008F824 File Offset: 0x0008DA24
		public override int GetUpdateOutputSize(int length)
		{
			int num = length + this.bufOff;
			int leftOver = num % this.buf.Length;
			return num - leftOver;
		}

		// Token: 0x06001F1C RID: 7964 RVA: 0x0008F846 File Offset: 0x0008DA46
		public override int GetOutputSize(int length)
		{
			return length + this.bufOff;
		}

		// Token: 0x06001F1D RID: 7965 RVA: 0x0008F850 File Offset: 0x0008DA50
		public override int ProcessByte(byte input, byte[] output, int outOff)
		{
			byte[] array = this.buf;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = input;
			if (this.bufOff != this.buf.Length)
			{
				return 0;
			}
			if (outOff + this.buf.Length > output.Length)
			{
				throw new global::Org.BouncyCastle.Crypto.DataLengthException("output buffer too short");
			}
			this.bufOff = 0;
			return this.cipher.ProcessBlock(this.buf, 0, output, outOff);
		}

		// Token: 0x06001F1E RID: 7966 RVA: 0x0008F8C0 File Offset: 0x0008DAC0
		public override byte[] ProcessByte(byte input)
		{
			int outLength = this.GetUpdateOutputSize(1);
			byte[] outBytes = (outLength > 0) ? new byte[outLength] : null;
			int pos = this.ProcessByte(input, outBytes, 0);
			if (outLength > 0 && pos < outLength)
			{
				byte[] tmp = new byte[pos];
				global::System.Array.Copy(outBytes, 0, tmp, 0, pos);
				outBytes = tmp;
			}
			return outBytes;
		}

		// Token: 0x06001F1F RID: 7967 RVA: 0x0008F90C File Offset: 0x0008DB0C
		public override byte[] ProcessBytes(byte[] input, int inOff, int length)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input");
			}
			if (length < 1)
			{
				return null;
			}
			int outLength = this.GetUpdateOutputSize(length);
			byte[] outBytes = (outLength > 0) ? new byte[outLength] : null;
			int pos = this.ProcessBytes(input, inOff, length, outBytes, 0);
			if (outLength > 0 && pos < outLength)
			{
				byte[] tmp = new byte[pos];
				global::System.Array.Copy(outBytes, 0, tmp, 0, pos);
				outBytes = tmp;
			}
			return outBytes;
		}

		// Token: 0x06001F20 RID: 7968 RVA: 0x0008F96C File Offset: 0x0008DB6C
		public override int ProcessBytes(byte[] input, int inOff, int length, byte[] output, int outOff)
		{
			if (length >= 1)
			{
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
				if (this.bufOff == this.buf.Length)
				{
					resultLen += this.cipher.ProcessBlock(this.buf, 0, output, outOff + resultLen);
					this.bufOff = 0;
				}
				return resultLen;
			}
			if (length < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input length!");
			}
			return 0;
		}

		// Token: 0x06001F21 RID: 7969 RVA: 0x0008FA88 File Offset: 0x0008DC88
		public override byte[] DoFinal()
		{
			byte[] outBytes = global::Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
			int length = this.GetOutputSize(0);
			if (length > 0)
			{
				outBytes = new byte[length];
				int pos = this.DoFinal(outBytes, 0);
				if (pos < outBytes.Length)
				{
					byte[] tmp = new byte[pos];
					global::System.Array.Copy(outBytes, 0, tmp, 0, pos);
					outBytes = tmp;
				}
			}
			else
			{
				this.Reset();
			}
			return outBytes;
		}

		// Token: 0x06001F22 RID: 7970 RVA: 0x0008FADC File Offset: 0x0008DCDC
		public override byte[] DoFinal(byte[] input, int inOff, int inLen)
		{
			if (input == null)
			{
				throw new global::System.ArgumentNullException("input");
			}
			int length = this.GetOutputSize(inLen);
			byte[] outBytes = global::Org.BouncyCastle.Crypto.BufferedCipherBase.EmptyBuffer;
			if (length > 0)
			{
				outBytes = new byte[length];
				int pos = (inLen > 0) ? this.ProcessBytes(input, inOff, inLen, outBytes, 0) : 0;
				pos += this.DoFinal(outBytes, pos);
				if (pos < outBytes.Length)
				{
					byte[] tmp = new byte[pos];
					global::System.Array.Copy(outBytes, 0, tmp, 0, pos);
					outBytes = tmp;
				}
			}
			else
			{
				this.Reset();
			}
			return outBytes;
		}

		// Token: 0x06001F23 RID: 7971 RVA: 0x0008FB50 File Offset: 0x0008DD50
		public override int DoFinal(byte[] output, int outOff)
		{
			int result;
			try
			{
				if (this.bufOff != 0)
				{
					global::Org.BouncyCastle.Crypto.Check.DataLength(!this.cipher.IsPartialBlockOkay, "data not block size aligned");
					global::Org.BouncyCastle.Crypto.Check.OutputLength(output, outOff, this.bufOff, "output buffer too short for DoFinal()");
					this.cipher.ProcessBlock(this.buf, 0, this.buf, 0);
					global::System.Array.Copy(this.buf, 0, output, outOff, this.bufOff);
				}
				result = this.bufOff;
			}
			finally
			{
				this.Reset();
			}
			return result;
		}

		// Token: 0x06001F24 RID: 7972 RVA: 0x0008FBE0 File Offset: 0x0008DDE0
		public override void Reset()
		{
			global::System.Array.Clear(this.buf, 0, this.buf.Length);
			this.bufOff = 0;
			this.cipher.Reset();
		}

		// Token: 0x04000B22 RID: 2850
		internal byte[] buf;

		// Token: 0x04000B23 RID: 2851
		internal int bufOff;

		// Token: 0x04000B24 RID: 2852
		internal bool forEncryption;

		// Token: 0x04000B25 RID: 2853
		internal global::Org.BouncyCastle.Crypto.IBlockCipher cipher;
	}
}
