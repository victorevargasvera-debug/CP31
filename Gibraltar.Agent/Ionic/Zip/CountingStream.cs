using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x0200045F RID: 1119
	internal class CountingStream : global::System.IO.Stream
	{
		// Token: 0x06003022 RID: 12322 RVA: 0x000AA880 File Offset: 0x000A8A80
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

		// Token: 0x17000DC3 RID: 3523
		// (get) Token: 0x06003023 RID: 12323 RVA: 0x000AA8D0 File Offset: 0x000A8AD0
		public global::System.IO.Stream WrappedStream
		{
			get
			{
				return this._s;
			}
		}

		// Token: 0x17000DC4 RID: 3524
		// (get) Token: 0x06003024 RID: 12324 RVA: 0x000AA8D8 File Offset: 0x000A8AD8
		public long BytesWritten
		{
			get
			{
				return this._bytesWritten;
			}
		}

		// Token: 0x17000DC5 RID: 3525
		// (get) Token: 0x06003025 RID: 12325 RVA: 0x000AA8E0 File Offset: 0x000A8AE0
		public long BytesRead
		{
			get
			{
				return this._bytesRead;
			}
		}

		// Token: 0x06003026 RID: 12326 RVA: 0x000AA8E8 File Offset: 0x000A8AE8
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

		// Token: 0x06003027 RID: 12327 RVA: 0x000AA93C File Offset: 0x000A8B3C
		public override int Read(byte[] buffer, int offset, int count)
		{
			int num = this._s.Read(buffer, offset, count);
			this._bytesRead += (long)num;
			return num;
		}

		// Token: 0x06003028 RID: 12328 RVA: 0x000AA96C File Offset: 0x000A8B6C
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (count == 0)
			{
				return;
			}
			this._s.Write(buffer, offset, count);
			this._bytesWritten += (long)count;
		}

		// Token: 0x17000DC6 RID: 3526
		// (get) Token: 0x06003029 RID: 12329 RVA: 0x000AA994 File Offset: 0x000A8B94
		public override bool CanRead
		{
			get
			{
				return this._s.CanRead;
			}
		}

		// Token: 0x17000DC7 RID: 3527
		// (get) Token: 0x0600302A RID: 12330 RVA: 0x000AA9A4 File Offset: 0x000A8BA4
		public override bool CanSeek
		{
			get
			{
				return this._s.CanSeek;
			}
		}

		// Token: 0x17000DC8 RID: 3528
		// (get) Token: 0x0600302B RID: 12331 RVA: 0x000AA9B4 File Offset: 0x000A8BB4
		public override bool CanWrite
		{
			get
			{
				return this._s.CanWrite;
			}
		}

		// Token: 0x0600302C RID: 12332 RVA: 0x000AA9C4 File Offset: 0x000A8BC4
		public override void Flush()
		{
			this._s.Flush();
		}

		// Token: 0x17000DC9 RID: 3529
		// (get) Token: 0x0600302D RID: 12333 RVA: 0x000AA9D4 File Offset: 0x000A8BD4
		public override long Length
		{
			get
			{
				return this._s.Length;
			}
		}

		// Token: 0x17000DCA RID: 3530
		// (get) Token: 0x0600302E RID: 12334 RVA: 0x000AA9E4 File Offset: 0x000A8BE4
		public long ComputedPosition
		{
			get
			{
				return this._initialOffset + this._bytesWritten;
			}
		}

		// Token: 0x17000DCB RID: 3531
		// (get) Token: 0x0600302F RID: 12335 RVA: 0x000AA9F4 File Offset: 0x000A8BF4
		// (set) Token: 0x06003030 RID: 12336 RVA: 0x000AAA04 File Offset: 0x000A8C04
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

		// Token: 0x06003031 RID: 12337 RVA: 0x000AAA14 File Offset: 0x000A8C14
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this._s.Seek(offset, origin);
		}

		// Token: 0x06003032 RID: 12338 RVA: 0x000AAA24 File Offset: 0x000A8C24
		public override void SetLength(long value)
		{
			this._s.SetLength(value);
		}

		// Token: 0x04001184 RID: 4484
		private global::System.IO.Stream _s;

		// Token: 0x04001185 RID: 4485
		private long _bytesWritten;

		// Token: 0x04001186 RID: 4486
		private long _bytesRead;

		// Token: 0x04001187 RID: 4487
		private long _initialOffset;
	}
}
