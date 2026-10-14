using System;
using System.Runtime.InteropServices;

namespace Ionic.Zlib
{
	// Token: 0x0200043E RID: 1086
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d0000D")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	internal sealed class ZlibCodec
	{
		// Token: 0x17000D8D RID: 3469
		// (get) Token: 0x06002EE5 RID: 12005 RVA: 0x000A47E4 File Offset: 0x000A29E4
		public int Adler32
		{
			get
			{
				return (int)this._Adler32;
			}
		}

		// Token: 0x06002EE6 RID: 12006 RVA: 0x000A47EC File Offset: 0x000A29EC
		public ZlibCodec()
		{
		}

		// Token: 0x06002EE7 RID: 12007 RVA: 0x000A4804 File Offset: 0x000A2A04
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

		// Token: 0x06002EE8 RID: 12008 RVA: 0x000A4870 File Offset: 0x000A2A70
		public int InitializeInflate()
		{
			return this.InitializeInflate(this.WindowBits);
		}

		// Token: 0x06002EE9 RID: 12009 RVA: 0x000A4880 File Offset: 0x000A2A80
		public int InitializeInflate(bool expectRfc1950Header)
		{
			return this.InitializeInflate(this.WindowBits, expectRfc1950Header);
		}

		// Token: 0x06002EEA RID: 12010 RVA: 0x000A4890 File Offset: 0x000A2A90
		public int InitializeInflate(int windowBits)
		{
			this.WindowBits = windowBits;
			return this.InitializeInflate(windowBits, true);
		}

		// Token: 0x06002EEB RID: 12011 RVA: 0x000A48A4 File Offset: 0x000A2AA4
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

		// Token: 0x06002EEC RID: 12012 RVA: 0x000A48DC File Offset: 0x000A2ADC
		public int Inflate(global::Ionic.Zlib.FlushType flush)
		{
			if (this.istate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Inflate State!");
			}
			return this.istate.Inflate(flush);
		}

		// Token: 0x06002EED RID: 12013 RVA: 0x000A4900 File Offset: 0x000A2B00
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

		// Token: 0x06002EEE RID: 12014 RVA: 0x000A492C File Offset: 0x000A2B2C
		public int SyncInflate()
		{
			if (this.istate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Inflate State!");
			}
			return this.istate.Sync();
		}

		// Token: 0x06002EEF RID: 12015 RVA: 0x000A4950 File Offset: 0x000A2B50
		public int InitializeDeflate()
		{
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x06002EF0 RID: 12016 RVA: 0x000A495C File Offset: 0x000A2B5C
		public int InitializeDeflate(global::Ionic.Zlib.CompressionLevel level)
		{
			this.CompressLevel = level;
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x06002EF1 RID: 12017 RVA: 0x000A496C File Offset: 0x000A2B6C
		public int InitializeDeflate(global::Ionic.Zlib.CompressionLevel level, bool wantRfc1950Header)
		{
			this.CompressLevel = level;
			return this._InternalInitializeDeflate(wantRfc1950Header);
		}

		// Token: 0x06002EF2 RID: 12018 RVA: 0x000A497C File Offset: 0x000A2B7C
		public int InitializeDeflate(global::Ionic.Zlib.CompressionLevel level, int bits)
		{
			this.CompressLevel = level;
			this.WindowBits = bits;
			return this._InternalInitializeDeflate(true);
		}

		// Token: 0x06002EF3 RID: 12019 RVA: 0x000A4994 File Offset: 0x000A2B94
		public int InitializeDeflate(global::Ionic.Zlib.CompressionLevel level, int bits, bool wantRfc1950Header)
		{
			this.CompressLevel = level;
			this.WindowBits = bits;
			return this._InternalInitializeDeflate(wantRfc1950Header);
		}

		// Token: 0x06002EF4 RID: 12020 RVA: 0x000A49AC File Offset: 0x000A2BAC
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

		// Token: 0x06002EF5 RID: 12021 RVA: 0x000A4A08 File Offset: 0x000A2C08
		public int Deflate(global::Ionic.Zlib.FlushType flush)
		{
			if (this.dstate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Deflate State!");
			}
			return this.dstate.Deflate(flush);
		}

		// Token: 0x06002EF6 RID: 12022 RVA: 0x000A4A2C File Offset: 0x000A2C2C
		public int EndDeflate()
		{
			if (this.dstate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Deflate State!");
			}
			this.dstate = null;
			return 0;
		}

		// Token: 0x06002EF7 RID: 12023 RVA: 0x000A4A4C File Offset: 0x000A2C4C
		public void ResetDeflate()
		{
			if (this.dstate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Deflate State!");
			}
			this.dstate.Reset();
		}

		// Token: 0x06002EF8 RID: 12024 RVA: 0x000A4A70 File Offset: 0x000A2C70
		public int SetDeflateParams(global::Ionic.Zlib.CompressionLevel level, global::Ionic.Zlib.CompressionStrategy strategy)
		{
			if (this.dstate == null)
			{
				throw new global::Ionic.Zlib.ZlibException("No Deflate State!");
			}
			return this.dstate.SetParams(level, strategy);
		}

		// Token: 0x06002EF9 RID: 12025 RVA: 0x000A4A98 File Offset: 0x000A2C98
		public int SetDictionary(byte[] dictionary)
		{
			if (this.istate != null)
			{
				return this.istate.SetDictionary(dictionary);
			}
			if (this.dstate != null)
			{
				return this.dstate.SetDictionary(dictionary);
			}
			throw new global::Ionic.Zlib.ZlibException("No Inflate or Deflate state!");
		}

		// Token: 0x06002EFA RID: 12026 RVA: 0x000A4AD4 File Offset: 0x000A2CD4
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

		// Token: 0x06002EFB RID: 12027 RVA: 0x000A4C38 File Offset: 0x000A2E38
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

		// Token: 0x040010C7 RID: 4295
		public byte[] InputBuffer;

		// Token: 0x040010C8 RID: 4296
		public int NextIn;

		// Token: 0x040010C9 RID: 4297
		public int AvailableBytesIn;

		// Token: 0x040010CA RID: 4298
		public long TotalBytesIn;

		// Token: 0x040010CB RID: 4299
		public byte[] OutputBuffer;

		// Token: 0x040010CC RID: 4300
		public int NextOut;

		// Token: 0x040010CD RID: 4301
		public int AvailableBytesOut;

		// Token: 0x040010CE RID: 4302
		public long TotalBytesOut;

		// Token: 0x040010CF RID: 4303
		public string Message;

		// Token: 0x040010D0 RID: 4304
		internal global::Ionic.Zlib.DeflateManager dstate;

		// Token: 0x040010D1 RID: 4305
		internal global::Ionic.Zlib.InflateManager istate;

		// Token: 0x040010D2 RID: 4306
		internal uint _Adler32;

		// Token: 0x040010D3 RID: 4307
		public global::Ionic.Zlib.CompressionLevel CompressLevel = global::Ionic.Zlib.CompressionLevel.Default;

		// Token: 0x040010D4 RID: 4308
		public int WindowBits = 15;

		// Token: 0x040010D5 RID: 4309
		public global::Ionic.Zlib.CompressionStrategy Strategy;
	}
}
