using System;
using System.IO;

namespace Ionic.Crc
{
	// Token: 0x0200002A RID: 42
	public class CrcCalculatorStream : global::System.IO.Stream, global::System.IDisposable
	{
		// Token: 0x0600015D RID: 349 RVA: 0x0000CACE File Offset: 0x0000ACCE
		public CrcCalculatorStream(global::System.IO.Stream stream) : this(true, global::Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit, stream, null)
		{
		}

		// Token: 0x0600015E RID: 350 RVA: 0x0000CADE File Offset: 0x0000ACDE
		public CrcCalculatorStream(global::System.IO.Stream stream, bool leaveOpen) : this(leaveOpen, global::Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit, stream, null)
		{
		}

		// Token: 0x0600015F RID: 351 RVA: 0x0000CAEE File Offset: 0x0000ACEE
		public CrcCalculatorStream(global::System.IO.Stream stream, long length) : this(true, length, stream, null)
		{
			if (length < 0L)
			{
				throw new global::System.ArgumentException("length");
			}
		}

		// Token: 0x06000160 RID: 352 RVA: 0x0000CB0A File Offset: 0x0000AD0A
		public CrcCalculatorStream(global::System.IO.Stream stream, long length, bool leaveOpen) : this(leaveOpen, length, stream, null)
		{
			if (length < 0L)
			{
				throw new global::System.ArgumentException("length");
			}
		}

		// Token: 0x06000161 RID: 353 RVA: 0x0000CB26 File Offset: 0x0000AD26
		public CrcCalculatorStream(global::System.IO.Stream stream, long length, bool leaveOpen, global::Ionic.Crc.CRC32 crc32) : this(leaveOpen, length, stream, crc32)
		{
			if (length < 0L)
			{
				throw new global::System.ArgumentException("length");
			}
		}

		// Token: 0x06000162 RID: 354 RVA: 0x0000CB44 File Offset: 0x0000AD44
		private CrcCalculatorStream(bool leaveOpen, long length, global::System.IO.Stream stream, global::Ionic.Crc.CRC32 crc32)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			this._innerStream = stream;
			this._crc32 = (crc32 ?? new global::Ionic.Crc.CRC32());
			this._lengthLimit = length;
			this._leaveOpen = leaveOpen;
		}

		// Token: 0x1700003F RID: 63
		// (get) Token: 0x06000163 RID: 355 RVA: 0x0000CB94 File Offset: 0x0000AD94
		public long TotalBytesSlurped
		{
			get
			{
				return this._crc32.TotalBytesRead;
			}
		}

		// Token: 0x17000040 RID: 64
		// (get) Token: 0x06000164 RID: 356 RVA: 0x0000CBA1 File Offset: 0x0000ADA1
		public int Crc
		{
			get
			{
				return this._crc32.Crc32Result;
			}
		}

		// Token: 0x17000041 RID: 65
		// (get) Token: 0x06000165 RID: 357 RVA: 0x0000CBAE File Offset: 0x0000ADAE
		// (set) Token: 0x06000166 RID: 358 RVA: 0x0000CBB6 File Offset: 0x0000ADB6
		public bool LeaveOpen
		{
			get
			{
				return this._leaveOpen;
			}
			set
			{
				this._leaveOpen = value;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x0000CBC0 File Offset: 0x0000ADC0
		public override int Read(byte[] buffer, int offset, int count)
		{
			int count2 = count;
			if (this._lengthLimit != global::Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit)
			{
				if (this._crc32.TotalBytesRead >= this._lengthLimit)
				{
					return 0;
				}
				long num = this._lengthLimit - this._crc32.TotalBytesRead;
				if (num < (long)count)
				{
					count2 = (int)num;
				}
			}
			int num2 = this._innerStream.Read(buffer, offset, count2);
			if (num2 > 0)
			{
				this._crc32.SlurpBlock(buffer, offset, num2);
			}
			return num2;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x0000CC2E File Offset: 0x0000AE2E
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (count > 0)
			{
				this._crc32.SlurpBlock(buffer, offset, count);
			}
			this._innerStream.Write(buffer, offset, count);
		}

		// Token: 0x17000042 RID: 66
		// (get) Token: 0x06000169 RID: 361 RVA: 0x0000CC50 File Offset: 0x0000AE50
		public override bool CanRead
		{
			get
			{
				return this._innerStream.CanRead;
			}
		}

		// Token: 0x17000043 RID: 67
		// (get) Token: 0x0600016A RID: 362 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000044 RID: 68
		// (get) Token: 0x0600016B RID: 363 RVA: 0x0000CC5D File Offset: 0x0000AE5D
		public override bool CanWrite
		{
			get
			{
				return this._innerStream.CanWrite;
			}
		}

		// Token: 0x0600016C RID: 364 RVA: 0x0000CC6A File Offset: 0x0000AE6A
		public override void Flush()
		{
			this._innerStream.Flush();
		}

		// Token: 0x17000045 RID: 69
		// (get) Token: 0x0600016D RID: 365 RVA: 0x0000CC77 File Offset: 0x0000AE77
		public override long Length
		{
			get
			{
				if (this._lengthLimit == global::Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit)
				{
					return this._innerStream.Length;
				}
				return this._lengthLimit;
			}
		}

		// Token: 0x17000046 RID: 70
		// (get) Token: 0x0600016E RID: 366 RVA: 0x0000CB94 File Offset: 0x0000AD94
		// (set) Token: 0x0600016F RID: 367 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Position
		{
			get
			{
				return this._crc32.TotalBytesRead;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06000170 RID: 368 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000A809 File Offset: 0x00008A09
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06000172 RID: 370 RVA: 0x0000CC98 File Offset: 0x0000AE98
		void global::System.IDisposable.Dispose()
		{
			this.InnerClose();
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000CCA0 File Offset: 0x0000AEA0
		private void InnerClose()
		{
			if (!this._leaveOpen)
			{
				this._innerStream.Close();
			}
		}

		// Token: 0x06000174 RID: 372 RVA: 0x0000CCB5 File Offset: 0x0000AEB5
		public override void Close()
		{
			base.Close();
			this.InnerClose();
		}

		// Token: 0x04000172 RID: 370
		private static readonly long UnsetLengthLimit = -99L;

		// Token: 0x04000173 RID: 371
		private readonly global::System.IO.Stream _innerStream;

		// Token: 0x04000174 RID: 372
		private readonly global::Ionic.Crc.CRC32 _crc32;

		// Token: 0x04000175 RID: 373
		private readonly long _lengthLimit = -99L;

		// Token: 0x04000176 RID: 374
		private bool _leaveOpen;
	}
}
