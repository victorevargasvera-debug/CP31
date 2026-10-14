using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using Ionic.Crc;
using Ionic.Zlib;

namespace Ionic.Zip
{
	// Token: 0x02000056 RID: 86
	public class ZipOutputStream : global::System.IO.Stream
	{
		// Token: 0x06000411 RID: 1041 RVA: 0x00019D4A File Offset: 0x00017F4A
		public ZipOutputStream(global::System.IO.Stream stream) : this(stream, false)
		{
		}

		// Token: 0x06000412 RID: 1042 RVA: 0x00019D54 File Offset: 0x00017F54
		public ZipOutputStream(string fileName)
		{
			this._alternateEncoding = global::System.Text.Encoding.GetEncoding("IBM437");
			this._maxBufferPairs = 16;
			base..ctor();
			global::System.IO.Stream stream = global::System.IO.File.Open(fileName, global::System.IO.FileMode.Create, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.None);
			this._Init(stream, false, fileName);
		}

		// Token: 0x06000413 RID: 1043 RVA: 0x00019D92 File Offset: 0x00017F92
		public ZipOutputStream(global::System.IO.Stream stream, bool leaveOpen)
		{
			this._alternateEncoding = global::System.Text.Encoding.GetEncoding("IBM437");
			this._maxBufferPairs = 16;
			base..ctor();
			this._Init(stream, leaveOpen, null);
		}

		// Token: 0x06000414 RID: 1044 RVA: 0x00019DBC File Offset: 0x00017FBC
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

		// Token: 0x06000415 RID: 1045 RVA: 0x00019E32 File Offset: 0x00018032
		public override string ToString()
		{
			return string.Format("ZipOutputStream::{0}(leaveOpen({1})))", this._name, this._leaveUnderlyingStreamOpen);
		}

		// Token: 0x170000EF RID: 239
		// (set) Token: 0x06000416 RID: 1046 RVA: 0x00019E50 File Offset: 0x00018050
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

		// Token: 0x170000F0 RID: 240
		// (get) Token: 0x06000417 RID: 1047 RVA: 0x00019E9D File Offset: 0x0001809D
		// (set) Token: 0x06000418 RID: 1048 RVA: 0x00019EA5 File Offset: 0x000180A5
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

		// Token: 0x170000F1 RID: 241
		// (get) Token: 0x06000419 RID: 1049 RVA: 0x00019EDE File Offset: 0x000180DE
		// (set) Token: 0x0600041A RID: 1050 RVA: 0x00019EE6 File Offset: 0x000180E6
		public int CodecBufferSize { get; set; }

		// Token: 0x170000F2 RID: 242
		// (get) Token: 0x0600041B RID: 1051 RVA: 0x00019EEF File Offset: 0x000180EF
		// (set) Token: 0x0600041C RID: 1052 RVA: 0x00019EF7 File Offset: 0x000180F7
		public global::Ionic.Zlib.CompressionStrategy Strategy { get; set; }

		// Token: 0x170000F3 RID: 243
		// (get) Token: 0x0600041D RID: 1053 RVA: 0x00019F00 File Offset: 0x00018100
		// (set) Token: 0x0600041E RID: 1054 RVA: 0x00019F08 File Offset: 0x00018108
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

		// Token: 0x170000F4 RID: 244
		// (get) Token: 0x0600041F RID: 1055 RVA: 0x00019F2B File Offset: 0x0001812B
		// (set) Token: 0x06000420 RID: 1056 RVA: 0x00019F33 File Offset: 0x00018133
		public global::Ionic.Zlib.CompressionLevel CompressionLevel { get; set; }

		// Token: 0x170000F5 RID: 245
		// (get) Token: 0x06000421 RID: 1057 RVA: 0x00019F3C File Offset: 0x0001813C
		// (set) Token: 0x06000422 RID: 1058 RVA: 0x00019F44 File Offset: 0x00018144
		public global::Ionic.Zip.CompressionMethod CompressionMethod { get; set; }

		// Token: 0x170000F6 RID: 246
		// (get) Token: 0x06000423 RID: 1059 RVA: 0x00019F4D File Offset: 0x0001814D
		// (set) Token: 0x06000424 RID: 1060 RVA: 0x00019F55 File Offset: 0x00018155
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

		// Token: 0x170000F7 RID: 247
		// (get) Token: 0x06000425 RID: 1061 RVA: 0x00019F78 File Offset: 0x00018178
		// (set) Token: 0x06000426 RID: 1062 RVA: 0x00019F80 File Offset: 0x00018180
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

