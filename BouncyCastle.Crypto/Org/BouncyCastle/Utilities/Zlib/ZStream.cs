using System;

namespace Org.BouncyCastle.Utilities.Zlib
{
	// Token: 0x0200004A RID: 74
	public sealed class ZStream
	{
		// Token: 0x06000366 RID: 870 RVA: 0x00013542 File Offset: 0x00011742
		public int inflateInit()
		{
			return this.inflateInit(15);
		}

		// Token: 0x06000367 RID: 871 RVA: 0x0001354C File Offset: 0x0001174C
		public int inflateInit(bool nowrap)
		{
			return this.inflateInit(15, nowrap);
		}

		// Token: 0x06000368 RID: 872 RVA: 0x00013557 File Offset: 0x00011757
		public int inflateInit(int w)
		{
			return this.inflateInit(w, false);
		}

		// Token: 0x06000369 RID: 873 RVA: 0x00013561 File Offset: 0x00011761
		public int inflateInit(int w, bool nowrap)
		{
			this.istate = new global::Org.BouncyCastle.Utilities.Zlib.Inflate();
			return this.istate.inflateInit(this, nowrap ? (-w) : w);
		}

		// Token: 0x0600036A RID: 874 RVA: 0x00013582 File Offset: 0x00011782
		public int inflate(int f)
		{
			if (this.istate == null)
			{
				return -2;
			}
			return this.istate.inflate(this, f);
		}

		// Token: 0x0600036B RID: 875 RVA: 0x0001359C File Offset: 0x0001179C
		public int inflateEnd()
		{
			if (this.istate == null)
			{
				return -2;
			}
			int result = this.istate.inflateEnd(this);
			this.istate = null;
			return result;
		}

		// Token: 0x0600036C RID: 876 RVA: 0x000135BC File Offset: 0x000117BC
		public int inflateSync()
		{
			if (this.istate == null)
			{
				return -2;
			}
			return this.istate.inflateSync(this);
		}

		// Token: 0x0600036D RID: 877 RVA: 0x000135D5 File Offset: 0x000117D5
		public int inflateSetDictionary(byte[] dictionary, int dictLength)
		{
			if (this.istate == null)
			{
				return -2;
			}
			return this.istate.inflateSetDictionary(this, dictionary, dictLength);
		}

		// Token: 0x0600036E RID: 878 RVA: 0x000135F0 File Offset: 0x000117F0
		public int deflateInit(int level)
		{
			return this.deflateInit(level, 15);
		}

		// Token: 0x0600036F RID: 879 RVA: 0x000135FB File Offset: 0x000117FB
		public int deflateInit(int level, bool nowrap)
		{
			return this.deflateInit(level, 15, nowrap);
		}

		// Token: 0x06000370 RID: 880 RVA: 0x00013607 File Offset: 0x00011807
		public int deflateInit(int level, int bits)
		{
			return this.deflateInit(level, bits, false);
		}

		// Token: 0x06000371 RID: 881 RVA: 0x00013612 File Offset: 0x00011812
		public int deflateInit(int level, int bits, bool nowrap)
		{
			this.dstate = new global::Org.BouncyCastle.Utilities.Zlib.Deflate();
			return this.dstate.deflateInit(this, level, nowrap ? (-bits) : bits);
		}

		// Token: 0x06000372 RID: 882 RVA: 0x00013634 File Offset: 0x00011834
		public int deflate(int flush)
		{
			if (this.dstate == null)
			{
				return -2;
			}
			return this.dstate.deflate(this, flush);
		}

		// Token: 0x06000373 RID: 883 RVA: 0x0001364E File Offset: 0x0001184E
		public int deflateEnd()
		{
			if (this.dstate == null)
			{
				return -2;
			}
			int result = this.dstate.deflateEnd();
			this.dstate = null;
			return result;
		}

		// Token: 0x06000374 RID: 884 RVA: 0x0001366D File Offset: 0x0001186D
		public int deflateParams(int level, int strategy)
		{
			if (this.dstate == null)
			{
				return -2;
			}
			return this.dstate.deflateParams(this, level, strategy);
		}

		// Token: 0x06000375 RID: 885 RVA: 0x00013688 File Offset: 0x00011888
		public int deflateSetDictionary(byte[] dictionary, int dictLength)
		{
			if (this.dstate == null)
			{
				return -2;
			}
			return this.dstate.deflateSetDictionary(this, dictionary, dictLength);
		}

