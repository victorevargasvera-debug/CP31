using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ionic.Crc;

namespace Ionic.Zlib
{
	// Token: 0x0200043D RID: 1085
	internal class ZlibBaseStream : global::System.IO.Stream
	{
		// Token: 0x17000D84 RID: 3460
		// (get) Token: 0x06002ECC RID: 11980 RVA: 0x000A3874 File Offset: 0x000A1A74
		internal int Crc32
		{
			get
			{
				if (this.crc == null)
				{
					return 0;
				}
				return this.crc.Crc32Result;
			}
		}

		// Token: 0x06002ECD RID: 11981 RVA: 0x000A3890 File Offset: 0x000A1A90
		public ZlibBaseStream(global::System.IO.Stream stream, global::Ionic.Zlib.CompressionMode compressionMode, global::Ionic.Zlib.CompressionLevel level, global::Ionic.Zlib.ZlibStreamFlavor flavor, bool leaveOpen)
		{
			this._flushMode = global::Ionic.Zlib.FlushType.None;
			this._stream = stream;
			this._leaveOpen = leaveOpen;
			this._compressionMode = compressionMode;
			this._flavor = flavor;
			this._level = level;
			if (flavor == global::Ionic.Zlib.ZlibStreamFlavor.GZIP)
			{
				this.crc = new global::Ionic.Crc.CRC32();
			}
		}

		// Token: 0x17000D85 RID: 3461
		// (get) Token: 0x06002ECE RID: 11982 RVA: 0x000A3908 File Offset: 0x000A1B08
		protected internal bool _wantCompress
		{
			get
			{
				return this._compressionMode == global::Ionic.Zlib.CompressionMode.Compress;
			}
		}

		// Token: 0x17000D86 RID: 3462
		// (get) Token: 0x06002ECF RID: 11983 RVA: 0x000A3914 File Offset: 0x000A1B14
		private global::Ionic.Zlib.ZlibCodec z
		{
			get
			{
				if (this._z == null)
				{
					bool flag = this._flavor == global::Ionic.Zlib.ZlibStreamFlavor.ZLIB;
					this._z = new global::Ionic.Zlib.ZlibCodec();
					if (this._compressionMode == global::Ionic.Zlib.CompressionMode.Decompress)
					{
						this._z.InitializeInflate(flag);
					}
					else
					{
						this._z.Strategy = this.Strategy;
						this._z.InitializeDeflate(this._level, flag);
					}
				}
				return this._z;
			}
		}

		// Token: 0x17000D87 RID: 3463
		// (get) Token: 0x06002ED0 RID: 11984 RVA: 0x000A3994 File Offset: 0x000A1B94
		private byte[] workingBuffer
		{
			get
			{
				if (this._workingBuffer == null)
				{
					this._workingBuffer = new byte[this._bufferSize];
				}
				return this._workingBuffer;
			}
		}