		// Token: 0x170000F8 RID: 248
		// (get) Token: 0x06000427 RID: 1063 RVA: 0x00019FA3 File Offset: 0x000181A3
		public bool OutputUsedZip64
		{
			get
			{
				return this._anyEntriesUsedZip64 || this._directoryNeededZip64;
			}
		}

		// Token: 0x170000F9 RID: 249
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00019FB5 File Offset: 0x000181B5
		// (set) Token: 0x06000429 RID: 1065 RVA: 0x00019FC0 File Offset: 0x000181C0
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

		// Token: 0x170000FA RID: 250
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00019FCC File Offset: 0x000181CC
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00019FE6 File Offset: 0x000181E6
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

		// Token: 0x170000FB RID: 251
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x0001A010 File Offset: 0x00018210
		// (set) Token: 0x0600042D RID: 1069 RVA: 0x0001A023 File Offset: 0x00018223
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

		// Token: 0x170000FC RID: 252
		// (get) Token: 0x0600042E RID: 1070 RVA: 0x0001A033 File Offset: 0x00018233
		// (set) Token: 0x0600042F RID: 1071 RVA: 0x0001A03B File Offset: 0x0001823B
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

		// Token: 0x170000FD RID: 253
		// (get) Token: 0x06000430 RID: 1072 RVA: 0x0001A044 File Offset: 0x00018244
		// (set) Token: 0x06000431 RID: 1073 RVA: 0x0001A04C File Offset: 0x0001824C
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

		// Token: 0x170000FE RID: 254
		// (get) Token: 0x06000432 RID: 1074 RVA: 0x0001A055 File Offset: 0x00018255
		public static global::System.Text.Encoding DefaultEncoding
		{
			get
			{
				return global::System.Text.Encoding.GetEncoding("IBM437");
			}
		}

		// Token: 0x170000FF RID: 255
		// (get) Token: 0x06000434 RID: 1076 RVA: 0x0001A086 File Offset: 0x00018286
		// (set) Token: 0x06000433 RID: 1075 RVA: 0x0001A061 File Offset: 0x00018261
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

		// Token: 0x17000100 RID: 256
		// (get) Token: 0x06000435 RID: 1077 RVA: 0x0001A08E File Offset: 0x0001828E
		// (set) Token: 0x06000436 RID: 1078 RVA: 0x0001A096 File Offset: 0x00018296
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

		// Token: 0x06000437 RID: 1079 RVA: 0x0001A0B3 File Offset: 0x000182B3
		private void InsureUniqueEntry(global::Ionic.Zip.ZipEntry ze1)
		{
			if (this._entriesWritten.ContainsKey(ze1.FileName))
			{
				this._exceptionPending = true;
				throw new global::System.ArgumentException(string.Format("The entry '{0}' already exists in the zip archive.", ze1.FileName));
			}
		}

		// Token: 0x17000101 RID: 257
		// (get) Token: 0x06000438 RID: 1080 RVA: 0x0001A0E5 File Offset: 0x000182E5
		internal global::System.IO.Stream OutputStream
		{
			get
			{
				return this._outputStream;
			}
		}

		// Token: 0x17000102 RID: 258
		// (get) Token: 0x06000439 RID: 1081 RVA: 0x0001A0ED File Offset: 0x000182ED
		internal string Name
		{
			get
			{
				return this._name;
			}
		}

		// Token: 0x0600043A RID: 1082 RVA: 0x0001A0F5 File Offset: 0x000182F5
		public bool ContainsEntry(string name)
		{
			return this._entriesWritten.ContainsKey(global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(name));
		}

		// Token: 0x0600043B RID: 1083 RVA: 0x0001A108 File Offset: 0x00018308
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

		// Token: 0x0600043C RID: 1084 RVA: 0x0001A1A0 File Offset: 0x000183A0
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

		// Token: 0x0600043D RID: 1085 RVA: 0x0001A2F0 File Offset: 0x000184F0
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

		// Token: 0x0600043E RID: 1086 RVA: 0x0001A3C8 File Offset: 0x000185C8
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

		// Token: 0x0600043F RID: 1087 RVA: 0x0001A47C File Offset: 0x0001867C
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

