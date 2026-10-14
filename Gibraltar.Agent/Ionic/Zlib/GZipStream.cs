using System;
using System.IO;
using System.Text;

namespace Ionic.Zlib
{
	// Token: 0x0200042A RID: 1066
	internal class GZipStream : global::System.IO.Stream
	{
		// Token: 0x17000D6D RID: 3437
		// (get) Token: 0x06002E52 RID: 11858 RVA: 0x0009E51C File Offset: 0x0009C71C
		// (set) Token: 0x06002E53 RID: 11859 RVA: 0x0009E524 File Offset: 0x0009C724
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("GZipStream");
				}
				this._Comment = value;
			}
		}

		// Token: 0x17000D6E RID: 3438
		// (get) Token: 0x06002E54 RID: 11860 RVA: 0x0009E544 File Offset: 0x0009C744
		// (set) Token: 0x06002E55 RID: 11861 RVA: 0x0009E54C File Offset: 0x0009C74C
		public string FileName
		{
			get
			{
				return this._FileName;
			}
			set
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("GZipStream");
				}
				this._FileName = value;
				if (this._FileName == null)
				{
					return;
				}
				if (this._FileName.IndexOf("/") != -1)
				{
					this._FileName = this._FileName.Replace("/", "\\");
				}
				if (this._FileName.EndsWith("\\"))
				{
					throw new global::System.Exception("Illegal filename");
				}
				if (this._FileName.IndexOf("\\") != -1)
				{
					this._FileName = global::System.IO.Path.GetFileName(this._FileName);
				}
			}
		}

		// Token: 0x17000D6F RID: 3439
		// (get) Token: 0x06002E56 RID: 11862 RVA: 0x0009E600 File Offset: 0x0009C800
		public int Crc32
		{
			get
			{
				return this._Crc32;
			}
		}

		// Token: 0x06002E57 RID: 11863 RVA: 0x0009E608 File Offset: 0x0009C808
		public GZipStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode) : this(stream, mode, global::Ionic.Zlib.CompressionLevel.Default, false)
		{
		}

		// Token: 0x06002E58 RID: 11864 RVA: 0x0009E614 File Offset: 0x0009C814
		public GZipStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, global::Ionic.Zlib.CompressionLevel level) : this(stream, mode, level, false)
		{
		}

		// Token: 0x06002E59 RID: 11865 RVA: 0x0009E620 File Offset: 0x0009C820
		public GZipStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, bool leaveOpen) : this(stream, mode, global::Ionic.Zlib.CompressionLevel.Default, leaveOpen)
		{
		}

		// Token: 0x06002E5A RID: 11866 RVA: 0x0009E62C File Offset: 0x0009C82C
		public GZipStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode mode, global::Ionic.Zlib.CompressionLevel level, bool leaveOpen)
		{
			this._baseStream = new global::Ionic.Zlib.ZlibBaseStream(stream, mode, level, global::Ionic.Zlib.ZlibStreamFlavor.GZIP, leaveOpen);
		}

		// Token: 0x17000D70 RID: 3440
		// (get) Token: 0x06002E5B RID: 11867 RVA: 0x0009E64C File Offset: 0x0009C84C
		// (set) Token: 0x06002E5C RID: 11868 RVA: 0x0009E65C File Offset: 0x0009C85C
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
					throw new global::System.ObjectDisposedException("GZipStream");
				}
				this._baseStream._flushMode = value;
			}
		}

		// Token: 0x17000D71 RID: 3441
		// (get) Token: 0x06002E5D RID: 11869 RVA: 0x0009E680 File Offset: 0x0009C880
		// (set) Token: 0x06002E5E RID: 11870 RVA: 0x0009E690 File Offset: 0x0009C890
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
					throw new global::System.ObjectDisposedException("GZipStream");
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

		// Token: 0x17000D72 RID: 3442
		// (get) Token: 0x06002E5F RID: 11871 RVA: 0x0009E70C File Offset: 0x0009C90C
		public virtual long TotalIn
		{
			get
			{
				return this._baseStream._z.TotalBytesIn;
			}
		}

		// Token: 0x17000D73 RID: 3443
		// (get) Token: 0x06002E60 RID: 11872 RVA: 0x0009E720 File Offset: 0x0009C920
		public virtual long TotalOut
		{
			get
			{
				return this._baseStream._z.TotalBytesOut;
			}
		}

		// Token: 0x06002E61 RID: 11873 RVA: 0x0009E734 File Offset: 0x0009C934
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (!this._disposed)
				{
					if (disposing && this._baseStream != null)
					{
						this._baseStream.Close();
						this._Crc32 = this._baseStream.Crc32;
					}
					this._disposed = true;
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x17000D74 RID: 3444
		// (get) Token: 0x06002E62 RID: 11874 RVA: 0x0009E7A0 File Offset: 0x0009C9A0
		public override bool CanRead
		{
			get
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("GZipStream");
				}
				return this._baseStream._stream.CanRead;
			}
		}

		// Token: 0x17000D75 RID: 3445
		// (get) Token: 0x06002E63 RID: 11875 RVA: 0x0009E7C8 File Offset: 0x0009C9C8
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000D76 RID: 3446
		// (get) Token: 0x06002E64 RID: 11876 RVA: 0x0009E7CC File Offset: 0x0009C9CC
		public override bool CanWrite
		{
			get
			{
				if (this._disposed)
				{
					throw new global::System.ObjectDisposedException("GZipStream");
				}
				return this._baseStream._stream.CanWrite;
			}
		}

		// Token: 0x06002E65 RID: 11877 RVA: 0x0009E7F4 File Offset: 0x0009C9F4
		public override void Flush()
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("GZipStream");
			}
			this._baseStream.Flush();
		}

		// Token: 0x17000D77 RID: 3447
		// (get) Token: 0x06002E66 RID: 11878 RVA: 0x0009E818 File Offset: 0x0009CA18
		public override long Length
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000D78 RID: 3448
		// (get) Token: 0x06002E67 RID: 11879 RVA: 0x0009E820 File Offset: 0x0009CA20
		// (set) Token: 0x06002E68 RID: 11880 RVA: 0x0009E88C File Offset: 0x0009CA8C
		public override long Position
		{
			get
			{
				if (this._baseStream._streamMode == global::Ionic.Zlib.ZlibBaseStream.StreamMode.Writer)
				{
					return this._baseStream._z.TotalBytesOut + (long)this._headerByteCount;
				}
				if (this._baseStream._streamMode == global::Ionic.Zlib.ZlibBaseStream.StreamMode.Reader)
				{
					return this._baseStream._z.TotalBytesIn + (long)this._baseStream._gzipHeaderByteCount;
				}
				return 0L;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06002E69 RID: 11881 RVA: 0x0009E894 File Offset: 0x0009CA94
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("GZipStream");
			}
			int result = this._baseStream.Read(buffer, offset, count);
			if (!this._firstReadDone)
			{
				this._firstReadDone = true;
				this.FileName = this._baseStream._GzipFileName;
				this.Comment = this._baseStream._GzipComment;
			}
			return result;
		}

		// Token: 0x06002E6A RID: 11882 RVA: 0x0009E900 File Offset: 0x0009CB00
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002E6B RID: 11883 RVA: 0x0009E908 File Offset: 0x0009CB08
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002E6C RID: 11884 RVA: 0x0009E910 File Offset: 0x0009CB10
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this._disposed)
			{
				throw new global::System.ObjectDisposedException("GZipStream");
			}
			if (this._baseStream._streamMode == global::Ionic.Zlib.ZlibBaseStream.StreamMode.Undefined)
			{
				if (!this._baseStream._wantCompress)
				{
					throw new global::System.InvalidOperationException();
				}
				this._headerByteCount = this.EmitHeader();
			}
			this._baseStream.Write(buffer, offset, count);
		}

		// Token: 0x06002E6D RID: 11885 RVA: 0x0009E980 File Offset: 0x0009CB80
		private int EmitHeader()
		{
			byte[] array = (this.Comment == null) ? null : global::Ionic.Zlib.GZipStream.iso8859dash1.GetBytes(this.Comment);
			byte[] array2 = (this.FileName == null) ? null : global::Ionic.Zlib.GZipStream.iso8859dash1.GetBytes(this.FileName);
			int num = (this.Comment == null) ? 0 : (array.Length + 1);
			int num2 = (this.FileName == null) ? 0 : (array2.Length + 1);
			byte[] array3 = new byte[10 + num + num2];
			int num3 = 0;
			array3[num3++] = 31;
			array3[num3++] = 139;
			array3[num3++] = 8;
			byte b = 0;
			if (this.Comment != null)
			{
				b ^= 16;
			}
			if (this.FileName != null)
			{
				b ^= 8;
			}
			array3[num3++] = b;
			if (this.LastModified == null)
			{
				this.LastModified = new global::System.DateTime?(global::System.DateTime.Now);
			}
			global::System.Array.Copy(global::System.BitConverter.GetBytes((int)(this.LastModified.Value - global::Ionic.Zlib.GZipStream._unixEpoch).TotalSeconds), 0, array3, num3, 4);
			num3 += 4;
			array3[num3++] = 0;
			array3[num3++] = byte.MaxValue;
			if (num2 != 0)
			{
				global::System.Array.Copy(array2, 0, array3, num3, num2 - 1);
				num3 += num2 - 1;
				array3[num3++] = 0;
			}
			if (num != 0)
			{
				global::System.Array.Copy(array, 0, array3, num3, num - 1);
				num3 += num - 1;
				array3[num3++] = 0;
			}
			this._baseStream._stream.Write(array3, 0, array3.Length);
			return array3.Length;
		}

		// Token: 0x06002E6E RID: 11886 RVA: 0x0009EB48 File Offset: 0x0009CD48
		public static byte[] CompressString(string s)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.Stream compressor = new global::Ionic.Zlib.GZipStream(memoryStream, global::Ionic.Zlib.CompressionMode.Compress, global::Ionic.Zlib.CompressionLevel.BestCompression);
				global::Ionic.Zlib.ZlibBaseStream.CompressString(s, compressor);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06002E6F RID: 11887 RVA: 0x0009EB98 File Offset: 0x0009CD98
		public static byte[] CompressBuffer(byte[] b)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				global::System.IO.Stream compressor = new global::Ionic.Zlib.GZipStream(memoryStream, global::Ionic.Zlib.CompressionMode.Compress, global::Ionic.Zlib.CompressionLevel.BestCompression);
				global::Ionic.Zlib.ZlibBaseStream.CompressBuffer(b, compressor);
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x06002E70 RID: 11888 RVA: 0x0009EBE8 File Offset: 0x0009CDE8
		public static string UncompressString(byte[] compressed)
		{
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(compressed))
			{
				global::System.IO.Stream decompressor = new global::Ionic.Zlib.GZipStream(memoryStream, global::Ionic.Zlib.CompressionMode.Decompress);
				result = global::Ionic.Zlib.ZlibBaseStream.UncompressString(compressed, decompressor);
			}
			return result;
		}

		// Token: 0x06002E71 RID: 11889 RVA: 0x0009EC30 File Offset: 0x0009CE30
		public static byte[] UncompressBuffer(byte[] compressed)
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(compressed))
			{
				global::System.IO.Stream decompressor = new global::Ionic.Zlib.GZipStream(memoryStream, global::Ionic.Zlib.CompressionMode.Decompress);
				result = global::Ionic.Zlib.ZlibBaseStream.UncompressBuffer(compressed, decompressor);
			}
			return result;
		}

		// Token: 0x04000FF0 RID: 4080
		public global::System.DateTime? LastModified;

		// Token: 0x04000FF1 RID: 4081
		private int _headerByteCount;

		// Token: 0x04000FF2 RID: 4082
		internal global::Ionic.Zlib.ZlibBaseStream _baseStream;

		// Token: 0x04000FF3 RID: 4083
		private bool _disposed;

		// Token: 0x04000FF4 RID: 4084
		private bool _firstReadDone;

		// Token: 0x04000FF5 RID: 4085
		private string _FileName;

		// Token: 0x04000FF6 RID: 4086
		private string _Comment;

		// Token: 0x04000FF7 RID: 4087
		private int _Crc32;

		// Token: 0x04000FF8 RID: 4088
		internal static readonly global::System.DateTime _unixEpoch = new global::System.DateTime(1970, 1, 1, 0, 0, 0, global::System.DateTimeKind.Utc);

		// Token: 0x04000FF9 RID: 4089
		internal static readonly global::System.Text.Encoding iso8859dash1 = global::System.Text.Encoding.GetEncoding("iso-8859-1");
	}
}
