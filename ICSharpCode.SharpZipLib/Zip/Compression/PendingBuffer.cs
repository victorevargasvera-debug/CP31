using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression
{
	// Token: 0x0200003C RID: 60
	public class PendingBuffer
	{
		// Token: 0x06000270 RID: 624 RVA: 0x0000D4DD File Offset: 0x0000B6DD
		public PendingBuffer() : this(4096)
		{
		}

		// Token: 0x06000271 RID: 625 RVA: 0x0000D4EA File Offset: 0x0000B6EA
		public PendingBuffer(int bufferSize)
		{
			this.buffer = new byte[bufferSize];
		}

		// Token: 0x06000272 RID: 626 RVA: 0x0000D500 File Offset: 0x0000B700
		public void Reset()
		{
			this.start = (this.end = (this.bitCount = 0));
		}

		// Token: 0x06000273 RID: 627 RVA: 0x0000D528 File Offset: 0x0000B728
		public void WriteByte(int value)
		{
			byte[] array = this.buffer;
			int num = this.end;
			this.end = num + 1;
			array[num] = (byte)value;
		}

		// Token: 0x06000274 RID: 628 RVA: 0x0000D550 File Offset: 0x0000B750
		public void WriteShort(int value)
		{
			byte[] array = this.buffer;
			int num = this.end;
			this.end = num + 1;
			array[num] = (byte)value;
			byte[] array2 = this.buffer;
			num = this.end;
			this.end = num + 1;
			array2[num] = (byte)(value >> 8);
		}

		// Token: 0x06000275 RID: 629 RVA: 0x0000D594 File Offset: 0x0000B794
		public void WriteInt(int value)
		{
			byte[] array = this.buffer;
			int num = this.end;
			this.end = num + 1;
			array[num] = (byte)value;
			byte[] array2 = this.buffer;
			num = this.end;
			this.end = num + 1;
			array2[num] = (byte)(value >> 8);
			byte[] array3 = this.buffer;
			num = this.end;
			this.end = num + 1;
			array3[num] = (byte)(value >> 16);
			byte[] array4 = this.buffer;
			num = this.end;
			this.end = num + 1;
			array4[num] = (byte)(value >> 24);
		}

		// Token: 0x06000276 RID: 630 RVA: 0x0000D611 File Offset: 0x0000B811
		public void WriteBlock(byte[] block, int offset, int length)
		{
			global::System.Array.Copy(block, offset, this.buffer, this.end, length);
			this.end += length;
		}

		// Token: 0x1700008D RID: 141
		// (get) Token: 0x06000277 RID: 631 RVA: 0x0000D635 File Offset: 0x0000B835
		public int BitCount
		{
			get
			{
				return this.bitCount;
			}
		}

		// Token: 0x06000278 RID: 632 RVA: 0x0000D640 File Offset: 0x0000B840
		public void AlignToByte()
		{
			if (this.bitCount > 0)
			{
				byte[] array = this.buffer;
				int num = this.end;
				this.end = num + 1;
				array[num] = (byte)this.bits;
				if (this.bitCount > 8)
				{
					byte[] array2 = this.buffer;
					num = this.end;
					this.end = num + 1;
					array2[num] = (byte)(this.bits >> 8);
				}
			}
			this.bits = 0U;
			this.bitCount = 0;
		}

		// Token: 0x06000279 RID: 633 RVA: 0x0000D6B0 File Offset: 0x0000B8B0
		public void WriteBits(int b, int count)
		{
			this.bits |= (uint)((uint)b << this.bitCount);
			this.bitCount += count;
			if (this.bitCount >= 16)
			{
				byte[] array = this.buffer;
				int num = this.end;
				this.end = num + 1;
				array[num] = (byte)this.bits;
				byte[] array2 = this.buffer;
				num = this.end;
				this.end = num + 1;
				array2[num] = (byte)(this.bits >> 8);
				this.bits >>= 16;
				this.bitCount -= 16;
			}
		}

		// Token: 0x0600027A RID: 634 RVA: 0x0000D74C File Offset: 0x0000B94C
		public void WriteShortMSB(int s)
		{
			byte[] array = this.buffer;
			int num = this.end;
			this.end = num + 1;
			array[num] = (byte)(s >> 8);
			byte[] array2 = this.buffer;
			num = this.end;
			this.end = num + 1;
			array2[num] = (byte)s;
		}

		// Token: 0x1700008E RID: 142
		// (get) Token: 0x0600027B RID: 635 RVA: 0x0000D78F File Offset: 0x0000B98F
		public bool IsFlushed
		{
			get
			{
				return this.end == 0;
			}
		}

		// Token: 0x0600027C RID: 636 RVA: 0x0000D79C File Offset: 0x0000B99C
		public int Flush(byte[] output, int offset, int length)
		{
			if (this.bitCount >= 8)
			{
				byte[] array = this.buffer;
				int num = this.end;
				this.end = num + 1;
				array[num] = (byte)this.bits;
				this.bits >>= 8;
				this.bitCount -= 8;
			}
			if (length > this.end - this.start)
			{
				length = this.end - this.start;
				global::System.Array.Copy(this.buffer, this.start, output, offset, length);
				this.start = 0;
				this.end = 0;
			}
			else
			{
				global::System.Array.Copy(this.buffer, this.start, output, offset, length);
				this.start += length;
			}
			return length;
		}

		// Token: 0x0600027D RID: 637 RVA: 0x0000D854 File Offset: 0x0000BA54
		public byte[] ToByteArray()
		{
			this.AlignToByte();
			byte[] array = new byte[this.end - this.start];
			global::System.Array.Copy(this.buffer, this.start, array, 0, array.Length);
			this.start = 0;
			this.end = 0;
			return array;
		}

		// Token: 0x040001A3 RID: 419
		private readonly byte[] buffer;

		// Token: 0x040001A4 RID: 420
		private int start;

		// Token: 0x040001A5 RID: 421
		private int end;

		// Token: 0x040001A6 RID: 422
		private uint bits;

		// Token: 0x040001A7 RID: 423
		private int bitCount;
	}
}