		// Token: 0x17000103 RID: 259
		// (get) Token: 0x06000440 RID: 1088 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanRead
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000104 RID: 260
		// (get) Token: 0x06000441 RID: 1089 RVA: 0x000060A5 File Offset: 0x000042A5
		public override bool CanSeek
		{
			get
			{
				return false;
			}
		}

		// Token: 0x17000105 RID: 261
		// (get) Token: 0x06000442 RID: 1090 RVA: 0x00019CE7 File Offset: 0x00017EE7
		public override bool CanWrite
		{
			get
			{
				return true;
			}
		}

		// Token: 0x17000106 RID: 262
		// (get) Token: 0x06000443 RID: 1091 RVA: 0x0000A809 File Offset: 0x00008A09
		public override long Length
		{
			get
			{
				throw new global::System.NotSupportedException();
			}
		}

		// Token: 0x17000107 RID: 263
		// (get) Token: 0x06000444 RID: 1092 RVA: 0x0001A515 File Offset: 0x00018715
		// (set) Token: 0x06000445 RID: 1093 RVA: 0x0000A809 File Offset: 0x00008A09
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

		// Token: 0x06000446 RID: 1094 RVA: 0x00002061 File Offset: 0x00000261
		public override void Flush()
		{
		}

		// Token: 0x06000447 RID: 1095 RVA: 0x0001A522 File Offset: 0x00018722
		public override int Read(byte[] buffer, int offset, int count)
		{
			throw new global::System.NotSupportedException("Read");
		}

		// Token: 0x06000448 RID: 1096 RVA: 0x0001A52E File Offset: 0x0001872E
		public override long Seek(long offset, global::System.IO.SeekOrigin origin)
		{
			throw new global::System.NotSupportedException("Seek");
		}

		// Token: 0x06000449 RID: 1097 RVA: 0x0000A809 File Offset: 0x00008A09
		public override void SetLength(long value)
		{
			throw new global::System.NotSupportedException();
		}

		// Token: 0x040002C5 RID: 709
		private global::Ionic.Zip.EncryptionAlgorithm _encryption;

		// Token: 0x040002C6 RID: 710
		private global::Ionic.Zip.ZipEntryTimestamp _timestamp;

		// Token: 0x040002C7 RID: 711
		internal string _password;

		// Token: 0x040002C8 RID: 712
		private string _comment;

		// Token: 0x040002C9 RID: 713
		private global::System.IO.Stream _outputStream;

		// Token: 0x040002CA RID: 714
		private global::Ionic.Zip.ZipEntry _currentEntry;

		// Token: 0x040002CB RID: 715
		internal global::Ionic.Zip.Zip64Option _zip64;

		// Token: 0x040002CC RID: 716
		private global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry> _entriesWritten;

		// Token: 0x040002CD RID: 717
		private int _entryCount;

		// Token: 0x040002CE RID: 718
		private global::Ionic.Zip.ZipOption _alternateEncodingUsage;

		// Token: 0x040002CF RID: 719
		private global::System.Text.Encoding _alternateEncoding;

		// Token: 0x040002D0 RID: 720
		private bool _leaveUnderlyingStreamOpen;

		// Token: 0x040002D1 RID: 721
		private bool _disposed;

		// Token: 0x040002D2 RID: 722
		private bool _exceptionPending;

		// Token: 0x040002D3 RID: 723
		private bool _anyEntriesUsedZip64;

		// Token: 0x040002D4 RID: 724
		private bool _directoryNeededZip64;

		// Token: 0x040002D5 RID: 725
		private global::Ionic.Zip.CountingStream _outputCounter;

		// Token: 0x040002D6 RID: 726
		private global::System.IO.Stream _encryptor;

		// Token: 0x040002D7 RID: 727
		private global::System.IO.Stream _deflater;

		// Token: 0x040002D8 RID: 728
		private global::Ionic.Crc.CrcCalculatorStream _entryOutputStream;

		// Token: 0x040002D9 RID: 729
		private bool _needToWriteEntryHeader;

		// Token: 0x040002DA RID: 730
		private string _name;

		// Token: 0x040002DB RID: 731
		private bool _DontIgnoreCase;

		// Token: 0x040002DC RID: 732
		internal global::Ionic.Zlib.ParallelDeflateOutputStream ParallelDeflater;

		// Token: 0x040002DD RID: 733
		private long _ParallelDeflateThreshold;

		// Token: 0x040002DE RID: 734
		private int _maxBufferPairs;
	}
}