		// Token: 0x06000376 RID: 886 RVA: 0x000136A4 File Offset: 0x000118A4
		internal void flush_pending()
		{
			int len = this.dstate.pending;
			if (len > this.avail_out)
			{
				len = this.avail_out;
			}
			if (len == 0)
			{
				return;
			}
			if (this.dstate.pending_buf.Length > this.dstate.pending_out && this.next_out.Length > this.next_out_index && this.dstate.pending_buf.Length >= this.dstate.pending_out + len)
			{
				int num = this.next_out.Length;
				int num2 = this.next_out_index + len;
			}
			global::System.Array.Copy(this.dstate.pending_buf, this.dstate.pending_out, this.next_out, this.next_out_index, len);
			this.next_out_index += len;
			this.dstate.pending_out += len;
			this.total_out += (long)len;
			this.avail_out -= len;
			this.dstate.pending -= len;
			if (this.dstate.pending == 0)
			{
				this.dstate.pending_out = 0;
			}
		}

		// Token: 0x06000377 RID: 887 RVA: 0x000137BC File Offset: 0x000119BC
		internal int read_buf(byte[] buf, int start, int size)
		{
			int len = this.avail_in;
			if (len > size)
			{
				len = size;
			}
			if (len == 0)
			{
				return 0;
			}
			this.avail_in -= len;
			if (this.dstate.noheader == 0)
			{
				this.adler = this._adler.adler32(this.adler, this.next_in, this.next_in_index, len);
			}
			global::System.Array.Copy(this.next_in, this.next_in_index, buf, start, len);
			this.next_in_index += len;
			this.total_in += (long)len;
			return len;
		}

		// Token: 0x06000378 RID: 888 RVA: 0x0001384C File Offset: 0x00011A4C
		public void free()
		{
			this.next_in = null;
			this.next_out = null;
			this.msg = null;
			this._adler = null;
		}

		// Token: 0x04000257 RID: 599
		private const int MAX_WBITS = 15;

		// Token: 0x04000258 RID: 600
		private const int DEF_WBITS = 15;

		// Token: 0x04000259 RID: 601
		private const int Z_NO_FLUSH = 0;

		// Token: 0x0400025A RID: 602
		private const int Z_PARTIAL_FLUSH = 1;

		// Token: 0x0400025B RID: 603
		private const int Z_SYNC_FLUSH = 2;

		// Token: 0x0400025C RID: 604
		private const int Z_FULL_FLUSH = 3;

		// Token: 0x0400025D RID: 605
		private const int Z_FINISH = 4;

		// Token: 0x0400025E RID: 606
		private const int MAX_MEM_LEVEL = 9;

		// Token: 0x0400025F RID: 607
		private const int Z_OK = 0;

		// Token: 0x04000260 RID: 608
		private const int Z_STREAM_END = 1;

		// Token: 0x04000261 RID: 609
		private const int Z_NEED_DICT = 2;

		// Token: 0x04000262 RID: 610
		private const int Z_ERRNO = -1;

		// Token: 0x04000263 RID: 611
		private const int Z_STREAM_ERROR = -2;

		// Token: 0x04000264 RID: 612
		private const int Z_DATA_ERROR = -3;

		// Token: 0x04000265 RID: 613
		private const int Z_MEM_ERROR = -4;

		// Token: 0x04000266 RID: 614
		private const int Z_BUF_ERROR = -5;

		// Token: 0x04000267 RID: 615
		private const int Z_VERSION_ERROR = -6;

		// Token: 0x04000268 RID: 616
		public byte[] next_in;

		// Token: 0x04000269 RID: 617
		public int next_in_index;

		// Token: 0x0400026A RID: 618
		public int avail_in;

		// Token: 0x0400026B RID: 619
		public long total_in;

		// Token: 0x0400026C RID: 620
		public byte[] next_out;

		// Token: 0x0400026D RID: 621
		public int next_out_index;

		// Token: 0x0400026E RID: 622
		public int avail_out;

		// Token: 0x0400026F RID: 623
		public long total_out;

		// Token: 0x04000270 RID: 624
		public string msg;

		// Token: 0x04000271 RID: 625
		internal global::Org.BouncyCastle.Utilities.Zlib.Deflate dstate;

		// Token: 0x04000272 RID: 626
		internal global::Org.BouncyCastle.Utilities.Zlib.Inflate istate;

		// Token: 0x04000273 RID: 627
		internal int data_type;

		// Token: 0x04000274 RID: 628
		public long adler;

		// Token: 0x04000275 RID: 629
		internal global::Org.BouncyCastle.Utilities.Zlib.Adler32 _adler = new global::Org.BouncyCastle.Utilities.Zlib.Adler32();
	}
}
