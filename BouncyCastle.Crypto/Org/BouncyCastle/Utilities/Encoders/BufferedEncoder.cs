using System;

namespace Org.BouncyCastle.Utilities.Encoders
{
	// Token: 0x02000061 RID: 97
	public class BufferedEncoder
	{
		// Token: 0x0600040D RID: 1037 RVA: 0x00015210 File Offset: 0x00013410
		public BufferedEncoder(global::Org.BouncyCastle.Utilities.Encoders.ITranslator translator, int bufferSize)
		{
			this.translator = translator;
			if (bufferSize % translator.GetEncodedBlockSize() != 0)
			{
				throw new global::System.ArgumentException("buffer size not multiple of input block size");
			}
			this.Buffer = new byte[bufferSize];
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00015240 File Offset: 0x00013440
		public int ProcessByte(byte input, byte[] outBytes, int outOff)
		{
			int resultLen = 0;
			byte[] buffer = this.Buffer;
			int num = this.bufOff;
			this.bufOff = num + 1;
			buffer[num] = input;
			if (this.bufOff == this.Buffer.Length)
			{
				resultLen = this.translator.Encode(this.Buffer, 0, this.Buffer.Length, outBytes, outOff);
				this.bufOff = 0;
			}
			return resultLen;
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x000152A0 File Offset: 0x000134A0
		public int ProcessBytes(byte[] input, int inOff, int len, byte[] outBytes, int outOff)
		{
			if (len < 0)
			{
				throw new global::System.ArgumentException("Can't have a negative input length!");
			}
			int resultLen = 0;
			int gapLen = this.Buffer.Length - this.bufOff;
			if (len > gapLen)
			{
				global::System.Array.Copy(input, inOff, this.Buffer, this.bufOff, gapLen);
				resultLen += this.translator.Encode(this.Buffer, 0, this.Buffer.Length, outBytes, outOff);
				this.bufOff = 0;
				len -= gapLen;
				inOff += gapLen;
				outOff += resultLen;
				int chunkSize = len - len % this.Buffer.Length;
				resultLen += this.translator.Encode(input, inOff, chunkSize, outBytes, outOff);
				len -= chunkSize;
				inOff += chunkSize;
			}
			if (len != 0)
			{
				global::System.Array.Copy(input, inOff, this.Buffer, this.bufOff, len);
				this.bufOff += len;
			}
			return resultLen;
		}

		// Token: 0x04000293 RID: 659
		internal byte[] Buffer;

		// Token: 0x04000294 RID: 660
		internal int bufOff;

		// Token: 0x04000295 RID: 661
		internal global::Org.BouncyCastle.Utilities.Encoders.ITranslator translator;
	}
}
