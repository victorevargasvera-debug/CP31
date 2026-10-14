using System;
using System.IO;
using NPOI.HSSF.Record.Crypto;
using NPOI.Util;

namespace NPOI.HSSF.Record
{
	// Token: 0x02000413 RID: 1043
	public class RecordInputStream : global::System.IO.Stream, global::NPOI.Util.ILittleEndianInput
	{
		// Token: 0x060025F6 RID: 9718 RVA: 0x00072ABE File Offset: 0x00070CBE
		public RecordInputStream(global::System.IO.Stream in1) : this(in1, null, 0)
		{
		}

		// Token: 0x060025F7 RID: 9719 RVA: 0x00072ACC File Offset: 0x00070CCC
		public RecordInputStream(global::System.IO.Stream in1, global::NPOI.HSSF.Record.Crypto.Biff8EncryptionKey key, int initialOffset)
		{
			if (key == null)
			{
				this._dataInput = global::NPOI.HSSF.Record.SimpleHeaderInput.GetLEI(in1);
				this._bhi = new global::NPOI.HSSF.Record.SimpleHeaderInput(in1);
			}
			else
			{
				global::NPOI.HSSF.Record.Crypto.Biff8DecryptingStream biff8DecryptingStream = new global::NPOI.HSSF.Record.Crypto.Biff8DecryptingStream(in1, initialOffset, key);
				this._bhi = biff8DecryptingStream;
				this._dataInput = biff8DecryptingStream;
			}
			this._nextSid = this.ReadNextSid();
		}

		// Token: 0x060025F8 RID: 9720 RVA: 0x00072B2D File Offset: 0x00070D2D
		public int Available()
		{
			return this.Remaining;
		}

		// Token: 0x060025F9 RID: 9721 RVA: 0x00072B35 File Offset: 0x00070D35
		public int Read()
		{
			this.CheckRecordPosition(1);
			this._currentDataOffset++;
			this.pos += 1L;
			return this._dataInput.ReadByte();
		}

		// Token: 0x060025FA RID: 9722 RVA: 0x00072B68 File Offset: 0x00070D68
		private int ReadNextSid()
		{
			int num = this._bhi.Available();
			if (num < 4)
			{
				return -1;
			}
			int num2 = this._bhi.ReadRecordSID();
			if (num2 == -1)
			{
				throw new global::NPOI.Util.RecordFormatException("Found invalid sid (" + num2.ToString() + ")");
			}
			this._currentDataLength = -1;
			return num2;
		}

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x060025FB RID: 9723 RVA: 0x00072BBF File Offset: 0x00070DBF
		public short Sid
		{
			get
			{
				return (short)this._currentSid;
			}
		}

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x060025FC RID: 9724 RVA: 0x00072BC8 File Offset: 0x00070DC8
		// (set) Token: 0x060025FD RID: 9725 RVA: 0x00008C75 File Offset: 0x00006E75
		public override long Position
		{
			get
			{
				return this.pos;
			}
			set
			{
				throw new global::System.NotImplementedException();
			}
		}

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x060025FE RID: 9726 RVA: 0x00072BD0 File Offset: 0x00070DD0
		public long CurrentLength
		{
			get
			{
				return (long)this._currentDataLength;
			}
		}

		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x060025FF RID: 9727 RVA: 0x00072BD9 File Offset: 0x00070DD9
		public int RecordOffset
		{
			get
			{
				return this._currentDataOffset;
			}
		}

		// Token: 0x06002600 RID: 9728 RVA: 0x00072BE1 File Offset: 0x00070DE1
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06002601 RID: 9729 RVA: 0x00072BE8 File Offset: 0x00070DE8
		public bool HasNextRecord
		{
			get
			{
				if (this._currentDataLength != -1 && this._currentDataLength != this._currentDataOffset)
				{
					throw new global::NPOI.HSSF.Record.LeftoverDataException(this._currentSid, this.Remaining);
				}
				if (this._currentDataLength != -1)
				{
					this._nextSid = this.ReadNextSid();
				}
				return this._nextSid != -1;
			}
		}

