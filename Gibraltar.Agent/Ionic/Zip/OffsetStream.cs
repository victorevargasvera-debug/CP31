using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x0200045D RID: 1117
	internal class OffsetStream : global::System.IO.Stream, global::System.IDisposable
	{
		// Token: 0x06002FFF RID: 12287 RVA: 0x000A9EE0 File Offset: 0x000A80E0
		public OffsetStream(global::System.IO.Stream s)
		{
			this._originalPosition = s.Position;
			this._innerStream = s;
		}

		// Token: 0x06003000 RID: 12288 RVA: 0x000A9EFC File Offset: 0x000A80FC
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this._innerStream.Read(buffer, offset, count);
		}

		// Token: 0x06003001 RID: 12289 RVA: 0x000A9F0C File Offset: 0x000A810C
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000DBE RID: 3518
		// (get) Token: 0x06003002 RID: 12290 RVA: 0x000A9F14 File Offset: 0x000A8114
		public override bool CanRead
		{
			get
			{
				return this._innerStream.CanRead;
			}
		}

		// Token: 0x17000DBF RID: 3519
		// (get) Token: 0x06003003 RID: 12291 RVA: 0x000A9F24 File Offset: 0x000A8124
		public override bool CanSeek
		{
			get
			{
				return this._innerStream.CanSeek;
			}
		}

		// Token: 0x17000DC0 RID: 3520
		// (get) Token: 0x06003004 RID: 12292 RVA: 0x000A9F34 File Offset: 0x000A8134
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x06003005 RID: 12293 RVA: 0x000A9F38 File Offset: 0x000A8138
		public override void Flush()
		{
			this._innerStream.Flush();
		}

		// Token: 0x17000DC1 RID: 3521
		// (get) Token: 0x06003006 RID: 12294 RVA: 0x000A9F48 File Offset: 0x000A8148
		public override long Length
		{
			get
			{
				return this._innerStream.Length;
			}
		}

		// Token: 0x17000DC2 RID: 3522
		// (get) Token: 0x06003007 RID: 12295 RVA: 0x000A9F58 File Offset: 0x000A8158
		// (set) Token: 0x06003008 RID: 12296 RVA: 0x000A9F6C File Offset: 0x000A816C
		public override long Position
		{
			get
			{
				return this._innerStream.Position - this._originalPosition;
			}
			set
			{
				this._innerStream.Position = this._originalPosition + value;
			}
		}

		// Token: 0x06003009 RID: 12297 RVA: 0x000A9F84 File Offset: 0x000A8184
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this._innerStream.Seek(this._originalPosition + offset, origin) - this._originalPosition;
		}

		// Token: 0x0600300A RID: 12298 RVA: 0x000A9FA4 File Offset: 0x000A81A4
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x0600300B RID: 12299 RVA: 0x000A9FAC File Offset: 0x000A81AC
		void global::System.IDisposable.Dispose()
		{
			this.Close();
		}

		// Token: 0x0600300C RID: 12300 RVA: 0x000A9FB4 File Offset: 0x000A81B4
		public override void Close()
		{
			base.Close();
		}

		// Token: 0x0400117F RID: 4479
		private long _originalPosition;

		// Token: 0x04001180 RID: 4480
		private global::System.IO.Stream _innerStream;
	}
}
