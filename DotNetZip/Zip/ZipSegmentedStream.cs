using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x02000058 RID: 88
	internal class ZipSegmentedStream : global::System.IO.Stream
	{
		// Token: 0x0600045C RID: 1116 RVA: 0x0001A7D3 File Offset: 0x000189D3
		private ZipSegmentedStream()
		{
			this._exceptionPending = false;
		}

		// Token: 0x0600045D RID: 1117 RVA: 0x0001A7E2 File Offset: 0x000189E2
		public static global::Ionic.Zip.ZipSegmentedStream ForReading(string name, uint initialDiskNumber, uint maxDiskNumber)
		{
			global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream = new global::Ionic.Zip.ZipSegmentedStream();
			zipSegmentedStream.rwMode = global::Ionic.Zip.ZipSegmentedStream.RwMode.ReadOnly;
			zipSegmentedStream.CurrentSegment = initialDiskNumber;
			zipSegmentedStream._maxDiskNumber = maxDiskNumber;
			zipSegmentedStream._baseName = name;
			zipSegmentedStream._SetReadStream();
			return zipSegmentedStream;
		}

		// Token: 0x0600045E RID: 1118 RVA: 0x0001A80B File Offset: 0x00018A0B
		public static global::Ionic.Zip.ZipSegmentedStream ForWriting(string name, int maxSegmentSize)
		{
			return global::Ionic.Zip.ZipSegmentedStream.ForWriting(name, (long)maxSegmentSize);
		}

		// Token: 0x0600045F RID: 1119 RVA: 0x0001A818 File Offset: 0x00018A18
		public static global::Ionic.Zip.ZipSegmentedStream ForWriting(string name, long maxSegmentSize)
		{
			global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream = new global::Ionic.Zip.ZipSegmentedStream
			{
				rwMode = global::Ionic.Zip.ZipSegmentedStream.RwMode.Write,
				CurrentSegment = 0U,
				_baseName = name,
				_maxSegmentSize = maxSegmentSize,
				_baseDir = global::System.IO.Path.GetDirectoryName(name)
			};
			if (zipSegmentedStream._baseDir == "")
			{
				zipSegmentedStream._baseDir = ".";
			}
			zipSegmentedStream._SetWriteStream(0U);
			return zipSegmentedStream;
		}

		// Token: 0x06000460 RID: 1120 RVA: 0x0001A878 File Offset: 0x00018A78
		public static global::System.IO.Stream ForUpdate(string name, uint diskNumber)
		{
			return global::System.IO.File.Open(string.Format("{0}.z{1:D2}", global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(name), global::System.IO.Path.GetFileNameWithoutExtension(name)), diskNumber + 1U), global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.None);
		}

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x06000461 RID: 1121 RVA: 0x0001A8A5 File Offset: 0x00018AA5
		// (set) Token: 0x06000462 RID: 1122 RVA: 0x0001A8AD File Offset: 0x00018AAD
		public bool ContiguousWrite { get; set; }

		// Token: 0x17000119 RID: 281
		// (get) Token: 0x06000463 RID: 1123 RVA: 0x0001A8B6 File Offset: 0x00018AB6
		// (set) Token: 0x06000464 RID: 1124 RVA: 0x0001A8BE File Offset: 0x00018ABE
		public uint CurrentSegment
		{
			get
			{
				return this._currentDiskNumber;
			}
			private set
			{
				this._currentDiskNumber = value;
				this._currentName = null;
			}
		}

		// Token: 0x1700011A RID: 282
		// (get) Token: 0x06000465 RID: 1125 RVA: 0x0001A8CE File Offset: 0x00018ACE
		public string CurrentName
		{
			get
			{
				if (this._currentName == null)
				{
					this._currentName = this._NameForSegment(this.CurrentSegment);
				}
				return this._currentName;
			}
		}

		// Token: 0x1700011B RID: 283
		// (get) Token: 0x06000466 RID: 1126 RVA: 0x0001A8F0 File Offset: 0x00018AF0
		public string CurrentTempName
		{
			get
			{
				return this._currentTempName;
			}
		}

		// Token: 0x06000467 RID: 1127 RVA: 0x0001A8F8 File Offset: 0x00018AF8
		private string _NameForSegment(uint diskNumber)
		{
			return string.Format("{0}.z{1:D2}", global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(this._baseName), global::System.IO.Path.GetFileNameWithoutExtension(this._baseName)), diskNumber + 1U);
		}

		// Token: 0x06000468 RID: 1128 RVA: 0x0001A927 File Offset: 0x00018B27
		public uint ComputeSegment(int length)
		{
			if (this._innerStream.Position + (long)length > this._maxSegmentSize)
			{
				return this.CurrentSegment + 1U;
			}
			return this.CurrentSegment;
		}

		// Token: 0x06000469 RID: 1129 RVA: 0x0001A950 File Offset: 0x00018B50
		public override string ToString()
		{
			return string.Format("{0}[{1}][{2}], pos=0x{3:X})", new object[]
			{
				"ZipSegmentedStream",
				this.CurrentName,
				this.rwMode.ToString(),
				this.Position
			});
		}

		// Token: 0x0600046A RID: 1130 RVA: 0x0001A9A0 File Offset: 0x00018BA0
		private void _SetReadStream()
		{
			if (this._innerStream != null)
			{
				this._innerStream.Dispose();
			}
			if (this.CurrentSegment + 1U == this._maxDiskNumber)
			{
				this._currentName = this._baseName;
			}
			this._innerStream = global::System.IO.File.OpenRead(this.CurrentName);
		}

		// Token: 0x0600046B RID: 1131 RVA: 0x0001A9F0 File Offset: 0x00018BF0
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this.rwMode != global::Ionic.Zip.ZipSegmentedStream.RwMode.ReadOnly)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException("Stream Error: Cannot Read.");
			}
			int num = this._innerStream.Read(buffer, offset, count);
			int num2 = num;
			while (num2 != count)
			{
				if (this._innerStream.Position != this._innerStream.Length)
				{
					this._exceptionPending = true;
					throw new global::Ionic.Zip.ZipException(string.Format("Read error in file {0}", this.CurrentName));
				}
				if (this.CurrentSegment + 1U == this._maxDiskNumber)
				{
					return num;
				}
				uint currentSegment = this.CurrentSegment;
				this.CurrentSegment = currentSegment + 1U;
				this._SetReadStream();
				offset += num2;
				count -= num2;
				num2 = this._innerStream.Read(buffer, offset, count);
				num += num2;
			}
			return num;
		}

		// Token: 0x0600046C RID: 1132 RVA: 0x0001AAAC File Offset: 0x00018CAC
		private void _SetWriteStream(uint increment)
		{
			if (this._innerStream != null)
			{
				this._innerStream.Dispose();
				if (global::System.IO.File.Exists(this.CurrentName))
				{
					global::System.IO.File.Delete(this.CurrentName);
				}
				global::System.IO.File.Move(this._currentTempName, this.CurrentName);
			}
			if (increment > 0U)
			{
				this.CurrentSegment += increment;
			}
			global::Ionic.Zip.SharedUtilities.CreateAndOpenUniqueTempFile(this._baseDir, out this._innerStream, out this._currentTempName);
			if (this.CurrentSegment == 0U)
			{
				this._innerStream.Write(global::System.BitConverter.GetBytes(134695760), 0, 4);
			}
		}

		// Token: 0x0600046D RID: 1133 RVA: 0x0001AB40 File Offset: 0x00018D40
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.rwMode != global::Ionic.Zip.ZipSegmentedStream.RwMode.Write)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException("Stream Error: Cannot Write.");
			}
			if (this.ContiguousWrite)
			{
				if (this._innerStream.Position + (long)count > this._maxSegmentSize)
				{
					this._SetWriteStream(1U);
				}
			}
			else
			{
				while (this._innerStream.Position + (long)count > this._maxSegmentSize)
				{
					long num = this._maxSegmentSize - this._innerStream.Position;
					int num2;
					if (num > (long)buffer.Length)
					{
						num2 = buffer.Length;
					}
					else
					{
						num2 = (int)num;
					}
					this._innerStream.Write(buffer, offset, num2);
					this._SetWriteStream(1U);
					count -= num2;
					offset += num2;
				}
			}
			this._innerStream.Write(buffer, offset, count);
		}

		// Token: 0x0600046E RID: 1134 RVA: 0x0001ABF8 File Offset: 0x00018DF8
		public long TruncateBackward(uint diskNumber, long offset)
		{
			if (this.rwMode != global::Ionic.Zip.ZipSegmentedStream.RwMode.Write)
			{
				this._exceptionPending = true;
				throw new global::Ionic.Zip.ZipException("bad state.");
			}
			if (diskNumber == this.CurrentSegment)
			{
				return this._innerStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
			}
			if (this._innerStream != null)
			{
				this._innerStream.Dispose();
				if (global::System.IO.File.Exists(this._currentTempName))
				{
					global::System.IO.File.Delete(this._currentTempName);
				}
			}
			for (uint num = this.CurrentSegment - 1U; num > diskNumber; num -= 1U)
			{
				string path = this._NameForSegment(num);
				if (global::System.IO.File.Exists(path))
				{
					global::System.IO.File.Delete(path);
				}
			}
			this.CurrentSegment = diskNumber;
			for (int i = 0; i < 3; i++)
			{
				try
				{
					this._currentTempName = global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(this.CurrentName), global::Ionic.Zip.SharedUtilities.InternalGetTempFileName());
					global::System.IO.File.Move(this.CurrentName, this._currentTempName);
					break;
				}
				catch (global::System.IO.IOException)
				{
					if (i == 2)
					{
						throw;
					}
				}
			}
			this._innerStream = new global::System.IO.FileStream(this._currentTempName, global::System.IO.FileMode.Open);
			return this._innerStream.Seek(offset, global::System.IO.SeekOrigin.Begin);
		}

		// Token: 0x1700011C RID: 284
		// (get) Token: 0x0600046F RID: 1135 RVA: 0x0001AD08 File Offset: 0x00018F08
		public override bool CanRead
		{
			get
			{
				return this.rwMode == global::Ionic.Zip.ZipSegmentedStream.RwMode.ReadOnly && this._innerStream != null && this._innerStream.CanRead;
			}
		}

		// Token: 0x1700011D RID: 285
		// (get) Token: 0x06000470 RID: 1136 RVA: 0x0001AD28 File Offset: 0x00018F28
		public override bool CanSeek
		{
			get
			{
				return this._innerStream != null && this._innerStream.CanSeek;
			}
		}

		// Token: 0x1700011E RID: 286
		// (get) Token: 0x06000471 RID: 1137 RVA: 0x0001AD3F File Offset: 0x00018F3F
		public override bool CanWrite
		{
			get
			{
				return this.rwMode == global::Ionic.Zip.ZipSegmentedStream.RwMode.Write && this._innerStream != null && this._innerStream.CanWrite;
			}
		}

		// Token: 0x06000472 RID: 1138 RVA: 0x0001AD5F File Offset: 0x00018F5F
		public override void Flush()
		{
			this._innerStream.Flush();
		}

		// Token: 0x1700011F RID: 287
		// (get) Token: 0x06000473 RID: 1139 RVA: 0x0001AD6C File Offset: 0x00018F6C
		public override long Length
		{
			get
			{
				return this._innerStream.Length;
			}
		}

		// Token: 0x17000120 RID: 288
		// (get) Token: 0x06000474 RID: 1140 RVA: 0x0001AD79 File Offset: 0x00018F79
		// (set) Token: 0x06000475 RID: 1141 RVA: 0x0001AD86 File Offset: 0x00018F86
		public override long Position
		{
			get
			{
				return this._innerStream.Position;
			}
			set
			{
				this._innerStream.Position = value;
			}
		}

		// Token: 0x06000476 RID: 1142 RVA: 0x0001AD94 File Offset: 0x00018F94
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this._innerStream.Seek(offset, origin);
		}

		// Token: 0x06000477 RID: 1143 RVA: 0x0001ADA3 File Offset: 0x00018FA3
		public override void SetLength(long value)
		{
			if (this.rwMode != global::Ionic.Zip.ZipSegmentedStream.RwMode.Write)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException();
			}
			this._innerStream.SetLength(value);
		}

		// Token: 0x06000478 RID: 1144 RVA: 0x0001ADC8 File Offset: 0x00018FC8
		protected override void Dispose(bool disposing)
		{
			try
			{
				if (this._innerStream != null)
				{
					this._innerStream.Dispose();
					if (this.rwMode == global::Ionic.Zip.ZipSegmentedStream.RwMode.Write)
					{
						bool exceptionPending = this._exceptionPending;
					}
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		// Token: 0x040002E2 RID: 738
		private global::Ionic.Zip.ZipSegmentedStream.RwMode rwMode;

		// Token: 0x040002E3 RID: 739
		private bool _exceptionPending;

		// Token: 0x040002E4 RID: 740
		private string _baseName;

		// Token: 0x040002E5 RID: 741
		private string _baseDir;

		// Token: 0x040002E6 RID: 742
		private string _currentName;

		// Token: 0x040002E7 RID: 743
		private string _currentTempName;

		// Token: 0x040002E8 RID: 744
		private uint _currentDiskNumber;

		// Token: 0x040002E9 RID: 745
		private uint _maxDiskNumber;

		// Token: 0x040002EA RID: 746
		private long _maxSegmentSize;

		// Token: 0x040002EB RID: 747
		private global::System.IO.Stream _innerStream;

		// Token: 0x0200007B RID: 123
		private enum RwMode
		{
			// Token: 0x04000422 RID: 1058
			None,
			// Token: 0x04000423 RID: 1059
			ReadOnly,
			// Token: 0x04000424 RID: 1060
			Write
		}
	}
}
