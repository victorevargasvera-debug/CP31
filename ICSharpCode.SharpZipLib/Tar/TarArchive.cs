using System;
using System.IO;
using System.Text;
using ICSharpCode.SharpZipLib.Core;

namespace ICSharpCode.SharpZipLib.Tar
{
	// Token: 0x02000044 RID: 68
	public class TarArchive : global::System.IDisposable
	{
		// Token: 0x14000002 RID: 2
		// (add) Token: 0x060002DE RID: 734 RVA: 0x0000E940 File Offset: 0x0000CB40
		// (remove) Token: 0x060002DF RID: 735 RVA: 0x0000E978 File Offset: 0x0000CB78
		public event global::ICSharpCode.SharpZipLib.Tar.ProgressMessageHandler ProgressMessageEvent;

		// Token: 0x060002E0 RID: 736 RVA: 0x0000E9B0 File Offset: 0x0000CBB0
		protected virtual void OnProgressMessageEvent(global::ICSharpCode.SharpZipLib.Tar.TarEntry entry, string message)
		{
			global::ICSharpCode.SharpZipLib.Tar.ProgressMessageHandler progressMessageEvent = this.ProgressMessageEvent;
			if (progressMessageEvent != null)
			{
				progressMessageEvent(this, entry, message);
			}
		}

		// Token: 0x060002E1 RID: 737 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		protected TarArchive()
		{
		}

		// Token: 0x060002E2 RID: 738 RVA: 0x0000E9EE File Offset: 0x0000CBEE
		protected TarArchive(global::ICSharpCode.SharpZipLib.Tar.TarInputStream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			this.tarIn = stream;
		}

		// Token: 0x060002E3 RID: 739 RVA: 0x0000EA21 File Offset: 0x0000CC21
		protected TarArchive(global::ICSharpCode.SharpZipLib.Tar.TarOutputStream stream)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			this.tarOut = stream;
		}

