using System;

namespace Ionic.Zip.Deflate64
{
	// Token: 0x02000061 RID: 97
	internal sealed class OutputWindow
	{
		// Token: 0x060004B2 RID: 1202 RVA: 0x0001C2F0 File Offset: 0x0001A4F0
		internal void ClearBytesUsed()
		{
			this._bytesUsed = 0;
		}

		// Token: 0x060004B3 RID: 1203 RVA: 0x0001C2FC File Offset: 0x0001A4FC
		public void Write(byte b)
		{
			byte[] window = this._window;
			int end = this._end;
			this._end = end + 1;
			window[end] = b;
			this._end &= 262143;
			this._bytesUsed++;
		}

		// Token: 0x060004B4 RID: 1204 RVA: 0x0001C344 File Offset: 0x0001A544
		public void WriteLengthDistance(int length, int distance)
		{
			this._bytesUsed += length;
			int num = this._end - distance & 262143;
			int num2 = 262144 - length;
			if (num > num2 || this._end >= num2)
			{
				while (length-- > 0)
				{
					byte[] window = this._window;
					int end = this._end;
					this._end = end + 1;
					window[end] = this._window[num++];
					this._end &= 262143;
					num &= 262143;
				}
				return;
			}
			if (length <= distance)
			{
				global::System.Array.Copy(this._window, num, this._window, this._end, length);
				this._end += length;
				return;
			}
			while (length-- > 0)
			{
				byte[] window2 = this._window;
				int end = this._end;
				this._end = end + 1;
				window2[end] = this._window[num++];
			}
		}

		// Token: 0x060004B5 RID: 1205 RVA: 0x0001C42C File Offset: 0x0001A62C
		public int CopyFrom(global::Ionic.Zip.Deflate64.InputBuffer input, int length)
		{
			length = global::System.Math.Min(global::System.Math.Min(length, 262144 - this._bytesUsed), input.AvailableBytes);
			int num = 262144 - this._end;
			int num2;
			if (length > num)
			{
				num2 = input.CopyTo(this._window, this._end, num);
				if (num2 == num)
				{
					num2 += input.CopyTo(this._window, 0, length - num);
				}
			}
			else
			{
				num2 = input.CopyTo(this._window, this._end, length);
			}
			this._end = (this._end + num2 & 262143);
			this._bytesUsed += num2;
			return num2;
		}

		// Token: 0x1700012B RID: 299
		// (get) Token: 0x060004B6 RID: 1206 RVA: 0x0001C4CD File Offset: 0x0001A6CD
		public int FreeBytes
		{
			get
			{
				return 262144 - this._bytesUsed;
			}
		}

		// Token: 0x1700012C RID: 300
		// (get) Token: 0x060004B7 RID: 1207 RVA: 0x0001C4DB File Offset: 0x0001A6DB
		public int AvailableBytes
		{
			get
			{
				return this._bytesUsed;
			}
		}

		// Token: 0x060004B8 RID: 1208 RVA: 0x0001C4E4 File Offset: 0x0001A6E4
		public int CopyTo(byte[] output, int offset, int length)
		{
			int num;
			if (length > this._bytesUsed)
			{
				num = this._end;
				length = this._bytesUsed;
			}
			else
			{
				num = (this._end - this._bytesUsed + length & 262143);
			}
			int num2 = length;
			int num3 = length - num;
			if (num3 > 0)
			{
				global::System.Array.Copy(this._window, 262144 - num3, output, offset, num3);
				offset += num3;
				length = num;
			}
			global::System.Array.Copy(this._window, num - length, output, offset, length);
			this._bytesUsed -= num2;
			return num2;
		}

		// Token: 0x04000341 RID: 833
		private const int WindowSize = 262144;

		// Token: 0x04000342 RID: 834
		private const int WindowMask = 262143;

		// Token: 0x04000343 RID: 835
		private readonly byte[] _window = new byte[262144];

		// Token: 0x04000344 RID: 836
		private int _end;

		// Token: 0x04000345 RID: 837
		private int _bytesUsed;
	}
}
