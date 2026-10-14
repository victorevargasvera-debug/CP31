using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000047 RID: 71
	[global::System.Obsolete("Use 'ZInputStream' instead")]
	public class ZInflaterInputStream : global::System.IO.Stream
	{
		// Token: 0x06000325 RID: 805 RVA: 0x00012BE0 File Offset: 0x00010DE0
		public ZInflaterInputStream(global::System.IO.Stream inp) : this(inp, false)
		{
		}

		// Token: 0x06000326 RID: 806 RVA: 0x00012BEC File Offset: 0x00010DEC
		public ZInflaterInputStream(global::System.IO.Stream inp, bool nowrap)
		{
			this.inp = inp;
			this.z.inflateInit(nowrap);
			this.z.next_in = this.buf;
			this.z.next_in_index = 0;
			this.z.avail_in = 0;
		}

		// Token: 0x17000069 RID: 105
		// (get) Token: 0x06000327 RID: 807 RVA: 0x00012C63 File Offset: 0x00010E63
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700006A RID: 106
		// (get) Token: 0x06000328 RID: 808 RVA: 0x00012C66 File Offset: 0x00010E66
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700006B RID: 107
		// (get) Token: 0x06000329 RID: 809 RVA: 0x00012C69 File Offset: 0x00010E69
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700006C RID: 108
		// (get) Token: 0x0600032A RID: 810 RVA: 0x00012C6C File Offset: 0x00010E6C
		public override long Length
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x1700006D RID: 109
		// (get) Token: 0x0600032B RID: 811 RVA: 0x00012C70 File Offset: 0x00010E70
		// (set) Token: 0x0600032C RID: 812 RVA: 0x00012C74 File Offset: 0x00010E74
		public override long Position
		{
			get
			{
				return 0L;
			}
			set
			{
			}
		}

		// Token: 0x0600032D RID: 813 RVA: 0x00012C76 File Offset: 0x00010E76
		public override void Write(byte[] b, int off, int len)
		{
		}

		// Token: 0x0600032E RID: 814 RVA: 0x00012C78 File Offset: 0x00010E78
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600032F RID: 815 RVA: 0x00012C7C File Offset: 0x00010E7C
		public override void SetLength(long value)
		{
		}

		// Token: 0x06000330 RID: 816 RVA: 0x00012C80 File Offset: 0x00010E80
		public override int Read(byte[] b, int off, int len)
		{
			if (len == 0)
			{
				return 0;
			}
			this.z.next_out = b;
			this.z.next_out_index = off;
			this.z.avail_out = len;
			for (;;)
			{
				if (this.z.avail_in == 0 && !this.nomoreinput)
				{
					this.z.next_in_index = 0;
					this.z.avail_in = this.inp.Read(this.buf, 0, 4192);
					if (this.z.avail_in <= 0)
					{
						this.z.avail_in = 0;
						this.nomoreinput = true;
					}
				}
				int err = this.z.inflate(this.flushLevel);
				if (this.nomoreinput && err == -5)
				{
					break;
				}
				if (err != 0 && err != 1)
				{
					goto Block_8;
				}
				if ((this.nomoreinput || err == 1) && this.z.avail_out == len)
				{
					return 0;
				}
				if (this.z.avail_out != len || err != 0)
				{
					goto IL_100;
				}
			}
			return 0;
			Block_8:
			throw new global::System.IO.IOException("inflating: " + this.z.msg);
			IL_100:
			return len - this.z.avail_out;
		}

		// Token: 0x06000331 RID: 817 RVA: 0x00012D9A File Offset: 0x00010F9A
		public override void Flush()
		{
			this.inp.Flush();
		}

		// Token: 0x06000332 RID: 818 RVA: 0x00012DA7 File Offset: 0x00010FA7
		public override void WriteByte(byte b)
		{
		}

		// Token: 0x06000333 RID: 819 RVA: 0x00012DA9 File Offset: 0x00010FA9
		public override void Close()
		{
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.inp);
			base.Close();
		}

		// Token: 0x06000334 RID: 820 RVA: 0x00012DBC File Offset: 0x00010FBC
		public override int ReadByte()
		{
			if (this.Read(this.buf1, 0, 1) <= 0)
			{
				return -1;
			}
			return (int)(this.buf1[0] & byte.MaxValue);
		}

		// Token: 0x0400023F RID: 575
		protected global::Org.BouncyCastle.Utilities.Zlib.ZStream z = new global::Org.BouncyCastle.Utilities.Zlib.ZStream();

		// Token: 0x04000240 RID: 576
		protected int flushLevel;

		// Token: 0x04000241 RID: 577
		private const int BUFSIZE = 4192;

		// Token: 0x04000242 RID: 578
		protected byte[] buf = new byte[4192];

		// Token: 0x04000243 RID: 579
		private byte[] buf1 = new byte[1];

		// Token: 0x04000244 RID: 580
		protected global::System.IO.Stream inp;

		// Token: 0x04000245 RID: 581
		private bool nomoreinput;
	}
}
