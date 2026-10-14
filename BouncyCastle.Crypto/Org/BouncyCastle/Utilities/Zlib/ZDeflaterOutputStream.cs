using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000046 RID: 70
	[global::System.Obsolete("Use 'ZOutputStream' instead")]
	public class ZDeflaterOutputStream : global::System.IO.Stream
	{
		// Token: 0x06000313 RID: 787 RVA: 0x00012907 File Offset: 0x00010B07
		public ZDeflaterOutputStream(global::System.IO.Stream outp) : this(outp, 6, false)
		{
		}

		// Token: 0x06000314 RID: 788 RVA: 0x00012912 File Offset: 0x00010B12
		public ZDeflaterOutputStream(global::System.IO.Stream outp, int level) : this(outp, level, false)
		{
		}

		// Token: 0x06000315 RID: 789 RVA: 0x00012920 File Offset: 0x00010B20
		public ZDeflaterOutputStream(global::System.IO.Stream outp, int level, bool nowrap)
		{
			this.outp = outp;
			this.z.deflateInit(level, nowrap);
		}

		// Token: 0x17000064 RID: 100
		// (get) Token: 0x06000316 RID: 790 RVA: 0x0001296F File Offset: 0x00010B6F
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000065 RID: 101
		// (get) Token: 0x06000317 RID: 791 RVA: 0x00012972 File Offset: 0x00010B72
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000066 RID: 102
		// (get) Token: 0x06000318 RID: 792 RVA: 0x00012975 File Offset: 0x00010B75
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000067 RID: 103
		// (get) Token: 0x06000319 RID: 793 RVA: 0x00012978 File Offset: 0x00010B78
		public override long Length
		{
			get
			{
				return 0L;
			}
		}

		// Token: 0x17000068 RID: 104
		// (get) Token: 0x0600031A RID: 794 RVA: 0x0001297C File Offset: 0x00010B7C
		// (set) Token: 0x0600031B RID: 795 RVA: 0x00012980 File Offset: 0x00010B80
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

		// Token: 0x0600031C RID: 796 RVA: 0x00012984 File Offset: 0x00010B84
		public override void Write(byte[] b, int off, int len)
		{
			if (len == 0)
			{
				return;
			}
			this.z.next_in = b;
			this.z.next_in_index = off;
			this.z.avail_in = len;
			for (;;)
			{
				this.z.next_out = this.buf;
				this.z.next_out_index = 0;
				this.z.avail_out = 4192;
				if (this.z.deflate(this.flushLevel) != 0)
				{
					break;
				}
				if (this.z.avail_out < 4192)
				{
					this.outp.Write(this.buf, 0, 4192 - this.z.avail_out);
				}
				if (this.z.avail_in <= 0 && this.z.avail_out != 0)
				{
					return;
				}
			}
			throw new global::System.IO.IOException("deflating: " + this.z.msg);
		}

		// Token: 0x0600031D RID: 797 RVA: 0x00012A6A File Offset: 0x00010C6A
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return 0L;
		}

		// Token: 0x0600031E RID: 798 RVA: 0x00012A6E File Offset: 0x00010C6E
		public override void SetLength(long value)
		{
		}

		// Token: 0x0600031F RID: 799 RVA: 0x00012A70 File Offset: 0x00010C70
		public override int Read(byte[] buffer, int offset, int count)
		{
			return 0;
		}

		// Token: 0x06000320 RID: 800 RVA: 0x00012A73 File Offset: 0x00010C73
		public override void Flush()
		{
			this.outp.Flush();
		}

		// Token: 0x06000321 RID: 801 RVA: 0x00012A80 File Offset: 0x00010C80
		public override void WriteByte(byte b)
		{
			this.buf1[0] = b;
			this.Write(this.buf1, 0, 1);
		}

		// Token: 0x06000322 RID: 802 RVA: 0x00012A9C File Offset: 0x00010C9C
		public void Finish()
		{
			for (;;)
			{
				this.z.next_out = this.buf;
				this.z.next_out_index = 0;
				this.z.avail_out = 4192;
				int err = this.z.deflate(4);
				if (err != 1 && err != 0)
				{
					break;
				}
				if (4192 - this.z.avail_out > 0)
				{
					this.outp.Write(this.buf, 0, 4192 - this.z.avail_out);
				}
				if (this.z.avail_in <= 0 && this.z.avail_out != 0)
				{
					goto Block_4;
				}
			}
			throw new global::System.IO.IOException("deflating: " + this.z.msg);
			Block_4:
			this.Flush();
		}

		// Token: 0x06000323 RID: 803 RVA: 0x00012B63 File Offset: 0x00010D63
		public void End()
		{
			if (this.z == null)
			{
				return;
			}
			this.z.deflateEnd();
			this.z.free();
			this.z = null;
		}

		// Token: 0x06000324 RID: 804 RVA: 0x00012B8C File Offset: 0x00010D8C
		public override void Close()
		{
			try
			{
				this.Finish();
			}
			catch (global::System.IO.IOException)
			{
			}
			finally
			{
				this.End();
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this.outp);
				this.outp = null;
			}
			base.Close();
		}

		// Token: 0x04000239 RID: 569
		protected global::Org.BouncyCastle.Utilities.Zlib.ZStream z = new global::Org.BouncyCastle.Utilities.Zlib.ZStream();

		// Token: 0x0400023A RID: 570
		protected int flushLevel;

		// Token: 0x0400023B RID: 571
		private const int BUFSIZE = 4192;

		// Token: 0x0400023C RID: 572
		protected byte[] buf = new byte[4192];

		// Token: 0x0400023D RID: 573
		private byte[] buf1 = new byte[1];

		// Token: 0x0400023E RID: 574
		protected global::System.IO.Stream outp;
	}
}
