using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x02000042 RID: 66
	internal class OffsetStream : global::System.IO.Stream, global::System.IDisposable
	{
		// Token: 0x060002D7 RID: 727 RVA: 0x000118A9 File Offset: 0x0000FAA9
		public OffsetStream(global::System.IO.Stream s)
		{
			this._originalPosition = s.Position;
			this._innerStream = s;
		}

		// Token: 0x060002D8 RID: 728 RVA: 0x000118C4 File Offset: 0x0000FAC4
		public override int Read(byte[] buffer, int offset, int count)
		{
			return this._innerStream.Read(buffer, offset, count);
		}

		// Token: 0x060002D9 RID: 729 RVA: 0x000060ED File Offset: 0x000042ED
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x17000095 RID: 149
		// (get) Token: 0x060002DA RID: 730 RVA: 0x000118D4 File Offset: 0x0000FAD4
		public override bool CanRead
		{
			get
			{
				return this._innerStream.CanRead;
			}
		}

		// Token: 0x17000096 RID: 150
		// (get) Token: 0x060002DB RID: 731 RVA: 0x000118E1 File Offset: 0x0000FAE1
		public override bool CanSeek
		{
			get
			{
				return this._innerStream.CanSeek;
			}
		}

		// Token: 0x17000097 RID: 151
		// (get) Token: 0x060002DC RID: 732 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x060002DD RID: 733 RVA: 0x000118EE File Offset: 0x0000FAEE
		public override void Flush()
		{
			this._innerStream.Flush();
		}

		// Token: 0x17000098 RID: 152
		// (get) Token: 0x060002DE RID: 734 RVA: 0x000118FB File Offset: 0x0000FAFB
		public override long Length
		{
			get
			{
				return this._innerStream.Length;
			}
		}

		// Token: 0x17000099 RID: 153
		// (get) Token: 0x060002DF RID: 735 RVA: 0x00011908 File Offset: 0x0000FB08
		// (set) Token: 0x060002E0 RID: 736 RVA: 0x0001191C File Offset: 0x0000FB1C
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

		// Token: 0x060002E1 RID: 737 RVA: 0x00011931 File Offset: 0x0000FB31
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this._innerStream.Seek(this._originalPosition + offset, origin) - this._originalPosition;
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x000060ED File Offset: 0x000042ED
		public override void SetLength(long value)
		{
			throw new global::System.NotImplementedException();
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0001194E File Offset: 0x0000FB4E
		void global::System.IDisposable.Dispose()
		{
			this.Close();
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x00011956 File Offset: 0x0000FB56
		public override void Close()
		{
			base.Close();
		}

		// Token: 0x040001FA RID: 506
		private long _originalPosition;

		// Token: 0x040001FB RID: 507
		private global::System.IO.Stream _innerStream;
	}
}
