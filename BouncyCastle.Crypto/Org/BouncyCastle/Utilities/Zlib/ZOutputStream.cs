using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000049 RID: 73
	public class ZOutputStream : global::System.IO.Stream
	{
		// Token: 0x0600034C RID: 844 RVA: 0x00013120 File Offset: 0x00011320
		private static global::Org.BouncyCastle.Utilities.Zlib.ZStream GetDefaultZStream(bool nowrap)
		{
			global::Org.BouncyCastle.Utilities.Zlib.ZStream zstream = new global::Org.BouncyCastle.Utilities.Zlib.ZStream();
			zstream.inflateInit(nowrap);
			return zstream;
		}

		// Token: 0x0600034D RID: 845 RVA: 0x0001312F File Offset: 0x0001132F
		public ZOutputStream(global::System.IO.Stream output) : this(output, false)
		{
		}

		// Token: 0x0600034E RID: 846 RVA: 0x00013139 File Offset: 0x00011339
		public ZOutputStream(global::System.IO.Stream output, bool nowrap) : this(output, global::Org.BouncyCastle.Utilities.Zlib.ZOutputStream.GetDefaultZStream(nowrap))
		{
		}

		// Token: 0x0600034F RID: 847 RVA: 0x00013148 File Offset: 0x00011348
		public ZOutputStream(global::System.IO.Stream output, global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
		{
			this.buf = new byte[4096];
			this.buf1 = new byte[1];
			base..ctor();
			if (z == null)
			{
				z = new global::Org.BouncyCastle.Utilities.Zlib.ZStream();
			}
			if (z.istate == null && z.dstate == null)
			{
				z.inflateInit();
			}
			this.output = output;
			this.compress = (z.istate == null);
			this.z = z;
		}

		// Token: 0x06000350 RID: 848 RVA: 0x000131B5 File Offset: 0x000113B5
		public ZOutputStream(global::System.IO.Stream output, int level) : this(output, level, false)
		{
		}

		// Token: 0x06000351 RID: 849 RVA: 0x000131C0 File Offset: 0x000113C0
		public ZOutputStream(global::System.IO.Stream output, int level, bool nowrap)
		{
			this.buf = new byte[4096];
			this.buf1 = new byte[1];
			base..ctor();
			this.output = output;
			this.compress = true;
			this.z = new global::Org.BouncyCastle.Utilities.Zlib.ZStream();
			this.z.deflateInit(level, nowrap);
		}

		// Token: 0x17000076 RID: 118
		// (get) Token: 0x06000352 RID: 850 RVA: 0x00013216 File Offset: 0x00011416
		public sealed override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000077 RID: 119
		// (get) Token: 0x06000353 RID: 851 RVA: 0x00013219 File Offset: 0x00011419
		public sealed override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000078 RID: 120
		// (get) Token: 0x06000354 RID: 852 RVA: 0x0001321C File Offset: 0x0001141C
		public sealed override bool CanWrite
		{
			get
			{
				return !this.closed;
			}
		}

		// Token: 0x06000355 RID: 853 RVA: 0x00013227 File Offset: 0x00011427
		public override void Close()
		{
			if (this.closed)
			{
				return;
			}
			this.DoClose();
			base.Close();
		}

		// Token: 0x06000356 RID: 854 RVA: 0x00013240 File Offset: 0x00011440
		private void DoClose()
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
				this.closed = true;
				this.End();
				global::Org.BouncyCastle.Utilities.Platform.Dispose(this.output);
				this.output = null;
			}
		}

		// Token: 0x06000357 RID: 855 RVA: 0x00013294 File Offset: 0x00011494
		public virtual void End()
		{
			if (this.z == null)
			{
				return;
			}
			if (this.compress)
			{
				this.z.deflateEnd();
			}
			else
			{
				this.z.inflateEnd();
			}
			this.z.free();
			this.z = null;
		}

		// Token: 0x06000358 RID: 856 RVA: 0x000132D4 File Offset: 0x000114D4
		public virtual void Finish()
		{
			for (;;)
			{
				this.z.next_out = this.buf;
				this.z.next_out_index = 0;
				this.z.avail_out = this.buf.Length;
				int err = this.compress ? this.z.deflate(4) : this.z.inflate(4);
				if (err != 1 && err != 0)
				{
					break;
				}
				int count = this.buf.Length - this.z.avail_out;
				if (count > 0)
				{
					this.output.Write(this.buf, 0, count);
				}
				if (this.z.avail_in <= 0 && this.z.avail_out != 0)
				{
					goto Block_6;
				}
			}
			throw new global::System.IO.IOException((this.compress ? "de" : "in") + "flating: " + this.z.msg);
			Block_6:
			this.Flush();
		}

		// Token: 0x06000359 RID: 857 RVA: 0x000133BD File Offset: 0x000115BD
		public override void Flush()
		{
			this.output.Flush();
		}

		// Token: 0x17000079 RID: 121
		// (get) Token: 0x0600035A RID: 858 RVA: 0x000133CA File Offset: 0x000115CA
		// (set) Token: 0x0600035B RID: 859 RVA: 0x000133D2 File Offset: 0x000115D2
		public virtual int FlushMode
		{
			get
			{
				return this.flushLevel;
			}
			set
			{
				this.flushLevel = value;
			}
		}

		// Token: 0x1700007A RID: 122
		// (get) Token: 0x0600035C RID: 860 RVA: 0x000133DB File Offset: 0x000115DB
		public sealed override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x1700007B RID: 123
		// (get) Token: 0x0600035D RID: 861 RVA: 0x000133E2 File Offset: 0x000115E2
		// (set) Token: 0x0600035E RID: 862 RVA: 0x000133E9 File Offset: 0x000115E9
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

		// Token: 0x0600035F RID: 863 RVA: 0x000133F0 File Offset: 0x000115F0
		public sealed override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000360 RID: 864 RVA: 0x000133F7 File Offset: 0x000115F7
		public sealed override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000361 RID: 865 RVA: 0x000133FE File Offset: 0x000115FE
		public sealed override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700007C RID: 124
		// (get) Token: 0x06000362 RID: 866 RVA: 0x00013405 File Offset: 0x00011605
		public virtual long TotalIn
		{
			get
			{
				return this.z.total_in;
			}
		}

		// Token: 0x1700007D RID: 125
		// (get) Token: 0x06000363 RID: 867 RVA: 0x00013412 File Offset: 0x00011612
		public virtual long TotalOut
		{
			get
			{
				return this.z.total_out;
			}
		}

		// Token: 0x06000364 RID: 868 RVA: 0x00013420 File Offset: 0x00011620
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
				this.z.avail_out = this.buf.Length;
				if ((this.compress ? this.z.deflate(this.flushLevel) : this.z.inflate(this.flushLevel)) != 0)
				{
					break;
				}
				this.output.Write(this.buf, 0, this.buf.Length - this.z.avail_out);
				if (this.z.avail_in <= 0 && this.z.avail_out != 0)
				{
					return;
				}
			}
			throw new global::System.IO.IOException((this.compress ? "de" : "in") + "flating: " + this.z.msg);
		}

		// Token: 0x06000365 RID: 869 RVA: 0x00013529 File Offset: 0x00011729
		public override void WriteByte(byte b)
		{
			this.buf1[0] = b;
			this.Write(this.buf1, 0, 1);
		}

		// Token: 0x0400024F RID: 591
		private const int BufferSize = 4096;

		// Token: 0x04000250 RID: 592
		protected global::Org.BouncyCastle.Utilities.Zlib.ZStream z;

		// Token: 0x04000251 RID: 593
		protected int flushLevel;

		// Token: 0x04000252 RID: 594
		protected byte[] buf;

		// Token: 0x04000253 RID: 595
		protected byte[] buf1;

		// Token: 0x04000254 RID: 596
		protected bool compress;

		// Token: 0x04000255 RID: 597
		protected global::System.IO.Stream output;

		// Token: 0x04000256 RID: 598
		protected bool closed;
	}
}