		// Token: 0x06002ED1 RID: 11985 RVA: 0x000A39B8 File Offset: 0x000A1BB8
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.crc != null)
			{
				this.crc.SlurpBlock(buffer, offset, count);
			}
			if (this._streamMode == global::Ionic.Zlib.ZlibBaseStream.StreamMode.Undefined)
			{
				this._streamMode = global::Ionic.Zlib.ZlibBaseStream.StreamMode.Writer;
			}
			else if (this._streamMode != global::Ionic.Zlib.ZlibBaseStream.StreamMode.Writer)
			{
				throw new global::Ionic.Zlib.ZlibException("Cannot Write after Reading.");
			}
			if (count == 0)
			{
				return;
			}
			this.z.InputBuffer = buffer;
			this._z.NextIn = offset;
			this._z.AvailableBytesIn = count;
			for (;;)
			{
				this._z.OutputBuffer = this.workingBuffer;
				this._z.NextOut = 0;
				this._z.AvailableBytesOut = this._workingBuffer.Length;
				int num = this._wantCompress ? this._z.Deflate(this._flushMode) : this._z.Inflate(this._flushMode);
				if (num != 0 && num != 1)
				{
					break;
				}
				int num2 = this._workingBuffer.Length - this._z.AvailableBytesOut;
				if (num2 > 0)
				{
					this._stream.Write(this._workingBuffer, 0, num2);
				}
				bool flag = this._z.AvailableBytesIn == 0 && this._z.AvailableBytesOut != 0;
				if (this._flavor == global::Ionic.Zlib.ZlibStreamFlavor.GZIP && !this._wantCompress)
				{
					flag = (this._z.AvailableBytesIn == 8 && this._z.AvailableBytesOut != 0);
				}
				if (flag)
				{
					return;
				}
			}
			throw new global::Ionic.Zlib.ZlibException((this._wantCompress ? "de" : "in") + "flating: " + this._z.Message);
		}

		// Token: 0x06002ED2 RID: 11986 RVA: 0x000A3B80 File Offset: 0x000A1D80
		private void finish()
		{
			if (this._z == null)
			{
				return;
			}
			if (this._streamMode == global::Ionic.Zlib.ZlibBaseStream.StreamMode.Writer)
			{
				int num;
				for (;;)
				{
					this._z.OutputBuffer = this.workingBuffer;
					this._z.NextOut = 0;
					this._z.AvailableBytesOut = this._workingBuffer.Length;
					num = (this._wantCompress ? this._z.Deflate(global::Ionic.Zlib.FlushType.Finish) : this._z.Inflate(global::Ionic.Zlib.FlushType.Finish));
					if (num != 1 && num != 0)
					{
						break;
					}
					if (this._workingBuffer.Length - this._z.AvailableBytesOut > 0)
					{
						this._stream.Write(this._workingBuffer, 0, this._workingBuffer.Length - this._z.AvailableBytesOut);
					}
					bool flag = this._z.AvailableBytesIn == 0 && this._z.AvailableBytesOut != 0;
					if (this._flavor == global::Ionic.Zlib.ZlibStreamFlavor.GZIP && !this._wantCompress)
					{
						flag = (this._z.AvailableBytesIn == 8 && this._z.AvailableBytesOut != 0);
					}
					if (flag)
					{
						goto Block_12;
					}
				}
				string text = (this._wantCompress ? "de" : "in") + "flating";
				if (this._z.Message == null)
				{
					throw new global::Ionic.Zlib.ZlibException(string.Format("{0}: (rc = {1})", text, num));
				}
				throw new global::Ionic.Zlib.ZlibException(text + ": " + this._z.Message);
				Block_12:
				this.Flush();
				if (this._flavor == global::Ionic.Zlib.ZlibStreamFlavor.GZIP)
				{
					if (this._wantCompress)
					{
						int crc32Result = this.crc.Crc32Result;
						this._stream.Write(global::System.BitConverter.GetBytes(crc32Result), 0, 4);
						int value = (int)(this.crc.TotalBytesRead & (long)((ulong)-1));
						this._stream.Write(global::System.BitConverter.GetBytes(value), 0, 4);
						return;
					}
					throw new global::Ionic.Zlib.ZlibException("Writing with decompression is not supported.");
				}
			}
			else if (this._streamMode == global::Ionic.Zlib.ZlibBaseStream.StreamMode.Reader && this._flavor == global::Ionic.Zlib.ZlibStreamFlavor.GZIP)
			{
				if (this._wantCompress)
				{
					throw new global::Ionic.Zlib.ZlibException("Reading with compression is not supported.");
				}
				if (this._z.TotalBytesOut == 0L)
				{
					return;
				}
				byte[] array = new byte[8];
				if (this._z.AvailableBytesIn < 8)
				{
					global::System.Array.Copy(this._z.InputBuffer, this._z.NextIn, array, 0, this._z.AvailableBytesIn);
					int num2 = 8 - this._z.AvailableBytesIn;
					int num3 = this._stream.Read(array, this._z.AvailableBytesIn, num2);
					if (num2 != num3)
					{
						throw new global::Ionic.Zlib.ZlibException(string.Format("Missing or incomplete GZIP trailer. Expected 8 bytes, got {0}.", this._z.AvailableBytesIn + num3));
					}
				}
				else
				{
					global::System.Array.Copy(this._z.InputBuffer, this._z.NextIn, array, 0, array.Length);
				}
				int num4 = global::System.BitConverter.ToInt32(array, 0);
				int crc32Result2 = this.crc.Crc32Result;
				int num5 = global::System.BitConverter.ToInt32(array, 4);
				int num6 = (int)(this._z.TotalBytesOut & (long)((ulong)-1));
				if (crc32Result2 != num4)
				{
					throw new global::Ionic.Zlib.ZlibException(string.Format("Bad CRC32 in GZIP trailer. (actual({0:X8})!=expected({1:X8}))", crc32Result2, num4));
				}
				if (num6 != num5)
				{
					throw new global::Ionic.Zlib.ZlibException(string.Format("Bad size in GZIP trailer. (actual({0})!=expected({1}))", num6, num5));
				}
			}
		}

		// Token: 0x06002ED3 RID: 11987 RVA: 0x000A3F14 File Offset: 0x000A2114
		private void end()
		{
			if (this.z == null)
			{
				return;
			}
			if (this._wantCompress)
			{
				this._z.EndDeflate();
			}
			else
			{
				this._z.EndInflate();
			}
			this._z = null;
		}

		// Token: 0x06002ED4 RID: 11988 RVA: 0x000A3F54 File Offset: 0x000A2154
		public override void Close()
		{
			if (this._stream == null)
			{
				return;
			}
			try
			{
				this.finish();
			}
			finally
			{
				this.end();
				if (!this._leaveOpen)
				{
					this._stream.Close();
				}
				else
				{
					this._stream.Flush();
				}
				this._stream = null;
			}
		}

		// Token: 0x06002ED5 RID: 11989 RVA: 0x000A3FC0 File Offset: 0x000A21C0
		public override void Flush()
		{
			if (this._wantCompress)
			{
				byte[] inputBuffer = new byte[0];
				this.z.InputBuffer = inputBuffer;
				this._z.NextIn = 0;
				this._z.AvailableBytesIn = 0;
				for (;;)
				{
					this._z.OutputBuffer = this.workingBuffer;
					this._z.NextOut = 0;
					this._z.AvailableBytesOut = this._workingBuffer.Length;
					int num = this._wantCompress ? this._z.Deflate(global::Ionic.Zlib.FlushType.Sync) : this._z.Inflate(global::Ionic.Zlib.FlushType.Sync);
					if (num != 0 && num != 1)
					{
						break;
					}
					int num2 = this._workingBuffer.Length - this._z.AvailableBytesOut;
					if (num2 > 0)
					{
						this._stream.Write(this._workingBuffer, 0, num2);
					}
					bool flag = this._z.AvailableBytesIn == 0 && this._z.AvailableBytesOut != 0;
					if (flag)
					{
						goto IL_12D;
					}
				}
				throw new global::Ionic.Zlib.ZlibException((this._wantCompress ? "de" : "in") + "flating: " + this._z.Message);
			}
			IL_12D:
			this._stream.Flush();
		}

		// Token: 0x06002ED6 RID: 11990 RVA: 0x000A410C File Offset: 0x000A230C
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06002ED7 RID: 11991 RVA: 0x000A4114 File Offset: 0x000A2314
		public override void SetLength(long value)
		{
			this._stream.SetLength(value);
		}

		// Token: 0x06002ED8 RID: 11992 RVA: 0x000A4124 File Offset: 0x000A2324
		private string ReadZeroTerminatedString()
		{
			global::System.Collections.Generic.List<byte> list = new global::System.Collections.Generic.List<byte>();
			bool flag = false;
			while (this._stream.Read(this._buf1, 0, 1) == 1)
			{
				if (this._buf1[0] == 0)
				{
					flag = true;
				}
				else
				{
					list.Add(this._buf1[0]);
				}
				if (flag)
				{
					byte[] array = list.ToArray();
					return global::Ionic.Zlib.GZipStream.iso8859dash1.GetString(array, 0, array.Length);
				}
			}
			throw new global::Ionic.Zlib.ZlibException("Unexpected EOF reading GZIP header.");
		}

		// Token: 0x06002ED9 RID: 11993 RVA: 0x000A419C File Offset: 0x000A239C
		private int _ReadAndValidateGzipHeader()
		{
			int num = 0;
			byte[] array = new byte[10];
			int num2 = this._stream.Read(array, 0, array.Length);
			if (num2 == 0)
			{
				return 0;
			}
			if (num2 != 10)
			{
				throw new global::Ionic.Zlib.ZlibException("Not a valid GZIP stream.");
			}
			if (array[0] != 31 || array[1] != 139 || array[2] != 8)
			{
				throw new global::Ionic.Zlib.ZlibException("Bad GZIP header.");
			}
			int num3 = global::System.BitConverter.ToInt32(array, 4);
			this._GzipMtime = global::Ionic.Zlib.GZipStream._unixEpoch.AddSeconds((double)num3);
			num += num2;
			if ((array[3] & 4) == 4)
			{
				num2 = this._stream.Read(array, 0, 2);
				num += num2;
				short num4 = (short)((int)array[0] + (int)array[1] * 256);
				byte[] array2 = new byte[(int)num4];
				num2 = this._stream.Read(array2, 0, array2.Length);
				if (num2 != (int)num4)
				{
					throw new global::Ionic.Zlib.ZlibException("Unexpected end-of-file reading GZIP header.");
				}
				num += num2;
			}
			if ((array[3] & 8) == 8)
			{
				this._GzipFileName = this.ReadZeroTerminatedString();
			}
			if ((array[3] & 16) == 16)
			{
				this._GzipComment = this.ReadZeroTerminatedString();
			}
			if ((array[3] & 2) == 2)
			{
				this.Read(this._buf1, 0, 1);
			}
			return num;
		}

		// Token: 0x06002EDA RID: 11994 RVA: 0x000A42DC File Offset: 0x000A24DC
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._streamMode == global::Ionic.Zlib.ZlibBaseStream.StreamMode.Undefined)
			{
				if (!this._stream.CanRead)
				{
					throw new global::Ionic.Zlib.ZlibException("The stream is not readable.");
				}
				this._streamMode = global::Ionic.Zlib.ZlibBaseStream.StreamMode.Reader;
				this.z.AvailableBytesIn = 0;
				if (this._flavor == global::Ionic.Zlib.ZlibStreamFlavor.GZIP)
				{
					this._gzipHeaderByteCount = this._ReadAndValidateGzipHeader();
					if (this._gzipHeaderByteCount == 0)
					{
						return 0;
					}
				}
			}
			if (this._streamMode != global::Ionic.Zlib.ZlibBaseStream.StreamMode.Reader)
			{
				throw new global::Ionic.Zlib.ZlibException("Cannot Read after Writing.");
			}
			if (count == 0)
			{
				return 0;
			}
			if (this.nomoreinput && this._wantCompress)
			{
				return 0;
			}
			if (buffer == null)
			{
				throw new global::System.ArgumentNullException("buffer");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if (offset < buffer.GetLowerBound(0))
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			if (offset + count > buffer.GetLength(0))
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			this._z.OutputBuffer = buffer;
			this._z.NextOut = offset;
			this._z.AvailableBytesOut = count;
			this._z.InputBuffer = this.workingBuffer;
			int num;
			for (;;)
			{
				if (this._z.AvailableBytesIn == 0 && !this.nomoreinput)
				{
					this._z.NextIn = 0;
					this._z.AvailableBytesIn = this._stream.Read(this._workingBuffer, 0, this._workingBuffer.Length);
					if (this._z.AvailableBytesIn == 0)
					{
						this.nomoreinput = true;
					}
				}
				num = (this._wantCompress ? this._z.Deflate(this._flushMode) : this._z.Inflate(this._flushMode));
				if (this.nomoreinput && num == -5)
				{
					break;
				}
				if (num != 0 && num != 1)
				{
					goto Block_20;
				}
				if (((this.nomoreinput || num == 1) && this._z.AvailableBytesOut == count) || this._z.AvailableBytesOut <= 0 || this.nomoreinput || num != 0)
				{
					goto IL_25E;
				}
			}
			return 0;
			Block_20:
			throw new global::Ionic.Zlib.ZlibException(string.Format("{0}flating:  rc={1}  msg={2}", this._wantCompress ? "de" : "in", num, this._z.Message));
			IL_25E:
			if (this._z.AvailableBytesOut > 0)
			{
				if (num == 0)
				{
					int availableBytesIn = this._z.AvailableBytesIn;
				}
				if (this.nomoreinput && this._wantCompress)
				{
					num = this._z.Deflate(global::Ionic.Zlib.FlushType.Finish);
					if (num != 0 && num != 1)
					{
						throw new global::Ionic.Zlib.ZlibException(string.Format("Deflating:  rc={0}  msg={1}", num, this._z.Message));
					}
				}
			}
			num = count - this._z.AvailableBytesOut;
			if (this.crc != null)
			{
				this.crc.SlurpBlock(buffer, offset, num);
			}
			return num;
		}

		// Token: 0x17000D88 RID: 3464
		// (get) Token: 0x06002EDB RID: 11995 RVA: 0x000A45E8 File Offset: 0x000A27E8
		public override bool CanRead
		{
			get
			{
				return this._stream.CanRead;
			}
		}

		// Token: 0x17000D89 RID: 3465
		// (get) Token: 0x06002EDC RID: 11996 RVA: 0x000A45F8 File Offset: 0x000A27F8
		public override bool CanSeek
		{
			get
			{
				return this._stream.CanSeek;
			}
		}

		// Token: 0x17000D8A RID: 3466
		// (get) Token: 0x06002EDD RID: 11997 RVA: 0x000A4608 File Offset: 0x000A2808
		public override bool CanWrite
		{
			get
			{
				return this._stream.CanWrite;
			}
		}

		// Token: 0x17000D8B RID: 3467
		// (get) Token: 0x06002EDE RID: 11998 RVA: 0x000A4618 File Offset: 0x000A2818
		public override long Length
		{
			get
			{
				return this._stream.Length;
			}
		}

		// Token: 0x17000D8C RID: 3468
		// (get) Token: 0x06002EDF RID: 11999 RVA: 0x000A4628 File Offset: 0x000A2828
		// (set) Token: 0x06002EE0 RID: 12000 RVA: 0x000A4630 File Offset: 0x000A2830
		public override long Position
		{
			get
			{
				throw new global::System.NotImplementedException();
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x06002EE1 RID: 12001 RVA: 0x000A4638 File Offset: 0x000A2838
		public static void CompressString(string s, global::System.IO.Stream compressor)
		{
			byte[] bytes = global::System.Text.Encoding.UTF8.GetBytes(s);
			try
			{
				compressor.Write(bytes, 0, bytes.Length);
			}
			finally
			{
				if (compressor != null)
				{
					((global::System.IDisposable)compressor).Dispose();
				}
			}
		}

		// Token: 0x06002EE2 RID: 12002 RVA: 0x000A4680 File Offset: 0x000A2880
		public static void CompressBuffer(byte[] b, global::System.IO.Stream compressor)
		{
			try
			{
				compressor.Write(b, 0, b.Length);
			}
			finally
			{
				if (compressor != null)
				{
					((global::System.IDisposable)compressor).Dispose();
				}
			}
		}

		// Token: 0x06002EE3 RID: 12003 RVA: 0x000A46BC File Offset: 0x000A28BC
		public static string UncompressString(byte[] compressed, global::System.IO.Stream decompressor)
		{
			byte[] array = new byte[1024];
			global::System.Text.Encoding utf = global::System.Text.Encoding.UTF8;
			string result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				try
				{
					int count;
					while ((count = decompressor.Read(array, 0, array.Length)) != 0)
					{
						memoryStream.Write(array, 0, count);
					}
				}
				finally
				{
					if (decompressor != null)
					{
						((global::System.IDisposable)decompressor).Dispose();
					}
				}
				memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
				result = new global::System.IO.StreamReader(memoryStream, utf).ReadToEnd();
			}
			return result;
		}

		// Token: 0x06002EE4 RID: 12004 RVA: 0x000A475C File Offset: 0x000A295C
		public static byte[] UncompressBuffer(byte[] compressed, global::System.IO.Stream decompressor)
		{
			byte[] array = new byte[1024];
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream())
			{
				try
				{
					int count;
					while ((count = decompressor.Read(array, 0, array.Length)) != 0)
					{
						memoryStream.Write(array, 0, count);
					}
				}
				finally
				{
					if (decompressor != null)
					{
						((global::System.IDisposable)decompressor).Dispose();
					}
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x040010B5 RID: 4277
		protected internal global::Ionic.Zlib.ZlibCodec _z;

		// Token: 0x040010B6 RID: 4278
		protected internal global::Ionic.Zlib.ZlibBaseStream.StreamMode _streamMode = global::Ionic.Zlib.ZlibBaseStream.StreamMode.Undefined;

		// Token: 0x040010B7 RID: 4279
		protected internal global::Ionic.Zlib.FlushType _flushMode;

		// Token: 0x040010B8 RID: 4280
		protected internal global::Ionic.Zlib.ZlibStreamFlavor _flavor;

		// Token: 0x040010B9 RID: 4281
		protected internal global::Ionic.Zlib.CompressionMode _compressionMode;

		// Token: 0x040010BA RID: 4282
		protected internal global::Ionic.Zlib.CompressionLevel _level;

		// Token: 0x040010BB RID: 4283
		protected internal bool _leaveOpen;

		// Token: 0x040010BC RID: 4284
		protected internal byte[] _workingBuffer;

		// Token: 0x040010BD RID: 4285
		protected internal int _bufferSize = 16384;

		// Token: 0x040010BE RID: 4286
		protected internal byte[] _buf1 = new byte[1];

		// Token: 0x040010BF RID: 4287
		protected internal global::System.IO.Stream _stream;

		// Token: 0x040010C0 RID: 4288
		protected internal global::Ionic.Zlib.CompressionStrategy Strategy;

		// Token: 0x040010C1 RID: 4289
		private global::Ionic.Crc.CRC32 crc;

		// Token: 0x040010C2 RID: 4290
		protected internal string _GzipFileName;

		// Token: 0x040010C3 RID: 4291
		protected internal string _GzipComment;

		// Token: 0x040010C4 RID: 4292
		protected internal global::System.DateTime _GzipMtime;

		// Token: 0x040010C5 RID: 4293
		protected internal int _gzipHeaderByteCount;

		// Token: 0x040010C6 RID: 4294
		private bool nomoreinput;

		// Token: 0x020004E0 RID: 1248
		internal enum StreamMode
		{
			// Token: 0x04001420 RID: 5152
			Writer,
			// Token: 0x04001421 RID: 5153
			Reader,
			// Token: 0x04001422 RID: 5154
			Undefined
		}
	}
}
