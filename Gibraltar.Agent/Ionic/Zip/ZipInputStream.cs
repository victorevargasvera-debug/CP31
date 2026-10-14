using System;
using System.IO;
using System.Text;
using Ionic.Crc;

namespace Ionic.Zip
{
	// Token: 0x02000473 RID: 1139
	internal class ZipInputStream : global::System.IO.Stream
	{
		// Token: 0x06003210 RID: 12816 RVA: 0x000B74A4 File Offset: 0x000B56A4
		public ZipInputStream(global::System.IO.Stream stream) : this(stream, false)
		{
		}

		// Token: 0x06003211 RID: 12817 RVA: 0x000B74B0 File Offset: 0x000B56B0
		public ZipInputStream(string fileName)
		{
			global::System.IO.Stream stream = global::System.IO.File.Open(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
			this._Init(stream, false, fileName);
		}

		// Token: 0x06003212 RID: 12818 RVA: 0x000B74DC File Offset: 0x000B56DC
		public ZipInputStream(global::System.IO.Stream stream, bool leaveOpen)
		{
			this._Init(stream, leaveOpen, null);
		}

		// Token: 0x06003213 RID: 12819 RVA: 0x000B74F0 File Offset: 0x000B56F0
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

		// Token: 0x06003214 RID: 12820 RVA: 0x000B7560 File Offset: 0x000B5760
		public override string ToString()
		{
			return string.Format("ZipInputStream::{0}(leaveOpen({1})))", this._name, this._leaveUnderlyingStreamOpen);
		}

		// Token: 0x17000E4E RID: 3662
		// (get) Token: 0x06003215 RID: 12821 RVA: 0x000B7580 File Offset: 0x000B5780
		// (set) Token: 0x06003216 RID: 12822 RVA: 0x000B7588 File Offset: 0x000B5788
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

		// Token: 0x17000E4F RID: 3663
		// (get) Token: 0x06003217 RID: 12823 RVA: 0x000B7594 File Offset: 0x000B5794
		// (set) Token: 0x06003218 RID: 12824 RVA: 0x000B759C File Offset: 0x000B579C
		public int CodecBufferSize { get; set; }

		// Token: 0x17000E50 RID: 3664
		// (set) Token: 0x06003219 RID: 12825 RVA: 0x000B75A8 File Offset: 0x000B57A8
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

		// Token: 0x0600321A RID: 12826 RVA: 0x000B75D0 File Offset: 0x000B57D0
		private void SetupStream()
		{
			this._crcStream = this._currentEntry.InternalOpenReader(this._Password);
			this._LeftToRead = this._crcStream.Length;
			this._needSetup = false;
		}

		// Token: 0x17000E51 RID: 3665
		// (get) Token: 0x0600321B RID: 12827 RVA: 0x000B7604 File Offset: 0x000B5804
		internal global::System.IO.Stream ReadStream
		{
			get
			{
				return this._inputStream;
			}
		}

		// Token: 0x0600321C RID: 12828 RVA: 0x000B760C File Offset: 0x000B580C
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
				this._currentEntry.VerifyCrcAfterExtract(crc);
				this._inputStream.Seek(this._endOfEntry, global::System.IO.SeekOrigin.Begin);
			}
			return num;
		}

		// Token: 0x0600321D RID: 12829 RVA: 0x000B76C8 File Offset: 0x000B58C8
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

		// Token: 0x0600321E RID: 12830 RVA: 0x000B7778 File Offset: 0x000B5978
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

		// Token: 0x17000E52 RID: 3666
		// (get) Token: 0x0600321F RID: 12831 RVA: 0x000B77B8 File Offset: 0x000B59B8
		public override bool CanRead
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000E53 RID: 3667
		// (get) Token: 0x06003220 RID: 12832 RVA: 0x000B77BC File Offset: 0x000B59BC
		public override bool CanSeek
		{
			get
			{
				return this._inputStream.CanSeek;
			}
		}

		// Token: 0x17000E54 RID: 3668
		// (get) Token: 0x06003221 RID: 12833 RVA: 0x000B77CC File Offset: 0x000B59CC
		public override bool CanWrite
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000E55 RID: 3669
		// (get) Token: 0x06003222 RID: 12834 RVA: 0x000B77D0 File Offset: 0x000B59D0
		public override long Length
		{
			get
			{
				return this._inputStream.Length;
			}
		}

		// Token: 0x17000E56 RID: 3670
		// (get) Token: 0x06003223 RID: 12835 RVA: 0x000B77E0 File Offset: 0x000B59E0
		// (set) Token: 0x06003224 RID: 12836 RVA: 0x000B77F0 File Offset: 0x000B59F0
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

		// Token: 0x06003225 RID: 12837 RVA: 0x000B77FC File Offset: 0x000B59FC
		public override void Flush()
		{
			throw new global::System.NotSupportedException("Flush");
		}

		// Token: 0x06003226 RID: 12838 RVA: 0x000B7808 File Offset: 0x000B5A08
		public override void Write(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("Write");
		}

		// Token: 0x06003227 RID: 12839 RVA: 0x000B7814 File Offset: 0x000B5A14
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			this._findRequired = true;
			return this._inputStream.Seek(offset, origin);
		}

		// Token: 0x06003228 RID: 12840 RVA: 0x000B782C File Offset: 0x000B5A2C
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x04001286 RID: 4742
		private global::System.IO.Stream _inputStream;

		// Token: 0x04001287 RID: 4743
		private global::System.Text.Encoding _provisionalAlternateEncoding;

		// Token: 0x04001288 RID: 4744
		private global::Ionic.Zip.ZipEntry _currentEntry;

		// Token: 0x04001289 RID: 4745
		private bool _firstEntry;

		// Token: 0x0400128A RID: 4746
		private bool _needSetup;

		// Token: 0x0400128B RID: 4747
		private global::Ionic.Zip.ZipContainer _container;

		// Token: 0x0400128C RID: 4748
		private global::Ionic.Crc.CrcCalculatorStream _crcStream;

		// Token: 0x0400128D RID: 4749
		private long _LeftToRead;

		// Token: 0x0400128E RID: 4750
		internal string _Password;

		// Token: 0x0400128F RID: 4751
		private long _endOfEntry;

		// Token: 0x04001290 RID: 4752
		private string _name;

		// Token: 0x04001291 RID: 4753
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x04001292 RID: 4754
		private bool _closed;

		// Token: 0x04001293 RID: 4755
		private bool _findRequired;

		// Token: 0x04001294 RID: 4756
		private bool _exceptionPending;
	}
}
