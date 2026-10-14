using System;
using System.IO;

namespace Ionic.Zlib
{
	// Token: 0x02000440 RID: 1088
	internal class ZlibStream : global::System.IO.Stream
	{
		// Token: 0x06002EFC RID: 12028 RVA: 0x000A4CD0 File Offset: 0x000A2ED0
		public ZlibStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode) : this(stream, mode, global::Ionic.Zlib.CompressionLevel.Default, false)
		{
		}

		// Token: 0x06002EFD RID: 12029 RVA: 0x000A4CDC File Offset: 0x000A2EDC
		public ZlibStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, global::Ionic.Zlib.CompressionLevel level) : this(stream, mode, level, false)
		{
		}

		// Token: 0x06002EFE RID: 12030 RVA: 0x000A4CE8 File Offset: 0x000A2EE8
		public ZlibStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, bool leaveOpen) : this(stream, mode, global::Ionic.Zlib.CompressionLevel.Default, leaveOpen)
		{
		}

		// Token: 0x06002EFF RID: 12031 RVA: 0x000A4CF4 File Offset: 0x000A2EF4
		public ZlibStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, global::Ionic.Zlib.CompressionLevel level, bool leaveOpen)
		{
			this._baseStream = new global::Ionic.Zlib.ZlibBaseStream(stream, mode, level, global::Ionic.Zlib.ZlibStreamFlavor.ZLIB, leaveOpen);
		}

		// Token: 0x17000D8E RID: 3470
		// (get) Token: 0x06002F00 RID: 12032 RVA: 0x000A4D14 File Offset: 0x000A2F14
		// (set) Token: 0x06002F01 RID: 12033 RVA: 0x000A4D24 File Offset: 0x000A2F24
		public virtual global::Ionic.Zlib.FlushType FlushMode
		{
			get
			{
				return this._baseStream._flushMode;
			}
			set
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("ZlibStream");
				}
				this._baseStream._flushMode = value;
			}
		}

		// Token: 0x17000D8F RID: 3471
		// (get) Token: 0x06002F02 RID: 12034 RVA: 0x000A4D48 File Offset: 0x000A2F48
		// (set) Token: 0x06002F03 RID: 12035 RVA: 0x000A4D58 File Offset: 0x000A2F58
		public int BufferSize
		{
			get
			{
				return this._baseStream._bufferSize;
			}
			set
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("ZlibStream");
				}
				if (this._baseStream._workingBuffer != null)
				{
					throw new global::Ionic.Zlib.ZlibException("The working buffer is already set.");
				}
				if (value < 1024)
				{
					throw new global::Ionic.Zlib.ZlibException(string.Format("Don't be silly. {0} bytes?? Use a bigger buffer, at least {1}.", value, 1024));
				}
				this._baseStream._bufferSize = value;
			}
		}

		// Token: 0x17000D90 RID: 3472
		// (get) Token: 0x06002F04 RID: 12036 RVA: 0x000A4DD4 File Offset: 0x000A2FD4
		public virtual long TotalIn
		{
			get
			{
				return this._baseStream._z.TotalBytesIn;
			}
		}

		// Token: 0x17000D91 RID: 3473
		// (get) Token: 0x06002F05 RID: 12037 RVA: 0x000A4DE8 File Offset: 0x000A2FE8
		public virtual long TotalOut
		{
			get
			{
				return this._baseStream._z.TotalBytesOut;
			}
		}

		// Token: 0x06002F06 RID: 12038 RVA: 0x000A4DFC File Offset: 0x000A2FFC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
				{
					if (disposing && this._baseStream != null)
					{
						this._baseStream.Close();
					}
					this._disposed = true;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x17000D92 RID: 3474
		// (get) Token: 0x06002F07 RID: 12039 RVA: 0x000A4E54 File Offset: 0x000A3054
		public override bool CanRead
		{
			get
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("ZlibStream");
				}
				return this._baseStream._stream.CanRead;
			}
		}

		// Token: 0x17000D93 RID: 3475
		// (get) Token: 0x06002F08 RID: 12040 RVA: 0x000A4E7C File Offset: 0x000A307C
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000D94 RID: 3476
		// (get) Token: 0x06002F09 RID: 12041 RVA: 0x000A4E80 File Offset: 0x000A3080
		public override bool CanWrite
		{
			get
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("ZlibStream");
				}
				return this._baseStream._stream.CanWrite;
			}
		}

		// Token: 0x06002F0A RID: 12042 RVA: 0x000A4EA8 File Offset: 0x000A30A8
		public override void Flush()
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("ZlibStream");
			}
			this._baseStream.Flush();
		}

		// Token: 0x17000D95 RID: 3477
		// (get) Token: 0x06002F0B RID: 12043 RVA: 0x000A4ECC File Offset: 0x000A30CC
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000D96 RID: 3478
		// (get) Token: 0x06002F0C RID: 12044 RVA: 0x000A4ED4 File Offset: 0x000A30D4
		// (set) Token: 0x06002F0D RID: 12045 RVA: 0x000A4F2C File Offset: 0x000A312C
		public override long Position
		{
			get
			{
				if (this._baseStream._streamMode == global::Ionic.Zlib.ZlibBaseStream.StreamMode.Writer)
				{
					return this._baseStream._z.TotalBytesOut;
				}
				if (this._baseStream._streamMode == global::Ionic.Zlib.ZlibBaseStream.StreamMode.Reader)
				{
					return this._baseStream._z.TotalBytesIn;
				}
				return 0L;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06002F0E RID: 12046 RVA: 0x000A4F34 File Offset: 0x000A3134
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("ZlibStream");
			}
			return this._baseStream.Read(buffer, offset, count);
		}

		// Token: 0x06002F0F RID: 12047 RVA: 0x000A4F5C File Offset: 0x000A315C
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002F10 RID: 12048 RVA: 0x000A4F64 File Offset: 0x000A3164
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002F11 RID: 12049 RVA: 0x000A4F6C File Offset: 0x000A316C
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("ZlibStream");
			}
			this._baseStream.Write(buffer, offset, count);
		}

		// Token: 0x06002F12 RID: 12050 RVA: 0x000A4F94 File Offset: 0x000A3194
		public static byte[] CompressString(string s)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.Stream compressor = new global::Ionic.Zlib.ZlibStream(memoryStream, global::Ionic.Zlib.CompressionMode.Compress, global::Ionic.Zlib.CompressionLevel.BestCompression);
				global::Ionic.Zlib.ZlibBaseStream.CompressString(s, compressor);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06002F13 RID: 12051 RVA: 0x000A4FE4 File Offset: 0x000A31E4
		public static byte[] CompressBuffer(byte[] b)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.Stream compressor = new global::Ionic.Zlib.ZlibStream(memoryStream, global::Ionic.Zlib.CompressionMode.Compress, global::Ionic.Zlib.CompressionLevel.BestCompression);
				global::Ionic.Zlib.ZlibBaseStream.CompressBuffer(b, compressor);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06002F14 RID: 12052 RVA: 0x000A5034 File Offset: 0x000A3234
		public static string UncompressString(byte[] compressed)
		{
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(compressed))
			{
				global::System.IO.Stream decompressor = new global::Ionic.Zlib.ZlibStream(memoryStream, global::Ionic.Zlib.CompressionMode.Decompress);
				result = global::Ionic.Zlib.ZlibBaseStream.UncompressString(compressed, decompressor);
			}
			return result;
		}

		// Token: 0x06002F15 RID: 12053 RVA: 0x000A507C File Offset: 0x000A327C
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(compressed))
			{
				global::System.IO.Stream decompressor = new global::Ionic.Zlib.ZlibStream(memoryStream, global::Ionic.Zlib.CompressionMode.Decompress);
				result = global::Ionic.Zlib.ZlibBaseStream.UncompressBuffer(compressed, decompressor);
			}
			return result;
		}

		// Token: 0x040010E0 RID: 4320
		internal global::Ionic.Zlib.ZlibBaseStream _baseStream;

		// Token: 0x040010E1 RID: 4321
		private bool _disposed;
	}
}
