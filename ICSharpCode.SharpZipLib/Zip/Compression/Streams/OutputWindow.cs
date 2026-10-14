using System;

namespace ICSharpCode.SharpZipLib.Zip.Compression.Streams
{
	// Token: 0x02000040 RID: 64
	public class OutputWindow
	{
		// Token: 0x060002BF RID: 703 RVA: 0x0000E258 File Offset: 0x0000C458
		public void Write(int value)
		{
			int num = this.windowFilled;
			this.windowFilled = num + 1;
			if (num == 32768)
			{
				throw new global::System.InvalidOperationException("Window full");
			}
			byte[] array = this.window;
			num = this.windowEnd;
			this.windowEnd = num + 1;
			array[num] = (byte)value;
			this.windowEnd &= 32767;
		}

		// Token: 0x060002C0 RID: 704 RVA: 0x0000E2B4 File Offset: 0x0000C4B4
		private void SlowRepeat(int repStart, int length, int distance)
		{
			while (length-- > 0)
			{
				byte[] array = this.window;
				int num = this.windowEnd;
				this.windowEnd = num + 1;
				array[num] = this.window[repStart++];
				this.windowEnd &= 32767;
				repStart &= 32767;
			}
		}

		// Token: 0x060002C1 RID: 705 RVA: 0x0000E30C File Offset: 0x0000C50C
		public void Repeat(int length, int distance)
		{
			if ((this.windowFilled += length) > 32768)
			{
				throw new global::System.InvalidOperationException("Window full");
			}
			int num = this.windowEnd - distance & 32767;
			int num2 = 32768 - length;
			if (num > num2 || this.windowEnd >= num2)
			{
				this.SlowRepeat(num, length, distance);
				return;
			}
			if (length <= distance)
			{
				global::System.Array.Copy(this.window, num, this.window, this.windowEnd, length);
				this.windowEnd += length;
				return;
			}
			while (length-- > 0)
			{
				byte[] array = this.window;
				int num3 = this.windowEnd;
				this.windowEnd = num3 + 1;
				array[num3] = this.window[num++];
			}
		}

		// Token: 0x060002C2 RID: 706 RVA: 0x0000E3C4 File Offset: 0x0000C5C4
		public int CopyStored(global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.StreamManipulator input, int length)
		{
			length = global::System.Math.Min(global::System.Math.Min(length, 32768 - this.windowFilled), input.AvailableBytes);
			int num = 32768 - this.windowEnd;
			int num2;
			if (length > num)
			{
				num2 = input.CopyBytes(this.window, this.windowEnd, num);
				if (num2 == num)
				{
					num2 += input.CopyBytes(this.window, 0, length - num);
				}
			}
			else
			{
				num2 = input.CopyBytes(this.window, this.windowEnd, length);
			}
			this.windowEnd = (this.windowEnd + num2 & 32767);
			this.windowFilled += num2;
			return num2;
		}

		// Token: 0x060002C3 RID: 707 RVA: 0x0000E468 File Offset: 0x0000C668
		public void CopyDict(byte[] dictionary, int offset, int length)
		{
			if (dictionary == null)
			{
				throw new global::System.ArgumentNullException("dictionary");
			}
			if (this.windowFilled > 0)
			{
				throw new global::System.InvalidOperationException();
			}
			if (length > 32768)
			{
				offset += length - 32768;
				length = 32768;
			}
			global::System.Array.Copy(dictionary, offset, this.window, 0, length);
			this.windowEnd = (length & 32767);
		}

		// Token: 0x060002C4 RID: 708 RVA: 0x0000E4C8 File Offset: 0x0000C6C8
		public int GetFreeSpace()
		{
			return 32768 - this.windowFilled;
		}

		// Token: 0x060002C5 RID: 709 RVA: 0x0000E4D6 File Offset: 0x0000C6D6
		public int GetAvailable()
		{
			return this.windowFilled;
		}

		// Token: 0x060002C6 RID: 710 RVA: 0x0000E4E0 File Offset: 0x0000C6E0
		public int CopyOutput(byte[] output, int offset, int len)
		{
			int num = this.windowEnd;
			if (len > this.windowFilled)
			{
				len = this.windowFilled;
			}
			else
			{
				num = (this.windowEnd - this.windowFilled + len & 32767);
			}
			int num2 = len;
			int num3 = len - num;
			if (num3 > 0)
			{
				global::System.Array.Copy(this.window, 32768 - num3, output, offset, num3);
				offset += num3;
				len = num;
			}
			global::System.Array.Copy(this.window, num - len, output, offset, len);
			this.windowFilled -= num2;
			if (this.windowFilled < 0)
			{
				throw new global::System.InvalidOperationException();
			}
			return num2;
		}

		// Token: 0x060002C7 RID: 711 RVA: 0x0000E574 File Offset: 0x0000C774
		public void Reset()
		{
			this.windowFilled = (this.windowEnd = 0);
		}

		// Token: 0x040001BD RID: 445
		private const int WindowSize = 32768;

		// Token: 0x040001BE RID: 446
		private const int WindowMask = 32767;

		// Token: 0x040001BF RID: 447
		private byte[] window = new byte[32768];

		// Token: 0x040001C0 RID: 448
		private int windowEnd;

		// Token: 0x040001C1 RID: 449
		private int windowFilled;
	}
}
