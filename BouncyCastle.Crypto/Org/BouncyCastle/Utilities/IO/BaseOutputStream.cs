using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200004D RID: 77
	public abstract class BaseOutputStream : global::System.IO.Stream
	{
		// Token: 0x17000083 RID: 131
		// (get) Token: 0x06000391 RID: 913 RVA: 0x00013BF9 File Offset: 0x00011DF9
		public sealed override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000084 RID: 132
		// (get) Token: 0x06000392 RID: 914 RVA: 0x00013BFC File Offset: 0x00011DFC
		public sealed override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000085 RID: 133
		// (get) Token: 0x06000393 RID: 915 RVA: 0x00013BFF File Offset: 0x00011DFF
		public sealed override bool CanWrite
		{
			get
			{
				return !this.closed;
			}
		}

		// Token: 0x06000394 RID: 916 RVA: 0x00013C0A File Offset: 0x00011E0A
		public override void Close()
		{
			this.closed = true;
			base.Close();
		}

		// Token: 0x06000395 RID: 917 RVA: 0x00013C19 File Offset: 0x00011E19
		public override void Flush()
		{
		}

		// Token: 0x17000086 RID: 134
		// (get) Token: 0x06000396 RID: 918 RVA: 0x00013C1B File Offset: 0x00011E1B
		public sealed override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000087 RID: 135
		// (get) Token: 0x06000397 RID: 919 RVA: 0x00013C22 File Offset: 0x00011E22
		// (set) Token: 0x06000398 RID: 920 RVA: 0x00013C29 File Offset: 0x00011E29
		public sealed override long Position
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06000399 RID: 921 RVA: 0x00013C30 File Offset: 0x00011E30
		public sealed override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600039A RID: 922 RVA: 0x00013C37 File Offset: 0x00011E37
		public sealed override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600039B RID: 923 RVA: 0x00013C3E File Offset: 0x00011E3E
		public sealed override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600039C RID: 924 RVA: 0x00013C48 File Offset: 0x00011E48
		public override void Write(byte[] buffer, int offset, int count)
		{
			int end = offset + count;
			for (int i = offset; i < end; i++)
			{
				this.WriteByte(buffer[i]);
			}
		}

		// Token: 0x0600039D RID: 925 RVA: 0x00013C6E File Offset: 0x00011E6E
		public virtual void Write(params byte[] buffer)
		{
			this.Write(buffer, 0, buffer.Length);
		}

		// Token: 0x0600039E RID: 926 RVA: 0x00013C7B File Offset: 0x00011E7B
		public override void WriteByte(byte b)
		{
			this.Write(new byte[]
			{
				b
			}, 0, 1);
		}

		// Token: 0x04000277 RID: 631
		private bool closed;
	}
}
