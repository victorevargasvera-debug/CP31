using System;
using System.Collections;
using System.IO;
using ICSharpCode.SharpZipLib.Core;
using ICSharpCode.SharpZipLib.Zip.Compression;

namespace ICSharpCode.SharpZipLib.Zip
{
	// Token: 0x02000008 RID: 8
	public class FastZip
	{
		// Token: 0x06000021 RID: 33 RVA: 0x00002312 File Offset: 0x00000512
		public FastZip()
		{
		}

		// Token: 0x06000022 RID: 34 RVA: 0x0000233A File Offset: 0x0000053A
		public FastZip(global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting timeSetting)
		{
			this.entryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory(timeSetting);
			this.restoreDateTimeOnExtract_ = true;
		}

		// Token: 0x06000023 RID: 35 RVA: 0x00002375 File Offset: 0x00000575
		public FastZip(global::System.DateTime time)
		{
			this.entryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory(time);
			this.restoreDateTimeOnExtract_ = true;
		}

		// Token: 0x06000024 RID: 36 RVA: 0x000023B0 File Offset: 0x000005B0
		public FastZip(global::ICSharpCode.SharpZipLib.Zip.FastZipEvents events)
		{
			this.events_ = events;
		}

		// Token: 0x17000002 RID: 2
		// (get) Token: 0x06000025 RID: 37 RVA: 0x000023DF File Offset: 0x000005DF
		// (set) Token: 0x06000026 RID: 38 RVA: 0x000023E7 File Offset: 0x000005E7
		public bool CreateEmptyDirectories
		{
			get
			{
				return this.createEmptyDirectories_;
			}
			set
			{
				this.createEmptyDirectories_ = value;
			}
		}

		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000027 RID: 39 RVA: 0x000023F0 File Offset: 0x000005F0
		// (set) Token: 0x06000028 RID: 40 RVA: 0x000023F8 File Offset: 0x000005F8
		public string Password
		{
			get
			{
				return this.password_;
			}
			set
			{
				this.password_ = value;
			}
		}

		// Token: 0x17000004 RID: 4
		// (get) Token: 0x06000029 RID: 41 RVA: 0x00002401 File Offset: 0x00000601
		// (set) Token: 0x0600002A RID: 42 RVA: 0x00002409 File Offset: 0x00000609
		public global::ICSharpCode.SharpZipLib.Zip.ZipEncryptionMethod EntryEncryptionMethod { get; set; } = global::ICSharpCode.SharpZipLib.Zip.ZipEncryptionMethod.ZipCrypto;

		// Token: 0x17000005 RID: 5
		// (get) Token: 0x0600002B RID: 43 RVA: 0x00002412 File Offset: 0x00000612
		// (set) Token: 0x0600002C RID: 44 RVA: 0x0000241F File Offset: 0x0000061F
		public global::ICSharpCode.SharpZipLib.Core.INameTransform NameTransform
		{
			get
			{
				return this.entryFactory_.NameTransform;
			}
			set
			{
				this.entryFactory_.NameTransform = value;
			}
		}

