using System;
using System.IO;
using System.Text;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x02000055 RID: 85
	public class ZipInputStream : global::System.IO.Stream
	{
		// Token: 0x060003F8 RID: 1016 RVA: 0x000199FC File Offset: 0x00017BFC
		public ZipInputStream(global::System.IO.Stream stream) : this(stream, false)
		{
		}

		// Token: 0x060003F9 RID: 1017 RVA: 0x00019A08 File Offset: 0x00017C08
		public ZipInputStream(string fileName)
		{
			global::System.IO.Stream stream = global::System.IO.File.Open(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
			this._Init(stream, false, fileName);
		}

		// Token: 0x060003FA RID: 1018 RVA: 0x00019A2E File Offset: 0x00017C2E
		public ZipInputStream(global::System.IO.Stream stream, bool leaveOpen)
		{
			this._Init(stream, leaveOpen, null);
		}

		// Token: 0x060003FB RID: 1019 RVA: 0x00019A40 File Offset: 0x00017C40
		private void _Init(global::System.IO.Stream stream, bool leaveOpen, string name)
		{
			this._inputStream = stream;
			if (!this._inputStream.CanRead)
			{
				throw new global::Ionic.Zip.ZipException("The stream must be readable.");
			}
			this._container = new global::Ionic.Zip.ZipContainer(this);
			this._provisionalAlternateEncoding = global::System.Text.Encoding.GetEncoding("IBM437");
			this._leaveUnderlyingStreamOpen = leaveOpen;
			this._findRequired = true;
			this._name = (name ?? "(stream)");
		}

		// Token: 0x060003FC RID: 1020 RVA: 0x00019AA6 File Offset: 0x00017CA6
		public override string ToString()
		{
			return string.Format("ZipInputStream::{0}(leaveOpen({1})))", this._name, this._leaveUnderlyingStreamOpen);
		}

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060003FD RID: 1021 RVA: 0x00019AC3 File Offset: 0x00017CC3
		// (set) Token: 0x060003FE RID: 1022 RVA: 0x00019ACB File Offset: 0x00017CCB
		public global::System.Text.Encoding ProvisionalAlternateEncoding
		{
			get
			{
				return this._provisionalAlternateEncoding;
			}
			set
			{
				this._provisionalAlternateEncoding = value;
			}
		}

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060003FF RID: 1023 RVA: 0x00019AD4 File Offset: 0x00017CD4
		// (set) Token: 0x06000400 RID: 1024 RVA: 0x00019ADC File Offset: 0x00017CDC
		public int CodecBufferSize { get; set; }

		// Token: 0x170000E8 RID: 232
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00019AE5 File Offset: 0x00017CE5
		public string Password
		{
			set
			{
				if (this._closed)
				{
					this._exceptionPending = true;
					throw new global::System.InvalidOperationException("The stream has been closed.");
				}
				this._Password = value;
			}
		}

		// Token: 0x06000402 RID: 1026 RVA: 0x00019B08 File Offset: 0x00017D08
		private void SetupStream()
		{
			this._crcStream = this._currentEntry.InternalOpenReader(this._Password);
			this._LeftToRead = this._crcStream.Length;
			this._needSetup = false;
		}

		// Token: 0x170000E9 RID: 233
		// (get) Token: 0x06000403 RID: 1027 RVA: 0x00019B39 File Offset: 0x00017D39
		internal global::System.IO.Stream ReadStream
		{
			get
			{
				return this._inputStream;
			}
		}

		// Token: 0x06000404 RID: 1028 RVA: 0x00019B44 File Offset: 0x00017D44
		public override int Read(byte[] buffer, int offset, int count)
		{
			if (this._closed)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException("The stream has been closed.");
			}
			if (this._needSetup)
			{
				this.SetupStream();
			}
			if (this._LeftToRead == 0L)
			{
				return 0;
			}
			int count2 = (this._LeftToRead > (long)count) ? count : ((int)this._LeftToRead);
			int num = this._crcStream.Read(buffer, offset, count2);
			this._LeftToRead -= (long)num;
			if (this._LeftToRead == 0L)
			{
				int crc = this._crcStream.Crc;
				this._currentEntry.VerifyCrcAfterExtract(crc, this._currentEntry.Encryption, this._currentEntry._Crc32, this._currentEntry.ArchiveStream, this._currentEntry.UncompressedSize);
				this._inputStream.Seek(this._endOfEntry, global::System.IO.SeekOrigin.Begin);
			}
			return num;
		}

		// Token: 0x06000405 RID: 1029 RVA: 0x00019C18 File Offset: 0x00017E18
		public global::Ionic.Zip.ZipEntry GetNextEntry()
		{
			if (this._findRequired)
			{
				if (global::Ionic.Zip.SharedUtilities.FindSignature(this._inputStream, 67324752) == -1L)
				{
					return null;
				}
				this._inputStream.Seek(-4L, global::System.IO.SeekOrigin.Current);
			}
			else if (this._firstEntry)
			{
				this._inputStream.Seek(this._endOfEntry, global::System.IO.SeekOrigin.Begin);
			}
			this._currentEntry = global::Ionic.Zip.ZipEntry.ReadEntry(this._container, !this._firstEntry);
			this._endOfEntry = this._inputStream.Position;
			this._firstEntry = true;
			this._needSetup = true;
			this._findRequired = false;
			return this._currentEntry;
		}

		// Token: 0x06000406 RID: 1030 RVA: 0x00019CB6 File Offset: 0x00017EB6
		protected override void Dispose(bool disposing)
		{
			if (this._closed)
			{
				return;
			}
			if (disposing)
			{
				if (this._exceptionPending)
				{
					return;
				}
				if (!this._leaveUnderlyingStreamOpen)
				{
					this._inputStream.Dispose();
				}
			}
			this._closed = true;
		}

		// Token: 0x170000EA RID: 234
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00019CE7 File Offset: 0x00017EE7
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x170000EB RID: 235
		// (get) Token: 0x06000408 RID: 1032 RVA: 0x00019CEA File Offset: 0x00017EEA
		public override bool CanSeek
		{
			get
			{
				return this._inputStream.CanSeek;
			}
		}

		// Token: 0x170000EC RID: 236
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x170000ED RID: 237
		// (get) Token: 0x0600040A RID: 1034 RVA: 0x00019CF7 File Offset: 0x00017EF7
		public override long Length
		{
			get
			{
				return this._inputStream.Length;
			}
		}

		// Token: 0x170000EE RID: 238
		// (get) Token: 0x0600040B RID: 1035 RVA: 0x00019D04 File Offset: 0x00017F04
		// (set) Token: 0x0600040C RID: 1036 RVA: 0x00019D11 File Offset: 0x00017F11
		public override long Position
		{
			get
			{
				return this._inputStream.Position;
			}
			set
			{
				this.Seek(value, global::System.IO.SeekOrigin.Begin);
			}
		}

		// Token: 0x0600040D RID: 1037 RVA: 0x00019D1C File Offset: 0x00017F1C
		public override void Flush()
		{
			throw new global::System.NotSupportedException("Flush");
		}

		// Token: 0x0600040E RID: 1038 RVA: 0x00019D28 File Offset: 0x00017F28
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("Write");
		}

		// Token: 0x0600040F RID: 1039 RVA: 0x00019D34 File Offset: 0x00017F34
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			this._findRequired = true;
			return this._inputStream.Seek(offset, origin);
		}

		// Token: 0x06000410 RID: 1040 RVA: 0x0000A809 File Offset: 0x00008A09
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040002B2 RID: 690
		private global::System.IO.Stream _inputStream;

		// Token: 0x040002B3 RID: 691
		private global::System.Text.Encoding _provisionalAlternateEncoding;

		// Token: 0x040002B4 RID: 692
		private global::Ionic.Zip.ZipEntry _currentEntry;

		// Token: 0x040002B5 RID: 693
		private bool _firstEntry;

		// Token: 0x040002B6 RID: 694
		private bool _needSetup;

		// Token: 0x040002B7 RID: 695
		private global::Ionic.Zip.ZipContainer _container;

		// Token: 0x040002B8 RID: 696
		private global::Ionic.Crc.CrcCalculatorStream _crcStream;

		// Token: 0x040002B9 RID: 697
		private long _LeftToRead;

		// Token: 0x040002BA RID: 698
		internal string _Password;

		// Token: 0x040002BB RID: 699
		private long _endOfEntry;

		// Token: 0x040002BC RID: 700
		private string _name;

		// Token: 0x040002BD RID: 701
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x040002BE RID: 702
		private bool _closed;

		// Token: 0x040002BF RID: 703
		private bool _findRequired;

		// Token: 0x040002C0 RID: 704
		private bool _exceptionPending;
	}
}
