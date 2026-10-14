using System;
using System.Runtime.InteropServices;

namespace Ionic.Zlib
{
	// Token: 0x02000026 RID: 38
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	public sealed class ZlibCodec
	{
		// Token: 0x17000033 RID: 51
		// (get) Token: 0x06000118 RID: 280 RVA: 0x0000BDF8 File Offset: 0x00009FF8
		public int Adler32
		{
			get
			{
				return (int)this._Adler32;
			}
		}

		// Token: 0x06000119 RID: 281 RVA: 0x0000BE00 File Offset: 0x0000A000
		public ZlibCodec()
		{
		}

		// Token: 0x0600011A RID: 282 RVA: 0x0000BE18 File Offset: 0x0000A018
		public ZlibCodec(global::Ionic.Zlib.CompressionMode mode)
		{
			if (mode == global::Ionic.Zlib.CompressionMode.Compress)
			{
				if (this.InitializeDeflate() != 0)
				{
					throw new global::Ionic.Zlib.ZlibException("Cannot initialize for deflate.");
				}
			}
			else
			{
				if (mode != global::Ionic.Zlib.CompressionMode.Decompress)
				{
					throw new global::Ionic.Zlib.ZlibException("Invalid ZlibStreamFlavor.");
				}
				if (this.InitializeInflate() != 0)
				{
					throw new global::Ionic.Zlib.ZlibException("Cannot initialize for inflate.");
				}
			}
		}

		// Token: 0x0600011B RID: 283 RVA: 0x0000BE72 File Offset: 0x0000A072
		public int InitializeInflate()
		{
			return this.InitializeInflate(this.WindowBits);
		}

		// Token: 0x0600011C RID: 284 RVA: 0x0000BE80 File Offset: 0x0000A080
		public int InitializeInflate(bool expectRfc1950Header)
		{
			return this.InitializeInflate(this.WindowBits, expectRfc1950Header);
		}

		// Token: 0x0600011D RID: 285 RVA: 0x0000BE8F File Offset: 0x0000A08F
		public int InitializeInflate(int windowBits)
		{
			this.WindowBits = windowBits;
			return this.InitializeInflate(windowBits, true);
		}

		// Token: 0x0600011E RID: 286 RVA: 0x0000BEA0 File Offset: 0x0000A0A0
		public int InitializeInflate(int windowBits, bool expectRfc1950Header)
		{
			this.WindowBits = windowBits;
			if (this.dstate != null)
			{
				throw new global::Ionic.Zlib.ZlibException("You may not call InitializeInflate() after calling InitializeDeflate().");
			}
			this.istate = new global::Ionic.Zlib.InflateManager(expectRfc1950Header);
			return this.istate.Initialize(this, windowBits);
		}

		// Token: 0x0600011F RID: 287 RVA: 0x0000BED5 File Offset: 0x0000A0D5
		public int Inflate(global::Ionic.Zlib.FlushType flush)
		{
			if (this.istate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Inflate State!");
			}
			return this.istate.Inflate(flush);
		}

		// Token: 0x06000120 RID: 288 RVA: 0x0000BEF6 File Offset: 0x0000A0F6
		public int EndInflate()
		{
			if (this.istate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Inflate State!");
			}
			int result = this.istate.End();
			this.istate = null;
			return result;
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000BF1D File Offset: 0x0000A11D
		public int SyncInflate()
		{
			if (this.istate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Inflate State!");
			}
			return this.istate.Sync();
		}

		// Token: 0x06000122 RID: 290 RVA: 0x0000BF3D File Offset: 0x0000A13D
		public int InitializeDeflate()
		{
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x06000123 RID: 291 RVA: 0x0000BF46 File Offset: 0x0000A146
		public int InitializeDeflate(global::Ionic.Zlib.CompressionLevel level)
		{
			this.CompressLevel = level;
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000BF56 File Offset: 0x0000A156
		public int InitializeDeflate(global::Ionic.Zlib.CompressionLevel level, bool wantRfc1950Header)
		{
			this.CompressLevel = level;
			return this._InternalInitializeDeflate(wantRfc1950Header);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000BF66 File Offset: 0x0000A166
		public int InitializeDeflate(global::Ionic.Zlib.CompressionLevel level, int bits)
		{
			this.CompressLevel = level;
			this.WindowBits = bits;
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000BF7D File Offset: 0x0000A17D
		public int InitializeDeflate(global::Ionic.Zlib.CompressionLevel level, int bits, bool wantRfc1950Header)
		{
			this.CompressLevel = level;
			this.WindowBits = bits;
			return this._InternalInitializeDeflate(wantRfc1950Header);
		}

		// Token: 0x06000127 RID: 295 RVA: 0x0000BF94 File Offset: 0x0000A194
		private int _InternalInitializeDeflate(bool wantRfc1950Header)
		{
			if (this.istate != null)
			{
				throw new global::Ionic.Zlib.ZlibException("You may not call InitializeDeflate() after calling InitializeInflate().");
			}
			this.dstate = new global::Ionic.Zlib.DeflateManager();
			this.dstate.WantRfc1950HeaderBytes = wantRfc1950Header;
			return this.dstate.Initialize(this, this.CompressLevel, this.WindowBits, this.Strategy);
		}

		// Token: 0x06000128 RID: 296 RVA: 0x0000BFE9 File Offset: 0x0000A1E9
		public int Deflate(global::Ionic.Zlib.FlushType flush)
		{
			if (this.dstate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Deflate State!");
			}
			return this.dstate.Deflate(flush);
		}

		// Token: 0x06000129 RID: 297 RVA: 0x0000C00A File Offset: 0x0000A20A
		public int EndDeflate()
		{
			if (this.dstate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Deflate State!");
			}
			this.dstate = null;
			return 0;
		}

		// Token: 0x0600012A RID: 298 RVA: 0x0000C027 File Offset: 0x0000A227
		public void ResetDeflate()
		{
			if (this.dstate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Deflate State!");
			}
			this.dstate.Reset();
		}

		// Token: 0x0600012B RID: 299 RVA: 0x0000C047 File Offset: 0x0000A247
		public int SetDeflateParams(global::Ionic.Zlib.CompressionLevel level, global::Ionic.Zlib.CompressionStrategy strategy)
		{
			if (this.dstate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Deflate State!");
			}
			return this.dstate.SetParams(level, strategy);
		}

		// Token: 0x0600012C RID: 300 RVA: 0x0000C069 File Offset: 0x0000A269
		public int SetDictionary(byte[] dictionary)
		{
			if (this.istate != null)
			{
				return this.istate.SetDictionary(dictionary, false);
			}
			if (this.dstate != null)
			{
				return this.dstate.SetDictionary(dictionary);
			}
			throw new global::Ionic.Zlib.ZlibException("No Inflate or Deflate state!");
		}

		// Token: 0x0600012D RID: 301 RVA: 0x0000C0A0 File Offset: 0x0000A2A0
		public int SetDictionaryUnconditionally(byte[] dictionary)
		{
			if (this.istate != null)
			{
				return this.istate.SetDictionary(dictionary, true);
			}
			if (this.dstate != null)
			{
				return this.dstate.SetDictionary(dictionary);
			}
			throw new global::Ionic.Zlib.ZlibException("No Inflate or Deflate state!");
		}

		// Token: 0x0600012E RID: 302 RVA: 0x0000C0D8 File Offset: 0x0000A2D8
		internal void flush_pending()
		{
			int num = this.dstate.pendingCount;
			if (num > this.AvailableBytesOut)
			{
				num = this.AvailableBytesOut;
			}
			if (num == 0)
			{
				return;
			}
			if (this.dstate.pending.Length <= this.dstate.nextPending || this.OutputBuffer.Length <= this.NextOut || this.dstate.pending.Length < this.dstate.nextPending + num || this.OutputBuffer.Length < this.NextOut + num)
			{
				throw new global::Ionic.Zlib.ZlibException(string.Format("Invalid State. (pending.Length={0}, pendingCount={1})", this.dstate.pending.Length, this.dstate.pendingCount));
			}
			global::System.Array.Copy(this.dstate.pending, this.dstate.nextPending, this.OutputBuffer, this.NextOut, num);
			this.NextOut += num;
			this.dstate.nextPending += num;
			this.TotalBytesOut += (long)num;
			this.AvailableBytesOut -= num;
			this.dstate.pendingCount -= num;
			if (this.dstate.pendingCount == 0)
			{
				this.dstate.nextPending = 0;
			}
		}

		// Token: 0x0600012F RID: 303 RVA: 0x0000C224 File Offset: 0x0000A424
		internal int read_buf(byte[] buf, int start, int size)
		{
			int num = this.AvailableBytesIn;
			if (num > size)
			{
				num = size;
			}
			if (num == 0)
			{
				return 0;
			}
			this.AvailableBytesIn -= num;
			if (this.dstate.WantRfc1950HeaderBytes)
			{
				this._Adler32 = global::Ionic.Zlib.Adler.Adler32(this._Adler32, this.InputBuffer, this.NextIn, num);
			}
			global::System.Array.Copy(this.InputBuffer, this.NextIn, buf, start, num);
			this.NextIn += num;
			this.TotalBytesIn += (long)num;
			return num;
		}

		// Token: 0x04000151 RID: 337
		public byte[] InputBuffer;

		// Token: 0x04000152 RID: 338
		public int NextIn;

		// Token: 0x04000153 RID: 339
		public int AvailableBytesIn;

		// Token: 0x04000154 RID: 340
		public long TotalBytesIn;

		// Token: 0x04000155 RID: 341
		public byte[] OutputBuffer;

		// Token: 0x04000156 RID: 342
		public int NextOut;

		// Token: 0x04000157 RID: 343
		public int AvailableBytesOut;

		// Token: 0x04000158 RID: 344
		public long TotalBytesOut;

		// Token: 0x04000159 RID: 345
		public string Message;

		// Token: 0x0400015A RID: 346
		internal global::Ionic.Zlib.DeflateManager dstate;

		// Token: 0x0400015B RID: 347
		internal global::Ionic.Zlib.InflateManager istate;

		// Token: 0x0400015C RID: 348
		internal uint _Adler32;

		// Token: 0x0400015D RID: 349
		public global::Ionic.Zlib.CompressionLevel CompressLevel = global::Ionic.Zlib.CompressionLevel.Default;

		// Token: 0x0400015E RID: 350
		public int WindowBits = 15;

		// Token: 0x0400015F RID: 351
		public global::Ionic.Zlib.CompressionStrategy Strategy;
	}
}
