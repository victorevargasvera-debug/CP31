using System;
using System.IO;

namespace Ionic.Zip
{
	// Token: 0x02000476 RID: 1142
	internal class ZipSegmentedStream : global::System.IO.Stream
	{
		// Token: 0x06003274 RID: 12916 RVA: 0x000B8428 File Offset: 0x000B6628
		private ZipSegmentedStream()
		{
			this._exceptionPending = false;
		}

		// Token: 0x06003275 RID: 12917 RVA: 0x000B8438 File Offset: 0x000B6638
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

		// Token: 0x06003276 RID: 12918 RVA: 0x000B8464 File Offset: 0x000B6664
		public static global::Ionic.Zip.ZipSegmentedStream ForWriting(string name, int maxSegmentSize)
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

		// Token: 0x06003277 RID: 12919 RVA: 0x000B84CC File Offset: 0x000B66CC
		public static global::System.IO.Stream ForUpdate(string name, uint diskNumber)
		{
			if (diskNumber >= 99U)
			{
				throw new global::System.ArgumentOutOfRangeException("diskNumber");
			}
			return global::System.IO.File.Open(string.Format("{0}.z{1:D2}", global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(name), global::System.IO.Path.GetFileNameWithoutExtension(name)), diskNumber + 1U), global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.None);
		}

		// Token: 0x17000E80 RID: 3712
		// (get) Token: 0x06003278 RID: 12920 RVA: 0x000B850C File Offset: 0x000B670C
		// (set) Token: 0x06003279 RID: 12921 RVA: 0x000B8514 File Offset: 0x000B6714
		public bool ContiguousWrite { get; set; }

		// Token: 0x17000E81 RID: 3713
		// (get) Token: 0x0600327A RID: 12922 RVA: 0x000B8520 File Offset: 0x000B6720
		// (set) Token: 0x0600327B RID: 12923 RVA: 0x000B8528 File Offset: 0x000B6728
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

		// Token: 0x17000E82 RID: 3714
		// (get) Token: 0x0600327C RID: 12924 RVA: 0x000B8538 File Offset: 0x000B6738
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

		// Token: 0x17000E83 RID: 3715
		// (get) Token: 0x0600327D RID: 12925 RVA: 0x000B8560 File Offset: 0x000B6760
		public string CurrentTempName
		{
			get
			{
				return this._currentTempName;
			}
		}

		// Token: 0x0600327E RID: 12926 RVA: 0x000B8568 File Offset: 0x000B6768
		private string _NameForSegment(uint diskNumber)
		{
			if (diskNumber >= 99U)
			{
				this._exceptionPending = true;
				throw new global::System.OverflowException("The number of zip segments would exceed 99.");
			}
			return string.Format("{0}.z{1:D2}", global::System.IO.Path.Combine(global::System.IO.Path.GetDirectoryName(this._baseName), global::System.IO.Path.GetFileNameWithoutExtension(this._baseName)), diskNumber + 1U);
		}

		// Token: 0x0600327F RID: 12927 RVA: 0x000B85C0 File Offset: 0x000B67C0
		public uint ComputeSegment(int length)
		{
			if (this._innerStream.Position + (long)length > (long)this._maxSegmentSize)
			{
				return this.CurrentSegment + 1U;
			}
			return this.CurrentSegment;
		}

		// Token: 0x06003280 RID: 12928 RVA: 0x000B85EC File Offset: 0x000B67EC
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

		// Token: 0x06003281 RID: 12929 RVA: 0x000B8640 File Offset: 0x000B6840
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

		// Token: 0x06003282 RID: 12930 RVA: 0x000B8698 File Offset: 0x000B6898
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

		// Token: 0x06003283 RID: 12931 RVA: 0x000B8768 File Offset: 0x000B6968
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

