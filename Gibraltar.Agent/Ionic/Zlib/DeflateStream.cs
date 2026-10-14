using System;
using System.IO;

namespace Ionic.Zlib
{
	// Token: 0x02000429 RID: 1065
	internal class DeflateStream : global::System.IO.Stream
	{
		// Token: 0x06002E36 RID: 11830 RVA: 0x0009E0F0 File Offset: 0x0009C2F0
		public DeflateStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode) : this(stream, mode, global::Ionic.Zlib.CompressionLevel.Default, false)
		{
		}

		// Token: 0x06002E37 RID: 11831 RVA: 0x0009E0FC File Offset: 0x0009C2FC
		public DeflateStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, global::Ionic.Zlib.CompressionLevel level) : this(stream, mode, level, false)
		{
		}

		// Token: 0x06002E38 RID: 11832 RVA: 0x0009E108 File Offset: 0x0009C308
		public DeflateStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, bool leaveOpen) : this(stream, mode, global::Ionic.Zlib.CompressionLevel.Default, leaveOpen)
		{
		}

		// Token: 0x06002E39 RID: 11833 RVA: 0x0009E114 File Offset: 0x0009C314
		public DeflateStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, global::Ionic.Zlib.CompressionLevel level, bool leaveOpen)
		{
			this._innerStream = stream;
			this._baseStream = new global::Ionic.Zlib.ZlibBaseStream(stream, mode, level, global::Ionic.Zlib.ZlibStreamFlavor.DEFLATE, leaveOpen);
		}

		// Token: 0x17000D63 RID: 3427
		// (get) Token: 0x06002E3A RID: 11834 RVA: 0x0009E138 File Offset: 0x0009C338
		// (set) Token: 0x06002E3B RID: 11835 RVA: 0x0009E148 File Offset: 0x0009C348
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
					throw new global::System.ObjectDisposedException("DeflateStream");
				}
				this._baseStream._flushMode = value;
			}
		}

		// Token: 0x17000D64 RID: 3428
		// (get) Token: 0x06002E3C RID: 11836 RVA: 0x0009E16C File Offset: 0x0009C36C
		// (set) Token: 0x06002E3D RID: 11837 RVA: 0x0009E17C File Offset: 0x0009C37C
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
					throw new global::System.ObjectDisposedException("DeflateStream");
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

		// Token: 0x17000D65 RID: 3429
		// (get) Token: 0x06002E3E RID: 11838 RVA: 0x0009E1F8 File Offset: 0x0009C3F8
		// (set) Token: 0x06002E3F RID: 11839 RVA: 0x0009E208 File Offset: 0x0009C408
		public global::Ionic.Zlib.CompressionStrategy Strategy
		{
			get
			{
				return this._baseStream.Strategy;
			}
			set
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("DeflateStream");
				}
				this._baseStream.Strategy = value;
			}
		}

		// Token: 0x17000D66 RID: 3430
		// (get) Token: 0x06002E40 RID: 11840 RVA: 0x0009E22C File Offset: 0x0009C42C
		public virtual long TotalIn
		{
			get
			{
				return this._baseStream._z.TotalBytesIn;
			}
		}

		// Token: 0x17000D67 RID: 3431
		// (get) Token: 0x06002E41 RID: 11841 RVA: 0x0009E240 File Offset: 0x0009C440
		public virtual long TotalOut
		{
			get
			{
				return this._baseStream._z.TotalBytesOut;
			}
		}

		// Token: 0x06002E42 RID: 11842 RVA: 0x0009E254 File Offset: 0x0009C454
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

		// Token: 0x17000D68 RID: 3432
		// (get) Token: 0x06002E43 RID: 11843 RVA: 0x0009E2AC File Offset: 0x0009C4AC
		public override bool CanRead
		{
			get
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("DeflateStream");
				}
				return this._baseStream._stream.CanRead;
			}
		}

		// Token: 0x17000D69 RID: 3433
		// (get) Token: 0x06002E44 RID: 11844 RVA: 0x0009E2D4 File Offset: 0x0009C4D4
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000D6A RID: 3434
		// (get) Token: 0x06002E45 RID: 11845 RVA: 0x0009E2D8 File Offset: 0x0009C4D8
		public override bool CanWrite
		{
			get
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("DeflateStream");
				}
				return this._baseStream._stream.CanWrite;
			}
		}

		// Token: 0x06002E46 RID: 11846 RVA: 0x0009E300 File Offset: 0x0009C500
		public override void Flush()
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("DeflateStream");
			}
			this._baseStream.Flush();
		}

		// Token: 0x17000D6B RID: 3435
		// (get) Token: 0x06002E47 RID: 11847 RVA: 0x0009E324 File Offset: 0x0009C524
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000D6C RID: 3436
		// (get) Token: 0x06002E48 RID: 11848 RVA: 0x0009E32C File Offset: 0x0009C52C
		// (set) Token: 0x06002E49 RID: 11849 RVA: 0x0009E384 File Offset: 0x0009C584
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
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06002E4A RID: 11850 RVA: 0x0009E38C File Offset: 0x0009C58C
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("DeflateStream");
			}
			return this._baseStream.Read(buffer, offset, count);
		}

		// Token: 0x06002E4B RID: 11851 RVA: 0x0009E3B4 File Offset: 0x0009C5B4
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002E4C RID: 11852 RVA: 0x0009E3BC File Offset: 0x0009C5BC
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002E4D RID: 11853 RVA: 0x0009E3C4 File Offset: 0x0009C5C4
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("DeflateStream");
			}
			this._baseStream.Write(buffer, offset, count);
		}

		// Token: 0x06002E4E RID: 11854 RVA: 0x0009E3EC File Offset: 0x0009C5EC
		public static byte[] CompressString(string s)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.Stream compressor = new global::Ionic.Zlib.DeflateStream(memoryStream, global::Ionic.Zlib.CompressionMode.Compress, global::Ionic.Zlib.CompressionLevel.BestCompression);
				global::Ionic.Zlib.ZlibBaseStream.CompressString(s, compressor);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06002E4F RID: 11855 RVA: 0x0009E43C File Offset: 0x0009C63C
		public static byte[] CompressBuffer(byte[] b)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.Stream compressor = new global::Ionic.Zlib.DeflateStream(memoryStream, global::Ionic.Zlib.CompressionMode.Compress, global::Ionic.Zlib.CompressionLevel.BestCompression);
				global::Ionic.Zlib.ZlibBaseStream.CompressBuffer(b, compressor);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06002E50 RID: 11856 RVA: 0x0009E48C File Offset: 0x0009C68C
		public static string UncompressString(byte[] compressed)
		{
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(compressed))
			{
				global::System.IO.Stream decompressor = new global::Ionic.Zlib.DeflateStream(memoryStream, global::Ionic.Zlib.CompressionMode.Decompress);
				result = global::Ionic.Zlib.ZlibBaseStream.UncompressString(compressed, decompressor);
			}
			return result;
		}

		// Token: 0x06002E51 RID: 11857 RVA: 0x0009E4D4 File Offset: 0x0009C6D4
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(compressed))
			{
				global::System.IO.Stream decompressor = new global::Ionic.Zlib.DeflateStream(memoryStream, global::Ionic.Zlib.CompressionMode.Decompress);
				result = global::Ionic.Zlib.ZlibBaseStream.UncompressBuffer(compressed, decompressor);
			}
			return result;
		}

		// Token: 0x04000FED RID: 4077
		internal global::Ionic.Zlib.ZlibBaseStream _baseStream;

		// Token: 0x04000FEE RID: 4078
		internal global::System.IO.Stream _innerStream;

		// Token: 0x04000FEF RID: 4079
		private bool _disposed;
	}
}