		// Token: 0x06002602 RID: 9730 RVA: 0x00072C40 File Offset: 0x00070E40
		public void NextRecord()
		{
			if (this._nextSid == -1)
			{
				throw new global::System.IO.InvalidDataException("EOF - next record not available");
			}
			if (this._currentDataLength != -1)
			{
				throw new global::System.IO.InvalidDataException("Cannot call nextRecord() without checking hasNextRecord() first");
			}
			this._currentSid = this._nextSid;
			this._currentDataOffset = 0;
			this._currentDataLength = this._bhi.ReadDataSize();
			this.pos += 2L;
			if (this._currentDataLength > 8224)
			{
				throw new global::NPOI.Util.RecordFormatException("The content of an excel record cannot exceed " + 8224.ToString() + " bytes");
			}
		}

		// Token: 0x06002603 RID: 9731 RVA: 0x00072CD8 File Offset: 0x00070ED8
		protected void CheckRecordPosition(int requiredByteCount)
		{
			int remaining = this.Remaining;
			if (remaining >= requiredByteCount)
			{
				return;
			}
			if (remaining == 0 && this.IsContinueNext)
			{
				this.NextRecord();
				return;
			}
			throw new global::NPOI.Util.RecordFormatException(string.Concat(new string[]
			{
				"Not enough data (",
				remaining.ToString(),
				") to read requested (",
				requiredByteCount.ToString(),
				") bytes"
			}));
		}

		// Token: 0x06002604 RID: 9732 RVA: 0x00072B35 File Offset: 0x00070D35
		public override int ReadByte()
		{
			this.CheckRecordPosition(1);
			this._currentDataOffset++;
			this.pos += 1L;
			return this._dataInput.ReadByte();
		}

		// Token: 0x06002605 RID: 9733 RVA: 0x00072D3F File Offset: 0x00070F3F
		public short ReadShort()
		{
			this.CheckRecordPosition(2);
			this._currentDataOffset += 2;
			this.pos += 2L;
			return this._dataInput.ReadShort();
		}

		// Token: 0x06002606 RID: 9734 RVA: 0x00072D70 File Offset: 0x00070F70
		public int ReadInt()
		{
			this.CheckRecordPosition(4);
			this._currentDataOffset += 4;
			this.pos += 4L;
			return this._dataInput.ReadInt();
		}

		// Token: 0x06002607 RID: 9735 RVA: 0x00072DA1 File Offset: 0x00070FA1
		public long ReadLong()
		{
			this.CheckRecordPosition(8);
			this._currentDataOffset += 8;
			this.pos += 8L;
			return this._dataInput.ReadLong();
		}

		// Token: 0x06002608 RID: 9736 RVA: 0x00072DD4 File Offset: 0x00070FD4
		public int ReadUByte()
		{
			int num = this.ReadByte();
			if (num < 0)
			{
				num += 256;
			}
			return num;
		}

		// Token: 0x06002609 RID: 9737 RVA: 0x00072DF5 File Offset: 0x00070FF5
		public int ReadUShort()
		{
			this.CheckRecordPosition(2);
			this._currentDataOffset += 2;
			this.pos += 2L;
			return this._dataInput.ReadUShort();
		}

		// Token: 0x0600260A RID: 9738 RVA: 0x00072E26 File Offset: 0x00071026
		public double ReadDouble()
		{
			this.CheckRecordPosition(8);
			this._currentDataOffset += 8;
			double result = global::System.BitConverter.Int64BitsToDouble(this._dataInput.ReadLong());
			this.pos += 8L;
			return result;
		}

		// Token: 0x0600260B RID: 9739 RVA: 0x00072E5C File Offset: 0x0007105C
		public void ReadFully(byte[] buf)
		{
			this.ReadFully(buf, 0, buf.Length);
		}

