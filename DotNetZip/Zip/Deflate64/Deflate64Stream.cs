using System;
using System.IO;

namespace Ionic.Zip.Deflate64
{
	// Token: 0x0200005A RID: 90
	internal sealed class Deflate64Stream : global::System.IO.Stream
	{
		// Token: 0x06000479 RID: 1145 RVA: 0x0001AE14 File Offset: 0x00019014
		internal Deflate64Stream(global::System.IO.Stream stream, long uncompressedSize = -1L)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (!stream.CanRead)
			{
				throw new global::System.ArgumentException("NotSupported_UnreadableStream", "stream");
			}
			this._inflater = new global::Ionic.Zip.Deflate64.InflaterManaged(null, true, uncompressedSize);
			this._stream = stream;
			this._buffer = new byte[8192];
		}

		// Token: 0x17000121 RID: 289
		// (get) Token: 0x0600047A RID: 1146 RVA: 0x0001AE72 File Offset: 0x00019072
		public override bool CanRead
		{
			get
			{
				return this._stream != null && this._stream.CanRead;
			}
		}

		// Token: 0x17000122 RID: 290
		// (get) Token: 0x0600047B RID: 1147 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000123 RID: 291
		// (get) Token: 0x0600047C RID: 1148 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000124 RID: 292
		// (get) Token: 0x0600047D RID: 1149 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000125 RID: 293
		// (get) Token: 0x0600047E RID: 1150 RVA: 0x0000A809 File Offset: 0x00008A09
		// (set) Token: 0x0600047F RID: 1151 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Position
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

		// Token: 0x06000480 RID: 1152 RVA: 0x0001AE89 File Offset: 0x00019089
		public override void Flush()
		{
			this.EnsureNotDisposed();
		}

		// Token: 0x06000481 RID: 1153 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000482 RID: 1154 RVA: 0x0000A809 File Offset: 0x00008A09
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0001AE94 File Offset: 0x00019094
		public override int Read(byte[] array, int offset, int count)
		{
			this.ValidateParameters(array, offset, count);
			this.EnsureNotDisposed();
			int num = offset;
			int num2 = count;
			for (;;)
			{
				int num3 = this._inflater.Inflate(array, num, num2);
				num += num3;
				num2 -= num3;
				if (num2 == 0 || this._inflater.Finished())
				{
					goto IL_7F;
				}
				int num4 = this._stream.Read(this._buffer, 0, this._buffer.Length);
				if (num4 <= 0)
				{
					goto IL_7F;
				}
				if (num4 > this._buffer.Length)
				{
					break;
				}
				this._inflater.SetInput(this._buffer, 0, num4);
			}
			throw new global::System.IO.InvalidDataException();
			IL_7F:
			return count - num2;
		}

		// Token: 0x06000484 RID: 1156 RVA: 0x0001AF24 File Offset: 0x00019124
		private void ValidateParameters(byte[] array, int offset, int count)
		{
			if (array == null)
			{
				throw new global::System.ArgumentNullException("array");
			}
			if (offset < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("offset");
			}
			if (count < 0)
			{
				throw new global::System.ArgumentOutOfRangeException("count");
			}
			if (array.Length - offset < count)
			{
				throw new global::System.ArgumentException("InvalidArgumentOffsetCount");
			}
		}

		// Token: 0x06000485 RID: 1157 RVA: 0x0001AF70 File Offset: 0x00019170
		private void EnsureNotDisposed()
		{
			if (this._stream == null)
			{
				global::Ionic.Zip.Deflate64.Deflate64Stream.ThrowStreamClosedException();
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x0001AF7F File Offset: 0x0001917F
		private static void ThrowStreamClosedException()
		{
			throw new global::System.ObjectDisposedException(null, "ObjectDisposed_StreamClosed");
		}

		// Token: 0x06000487 RID: 1159 RVA: 0x000060ED File Offset: 0x000042ED
		public override global::System.IAsyncResult BeginRead(byte[] buffer, int offset, int count, global::System.AsyncCallback asyncCallback, object asyncState)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000488 RID: 1160 RVA: 0x000060ED File Offset: 0x000042ED
		public override int EndRead(global::System.IAsyncResult asyncResult)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x06000489 RID: 1161 RVA: 0x0001AF8C File Offset: 0x0001918C
		public override void Write(byte[] array, int offset, int count)
		{
			throw new global::System.InvalidOperationException("CannotWriteToDeflateStream");
		}

		// Token: 0x0600048A RID: 1162 RVA: 0x0001AF98 File Offset: 0x00019198
		private void PurgeBuffers(bool disposing)
		{
			if (!disposing)
			{
				return;
			}
			if (this._stream == null)
			{
				return;
			}
			this.Flush();
		}

		// Token: 0x0600048B RID: 1163 RVA: 0x0001AFB0 File Offset: 0x000191B0
		protected override void Dispose(bool disposing)
		{
			try
			{
				this.PurgeBuffers(disposing);
			}
			finally
			{
				try
				{
					if (disposing && this._stream != null)
					{
						this._stream.Dispose();
					}
				}
				finally
				{
					this._stream = null;
					try
					{
						if (this._inflater != null)
						{
							this._inflater.Dispose();
						}
					}
					finally
					{
						this._inflater = null;
						base.Dispose(disposing);
					}
				}
			}
		}

		// Token: 0x040002F1 RID: 753
		internal const int DefaultBufferSize = 8192;

		// Token: 0x040002F2 RID: 754
		private global::System.IO.Stream _stream;

		// Token: 0x040002F3 RID: 755
		private global::Ionic.Zip.Deflate64.InflaterManaged _inflater;

		// Token: 0x040002F4 RID: 756
		private readonly byte[] _buffer;
	}
}
