using System;
using System.IO;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x02000048 RID: 72
	public class ZInputStream : global::System.IO.Stream
	{
		// Token: 0x06000335 RID: 821 RVA: 0x00012DDF File Offset: 0x00010FDF
		private static global::Org.BouncyCastle.Utilities.Zlib.ZStream GetDefaultZStream(bool nowrap)
		{
			global::Org.BouncyCastle.Utilities.Zlib.ZStream zstream = new global::Org.BouncyCastle.Utilities.Zlib.ZStream();
			zstream.inflateInit(nowrap);
			return zstream;
		}

		// Token: 0x06000336 RID: 822 RVA: 0x00012DEE File Offset: 0x00010FEE
		public ZInputStream(global::System.IO.Stream input) : this(input, false)
		{
		}

		// Token: 0x06000337 RID: 823 RVA: 0x00012DF8 File Offset: 0x00010FF8
		public ZInputStream(global::System.IO.Stream input, bool nowrap) : this(input, global::Org.BouncyCastle.Utilities.Zlib.ZInputStream.GetDefaultZStream(nowrap))
		{
		}

		// Token: 0x06000338 RID: 824 RVA: 0x00012E08 File Offset: 0x00011008
		public ZInputStream(global::System.IO.Stream input, global::Org.BouncyCastle.Utilities.Zlib.ZStream z)
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
			this.input = input;
			this.compress = (z.istate == null);
			this.z = z;
			this.z.next_in = this.buf;
			this.z.next_in_index = 0;
			this.z.avail_in = 0;
		}

		// Token: 0x06000339 RID: 825 RVA: 0x00012E9E File Offset: 0x0001109E
		public ZInputStream(global::System.IO.Stream input, int level) : this(input, level, false)
		{
		}

		// Token: 0x0600033A RID: 826 RVA: 0x00012EAC File Offset: 0x000110AC
		public ZInputStream(global::System.IO.Stream input, int level, bool nowrap)
		{
			this.buf = new byte[4096];
			this.buf1 = new byte[1];
			base..ctor();
			this.input = input;
			this.compress = true;
			this.z = new global::Org.BouncyCastle.Utilities.Zlib.ZStream();
			this.z.deflateInit(level, nowrap);
			this.z.next_in = this.buf;
			this.z.next_in_index = 0;
			this.z.avail_in = 0;
		}

		// Token: 0x1700006E RID: 110
		// (get) Token: 0x0600033B RID: 827 RVA: 0x00012F2B File Offset: 0x0001112B
		public sealed override bool CanRead
		{
			get
			{
				return !this.closed;
			}
		}

		// Token: 0x1700006F RID: 111
		// (get) Token: 0x0600033C RID: 828 RVA: 0x00012F36 File Offset: 0x00011136
		public sealed override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000070 RID: 112
		// (get) Token: 0x0600033D RID: 829 RVA: 0x00012F39 File Offset: 0x00011139
		public sealed override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600033E RID: 830 RVA: 0x00012F3C File Offset: 0x0001113C
		public override void Close()
		{
			if (this.closed)
			{
				return;
			}
			this.closed = true;
			global::Org.BouncyCastle.Utilities.Platform.Dispose(this.input);
			base.Close();
		}

		// Token: 0x0600033F RID: 831 RVA: 0x00012F5F File Offset: 0x0001115F
		public sealed override void Flush()
		{
		}

		// Token: 0x17000071 RID: 113
		// (get) Token: 0x06000340 RID: 832 RVA: 0x00012F61 File Offset: 0x00011161
		// (set) Token: 0x06000341 RID: 833 RVA: 0x00012F69 File Offset: 0x00011169
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

		// Token: 0x17000072 RID: 114
		// (get) Token: 0x06000342 RID: 834 RVA: 0x00012F72 File Offset: 0x00011172
		public sealed override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000073 RID: 115
		// (get) Token: 0x06000343 RID: 835 RVA: 0x00012F79 File Offset: 0x00011179
		// (set) Token: 0x06000344 RID: 836 RVA: 0x00012F80 File Offset: 0x00011180
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

		// Token: 0x06000345 RID: 837 RVA: 0x00012F88 File Offset: 0x00011188
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
					this.z.avail_in = this.input.Read(this.buf, 0, this.buf.Length);
					if (this.z.avail_in <= 0)
					{
						this.z.avail_in = 0;
						this.nomoreinput = true;
					}
				}
				int err = this.compress ? this.z.deflate(this.flushLevel) : this.z.inflate(this.flushLevel);
				if (this.nomoreinput && err == -5)
				{
					break;
				}
				if (err != 0 && err != 1)
				{
					goto Block_9;
				}
				if ((this.nomoreinput || err == 1) && this.z.avail_out == len)
				{
					return 0;
				}
				if (this.z.avail_out != len || err != 0)
				{
					goto IL_132;
				}
			}
			return 0;
			Block_9:
			throw new global::System.IO.IOException((this.compress ? "de" : "in") + "flating: " + this.z.msg);
			IL_132:
			return len - this.z.avail_out;
		}

		// Token: 0x06000346 RID: 838 RVA: 0x000130D4 File Offset: 0x000112D4
		public override int ReadByte()
		{
			if (this.Read(this.buf1, 0, 1) <= 0)
			{
				return -1;
			}
			return (int)this.buf1[0];
		}

		// Token: 0x06000347 RID: 839 RVA: 0x000130F1 File Offset: 0x000112F1
		public sealed override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000348 RID: 840 RVA: 0x000130F8 File Offset: 0x000112F8
		public sealed override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000074 RID: 116
		// (get) Token: 0x06000349 RID: 841 RVA: 0x000130FF File Offset: 0x000112FF
		public virtual long TotalIn
		{
			get
			{
				return this.z.total_in;
			}
		}

		// Token: 0x17000075 RID: 117
		// (get) Token: 0x0600034A RID: 842 RVA: 0x0001310C File Offset: 0x0001130C
		public virtual long TotalOut
		{
			get
			{
				return this.z.total_out;
			}
		}

		// Token: 0x0600034B RID: 843 RVA: 0x00013119 File Offset: 0x00011319
		public sealed override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x04000246 RID: 582
		private const int BufferSize = 4096;

		// Token: 0x04000247 RID: 583
		protected global::Org.BouncyCastle.Utilities.Zlib.ZStream z;

		// Token: 0x04000248 RID: 584
		protected int flushLevel;

		// Token: 0x04000249 RID: 585
		protected byte[] buf;

		// Token: 0x0400024A RID: 586
		protected byte[] buf1;

		// Token: 0x0400024B RID: 587
		protected bool compress;

		// Token: 0x0400024C RID: 588
		protected global::System.IO.Stream input;

		// Token: 0x0400024D RID: 589
		protected bool closed;

		// Token: 0x0400024E RID: 590
		private bool nomoreinput;
	}
}
