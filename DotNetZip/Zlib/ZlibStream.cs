using System;
using System.IO;

namespace Ionic.Zlib
{
	// Token: 0x02000028 RID: 40
	public class ZlibStream : global::System.IO.Stream
	{
		// Token: 0x06000130 RID: 304 RVA: 0x0000C2AE File Offset: 0x0000A4AE
		public ZlibStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode) : this(stream, mode, global::Ionic.Zlib.CompressionLevel.Default, false)
		{
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000C2BA File Offset: 0x0000A4BA
		public ZlibStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, global::Ionic.Zlib.CompressionLevel level) : this(stream, mode, level, false)
		{
		}

		// Token: 0x06000132 RID: 306 RVA: 0x0000C2C6 File Offset: 0x0000A4C6
		public ZlibStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, bool leaveOpen) : this(stream, mode, global::Ionic.Zlib.CompressionLevel.Default, leaveOpen)
		{
		}

		// Token: 0x06000133 RID: 307 RVA: 0x0000C2D2 File Offset: 0x0000A4D2
		public ZlibStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, global::Ionic.Zlib.CompressionLevel level, bool leaveOpen)
		{
			this._baseStream = new global::Ionic.Zlib.ZlibBaseStream(stream, mode, level, global::Ionic.Zlib.ZlibStreamFlavor.ZLIB, leaveOpen);
		}

		// Token: 0x17000034 RID: 52
		// (get) Token: 0x06000134 RID: 308 RVA: 0x0000C2EF File Offset: 0x0000A4EF
		// (set) Token: 0x06000135 RID: 309 RVA: 0x0000C2FC File Offset: 0x0000A4FC
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

		// Token: 0x17000035 RID: 53
		// (get) Token: 0x06000136 RID: 310 RVA: 0x0000C31D File Offset: 0x0000A51D
		// (set) Token: 0x06000137 RID: 311 RVA: 0x0000C32C File Offset: 0x0000A52C
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

		// Token: 0x17000036 RID: 54
		// (get) Token: 0x06000138 RID: 312 RVA: 0x0000C398 File Offset: 0x0000A598
		public virtual long TotalIn
		{
			get
			{
				return this._baseStream._z.TotalBytesIn;
			}
		}

		// Token: 0x17000037 RID: 55
		// (get) Token: 0x06000139 RID: 313 RVA: 0x0000C3AA File Offset: 0x0000A5AA
		public virtual long TotalOut
		{
			get
			{
				return this._baseStream._z.TotalBytesOut;
			}
		}

		// Token: 0x0600013A RID: 314 RVA: 0x0000C3BC File Offset: 0x0000A5BC
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
				{
					if (disposing && this._baseStream != null)
					{
						this._baseStream.Dispose();
					}
					this._disposed = true;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x17000038 RID: 56
		// (get) Token: 0x0600013B RID: 315 RVA: 0x0000C408 File Offset: 0x0000A608
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

		// Token: 0x17000039 RID: 57
		// (get) Token: 0x0600013C RID: 316 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700003A RID: 58
		// (get) Token: 0x0600013D RID: 317 RVA: 0x0000C42D File Offset: 0x0000A62D
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

		// Token: 0x0600013E RID: 318 RVA: 0x0000C452 File Offset: 0x0000A652
		public override void Flush()
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("ZlibStream");
			}
			this._baseStream.Flush();
		}

		// Token: 0x1700003B RID: 59
		// (get) Token: 0x0600013F RID: 319 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x1700003C RID: 60
		// (get) Token: 0x06000140 RID: 320 RVA: 0x0000C474 File Offset: 0x0000A674
		// (set) Token: 0x06000141 RID: 321 RVA: 0x0000A809 File Offset: 0x00008A09
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

		// Token: 0x06000142 RID: 322 RVA: 0x0000C4C0 File Offset: 0x0000A6C0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("ZlibStream");
			}
			return this._baseStream.Read(buffer, offset, count);
		}

		// Token: 0x06000143 RID: 323 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000144 RID: 324 RVA: 0x0000A809 File Offset: 0x00008A09
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000145 RID: 325 RVA: 0x0000C4E3 File Offset: 0x0000A6E3
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("ZlibStream");
			}
			this._baseStream.Write(buffer, offset, count);
		}

		// Token: 0x06000146 RID: 326 RVA: 0x0000C508 File Offset: 0x0000A708
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

		// Token: 0x06000147 RID: 327 RVA: 0x0000C550 File Offset: 0x0000A750
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

		// Token: 0x06000148 RID: 328 RVA: 0x0000C598 File Offset: 0x0000A798
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

		// Token: 0x06000149 RID: 329 RVA: 0x0000C5DC File Offset: 0x0000A7DC
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

		// Token: 0x0400016A RID: 362
		internal global::Ionic.Zlib.ZlibBaseStream _baseStream;

		// Token: 0x0400016B RID: 363
		private bool _disposed;
	}
}
