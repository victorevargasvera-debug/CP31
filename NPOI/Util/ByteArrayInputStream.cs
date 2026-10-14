using System;
using System.IO;

namespace NPOI.Util
{
	// Token: 0x02000258 RID: 600
	public class ByteArrayInputStream : global::NPOI.Util.InputStream
	{
		// Token: 0x06000EBC RID: 3772 RVA: 0x0002B9B3 File Offset: 0x00029BB3
		public ByteArrayInputStream()
		{
		}

		// Token: 0x06000EBD RID: 3773 RVA: 0x0002B9BB File Offset: 0x00029BBB
		public ByteArrayInputStream(byte[] buf)
		{
			this.buf = buf;
			this.pos = 0;
			this.count = buf.Length;
		}

		// Token: 0x06000EBE RID: 3774 RVA: 0x0002B9DA File Offset: 0x00029BDA
		public ByteArrayInputStream(byte[] buf, int offset, int length)
		{
			this.buf = buf;
			this.pos = offset;
			this.count = global::System.Math.Min(offset + length, buf.Length);
			this.mark = offset;
		}

		// Token: 0x06000EBF RID: 3775 RVA: 0x0002BA08 File Offset: 0x00029C08
		public override int Read()
		{
			int num2;
			lock (this)
			{
				int num;
				if (this.pos >= this.count)
				{
					num = -1;
				}
				else
				{
					byte[] array = this.buf;
					num2 = this.pos;
					this.pos = num2 + 1;
					num = (array[num2] & 255);
				}
				num2 = num;
			}
			return num2;
		}

		// Token: 0x06000EC0 RID: 3776 RVA: 0x0002BA70 File Offset: 0x00029C70
		public override int Read(byte[] b, int off, int len)
		{
			int result;
			lock (this)
			{
				if (b == null)
				{
					throw new global::System.NullReferenceException();
				}
				if (off < 0 || len < 0 || len > b.Length - off)
				{
					throw new global::System.IndexOutOfRangeException();
				}
				if (this.pos >= this.count)
				{
					result = -1;
				}
				else
				{
					int num = this.count - this.pos;
					if (len > num)
					{
						len = num;
					}
					if (len <= 0)
					{
						result = 0;
					}
					else
					{
						global::System.Array.Copy(this.buf, this.pos, b, off, len);
						this.pos += len;
						result = len;
					}
				}
			}
			return result;
		}

		// Token: 0x06000EC1 RID: 3777 RVA: 0x0002BB18 File Offset: 0x00029D18
		public override int Available()
		{
			return this.count - this.pos;
		}

		// Token: 0x06000EC2 RID: 3778 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool MarkSupported()
		{
			return true;
		}

		// Token: 0x06000EC3 RID: 3779 RVA: 0x0002BB27 File Offset: 0x00029D27
		public override void Mark(int readAheadLimit)
		{
			this.mark = this.pos;
		}

		// Token: 0x06000EC4 RID: 3780 RVA: 0x0002BB35 File Offset: 0x00029D35
		public override void Reset()
		{
			this.pos = this.mark;
		}

		// Token: 0x06000EC5 RID: 3781 RVA: 0x00019A7F File Offset: 0x00017C7F
		public override void Close()
		{
		}

		// Token: 0x1700031C RID: 796
		// (get) Token: 0x06000EC6 RID: 3782 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700031D RID: 797
		// (get) Token: 0x06000EC7 RID: 3783 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700031E RID: 798
		// (get) Token: 0x06000EC8 RID: 3784 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanSeek
		{
			get
			{
				return true;
			}
		}

		// Token: 0x06000EC9 RID: 3785 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void Flush()
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x1700031F RID: 799
		// (get) Token: 0x06000ECA RID: 3786 RVA: 0x0002BB43 File Offset: 0x00029D43
		public override long Length
		{
			get
			{
				return (long)this.count;
			}
		}

		// Token: 0x17000320 RID: 800
		// (get) Token: 0x06000ECB RID: 3787 RVA: 0x0002BB4C File Offset: 0x00029D4C
		// (set) Token: 0x06000ECC RID: 3788 RVA: 0x0002BB55 File Offset: 0x00029D55
		public override long Position
		{
			get
			{
				return (long)this.pos;
			}
			set
			{
				this.pos = (int)value;
			}
		}

		// Token: 0x06000ECD RID: 3789 RVA: 0x0002BB60 File Offset: 0x00029D60
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			if (!this.CanSeek)
			{
				throw new global::System.NotSupportedException();
			}
			switch (origin)
			{
			case global::System.IO.SeekOrigin.Begin:
				if (0L > offset)
				{
					throw new global::System.ArgumentOutOfRangeException("offset", "offset must be positive");
				}
				this.Position = ((offset < this.Length) ? offset : this.Length);
				break;
			case global::System.IO.SeekOrigin.Current:
				this.Position = ((this.Position + offset < this.Length) ? (this.Position + offset) : this.Length);
				break;
			case global::System.IO.SeekOrigin.End:
				this.Position = this.Length;
				break;
			default:
				throw new global::System.ArgumentException("incorrect SeekOrigin", "origin");
			}
			return this.Position;
		}

		// Token: 0x06000ECE RID: 3790 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000ECF RID: 3791 RVA: 0x00008C75 File Offset: 0x00006E75
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x040006AE RID: 1710
		protected byte[] buf;

		// Token: 0x040006AF RID: 1711
		protected int pos;

		// Token: 0x040006B0 RID: 1712
		protected int mark;

		// Token: 0x040006B1 RID: 1713
		protected int count;
	}
}
