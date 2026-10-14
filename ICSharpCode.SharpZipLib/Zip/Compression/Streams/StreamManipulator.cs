using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000041 RID: 65
	public class StreamManipulator
	{
		// Token: 0x060002C9 RID: 713 RVA: 0x0000E5AC File Offset: 0x0000C7AC
		public int PeekBits(int bitCount)
		{
			if (this.bitsInBuffer_ < bitCount)
			{
				if (this.windowStart_ == this.windowEnd_)
				{
					return -1;
				}
				uint num = this.buffer_;
				byte[] array = this.window_;
				int num2 = this.windowStart_;
				this.windowStart_ = num2 + 1;
				uint num3 = array[num2] & 255U;
				byte[] array2 = this.window_;
				num2 = this.windowStart_;
				this.windowStart_ = num2 + 1;
				this.buffer_ = (num | (num3 | (array2[num2] & 255U) << 8) << this.bitsInBuffer_);
				this.bitsInBuffer_ += 16;
			}
			return (int)((ulong)this.buffer_ & (ulong)((long)((1 << bitCount) - 1)));
		}

		// Token: 0x060002CA RID: 714 RVA: 0x0000E64C File Offset: 0x0000C84C
		public bool TryGetBits(int bitCount, ref int output, int outputOffset = 0)
		{
			int num = this.PeekBits(bitCount);
			if (num < 0)
			{
				return false;
			}
			output = num + outputOffset;
			this.DropBits(bitCount);
			return true;
		}

		// Token: 0x060002CB RID: 715 RVA: 0x0000E674 File Offset: 0x0000C874
		public bool TryGetBits(int bitCount, ref byte[] array, int index)
		{
			int num = this.PeekBits(bitCount);
			if (num < 0)
			{
				return false;
			}
			array[index] = (byte)num;
			this.DropBits(bitCount);
			return true;
		}

		// Token: 0x060002CC RID: 716 RVA: 0x0000E69D File Offset: 0x0000C89D
		public void DropBits(int bitCount)
		{
			this.buffer_ >>= bitCount;
			this.bitsInBuffer_ -= bitCount;
		}

		// Token: 0x060002CD RID: 717 RVA: 0x0000E6BE File Offset: 0x0000C8BE
		public int GetBits(int bitCount)
		{
			int num = this.PeekBits(bitCount);
			if (num >= 0)
			{
				this.DropBits(bitCount);
			}
			return num;
		}

		// Token: 0x170000A3 RID: 163
		// (get) Token: 0x060002CE RID: 718 RVA: 0x0000E6D2 File Offset: 0x0000C8D2
		public int AvailableBits
		{
			get
			{
				return this.bitsInBuffer_;
			}
		}

		// Token: 0x170000A4 RID: 164
		// (get) Token: 0x060002CF RID: 719 RVA: 0x0000E6DA File Offset: 0x0000C8DA
		public int AvailableBytes
		{
			get
			{
				return this.windowEnd_ - this.windowStart_ + (this.bitsInBuffer_ >> 3);
			}
		}

		// Token: 0x060002D0 RID: 720 RVA: 0x0000E6F2 File Offset: 0x0000C8F2
		public void SkipToByteBoundary()
		{
			this.buffer_ >>= (this.bitsInBuffer_ & 7);
			this.bitsInBuffer_ &= -8;
		}

		// Token: 0x170000A5 RID: 165
		// (get) Token: 0x060002D1 RID: 721 RVA: 0x0000E71B File Offset: 0x0000C91B
		public bool IsNeedingInput
		{
			get
			{
				return this.windowStart_ == this.windowEnd_;
			}
		}

		// Token: 0x060002D2 RID: 722 RVA: 0x0000E72C File Offset: 0x0000C92C
		public int CopyBytes(byte[] output, int offset, int length)
		{
			if (length < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("length");
			}
			if ((this.bitsInBuffer_ & 7) != 0)
			{
				throw new global::System.InvalidOperationException("Bit buffer is not byte aligned!");
			}
			int num = 0;
			while (this.bitsInBuffer_ > 0 && length > 0)
			{
				output[offset++] = (byte)this.buffer_;
				this.buffer_ >>= 8;
				this.bitsInBuffer_ -= 8;
				length--;
				num++;
			}
			if (length == 0)
			{
				return num;
			}
			int num2 = this.windowEnd_ - this.windowStart_;
			if (length > num2)
			{
				length = num2;
			}
			global::System.Array.Copy(this.window_, this.windowStart_, output, offset, length);
			this.windowStart_ += length;
			if ((this.windowStart_ - this.windowEnd_ & 1) != 0)
			{
				byte[] array = this.window_;
				int num3 = this.windowStart_;
				this.windowStart_ = num3 + 1;
				this.buffer_ = (array[num3] & 255U);
				this.bitsInBuffer_ = 8;
			}
			return num + length;
		}

		// Token: 0x060002D3 RID: 723 RVA: 0x0000E820 File Offset: 0x0000CA20
		public void Reset()
		{
			this.buffer_ = 0U;
			this.windowStart_ = (this.windowEnd_ = (this.bitsInBuffer_ = 0));
		}

		// Token: 0x060002D4 RID: 724 RVA: 0x0000E850 File Offset: 0x0000CA50
		public void SetInput(byte[] buffer, int offset, int count)
		{
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset", "Cannot be negative");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count", "Cannot be negative");
			}
			if (this.windowStart_ < this.windowEnd_)
			{
				throw new global::System.InvalidOperationException("Old input was not completely processed");
			}
			int num = offset + count;
			if (offset > num || num > buffer.Length)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if ((count & 1) != 0)
			{
				this.buffer_ |= (uint)((uint)(buffer[offset++] & byte.MaxValue) << this.bitsInBuffer_);
				this.bitsInBuffer_ += 8;
			}
			this.window_ = buffer;
			this.windowStart_ = offset;
			this.windowEnd_ = num;
		}

		// Token: 0x040001C2 RID: 450
		private byte[] window_;

		// Token: 0x040001C3 RID: 451
		private int windowStart_;

		// Token: 0x040001C4 RID: 452
		private int windowEnd_;

		// Token: 0x040001C5 RID: 453
		private uint buffer_;

		// Token: 0x040001C6 RID: 454
		private int bitsInBuffer_;
	}
}