		// Token: 0x0600260C RID: 9740 RVA: 0x00072E6C File Offset: 0x0007106C
		public void ReadFully(byte[] buf, int off, int len)
		{
			int num = len;
			if (buf == null)
			{
				throw new global::System.ArgumentNullException();
			}
			if (off < 0 || len < 0 || len > buf.Length - off)
			{
				throw new global::System.IndexOutOfRangeException();
			}
			while (len > 0)
			{
				int num2 = global::System.Math.Min(this.Available(), len);
				if (num2 == 0)
				{
					if (!this.HasNextRecord)
					{
						throw new global::NPOI.Util.RecordFormatException(string.Concat(new string[]
						{
							"Can't read the remaining ",
							len.ToString(),
							" bytes of the requested ",
							num.ToString(),
							" bytes. No further record exists."
						}));
					}
					this.NextRecord();
					num2 = global::System.Math.Min(this.Available(), len);
				}
				this.CheckRecordPosition(num2);
				this._dataInput.ReadFully(buf, off, num2);
				this._currentDataOffset += num2;
				off += num2;
				len -= num2;
				this.pos += (long)num2;
			}
		}

		// Token: 0x0600260D RID: 9741 RVA: 0x00072F48 File Offset: 0x00071148
		public string ReadUnicodeLEString(int requestedLength)
		{
			return this.ReadStringCommon(requestedLength, false);
		}

		// Token: 0x0600260E RID: 9742 RVA: 0x00072F52 File Offset: 0x00071152
		public string ReadCompressedUnicode(int requestedLength)
		{
			return this.ReadStringCommon(requestedLength, true);
		}

		// Token: 0x0600260F RID: 9743 RVA: 0x00072F5C File Offset: 0x0007115C
		private string ReadStringCommon(int requestedLength, bool pIsCompressedEncoding)
		{
			if (requestedLength < 0 || requestedLength > 1048576)
			{
				throw new global::System.ArgumentException("Bad requested string length (" + requestedLength.ToString() + ")");
			}
			char[] array = new char[requestedLength];
			bool flag = pIsCompressedEncoding;
			int i = 0;
			for (;;)
			{
				int j = flag ? this.Remaining : (this.Remaining / 2);
				if (requestedLength - i <= j)
				{
					break;
				}
				while (j > 0)
				{
					char c;
					if (flag)
					{
						c = (char)this.ReadUByte();
					}
					else
					{
						c = (char)this.ReadShort();
					}
					array[i] = c;
					i++;
					j--;
				}
				if (!this.IsContinueNext)
				{
					goto Block_8;
				}
				if (this.Remaining != 0)
				{
					goto Block_9;
				}
				this.NextRecord();
				flag = ((byte)this.ReadByte() == 0);
			}
			while (i < requestedLength)
			{
				char c2;
				if (flag)
				{
					c2 = (char)this.ReadUByte();
				}
				else
				{
					c2 = (char)this.ReadShort();
				}
				array[i] = c2;
				i++;
			}
			return new string(array);
			Block_8:
			throw new global::NPOI.Util.RecordFormatException(string.Concat(new string[]
			{
				"Expected to find a ContinueRecord in order to read remaining ",
				(requestedLength - i).ToString(),
				" of ",
				requestedLength.ToString(),
				" chars"
			}));
			Block_9:
			throw new global::NPOI.Util.RecordFormatException("Odd number of bytes(" + this.Remaining.ToString() + ") left behind");
		}

		// Token: 0x06002610 RID: 9744 RVA: 0x00073098 File Offset: 0x00071298
		public string ReadString()
		{
			int requestedLength = this.ReadUShort();
			byte b = (byte)this.ReadByte();
			return this.ReadStringCommon(requestedLength, b == 0);
		}