		// Token: 0x060002E4 RID: 740 RVA: 0x0000EA54 File Offset: 0x0000CC54
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(global::System.IO.Stream inputStream)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarArchive.CreateInputTarArchive(inputStream, null);
		}

		// Token: 0x060002E5 RID: 741 RVA: 0x0000EA60 File Offset: 0x0000CC60
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(global::System.IO.Stream inputStream, global::System.Text.Encoding nameEncoding)
		{
			if (inputStream == null)
			{
				throw new global::System.ArgumentNullException("inputStream");
			}
			global::ICSharpCode.SharpZipLib.Tar.TarInputStream tarInputStream = inputStream as global::ICSharpCode.SharpZipLib.Tar.TarInputStream;
			global::ICSharpCode.SharpZipLib.Tar.TarArchive result;
			if (tarInputStream != null)
			{
				result = new global::ICSharpCode.SharpZipLib.Tar.TarArchive(tarInputStream);
			}
			else
			{
				result = global::ICSharpCode.SharpZipLib.Tar.TarArchive.CreateInputTarArchive(inputStream, 20, nameEncoding);
			}
			return result;
		}

		// Token: 0x060002E6 RID: 742 RVA: 0x0000EA99 File Offset: 0x0000CC99
		[global::System.Obsolete("No Encoding for Name field is specified, any non-ASCII bytes will be discarded")]
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(global::System.IO.Stream inputStream, int blockFactor)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarArchive.CreateInputTarArchive(inputStream, blockFactor, null);
		}

		// Token: 0x060002E7 RID: 743 RVA: 0x0000EAA3 File Offset: 0x0000CCA3
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateInputTarArchive(global::System.IO.Stream inputStream, int blockFactor, global::System.Text.Encoding nameEncoding)
		{
			if (inputStream == null)
			{
				throw new global::System.ArgumentNullException("inputStream");
			}
			if (inputStream is global::ICSharpCode.SharpZipLib.Tar.TarInputStream)
			{
				throw new global::System.ArgumentException("TarInputStream not valid");
			}
			return new global::ICSharpCode.SharpZipLib.Tar.TarArchive(new global::ICSharpCode.SharpZipLib.Tar.TarInputStream(inputStream, blockFactor, nameEncoding));
		}

		// Token: 0x060002E8 RID: 744 RVA: 0x0000EAD4 File Offset: 0x0000CCD4
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(global::System.IO.Stream outputStream, global::System.Text.Encoding nameEncoding)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			global::ICSharpCode.SharpZipLib.Tar.TarOutputStream tarOutputStream = outputStream as global::ICSharpCode.SharpZipLib.Tar.TarOutputStream;
			global::ICSharpCode.SharpZipLib.Tar.TarArchive result;
			if (tarOutputStream != null)
			{
				result = new global::ICSharpCode.SharpZipLib.Tar.TarArchive(tarOutputStream);
			}
			else
			{
				result = global::ICSharpCode.SharpZipLib.Tar.TarArchive.CreateOutputTarArchive(outputStream, 20, nameEncoding);
			}
			return result;
		}

		// Token: 0x060002E9 RID: 745 RVA: 0x0000EB0D File Offset: 0x0000CD0D
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(global::System.IO.Stream outputStream)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarArchive.CreateOutputTarArchive(outputStream, null);
		}

		// Token: 0x060002EA RID: 746 RVA: 0x0000EB16 File Offset: 0x0000CD16
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(global::System.IO.Stream outputStream, int blockFactor)
		{
			return global::ICSharpCode.SharpZipLib.Tar.TarArchive.CreateOutputTarArchive(outputStream, blockFactor, null);
		}

		// Token: 0x060002EB RID: 747 RVA: 0x0000EB20 File Offset: 0x0000CD20
		public static global::ICSharpCode.SharpZipLib.Tar.TarArchive CreateOutputTarArchive(global::System.IO.Stream outputStream, int blockFactor, global::System.Text.Encoding nameEncoding)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			if (outputStream is global::ICSharpCode.SharpZipLib.Tar.TarOutputStream)
			{
				throw new global::System.ArgumentException("TarOutputStream is not valid");
			}
			return new global::ICSharpCode.SharpZipLib.Tar.TarArchive(new global::ICSharpCode.SharpZipLib.Tar.TarOutputStream(outputStream, blockFactor, nameEncoding));
		}

		// Token: 0x060002EC RID: 748 RVA: 0x0000EB50 File Offset: 0x0000CD50
		public void SetKeepOldFiles(bool keepExistingFiles)
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			this.keepOldFiles = keepExistingFiles;
		}

		// Token: 0x170000A6 RID: 166
		// (get) Token: 0x060002ED RID: 749 RVA: 0x0000EB6C File Offset: 0x0000CD6C
		// (set) Token: 0x060002EE RID: 750 RVA: 0x0000EB87 File Offset: 0x0000CD87
		public bool AsciiTranslate
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.asciiTranslate;
			}
			set
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				this.asciiTranslate = value;
			}
		}

		// Token: 0x060002EF RID: 751 RVA: 0x0000EBA3 File Offset: 0x0000CDA3
		[global::System.Obsolete("Use the AsciiTranslate property")]
		public void SetAsciiTranslation(bool translateAsciiFiles)
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			this.asciiTranslate = translateAsciiFiles;
		}

		// Token: 0x170000A7 RID: 167
		// (get) Token: 0x060002F0 RID: 752 RVA: 0x0000EBBF File Offset: 0x0000CDBF
		// (set) Token: 0x060002F1 RID: 753 RVA: 0x0000EBDA File Offset: 0x0000CDDA
		public string PathPrefix
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.pathPrefix;
			}
			set
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				this.pathPrefix = value;
			}
		}

		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060002F2 RID: 754 RVA: 0x0000EBF6 File Offset: 0x0000CDF6
		// (set) Token: 0x060002F3 RID: 755 RVA: 0x0000EC11 File Offset: 0x0000CE11
		public string RootPath
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.rootPath;
			}
			set
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				this.rootPath = value.Replace('\\', '/').TrimEnd(new char[]
				{
					'/'
				});
			}
		}

		// Token: 0x060002F4 RID: 756 RVA: 0x0000EC46 File Offset: 0x0000CE46
		public void SetUserInfo(int userId, string userName, int groupId, string groupName)
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			this.userId = userId;
			this.userName = userName;
			this.groupId = groupId;
			this.groupName = groupName;
			this.applyUserInfoOverrides = true;
		}

		// Token: 0x170000A9 RID: 169
		// (get) Token: 0x060002F5 RID: 757 RVA: 0x0000EC7F File Offset: 0x0000CE7F
		// (set) Token: 0x060002F6 RID: 758 RVA: 0x0000EC9A File Offset: 0x0000CE9A
		public bool ApplyUserInfoOverrides
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.applyUserInfoOverrides;
			}
			set
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				this.applyUserInfoOverrides = value;
			}
		}

		// Token: 0x170000AA RID: 170
		// (get) Token: 0x060002F7 RID: 759 RVA: 0x0000ECB6 File Offset: 0x0000CEB6
		public int UserId
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.userId;
			}
		}

		// Token: 0x170000AB RID: 171
		// (get) Token: 0x060002F8 RID: 760 RVA: 0x0000ECD1 File Offset: 0x0000CED1
		public string UserName
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.userName;
			}
		}

		// Token: 0x170000AC RID: 172
		// (get) Token: 0x060002F9 RID: 761 RVA: 0x0000ECEC File Offset: 0x0000CEEC
		public int GroupId
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.groupId;
			}
		}

		// Token: 0x170000AD RID: 173
		// (get) Token: 0x060002FA RID: 762 RVA: 0x0000ED07 File Offset: 0x0000CF07
		public string GroupName
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				return this.groupName;
			}
		}

		// Token: 0x170000AE RID: 174
		// (get) Token: 0x060002FB RID: 763 RVA: 0x0000ED24 File Offset: 0x0000CF24
		public int RecordSize
		{
			get
			{
				if (this.isDisposed)
				{
					throw new global::System.ObjectDisposedException("TarArchive");
				}
				if (this.tarIn != null)
				{
					return this.tarIn.RecordSize;
				}
				if (this.tarOut != null)
				{
					return this.tarOut.RecordSize;
				}
				return 10240;
			}
		}

		// Token: 0x170000AF RID: 175
		// (set) Token: 0x060002FC RID: 764 RVA: 0x0000ED71 File Offset: 0x0000CF71
		public bool IsStreamOwner
		{
			set
			{
				if (this.tarIn != null)
				{
					this.tarIn.IsStreamOwner = value;
					return;
				}
				this.tarOut.IsStreamOwner = value;
			}
		}

		// Token: 0x060002FD RID: 765 RVA: 0x0000ED94 File Offset: 0x0000CF94
		[global::System.Obsolete("Use Close instead")]
		public void CloseArchive()
		{
			this.Close();
		}

		// Token: 0x060002FE RID: 766 RVA: 0x0000ED9C File Offset: 0x0000CF9C
		public void ListContents()
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			for (;;)
			{
				global::ICSharpCode.SharpZipLib.Tar.TarEntry nextEntry = this.tarIn.GetNextEntry();
				if (nextEntry == null)
				{
					break;
				}
				this.OnProgressMessageEvent(nextEntry, null);
			}
		}

		// Token: 0x060002FF RID: 767 RVA: 0x0000EDD5 File Offset: 0x0000CFD5
		public void ExtractContents(string destinationDirectory)
		{
			this.ExtractContents(destinationDirectory, false);
		}

		// Token: 0x06000300 RID: 768 RVA: 0x0000EDE0 File Offset: 0x0000CFE0
		public void ExtractContents(string destinationDirectory, bool allowParentTraversal)
		{
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			string fullPath = global::System.IO.Path.GetFullPath(destinationDirectory);
			for (;;)
			{
				global::ICSharpCode.SharpZipLib.Tar.TarEntry nextEntry = this.tarIn.GetNextEntry();
				if (nextEntry == null)
				{
					break;
				}
				if (nextEntry.TarHeader.TypeFlag != 49 && nextEntry.TarHeader.TypeFlag != 50)
				{
					this.ExtractEntry(fullPath, nextEntry, allowParentTraversal);
				}
			}
		}

		// Token: 0x06000301 RID: 769 RVA: 0x0000EE40 File Offset: 0x0000D040
		private void ExtractEntry(string destDir, global::ICSharpCode.SharpZipLib.Tar.TarEntry entry, bool allowParentTraversal)
		{
			this.OnProgressMessageEvent(entry, null);
			string text = entry.Name;
			if (global::System.IO.Path.IsPathRooted(text))
			{
				text = text.Substring(global::System.IO.Path.GetPathRoot(text).Length);
			}
			text = text.Replace('/', global::System.IO.Path.DirectorySeparatorChar);
			string text2 = global::System.IO.Path.Combine(destDir, text);
			string text3 = global::System.IO.Path.GetDirectoryName(global::System.IO.Path.GetFullPath(text2)) ?? "";
			if (!allowParentTraversal && !text3.StartsWith(destDir, global::System.StringComparison.InvariantCultureIgnoreCase))
			{
				throw new global::ICSharpCode.SharpZipLib.Core.InvalidNameException("Parent traversal in paths is not allowed");
			}
			if (entry.IsDirectory)
			{
				global::ICSharpCode.SharpZipLib.Tar.TarArchive.EnsureDirectoryExists(text2);
				return;
			}
			global::ICSharpCode.SharpZipLib.Tar.TarArchive.EnsureDirectoryExists(global::System.IO.Path.GetDirectoryName(text2));
			bool flag = true;
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(text2);
			if (fileInfo.Exists)
			{
				if (this.keepOldFiles)
				{
					this.OnProgressMessageEvent(entry, "Destination file already exists");
					flag = false;
				}
				else if ((fileInfo.Attributes & global::System.IO.FileAttributes.ReadOnly) != (global::System.IO.FileAttributes)0)
				{
					this.OnProgressMessageEvent(entry, "Destination file already exists, and is read-only");
					flag = false;
				}
			}
			if (flag)
			{
				using (global::System.IO.FileStream fileStream = global::System.IO.File.Create(text2))
				{
					if (this.asciiTranslate)
					{
						this.ExtractAndTranslateEntry(text2, fileStream);
					}
					else
					{
						this.tarIn.CopyEntryContents(fileStream);
					}
				}
			}
		}

		// Token: 0x06000302 RID: 770 RVA: 0x0000EF60 File Offset: 0x0000D160
		private void ExtractAndTranslateEntry(string destFile, global::System.IO.Stream outputStream)
		{
			if (!global::ICSharpCode.SharpZipLib.Tar.TarArchive.IsBinary(destFile))
			{
				using (global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(outputStream, new global::System.Text.UTF8Encoding(false), 1024, true))
				{
					byte[] array = new byte[32768];
					for (;;)
					{
						int num = this.tarIn.Read(array, 0, array.Length);
						if (num <= 0)
						{
							break;
						}
						int num2 = 0;
						for (int i = 0; i < num; i++)
						{
							if (array[i] == 10)
							{
								string @string = global::System.Text.Encoding.ASCII.GetString(array, num2, i - num2);
								streamWriter.WriteLine(@string);
								num2 = i + 1;
							}
						}
					}
					return;
				}
			}
			this.tarIn.CopyEntryContents(outputStream);
		}

		// Token: 0x06000303 RID: 771 RVA: 0x0000F010 File Offset: 0x0000D210
		public void WriteEntry(global::ICSharpCode.SharpZipLib.Tar.TarEntry sourceEntry, bool recurse)
		{
			if (sourceEntry == null)
			{
				throw new global::System.ArgumentNullException("sourceEntry");
			}
			if (this.isDisposed)
			{
				throw new global::System.ObjectDisposedException("TarArchive");
			}
			try
			{
				if (recurse)
				{
					global::ICSharpCode.SharpZipLib.Tar.TarHeader.SetValueDefaults(sourceEntry.UserId, sourceEntry.UserName, sourceEntry.GroupId, sourceEntry.GroupName);
				}
				this.WriteEntryCore(sourceEntry, recurse);
			}
			finally
			{
				if (recurse)
				{
					global::ICSharpCode.SharpZipLib.Tar.TarHeader.RestoreSetValues();
				}
			}
		}

		// Token: 0x06000304 RID: 772 RVA: 0x0000F084 File Offset: 0x0000D284
		private void WriteEntryCore(global::ICSharpCode.SharpZipLib.Tar.TarEntry sourceEntry, bool recurse)
		{
			string text = null;
			string text2 = sourceEntry.File;
			global::ICSharpCode.SharpZipLib.Tar.TarEntry tarEntry = (global::ICSharpCode.SharpZipLib.Tar.TarEntry)sourceEntry.Clone();
			if (this.applyUserInfoOverrides)
			{
				tarEntry.GroupId = this.groupId;
				tarEntry.GroupName = this.groupName;
				tarEntry.UserId = this.userId;
				tarEntry.UserName = this.userName;
			}
			this.OnProgressMessageEvent(tarEntry, null);
			if (this.asciiTranslate && !tarEntry.IsDirectory && !global::ICSharpCode.SharpZipLib.Tar.TarArchive.IsBinary(text2))
			{
				text = global::ICSharpCode.SharpZipLib.Core.PathUtils.GetTempFileName(null);
				using (global::System.IO.StreamReader streamReader = global::System.IO.File.OpenText(text2))
				{
					using (global::System.IO.Stream stream = global::System.IO.File.Create(text))
					{
						for (;;)
						{
							string text3 = streamReader.ReadLine();
							if (text3 == null)
							{
								break;
							}
							byte[] bytes = global::System.Text.Encoding.ASCII.GetBytes(text3);
							stream.Write(bytes, 0, bytes.Length);
							stream.WriteByte(10);
						}
						stream.Flush();
					}
				}
				tarEntry.Size = new global::System.IO.FileInfo(text).Length;
				text2 = text;
			}
			string text4 = null;
			if (!string.IsNullOrEmpty(this.rootPath) && tarEntry.Name.StartsWith(this.rootPath, global::System.StringComparison.OrdinalIgnoreCase))
			{
				text4 = tarEntry.Name.Substring(this.rootPath.Length + 1);
			}
			if (this.pathPrefix != null)
			{
				text4 = ((text4 == null) ? (this.pathPrefix + "/" + tarEntry.Name) : (this.pathPrefix + "/" + text4));
			}
			if (text4 != null)
			{
				tarEntry.Name = text4;
			}
			this.tarOut.PutNextEntry(tarEntry);
			if (tarEntry.IsDirectory)
			{
				if (recurse)
				{
					global::ICSharpCode.SharpZipLib.Tar.TarEntry[] directoryEntries = tarEntry.GetDirectoryEntries();
					for (int i = 0; i < directoryEntries.Length; i++)
					{
						this.WriteEntryCore(directoryEntries[i], recurse);
					}
					return;
				}
			}
			else
			{
				using (global::System.IO.Stream stream2 = global::System.IO.File.OpenRead(text2))
				{
					byte[] array = new byte[32768];
					for (;;)
					{
						int num = stream2.Read(array, 0, array.Length);
						if (num <= 0)
						{
							break;
						}
						this.tarOut.Write(array, 0, num);
					}
				}
				if (!string.IsNullOrEmpty(text))
				{
					global::System.IO.File.Delete(text);
				}
				this.tarOut.CloseEntry();
			}
		}

		// Token: 0x06000305 RID: 773 RVA: 0x0000F2CC File Offset: 0x0000D4CC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000306 RID: 774 RVA: 0x0000F2DC File Offset: 0x0000D4DC
		protected virtual void Dispose(bool disposing)
		{
			if (!this.isDisposed)
			{
				this.isDisposed = true;
				if (disposing)
				{
					if (this.tarOut != null)
					{
						this.tarOut.Flush();
						this.tarOut.Dispose();
					}
					if (this.tarIn != null)
					{
						this.tarIn.Dispose();
					}
				}
			}
		}

		// Token: 0x06000307 RID: 775 RVA: 0x0000F32C File Offset: 0x0000D52C
		public virtual void Close()
		{
			this.Dispose(true);
		}

		// Token: 0x06000308 RID: 776 RVA: 0x0000F338 File Offset: 0x0000D538
		~TarArchive()
		{
			this.Dispose(false);
		}

		// Token: 0x06000309 RID: 777 RVA: 0x0000F368 File Offset: 0x0000D568
		private static void EnsureDirectoryExists(string directoryName)
		{
			if (!global::System.IO.Directory.Exists(directoryName))
			{
				try
				{
					global::System.IO.Directory.CreateDirectory(directoryName);
				}
				catch (global::System.Exception ex)
				{
					throw new global::ICSharpCode.SharpZipLib.Tar.TarException("Exception creating directory '" + directoryName + "', " + ex.Message, ex);
				}
			}
		}

		// Token: 0x0600030A RID: 778 RVA: 0x0000F3B4 File Offset: 0x0000D5B4
		private static bool IsBinary(string filename)
		{
			using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenRead(filename))
			{
				int num = global::System.Math.Min(4096, (int)fileStream.Length);
				byte[] array = new byte[num];
				int num2 = fileStream.Read(array, 0, num);
				for (int i = 0; i < num2; i++)
				{
					byte b = array[i];
					if (b < 8 || (b > 13 && b < 32) || b == 255)
					{
						return true;
					}
				}
			}
			return false;
		}

		// Token: 0x040001C8 RID: 456
		private bool keepOldFiles;

		// Token: 0x040001C9 RID: 457
		private bool asciiTranslate;

		// Token: 0x040001CA RID: 458
		private int userId;

		// Token: 0x040001CB RID: 459
		private string userName = string.Empty;

		// Token: 0x040001CC RID: 460
		private int groupId;

		// Token: 0x040001CD RID: 461
		private string groupName = string.Empty;

		// Token: 0x040001CE RID: 462
		private string rootPath;

		// Token: 0x040001CF RID: 463
		private string pathPrefix;

		// Token: 0x040001D0 RID: 464
		private bool applyUserInfoOverrides;

		// Token: 0x040001D1 RID: 465
		private global::ICSharpCode.SharpZipLib.Tar.TarInputStream tarIn;

		// Token: 0x040001D2 RID: 466
		private global::ICSharpCode.SharpZipLib.Tar.TarOutputStream tarOut;

		// Token: 0x040001D3 RID: 467
		private bool isDisposed;
	}
}