		// Token: 0x17000006 RID: 6
		// (get) Token: 0x0600002D RID: 45 RVA: 0x0000242D File Offset: 0x0000062D
		// (set) Token: 0x0600002E RID: 46 RVA: 0x00002435 File Offset: 0x00000635
		public global::ICSharpCode.SharpZipLib.Zip.IEntryFactory EntryFactory
		{
			get
			{
				return this.entryFactory_;
			}
			set
			{
				if (value == null)
				{
					this.entryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory();
					return;
				}
				this.entryFactory_ = value;
			}
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x0600002F RID: 47 RVA: 0x0000244D File Offset: 0x0000064D
		// (set) Token: 0x06000030 RID: 48 RVA: 0x00002455 File Offset: 0x00000655
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

		// Token: 0x17000008 RID: 8
		// (get) Token: 0x06000031 RID: 49 RVA: 0x0000245E File Offset: 0x0000065E
		// (set) Token: 0x06000032 RID: 50 RVA: 0x00002466 File Offset: 0x00000666
		public bool RestoreDateTimeOnExtract
		{
			get
			{
				return this.restoreDateTimeOnExtract_;
			}
			set
			{
				this.restoreDateTimeOnExtract_ = value;
			}
		}

		// Token: 0x17000009 RID: 9
		// (get) Token: 0x06000033 RID: 51 RVA: 0x0000246F File Offset: 0x0000066F
		// (set) Token: 0x06000034 RID: 52 RVA: 0x00002477 File Offset: 0x00000677
		public bool RestoreAttributesOnExtract
		{
			get
			{
				return this.restoreAttributesOnExtract_;
			}
			set
			{
				this.restoreAttributesOnExtract_ = value;
			}
		}

		// Token: 0x1700000A RID: 10
		// (get) Token: 0x06000035 RID: 53 RVA: 0x00002480 File Offset: 0x00000680
		// (set) Token: 0x06000036 RID: 54 RVA: 0x00002488 File Offset: 0x00000688
		public global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater.CompressionLevel CompressionLevel
		{
			get
			{
				return this.compressionLevel_;
			}
			set
			{
				this.compressionLevel_ = value;
			}
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00002491 File Offset: 0x00000691
		public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
		{
			this.CreateZip(global::System.IO.File.Create(zipFileName), sourceDirectory, recurse, fileFilter, directoryFilter);
		}

		// Token: 0x06000038 RID: 56 RVA: 0x000024A5 File Offset: 0x000006A5
		public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, string fileFilter)
		{
			this.CreateZip(global::System.IO.File.Create(zipFileName), sourceDirectory, recurse, fileFilter, null);
		}

		// Token: 0x06000039 RID: 57 RVA: 0x000024B8 File Offset: 0x000006B8
		public void CreateZip(global::System.IO.Stream outputStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter)
		{
			this.CreateZip(outputStream, sourceDirectory, recurse, fileFilter, directoryFilter, false);
		}

		// Token: 0x0600003A RID: 58 RVA: 0x000024C8 File Offset: 0x000006C8
		public void CreateZip(global::System.IO.Stream outputStream, string sourceDirectory, bool recurse, string fileFilter, string directoryFilter, bool leaveOpen)
		{
			global::ICSharpCode.SharpZipLib.Core.FileSystemScanner scanner = new global::ICSharpCode.SharpZipLib.Core.FileSystemScanner(fileFilter, directoryFilter);
			this.CreateZip(outputStream, sourceDirectory, recurse, scanner, leaveOpen);
		}

		// Token: 0x0600003B RID: 59 RVA: 0x000024EB File Offset: 0x000006EB
		public void CreateZip(string zipFileName, string sourceDirectory, bool recurse, global::ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter, global::ICSharpCode.SharpZipLib.Core.IScanFilter directoryFilter)
		{
			this.CreateZip(global::System.IO.File.Create(zipFileName), sourceDirectory, recurse, fileFilter, directoryFilter, false);
		}

		// Token: 0x0600003C RID: 60 RVA: 0x00002500 File Offset: 0x00000700
		public void CreateZip(global::System.IO.Stream outputStream, string sourceDirectory, bool recurse, global::ICSharpCode.SharpZipLib.Core.IScanFilter fileFilter, global::ICSharpCode.SharpZipLib.Core.IScanFilter directoryFilter, bool leaveOpen = false)
		{
			global::ICSharpCode.SharpZipLib.Core.FileSystemScanner scanner = new global::ICSharpCode.SharpZipLib.Core.FileSystemScanner(fileFilter, directoryFilter);
			this.CreateZip(outputStream, sourceDirectory, recurse, scanner, leaveOpen);
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00002524 File Offset: 0x00000724
		private void CreateZip(global::System.IO.Stream outputStream, string sourceDirectory, bool recurse, global::ICSharpCode.SharpZipLib.Core.FileSystemScanner scanner, bool leaveOpen)
		{
			this.NameTransform = new global::ICSharpCode.SharpZipLib.Zip.ZipNameTransform(sourceDirectory);
			this.sourceDirectory_ = sourceDirectory;
			using (this.outputStream_ = new global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream(outputStream))
			{
				this.outputStream_.SetLevel((int)this.CompressionLevel);
				this.outputStream_.IsStreamOwner = !leaveOpen;
				this.outputStream_.NameTransform = null;
				if (!string.IsNullOrEmpty(this.password_) && this.EntryEncryptionMethod != global::ICSharpCode.SharpZipLib.Zip.ZipEncryptionMethod.None)
				{
					this.outputStream_.Password = this.password_;
				}
				this.outputStream_.UseZip64 = this.UseZip64;
				scanner.ProcessFile = (global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler)global::System.Delegate.Combine(scanner.ProcessFile, new global::ICSharpCode.SharpZipLib.Core.ProcessFileHandler(this.ProcessFile));
				if (this.CreateEmptyDirectories)
				{
					scanner.ProcessDirectory += this.ProcessDirectory;
				}
				if (this.events_ != null)
				{
					if (this.events_.FileFailure != null)
					{
						scanner.FileFailure = (global::ICSharpCode.SharpZipLib.Core.FileFailureHandler)global::System.Delegate.Combine(scanner.FileFailure, this.events_.FileFailure);
					}
					if (this.events_.DirectoryFailure != null)
					{
						scanner.DirectoryFailure = (global::ICSharpCode.SharpZipLib.Core.DirectoryFailureHandler)global::System.Delegate.Combine(scanner.DirectoryFailure, this.events_.DirectoryFailure);
					}
				}
				scanner.Scan(sourceDirectory, recurse);
			}
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00002690 File Offset: 0x00000890
		public void ExtractZip(string zipFileName, string targetDirectory, string fileFilter)
		{
			this.ExtractZip(zipFileName, targetDirectory, global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Always, null, fileFilter, null, this.restoreDateTimeOnExtract_, false);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000026B0 File Offset: 0x000008B0
		public void ExtractZip(string zipFileName, string targetDirectory, global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite overwrite, global::ICSharpCode.SharpZipLib.Zip.FastZip.ConfirmOverwriteDelegate confirmDelegate, string fileFilter, string directoryFilter, bool restoreDateTime, bool allowParentTraversal = false)
		{
			global::System.IO.Stream inputStream = global::System.IO.File.Open(zipFileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read);
			this.ExtractZip(inputStream, targetDirectory, overwrite, confirmDelegate, fileFilter, directoryFilter, restoreDateTime, true, allowParentTraversal);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x000026DC File Offset: 0x000008DC
		public void ExtractZip(global::System.IO.Stream inputStream, string targetDirectory, global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite overwrite, global::ICSharpCode.SharpZipLib.Zip.FastZip.ConfirmOverwriteDelegate confirmDelegate, string fileFilter, string directoryFilter, bool restoreDateTime, bool isStreamOwner, bool allowParentTraversal = false)
		{
			if (overwrite == global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Prompt && confirmDelegate == null)
			{
				throw new global::System.ArgumentNullException("confirmDelegate");
			}
			this.continueRunning_ = true;
			this.overwrite_ = overwrite;
			this.confirmDelegate_ = confirmDelegate;
			this.extractNameTransform_ = new global::ICSharpCode.SharpZipLib.Zip.WindowsNameTransform(targetDirectory, allowParentTraversal);
			this.fileFilter_ = new global::ICSharpCode.SharpZipLib.Core.NameFilter(fileFilter);
			this.directoryFilter_ = new global::ICSharpCode.SharpZipLib.Core.NameFilter(directoryFilter);
			this.restoreDateTimeOnExtract_ = restoreDateTime;
			using (this.zipFile_ = new global::ICSharpCode.SharpZipLib.Zip.ZipFile(inputStream, !isStreamOwner))
			{
				if (this.password_ != null)
				{
					this.zipFile_.Password = this.password_;
				}
				global::System.Collections.IEnumerator enumerator = this.zipFile_.GetEnumerator();
				while (this.continueRunning_ && enumerator.MoveNext())
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipEntry zipEntry = (global::ICSharpCode.SharpZipLib.Zip.ZipEntry)enumerator.Current;
					if (zipEntry.IsFile)
					{
						if (this.directoryFilter_.IsMatch(global::System.IO.Path.GetDirectoryName(zipEntry.Name)) && this.fileFilter_.IsMatch(zipEntry.Name))
						{
							this.ExtractEntry(zipEntry);
						}
					}
					else if (zipEntry.IsDirectory && this.directoryFilter_.IsMatch(zipEntry.Name) && this.CreateEmptyDirectories)
					{
						this.ExtractEntry(zipEntry);
					}
				}
			}
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00002820 File Offset: 0x00000A20
		private void ProcessDirectory(object sender, global::ICSharpCode.SharpZipLib.Core.DirectoryEventArgs e)
		{
			if (!e.HasMatchingFiles && this.CreateEmptyDirectories)
			{
				if (this.events_ != null)
				{
					this.events_.OnProcessDirectory(e.Name, e.HasMatchingFiles);
				}
				if (e.ContinueRunning && e.Name != this.sourceDirectory_)
				{
					global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = this.entryFactory_.MakeDirectoryEntry(e.Name);
					this.outputStream_.PutNextEntry(entry);
				}
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00002898 File Offset: 0x00000A98
		private void ProcessFile(object sender, global::ICSharpCode.SharpZipLib.Core.ScanEventArgs e)
		{
			if (this.events_ != null && this.events_.ProcessFile != null)
			{
				this.events_.ProcessFile(sender, e);
			}
			if (e.ContinueRunning)
			{
				try
				{
					using (global::System.IO.FileStream fileStream = global::System.IO.File.Open(e.Name, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Read))
					{
						global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry = this.entryFactory_.MakeFileEntry(e.Name);
						this.ConfigureEntryEncryption(entry);
						this.outputStream_.PutNextEntry(entry);
						this.AddFileContents(e.Name, fileStream);
					}
				}
				catch (global::System.Exception e2)
				{
					if (this.events_ == null)
					{
						this.continueRunning_ = false;
						throw;
					}
					this.continueRunning_ = this.events_.OnFileFailure(e.Name, e2);
				}
			}
		}

		// Token: 0x06000043 RID: 67 RVA: 0x00002970 File Offset: 0x00000B70
		private void ConfigureEntryEncryption(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			if (!string.IsNullOrEmpty(this.Password) && entry.AESEncryptionStrength == 0)
			{
				global::ICSharpCode.SharpZipLib.Zip.ZipEncryptionMethod entryEncryptionMethod = this.EntryEncryptionMethod;
				if (entryEncryptionMethod == global::ICSharpCode.SharpZipLib.Zip.ZipEncryptionMethod.AES128)
				{
					entry.AESKeySize = 128;
					return;
				}
				if (entryEncryptionMethod != global::ICSharpCode.SharpZipLib.Zip.ZipEncryptionMethod.AES256)
				{
					return;
				}
				entry.AESKeySize = 256;
			}
		}

		// Token: 0x06000044 RID: 68 RVA: 0x000029BC File Offset: 0x00000BBC
		private void AddFileContents(string name, global::System.IO.Stream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			if (this.buffer_ == null)
			{
				this.buffer_ = new byte[4096];
			}
			if (this.events_ != null && this.events_.Progress != null)
			{
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(stream, this.outputStream_, this.buffer_, this.events_.Progress, this.events_.ProgressInterval, this, name);
			}
			else
			{
				global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(stream, this.outputStream_, this.buffer_);
			}
			if (this.events_ != null)
			{
				this.continueRunning_ = this.events_.OnCompletedFile(name);
			}
		}

		// Token: 0x06000045 RID: 69 RVA: 0x00002A5C File Offset: 0x00000C5C
		private void ExtractFileEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry, string targetName)
		{
			bool flag = true;
			if (this.overwrite_ != global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Always && global::System.IO.File.Exists(targetName))
			{
				flag = (this.overwrite_ == global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite.Prompt && this.confirmDelegate_ != null && this.confirmDelegate_(targetName));
			}
			if (flag)
			{
				if (this.events_ != null)
				{
					this.continueRunning_ = this.events_.OnProcessFile(entry.Name);
				}
				if (this.continueRunning_)
				{
					try
					{
						using (global::System.IO.FileStream fileStream = global::System.IO.File.Create(targetName))
						{
							if (this.buffer_ == null)
							{
								this.buffer_ = new byte[4096];
							}
							using (global::System.IO.Stream inputStream = this.zipFile_.GetInputStream(entry))
							{
								if (this.events_ != null && this.events_.Progress != null)
								{
									global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(inputStream, fileStream, this.buffer_, this.events_.Progress, this.events_.ProgressInterval, this, entry.Name, entry.Size);
								}
								else
								{
									global::ICSharpCode.SharpZipLib.Core.StreamUtils.Copy(inputStream, fileStream, this.buffer_);
								}
							}
							if (this.events_ != null)
							{
								this.continueRunning_ = this.events_.OnCompletedFile(entry.Name);
							}
						}
						if (this.restoreDateTimeOnExtract_)
						{
							switch (this.entryFactory_.Setting)
							{
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTime:
								global::System.IO.File.SetLastWriteTime(targetName, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTimeUtc:
								global::System.IO.File.SetLastWriteTimeUtc(targetName, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTime:
								global::System.IO.File.SetCreationTime(targetName, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTimeUtc:
								global::System.IO.File.SetCreationTimeUtc(targetName, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTime:
								global::System.IO.File.SetLastAccessTime(targetName, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTimeUtc:
								global::System.IO.File.SetLastAccessTimeUtc(targetName, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed:
								global::System.IO.File.SetLastWriteTime(targetName, this.entryFactory_.FixedDateTime);
								break;
							default:
								throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unhandled time setting in ExtractFileEntry");
							}
						}
						if (this.RestoreAttributesOnExtract && entry.IsDOSEntry && entry.ExternalFileAttributes != -1)
						{
							global::System.IO.FileAttributes fileAttributes = (global::System.IO.FileAttributes)entry.ExternalFileAttributes;
							fileAttributes &= (global::System.IO.FileAttributes.ReadOnly | global::System.IO.FileAttributes.Hidden | global::System.IO.FileAttributes.Archive | global::System.IO.FileAttributes.Normal);
							global::System.IO.File.SetAttributes(targetName, fileAttributes);
						}
					}
					catch (global::System.Exception e)
					{
						if (this.events_ == null)
						{
							this.continueRunning_ = false;
							throw;
						}
						this.continueRunning_ = this.events_.OnFileFailure(targetName, e);
					}
				}
			}
		}

		// Token: 0x06000046 RID: 70 RVA: 0x00002CE0 File Offset: 0x00000EE0
		private void ExtractEntry(global::ICSharpCode.SharpZipLib.Zip.ZipEntry entry)
		{
			bool flag = entry.IsCompressionMethodSupported();
			string text = entry.Name;
			if (flag)
			{
				if (entry.IsFile)
				{
					text = this.extractNameTransform_.TransformFile(text);
				}
				else if (entry.IsDirectory)
				{
					text = this.extractNameTransform_.TransformDirectory(text);
				}
				flag = !string.IsNullOrEmpty(text);
			}
			string text2 = string.Empty;
			if (flag)
			{
				if (entry.IsDirectory)
				{
					text2 = text;
				}
				else
				{
					text2 = global::System.IO.Path.GetDirectoryName(global::System.IO.Path.GetFullPath(text));
				}
			}
			if (flag && !global::System.IO.Directory.Exists(text2) && (!entry.IsDirectory || this.CreateEmptyDirectories))
			{
				try
				{
					global::ICSharpCode.SharpZipLib.Zip.FastZipEvents fastZipEvents = this.events_;
					this.continueRunning_ = (fastZipEvents == null || fastZipEvents.OnProcessDirectory(text2, true));
					if (this.continueRunning_)
					{
						global::System.IO.Directory.CreateDirectory(text2);
						if (entry.IsDirectory && this.restoreDateTimeOnExtract_)
						{
							switch (this.entryFactory_.Setting)
							{
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTime:
								global::System.IO.Directory.SetLastWriteTime(text2, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastWriteTimeUtc:
								global::System.IO.Directory.SetLastWriteTimeUtc(text2, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTime:
								global::System.IO.Directory.SetCreationTime(text2, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.CreateTimeUtc:
								global::System.IO.Directory.SetCreationTimeUtc(text2, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTime:
								global::System.IO.Directory.SetLastAccessTime(text2, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.LastAccessTimeUtc:
								global::System.IO.Directory.SetLastAccessTimeUtc(text2, entry.DateTime);
								break;
							case global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory.TimeSetting.Fixed:
								global::System.IO.Directory.SetLastWriteTime(text2, this.entryFactory_.FixedDateTime);
								break;
							default:
								throw new global::ICSharpCode.SharpZipLib.Zip.ZipException("Unhandled time setting in ExtractEntry");
							}
						}
					}
					else
					{
						flag = false;
					}
				}
				catch (global::System.Exception e)
				{
					flag = false;
					if (this.events_ == null)
					{
						this.continueRunning_ = false;
						throw;
					}
					if (entry.IsDirectory)
					{
						this.continueRunning_ = this.events_.OnDirectoryFailure(text, e);
					}
					else
					{
						this.continueRunning_ = this.events_.OnFileFailure(text, e);
					}
				}
			}
			if (flag && entry.IsFile)
			{
				this.ExtractFileEntry(entry, text);
			}
		}

		// Token: 0x06000047 RID: 71 RVA: 0x00002ED0 File Offset: 0x000010D0
		private static int MakeExternalAttributes(global::System.IO.FileInfo info)
		{
			return (int)info.Attributes;
		}

		// Token: 0x06000048 RID: 72 RVA: 0x00002ED8 File Offset: 0x000010D8
		private static bool NameIsValid(string name)
		{
			return !string.IsNullOrEmpty(name) && name.IndexOfAny(global::System.IO.Path.GetInvalidPathChars()) < 0;
		}

		// Token: 0x0400000C RID: 12
		private bool continueRunning_;

		// Token: 0x0400000D RID: 13
		private byte[] buffer_;

		// Token: 0x0400000E RID: 14
		private global::ICSharpCode.SharpZipLib.Zip.ZipOutputStream outputStream_;

		// Token: 0x0400000F RID: 15
		private global::ICSharpCode.SharpZipLib.Zip.ZipFile zipFile_;

		// Token: 0x04000010 RID: 16
		private string sourceDirectory_;

		// Token: 0x04000011 RID: 17
		private global::ICSharpCode.SharpZipLib.Core.NameFilter fileFilter_;

		// Token: 0x04000012 RID: 18
		private global::ICSharpCode.SharpZipLib.Core.NameFilter directoryFilter_;

		// Token: 0x04000013 RID: 19
		private global::ICSharpCode.SharpZipLib.Zip.FastZip.Overwrite overwrite_;

		// Token: 0x04000014 RID: 20
		private global::ICSharpCode.SharpZipLib.Zip.FastZip.ConfirmOverwriteDelegate confirmDelegate_;

		// Token: 0x04000015 RID: 21
		private bool restoreDateTimeOnExtract_;

		// Token: 0x04000016 RID: 22
		private bool restoreAttributesOnExtract_;

		// Token: 0x04000017 RID: 23
		private bool createEmptyDirectories_;

		// Token: 0x04000018 RID: 24
		private global::ICSharpCode.SharpZipLib.Zip.FastZipEvents events_;

		// Token: 0x04000019 RID: 25
		private global::ICSharpCode.SharpZipLib.Zip.IEntryFactory entryFactory_ = new global::ICSharpCode.SharpZipLib.Zip.ZipEntryFactory();

		// Token: 0x0400001A RID: 26
		private global::ICSharpCode.SharpZipLib.Core.INameTransform extractNameTransform_;

		// Token: 0x0400001B RID: 27
		private global::ICSharpCode.SharpZipLib.Zip.UseZip64 useZip64_ = global::ICSharpCode.SharpZipLib.Zip.UseZip64.Dynamic;

		// Token: 0x0400001C RID: 28
		private global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater.CompressionLevel compressionLevel_ = global::ICSharpCode.SharpZipLib.Zip.Compression.Deflater.CompressionLevel.DEFAULT_COMPRESSION;

		// Token: 0x0400001D RID: 29
		private string password_;

		// Token: 0x0200007B RID: 123
		public enum Overwrite
		{
			// Token: 0x04000326 RID: 806
			Prompt,
			// Token: 0x04000327 RID: 807
			Never,
			// Token: 0x04000328 RID: 808
			Always
		}

		// Token: 0x0200007C RID: 124
		// (Invoke) Token: 0x06000516 RID: 1302
		public delegate bool ConfirmOverwriteDelegate(string fileName);
	}
}
