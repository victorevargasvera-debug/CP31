using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using ICSharpCode.SharpZipLib.BZip2;
using ICSharpCode.SharpZipLib.Checksum;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Encryption;
using ICSharpCode.SharpZipLib.Zip.Compression;
using ICSharpCode.SharpZipLib.Zip.Compression.Streams;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000022 RID: 34
	public class ZipFile : global::System.Collections.IEnumerable, global::System.IDisposable
	{
		// Token: 0x06000119 RID: 281 RVA: 0x00004E74 File Offset: 0x00003074
		private void OnKeysRequired(string fileName)
		{
			if (this.KeysRequired != null)
			{
				global::ICSharpCode.SharpZipLib.Zip.KeysRequiredEventArgs keysRequiredEventArgs = new global::ICSharpCode.SharpZipLib.Zip.KeysRequiredEventArgs(fileName, this.key);
				this.KeysRequired(this, keysRequiredEventArgs);
				this.key = keysRequiredEventArgs.Key;
			}
		}

		// Token: 0x17000051 RID: 81
		// (get) Token: 0x0600011A RID: 282 RVA: 0x00004EAF File Offset: 0x000030AF
		// (set) Token: 0x0600011B RID: 283 RVA: 0x00004EB7 File Offset: 0x000030B7
		private byte[] Key
		{
			get
			{
				return this.key;
			}
			set
			{
				this.key = value;
			}
		}

		// Token: 0x17000052 RID: 82
		// (set) Token: 0x0600011C RID: 284 RVA: 0x00004EC0 File Offset: 0x000030C0
		public string Password
		{
			set
			{
				if (string.IsNullOrEmpty(value))
				{
					this.key = null;
				}
				else
				{
					this.key = global::ICSharpCode.SharpZipLib.Encryption.PkzipClassic.GenerateKeys(global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(value));
				}
				this.rawPassword_ = value;
			}
		}

		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600011D RID: 285 RVA: 0x00004EEB File Offset: 0x000030EB
		private bool HaveKeys
		{
			get
			{
				return this.key != null;
			}
		}

		// Token: 0x0600011E RID: 286 RVA: 0x00004EF8 File Offset: 0x000030F8
		public ZipFile(string name)
		{
			if (name == null)
			{
				throw new global::System.ArgumentNullException("name");
			}
			this.name_ = name;
			this.baseStream_ = global::System.IO.File.Open(name, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
			this.isStreamOwner = true;
			try
			{
				this.ReadEntries();
			}
			catch
			{
				this.DisposeInternal(true);
				throw;
			}
		}

		// Token: 0x0600011F RID: 287 RVA: 0x00004F78 File Offset: 0x00003178
		public ZipFile(global::System.IO.FileStream file) : this(file, false)
		{
		}

		// Token: 0x06000120 RID: 288 RVA: 0x00004F84 File Offset: 0x00003184
		public ZipFile(global::System.IO.FileStream file, bool leaveOpen)
		{
			if (file == null)
			{
				throw new global::System.ArgumentNullException("file");
			}
			if (!file.CanSeek)
			{
				throw new global::System.ArgumentException("Stream is not seekable", "file");
			}
			this.baseStream_ = file;
			this.name_ = file.Name;
			this.isStreamOwner = !leaveOpen;
			try
			{
				this.ReadEntries();
			}
			catch
			{
				this.DisposeInternal(true);
				throw;
			}
		}

		// Token: 0x06000121 RID: 289 RVA: 0x0000501C File Offset: 0x0000321C
		public ZipFile(global::System.IO.Stream stream) : this(stream, false)
		{
		}

		// Token: 0x06000122 RID: 290 RVA: 0x00005028 File Offset: 0x00003228
		public ZipFile(global::System.IO.Stream stream, bool leaveOpen)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (!stream.CanSeek)
			{
				throw new global::System.ArgumentException("Stream is not seekable", "stream");
			}
			this.baseStream_ = stream;
			this.isStreamOwner = !leaveOpen;
			if (this.baseStream_.Length > 0L)
			{
				try
				{
					this.ReadEntries();
					return;
				}
				catch
				{
					this.DisposeInternal(true);
					throw;
				}
			}
			this.entries_ = global::ICSharpCode.SharpZipLib.Core.Empty.Array<global::ICSharpCode.SharpZipLib.Zip.ZipEntry>();
			this.isNewArchive_ = true;
		}

		// Token: 0x06000123 RID: 291 RVA: 0x000050D4 File Offset: 0x000032D4
		internal ZipFile()
		{
			this.entries_ = global::ICSharpCode.SharpZipLib.Core.Empty.Array<global::ICSharpCode.SharpZipLib.Zip.ZipEntry>();
			this.isNewArchive_ = true;
		}

		// Token: 0x06000124 RID: 292 RVA: 0x0000510C File Offset: 0x0000330C
		~ZipFile()
		{
			this.Dispose(false);
		}

		// Token: 0x06000125 RID: 293 RVA: 0x0000513C File Offset: 0x0000333C
		public void Close()
		{
			this.DisposeInternal(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000126 RID: 294 RVA: 0x0000514C File Offset: 0x0000334C
		public static global::ICSharpCode.SharpZipLib.Zip.ZipFile Create(string fileName)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			global::System.IO.FileStream fileStream = global::System.IO.File.Create(fileName);
			return new global::ICSharpCode.SharpZipLib.Zip.ZipFile
			{
				name_ = fileName,
				baseStream_ = fileStream,
				isStreamOwner = true
			};
		}

		// Token: 0x06000127 RID: 295 RVA: 0x00005188 File Offset: 0x00003388
		public static global::ICSharpCode.SharpZipLib.Zip.ZipFile Create(global::System.IO.Stream outStream)
		{
			if (outStream == null)
			{
				throw new global::System.ArgumentNullException("outStream");
			}
			if (!outStream.CanWrite)
			{
				throw new global::System.ArgumentException("Stream is not writeable", "outStream");
			}
			if (!outStream.CanSeek)
			{
				throw new global::System.ArgumentException("Stream is not seekable", "outStream");
			}
			return new global::ICSharpCode.SharpZipLib.Zip.ZipFile
			{
				baseStream_ = outStream
			};
		}

		// Token: 0x17000054 RID: 84
		// (get) Token: 0x06000128 RID: 296 RVA: 0x000051DF File Offset: 0x000033DF
		// (set) Token: 0x06000129 RID: 297 RVA: 0x000051E7 File Offset: 0x000033E7
		public bool IsStreamOwner
		{
			get
			{
				return this.isStreamOwner;
			}
			set
			{
				this.isStreamOwner = value;
			}
		}

		// Token: 0x17000055 RID: 85
		// (get) Token: 0x0600012A RID: 298 RVA: 0x000051F0 File Offset: 0x000033F0
		public bool IsEmbeddedArchive
		{
			get
			{
				return this.offsetOfFirstEntry > 0L;
			}
		}

		// Token: 0x17000056 RID: 86
		// (get) Token: 0x0600012B RID: 299 RVA: 0x000051FC File Offset: 0x000033FC
		public bool IsNewArchive
		{
			get
			{
				return this.isNewArchive_;
			}
		}

		// Token: 0x17000057 RID: 87
		// (get) Token: 0x0600012C RID: 300 RVA: 0x00005204 File Offset: 0x00003404
		public string ZipFileComment
		{
			get
			{
				return this.comment_;
			}
		}

		// Token: 0x17000058 RID: 88
		// (get) Token: 0x0600012D RID: 301 RVA: 0x0000520C File Offset: 0x0000340C
		public string Name
		{
			get
			{
				return this.name_;
			}
		}

		// Token: 0x17000059 RID: 89
		// (get) Token: 0x0600012E RID: 302 RVA: 0x00005214 File Offset: 0x00003414
		[global::System.Obsolete("Use the Count property instead")]
		public int Size
		{
			get
			{
				return this.entries_.Length;
			}
		}

		// Token: 0x1700005A RID: 90
		// (get) Token: 0x0600012F RID: 303 RVA: 0x0000521E File Offset: 0x0000341E
		public long Count
		{
			get
			{
				return (long)this.entries_.Length;
			}
		}

		// Token: 0x1700005B RID: 91
		[global::System.Runtime.CompilerServices.IndexerName("EntryByIndex")]
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry this[int index]
		{
			get
			{
				return (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)this.entries_[index].Clone();
			}
		}

		// Token: 0x06000131 RID: 305 RVA: 0x0000523D File Offset: 0x0000343D
		public global::System.Collections.IEnumerator GetEnumerator()
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			return new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipEntryEnumerator(this.entries_);
		}

		// Token: 0x06000132 RID: 306 RVA: 0x00005260 File Offset: 0x00003460
		public int FindEntry(string name, bool ignoreCase)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			for (int i = 0; i < this.entries_.Length; i++)
			{
				if (string.Compare(name, this.entries_[i].Name, ignoreCase ? global::System.StringComparison.OrdinalIgnoreCase : global::System.StringComparison.Ordinal) == 0)
				{
					return i;
				}
			}
			return -1;
		}

		// Token: 0x06000133 RID: 307 RVA: 0x000052B4 File Offset: 0x000034B4
		public global::ICSharpCode.SharpZipLib.Zip.ZipEntry GetEntry(string name)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			int num = this.FindEntry(name, true);
			if (num < 0)
			{
				return null;
			}
			return (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)this.entries_[num].Clone();
		}

		// Token: 0x06000134 RID: 308 RVA: 0x000052F8 File Offset: 0x000034F8
		public global::System.IO.Stream GetInputStream(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			long num = entry.ZipFileIndex;
			if (num < 0L || num >= (long)this.entries_.Length || this.entries_[(int)(checked((global::System.IntPtr)num))].Name != entry.Name)
			{
				num = (long)this.FindEntry(entry.Name, true);
				if (num < 0L)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry cannot be found");
				}
			}
			return this.GetInputStream(num);
		}

		// Token: 0x06000135 RID: 309 RVA: 0x00005380 File Offset: 0x00003580
		public global::System.IO.Stream GetInputStream(long entryIndex)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			checked
			{
				long start = this.LocateEntry(this.entries_[(int)((global::System.IntPtr)entryIndex)]);
				global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = this.entries_[(int)((global::System.IntPtr)entryIndex)].CompressionMethod;
				global::System.IO.Stream stream = new global::ICSharpCode.SharpZipLib.Zip.ZipFile.PartialInputStream(this, start, this.entries_[(int)((global::System.IntPtr)entryIndex)].CompressedSize);
				if (this.entries_[(int)((global::System.IntPtr)entryIndex)].IsCrypted)
				{
					stream = this.CreateAndInitDecryptionStream(stream, this.entries_[(int)((global::System.IntPtr)entryIndex)]);
					if (stream == null)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unable to decrypt this entry");
					}
				}
				if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
				{
					if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
					{
						if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.BZip2)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unsupported compression method " + compressionMethod.ToString());
						}
						stream = new global::ICSharpCode.SharpZipLib.BZip2.BZip2InputStream(stream);
					}
					else
					{
						stream = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.InflaterInputStream(stream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Inflater(true));
					}
				}
				return stream;
			}
		}

		// Token: 0x06000136 RID: 310 RVA: 0x00005448 File Offset: 0x00003648
		public bool TestArchive(bool testData)
		{
			return this.TestArchive(testData, global::ICSharpCode.SharpZipLib.Zip.TestStrategy.FindFirstError, null);
		}

		// Token: 0x06000137 RID: 311 RVA: 0x00005454 File Offset: 0x00003654
		public bool TestArchive(bool testData, global::ICSharpCode.SharpZipLib.Zip.TestStrategy strategy, global::ICSharpCode.SharpZipLib.Zip.ZipTestResultHandler resultHandler)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			global::ICSharpCode.SharpZipLib.Zip.TestStatus testStatus = new global::ICSharpCode.SharpZipLib.Zip.TestStatus(this);
			if (resultHandler != null)
			{
				resultHandler(testStatus, null);
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest tests = testData ? (global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Extract | global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Header) : global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Header;
			bool flag = true;
			try
			{
				int num = 0;
				while (flag && (long)num < this.Count)
				{
					if (resultHandler != null)
					{
						testStatus.SetEntry(this[num]);
						testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.EntryHeader);
						resultHandler(testStatus, null);
					}
					try
					{
						this.TestLocalHeader(this[num], tests);
					}
					catch (global::ICSharpCode.SharpZipLib.Zip.ZipException ex)
					{
						testStatus.AddError();
						if (resultHandler != null)
						{
							resultHandler(testStatus, "Exception during test - '" + ex.Message + "'");
						}
						flag &= (strategy > global::ICSharpCode.SharpZipLib.Zip.TestStrategy.FindFirstError);
					}
					if (flag && testData && this[num].IsFile)
					{
						bool flag2 = this[num].AESKeySize == 0;
						if (resultHandler != null)
						{
							testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.EntryData);
							resultHandler(testStatus, null);
						}
						global::ICSharpCode.SharpZipLib.Checksum.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksum.Crc32();
						using (global::System.IO.Stream inputStream = this.GetInputStream(this[num]))
						{
							byte[] array = new byte[4096];
							long num2 = 0L;
							int num3;
							while ((num3 = inputStream.Read(array, 0, array.Length)) > 0)
							{
								if (flag2)
								{
									crc.Update(new global::System.ArraySegment<byte>(array, 0, num3));
								}
								if (resultHandler != null)
								{
									num2 += (long)num3;
									testStatus.SetBytesTested(num2);
									resultHandler(testStatus, null);
								}
							}
						}
						if (flag2 && this[num].Crc != crc.Value)
						{
							testStatus.AddError();
							if (resultHandler != null)
							{
								resultHandler(testStatus, "CRC mismatch");
							}
							flag &= (strategy > global::ICSharpCode.SharpZipLib.Zip.TestStrategy.FindFirstError);
						}
						if ((this[num].Flags & 8) != 0)
						{
							global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseStream_);
							global::ICSharpCode.SharpZipLib.Zip.DescriptorData descriptorData = new global::ICSharpCode.SharpZipLib.Zip.DescriptorData();
							zipHelperStream.ReadDataDescriptor(this[num].LocalHeaderRequiresZip64, descriptorData);
							if (flag2 && this[num].Crc != descriptorData.Crc)
							{
								testStatus.AddError();
								if (resultHandler != null)
								{
									resultHandler(testStatus, "Descriptor CRC mismatch");
								}
							}
							if (this[num].CompressedSize != descriptorData.CompressedSize)
							{
								testStatus.AddError();
								if (resultHandler != null)
								{
									resultHandler(testStatus, "Descriptor compressed size mismatch");
								}
							}
							if (this[num].Size != descriptorData.Size)
							{
								testStatus.AddError();
								if (resultHandler != null)
								{
									resultHandler(testStatus, "Descriptor size mismatch");
								}
							}
						}
					}
					if (resultHandler != null)
					{
						testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.EntryComplete);
						resultHandler(testStatus, null);
					}
					num++;
				}
				if (resultHandler != null)
				{
					testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.MiscellaneousTests);
					resultHandler(testStatus, null);
				}
			}
			catch (global::System.Exception ex2)
			{
				testStatus.AddError();
				if (resultHandler != null)
				{
					resultHandler(testStatus, "Exception during test - '" + ex2.Message + "'");
				}
			}
			if (resultHandler != null)
			{
				testStatus.SetOperation(global::ICSharpCode.SharpZipLib.Zip.TestOperation.Complete);
				testStatus.SetEntry(null);
				resultHandler(testStatus, null);
			}
			return testStatus.ErrorCount == 0;
		}

		// Token: 0x06000138 RID: 312 RVA: 0x00005770 File Offset: 0x00003970
		private long TestLocalHeader(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest tests)
		{
			global::System.IO.Stream obj = this.baseStream_;
			long result;
			lock (obj)
			{
				bool flag2 = (tests & global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Header) > (global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest)0;
				bool flag3 = (tests & global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Extract) > (global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest)0;
				long num = this.offsetOfFirstEntry + entry.Offset;
				this.baseStream_.Seek(num, global::System.IO.SeekOrigin.Begin);
				int num2 = (int)this.ReadLEUint();
				if (num2 != 67324752)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Wrong local header signature at 0x{0:x}, expected 0x{1:x8}, actual 0x{2:x8}", num, 67324752, num2));
				}
				short num3 = (short)(this.ReadLEUshort() & 255);
				short num4 = (short)this.ReadLEUshort();
				short num5 = (short)this.ReadLEUshort();
				short num6 = (short)this.ReadLEUshort();
				short num7 = (short)this.ReadLEUshort();
				uint num8 = this.ReadLEUint();
				long num9 = (long)((ulong)this.ReadLEUint());
				long num10 = (long)((ulong)this.ReadLEUint());
				int num11 = (int)this.ReadLEUshort();
				int num12 = (int)this.ReadLEUshort();
				byte[] array = new byte[num11];
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array);
				byte[] array2 = new byte[num12];
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array2);
				global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(array2);
				if (zipExtraData.Find(1))
				{
					num10 = zipExtraData.ReadLong();
					num9 = zipExtraData.ReadLong();
					if ((num4 & 8) != 0)
					{
						if (num10 != -1L && num10 != entry.Size)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Size invalid for descriptor");
						}
						if (num9 != -1L && num9 != entry.CompressedSize)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Compressed size invalid for descriptor");
						}
					}
				}
				else if (num3 >= 45 && ((uint)num10 == 4294967295U || (uint)num9 == 4294967295U))
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Required Zip64 extended information missing");
				}
				if (flag3 && entry.IsFile)
				{
					if (!entry.IsCompressionMethodSupported())
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Compression method not supported");
					}
					if (num3 > 51 || (num3 > 20 && num3 < 45))
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Version required to extract this entry not supported ({0})", num3));
					}
					if ((num4 & 12384) != 0)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("The library does not support the zip version required to extract this entry");
					}
				}
				if (flag2)
				{
					if (num3 <= 63 && num3 != 10 && num3 != 11 && num3 != 20 && num3 != 21 && num3 != 25 && num3 != 27 && num3 != 45 && num3 != 46 && num3 != 50 && num3 != 51 && num3 != 52 && num3 != 61 && num3 != 62 && num3 != 63)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Version required to extract this entry is invalid ({0})", num3));
					}
					if (((int)num4 & 49168) != 0)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Reserved bit flags cannot be set.");
					}
					if ((num4 & 1) != 0 && num3 < 20)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Version required to extract this entry is too low for encryption ({0})", num3));
					}
					if ((num4 & 64) != 0)
					{
						if ((num4 & 1) == 0)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Strong encryption flag set but encryption flag is not set");
						}
						if (num3 < 50)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Version required to extract this entry is too low for encryption ({0})", num3));
						}
					}
					if ((num4 & 32) != 0 && num3 < 27)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Patched data requires higher version than ({0})", num3));
					}
					if ((int)num4 != entry.Flags)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Central header/local header flags mismatch");
					}
					if (entry.CompressionMethodForHeader != (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod)num5)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Central header/local header compression method mismatch");
					}
					if (entry.Version != (int)num3)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Extract version mismatch");
					}
					if ((num4 & 64) != 0 && num3 < 62)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Strong encryption flag set but version not high enough");
					}
					if ((num4 & 8192) != 0 && (num6 != 0 || num7 != 0))
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Header masked set but date/time values non-zero");
					}
					if ((num4 & 8) == 0 && num8 != (uint)entry.Crc)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Central header/local header crc mismatch");
					}
					if (num10 == 0L && num9 == 0L && num8 != 0U)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid CRC for empty entry");
					}
					if (entry.Name.Length > num11)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("File name length mismatch");
					}
					string text = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToStringExt((int)num4, array);
					if (text != entry.Name)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Central header and local header file name mismatch");
					}
					if (entry.IsDirectory)
					{
						if (num10 > 0L)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Directory cannot have size");
						}
						if (entry.IsCrypted)
						{
							if (num9 > (long)(entry.EncryptionOverheadSize + 2))
							{
								throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Directory compressed size invalid");
							}
						}
						else if (num9 > 2L)
						{
							throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Directory compressed size invalid");
						}
					}
					if (!global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform.IsValidName(text, true))
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Name is invalid");
					}
				}
				if ((num4 & 8) == 0 || ((num10 > 0L || num9 > 0L) && entry.Size > 0L))
				{
					if (num10 != 0L && num10 != entry.Size)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Size mismatch between central header({0}) and local header({1})", entry.Size, num10));
					}
					if (num9 != 0L && num9 != entry.CompressedSize && num9 != (long)((ulong)-1) && num9 != -1L)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Compressed size mismatch between central header({0}) and local header({1})", entry.CompressedSize, num9));
					}
				}
				int num13 = num11 + num12;
				result = this.offsetOfFirstEntry + entry.Offset + 30L + (long)num13;
			}
			return result;
		}

		// Token: 0x1700005C RID: 92
		// (get) Token: 0x06000139 RID: 313 RVA: 0x00005C64 File Offset: 0x00003E64
		// (set) Token: 0x0600013A RID: 314 RVA: 0x00005C71 File Offset: 0x00003E71
		public global::ICSharpCode.SharpZipLib.Core.INameTransform NameTransform
		{
			get
			{
				return this.updateEntryFactory_.NameTransform;
			}
			set
			{
				this.updateEntryFactory_.NameTransform = value;
			}
		}

		// Token: 0x1700005D RID: 93
		// (get) Token: 0x0600013B RID: 315 RVA: 0x00005C7F File Offset: 0x00003E7F
		// (set) Token: 0x0600013C RID: 316 RVA: 0x00005C87 File Offset: 0x00003E87
		public global::ICSharpCode.SharpZipLib.Zip.IEntryFactory EntryFactory
		{
			get
			{
				return this.updateEntryFactory_;
			}
			set
			{
				if (value == null)
				{
					this.updateEntryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory();
					return;
				}
				this.updateEntryFactory_ = value;
			}
		}

		// Token: 0x1700005E RID: 94
		// (get) Token: 0x0600013D RID: 317 RVA: 0x00005C9F File Offset: 0x00003E9F
		// (set) Token: 0x0600013E RID: 318 RVA: 0x00005CA7 File Offset: 0x00003EA7
		public int BufferSize
		{
			get
			{
				return this.bufferSize_;
			}
			set
			{
				if (value < 1024)
				{
					throw new global::System.ArgumentOutOfRangeException("value", "cannot be below 1024");
				}
				if (this.bufferSize_ != value)
				{
					this.bufferSize_ = value;
					this.copyBuffer_ = null;
				}
			}
		}

		// Token: 0x1700005F RID: 95
		// (get) Token: 0x0600013F RID: 319 RVA: 0x00005CD8 File Offset: 0x00003ED8
		public bool IsUpdating
		{
			get
			{
				return this.updates_ != null;
			}
		}

		// Token: 0x17000060 RID: 96
		// (get) Token: 0x06000140 RID: 320 RVA: 0x00005CE3 File Offset: 0x00003EE3
		// (set) Token: 0x06000141 RID: 321 RVA: 0x00005CEB File Offset: 0x00003EEB
		public global::ICSharpCode.SharpZipLib.Zip.UseZip64 UseZip64
		{
			get
			{
				return this.useZip64_;
			}
			set
			{
				this.useZip64_ = value;
			}
		}

		// Token: 0x06000142 RID: 322 RVA: 0x00005CF4 File Offset: 0x00003EF4
		public void BeginUpdate(global::ICSharpCode.SharpZipLib.Zip.IArchiveStorage archiveStorage, global::ICSharpCode.SharpZipLib.Zip.IDynamicDataSource dataSource)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			if (this.IsEmbeddedArchive)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot update embedded/SFX archives");
			}
			if (archiveStorage == null)
			{
				throw new global::System.ArgumentNullException("archiveStorage");
			}
			this.archiveStorage_ = archiveStorage;
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			this.updateDataSource_ = dataSource;
			this.updateIndex_ = new global::System.Collections.Generic.Dictionary<string, int>();
			this.updates_ = new global::System.Collections.Generic.List<global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate>(this.entries_.Length);
			foreach (global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry in this.entries_)
			{
				int count = this.updates_.Count;
				this.updates_.Add(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(zipEntry));
				this.updateIndex_.Add(zipEntry.Name, count);
			}
			this.updates_.Sort(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateComparer());
			int num = 0;
			foreach (global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate zipUpdate in this.updates_)
			{
				if (num == this.updates_.Count - 1)
				{
					break;
				}
				zipUpdate.OffsetBasedSize = this.updates_[num + 1].Entry.Offset - zipUpdate.Entry.Offset;
				num++;
			}
			this.updateCount_ = (long)this.updates_.Count;
			this.contentsEdited_ = false;
			this.commentEdited_ = false;
			this.newComment_ = null;
		}

		// Token: 0x06000143 RID: 323 RVA: 0x00005E78 File Offset: 0x00004078
		public void BeginUpdate(global::ICSharpCode.SharpZipLib.Zip.IArchiveStorage archiveStorage)
		{
			this.BeginUpdate(archiveStorage, new global::ICSharpCode.SharpZipLib.Zip.DynamicDiskDataSource());
		}

		// Token: 0x06000144 RID: 324 RVA: 0x00005E86 File Offset: 0x00004086
		public void BeginUpdate()
		{
			if (this.Name == null)
			{
				this.BeginUpdate(new global::ICSharpCode.SharpZipLib.Zip.MemoryArchiveStorage(), new global::ICSharpCode.SharpZipLib.Zip.DynamicDiskDataSource());
				return;
			}
			this.BeginUpdate(new global::ICSharpCode.SharpZipLib.Zip.DiskArchiveStorage(this), new global::ICSharpCode.SharpZipLib.Zip.DynamicDiskDataSource());
		}

		// Token: 0x06000145 RID: 325 RVA: 0x00005EB4 File Offset: 0x000040B4
		public void CommitUpdate()
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			this.CheckUpdating();
			try
			{
				this.updateIndex_.Clear();
				this.updateIndex_ = null;
				if (this.contentsEdited_)
				{
					this.RunUpdates();
				}
				else if (this.commentEdited_)
				{
					this.UpdateCommentOnly();
				}
				else if (this.entries_.Length == 0)
				{
					byte[] comment = (this.newComment_ != null) ? this.newComment_.RawComment : global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(this.comment_);
					using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseStream_))
					{
						zipHelperStream.WriteEndOfCentralDirectory(0L, 0L, 0L, comment);
					}
				}
			}
			finally
			{
				this.PostUpdateCleanup();
			}
		}

		// Token: 0x06000146 RID: 326 RVA: 0x00005F80 File Offset: 0x00004180
		public void AbortUpdate()
		{
			this.PostUpdateCleanup();
		}

		// Token: 0x06000147 RID: 327 RVA: 0x00005F88 File Offset: 0x00004188
		public void SetComment(string comment)
		{
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			this.CheckUpdating();
			this.newComment_ = new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipString(comment);
			if (this.newComment_.RawLength > 65535)
			{
				this.newComment_ = null;
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Comment length exceeds maximum - 65535");
			}
			this.commentEdited_ = true;
		}

		// Token: 0x06000148 RID: 328 RVA: 0x00005FE8 File Offset: 0x000041E8
		private void AddUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			this.contentsEdited_ = true;
			int num = this.FindExistingUpdate(update.Entry.Name, true);
			if (num >= 0)
			{
				if (this.updates_[num] == null)
				{
					this.updateCount_ += 1L;
				}
				this.updates_[num] = update;
				return;
			}
			num = this.updates_.Count;
			this.updates_.Add(update);
			this.updateCount_ += 1L;
			this.updateIndex_.Add(update.Entry.Name, num);
		}

		// Token: 0x06000149 RID: 329 RVA: 0x0000607C File Offset: 0x0000427C
		public void Add(string fileName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod, bool useUnicodeText)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			if (this.isDisposed_)
			{
				throw new global::System.ObjectDisposedException("ZipFile");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipFile.CheckSupportedCompressionMethod(compressionMethod);
			this.CheckUpdating();
			this.contentsEdited_ = true;
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = this.EntryFactory.MakeFileEntry(fileName);
			zipEntry.IsUnicodeText = useUnicodeText;
			zipEntry.CompressionMethod = compressionMethod;
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(fileName, zipEntry));
		}

		// Token: 0x0600014A RID: 330 RVA: 0x000060E8 File Offset: 0x000042E8
		public void Add(string fileName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipFile.CheckSupportedCompressionMethod(compressionMethod);
			this.CheckUpdating();
			this.contentsEdited_ = true;
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = this.EntryFactory.MakeFileEntry(fileName);
			zipEntry.CompressionMethod = compressionMethod;
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(fileName, zipEntry));
		}

		// Token: 0x0600014B RID: 331 RVA: 0x00006137 File Offset: 0x00004337
		public void Add(string fileName)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			this.CheckUpdating();
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(fileName, this.EntryFactory.MakeFileEntry(fileName)));
		}

		// Token: 0x0600014C RID: 332 RVA: 0x00006165 File Offset: 0x00004365
		public void Add(string fileName, string entryName)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			if (entryName == null)
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			this.CheckUpdating();
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(fileName, this.EntryFactory.MakeFileEntry(fileName, entryName, true)));
		}

		// Token: 0x0600014D RID: 333 RVA: 0x000061A3 File Offset: 0x000043A3
		public void Add(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, string entryName)
		{
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			if (entryName == null)
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			this.CheckUpdating();
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(dataSource, this.EntryFactory.MakeFileEntry(entryName, false)));
		}

		// Token: 0x0600014E RID: 334 RVA: 0x000061E0 File Offset: 0x000043E0
		public void Add(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, string entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod)
		{
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			if (entryName == null)
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipFile.CheckSupportedCompressionMethod(compressionMethod);
			this.CheckUpdating();
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = this.EntryFactory.MakeFileEntry(entryName, false);
			zipEntry.CompressionMethod = compressionMethod;
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(dataSource, zipEntry));
		}

		// Token: 0x0600014F RID: 335 RVA: 0x00006238 File Offset: 0x00004438
		public void Add(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, string entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod, bool useUnicodeText)
		{
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			if (entryName == null)
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipFile.CheckSupportedCompressionMethod(compressionMethod);
			this.CheckUpdating();
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = this.EntryFactory.MakeFileEntry(entryName, false);
			zipEntry.IsUnicodeText = useUnicodeText;
			zipEntry.CompressionMethod = compressionMethod;
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(dataSource, zipEntry));
		}

		// Token: 0x06000150 RID: 336 RVA: 0x00006297 File Offset: 0x00004497
		public void Add(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			this.CheckUpdating();
			if (entry.Size != 0L || entry.CompressedSize != 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry cannot have any data");
			}
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add, entry));
		}

		// Token: 0x06000151 RID: 337 RVA: 0x000062D8 File Offset: 0x000044D8
		public void Add(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			if (entry.AESKeySize > 0)
			{
				throw new global::System.NotSupportedException("Creation of AES encrypted entries is not supported");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipFile.CheckSupportedCompressionMethod(entry.CompressionMethod);
			this.CheckUpdating();
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(dataSource, entry));
		}

		// Token: 0x06000152 RID: 338 RVA: 0x00006334 File Offset: 0x00004534
		public void AddDirectory(string directoryName)
		{
			if (directoryName == null)
			{
				throw new global::System.ArgumentNullException("directoryName");
			}
			this.CheckUpdating();
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = this.EntryFactory.MakeDirectoryEntry(directoryName);
			this.AddUpdate(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add, entry));
		}

		// Token: 0x06000153 RID: 339 RVA: 0x0000636F File Offset: 0x0000456F
		private static void CheckSupportedCompressionMethod(global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod)
		{
			if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated && compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored && compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.BZip2)
			{
				throw new global::System.NotImplementedException("Compression method not supported");
			}
		}

		// Token: 0x06000154 RID: 340 RVA: 0x00006388 File Offset: 0x00004588
		public bool Delete(string fileName)
		{
			if (fileName == null)
			{
				throw new global::System.ArgumentNullException("fileName");
			}
			this.CheckUpdating();
			int num = this.FindExistingUpdate(fileName, false);
			if (num >= 0 && this.updates_[num] != null)
			{
				bool result = true;
				this.contentsEdited_ = true;
				this.updates_[num] = null;
				this.updateCount_ -= 1L;
				return result;
			}
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find entry to delete");
		}

		// Token: 0x06000155 RID: 341 RVA: 0x000063FC File Offset: 0x000045FC
		public void Delete(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			this.CheckUpdating();
			int num = this.FindExistingUpdate(entry);
			if (num >= 0)
			{
				this.contentsEdited_ = true;
				this.updates_[num] = null;
				this.updateCount_ -= 1L;
				return;
			}
			throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find entry to delete");
		}

		// Token: 0x06000156 RID: 342 RVA: 0x00006457 File Offset: 0x00004657
		private void WriteLEShort(int value)
		{
			this.baseStream_.WriteByte((byte)(value & 255));
			this.baseStream_.WriteByte((byte)(value >> 8 & 255));
		}

		// Token: 0x06000157 RID: 343 RVA: 0x00006481 File Offset: 0x00004681
		private void WriteLEUshort(ushort value)
		{
			this.baseStream_.WriteByte((byte)(value & 255));
			this.baseStream_.WriteByte((byte)(value >> 8));
		}

		// Token: 0x06000158 RID: 344 RVA: 0x000064A5 File Offset: 0x000046A5
		private void WriteLEInt(int value)
		{
			this.WriteLEShort(value & 65535);
			this.WriteLEShort(value >> 16);
		}

		// Token: 0x06000159 RID: 345 RVA: 0x000064BE File Offset: 0x000046BE
		private void WriteLEUint(uint value)
		{
			this.WriteLEUshort((ushort)(value & 65535U));
			this.WriteLEUshort((ushort)(value >> 16));
		}

		// Token: 0x0600015A RID: 346 RVA: 0x000064D9 File Offset: 0x000046D9
		private void WriteLeLong(long value)
		{
			this.WriteLEInt((int)(value & (long)((ulong)-1)));
			this.WriteLEInt((int)(value >> 32));
		}

		// Token: 0x0600015B RID: 347 RVA: 0x000064F1 File Offset: 0x000046F1
		private void WriteLEUlong(ulong value)
		{
			this.WriteLEUint((uint)(value & (ulong)-1));
			this.WriteLEUint((uint)(value >> 32));
		}

		// Token: 0x0600015C RID: 348 RVA: 0x0000650C File Offset: 0x0000470C
		private void WriteLocalEntryHeader(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			global::ICSharpCode.SharpZipLib.Zip.ZipEntry outEntry = update.OutEntry;
			outEntry.Offset = this.baseStream_.Position;
			if (update.Command != global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy)
			{
				if (outEntry.CompressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
				{
					if (outEntry.Size == 0L)
					{
						outEntry.CompressedSize = outEntry.Size;
						outEntry.Crc = 0L;
						outEntry.CompressionMethod = global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored;
					}
				}
				else if (outEntry.CompressionMethod == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
				{
					outEntry.Flags &= -9;
				}
				if (this.HaveKeys)
				{
					outEntry.IsCrypted = true;
					if (outEntry.Crc < 0L)
					{
						outEntry.Flags |= 8;
					}
				}
				else
				{
					outEntry.IsCrypted = false;
				}
				switch (this.useZip64_)
				{
				case global::ICSharpCode.SharpZipLib.Zip.UseZip64.On:
					outEntry.ForceZip64();
					break;
				case global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic:
					if (outEntry.Size < 0L)
					{
						outEntry.ForceZip64();
					}
					break;
				}
			}
			this.WriteLEInt(67324752);
			this.WriteLEShort(outEntry.Version);
			this.WriteLEShort(outEntry.Flags);
			this.WriteLEShort((int)((byte)outEntry.CompressionMethodForHeader));
			this.WriteLEInt((int)outEntry.DosTime);
			if (!outEntry.HasCrc)
			{
				update.CrcPatchOffset = this.baseStream_.Position;
				this.WriteLEInt(0);
			}
			else
			{
				this.WriteLEInt((int)outEntry.Crc);
			}
			if (outEntry.LocalHeaderRequiresZip64)
			{
				this.WriteLEInt(-1);
				this.WriteLEInt(-1);
			}
			else
			{
				if (outEntry.CompressedSize < 0L || outEntry.Size < 0L)
				{
					update.SizePatchOffset = this.baseStream_.Position;
				}
				this.WriteLEInt((int)outEntry.CompressedSize);
				this.WriteLEInt((int)outEntry.Size);
			}
			byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(outEntry.Flags, outEntry.Name);
			if (array.Length > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry name too long.");
			}
			global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(outEntry.ExtraData);
			if (outEntry.LocalHeaderRequiresZip64)
			{
				zipExtraData.StartNewEntry();
				zipExtraData.AddLeLong(outEntry.Size);
				zipExtraData.AddLeLong(outEntry.CompressedSize);
				zipExtraData.AddNewEntry(1);
			}
			else
			{
				zipExtraData.Delete(1);
			}
			outEntry.ExtraData = zipExtraData.GetEntryData();
			this.WriteLEShort(array.Length);
			this.WriteLEShort(outEntry.ExtraData.Length);
			if (array.Length != 0)
			{
				this.baseStream_.Write(array, 0, array.Length);
			}
			if (outEntry.LocalHeaderRequiresZip64)
			{
				if (!zipExtraData.Find(1))
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Internal error cannot find extra data");
				}
				update.SizePatchOffset = this.baseStream_.Position + (long)zipExtraData.CurrentReadIndex;
			}
			if (outEntry.ExtraData.Length != 0)
			{
				this.baseStream_.Write(outEntry.ExtraData, 0, outEntry.ExtraData.Length);
			}
		}

		// Token: 0x0600015D RID: 349 RVA: 0x000067A0 File Offset: 0x000049A0
		private int WriteCentralDirectoryHeader(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (entry.CompressedSize < 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Attempt to write central directory entry with unknown csize");
			}
			if (entry.Size < 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Attempt to write central directory entry with unknown size");
			}
			if (entry.Crc < 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Attempt to write central directory entry with unknown crc");
			}
			this.WriteLEInt(33639248);
			this.WriteLEShort(entry.HostSystem << 8 | entry.VersionMadeBy);
			this.WriteLEShort(entry.Version);
			this.WriteLEShort(entry.Flags);
			this.WriteLEShort((int)((byte)entry.CompressionMethodForHeader));
			this.WriteLEInt((int)entry.DosTime);
			this.WriteLEInt((int)entry.Crc);
			bool flag = false;
			if (entry.IsZip64Forced() || entry.CompressedSize >= (long)((ulong)-1))
			{
				flag = true;
				this.WriteLEInt(-1);
			}
			else
			{
				this.WriteLEInt((int)(entry.CompressedSize & (long)((ulong)-1)));
			}
			bool flag2 = false;
			if (entry.IsZip64Forced() || entry.Size >= (long)((ulong)-1))
			{
				flag2 = true;
				this.WriteLEInt(-1);
			}
			else
			{
				this.WriteLEInt((int)entry.Size);
			}
			byte[] array = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(entry.Flags, entry.Name);
			if (array.Length > 65535)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry name is too long.");
			}
			this.WriteLEShort(array.Length);
			global::ICSharpCode.SharpZipLib.Zip.ZipExtraData zipExtraData = new global::ICSharpCode.SharpZipLib.Zip.ZipExtraData(entry.ExtraData);
			if (entry.CentralHeaderRequiresZip64)
			{
				zipExtraData.StartNewEntry();
				if (flag2)
				{
					zipExtraData.AddLeLong(entry.Size);
				}
				if (flag)
				{
					zipExtraData.AddLeLong(entry.CompressedSize);
				}
				if (entry.Offset >= (long)((ulong)-1))
				{
					zipExtraData.AddLeLong(entry.Offset);
				}
				zipExtraData.AddNewEntry(1);
			}
			else
			{
				zipExtraData.Delete(1);
			}
			byte[] entryData = zipExtraData.GetEntryData();
			this.WriteLEShort(entryData.Length);
			this.WriteLEShort((entry.Comment != null) ? entry.Comment.Length : 0);
			this.WriteLEShort(0);
			this.WriteLEShort(0);
			if (entry.ExternalFileAttributes != -1)
			{
				this.WriteLEInt(entry.ExternalFileAttributes);
			}
			else if (entry.IsDirectory)
			{
				this.WriteLEUint(16U);
			}
			else
			{
				this.WriteLEUint(0U);
			}
			if (entry.Offset >= (long)((ulong)-1))
			{
				this.WriteLEUint(uint.MaxValue);
			}
			else
			{
				this.WriteLEUint((uint)((int)entry.Offset));
			}
			if (array.Length != 0)
			{
				this.baseStream_.Write(array, 0, array.Length);
			}
			if (entryData.Length != 0)
			{
				this.baseStream_.Write(entryData, 0, entryData.Length);
			}
			byte[] array2 = (entry.Comment != null) ? global::System.Text.Encoding.ASCII.GetBytes(entry.Comment) : global::ICSharpCode.SharpZipLib.Core.Empty.Array<byte>();
			if (array2.Length != 0)
			{
				this.baseStream_.Write(array2, 0, array2.Length);
			}
			return 46 + array.Length + entryData.Length + array2.Length;
		}

		// Token: 0x0600015E RID: 350 RVA: 0x00006A34 File Offset: 0x00004C34
		private void PostUpdateCleanup()
		{
			this.updateDataSource_ = null;
			this.updates_ = null;
			this.updateIndex_ = null;
			if (this.archiveStorage_ != null)
			{
				this.archiveStorage_.Dispose();
				this.archiveStorage_ = null;
			}
		}

		// Token: 0x0600015F RID: 351 RVA: 0x00006A68 File Offset: 0x00004C68
		private string GetTransformedFileName(string name)
		{
			global::ICSharpCode.SharpZipLib.Core.INameTransform nameTransform = this.NameTransform;
			if (nameTransform == null)
			{
				return name;
			}
			return nameTransform.TransformFile(name);
		}

		// Token: 0x06000160 RID: 352 RVA: 0x00006A88 File Offset: 0x00004C88
		private string GetTransformedDirectoryName(string name)
		{
			global::ICSharpCode.SharpZipLib.Core.INameTransform nameTransform = this.NameTransform;
			if (nameTransform == null)
			{
				return name;
			}
			return nameTransform.TransformDirectory(name);
		}

		// Token: 0x06000161 RID: 353 RVA: 0x00006AA8 File Offset: 0x00004CA8
		private byte[] GetBuffer()
		{
			if (this.copyBuffer_ == null)
			{
				this.copyBuffer_ = new byte[this.bufferSize_];
			}
			return this.copyBuffer_;
		}

		// Token: 0x06000162 RID: 354 RVA: 0x00006ACC File Offset: 0x00004CCC
		private void CopyDescriptorBytes(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, global::System.IO.Stream dest, global::System.IO.Stream source)
		{
			int i = global::ICSharpCode.SharpZipLib.Zip.ZipFile.GetDescriptorSize(update, false);
			if (i == 0)
			{
				return;
			}
			byte[] buffer = this.GetBuffer();
			source.Read(buffer, 0, 4);
			dest.Write(buffer, 0, 4);
			if (global::System.BitConverter.ToUInt32(buffer, 0) != 134695760U)
			{
				i -= buffer.Length;
			}
			while (i > 0)
			{
				int count = global::System.Math.Min(buffer.Length, i);
				int num = source.Read(buffer, 0, count);
				if (num <= 0)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unxpected end of stream");
				}
				dest.Write(buffer, 0, num);
				i -= num;
			}
		}

		// Token: 0x06000163 RID: 355 RVA: 0x00006B4C File Offset: 0x00004D4C
		private void CopyBytes(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, global::System.IO.Stream destination, global::System.IO.Stream source, long bytesToCopy, bool updateCrc)
		{
			if (destination == source)
			{
				throw new global::System.InvalidOperationException("Destination and source are the same");
			}
			global::ICSharpCode.SharpZipLib.Checksum.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksum.Crc32();
			byte[] buffer = this.GetBuffer();
			long num = bytesToCopy;
			long num2 = 0L;
			int num4;
			do
			{
				int num3 = buffer.Length;
				if (bytesToCopy < (long)num3)
				{
					num3 = (int)bytesToCopy;
				}
				num4 = source.Read(buffer, 0, num3);
				if (num4 > 0)
				{
					if (updateCrc)
					{
						crc.Update(new global::System.ArraySegment<byte>(buffer, 0, num4));
					}
					destination.Write(buffer, 0, num4);
					bytesToCopy -= (long)num4;
					num2 += (long)num4;
				}
			}
			while (num4 > 0 && bytesToCopy > 0L);
			if (num2 != num)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Failed to copy bytes expected {0} read {1}", num, num2));
			}
			if (updateCrc)
			{
				update.OutEntry.Crc = crc.Value;
			}
		}

		// Token: 0x06000164 RID: 356 RVA: 0x00006C08 File Offset: 0x00004E08
		private static int GetDescriptorSize(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, bool includingSignature)
		{
			if (!((global::ICSharpCode.SharpZipLib.Zip.GeneralBitFlags)update.Entry.Flags).HasFlag(global::ICSharpCode.SharpZipLib.Zip.GeneralBitFlags.Descriptor))
			{
				return 0;
			}
			int num = update.Entry.LocalHeaderRequiresZip64 ? 24 : 16;
			if (!includingSignature)
			{
				return num - 4;
			}
			return num;
		}

		// Token: 0x06000165 RID: 357 RVA: 0x00006C50 File Offset: 0x00004E50
		private void CopyDescriptorBytesDirect(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, global::System.IO.Stream stream, ref long destinationPosition, long sourcePosition)
		{
			byte[] buffer = this.GetBuffer();
			stream.Position = sourcePosition;
			stream.Read(buffer, 0, 4);
			bool includingSignature = global::System.BitConverter.ToUInt32(buffer, 0) == 134695760U;
			int i = global::ICSharpCode.SharpZipLib.Zip.ZipFile.GetDescriptorSize(update, includingSignature);
			while (i > 0)
			{
				stream.Position = sourcePosition;
				int num = stream.Read(buffer, 0, i);
				if (num <= 0)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unexpected end of stream");
				}
				stream.Position = destinationPosition;
				stream.Write(buffer, 0, num);
				i -= num;
				destinationPosition += (long)num;
				sourcePosition += (long)num;
			}
		}

		// Token: 0x06000166 RID: 358 RVA: 0x00006CDC File Offset: 0x00004EDC
		private void CopyEntryDataDirect(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, global::System.IO.Stream stream, bool updateCrc, ref long destinationPosition, ref long sourcePosition)
		{
			long num = update.Entry.CompressedSize;
			global::ICSharpCode.SharpZipLib.Checksum.Crc32 crc = new global::ICSharpCode.SharpZipLib.Checksum.Crc32();
			byte[] buffer = this.GetBuffer();
			long num2 = num;
			long num3 = 0L;
			int num5;
			do
			{
				int num4 = buffer.Length;
				if (num < (long)num4)
				{
					num4 = (int)num;
				}
				stream.Position = sourcePosition;
				num5 = stream.Read(buffer, 0, num4);
				if (num5 > 0)
				{
					if (updateCrc)
					{
						crc.Update(new global::System.ArraySegment<byte>(buffer, 0, num5));
					}
					stream.Position = destinationPosition;
					stream.Write(buffer, 0, num5);
					destinationPosition += (long)num5;
					sourcePosition += (long)num5;
					num -= (long)num5;
					num3 += (long)num5;
				}
			}
			while (num5 > 0 && num > 0L);
			if (num3 != num2)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Failed to copy bytes expected {0} read {1}", num2, num3));
			}
			if (updateCrc)
			{
				update.OutEntry.Crc = crc.Value;
			}
		}

		// Token: 0x06000167 RID: 359 RVA: 0x00006DB8 File Offset: 0x00004FB8
		private int FindExistingUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			int result = -1;
			if (this.updateIndex_.ContainsKey(entry.Name))
			{
				result = this.updateIndex_[entry.Name];
			}
			return result;
		}

		// Token: 0x06000168 RID: 360 RVA: 0x00006DF0 File Offset: 0x00004FF0
		private int FindExistingUpdate(string fileName, bool isEntryName = false)
		{
			int result = -1;
			string text = (!isEntryName) ? this.GetTransformedFileName(fileName) : fileName;
			if (this.updateIndex_.ContainsKey(text))
			{
				result = this.updateIndex_[text];
			}
			return result;
		}

		// Token: 0x06000169 RID: 361 RVA: 0x00006E2C File Offset: 0x0000502C
		private global::System.IO.Stream GetOutputStream(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			global::System.IO.Stream stream = this.baseStream_;
			if (entry.IsCrypted)
			{
				stream = this.CreateAndInitEncryptionStream(stream, entry);
			}
			global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod = entry.CompressionMethod;
			if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Stored)
			{
				if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
				{
					if (compressionMethod != global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.BZip2)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unknown compression method " + entry.CompressionMethod.ToString());
					}
					stream = new global::ICSharpCode.SharpZipLib.BZip2.BZip2OutputStream(stream)
					{
						IsStreamOwner = entry.IsCrypted
					};
				}
				else
				{
					stream = new global::ICSharpCode.SharpZipLib.Zip.Compression.Streams.DeflaterOutputStream(stream, new global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater(9, true))
					{
						IsStreamOwner = entry.IsCrypted
					};
				}
			}
			else if (!entry.IsCrypted)
			{
				stream = new global::ICSharpCode.SharpZipLib.Zip.ZipFile.UncompressedStream(stream);
			}
			return stream;
		}

		// Token: 0x0600016A RID: 362 RVA: 0x00006ED0 File Offset: 0x000050D0
		private void AddEntry(global::ICSharpCode.SharpZipLib.Zip.ZipFile workFile, global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			global::System.IO.Stream stream = null;
			if (update.Entry.IsFile)
			{
				stream = update.GetSource();
				if (stream == null)
				{
					stream = this.updateDataSource_.GetSource(update.Entry, update.Filename);
				}
			}
			bool updateCrc = update.Entry.AESKeySize == 0;
			if (stream != null)
			{
				using (stream)
				{
					long length = stream.Length;
					if (update.OutEntry.Size < 0L)
					{
						update.OutEntry.Size = length;
					}
					else if (update.OutEntry.Size != length)
					{
						throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Entry size/stream size mismatch");
					}
					workFile.WriteLocalEntryHeader(update);
					long position = workFile.baseStream_.Position;
					using (global::System.IO.Stream outputStream = workFile.GetOutputStream(update.OutEntry))
					{
						this.CopyBytes(update, outputStream, stream, length, updateCrc);
					}
					long position2 = workFile.baseStream_.Position;
					update.OutEntry.CompressedSize = position2 - position;
					if ((update.OutEntry.Flags & 8) == 8)
					{
						new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(workFile.baseStream_).WriteDataDescriptor(update.OutEntry);
					}
					return;
				}
			}
			workFile.WriteLocalEntryHeader(update);
			update.OutEntry.CompressedSize = 0L;
		}

		// Token: 0x0600016B RID: 363 RVA: 0x00007020 File Offset: 0x00005220
		private void ModifyEntry(global::ICSharpCode.SharpZipLib.Zip.ZipFile workFile, global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			workFile.WriteLocalEntryHeader(update);
			long position = workFile.baseStream_.Position;
			if (update.Entry.IsFile && update.Filename != null)
			{
				using (global::System.IO.Stream outputStream = workFile.GetOutputStream(update.OutEntry))
				{
					using (global::System.IO.Stream inputStream = this.GetInputStream(update.Entry))
					{
						this.CopyBytes(update, outputStream, inputStream, inputStream.Length, true);
					}
				}
			}
			long position2 = workFile.baseStream_.Position;
			update.Entry.CompressedSize = position2 - position;
		}

		// Token: 0x0600016C RID: 364 RVA: 0x000070CC File Offset: 0x000052CC
		private void CopyEntryDirect(global::ICSharpCode.SharpZipLib.Zip.ZipFile workFile, global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update, ref long destinationPosition)
		{
			bool flag = update.Entry.Offset == destinationPosition;
			if (!flag)
			{
				this.baseStream_.Position = destinationPosition;
				workFile.WriteLocalEntryHeader(update);
				destinationPosition = this.baseStream_.Position;
			}
			long num = 0L;
			long num2 = update.Entry.Offset + 26L;
			this.baseStream_.Seek(num2, global::System.IO.SeekOrigin.Begin);
			uint num3 = (uint)this.ReadLEUshort();
			uint num4 = (uint)this.ReadLEUshort();
			num = this.baseStream_.Position + (long)((ulong)num3) + (long)((ulong)num4);
			if (!flag)
			{
				if (update.Entry.CompressedSize > 0L)
				{
					this.CopyEntryDataDirect(update, this.baseStream_, false, ref destinationPosition, ref num);
				}
				this.CopyDescriptorBytesDirect(update, this.baseStream_, ref destinationPosition, num);
				return;
			}
			if (update.OffsetBasedSize != -1L)
			{
				destinationPosition += update.OffsetBasedSize;
				return;
			}
			destinationPosition += num - num2 + 26L;
			destinationPosition += update.Entry.CompressedSize;
			this.baseStream_.Seek(destinationPosition, global::System.IO.SeekOrigin.Begin);
			bool includingSignature = this.ReadLEUint() == 134695760U;
			destinationPosition += (long)global::ICSharpCode.SharpZipLib.Zip.ZipFile.GetDescriptorSize(update, includingSignature);
		}

		// Token: 0x0600016D RID: 365 RVA: 0x000071E0 File Offset: 0x000053E0
		private void CopyEntry(global::ICSharpCode.SharpZipLib.Zip.ZipFile workFile, global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate update)
		{
			workFile.WriteLocalEntryHeader(update);
			if (update.Entry.CompressedSize > 0L)
			{
				long offset = update.Entry.Offset + 26L;
				this.baseStream_.Seek(offset, global::System.IO.SeekOrigin.Begin);
				uint num = (uint)this.ReadLEUshort();
				uint num2 = (uint)this.ReadLEUshort();
				this.baseStream_.Seek((long)((ulong)(num + num2)), global::System.IO.SeekOrigin.Current);
				this.CopyBytes(update, workFile.baseStream_, this.baseStream_, update.Entry.CompressedSize, false);
			}
			this.CopyDescriptorBytes(update, workFile.baseStream_, this.baseStream_);
		}

		// Token: 0x0600016E RID: 366 RVA: 0x00007272 File Offset: 0x00005472
		private void Reopen(global::System.IO.Stream source)
		{
			this.isNewArchive_ = false;
			if (source == null)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Failed to reopen archive - no source");
			}
			this.baseStream_ = source;
			this.ReadEntries();
		}

		// Token: 0x0600016F RID: 367 RVA: 0x00007297 File Offset: 0x00005497
		private void Reopen()
		{
			if (this.Name == null)
			{
				throw new global::System.InvalidOperationException("Name is not known cannot Reopen");
			}
			this.Reopen(global::System.IO.File.Open(this.Name, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read));
		}

		// Token: 0x06000170 RID: 368 RVA: 0x000072C0 File Offset: 0x000054C0
		private void UpdateCommentOnly()
		{
			long length = this.baseStream_.Length;
			global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream;
			if (this.archiveStorage_.UpdateMode == global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Safe)
			{
				zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.archiveStorage_.MakeTemporaryCopy(this.baseStream_))
				{
					IsStreamOwner = true
				};
				this.baseStream_.Dispose();
				this.baseStream_ = null;
			}
			else if (this.archiveStorage_.UpdateMode == global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Direct)
			{
				this.baseStream_ = this.archiveStorage_.OpenForDirectUpdate(this.baseStream_);
				zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseStream_);
			}
			else
			{
				this.baseStream_.Dispose();
				this.baseStream_ = null;
				zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.Name);
			}
			using (zipHelperStream)
			{
				if (zipHelperStream.LocateBlockWithSignature(101010256, length, 22, 65535) < 0L)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find central directory");
				}
				zipHelperStream.Position += 16L;
				byte[] rawComment = this.newComment_.RawComment;
				zipHelperStream.WriteLEShort(rawComment.Length);
				zipHelperStream.Write(rawComment, 0, rawComment.Length);
				zipHelperStream.SetLength(zipHelperStream.Position);
			}
			if (this.archiveStorage_.UpdateMode == global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Safe)
			{
				this.Reopen(this.archiveStorage_.ConvertTemporaryToFinal());
				return;
			}
			this.ReadEntries();
		}

		// Token: 0x06000171 RID: 369 RVA: 0x0000740C File Offset: 0x0000560C
		private void RunUpdates()
		{
			long num = 0L;
			long length = 0L;
			bool flag = false;
			long position = 0L;
			global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile;
			if (this.IsNewArchive)
			{
				zipFile = this;
				zipFile.baseStream_.Position = 0L;
				flag = true;
			}
			else if (this.archiveStorage_.UpdateMode == global::ICSharpCode.SharpZipLib.Zip.FileUpdateMode.Direct)
			{
				zipFile = this;
				zipFile.baseStream_.Position = 0L;
				flag = true;
				this.updates_.Sort(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateComparer());
			}
			else
			{
				zipFile = global::ICSharpCode.SharpZipLib.Zip.ZipFile.Create(this.archiveStorage_.GetTemporaryOutput());
				zipFile.UseZip64 = this.UseZip64;
				if (this.key != null)
				{
					zipFile.key = (byte[])this.key.Clone();
				}
			}
			try
			{
				foreach (global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate zipUpdate in this.updates_)
				{
					if (zipUpdate != null)
					{
						switch (zipUpdate.Command)
						{
						case global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy:
							if (flag)
							{
								this.CopyEntryDirect(zipFile, zipUpdate, ref position);
							}
							else
							{
								this.CopyEntry(zipFile, zipUpdate);
							}
							break;
						case global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Modify:
							this.ModifyEntry(zipFile, zipUpdate);
							break;
						case global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add:
							if (!this.IsNewArchive && flag)
							{
								zipFile.baseStream_.Position = position;
							}
							this.AddEntry(zipFile, zipUpdate);
							if (flag)
							{
								position = zipFile.baseStream_.Position;
							}
							break;
						}
					}
				}
				if (!this.IsNewArchive && flag)
				{
					zipFile.baseStream_.Position = position;
				}
				long position2 = zipFile.baseStream_.Position;
				foreach (global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate zipUpdate2 in this.updates_)
				{
					if (zipUpdate2 != null)
					{
						num += (long)zipFile.WriteCentralDirectoryHeader(zipUpdate2.OutEntry);
					}
				}
				byte[] comment = (this.newComment_ != null) ? this.newComment_.RawComment : global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(this.comment_);
				using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(zipFile.baseStream_))
				{
					zipHelperStream.WriteEndOfCentralDirectory(this.updateCount_, num, position2, comment);
				}
				length = zipFile.baseStream_.Position;
				foreach (global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate zipUpdate3 in this.updates_)
				{
					if (zipUpdate3 != null)
					{
						if (zipUpdate3.CrcPatchOffset > 0L && zipUpdate3.OutEntry.CompressedSize > 0L)
						{
							zipFile.baseStream_.Position = zipUpdate3.CrcPatchOffset;
							zipFile.WriteLEInt((int)zipUpdate3.OutEntry.Crc);
						}
						if (zipUpdate3.SizePatchOffset > 0L)
						{
							zipFile.baseStream_.Position = zipUpdate3.SizePatchOffset;
							if (zipUpdate3.OutEntry.LocalHeaderRequiresZip64)
							{
								zipFile.WriteLeLong(zipUpdate3.OutEntry.Size);
								zipFile.WriteLeLong(zipUpdate3.OutEntry.CompressedSize);
							}
							else
							{
								zipFile.WriteLEInt((int)zipUpdate3.OutEntry.CompressedSize);
								zipFile.WriteLEInt((int)zipUpdate3.OutEntry.Size);
							}
						}
					}
				}
			}
			catch
			{
				zipFile.Close();
				if (!flag && zipFile.Name != null)
				{
					global::System.IO.File.Delete(zipFile.Name);
				}
				throw;
			}
			if (flag)
			{
				zipFile.baseStream_.SetLength(length);
				zipFile.baseStream_.Flush();
				this.isNewArchive_ = false;
				this.ReadEntries();
				return;
			}
			this.baseStream_.Dispose();
			this.Reopen(this.archiveStorage_.ConvertTemporaryToFinal());
		}

		// Token: 0x06000172 RID: 370 RVA: 0x00007818 File Offset: 0x00005A18
		private void CheckUpdating()
		{
			if (this.updates_ == null)
			{
				throw new global::System.InvalidOperationException("BeginUpdate has not been called");
			}
		}

		// Token: 0x06000173 RID: 371 RVA: 0x0000782D File Offset: 0x00005A2D
		void global::System.IDisposable.Dispose()
		{
			this.Close();
		}

		// Token: 0x06000174 RID: 372 RVA: 0x00007838 File Offset: 0x00005A38
		private void DisposeInternal(bool disposing)
		{
			if (!this.isDisposed_)
			{
				this.isDisposed_ = true;
				this.entries_ = global::ICSharpCode.SharpZipLib.Core.Empty.Array<global::ICSharpCode.SharpZipLib.Zip.ZipEntry>();
				if (this.IsStreamOwner && this.baseStream_ != null)
				{
					global::System.IO.Stream obj = this.baseStream_;
					lock (obj)
					{
						this.baseStream_.Dispose();
					}
				}
				this.PostUpdateCleanup();
			}
		}

		// Token: 0x06000175 RID: 373 RVA: 0x000078B0 File Offset: 0x00005AB0
		protected virtual void Dispose(bool disposing)
		{
			this.DisposeInternal(disposing);
		}

		// Token: 0x06000176 RID: 374 RVA: 0x000078BC File Offset: 0x00005ABC
		private ushort ReadLEUshort()
		{
			int num = this.baseStream_.ReadByte();
			if (num < 0)
			{
				throw new global::System.IO.EndOfStreamException("End of stream");
			}
			int num2 = this.baseStream_.ReadByte();
			if (num2 < 0)
			{
				throw new global::System.IO.EndOfStreamException("End of stream");
			}
			return (ushort)num | (ushort)(num2 << 8);
		}

		// Token: 0x06000177 RID: 375 RVA: 0x00007905 File Offset: 0x00005B05
		private uint ReadLEUint()
		{
			return (uint)((int)this.ReadLEUshort() | (int)this.ReadLEUshort() << 16);
		}

		// Token: 0x06000178 RID: 376 RVA: 0x00007917 File Offset: 0x00005B17
		private ulong ReadLEUlong()
		{
			return (ulong)this.ReadLEUint() | (ulong)this.ReadLEUint() << 32;
		}

		// Token: 0x06000179 RID: 377 RVA: 0x0000792C File Offset: 0x00005B2C
		private long LocateBlockWithSignature(int signature, long endLocation, int minimumBlockSize, int maximumVariableData)
		{
			long result;
			using (global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream zipHelperStream = new global::ICSharpCode.SharpZipLib.Zip.ZipHelperStream(this.baseStream_))
			{
				result = zipHelperStream.LocateBlockWithSignature(signature, endLocation, minimumBlockSize, maximumVariableData);
			}
			return result;
		}

		// Token: 0x0600017A RID: 378 RVA: 0x00007970 File Offset: 0x00005B70
		private void ReadEntries()
		{
			if (!this.baseStream_.CanSeek)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("ZipFile stream must be seekable");
			}
			long num = this.LocateBlockWithSignature(101010256, this.baseStream_.Length, 22, 65535);
			if (num < 0L)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find central directory");
			}
			int num2 = (int)this.ReadLEUshort();
			ushort num3 = this.ReadLEUshort();
			ulong num4 = (ulong)this.ReadLEUshort();
			ulong num5 = (ulong)this.ReadLEUshort();
			ulong num6 = (ulong)this.ReadLEUint();
			long num7 = (long)((ulong)this.ReadLEUint());
			uint num8 = (uint)this.ReadLEUshort();
			if (num8 > 0U)
			{
				byte[] array = new byte[num8];
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array);
				this.comment_ = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToString(array);
			}
			else
			{
				this.comment_ = string.Empty;
			}
			bool flag = false;
			bool flag2 = false;
			if (num2 == 65535 || num3 == 65535 || num4 == 65535UL || num5 == 65535UL || num6 == (ulong)-1 || num7 == (long)((ulong)-1))
			{
				flag2 = true;
			}
			if (this.LocateBlockWithSignature(117853008, num - 4L, 20, 0) < 0L)
			{
				if (flag2)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Cannot find Zip64 locator");
				}
			}
			else
			{
				flag = true;
				this.ReadLEUint();
				ulong num9 = this.ReadLEUlong();
				this.ReadLEUint();
				this.baseStream_.Position = (long)num9;
				if ((ulong)this.ReadLEUint() != 101075792UL)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException(string.Format("Invalid Zip64 Central directory signature at {0:X}", num9));
				}
				this.ReadLEUlong();
				this.ReadLEUshort();
				this.ReadLEUshort();
				this.ReadLEUint();
				this.ReadLEUint();
				num4 = this.ReadLEUlong();
				num5 = this.ReadLEUlong();
				num6 = this.ReadLEUlong();
				num7 = (long)this.ReadLEUlong();
			}
			this.entries_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry[num4];
			if (!flag && num7 < num - (long)(4UL + num6))
			{
				this.offsetOfFirstEntry = num - (long)(4UL + num6 + (ulong)num7);
				if (this.offsetOfFirstEntry <= 0L)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid embedded zip archive");
				}
			}
			this.baseStream_.Seek(this.offsetOfFirstEntry + num7, global::System.IO.SeekOrigin.Begin);
			for (ulong num10 = 0UL; num10 < num4; num10 += 1UL)
			{
				if (this.ReadLEUint() != 33639248U)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Wrong Central Directory signature");
				}
				int madeByInfo = (int)this.ReadLEUshort();
				int versionRequiredToExtract = (int)this.ReadLEUshort();
				int num11 = (int)this.ReadLEUshort();
				int method = (int)this.ReadLEUshort();
				uint num12 = this.ReadLEUint();
				uint num13 = this.ReadLEUint();
				long num14 = (long)((ulong)this.ReadLEUint());
				long num15 = (long)((ulong)this.ReadLEUint());
				int num16 = (int)this.ReadLEUshort();
				int num17 = (int)this.ReadLEUshort();
				int num18 = (int)this.ReadLEUshort();
				this.ReadLEUshort();
				this.ReadLEUshort();
				uint externalFileAttributes = this.ReadLEUint();
				long offset = (long)((ulong)this.ReadLEUint());
				byte[] array2 = new byte[global::System.Math.Max(num16, num18)];
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array2, 0, num16);
				global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToStringExt(num11, array2, num16), versionRequiredToExtract, madeByInfo, (global::ICSharpCode.SharpZipLib.Zip.CompressionMethod)method)
				{
					Crc = (long)((ulong)num13 & (ulong)-1),
					Size = (num15 & (long)((ulong)-1)),
					CompressedSize = (num14 & (long)((ulong)-1)),
					Flags = num11,
					DosTime = (long)((ulong)num12),
					ZipFileIndex = (long)num10,
					Offset = offset,
					ExternalFileAttributes = (int)externalFileAttributes
				};
				if ((num11 & 8) == 0)
				{
					zipEntry.CryptoCheckValue = (byte)(num13 >> 24);
				}
				else
				{
					zipEntry.CryptoCheckValue = (byte)(num12 >> 8 & 255U);
				}
				if (num17 > 0)
				{
					byte[] array3 = new byte[num17];
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array3);
					zipEntry.ExtraData = array3;
				}
				zipEntry.ProcessExtraData(false);
				if (num18 > 0)
				{
					global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(this.baseStream_, array2, 0, num18);
					zipEntry.Comment = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToStringExt(num11, array2, num18);
				}
				this.entries_[(int)(checked((global::System.IntPtr)num10))] = zipEntry;
			}
		}

		// Token: 0x0600017B RID: 379 RVA: 0x00007D23 File Offset: 0x00005F23
		private long LocateEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			return this.TestLocalHeader(entry, global::ICSharpCode.SharpZipLib.Zip.ZipFile.HeaderTest.Extract);
		}

		// Token: 0x0600017C RID: 380 RVA: 0x00007D30 File Offset: 0x00005F30
		private global::System.IO.Stream CreateAndInitDecryptionStream(global::System.IO.Stream baseStream, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			global::System.Security.Cryptography.CryptoStream cryptoStream;
			if (entry.CompressionMethodForHeader == global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.WinZipAES)
			{
				if (entry.Version < 51)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Decryption method not supported");
				}
				this.OnKeysRequired(entry.Name);
				if (this.rawPassword_ == null)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No password available for AES encrypted stream");
				}
				int aessaltLen = entry.AESSaltLen;
				byte[] array = new byte[aessaltLen];
				int num = global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadRequestedBytes(baseStream, array, 0, aessaltLen);
				if (num != aessaltLen)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("AES Salt expected " + aessaltLen.ToString() + " got " + num.ToString());
				}
				byte[] array2 = new byte[2];
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(baseStream, array2);
				int blockSize = entry.AESKeySize / 8;
				global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform zipAESTransform = new global::ICSharpCode.SharpZipLib.Encryption.ZipAESTransform(this.rawPassword_, array, blockSize, false);
				byte[] pwdVerifier = zipAESTransform.PwdVerifier;
				if (pwdVerifier[0] != array2[0] || pwdVerifier[1] != array2[1])
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid password for AES");
				}
				cryptoStream = new global::ICSharpCode.SharpZipLib.Encryption.ZipAESStream(baseStream, zipAESTransform, global::System.Security.Cryptography.CryptoStreamMode.Read);
			}
			else
			{
				if (entry.Version >= 50 && (entry.Flags & 64) != 0)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Decryption method not supported");
				}
				global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged pkzipClassicManaged = new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged();
				this.OnKeysRequired(entry.Name);
				if (!this.HaveKeys)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No password available for encrypted stream");
				}
				cryptoStream = new global::System.Security.Cryptography.CryptoStream(baseStream, pkzipClassicManaged.CreateDecryptor(this.key, null), global::System.Security.Cryptography.CryptoStreamMode.Read);
				global::ICSharpCode.SharpZipLib.Zip.ZipFile.CheckClassicPassword(cryptoStream, entry);
			}
			return cryptoStream;
		}

		// Token: 0x0600017D RID: 381 RVA: 0x00007E88 File Offset: 0x00006088
		private global::System.IO.Stream CreateAndInitEncryptionStream(global::System.IO.Stream baseStream, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			global::System.Security.Cryptography.CryptoStream cryptoStream = null;
			if (entry.Version < 50 || (entry.Flags & 64) == 0)
			{
				global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged pkzipClassicManaged = new global::ICSharpCode.SharpZipLib.Encryption.PkzipClassicManaged();
				this.OnKeysRequired(entry.Name);
				if (!this.HaveKeys)
				{
					throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("No password available for encrypted stream");
				}
				cryptoStream = new global::System.Security.Cryptography.CryptoStream(new global::ICSharpCode.SharpZipLib.Zip.ZipFile.UncompressedStream(baseStream), pkzipClassicManaged.CreateEncryptor(this.key, null), global::System.Security.Cryptography.CryptoStreamMode.Write);
				if (entry.Crc < 0L || (entry.Flags & 8) != 0)
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipFile.WriteEncryptionHeader(cryptoStream, entry.DosTime << 16);
				}
				else
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipFile.WriteEncryptionHeader(cryptoStream, entry.Crc);
				}
			}
			return cryptoStream;
		}

		// Token: 0x0600017E RID: 382 RVA: 0x00007F20 File Offset: 0x00006120
		private static void CheckClassicPassword(global::System.Security.Cryptography.CryptoStream classicCryptoStream, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			byte[] array = new byte[12];
			global::ICSharpCode.SharpZipLib.Core.StreamUtils.ReadFully(classicCryptoStream, array);
			if (array[11] != entry.CryptoCheckValue)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Invalid password");
			}
		}

		// Token: 0x0600017F RID: 383 RVA: 0x00007F54 File Offset: 0x00006154
		private static void WriteEncryptionHeader(global::System.IO.Stream stream, long crcValue)
		{
			byte[] array = new byte[12];
			using (global::System.Security.Cryptography.RNGCryptoServiceProvider rngcryptoServiceProvider = new global::System.Security.Cryptography.RNGCryptoServiceProvider())
			{
				rngcryptoServiceProvider.GetBytes(array);
			}
			array[11] = (byte)(crcValue >> 24);
			stream.Write(array, 0, array.Length);
		}

		// Token: 0x040000CB RID: 203
		public global::ICSharpCode.SharpZipLib.Zip.ZipFile.KeysRequiredEventHandler KeysRequired;

		// Token: 0x040000CC RID: 204
		private const int DefaultBufferSize = 4096;

		// Token: 0x040000CD RID: 205
		private bool isDisposed_;

		// Token: 0x040000CE RID: 206
		private string name_;

		// Token: 0x040000CF RID: 207
		private string comment_;

		// Token: 0x040000D0 RID: 208
		private string rawPassword_;

		// Token: 0x040000D1 RID: 209
		private global::System.IO.Stream baseStream_;

		// Token: 0x040000D2 RID: 210
		private bool isStreamOwner;

		// Token: 0x040000D3 RID: 211
		private long offsetOfFirstEntry;

		// Token: 0x040000D4 RID: 212
		private global::ICSharpCode.SharpZipLib.Zip.ZipEntry[] entries_;

		// Token: 0x040000D5 RID: 213
		private byte[] key;

		// Token: 0x040000D6 RID: 214
		private bool isNewArchive_;

		// Token: 0x040000D7 RID: 215
		private global::ICSharpCode.SharpZipLib.Zip.UseZip64 useZip64_ = global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic;

		// Token: 0x040000D8 RID: 216
		private global::System.Collections.Generic.List<global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate> updates_;

		// Token: 0x040000D9 RID: 217
		private long updateCount_;

		// Token: 0x040000DA RID: 218
		private global::System.Collections.Generic.Dictionary<string, int> updateIndex_;

		// Token: 0x040000DB RID: 219
		private global::ICSharpCode.SharpZipLib.Zip.IArchiveStorage archiveStorage_;

		// Token: 0x040000DC RID: 220
		private global::ICSharpCode.SharpZipLib.Zip.IDynamicDataSource updateDataSource_;

		// Token: 0x040000DD RID: 221
		private bool contentsEdited_;

		// Token: 0x040000DE RID: 222
		private int bufferSize_ = 4096;

		// Token: 0x040000DF RID: 223
		private byte[] copyBuffer_;

		// Token: 0x040000E0 RID: 224
		private global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipString newComment_;

		// Token: 0x040000E1 RID: 225
		private bool commentEdited_;

		// Token: 0x040000E2 RID: 226
		private global::ICSharpCode.SharpZipLib.Zip.IEntryFactory updateEntryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory();

		// Token: 0x02000080 RID: 128
		// (Invoke) Token: 0x0600051A RID: 1306
		public delegate void KeysRequiredEventHandler(object sender, global::ICSharpCode.SharpZipLib.Zip.KeysRequiredEventArgs e);

		// Token: 0x02000081 RID: 129
		[global::System.Flags]
		private enum HeaderTest
		{
			// Token: 0x0400033D RID: 829
			Extract = 1,
			// Token: 0x0400033E RID: 830
			Header = 2
		}

		// Token: 0x02000082 RID: 130
		private enum UpdateCommand
		{
			// Token: 0x04000340 RID: 832
			Copy,
			// Token: 0x04000341 RID: 833
			Modify,
			// Token: 0x04000342 RID: 834
			Add
		}

		// Token: 0x02000083 RID: 131
		private class UpdateComparer : global::System.Collections.Generic.IComparer<global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate>
		{
			// Token: 0x0600051D RID: 1309 RVA: 0x00017EA8 File Offset: 0x000160A8
			public int Compare(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate x, global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipUpdate y)
			{
				int num;
				if (x == null)
				{
					if (y == null)
					{
						num = 0;
					}
					else
					{
						num = -1;
					}
				}
				else if (y == null)
				{
					num = 1;
				}
				else
				{
					int num2 = (x.Command == global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy || x.Command == global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Modify) ? 0 : 1;
					int num3 = (y.Command == global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy || y.Command == global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Modify) ? 0 : 1;
					num = num2 - num3;
					if (num == 0)
					{
						long num4 = x.Entry.Offset - y.Entry.Offset;
						if (num4 < 0L)
						{
							num = -1;
						}
						else if (num4 == 0L)
						{
							num = 0;
						}
						else
						{
							num = 1;
						}
					}
				}
				return num;
			}
		}

		// Token: 0x02000084 RID: 132
		private class ZipUpdate
		{
			// Token: 0x0600051F RID: 1311 RVA: 0x00017F2E File Offset: 0x0001612E
			public ZipUpdate(string fileName, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
			{
				this.command_ = global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add;
				this.entry_ = entry;
				this.filename_ = fileName;
			}

			// Token: 0x06000520 RID: 1312 RVA: 0x00017F64 File Offset: 0x00016164
			[global::System.Obsolete]
			public ZipUpdate(string fileName, string entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod)
			{
				this.command_ = global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add;
				this.entry_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(entryName)
				{
					CompressionMethod = compressionMethod
				};
				this.filename_ = fileName;
			}

			// Token: 0x06000521 RID: 1313 RVA: 0x00017FB0 File Offset: 0x000161B0
			[global::System.Obsolete]
			public ZipUpdate(string fileName, string entryName) : this(fileName, entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod.Deflated)
			{
			}

			// Token: 0x06000522 RID: 1314 RVA: 0x00017FBC File Offset: 0x000161BC
			[global::System.Obsolete]
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, string entryName, global::ICSharpCode.SharpZipLib.Zip.CompressionMethod compressionMethod)
			{
				this.command_ = global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add;
				this.entry_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntry(entryName)
				{
					CompressionMethod = compressionMethod
				};
				this.dataSource_ = dataSource;
			}

			// Token: 0x06000523 RID: 1315 RVA: 0x00018008 File Offset: 0x00016208
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
			{
				this.command_ = global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Add;
				this.entry_ = entry;
				this.dataSource_ = dataSource;
			}

			// Token: 0x06000524 RID: 1316 RVA: 0x0001803D File Offset: 0x0001623D
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipEntry original, global::ICSharpCode.SharpZipLib.Zip.ZipEntry updated)
			{
				throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Modify not currently supported");
			}

			// Token: 0x06000525 RID: 1317 RVA: 0x00018067 File Offset: 0x00016267
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand command, global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
			{
				this.command_ = command;
				this.entry_ = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)entry.Clone();
			}

			// Token: 0x06000526 RID: 1318 RVA: 0x0001809F File Offset: 0x0001629F
			public ZipUpdate(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry) : this(global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand.Copy, entry)
			{
			}

			// Token: 0x1700011D RID: 285
			// (get) Token: 0x06000527 RID: 1319 RVA: 0x000180A9 File Offset: 0x000162A9
			public global::ICSharpCode.SharpZipLib.Zip.ZipEntry Entry
			{
				get
				{
					return this.entry_;
				}
			}

			// Token: 0x1700011E RID: 286
			// (get) Token: 0x06000528 RID: 1320 RVA: 0x000180B1 File Offset: 0x000162B1
			public global::ICSharpCode.SharpZipLib.Zip.ZipEntry OutEntry
			{
				get
				{
					if (this.outEntry_ == null)
					{
						this.outEntry_ = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)this.entry_.Clone();
					}
					return this.outEntry_;
				}
			}

			// Token: 0x1700011F RID: 287
			// (get) Token: 0x06000529 RID: 1321 RVA: 0x000180D7 File Offset: 0x000162D7
			public global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand Command
			{
				get
				{
					return this.command_;
				}
			}

			// Token: 0x17000120 RID: 288
			// (get) Token: 0x0600052A RID: 1322 RVA: 0x000180DF File Offset: 0x000162DF
			public string Filename
			{
				get
				{
					return this.filename_;
				}
			}

			// Token: 0x17000121 RID: 289
			// (get) Token: 0x0600052B RID: 1323 RVA: 0x000180E7 File Offset: 0x000162E7
			// (set) Token: 0x0600052C RID: 1324 RVA: 0x000180EF File Offset: 0x000162EF
			public long SizePatchOffset
			{
				get
				{
					return this.sizePatchOffset_;
				}
				set
				{
					this.sizePatchOffset_ = value;
				}
			}

			// Token: 0x17000122 RID: 290
			// (get) Token: 0x0600052D RID: 1325 RVA: 0x000180F8 File Offset: 0x000162F8
			// (set) Token: 0x0600052E RID: 1326 RVA: 0x00018100 File Offset: 0x00016300
			public long CrcPatchOffset
			{
				get
				{
					return this.crcPatchOffset_;
				}
				set
				{
					this.crcPatchOffset_ = value;
				}
			}

			// Token: 0x17000123 RID: 291
			// (get) Token: 0x0600052F RID: 1327 RVA: 0x00018109 File Offset: 0x00016309
			// (set) Token: 0x06000530 RID: 1328 RVA: 0x00018111 File Offset: 0x00016311
			public long OffsetBasedSize
			{
				get
				{
					return this._offsetBasedSize;
				}
				set
				{
					this._offsetBasedSize = value;
				}
			}

			// Token: 0x06000531 RID: 1329 RVA: 0x0001811C File Offset: 0x0001631C
			public global::System.IO.Stream GetSource()
			{
				global::System.IO.Stream result = null;
				if (this.dataSource_ != null)
				{
					result = this.dataSource_.GetSource();
				}
				return result;
			}

			// Token: 0x04000343 RID: 835
			private global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry_;

			// Token: 0x04000344 RID: 836
			private global::ICSharpCode.SharpZipLib.Zip.ZipEntry outEntry_;

			// Token: 0x04000345 RID: 837
			private readonly global::ICSharpCode.SharpZipLib.Zip.ZipFile.UpdateCommand command_;

			// Token: 0x04000346 RID: 838
			private global::ICSharpCode.SharpZipLib.Zip.IStaticDataSource dataSource_;

			// Token: 0x04000347 RID: 839
			private readonly string filename_;

			// Token: 0x04000348 RID: 840
			private long sizePatchOffset_ = -1L;

			// Token: 0x04000349 RID: 841
			private long crcPatchOffset_ = -1L;

			// Token: 0x0400034A RID: 842
			private long _offsetBasedSize = -1L;
		}

		// Token: 0x02000085 RID: 133
		private class ZipString
		{
			// Token: 0x06000532 RID: 1330 RVA: 0x00018140 File Offset: 0x00016340
			public ZipString(string comment)
			{
				this.comment_ = comment;
				this.isSourceString_ = true;
			}

			// Token: 0x06000533 RID: 1331 RVA: 0x00018156 File Offset: 0x00016356
			public ZipString(byte[] rawString)
			{
				this.rawComment_ = rawString;
			}

			// Token: 0x17000124 RID: 292
			// (get) Token: 0x06000534 RID: 1332 RVA: 0x00018165 File Offset: 0x00016365
			public bool IsSourceString
			{
				get
				{
					return this.isSourceString_;
				}
			}

			// Token: 0x17000125 RID: 293
			// (get) Token: 0x06000535 RID: 1333 RVA: 0x0001816D File Offset: 0x0001636D
			public int RawLength
			{
				get
				{
					this.MakeBytesAvailable();
					return this.rawComment_.Length;
				}
			}

			// Token: 0x17000126 RID: 294
			// (get) Token: 0x06000536 RID: 1334 RVA: 0x0001817D File Offset: 0x0001637D
			public byte[] RawComment
			{
				get
				{
					this.MakeBytesAvailable();
					return (byte[])this.rawComment_.Clone();
				}
			}

			// Token: 0x06000537 RID: 1335 RVA: 0x00018195 File Offset: 0x00016395
			public void Reset()
			{
				if (this.isSourceString_)
				{
					this.rawComment_ = null;
					return;
				}
				this.comment_ = null;
			}

			// Token: 0x06000538 RID: 1336 RVA: 0x000181AE File Offset: 0x000163AE
			private void MakeTextAvailable()
			{
				if (this.comment_ == null)
				{
					this.comment_ = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToString(this.rawComment_);
				}
			}

			// Token: 0x06000539 RID: 1337 RVA: 0x000181C9 File Offset: 0x000163C9
			private void MakeBytesAvailable()
			{
				if (this.rawComment_ == null)
				{
					this.rawComment_ = global::ICSharpCode.SharpZipLib.Zip.ZipStrings.ConvertToArray(this.comment_);
				}
			}

			// Token: 0x0600053A RID: 1338 RVA: 0x000181E4 File Offset: 0x000163E4
			public static implicit operator string(global::ICSharpCode.SharpZipLib.Zip.ZipFile.ZipString zipString)
			{
				zipString.MakeTextAvailable();
				return zipString.comment_;
			}

			// Token: 0x0400034B RID: 843
			private string comment_;

			// Token: 0x0400034C RID: 844
			private byte[] rawComment_;

			// Token: 0x0400034D RID: 845
			private readonly bool isSourceString_;
		}

		// Token: 0x02000086 RID: 134
		private class ZipEntryEnumerator : global::System.Collections.IEnumerator
		{
			// Token: 0x0600053B RID: 1339 RVA: 0x000181F2 File Offset: 0x000163F2
			public ZipEntryEnumerator(global::ICSharpCode.SharpZipLib.Zip.ZipEntry[] entries)
			{
				this.array = entries;
			}

			// Token: 0x17000127 RID: 295
			// (get) Token: 0x0600053C RID: 1340 RVA: 0x00018208 File Offset: 0x00016408
			public object Current
			{
				get
				{
					return this.array[this.index];
				}
			}

			// Token: 0x0600053D RID: 1341 RVA: 0x00018217 File Offset: 0x00016417
			public void Reset()
			{
				this.index = -1;
			}

			// Token: 0x0600053E RID: 1342 RVA: 0x00018220 File Offset: 0x00016420
			public bool MoveNext()
			{
				int num = this.index + 1;
				this.index = num;
				return num < this.array.Length;
			}

			// Token: 0x0400034E RID: 846
			private global::ICSharpCode.SharpZipLib.Zip.ZipEntry[] array;

			// Token: 0x0400034F RID: 847
			private int index = -1;
		}

		// Token: 0x02000087 RID: 135
		private class UncompressedStream : global::System.IO.Stream
		{
			// Token: 0x0600053F RID: 1343 RVA: 0x00018248 File Offset: 0x00016448
			public UncompressedStream(global::System.IO.Stream baseStream)
			{
				this.baseStream_ = baseStream;
			}

			// Token: 0x17000128 RID: 296
			// (get) Token: 0x06000540 RID: 1344 RVA: 0x00018257 File Offset: 0x00016457
			public override bool CanRead
			{
				get
				{
					return false;
				}
			}

			// Token: 0x06000541 RID: 1345 RVA: 0x0001825A File Offset: 0x0001645A
			public override void Flush()
			{
				this.baseStream_.Flush();
			}

			// Token: 0x17000129 RID: 297
			// (get) Token: 0x06000542 RID: 1346 RVA: 0x00018267 File Offset: 0x00016467
			public override bool CanWrite
			{
				get
				{
					return this.baseStream_.CanWrite;
				}
			}

			// Token: 0x1700012A RID: 298
			// (get) Token: 0x06000543 RID: 1347 RVA: 0x00018274 File Offset: 0x00016474
			public override bool CanSeek
			{
				get
				{
					return false;
				}
			}

			// Token: 0x1700012B RID: 299
			// (get) Token: 0x06000544 RID: 1348 RVA: 0x00018277 File Offset: 0x00016477
			public override long Length
			{
				get
				{
					return 0L;
				}
			}

			// Token: 0x1700012C RID: 300
			// (get) Token: 0x06000545 RID: 1349 RVA: 0x0001827B File Offset: 0x0001647B
			// (set) Token: 0x06000546 RID: 1350 RVA: 0x00018288 File Offset: 0x00016488
			public override long Position
			{
				get
				{
					return this.baseStream_.Position;
				}
				set
				{
					throw new global::System.NotImplementedException();
				}
			}

			// Token: 0x06000547 RID: 1351 RVA: 0x0001828F File Offset: 0x0001648F
			public override int Read(byte[] buffer, int offset, int count)
			{
				return 0;
			}

			// Token: 0x06000548 RID: 1352 RVA: 0x00018292 File Offset: 0x00016492
			public override long Seek(long offset, global::System.IO.SeekOrigin origin)
			{
				return 0L;
			}

			// Token: 0x06000549 RID: 1353 RVA: 0x00018296 File Offset: 0x00016496
			public override void SetLength(long value)
			{
			}

			// Token: 0x0600054A RID: 1354 RVA: 0x00018298 File Offset: 0x00016498
			public override void Write(byte[] buffer, int offset, int count)
			{
				this.baseStream_.Write(buffer, offset, count);
			}

			// Token: 0x04000350 RID: 848
			private readonly global::System.IO.Stream baseStream_;
		}

		// Token: 0x02000088 RID: 136
		private class PartialInputStream : global::System.IO.Stream
		{
			// Token: 0x0600054B RID: 1355 RVA: 0x000182A8 File Offset: 0x000164A8
			public PartialInputStream(global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile, long start, long length)
			{
				this.start_ = start;
				this.length_ = length;
				this.zipFile_ = zipFile;
				this.baseStream_ = this.zipFile_.baseStream_;
				this.readPos_ = start;
				this.end_ = start + length;
			}

			// Token: 0x0600054C RID: 1356 RVA: 0x000182E8 File Offset: 0x000164E8
			public override int ReadByte()
			{
				if (this.readPos_ >= this.end_)
				{
					return -1;
				}
				global::System.IO.Stream obj = this.baseStream_;
				int result;
				lock (obj)
				{
					global::System.IO.Stream stream = this.baseStream_;
					long num = this.readPos_;
					this.readPos_ = num + 1L;
					stream.Seek(num, global::System.IO.SeekOrigin.Begin);
					result = this.baseStream_.ReadByte();
				}
				return result;
			}

			// Token: 0x0600054D RID: 1357 RVA: 0x00018360 File Offset: 0x00016560
			public override int Read(byte[] buffer, int offset, int count)
			{
				global::System.IO.Stream obj = this.baseStream_;
				int result;
				lock (obj)
				{
					if ((long)count > this.end_ - this.readPos_)
					{
						count = (int)(this.end_ - this.readPos_);
						if (count == 0)
						{
							return 0;
						}
					}
					if (this.baseStream_.Position != this.readPos_)
					{
						this.baseStream_.Seek(this.readPos_, global::System.IO.SeekOrigin.Begin);
					}
					int num = this.baseStream_.Read(buffer, offset, count);
					if (num > 0)
					{
						this.readPos_ += (long)num;
					}
					result = num;
				}
				return result;
			}

			// Token: 0x0600054E RID: 1358 RVA: 0x00018410 File Offset: 0x00016610
			public override void Write(byte[] buffer, int offset, int count)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x0600054F RID: 1359 RVA: 0x00018417 File Offset: 0x00016617
			public override void SetLength(long value)
			{
				throw new global::System.NotSupportedException();
			}

			// Token: 0x06000550 RID: 1360 RVA: 0x00018420 File Offset: 0x00016620
			public override long Seek(long offset, global::System.IO.SeekOrigin origin)
			{
				long num = this.readPos_;
				switch (origin)
				{
				case global::System.IO.SeekOrigin.Begin:
					num = this.start_ + offset;
					break;
				case global::System.IO.SeekOrigin.Current:
					num = this.readPos_ + offset;
					break;
				case global::System.IO.SeekOrigin.End:
					num = this.end_ + offset;
					break;
				}
				if (num < this.start_)
				{
					throw new global::System.ArgumentException("Negative position is invalid");
				}
				if (num > this.end_)
				{
					throw new global::System.IO.IOException("Cannot seek past end");
				}
				this.readPos_ = num;
				return this.readPos_;
			}

			// Token: 0x06000551 RID: 1361 RVA: 0x0001849C File Offset: 0x0001669C
			public override void Flush()
			{
			}

			// Token: 0x1700012D RID: 301
			// (get) Token: 0x06000552 RID: 1362 RVA: 0x0001849E File Offset: 0x0001669E
			// (set) Token: 0x06000553 RID: 1363 RVA: 0x000184B0 File Offset: 0x000166B0
			public override long Position
			{
				get
				{
					return this.readPos_ - this.start_;
				}
				set
				{
					long num = this.start_ + value;
					if (num < this.start_)
					{
						throw new global::System.ArgumentException("Negative position is invalid");
					}
					if (num > this.end_)
					{
						throw new global::System.InvalidOperationException("Cannot seek past end");
					}
					this.readPos_ = num;
				}
			}

			// Token: 0x1700012E RID: 302
			// (get) Token: 0x06000554 RID: 1364 RVA: 0x000184F5 File Offset: 0x000166F5
			public override long Length
			{
				get
				{
					return this.length_;
				}
			}

			// Token: 0x1700012F RID: 303
			// (get) Token: 0x06000555 RID: 1365 RVA: 0x000184FD File Offset: 0x000166FD
			public override bool CanWrite
			{
				get
				{
					return false;
				}
			}

			// Token: 0x17000130 RID: 304
			// (get) Token: 0x06000556 RID: 1366 RVA: 0x00018500 File Offset: 0x00016700
			public override bool CanSeek
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000131 RID: 305
			// (get) Token: 0x06000557 RID: 1367 RVA: 0x00018503 File Offset: 0x00016703
			public override bool CanRead
			{
				get
				{
					return true;
				}
			}

			// Token: 0x17000132 RID: 306
			// (get) Token: 0x06000558 RID: 1368 RVA: 0x00018506 File Offset: 0x00016706
			public override bool CanTimeout
			{
				get
				{
					return this.baseStream_.CanTimeout;
				}
			}

			// Token: 0x04000351 RID: 849
			private global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile_;

			// Token: 0x04000352 RID: 850
			private global::System.IO.Stream baseStream_;

			// Token: 0x04000353 RID: 851
			private readonly long start_;

			// Token: 0x04000354 RID: 852
			private readonly long length_;

			// Token: 0x04000355 RID: 853
			private long readPos_;

			// Token: 0x04000356 RID: 854
			private readonly long end_;
		}
	}
}
