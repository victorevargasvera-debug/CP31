using System;
using System.IO;
using System.Security.Cryptography;
using System.Threading;
using System.Threading.Tasks;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip;

namespace ICSharpCode.SharpZipLib.Encryption
{
	// Token: 0x0200005A RID: 90
	internal class ZipAESStream : global::System.Security.Cryptography.CryptoStream
	{
		// Token: 0x06000420 RID: 1056 RVA: 0x00012F14 File Offset: 0x00011114
		public ZipAESStream(global::System.IO.Stream stream, global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform transform, global::System.Security.Cryptography.CryptoStreamMode mode) : base(stream, transform, mode)
		{
			this._stream = stream;
			this._transform = transform;
			this._slideBuffer = new byte[1024];
			if (mode != global::System.Security.Cryptography.CryptoStreamMode.Read)
			{
				throw new global::System.Exception("ZipAESStream only for read");
			}
		}

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00012F4B File Offset: 0x0001114B
		private bool HasBufferedData
		{
			get
			{
				return this._transformBuffer != null && this._transformBufferStartPos < this._transformBufferFreePos;
			}
		}

		// Token: 0x06000422 RID: 1058 RVA: 0x00012F68 File Offset: 0x00011168
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (count == 0)
			{
				return 0;
			}
			int num = 0;
			if (this.HasBufferedData)
			{
				num = this.ReadBufferedData(buffer, offset, count);
				if (num == count)
				{
					return num;
				}
				offset += num;
				count -= num;
			}
			if (this._slideBuffer != null)
			{
				num += this.ReadAndTransform(buffer, offset, count);
			}
			return num;
		}

		// Token: 0x06000423 RID: 1059 RVA: 0x00012FB3 File Offset: 0x000111B3
		public override global::System.Threading.Tasks.Task<int> ReadAsync(byte[] buffer, int offset, int count, global::System.Threading.CancellationToken cancellationToken)
		{
			return global::System.Threading.Tasks.Task.FromResult<int>(this.Read(buffer, offset, count));
		}

		// Token: 0x06000424 RID: 1060 RVA: 0x00012FC4 File Offset: 0x000111C4
		private int ReadAndTransform(byte[] buffer, int offset, int count)
		{
			int i = 0;
			while (i < count)
			{
				int count2 = count - i;
				int num = this._slideBufFreePos - this._slideBufStartPos;
				int num2 = 26 - num;
				if (this._slideBuffer.Length - this._slideBufFreePos < num2)
				{
					int num3 = 0;
					int j = this._slideBufStartPos;
					while (j < this._slideBufFreePos)
					{
						this._slideBuffer[num3] = this._slideBuffer[j];
						j++;
						num3++;
					}
					this._slideBufFreePos -= this._slideBufStartPos;
					this._slideBufStartPos = 0;
				}
				int num4 = global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadRequestedBytes(this._stream, this._slideBuffer, this._slideBufFreePos, num2);
				this._slideBufFreePos += num4;
				num = this._slideBufFreePos - this._slideBufStartPos;
				if (num < 26)
				{
					if (num > 10)
					{
						int blockSize = num - 10;
						i += this.TransformAndBufferBlock(buffer, offset, count2, blockSize);
					}
					else if (num < 10)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Internal error missed auth code");
					}
					byte[] authCode = this._transform.GetAuthCode();
					for (int k = 0; k < 10; k++)
					{
						if (authCode[k] != this._slideBuffer[this._slideBufStartPos + k])
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("AES Authentication Code does not match. This is a super-CRC check on the data in the file after compression and encryption. \r\nThe file may be damaged.");
						}
					}
					this._slideBuffer = null;
					break;
				}
				int num5 = this.TransformAndBufferBlock(buffer, offset, count2, 16);
				i += num5;
				offset += num5;
			}
			return i;
		}

		// Token: 0x06000425 RID: 1061 RVA: 0x00013124 File Offset: 0x00011324
		private int ReadBufferedData(byte[] buffer, int offset, int count)
		{
			int num = global::System.Math.Min(count, this._transformBufferFreePos - this._transformBufferStartPos);
			global::System.Array.Copy(this._transformBuffer, this._transformBufferStartPos, buffer, offset, num);
			this._transformBufferStartPos += num;
			return num;
		}

		// Token: 0x06000426 RID: 1062 RVA: 0x00013168 File Offset: 0x00011368
		private int TransformAndBufferBlock(byte[] buffer, int offset, int count, int blockSize)
		{
			bool flag = blockSize > count;
			if (flag && this._transformBuffer == null)
			{
				this._transformBuffer = new byte[16];
			}
			byte[] outputBuffer = flag ? this._transformBuffer : buffer;
			int outputOffset = flag ? 0 : offset;
			this._transform.TransformBlock(this._slideBuffer, this._slideBufStartPos, blockSize, outputBuffer, outputOffset);
			this._slideBufStartPos += blockSize;
			if (!flag)
			{
				return blockSize;
			}
			global::System.Array.Copy(this._transformBuffer, 0, buffer, offset, count);
			this._transformBufferStartPos = count;
			this._transformBufferFreePos = blockSize;
			return count;
		}

		// Token: 0x06000427 RID: 1063 RVA: 0x000131F6 File Offset: 0x000113F6
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x04000275 RID: 629
		private const int AUTH_CODE_LENGTH = 10;

		// Token: 0x04000276 RID: 630
		private const int CRYPTO_BLOCK_SIZE = 16;

		// Token: 0x04000277 RID: 631
		private const int BLOCK_AND_AUTH = 26;

		// Token: 0x04000278 RID: 632
		private global::System.IO.Stream _stream;

		// Token: 0x04000279 RID: 633
		private global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform _transform;

		// Token: 0x0400027A RID: 634
		private byte[] _slideBuffer;

		// Token: 0x0400027B RID: 635
		private int _slideBufStartPos;

		// Token: 0x0400027C RID: 636
		private int _slideBufFreePos;

		// Token: 0x0400027D RID: 637
		private byte[] _transformBuffer;

		// Token: 0x0400027E RID: 638
		private int _transformBufferFreePos;

		// Token: 0x0400027F RID: 639
		private int _transformBufferStartPos;
	}
}