		// Token: 0x06003284 RID: 12932 RVA: 0x000B880C File Offset: 0x000B6A0C
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this.rwMode != global::Ionic.Zip.ZipSegmentedStream.RwMode.Write)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException("Stream Error: Cannot Write.");
			}
			if (this.ContiguousWrite)
			{
				if (this._innerStream.Position + (long)count > (long)this._maxSegmentSize)
				{
					this._SetWriteStream(1U);
				}
			}
			else
			{
				while (this._innerStream.Position + (long)count > (long)this._maxSegmentSize)
				{
					int num = this._maxSegmentSize - (int)this._innerStream.Position;
					this._innerStream.Write(buffer, offset, num);
					this._SetWriteStream(1U);
					count -= num;
					offset += num;
				}
			}
			this._innerStream.Write(buffer, offset, count);
		}

		// Token: 0x06003285 RID: 12933 RVA: 0x000B88C4 File Offset: 0x000B6AC4
		public long TruncateBackward(uint diskNumber, long offset)
		{
			if (diskNumber >= 99U)
			{
				throw new global::System.ArgumentOutOfRangeException("diskNumber");
			}
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
					this._currentTempName = global::Ionic.Zip.SharedUtilities.InternalGetTempFileName();
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

		// Token: 0x17000E84 RID: 3716
		// (get) Token: 0x06003286 RID: 12934 RVA: 0x000B89F4 File Offset: 0x000B6BF4
		public override bool CanRead
		{
			get
			{
				return this.rwMode == global::Ionic.Zip.ZipSegmentedStream.RwMode.ReadOnly && this._innerStream != null && this._innerStream.CanRead;
			}
		}

		// Token: 0x17000E85 RID: 3717
		// (get) Token: 0x06003287 RID: 12935 RVA: 0x000B8A1C File Offset: 0x000B6C1C
		public override bool CanSeek
		{
			get
			{
				return this._innerStream != null && this._innerStream.CanSeek;
			}
		}

		// Token: 0x17000E86 RID: 3718
		// (get) Token: 0x06003288 RID: 12936 RVA: 0x000B8A38 File Offset: 0x000B6C38
		public override bool CanWrite
		{
			get
			{
				return this.rwMode == global::Ionic.Zip.ZipSegmentedStream.RwMode.Write && this._innerStream != null && this._innerStream.CanWrite;
			}
		}

		// Token: 0x06003289 RID: 12937 RVA: 0x000B8A60 File Offset: 0x000B6C60
		public override void Flush()
		{
			this._innerStream.Flush();
		}

		// Token: 0x17000E87 RID: 3719
		// (get) Token: 0x0600328A RID: 12938 RVA: 0x000B8A70 File Offset: 0x000B6C70
		public override long Length
		{
			get
			{
				return this._innerStream.Length;
			}
		}

		// Token: 0x17000E88 RID: 3720
		// (get) Token: 0x0600328B RID: 12939 RVA: 0x000B8A80 File Offset: 0x000B6C80
		// (set) Token: 0x0600328C RID: 12940 RVA: 0x000B8A90 File Offset: 0x000B6C90
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

		// Token: 0x0600328D RID: 12941 RVA: 0x000B8AA0 File Offset: 0x000B6CA0
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			return this._innerStream.Seek(offset, origin);
		}

		// Token: 0x0600328E RID: 12942 RVA: 0x000B8AB0 File Offset: 0x000B6CB0
		public override void SetLength(long value)
		{
			if (this.rwMode != global::Ionic.Zip.ZipSegmentedStream.RwMode.Write)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException();
			}
			this._innerStream.SetLength(value);
		}

		// Token: 0x0600328F RID: 12943 RVA: 0x000B8AD8 File Offset: 0x000B6CD8
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

		// Token: 0x040012B6 RID: 4790
		private global::Ionic.Zip.ZipSegmentedStream.RwMode rwMode;

		// Token: 0x040012B7 RID: 4791
		private bool _exceptionPending;

		// Token: 0x040012B8 RID: 4792
		private string _baseName;

		// Token: 0x040012B9 RID: 4793
		private string _baseDir;

		// Token: 0x040012BA RID: 4794
		private string _currentName;

		// Token: 0x040012BB RID: 4795
		private string _currentTempName;

		// Token: 0x040012BC RID: 4796
		private uint _currentDiskNumber;

		// Token: 0x040012BD RID: 4797
		private uint _maxDiskNumber;

		// Token: 0x040012BE RID: 4798
		private int _maxSegmentSize;

		// Token: 0x040012BF RID: 4799
		private global::System.IO.Stream _innerStream;

		// Token: 0x020004ED RID: 1261
		private enum RwMode
		{
			// Token: 0x04001473 RID: 5235
			None,
			// Token: 0x04001474 RID: 5236
			ReadOnly,
			// Token: 0x04001475 RID: 5237
			Write
		}
	}
}
