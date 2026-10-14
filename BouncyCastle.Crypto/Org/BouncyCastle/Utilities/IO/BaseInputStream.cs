using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.IO
{
	// Token: 0x0200004C RID: 76
	public abstract class BaseInputStream : global::System.IO.Stream
	{
		// Token: 0x1700007E RID: 126
		// (get) Token: 0x06000384 RID: 900 RVA: 0x00013B59 File Offset: 0x00011D59
		public sealed override bool CanRead
		{
			get
			{
				return !this.closed;
			}
		}

		// Token: 0x1700007F RID: 127
		// (get) Token: 0x06000385 RID: 901 RVA: 0x00013B64 File Offset: 0x00011D64
		public sealed override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000080 RID: 128
		// (get) Token: 0x06000386 RID: 902 RVA: 0x00013B67 File Offset: 0x00011D67
		public sealed override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06000387 RID: 903 RVA: 0x00013B6A File Offset: 0x00011D6A
		public override void Close()
		{
			this.closed = true;
			base.Close();
		}

		// Token: 0x06000388 RID: 904 RVA: 0x00013B79 File Offset: 0x00011D79
		public sealed override void Flush()
		{
		}

		// Token: 0x17000081 RID: 129
		// (get) Token: 0x06000389 RID: 905 RVA: 0x00013B7B File Offset: 0x00011D7B
		public sealed override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000082 RID: 130
		// (get) Token: 0x0600038A RID: 906 RVA: 0x00013B82 File Offset: 0x00011D82
		// (set) Token: 0x0600038B RID: 907 RVA: 0x00013B89 File Offset: 0x00011D89
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

		// Token: 0x0600038C RID: 908 RVA: 0x00013B90 File Offset: 0x00011D90
		public override int Read(byte[] buffer, int offset, int count)
		{
			int pos = offset;
			try
			{
				int end = offset + count;
				while (pos < end)
				{
					int b = this.ReadByte();
					if (b == -1)
					{
						break;
					}
					buffer[pos++] = (byte)b;
				}
			}
			catch (global::System.IO.IOException)
			{
				if (pos == offset)
				{
					throw;
				}
			}
			return pos - offset;
		}

		// Token: 0x0600038D RID: 909 RVA: 0x00013BDC File Offset: 0x00011DDC
		public sealed override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600038E RID: 910 RVA: 0x00013BE3 File Offset: 0x00011DE3
		public sealed override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600038F RID: 911 RVA: 0x00013BEA File Offset: 0x00011DEA
		public sealed override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x04000276 RID: 630
		private bool closed;
	}
}
