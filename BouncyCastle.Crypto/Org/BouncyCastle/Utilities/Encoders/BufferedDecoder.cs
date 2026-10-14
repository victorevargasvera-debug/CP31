using System;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000060 RID: 96
	public class BufferedDecoder
	{
		// Token: 0x0600040A RID: 1034 RVA: 0x000150B0 File Offset: 0x000132B0
		public BufferedDecoder(global::Org.BouncyCastle.Utilities.Encoders.ITranslator translator, int bufferSize)
		{
			this.translator = translator;
			if (bufferSize % translator.GetEncodedBlockSize() != 0)
			{
				throw new global::System.ArgumentException("buffer size not multiple of input block size");
			}
			this.buffer = new byte[bufferSize];
		}

		// Token: 0x0600040B RID: 1035 RVA: 0x000150E0 File Offset: 0x000132E0
		public int ProcessByte(byte input, byte[] output, int outOff)
		{
			int resultLen = 0;
			byte[] array = this.buffer;
			int num = this.bufOff;
			this.bufOff = num + 1;
			array[num] = input;
			if (this.bufOff == this.buffer.Length)
			{
				resultLen = this.translator.Decode(this.buffer, 0, this.buffer.Length, output, outOff);
				this.bufOff = 0;
			}
			return resultLen;
		}

		// Token: 0x0600040C RID: 1036 RVA: 0x00015140 File Offset: 0x00013340
		public int ProcessBytes(byte[] input, int inOff, int len, byte[] outBytes, int outOff)
		{
			if (len < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input length!");
			}
			int resultLen = 0;
			int gapLen = this.buffer.Length - this.bufOff;
			if (len > gapLen)
			{
				global::System.Array.Copy(input, inOff, this.buffer, this.bufOff, gapLen);
				resultLen += this.translator.Decode(this.buffer, 0, this.buffer.Length, outBytes, outOff);
				this.bufOff = 0;
				len -= gapLen;
				inOff += gapLen;
				outOff += resultLen;
				int chunkSize = len - len % this.buffer.Length;
				resultLen += this.translator.Decode(input, inOff, chunkSize, outBytes, outOff);
				len -= chunkSize;
				inOff += chunkSize;
			}
			if (len != 0)
			{
				global::System.Array.Copy(input, inOff, this.buffer, this.bufOff, len);
				this.bufOff += len;
			}
			return resultLen;
		}

		// Token: 0x04000290 RID: 656
		internal byte[] buffer;

		// Token: 0x04000291 RID: 657
		internal int bufOff;

		// Token: 0x04000292 RID: 658
		internal global::Org.BouncyCastle.Utilities.Encoders.ITranslator translator;
	}
}
