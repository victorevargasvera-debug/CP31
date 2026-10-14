using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x02000044 RID: 68
	public class CountingStream : global::System.IO.Stream
	{
		// Token: 0x060002FA RID: 762 RVA: 0x00012204 File Offset: 0x00010404
		public CountingStream(global::System.IO.Stream stream)
		{
			this._s = stream;
			try
			{
				this._initialOffset = this._s.Position;
			}
			catch
			{
				this._initialOffset = 0L;
			}
		}

		// Token: 0x1700009A RID: 154
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0001224C File Offset: 0x0001044C
		public global::System.IO.Stream WrappedStream
		{
			get
			{
				return this._s;
			}
		}

		// Token: 0x1700009B RID: 155
		// (get) Token: 0x060002FC RID: 764 RVA: 0x00012254 File Offset: 0x00010454
		public long BytesWritten
		{
			get
			{
				return this._bytesWritten;
			}
		}

		// Token: 0x1700009C RID: 156
		// (get) Token: 0x060002FD RID: 765 RVA: 0x0001225C File Offset: 0x0001045C
		public long BytesRead
		{
			get
			{
				return this._bytesRead;
			}
		}

		// Token: 0x060002FE RID: 766 RVA: 0x00012264 File Offset: 0x00010464
		public void Adjust(long delta)
		{
			this._bytesWritten -= delta;
			if (this._bytesWritten < 0L)
			{
				throw new global::System.InvalidOperationException();
			}
			if (this._s is global::Ionic.Zip.CountingStream)
			{
				((global::Ionic.Zip.CountingStream)this._s).Adjust(delta);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x000122A4 File Offset: 0x000104A4
		public override int Read(byte[] buffer, int offset, int count)
		{
			int num = this._s.Read(buffer, offset, count);
			this._bytesRead += (long)num;
			return num;
		}

		// Token: 0x06000300 RID: 768 RVA: 0x000122D0 File Offset: 0x000104D0
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (count == 0)
			{
				return;
			}
			this._s.Write(buffer, offset, count);
			this._bytesWritten += (long)count;
		}

		// Token: 0x1700009D RID: 157
		// (get) Token: 0x06000301 RID: 769 RVA: 0x000122F3 File Offset: 0x000104F3
		public override bool CanRead
		{
			get
			{
				return this._s.CanRead;
			}
		}

		// Token: 0x1700009E RID: 158
		// (get) Token: 0x06000302 RID: 770 RVA: 0x00012300 File Offset: 0x00010500
		public override bool CanSeek
		{
			get
			{
				return this._s.CanSeek;
			}
		}

		// Token: 0x1700009F RID: 159
		// (get) Token: 0x06000303 RID: 771 RVA: 0x0001230D File Offset: 0x0001050D
		public override bool CanWrite
		{
			get
			{
				return this._s.CanWrite;
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0001231A File Offset: 0x0001051A
		public override void Flush()
		{
			this._s.Flush();
		}

		// Token: 0x170000A0 RID: 160
		// (get) Token: 0x06000305 RID: 773 RVA: 0x00012327 File Offset: 0x00010527
		public override long Length
		{
			get
			{
				return this._s.Length;
			}
		}

		// Token: 0x170000A1 RID: 161
		// (get) Token: 0x06000306 RID: 774 RVA: 0x00012334 File Offset: 0x00010534
		public long ComputedPosition
		{
			get
			{
				return this._initialOffset + this._bytesWritten;
			}
		}

		// Token: 0x170000A2 RID: 162
		// (get) Token: 0x06000307 RID: 775 RVA: 0x00012343 File Offset: 0x00010543
		// (set) Token: 0x06000308 RID: 776 RVA: 0x00012350 File Offset: 0x00010550
		public override long Position
		{
			get
			{
				return this._s.Position;
			}
			set
			{
				this._s.Seek(value, global::System.IO.SeekOrigin.Begin);
			}
		}

		// Token: 0x06000309 RID: 777 RVA: 0x00012360 File Offset: 0x00010560
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this._s.Seek(offset, origin);
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0001236F File Offset: 0x0001056F
		public override void SetLength(long value)
		{
			this._s.SetLength(value);
		}

		// Token: 0x040001FE RID: 510
		private global::System.IO.Stream _s;

		// Token: 0x040001FF RID: 511
		private long _bytesWritten;

		// Token: 0x04000200 RID: 512
		private long _bytesRead;

		// Token: 0x04000201 RID: 513
		private long _initialOffset;
	}
}
