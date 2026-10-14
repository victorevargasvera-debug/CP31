using System;
using System.IO;

namespace Ionic.Crc
{
	// Token: 0x02000425 RID: 1061
	internal class CrcCalculatorStream : global::System.IO.Stream, global::System.IDisposable
	{
		// Token: 0x06002DF5 RID: 11765 RVA: 0x0009B704 File Offset: 0x00099904
		public CrcCalculatorStream(global::System.IO.Stream stream) : this(true, global::Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit, stream, null)
		{
		}

		// Token: 0x06002DF6 RID: 11766 RVA: 0x0009B714 File Offset: 0x00099914
		public CrcCalculatorStream(global::System.IO.Stream stream, bool leaveOpen) : this(leaveOpen, global::Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit, stream, null)
		{
		}

		// Token: 0x06002DF7 RID: 11767 RVA: 0x0009B724 File Offset: 0x00099924
		public CrcCalculatorStream(global::System.IO.Stream stream, long length) : this(true, length, stream, null)
		{
			if (length < 0L)
			{
				throw new global::System.ArgumentException("length");
			}
		}

		// Token: 0x06002DF8 RID: 11768 RVA: 0x0009B744 File Offset: 0x00099944
		public CrcCalculatorStream(global::System.IO.Stream stream, long length, bool leaveOpen) : this(leaveOpen, length, stream, null)
		{
			if (length < 0L)
			{
				throw new global::System.ArgumentException("length");
			}
		}

		// Token: 0x06002DF9 RID: 11769 RVA: 0x0009B764 File Offset: 0x00099964
		public CrcCalculatorStream(global::System.IO.Stream stream, long length, bool leaveOpen, global::Ionic.Crc.CRC32 crc32) : this(leaveOpen, length, stream, crc32)
		{
			if (length < 0L)
			{
				throw new global::System.ArgumentException("length");
			}
		}

		// Token: 0x06002DFA RID: 11770 RVA: 0x0009B784 File Offset: 0x00099984
		private CrcCalculatorStream(bool leaveOpen, long length, global::System.IO.Stream stream, global::Ionic.Crc.CRC32 crc32)
		{
			this._innerStream = stream;
			this._Crc32 = (crc32 ?? new global::Ionic.Crc.CRC32());
			this._lengthLimit = length;
			this._leaveOpen = leaveOpen;
		}

		// Token: 0x17000D5A RID: 3418
		// (get) Token: 0x06002DFB RID: 11771 RVA: 0x0009B7C0 File Offset: 0x000999C0
		public long TotalBytesSlurped
		{
			get
			{
				return this._Crc32.TotalBytesRead;
			}
		}

		// Token: 0x17000D5B RID: 3419
		// (get) Token: 0x06002DFC RID: 11772 RVA: 0x0009B7D0 File Offset: 0x000999D0
		public int Crc
		{
			get
			{
				return this._Crc32.Crc32Result;
			}
		}

		// Token: 0x17000D5C RID: 3420
		// (get) Token: 0x06002DFD RID: 11773 RVA: 0x0009B7E0 File Offset: 0x000999E0
		// (set) Token: 0x06002DFE RID: 11774 RVA: 0x0009B7E8 File Offset: 0x000999E8
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

		// Token: 0x06002DFF RID: 11775 RVA: 0x0009B7F4 File Offset: 0x000999F4
		public override int Read(byte[] buffer, int offset, int count)
		{
			int count2 = count;
			if (this._lengthLimit != global::Ionic.Crc.CrcCalculatorStream.UnsetLengthLimit)
			{
				if (this._Crc32.TotalBytesRead >= this._lengthLimit)
				{
					return 0;
				}
				long num = this._lengthLimit - this._Crc32.TotalBytesRead;
				if (num < (long)count)
				{
					count2 = (int)num;
				}
			}
			int num2 = this._innerStream.Read(buffer, offset, count2);
			if (num2 > 0)
			{
				this._Crc32.SlurpBlock(buffer, offset, num2);
			}
			return num2;
		}

		// Token: 0x06002E00 RID: 11776 RVA: 0x0009B874 File Offset: 0x00099A74
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (count > 0)
			{
				this._Crc32.SlurpBlock(buffer, offset, count);
			}
			this._innerStream.Write(buffer, offset, count);
		}

		// Token: 0x17000D5D RID: 3421
		// (get) Token: 0x06002E01 RID: 11777 RVA: 0x0009B89C File Offset: 0x00099A9C
		public override bool CanRead
		{
			get
			{
				return this._innerStream.CanRead;
			}
		}

		// Token: 0x17000D5E RID: 3422
		// (get) Token: 0x06002E02 RID: 11778 RVA: 0x0009B8AC File Offset: 0x00099AAC
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000D5F RID: 3423
		// (get) Token: 0x06002E03 RID: 11779 RVA: 0x0009B8B0 File Offset: 0x00099AB0
		public override bool CanWrite
		{
			get
			{
				return this._innerStream.CanWrite;
			}
		}

		// Token: 0x06002E04 RID: 11780 RVA: 0x0009B8C0 File Offset: 0x00099AC0
		public override void Flush()
		{
			this._innerStream.Flush();
		}

		// Token: 0x17000D60 RID: 3424
		// (get) Token: 0x06002E05 RID: 11781 RVA: 0x0009B8D0 File Offset: 0x00099AD0
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

		// Token: 0x17000D61 RID: 3425
		// (get) Token: 0x06002E06 RID: 11782 RVA: 0x0009B8F4 File Offset: 0x00099AF4
		// (set) Token: 0x06002E07 RID: 11783 RVA: 0x0009B904 File Offset: 0x00099B04
		public override long Position
		{
			get
			{
				return this._Crc32.TotalBytesRead;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x06002E08 RID: 11784 RVA: 0x0009B90C File Offset: 0x00099B0C
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002E09 RID: 11785 RVA: 0x0009B914 File Offset: 0x00099B14
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x06002E0A RID: 11786 RVA: 0x0009B91C File Offset: 0x00099B1C
		void global::System.IDisposable.Dispose()
		{
			this.Close();
		}

		// Token: 0x06002E0B RID: 11787 RVA: 0x0009B924 File Offset: 0x00099B24
		public override void Close()
		{
			base.Close();
			if (!this._leaveOpen)
			{
				this._innerStream.Close();
			}
		}

		// Token: 0x04000F95 RID: 3989
		private static readonly long UnsetLengthLimit = -99L;

		// Token: 0x04000F96 RID: 3990
		internal global::System.IO.Stream _innerStream;

		// Token: 0x04000F97 RID: 3991
		private global::Ionic.Crc.CRC32 _Crc32;

		// Token: 0x04000F98 RID: 3992
		private long _lengthLimit = -99L;

		// Token: 0x04000F99 RID: 3993
		private bool _leaveOpen;
	}
}
