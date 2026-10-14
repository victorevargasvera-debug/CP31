using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x02000474 RID: 1140
	internal class ZipOutputStream : global::System.IO.Stream
	{
		// Token: 0x06003229 RID: 12841 RVA: 0x000B7834 File Offset: 0x000B5A34
		public ZipOutputStream(global::System.IO.Stream stream) : this(stream, false)
		{
		}

		// Token: 0x0600322A RID: 12842 RVA: 0x000B7840 File Offset: 0x000B5A40
		public ZipOutputStream(string fileName)
		{
			this._alternateEncoding = global::System.Text.Encoding.GetEncoding("IBM437");
			this._maxBufferPairs = 16;
			base..ctor();
			global::System.IO.Stream stream = global::System.IO.File.Open(fileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.None);
			this._Init(stream, false, fileName);
		}

		// Token: 0x0600322B RID: 12843 RVA: 0x000B7884 File Offset: 0x000B5A84
		public ZipOutputStream(global::System.IO.Stream stream, bool leaveOpen)
		{
			this._alternateEncoding = global::System.Text.Encoding.GetEncoding("IBM437");
			this._maxBufferPairs = 16;
			base..ctor();
			this._Init(stream, leaveOpen, null);
		}

		// Token: 0x0600322C RID: 12844 RVA: 0x000B78B0 File Offset: 0x000B5AB0
		private void _Init(global::System.IO.Stream stream, bool leaveOpen, string name)
		{
			this._outputStream = (stream.CanRead ? stream : new global::Ionic.Zip.CountingStream(stream));
			this.CompressionLevel = global::Ionic.Zlib.CompressionLevel.Default;
			this.CompressionMethod = global::Ionic.Zip.CompressionMethod.Deflate;
			this._encryption = global::Ionic.Zip.EncryptionAlgorithm.None;
			this._entriesWritten = new global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>(global::System.StringComparer.Ordinal);
			this._zip64 = global::Ionic.Zip.Zip64Option.Default;
			this._leaveUnderlyingStreamOpen = leaveOpen;
			this.Strategy = global::Ionic.Zlib.CompressionStrategy.Default;
			this._name = (name ?? "(stream)");
			this.ParallelDeflateThreshold = -1L;
		}

		// Token: 0x0600322D RID: 12845 RVA: 0x000B7934 File Offset: 0x000B5B34
		public override string ToString()
		{
			return string.Format("ZipOutputStream::{0}(leaveOpen({1})))", this._name, this._leaveUnderlyingStreamOpen);
		}

		// Token: 0x17000E57 RID: 3671
		// (set) Token: 0x0600322E RID: 12846 RVA: 0x000B7954 File Offset: 0x000B5B54
		public string Password
		{
			set
			{
				if (this._disposed)
				{
					this._exceptionPending = true;
					throw new global::System.InvalidOperationException("The stream has been closed.");
				}
				this._password = value;
				if (this._password == null)
				{
					this._encryption = global::Ionic.Zip.EncryptionAlgorithm.None;
					return;
				}
				if (this._encryption == global::Ionic.Zip.EncryptionAlgorithm.None)
				{
					this._encryption = global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak;
				}
			}
		}

		// Token: 0x17000E58 RID: 3672
		// (get) Token: 0x0600322F RID: 12847 RVA: 0x000B79B0 File Offset: 0x000B5BB0
		// (set) Token: 0x06003230 RID: 12848 RVA: 0x000B79B8 File Offset: 0x000B5BB8
		public global::Ionic.Zip.EncryptionAlgorithm Encryption
		{
			get
			{
				return this._encryption;
			}
			set
			{
				if (this._disposed)
				{
					this._exceptionPending = true;
					throw new global::System.InvalidOperationException("The stream has been closed.");
				}
				if (value == global::Ionic.Zip.EncryptionAlgorithm.Unsupported)
				{
					this._exceptionPending = true;
					throw new global::System.InvalidOperationException("You may not set Encryption to that value.");
				}
				this._encryption = value;
			}
		}

		// Token: 0x17000E59 RID: 3673
		// (get) Token: 0x06003231 RID: 12849 RVA: 0x000B79F8 File Offset: 0x000B5BF8
		// (set) Token: 0x06003232 RID: 12850 RVA: 0x000B7A00 File Offset: 0x000B5C00
		public int CodecBufferSize { get; set; }

		// Token: 0x17000E5A RID: 3674
		// (get) Token: 0x06003233 RID: 12851 RVA: 0x000B7A0C File Offset: 0x000B5C0C
		// (set) Token: 0x06003234 RID: 12852 RVA: 0x000B7A14 File Offset: 0x000B5C14
		public global::Ionic.Zlib.CompressionStrategy Strategy { get; set; }

		// Token: 0x17000E5B RID: 3675
		// (get) Token: 0x06003235 RID: 12853 RVA: 0x000B7A20 File Offset: 0x000B5C20
		// (set) Token: 0x06003236 RID: 12854 RVA: 0x000B7A28 File Offset: 0x000B5C28
		public global::Ionic.Zip.ZipEntryTimestamp Timestamp
		{
			get
			{
				return this._timestamp;
			}
			set
			{
				if (this._disposed)
				{
					this._exceptionPending = true;
					throw new global::System.InvalidOperationException("The stream has been closed.");
				}
				this._timestamp = value;
			}
		}

		// Token: 0x17000E5C RID: 3676
		// (get) Token: 0x06003237 RID: 12855 RVA: 0x000B7A50 File Offset: 0x000B5C50
		// (set) Token: 0x06003238 RID: 12856 RVA: 0x000B7A58 File Offset: 0x000B5C58
		public global::Ionic.Zlib.CompressionLevel CompressionLevel { get; set; }

		// Token: 0x17000E5D RID: 3677
		// (get) Token: 0x06003239 RID: 12857 RVA: 0x000B7A64 File Offset: 0x000B5C64
		// (set) Token: 0x0600323A RID: 12858 RVA: 0x000B7A6C File Offset: 0x000B5C6C
		public global::Ionic.Zip.CompressionMethod CompressionMethod { get; set; }

		// Token: 0x17000E5E RID: 3678
		// (get) Token: 0x0600323B RID: 12859 RVA: 0x000B7A78 File Offset: 0x000B5C78
		// (set) Token: 0x0600323C RID: 12860 RVA: 0x000B7A80 File Offset: 0x000B5C80
		public string Comment
		{
			get
			{
				return this._comment;
			}
			set
			{
				if (this._disposed)
				{
					this._exceptionPending = true;
					throw new global::System.InvalidOperationException("The stream has been closed.");
				}
				this._comment = value;
			}
		}

		// Token: 0x17000E5F RID: 3679
		// (get) Token: 0x0600323D RID: 12861 RVA: 0x000B7AA8 File Offset: 0x000B5CA8
		// (set) Token: 0x0600323E RID: 12862 RVA: 0x000B7AB0 File Offset: 0x000B5CB0
		public global::Ionic.Zip.Zip64Option EnableZip64
		{
			get
			{
				return this._zip64;
			}
			set
			{
				if (this._disposed)
				{
					this._exceptionPending = true;
					throw new global::System.InvalidOperationException("The stream has been closed.");
				}
				this._zip64 = value;
			}
		}

		// Token: 0x17000E60 RID: 3680
		// (get) Token: 0x0600323F RID: 12863 RVA: 0x000B7AD8 File Offset: 0x000B5CD8
		public bool OutputUsedZip64
		{
			get
			{
				return this._anyEntriesUsedZip64 || this._directoryNeededZip64;
			}
		}

		// Token: 0x17000E61 RID: 3681
		// (get) Token: 0x06003240 RID: 12864 RVA: 0x000B7AF0 File Offset: 0x000B5CF0
		// (set) Token: 0x06003241 RID: 12865 RVA: 0x000B7AFC File Offset: 0x000B5CFC
		public bool IgnoreCase
		{
			get
			{
				return !this._DontIgnoreCase;
			}
			set
			{
				this._DontIgnoreCase = !value;
			}
		}

		// Token: 0x17000E62 RID: 3682
		// (get) Token: 0x06003242 RID: 12866 RVA: 0x000B7B08 File Offset: 0x000B5D08
		// (set) Token: 0x06003243 RID: 12867 RVA: 0x000B7B28 File Offset: 0x000B5D28
		[global::System.Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete. It will be removed in a future version of the library. Use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			get
			{
				return this._alternateEncoding == global::System.Text.Encoding.UTF8 && this.AlternateEncodingUsage == global::Ionic.Zip.ZipOption.AsNecessary;
			}
			set
			{
				if (value)
				{
					this._alternateEncoding = global::System.Text.Encoding.UTF8;
					this._alternateEncodingUsage = global::Ionic.Zip.ZipOption.AsNecessary;
					return;
				}
				this._alternateEncoding = global::Ionic.Zip.ZipOutputStream.DefaultEncoding;
				this._alternateEncodingUsage = global::Ionic.Zip.ZipOption.Default;
			}
		}

		// Token: 0x17000E63 RID: 3683
		// (get) Token: 0x06003244 RID: 12868 RVA: 0x000B7B58 File Offset: 0x000B5D58
		// (set) Token: 0x06003245 RID: 12869 RVA: 0x000B7B70 File Offset: 0x000B5D70
		[global::System.Obsolete("use AlternateEncoding and AlternateEncodingUsage instead.")]
		public global::System.Text.Encoding ProvisionalAlternateEncoding
		{
			get
			{
				if (this._alternateEncodingUsage == global::Ionic.Zip.ZipOption.AsNecessary)
				{
					return this._alternateEncoding;
				}
				return null;
			}
			set
			{
				this._alternateEncoding = value;
				this._alternateEncodingUsage = global::Ionic.Zip.ZipOption.AsNecessary;
			}
		}

		// Token: 0x17000E64 RID: 3684
		// (get) Token: 0x06003246 RID: 12870 RVA: 0x000B7B80 File Offset: 0x000B5D80
		// (set) Token: 0x06003247 RID: 12871 RVA: 0x000B7B88 File Offset: 0x000B5D88
		public global::System.Text.Encoding AlternateEncoding
		{
			get
			{
				return this._alternateEncoding;
			}
			set
			{
				this._alternateEncoding = value;
			}
		}

		// Token: 0x17000E65 RID: 3685
		// (get) Token: 0x06003248 RID: 12872 RVA: 0x000B7B94 File Offset: 0x000B5D94
		// (set) Token: 0x06003249 RID: 12873 RVA: 0x000B7B9C File Offset: 0x000B5D9C
		public global::Ionic.Zip.ZipOption AlternateEncodingUsage
		{
			get
			{
				return this._alternateEncodingUsage;
			}
			set
			{
				this._alternateEncodingUsage = value;
			}
		}

		// Token: 0x17000E66 RID: 3686
		// (get) Token: 0x0600324A RID: 12874 RVA: 0x000B7BA8 File Offset: 0x000B5DA8
		public static global::System.Text.Encoding DefaultEncoding
		{
			get
			{
				return global::System.Text.Encoding.GetEncoding("IBM437");
			}
		}

		// Token: 0x17000E67 RID: 3687
		// (get) Token: 0x0600324C RID: 12876 RVA: 0x000B7BE4 File Offset: 0x000B5DE4
		// (set) Token: 0x0600324B RID: 12875 RVA: 0x000B7BB4 File Offset: 0x000B5DB4
		public long ParallelDeflateThreshold
		{
			get
			{
				return this._ParallelDeflateThreshold;
			}
			set
			{
				if (value != 0L && value != -1L && value < 65536L)
				{
					throw new global::System.ArgumentOutOfRangeException("value must be greater than 64k, or 0, or -1");
				}
				this._ParallelDeflateThreshold = value;
			}
		}

		// Token: 0x17000E68 RID: 3688
		// (get) Token: 0x0600324D RID: 12877 RVA: 0x000B7BEC File Offset: 0x000B5DEC
		// (set) Token: 0x0600324E RID: 12878 RVA: 0x000B7BF4 File Offset: 0x000B5DF4
		public int ParallelDeflateMaxBufferPairs
		{
			get
			{
				return this._maxBufferPairs;
			}
			set
			{
				if (value < 4)
				{
					throw new global::System.ArgumentOutOfRangeException("ParallelDeflateMaxBufferPairs", "Value must be 4 or greater.");
				}
				this._maxBufferPairs = value;
			}
		}

		// Token: 0x0600324F RID: 12879 RVA: 0x000B7C14 File Offset: 0x000B5E14
		private void InsureUniqueEntry(global::Ionic.Zip.ZipEntry ze1)
		{
			if (this._entriesWritten.ContainsKey(ze1.FileName))
			{
				this._exceptionPending = true;
				throw new global::System.ArgumentException(string.Format("The entry '{0}' already exists in the zip archive.", ze1.FileName));
			}
		}

		// Token: 0x17000E69 RID: 3689
		// (get) Token: 0x06003250 RID: 12880 RVA: 0x000B7C4C File Offset: 0x000B5E4C
		internal global::System.IO.Stream OutputStream
		{
			get
			{
				return this._outputStream;
			}
		}

		// Token: 0x17000E6A RID: 3690
		// (get) Token: 0x06003251 RID: 12881 RVA: 0x000B7C54 File Offset: 0x000B5E54
		internal string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x06003252 RID: 12882 RVA: 0x000B7C5C File Offset: 0x000B5E5C
		public bool ContainsEntry(string name)
		{
			return this._entriesWritten.ContainsKey(global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(name));
		}

		// Token: 0x06003253 RID: 12883 RVA: 0x000B7C70 File Offset: 0x000B5E70
		public override void Write(byte[] buffer, int offset, int count)
		{
			if (this._disposed)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException("The stream has been closed.");
			}
			if (buffer == null)
			{
				this._exceptionPending = true;
				throw new global::System.ArgumentNullException("buffer");
			}
			if (this._currentEntry == null)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException("You must call PutNextEntry() before calling Write().");
			}
			if (this._currentEntry.IsDirectory)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException("You cannot Write() data for an entry that is a directory.");
			}
			if (this._needToWriteEntryHeader)
			{
				this._InitiateCurrentEntry(false);
			}
			if (count != 0)
			{
				this._entryOutputStream.Write(buffer, offset, count);
			}
		}

		// Token: 0x06003254 RID: 12884 RVA: 0x000B7D1C File Offset: 0x000B5F1C
		public global::Ionic.Zip.ZipEntry PutNextEntry(string entryName)
		{
			if (string.IsNullOrEmpty(entryName))
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			if (this._disposed)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException("The stream has been closed.");
			}
			this._FinishCurrentEntry();
			this._currentEntry = global::Ionic.Zip.ZipEntry.CreateForZipOutputStream(entryName);
			this._currentEntry._container = new global::Ionic.Zip.ZipContainer(this);
			global::Ionic.Zip.ZipEntry currentEntry = this._currentEntry;
			currentEntry._BitField |= 8;
			this._currentEntry.SetEntryTimes(global::System.DateTime.Now, global::System.DateTime.Now, global::System.DateTime.Now);
			this._currentEntry.CompressionLevel = this.CompressionLevel;
			this._currentEntry.CompressionMethod = this.CompressionMethod;
			this._currentEntry.Password = this._password;
			this._currentEntry.Encryption = this.Encryption;
			this._currentEntry.AlternateEncoding = this.AlternateEncoding;
			this._currentEntry.AlternateEncodingUsage = this.AlternateEncodingUsage;
			if (entryName.EndsWith("/"))
			{
				this._currentEntry.MarkAsDirectory();
			}
			this._currentEntry.EmitTimesInWindowsFormatWhenSaving = ((this._timestamp & global::Ionic.Zip.ZipEntryTimestamp.Windows) > global::Ionic.Zip.ZipEntryTimestamp.None);
			this._currentEntry.EmitTimesInUnixFormatWhenSaving = ((this._timestamp & global::Ionic.Zip.ZipEntryTimestamp.Unix) > global::Ionic.Zip.ZipEntryTimestamp.None);
			this.InsureUniqueEntry(this._currentEntry);
			this._needToWriteEntryHeader = true;
			return this._currentEntry;
		}

		// Token: 0x06003255 RID: 12885 RVA: 0x000B7E78 File Offset: 0x000B6078
		private void _InitiateCurrentEntry(bool finishing)
		{
			this._entriesWritten.Add(this._currentEntry.FileName, this._currentEntry);
			this._entryCount++;
			if (this._entryCount > 65534 && this._zip64 == global::Ionic.Zip.Zip64Option.Default)
			{
				this._exceptionPending = true;
				throw new global::System.InvalidOperationException("Too many entries. Consider setting ZipOutputStream.EnableZip64.");
			}
			this._currentEntry.WriteHeader(this._outputStream, finishing ? 99 : 0);
			this._currentEntry.StoreRelativeOffset();
			if (!this._currentEntry.IsDirectory)
			{
				this._currentEntry.WriteSecurityMetadata(this._outputStream);
				this._currentEntry.PrepOutputStream(this._outputStream, finishing ? 0L : -1L, out this._outputCounter, out this._encryptor, out this._deflater, out this._entryOutputStream);
			}
			this._needToWriteEntryHeader = false;
		}

		// Token: 0x06003256 RID: 12886 RVA: 0x000B7F6C File Offset: 0x000B616C
		private void _FinishCurrentEntry()
		{
			if (this._currentEntry != null)
			{
				if (this._needToWriteEntryHeader)
				{
					this._InitiateCurrentEntry(true);
				}
				this._currentEntry.FinishOutputStream(this._outputStream, this._outputCounter, this._encryptor, this._deflater, this._entryOutputStream);
				this._currentEntry.PostProcessOutput(this._outputStream);
				if (this._currentEntry.OutputUsedZip64 != null)
				{
					this._anyEntriesUsedZip64 |= this._currentEntry.OutputUsedZip64.Value;
				}
				this._outputCounter = null;
				this._encryptor = (this._deflater = null);
				this._entryOutputStream = null;
			}
		}

		// Token: 0x06003257 RID: 12887 RVA: 0x000B802C File Offset: 0x000B622C
		protected override void Dispose(bool disposing)
		{
			if (this._disposed)
			{
				return;
			}
			if (disposing && !this._exceptionPending)
			{
				this._FinishCurrentEntry();
				this._directoryNeededZip64 = global::Ionic.Zip.ZipOutput.WriteCentralDirectoryStructure(this._outputStream, this._entriesWritten.Values, 1U, this._zip64, this.Comment, new global::Ionic.Zip.ZipContainer(this));
				global::Ionic.Zip.CountingStream countingStream = this._outputStream as global::Ionic.Zip.CountingStream;
				global::System.IO.Stream stream;
				if (countingStream != null)
				{
					stream = countingStream.WrappedStream;
					countingStream.Dispose();
				}
				else
				{
					stream = this._outputStream;
				}
				if (!this._leaveUnderlyingStreamOpen)
				{
					stream.Dispose();
				}
				this._outputStream = null;
			}
			this._disposed = true;
		}

		// Token: 0x17000E6B RID: 3691
		// (get) Token: 0x06003258 RID: 12888 RVA: 0x000B80DC File Offset: 0x000B62DC
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000E6C RID: 3692
		// (get) Token: 0x06003259 RID: 12889 RVA: 0x000B80E0 File Offset: 0x000B62E0
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000E6D RID: 3693
		// (get) Token: 0x0600325A RID: 12890 RVA: 0x000B80E4 File Offset: 0x000B62E4
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000E6E RID: 3694
		// (get) Token: 0x0600325B RID: 12891 RVA: 0x000B80E8 File Offset: 0x000B62E8
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000E6F RID: 3695
		// (get) Token: 0x0600325C RID: 12892 RVA: 0x000B80F0 File Offset: 0x000B62F0
		// (set) Token: 0x0600325D RID: 12893 RVA: 0x000B8100 File Offset: 0x000B6300
		public override long Position
		{
			get
			{
				return this._outputStream.Position;
			}
			set
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x0600325E RID: 12894 RVA: 0x000B8108 File Offset: 0x000B6308
		public override void Flush()
		{
		}

		// Token: 0x0600325F RID: 12895 RVA: 0x000B810C File Offset: 0x000B630C
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("Read");
		}

		// Token: 0x06003260 RID: 12896 RVA: 0x000B8118 File Offset: 0x000B6318
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("Seek");
		}

		// Token: 0x06003261 RID: 12897 RVA: 0x000B8124 File Offset: 0x000B6324
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x04001299 RID: 4761
		private global::Ionic.Zip.EncryptionAlgorithm _encryption;

		// Token: 0x0400129A RID: 4762
		private global::Ionic.Zip.ZipEntryTimestamp _timestamp;

		// Token: 0x0400129B RID: 4763
		internal string _password;

		// Token: 0x0400129C RID: 4764
		private string _comment;

		// Token: 0x0400129D RID: 4765
		private global::System.IO.Stream _outputStream;

		// Token: 0x0400129E RID: 4766
		private global::Ionic.Zip.ZipEntry _currentEntry;

		// Token: 0x0400129F RID: 4767
		internal global::Ionic.Zip.Zip64Option _zip64;

		// Token: 0x040012A0 RID: 4768
		private global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry> _entriesWritten;

		// Token: 0x040012A1 RID: 4769
		private int _entryCount;

		// Token: 0x040012A2 RID: 4770
		private global::Ionic.Zip.ZipOption _alternateEncodingUsage;

		// Token: 0x040012A3 RID: 4771
		private global::System.Text.Encoding _alternateEncoding;

		// Token: 0x040012A4 RID: 4772
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x040012A5 RID: 4773
		private bool _disposed;

		// Token: 0x040012A6 RID: 4774
		private bool _exceptionPending;

		// Token: 0x040012A7 RID: 4775
		private bool _anyEntriesUsedZip64;

		// Token: 0x040012A8 RID: 4776
		private bool _directoryNeededZip64;

		// Token: 0x040012A9 RID: 4777
		private global::Ionic.Zip.CountingStream _outputCounter;

		// Token: 0x040012AA RID: 4778
		private global::System.IO.Stream _encryptor;

		// Token: 0x040012AB RID: 4779
		private global::System.IO.Stream _deflater;

		// Token: 0x040012AC RID: 4780
		private global::Ionic.Crc.CrcCalculatorStream _entryOutputStream;

		// Token: 0x040012AD RID: 4781
		private bool _needToWriteEntryHeader;

		// Token: 0x040012AE RID: 4782
		private string _name;

		// Token: 0x040012AF RID: 4783
		private bool _DontIgnoreCase;

		// Token: 0x040012B0 RID: 4784
		internal global::Ionic.Zlib.ParallelDeflateOutputStream ParallelDeflater;

		// Token: 0x040012B1 RID: 4785
		private long _ParallelDeflateThreshold;

		// Token: 0x040012B2 RID: 4786
		private int _maxBufferPairs;
	}
}