		// Token: 0x06002611 RID: 9745 RVA: 0x000730C0 File Offset: 0x000712C0
		public byte[] ReadRemainder()
		{
			int remaining = this.Remaining;
			if (remaining == 0)
			{
				return new byte[0];
			}
			byte[] array = new byte[remaining];
			this.ReadFully(array);
			return array;
		}

		// Token: 0x06002612 RID: 9746 RVA: 0x000730F0 File Offset: 0x000712F0
		public byte[] ReadAllContinuedRemainder()
		{
			byte[] result;
			using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(16448))
			{
				for (;;)
				{
					byte[] array = this.ReadRemainder();
					memoryStream.Write(array, 0, array.Length);
					if (!this.IsContinueNext)
					{
						break;
					}
					this.NextRecord();
				}
				result = memoryStream.ToArray();
			}
			return result;
		}

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06002613 RID: 9747 RVA: 0x00073150 File Offset: 0x00071350
		public int Remaining
		{
			get
			{
				if (this._currentDataLength == -1)
				{
					return 0;
				}
				return this._currentDataLength - this._currentDataOffset;
			}
		}

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06002614 RID: 9748 RVA: 0x0007316A File Offset: 0x0007136A
		public bool IsContinueNext
		{
			get
			{
				if (this._currentDataLength != -1 && this._currentDataOffset != this._currentDataLength)
				{
					throw new global::System.InvalidOperationException("Should never be called before end of current record");
				}
				return this.HasNextRecord && this._nextSid == 60;
			}
		}

		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06002615 RID: 9749 RVA: 0x00072BD0 File Offset: 0x00070DD0
		public override long Length
		{
			get
			{
				return (long)this._currentDataLength;
			}
		}

		// Token: 0x06002616 RID: 9750 RVA: 0x000731A2 File Offset: 0x000713A2
		public override void SetLength(long value)
		{
			this._currentDataLength = (int)value;
		}

		// Token: 0x06002617 RID: 9751 RVA: 0x00072BE1 File Offset: 0x00070DE1
		public override void Flush()
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06002618 RID: 9752 RVA: 0x00008875 File Offset: 0x00006A75
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x06002619 RID: 9753 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600261A RID: 9754 RVA: 0x00006EB4 File Offset: 0x000050B4
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600261B RID: 9755 RVA: 0x00072BE1 File Offset: 0x00070DE1
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x0600261C RID: 9756 RVA: 0x000731AC File Offset: 0x000713AC
		public override int Read(byte[] b, int off, int len)
		{
			int num = global::System.Math.Min(len, this.Remaining);
			if (num == 0)
			{
				return 0;
			}
			this.ReadFully(b, off, num);
			return num;
		}

		// Token: 0x0600261D RID: 9757 RVA: 0x000731D5 File Offset: 0x000713D5
		public int GetNextSid()
		{
			return this._nextSid;
		}

		// Token: 0x04000FEE RID: 4078
		public const short MAX_RECORD_DATA_SIZE = 8224;

		// Token: 0x04000FEF RID: 4079
		private const int INVALID_SID_VALUE = -1;

		// Token: 0x04000FF0 RID: 4080
		private const int DATA_LEN_NEEDS_TO_BE_READ = -1;

		// Token: 0x04000FF1 RID: 4081
		protected int _currentSid;

		// Token: 0x04000FF2 RID: 4082
		protected int _currentDataLength = -1;

		// Token: 0x04000FF3 RID: 4083
		protected int _nextSid = -1;

		// Token: 0x04000FF4 RID: 4084
		private int _currentDataOffset;

		// Token: 0x04000FF5 RID: 4085
		private long pos;

		// Token: 0x04000FF6 RID: 4086
		private global::NPOI.HSSF.Record.BiffHeaderInput _bhi;

		// Token: 0x04000FF7 RID: 4087
		private global::NPOI.Util.ILittleEndianInput _dataInput;
	}
}
