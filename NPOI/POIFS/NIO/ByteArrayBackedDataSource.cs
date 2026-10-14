using System;
using System.IO;
using NPOI.Util;

namespace NPOI.POIFS.NIO
{
	// Token: 0x020002C2 RID: 706
	public class ByteArrayBackedDataSource : global::NPOI.POIFS.NIO.DataSource
	{
		// Token: 0x0600137E RID: 4990 RVA: 0x0003A8C2 File Offset: 0x00038AC2
		public ByteArrayBackedDataSource(byte[] data, int size)
		{
			this.buffer = data;
			this.size = (long)size;
		}

		// Token: 0x0600137F RID: 4991 RVA: 0x0003A8D9 File Offset: 0x00038AD9
		public ByteArrayBackedDataSource(byte[] data) : this(data, data.Length)
		{
		}

		// Token: 0x06001380 RID: 4992 RVA: 0x0003A8E8 File Offset: 0x00038AE8
		public override global::NPOI.Util.ByteBuffer Read(int length, long position)
		{
			if (position >= this.size)
			{
				throw new global::System.IndexOutOfRangeException(string.Concat(new string[]
				{
					"Unable to read ",
					length.ToString(),
					" bytes from ",
					position.ToString(),
					" in stream of length ",
					this.size.ToString()
				}));
			}
			int length2 = (int)global::System.Math.Min((long)length, this.size - position);
			return global::NPOI.Util.ByteBuffer.CreateBuffer(this.buffer, (int)position, length2);
		}

		// Token: 0x06001381 RID: 4993 RVA: 0x0003A968 File Offset: 0x00038B68
		public override void Write(global::NPOI.Util.ByteBuffer src, long position)
		{
			long num = position + (long)src.Length;
			if (num > (long)this.buffer.Length)
			{
				this.Extend(num);
			}
			src.Read(this.buffer, (int)position, src.Length);
			if (num > this.size)
			{
				this.size = num;
			}
		}

		// Token: 0x06001382 RID: 4994 RVA: 0x0003A9B8 File Offset: 0x00038BB8
		private void Extend(long length)
		{
			long num = length - (long)this.buffer.Length;
			if ((double)num < (double)this.buffer.Length * 0.25)
			{
				num = (long)((double)this.buffer.Length * 0.25);
			}
			if (num < 4096L)
			{
				num = 4096L;
			}
			byte[] destinationArray = new byte[(int)(num + (long)this.buffer.Length)];
			global::System.Array.Copy(this.buffer, 0, destinationArray, 0, (int)this.size);
			this.buffer = destinationArray;
		}

		// Token: 0x06001383 RID: 4995 RVA: 0x0003AA3B File Offset: 0x00038C3B
		public override void CopyTo(global::System.IO.Stream stream)
		{
			stream.Write(this.buffer, 0, (int)this.size);
		}

		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x06001384 RID: 4996 RVA: 0x0003AA51 File Offset: 0x00038C51
		public override long Size
		{
			get
			{
				return this.size;
			}
		}

		// Token: 0x06001385 RID: 4997 RVA: 0x0003AA59 File Offset: 0x00038C59
		public override void Close()
		{
			this.buffer = null;
			this.size = -1L;
		}

		// Token: 0x04000825 RID: 2085
		private byte[] buffer;

		// Token: 0x04000826 RID: 2086
		private long size;
	}
}
