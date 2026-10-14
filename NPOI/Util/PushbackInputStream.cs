using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000289 RID: 649
	public class PushbackInputStream : global::NPOI.Util.FilterInputStream
	{
		// Token: 0x06001176 RID: 4470 RVA: 0x00034A8B File Offset: 0x00032C8B
		public PushbackInputStream(global::NPOI.Util.InputStream input) : this(input, 1)
		{
		}

		// Token: 0x06001177 RID: 4471 RVA: 0x00034A95 File Offset: 0x00032C95
		public PushbackInputStream(global::NPOI.Util.InputStream input, int size) : base(input)
		{
			if (size <= 0)
			{
				throw new global::System.ArgumentException("size <= 0");
			}
			this.buf = new byte[size];
			this.pos = size;
		}

		// Token: 0x06001178 RID: 4472 RVA: 0x00034AC7 File Offset: 0x00032CC7
		protected override void Dispose(bool disposing)
		{
			this.input = null;
			base.Dispose(disposing);
		}

		// Token: 0x06001179 RID: 4473 RVA: 0x00034AD9 File Offset: 0x00032CD9
		public override int ReadByte()
		{
			if (this.bufint != -1)
			{
				int result = this.bufint;
				this.bufint = -1;
				return result;
			}
			return this.input.ReadByte();
		}

		// Token: 0x0600117A RID: 4474 RVA: 0x00034B00 File Offset: 0x00032D00
		public override int Read()
		{
			this.ensureOpen();
			if (this.pos < this.buf.Length)
			{
				byte[] array = this.buf;
				int num = this.pos;
				this.pos = num + 1;
				return array[num] & 255;
			}
			return base.Read();
		}

		// Token: 0x0600117B RID: 4475 RVA: 0x00034B48 File Offset: 0x00032D48
		public override int Read(byte[] b, int off, int len)
		{
			this.ensureOpen();
			if (b == null)
			{
				throw new global::System.ArgumentNullException();
			}
			if (off < 0 || len < 0 || len > b.Length - off)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			if (len == 0)
			{
				return 0;
			}
			int num = this.buf.Length - this.pos;
			if (num > 0)
			{
				if (len < num)
				{
					num = len;
				}
				global::System.Array.Copy(this.buf, this.pos, b, off, num);
				this.pos += num;
				off += num;
				len -= num;
			}
			if (len <= 0)
			{
				return num;
			}
			len = base.Read(b, off, len);
			if (len != -1)
			{
				return num + len;
			}
			if (num != 0)
			{
				return num;
			}
			return -1;
		}

		// Token: 0x0600117C RID: 4476 RVA: 0x00034BE4 File Offset: 0x00032DE4
		public virtual void Unread(int b)
		{
			this.ensureOpen();
			if (this.pos == 0)
			{
				throw new global::System.IO.IOException("Push back buffer is full");
			}
			byte[] array = this.buf;
			int num = this.pos - 1;
			this.pos = num;
			array[num] = (byte)b;
		}

		// Token: 0x0600117D RID: 4477 RVA: 0x00034C24 File Offset: 0x00032E24
		public void Unread(byte[] b)
		{
			this.Unread(b, 0, b.Length);
		}

		// Token: 0x0600117E RID: 4478 RVA: 0x00034C34 File Offset: 0x00032E34
		public override int Available()
		{
			this.ensureOpen();
			int num = this.buf.Length - this.pos;
			int num2 = base.Available();
			if (num <= 2147483647 - num2)
			{
				return num + num2;
			}
			return int.MaxValue;
		}

		// Token: 0x17000347 RID: 839
		// (get) Token: 0x0600117F RID: 4479 RVA: 0x00034C71 File Offset: 0x00032E71
		public override bool CanRead
		{
			get
			{
				return this.input.CanRead;
			}
		}

		// Token: 0x06001180 RID: 4480 RVA: 0x00034C80 File Offset: 0x00032E80
		private void ensureOpen()
		{
			if (this.input == null)
			{
				throw new global::System.IO.IOException("Stream closed");
			}
		}

		// Token: 0x06001181 RID: 4481 RVA: 0x00034C97 File Offset: 0x00032E97
		public void Unread(byte[] b, int off, int len)
		{
			this.ensureOpen();
			if (len > this.pos)
			{
				throw new global::System.IO.IOException("Push back buffer is full");
			}
			this.pos -= len;
			global::System.Array.Copy(b, off, this.buf, this.pos, len);
		}

		// Token: 0x06001182 RID: 4482 RVA: 0x00034CD8 File Offset: 0x00032ED8
		public override long Skip(long n)
		{
			this.ensureOpen();
			if (n <= 0L)
			{
				return 0L;
			}
			long num = (long)(this.buf.Length - this.pos);
			if (num > 0L)
			{
				if (n < num)
				{
					num = n;
				}
				this.pos += (int)num;
				n -= num;
			}
			if (n > 0L)
			{
				num += base.Skip(n);
			}
			return num;
		}

		// Token: 0x06001183 RID: 4483 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool MarkSupported()
		{
			return false;
		}

		// Token: 0x17000348 RID: 840
		// (get) Token: 0x06001184 RID: 4484 RVA: 0x00034D33 File Offset: 0x00032F33
		public override bool CanSeek
		{
			get
			{
				return this.input.CanSeek;
			}
		}

		// Token: 0x17000349 RID: 841
		// (get) Token: 0x06001185 RID: 4485 RVA: 0x00034D42 File Offset: 0x00032F42
		public override bool CanWrite
		{
			get
			{
				return this.input.CanWrite;
			}
		}

		// Token: 0x1700034A RID: 842
		// (get) Token: 0x06001186 RID: 4486 RVA: 0x00034D51 File Offset: 0x00032F51
		public override long Length
		{
			get
			{
				return this.input.Length;
			}
		}

		// Token: 0x1700034B RID: 843
		// (get) Token: 0x06001187 RID: 4487 RVA: 0x00034D60 File Offset: 0x00032F60
		// (set) Token: 0x06001188 RID: 4488 RVA: 0x00034D6F File Offset: 0x00032F6F
		public override long Position
		{
			get
			{
				return this.input.Position;
			}
			set
			{
				this.input.Position = value;
			}
		}

		// Token: 0x06001189 RID: 4489 RVA: 0x00034D7F File Offset: 0x00032F7F
		public override void Close()
		{
			if (this.input == null)
			{
				return;
			}
			this.input.Close();
			this.input = null;
			this.buf = null;
		}

		// Token: 0x0600118A RID: 4490 RVA: 0x00034DA9 File Offset: 0x00032FA9
		public override void Flush()
		{
			this.input.Flush();
		}

		// Token: 0x0600118B RID: 4491 RVA: 0x00034DB8 File Offset: 0x00032FB8
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this.input.Seek(offset, origin);
		}

		// Token: 0x0600118C RID: 4492 RVA: 0x00034DC9 File Offset: 0x00032FC9
		public override void SetLength(long value)
		{
			this.input.SetLength(value);
		}

		// Token: 0x0600118D RID: 4493 RVA: 0x00034DD9 File Offset: 0x00032FD9
		public override void Write(byte[] buffer, int offset, int count)
		{
			this.input.Write(buffer, offset, count);
		}

		// Token: 0x0600118E RID: 4494 RVA: 0x00034DEB File Offset: 0x00032FEB
		public override void WriteByte(byte value)
		{
			this.input.WriteByte(value);
		}

		// Token: 0x04000760 RID: 1888
		protected byte[] buf;

		// Token: 0x04000761 RID: 1889
		private int bufint = -1;

		// Token: 0x04000762 RID: 1890
		protected int pos;
	}
}
