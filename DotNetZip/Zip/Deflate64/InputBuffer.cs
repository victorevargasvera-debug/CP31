using System;

namespace Ionic.Zip.Deflate64
{
	// Token: 0x0200005F RID: 95
	internal sealed class InputBuffer
	{
		// Token: 0x17000129 RID: 297
		// (get) Token: 0x060004A6 RID: 1190 RVA: 0x0001BFB0 File Offset: 0x0001A1B0
		public int AvailableBits
		{
			get
			{
				return this._bitsInBuffer;
			}
		}

		// Token: 0x1700012A RID: 298
		// (get) Token: 0x060004A7 RID: 1191 RVA: 0x0001BFB8 File Offset: 0x0001A1B8
		public int AvailableBytes
		{
			get
			{
				return this._end - this._start + this._bitsInBuffer / 8;
			}
		}

		// Token: 0x060004A8 RID: 1192 RVA: 0x0001BFD0 File Offset: 0x0001A1D0
		public bool EnsureBitsAvailable(int count)
		{
			if (this._bitsInBuffer < count)
			{
				if (this.NeedsInput())
				{
					return false;
				}
				uint bitBuffer = this._bitBuffer;
				byte[] buffer = this._buffer;
				int start = this._start;
				this._start = start + 1;
				this._bitBuffer = (bitBuffer | buffer[start] << (this._bitsInBuffer & 31));
				this._bitsInBuffer += 8;
				if (this._bitsInBuffer < count)
				{
					if (this.NeedsInput())
					{
						return false;
					}
					uint bitBuffer2 = this._bitBuffer;
					byte[] buffer2 = this._buffer;
					start = this._start;
					this._start = start + 1;
					this._bitBuffer = (bitBuffer2 | buffer2[start] << (this._bitsInBuffer & 31));
					this._bitsInBuffer += 8;
				}
			}
			return true;
		}

		// Token: 0x060004A9 RID: 1193 RVA: 0x0001C084 File Offset: 0x0001A284
		public uint TryLoad16Bits()
		{
			if (this._bitsInBuffer < 8)
			{
				if (this._start < this._end)
				{
					uint bitBuffer = this._bitBuffer;
					byte[] buffer = this._buffer;
					int start = this._start;
					this._start = start + 1;
					this._bitBuffer = (bitBuffer | buffer[start] << (this._bitsInBuffer & 31));
					this._bitsInBuffer += 8;
				}
				if (this._start < this._end)
				{
					uint bitBuffer2 = this._bitBuffer;
					byte[] buffer2 = this._buffer;
					int start = this._start;
					this._start = start + 1;
					this._bitBuffer = (bitBuffer2 | buffer2[start] << (this._bitsInBuffer & 31));
					this._bitsInBuffer += 8;
				}
			}
			else if (this._bitsInBuffer < 16 && this._start < this._end)
			{
				uint bitBuffer3 = this._bitBuffer;
				byte[] buffer3 = this._buffer;
				int start = this._start;
				this._start = start + 1;
				this._bitBuffer = (bitBuffer3 | buffer3[start] << (this._bitsInBuffer & 31));
				this._bitsInBuffer += 8;
			}
			return this._bitBuffer;
		}

		// Token: 0x060004AA RID: 1194 RVA: 0x0001C193 File Offset: 0x0001A393
		private uint GetBitMask(int count)
		{
			return (1U << count) - 1U;
		}

		// Token: 0x060004AB RID: 1195 RVA: 0x0001C19D File Offset: 0x0001A39D
		public int GetBits(int count)
		{
			if (!this.EnsureBitsAvailable(count))
			{
				return -1;
			}
			int result = (int)(this._bitBuffer & this.GetBitMask(count));
			this._bitBuffer >>= count;
			this._bitsInBuffer -= count;
			return result;
		}

		// Token: 0x060004AC RID: 1196 RVA: 0x0001C1D8 File Offset: 0x0001A3D8
		public int CopyTo(byte[] output, int offset, int length)
		{
			int num = 0;
			while (this._bitsInBuffer > 0 && length > 0)
			{
				output[offset++] = (byte)this._bitBuffer;
				this._bitBuffer >>= 8;
				this._bitsInBuffer -= 8;
				length--;
				num++;
			}
			if (length == 0)
			{
				return num;
			}
			int num2 = this._end - this._start;
			if (length > num2)
			{
				length = num2;
			}
			global::System.Array.Copy(this._buffer, this._start, output, offset, length);
			this._start += length;
			return num + length;
		}

		// Token: 0x060004AD RID: 1197 RVA: 0x0001C269 File Offset: 0x0001A469
		public bool NeedsInput()
		{
			return this._start == this._end;
		}

		// Token: 0x060004AE RID: 1198 RVA: 0x0001C279 File Offset: 0x0001A479
		public void SetInput(byte[] buffer, int offset, int length)
		{
			if (this._start == this._end)
			{
				this._buffer = buffer;
				this._start = offset;
				this._end = offset + length;
			}
		}

		// Token: 0x060004AF RID: 1199 RVA: 0x0001C2A0 File Offset: 0x0001A4A0
		public void SkipBits(int n)
		{
			this._bitBuffer >>= n;
			this._bitsInBuffer -= n;
		}

		// Token: 0x060004B0 RID: 1200 RVA: 0x0001C2C1 File Offset: 0x0001A4C1
		public void SkipToByteBoundary()
		{
			this._bitBuffer >>= this._bitsInBuffer % 8;
			this._bitsInBuffer -= this._bitsInBuffer % 8;
		}

		// Token: 0x04000338 RID: 824
		private byte[] _buffer;

		// Token: 0x04000339 RID: 825
		private int _start;

		// Token: 0x0400033A RID: 826
		private int _end;

		// Token: 0x0400033B RID: 827
		private uint _bitBuffer;

		// Token: 0x0400033C RID: 828
		private int _bitsInBuffer;
	}
}
