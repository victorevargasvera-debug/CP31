using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using Ionic.Zlib;
using Microsoft.CSharp;

namespace Ionic.Zip
{
	// Token: 0x0200046B RID: 1131
	[global::System.Runtime.InteropServices.Guid("ebc25cf6-9120-4283-b972-0e5520d00005")]
	[global::System.Runtime.InteropServices.ComVisible(true)]
	[global::System.Runtime.InteropServices.ClassInterface(global::System.Runtime.InteropServices.ClassInterfaceType.AutoDispatch)]
	internal class ZipFile : global::System.Collections.IEnumerable, global::System.Collections.Generic.IEnumerable<global::Ionic.Zip.ZipEntry>, global::System.IDisposable
	{
		// Token: 0x0600310B RID: 12555 RVA: 0x000B1FBC File Offset: 0x000B01BC
		public global::Ionic.Zip.ZipEntry AddItem(string fileOrDirectoryName)
		{
			return this.AddItem(fileOrDirectoryName, null);
		}

		// Token: 0x0600310C RID: 12556 RVA: 0x000B1FC8 File Offset: 0x000B01C8
		public global::Ionic.Zip.ZipEntry AddItem(string fileOrDirectoryName, string directoryPathInArchive)
		{
			if (global::System.IO.File.Exists(fileOrDirectoryName))
			{
				return this.AddFile(fileOrDirectoryName, directoryPathInArchive);
			}
			if (global::System.IO.Directory.Exists(fileOrDirectoryName))
			{
				return this.AddDirectory(fileOrDirectoryName, directoryPathInArchive);
			}
			throw new global::System.IO.FileNotFoundException(string.Format("That file or directory ({0}) does not exist!", fileOrDirectoryName));
		}

		// Token: 0x0600310D RID: 12557 RVA: 0x000B2004 File Offset: 0x000B0204
		public global::Ionic.Zip.ZipEntry AddFile(string fileName)
		{
			return this.AddFile(fileName, null);
		}

		// Token: 0x0600310E RID: 12558 RVA: 0x000B2010 File Offset: 0x000B0210
		public global::Ionic.Zip.ZipEntry AddFile(string fileName, string directoryPathInArchive)
		{
			string nameInArchive = global::Ionic.Zip.ZipEntry.NameInArchive(fileName, directoryPathInArchive);
			global::Ionic.Zip.ZipEntry ze = global::Ionic.Zip.ZipEntry.CreateFromFile(fileName, nameInArchive);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding {0}...", fileName);
			}
			return this._InternalAddEntry(ze);
		}

		// Token: 0x0600310F RID: 12559 RVA: 0x000B2054 File Offset: 0x000B0254
		public void RemoveEntries(global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> entriesToRemove)
		{
			if (entriesToRemove == null)
			{
				throw new global::System.ArgumentNullException("entriesToRemove");
			}
			foreach (global::Ionic.Zip.ZipEntry entry in entriesToRemove)
			{
				this.RemoveEntry(entry);
			}
		}

		// Token: 0x06003110 RID: 12560 RVA: 0x000B20B8 File Offset: 0x000B02B8
		public void RemoveEntries(global::System.Collections.Generic.ICollection<string> entriesToRemove)
		{
			if (entriesToRemove == null)
			{
				throw new global::System.ArgumentNullException("entriesToRemove");
			}
			foreach (string fileName in entriesToRemove)
			{
				this.RemoveEntry(fileName);
			}
		}

		// Token: 0x06003111 RID: 12561 RVA: 0x000B211C File Offset: 0x000B031C
		public void AddFiles(global::System.Collections.Generic.IEnumerable<string> fileNames)
		{
			this.AddFiles(fileNames, null);
		}

		// Token: 0x06003112 RID: 12562 RVA: 0x000B2128 File Offset: 0x000B0328
		public void UpdateFiles(global::System.Collections.Generic.IEnumerable<string> fileNames)
		{
			this.UpdateFiles(fileNames, null);
		}

		// Token: 0x06003113 RID: 12563 RVA: 0x000B2134 File Offset: 0x000B0334
		public void AddFiles(global::System.Collections.Generic.IEnumerable<string> fileNames, string directoryPathInArchive)
		{
			this.AddFiles(fileNames, false, directoryPathInArchive);
		}

		// Token: 0x06003114 RID: 12564 RVA: 0x000B2140 File Offset: 0x000B0340
		public void AddFiles(global::System.Collections.Generic.IEnumerable<string> fileNames, bool preserveDirHierarchy, string directoryPathInArchive)
		{
			if (fileNames == null)
			{
				throw new global::System.ArgumentNullException("fileNames");
			}
			this._addOperationCanceled = false;
			this.OnAddStarted();
			if (preserveDirHierarchy)
			{
				using (global::System.Collections.Generic.IEnumerator<string> enumerator = fileNames.GetEnumerator())
				{
					while (enumerator.MoveNext())
					{
						string text = enumerator.Current;
						if (this._addOperationCanceled)
						{
							break;
						}
						if (directoryPathInArchive != null)
						{
							string fullPath = global::System.IO.Path.GetFullPath(global::System.IO.Path.Combine(directoryPathInArchive, global::System.IO.Path.GetDirectoryName(text)));
							this.AddFile(text, fullPath);
						}
						else
						{
							this.AddFile(text, null);
						}
					}
					goto IL_D6;
				}
			}
			foreach (string fileName in fileNames)
			{
				if (this._addOperationCanceled)
				{
					break;
				}
				this.AddFile(fileName, directoryPathInArchive);
			}
			IL_D6:
			if (!this._addOperationCanceled)
			{
				this.OnAddCompleted();
			}
		}

		// Token: 0x06003115 RID: 12565 RVA: 0x000B2250 File Offset: 0x000B0450
		public void UpdateFiles(global::System.Collections.Generic.IEnumerable<string> fileNames, string directoryPathInArchive)
		{
			if (fileNames == null)
			{
				throw new global::System.ArgumentNullException("fileNames");
			}
			this.OnAddStarted();
			foreach (string fileName in fileNames)
			{
				this.UpdateFile(fileName, directoryPathInArchive);
			}
			this.OnAddCompleted();
		}

		// Token: 0x06003116 RID: 12566 RVA: 0x000B22C0 File Offset: 0x000B04C0
		public global::Ionic.Zip.ZipEntry UpdateFile(string fileName)
		{
			return this.UpdateFile(fileName, null);
		}

		// Token: 0x06003117 RID: 12567 RVA: 0x000B22CC File Offset: 0x000B04CC
		public global::Ionic.Zip.ZipEntry UpdateFile(string fileName, string directoryPathInArchive)
		{
			string fileName2 = global::Ionic.Zip.ZipEntry.NameInArchive(fileName, directoryPathInArchive);
			if (this[fileName2] != null)
			{
				this.RemoveEntry(fileName2);
			}
			return this.AddFile(fileName, directoryPathInArchive);
		}

		// Token: 0x06003118 RID: 12568 RVA: 0x000B2300 File Offset: 0x000B0500
		public global::Ionic.Zip.ZipEntry UpdateDirectory(string directoryName)
		{
			return this.UpdateDirectory(directoryName, null);
		}

		// Token: 0x06003119 RID: 12569 RVA: 0x000B230C File Offset: 0x000B050C
		public global::Ionic.Zip.ZipEntry UpdateDirectory(string directoryName, string directoryPathInArchive)
		{
			return this.AddOrUpdateDirectoryImpl(directoryName, directoryPathInArchive, global::Ionic.Zip.AddOrUpdateAction.AddOrUpdate);
		}

		// Token: 0x0600311A RID: 12570 RVA: 0x000B2318 File Offset: 0x000B0518
		public void UpdateItem(string itemName)
		{
			this.UpdateItem(itemName, null);
		}

		// Token: 0x0600311B RID: 12571 RVA: 0x000B2324 File Offset: 0x000B0524
		public void UpdateItem(string itemName, string directoryPathInArchive)
		{
			if (global::System.IO.File.Exists(itemName))
			{
				this.UpdateFile(itemName, directoryPathInArchive);
				return;
			}
			if (global::System.IO.Directory.Exists(itemName))
			{
				this.UpdateDirectory(itemName, directoryPathInArchive);
				return;
			}
			throw new global::System.IO.FileNotFoundException(string.Format("That file or directory ({0}) does not exist!", itemName));
		}

		// Token: 0x0600311C RID: 12572 RVA: 0x000B2360 File Offset: 0x000B0560
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, string content)
		{
			return this.AddEntry(entryName, content, global::System.Text.Encoding.Default);
		}

		// Token: 0x0600311D RID: 12573 RVA: 0x000B2370 File Offset: 0x000B0570
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, string content, global::System.Text.Encoding encoding)
		{
			global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream();
			global::System.IO.StreamWriter streamWriter = new global::System.IO.StreamWriter(memoryStream, encoding);
			streamWriter.Write(content);
			streamWriter.Flush();
			memoryStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
			return this.AddEntry(entryName, memoryStream);
		}

		// Token: 0x0600311E RID: 12574 RVA: 0x000B23AC File Offset: 0x000B05AC
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, global::System.IO.Stream stream)
		{
			global::Ionic.Zip.ZipEntry zipEntry = global::Ionic.Zip.ZipEntry.CreateForStream(entryName, stream);
			zipEntry.SetEntryTimes(global::System.DateTime.Now, global::System.DateTime.Now, global::System.DateTime.Now);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding {0}...", entryName);
			}
			return this._InternalAddEntry(zipEntry);
		}

		// Token: 0x0600311F RID: 12575 RVA: 0x000B2400 File Offset: 0x000B0600
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, global::Ionic.Zip.WriteDelegate writer)
		{
			global::Ionic.Zip.ZipEntry ze = global::Ionic.Zip.ZipEntry.CreateForWriter(entryName, writer);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding {0}...", entryName);
			}
			return this._InternalAddEntry(ze);
		}

		// Token: 0x06003120 RID: 12576 RVA: 0x000B243C File Offset: 0x000B063C
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, global::Ionic.Zip.OpenDelegate opener, global::Ionic.Zip.CloseDelegate closer)
		{
			global::Ionic.Zip.ZipEntry zipEntry = global::Ionic.Zip.ZipEntry.CreateForJitStreamProvider(entryName, opener, closer);
			zipEntry.SetEntryTimes(global::System.DateTime.Now, global::System.DateTime.Now, global::System.DateTime.Now);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding {0}...", entryName);
			}
			return this._InternalAddEntry(zipEntry);
		}

		// Token: 0x06003121 RID: 12577 RVA: 0x000B2490 File Offset: 0x000B0690
		private global::Ionic.Zip.ZipEntry _InternalAddEntry(global::Ionic.Zip.ZipEntry ze)
		{
			ze._container = new global::Ionic.Zip.ZipContainer(this);
			ze.CompressionMethod = this.CompressionMethod;
			ze.CompressionLevel = this.CompressionLevel;
			ze.ExtractExistingFile = this.ExtractExistingFile;
			ze.ZipErrorAction = this.ZipErrorAction;
			ze.SetCompression = this.SetCompression;
			ze.AlternateEncoding = this.AlternateEncoding;
			ze.AlternateEncodingUsage = this.AlternateEncodingUsage;
			ze.Password = this._Password;
			ze.Encryption = this.Encryption;
			ze.EmitTimesInWindowsFormatWhenSaving = this._emitNtfsTimes;
			ze.EmitTimesInUnixFormatWhenSaving = this._emitUnixTimes;
			this.InternalAddEntry(ze.FileName, ze);
			this.AfterAddEntry(ze);
			return ze;
		}

		// Token: 0x06003122 RID: 12578 RVA: 0x000B2548 File Offset: 0x000B0748
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, string content)
		{
			return this.UpdateEntry(entryName, content, global::System.Text.Encoding.Default);
		}

		// Token: 0x06003123 RID: 12579 RVA: 0x000B2558 File Offset: 0x000B0758
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, string content, global::System.Text.Encoding encoding)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, content, encoding);
		}

		// Token: 0x06003124 RID: 12580 RVA: 0x000B256C File Offset: 0x000B076C
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, global::Ionic.Zip.WriteDelegate writer)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, writer);
		}

		// Token: 0x06003125 RID: 12581 RVA: 0x000B2580 File Offset: 0x000B0780
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, global::Ionic.Zip.OpenDelegate opener, global::Ionic.Zip.CloseDelegate closer)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, opener, closer);
		}

		// Token: 0x06003126 RID: 12582 RVA: 0x000B2594 File Offset: 0x000B0794
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, global::System.IO.Stream stream)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, stream);
		}

		// Token: 0x06003127 RID: 12583 RVA: 0x000B25A8 File Offset: 0x000B07A8
		private void RemoveEntryForUpdate(string entryName)
		{
			if (string.IsNullOrEmpty(entryName))
			{
				throw new global::System.ArgumentNullException("entryName");
			}
			string directoryPathInArchive = null;
			if (entryName.IndexOf('\\') != -1)
			{
				directoryPathInArchive = global::System.IO.Path.GetDirectoryName(entryName);
				entryName = global::System.IO.Path.GetFileName(entryName);
			}
			string fileName = global::Ionic.Zip.ZipEntry.NameInArchive(entryName, directoryPathInArchive);
			if (this[fileName] != null)
			{
				this.RemoveEntry(fileName);
			}
		}

		// Token: 0x06003128 RID: 12584 RVA: 0x000B260C File Offset: 0x000B080C
		public global::Ionic.Zip.ZipEntry AddEntry(string entryName, byte[] byteContent)
		{
			if (byteContent == null)
			{
				throw new global::System.ArgumentException("bad argument", "byteContent");
			}
			global::System.IO.MemoryStream stream = new global::System.IO.MemoryStream(byteContent);
			return this.AddEntry(entryName, stream);
		}

		// Token: 0x06003129 RID: 12585 RVA: 0x000B2644 File Offset: 0x000B0844
		public global::Ionic.Zip.ZipEntry UpdateEntry(string entryName, byte[] byteContent)
		{
			this.RemoveEntryForUpdate(entryName);
			return this.AddEntry(entryName, byteContent);
		}

		// Token: 0x0600312A RID: 12586 RVA: 0x000B2658 File Offset: 0x000B0858
		public global::Ionic.Zip.ZipEntry AddDirectory(string directoryName)
		{
			return this.AddDirectory(directoryName, null);
		}

		// Token: 0x0600312B RID: 12587 RVA: 0x000B2664 File Offset: 0x000B0864
		public global::Ionic.Zip.ZipEntry AddDirectory(string directoryName, string directoryPathInArchive)
		{
			return this.AddOrUpdateDirectoryImpl(directoryName, directoryPathInArchive, global::Ionic.Zip.AddOrUpdateAction.AddOnly);
		}

		// Token: 0x0600312C RID: 12588 RVA: 0x000B2670 File Offset: 0x000B0870
		public global::Ionic.Zip.ZipEntry AddDirectoryByName(string directoryNameInArchive)
		{
			global::Ionic.Zip.ZipEntry zipEntry = global::Ionic.Zip.ZipEntry.CreateFromNothing(directoryNameInArchive);
			zipEntry._container = new global::Ionic.Zip.ZipContainer(this);
			zipEntry.MarkAsDirectory();
			zipEntry.AlternateEncoding = this.AlternateEncoding;
			zipEntry.AlternateEncodingUsage = this.AlternateEncodingUsage;
			zipEntry.SetEntryTimes(global::System.DateTime.Now, global::System.DateTime.Now, global::System.DateTime.Now);
			zipEntry.EmitTimesInWindowsFormatWhenSaving = this._emitNtfsTimes;
			zipEntry.EmitTimesInUnixFormatWhenSaving = this._emitUnixTimes;
			zipEntry._Source = global::Ionic.Zip.ZipEntrySource.Stream;
			this.InternalAddEntry(zipEntry.FileName, zipEntry);
			this.AfterAddEntry(zipEntry);
			return zipEntry;
		}

		// Token: 0x0600312D RID: 12589 RVA: 0x000B26FC File Offset: 0x000B08FC
		private global::Ionic.Zip.ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, global::Ionic.Zip.AddOrUpdateAction action)
		{
			if (rootDirectoryPathInArchive == null)
			{
				rootDirectoryPathInArchive = "";
			}
			return this.AddOrUpdateDirectoryImpl(directoryName, rootDirectoryPathInArchive, action, true, 0);
		}

		// Token: 0x0600312E RID: 12590 RVA: 0x000B2718 File Offset: 0x000B0918
		internal void InternalAddEntry(string name, global::Ionic.Zip.ZipEntry entry)
		{
			this._entries.Add(name, entry);
			this._zipEntriesAsList = null;
			this._contentsChanged = true;
		}

		// Token: 0x0600312F RID: 12591 RVA: 0x000B2738 File Offset: 0x000B0938
		private global::Ionic.Zip.ZipEntry AddOrUpdateDirectoryImpl(string directoryName, string rootDirectoryPathInArchive, global::Ionic.Zip.AddOrUpdateAction action, bool recurse, int level)
		{
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("{0} {1}...", (action == global::Ionic.Zip.AddOrUpdateAction.AddOnly) ? "adding" : "Adding or updating", directoryName);
			}
			if (level == 0)
			{
				this._addOperationCanceled = false;
				this.OnAddStarted();
			}
			if (this._addOperationCanceled)
			{
				return null;
			}
			string text = rootDirectoryPathInArchive;
			global::Ionic.Zip.ZipEntry zipEntry = null;
			if (level > 0)
			{
				int num = directoryName.Length;
				for (int i = level; i > 0; i--)
				{
					num = directoryName.LastIndexOfAny("/\\".ToCharArray(), num - 1, num - 1);
				}
				text = directoryName.Substring(num + 1);
				text = global::System.IO.Path.Combine(rootDirectoryPathInArchive, text);
			}
			if (level > 0 || rootDirectoryPathInArchive != "")
			{
				zipEntry = global::Ionic.Zip.ZipEntry.CreateFromFile(directoryName, text);
				zipEntry._container = new global::Ionic.Zip.ZipContainer(this);
				zipEntry.AlternateEncoding = this.AlternateEncoding;
				zipEntry.AlternateEncodingUsage = this.AlternateEncodingUsage;
				zipEntry.MarkAsDirectory();
				zipEntry.EmitTimesInWindowsFormatWhenSaving = this._emitNtfsTimes;
				zipEntry.EmitTimesInUnixFormatWhenSaving = this._emitUnixTimes;
				if (!this._entries.ContainsKey(zipEntry.FileName))
				{
					this.InternalAddEntry(zipEntry.FileName, zipEntry);
					this.AfterAddEntry(zipEntry);
				}
				text = zipEntry.FileName;
			}
			if (!this._addOperationCanceled)
			{
				string[] files = global::System.IO.Directory.GetFiles(directoryName);
				if (recurse)
				{
					foreach (string fileName in files)
					{
						if (this._addOperationCanceled)
						{
							break;
						}
						if (action == global::Ionic.Zip.AddOrUpdateAction.AddOnly)
						{
							this.AddFile(fileName, text);
						}
						else
						{
							this.UpdateFile(fileName, text);
						}
					}
					if (!this._addOperationCanceled)
					{
						foreach (string text2 in global::System.IO.Directory.GetDirectories(directoryName))
						{
							global::System.IO.FileAttributes attributes = global::System.IO.File.GetAttributes(text2);
							if (this.AddDirectoryWillTraverseReparsePoints || (attributes & global::System.IO.FileAttributes.ReparsePoint) == (global::System.IO.FileAttributes)0)
							{
								this.AddOrUpdateDirectoryImpl(text2, rootDirectoryPathInArchive, action, recurse, level + 1);
							}
						}
					}
				}
			}
			if (level == 0)
			{
				this.OnAddCompleted();
			}
			return zipEntry;
		}

		// Token: 0x06003130 RID: 12592 RVA: 0x000B2958 File Offset: 0x000B0B58
		public static bool CheckZip(string zipFileName)
		{
			return global::Ionic.Zip.ZipFile.CheckZip(zipFileName, false, null);
		}

		// Token: 0x06003131 RID: 12593 RVA: 0x000B2964 File Offset: 0x000B0B64
		public static bool CheckZip(string zipFileName, bool fixIfNecessary, global::System.IO.TextWriter writer)
		{
			global::Ionic.Zip.ZipFile zipFile = null;
			global::Ionic.Zip.ZipFile zipFile2 = null;
			bool flag = true;
			try
			{
				zipFile = new global::Ionic.Zip.ZipFile();
				zipFile.FullScan = true;
				zipFile.Initialize(zipFileName);
				zipFile2 = global::Ionic.Zip.ZipFile.Read(zipFileName);
				foreach (global::Ionic.Zip.ZipEntry zipEntry in zipFile)
				{
					foreach (global::Ionic.Zip.ZipEntry zipEntry2 in zipFile2)
					{
						if (zipEntry.FileName == zipEntry2.FileName)
						{
							if (zipEntry._RelativeOffsetOfLocalHeader != zipEntry2._RelativeOffsetOfLocalHeader)
							{
								flag = false;
								if (writer != null)
								{
									writer.WriteLine("{0}: mismatch in RelativeOffsetOfLocalHeader  (0x{1:X16} != 0x{2:X16})", zipEntry.FileName, zipEntry._RelativeOffsetOfLocalHeader, zipEntry2._RelativeOffsetOfLocalHeader);
								}
							}
							if (zipEntry._CompressedSize != zipEntry2._CompressedSize)
							{
								flag = false;
								if (writer != null)
								{
									writer.WriteLine("{0}: mismatch in CompressedSize  (0x{1:X16} != 0x{2:X16})", zipEntry.FileName, zipEntry._CompressedSize, zipEntry2._CompressedSize);
								}
							}
							if (zipEntry._UncompressedSize != zipEntry2._UncompressedSize)
							{
								flag = false;
								if (writer != null)
								{
									writer.WriteLine("{0}: mismatch in UncompressedSize  (0x{1:X16} != 0x{2:X16})", zipEntry.FileName, zipEntry._UncompressedSize, zipEntry2._UncompressedSize);
								}
							}
							if (zipEntry.CompressionMethod != zipEntry2.CompressionMethod)
							{
								flag = false;
								if (writer != null)
								{
									writer.WriteLine("{0}: mismatch in CompressionMethod  (0x{1:X4} != 0x{2:X4})", zipEntry.FileName, zipEntry.CompressionMethod, zipEntry2.CompressionMethod);
								}
							}
							if (zipEntry.Crc == zipEntry2.Crc)
							{
								break;
							}
							flag = false;
							if (writer != null)
							{
								writer.WriteLine("{0}: mismatch in Crc32  (0x{1:X4} != 0x{2:X4})", zipEntry.FileName, zipEntry.Crc, zipEntry2.Crc);
								break;
							}
							break;
						}
					}
				}
				zipFile2.Dispose();
				zipFile2 = null;
				if (!flag && fixIfNecessary)
				{
					string text = global::System.IO.Path.GetFileNameWithoutExtension(zipFileName);
					text = string.Format("{0}_fixed.zip", text);
					zipFile.Save(text);
				}
			}
			finally
			{
				if (zipFile != null)
				{
					zipFile.Dispose();
				}
				if (zipFile2 != null)
				{
					zipFile2.Dispose();
				}
			}
			return flag;
		}

		// Token: 0x06003132 RID: 12594 RVA: 0x000B2C0C File Offset: 0x000B0E0C
		public static void FixZipDirectory(string zipFileName)
		{
			using (global::Ionic.Zip.ZipFile zipFile = new global::Ionic.Zip.ZipFile())
			{
				zipFile.FullScan = true;
				zipFile.Initialize(zipFileName);
				zipFile.Save(zipFileName);
			}
		}

		// Token: 0x06003133 RID: 12595 RVA: 0x000B2C58 File Offset: 0x000B0E58
		public static bool CheckZipPassword(string zipFileName, string password)
		{
			bool result = false;
			try
			{
				using (global::Ionic.Zip.ZipFile zipFile = global::Ionic.Zip.ZipFile.Read(zipFileName))
				{
					foreach (global::Ionic.Zip.ZipEntry zipEntry in zipFile)
					{
						if (!zipEntry.IsDirectory && zipEntry.UsesEncryption)
						{
							zipEntry.ExtractWithPassword(global::System.IO.Stream.Null, password);
						}
					}
				}
				result = true;
			}
			catch (global::Ionic.Zip.BadPasswordException)
			{
			}
			return result;
		}

		// Token: 0x17000E0D RID: 3597
		// (get) Token: 0x06003134 RID: 12596 RVA: 0x000B2D08 File Offset: 0x000B0F08
		public string Info
		{
			get
			{
				global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
				stringBuilder.Append(string.Format("          ZipFile: {0}\n", this.Name));
				if (!string.IsNullOrEmpty(this._Comment))
				{
					stringBuilder.Append(string.Format("          Comment: {0}\n", this._Comment));
				}
				if (this._versionMadeBy != 0)
				{
					stringBuilder.Append(string.Format("  version made by: 0x{0:X4}\n", this._versionMadeBy));
				}
				if (this._versionNeededToExtract != 0)
				{
					stringBuilder.Append(string.Format("needed to extract: 0x{0:X4}\n", this._versionNeededToExtract));
				}
				stringBuilder.Append(string.Format("       uses ZIP64: {0}\n", this.InputUsesZip64));
				stringBuilder.Append(string.Format("     disk with CD: {0}\n", this._diskNumberWithCd));
				if (this._OffsetOfCentralDirectory == 4294967295U)
				{
					stringBuilder.Append(string.Format("      CD64 offset: 0x{0:X16}\n", this._OffsetOfCentralDirectory64));
				}
				else
				{
					stringBuilder.Append(string.Format("        CD offset: 0x{0:X8}\n", this._OffsetOfCentralDirectory));
				}
				stringBuilder.Append("\n");
				foreach (global::Ionic.Zip.ZipEntry zipEntry in this._entries.Values)
				{
					stringBuilder.Append(zipEntry.Info);
				}
				return stringBuilder.ToString();
			}
		}

		// Token: 0x17000E0E RID: 3598
		// (get) Token: 0x06003135 RID: 12597 RVA: 0x000B2E94 File Offset: 0x000B1094
		// (set) Token: 0x06003136 RID: 12598 RVA: 0x000B2E9C File Offset: 0x000B109C
		public bool FullScan { get; set; }

		// Token: 0x17000E0F RID: 3599
		// (get) Token: 0x06003137 RID: 12599 RVA: 0x000B2EA8 File Offset: 0x000B10A8
		// (set) Token: 0x06003138 RID: 12600 RVA: 0x000B2EB0 File Offset: 0x000B10B0
		public bool SortEntriesBeforeSaving { get; set; }

		// Token: 0x17000E10 RID: 3600
		// (get) Token: 0x06003139 RID: 12601 RVA: 0x000B2EBC File Offset: 0x000B10BC
		// (set) Token: 0x0600313A RID: 12602 RVA: 0x000B2EC4 File Offset: 0x000B10C4
		public bool AddDirectoryWillTraverseReparsePoints { get; set; }

		// Token: 0x17000E11 RID: 3601
		// (get) Token: 0x0600313B RID: 12603 RVA: 0x000B2ED0 File Offset: 0x000B10D0
		// (set) Token: 0x0600313C RID: 12604 RVA: 0x000B2ED8 File Offset: 0x000B10D8
		public int BufferSize
		{
			get
			{
				return this._BufferSize;
			}
			set
			{
				this._BufferSize = value;
			}
		}

		// Token: 0x17000E12 RID: 3602
		// (get) Token: 0x0600313D RID: 12605 RVA: 0x000B2EE4 File Offset: 0x000B10E4
		// (set) Token: 0x0600313E RID: 12606 RVA: 0x000B2EEC File Offset: 0x000B10EC
		public int CodecBufferSize { get; set; }

		// Token: 0x17000E13 RID: 3603
		// (get) Token: 0x0600313F RID: 12607 RVA: 0x000B2EF8 File Offset: 0x000B10F8
		// (set) Token: 0x06003140 RID: 12608 RVA: 0x000B2F00 File Offset: 0x000B1100
		public bool FlattenFoldersOnExtract { get; set; }

		// Token: 0x17000E14 RID: 3604
		// (get) Token: 0x06003141 RID: 12609 RVA: 0x000B2F0C File Offset: 0x000B110C
		// (set) Token: 0x06003142 RID: 12610 RVA: 0x000B2F14 File Offset: 0x000B1114
		public global::Ionic.Zlib.CompressionStrategy Strategy
		{
			get
			{
				return this._Strategy;
			}
			set
			{
				this._Strategy = value;
			}
		}

		// Token: 0x17000E15 RID: 3605
		// (get) Token: 0x06003143 RID: 12611 RVA: 0x000B2F20 File Offset: 0x000B1120
		// (set) Token: 0x06003144 RID: 12612 RVA: 0x000B2F28 File Offset: 0x000B1128
		public string Name
		{
			get
			{
				return this._name;
			}
			set
			{
				this._name = value;
			}
		}

		// Token: 0x17000E16 RID: 3606
		// (get) Token: 0x06003145 RID: 12613 RVA: 0x000B2F34 File Offset: 0x000B1134
		// (set) Token: 0x06003146 RID: 12614 RVA: 0x000B2F3C File Offset: 0x000B113C
		public global::Ionic.Zlib.CompressionLevel CompressionLevel { get; set; }

		// Token: 0x17000E17 RID: 3607
		// (get) Token: 0x06003147 RID: 12615 RVA: 0x000B2F48 File Offset: 0x000B1148
		// (set) Token: 0x06003148 RID: 12616 RVA: 0x000B2F50 File Offset: 0x000B1150
		public global::Ionic.Zip.CompressionMethod CompressionMethod
		{
			get
			{
				return this._compressionMethod;
			}
			set
			{
				this._compressionMethod = value;
			}
		}

		// Token: 0x17000E18 RID: 3608
		// (get) Token: 0x06003149 RID: 12617 RVA: 0x000B2F5C File Offset: 0x000B115C
		// (set) Token: 0x0600314A RID: 12618 RVA: 0x000B2F64 File Offset: 0x000B1164
		public string Comment
		{
			get
			{
				return this._Comment;
			}
			set
			{
				this._Comment = value;
				this._contentsChanged = true;
			}
		}

		// Token: 0x17000E19 RID: 3609
		// (get) Token: 0x0600314B RID: 12619 RVA: 0x000B2F74 File Offset: 0x000B1174
		// (set) Token: 0x0600314C RID: 12620 RVA: 0x000B2F7C File Offset: 0x000B117C
		public bool EmitTimesInWindowsFormatWhenSaving
		{
			get
			{
				return this._emitNtfsTimes;
			}
			set
			{
				this._emitNtfsTimes = value;
			}
		}

		// Token: 0x17000E1A RID: 3610
		// (get) Token: 0x0600314D RID: 12621 RVA: 0x000B2F88 File Offset: 0x000B1188
		// (set) Token: 0x0600314E RID: 12622 RVA: 0x000B2F90 File Offset: 0x000B1190
		public bool EmitTimesInUnixFormatWhenSaving
		{
			get
			{
				return this._emitUnixTimes;
			}
			set
			{
				this._emitUnixTimes = value;
			}
		}

		// Token: 0x17000E1B RID: 3611
		// (get) Token: 0x0600314F RID: 12623 RVA: 0x000B2F9C File Offset: 0x000B119C
		internal bool Verbose
		{
			get
			{
				return this._StatusMessageTextWriter != null;
			}
		}

		// Token: 0x06003150 RID: 12624 RVA: 0x000B2FA8 File Offset: 0x000B11A8
		public bool ContainsEntry(string name)
		{
			return this._entries.ContainsKey(global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(name));
		}

		// Token: 0x17000E1C RID: 3612
		// (get) Token: 0x06003151 RID: 12625 RVA: 0x000B2FBC File Offset: 0x000B11BC
		// (set) Token: 0x06003152 RID: 12626 RVA: 0x000B2FC4 File Offset: 0x000B11C4
		public bool CaseSensitiveRetrieval
		{
			get
			{
				return this._CaseSensitiveRetrieval;
			}
			set
			{
				if (value != this._CaseSensitiveRetrieval)
				{
					this._CaseSensitiveRetrieval = value;
					this._initEntriesDictionary();
				}
			}
		}

		// Token: 0x17000E1D RID: 3613
		// (get) Token: 0x06003153 RID: 12627 RVA: 0x000B2FE0 File Offset: 0x000B11E0
		// (set) Token: 0x06003154 RID: 12628 RVA: 0x000B3004 File Offset: 0x000B1204
		[global::System.Obsolete("Beginning with v1.9.1.6 of DotNetZip, this property is obsolete.  It will be removed in a future version of the library. Your applications should  use AlternateEncoding and AlternateEncodingUsage instead.")]
		public bool UseUnicodeAsNecessary
		{
			get
			{
				return this._alternateEncoding == global::System.Text.Encoding.GetEncoding("UTF-8") && this._alternateEncodingUsage == global::Ionic.Zip.ZipOption.AsNecessary;
			}
			set
			{
				if (value)
				{
					this._alternateEncoding = global::System.Text.Encoding.GetEncoding("UTF-8");
					this._alternateEncodingUsage = global::Ionic.Zip.ZipOption.AsNecessary;
					return;
				}
				this._alternateEncoding = global::Ionic.Zip.ZipFile.DefaultEncoding;
				this._alternateEncodingUsage = global::Ionic.Zip.ZipOption.Default;
			}
		}

		// Token: 0x17000E1E RID: 3614
		// (get) Token: 0x06003155 RID: 12629 RVA: 0x000B3038 File Offset: 0x000B1238
		// (set) Token: 0x06003156 RID: 12630 RVA: 0x000B3040 File Offset: 0x000B1240
		public global::Ionic.Zip.Zip64Option UseZip64WhenSaving
		{
			get
			{
				return this._zip64;
			}
			set
			{
				this._zip64 = value;
			}
		}

		// Token: 0x17000E1F RID: 3615
		// (get) Token: 0x06003157 RID: 12631 RVA: 0x000B304C File Offset: 0x000B124C
		public bool? RequiresZip64
		{
			get
			{
				if (this._entries.Count > 65534)
				{
					return new bool?(true);
				}
				if (!this._hasBeenSaved || this._contentsChanged)
				{
					bool? result = null;
					return result;
				}
				foreach (global::Ionic.Zip.ZipEntry zipEntry in this._entries.Values)
				{
					bool? result = zipEntry.RequiresZip64;
					if (result.Value)
					{
						return new bool?(true);
					}
				}
				return new bool?(false);
			}
		}

		// Token: 0x17000E20 RID: 3616
		// (get) Token: 0x06003158 RID: 12632 RVA: 0x000B3104 File Offset: 0x000B1304
		public bool? OutputUsedZip64
		{
			get
			{
				return this._OutputUsesZip64;
			}
		}

		// Token: 0x17000E21 RID: 3617
		// (get) Token: 0x06003159 RID: 12633 RVA: 0x000B310C File Offset: 0x000B130C
		public bool? InputUsesZip64
		{
			get
			{
				if (this._entries.Count > 65534)
				{
					return new bool?(true);
				}
				foreach (global::Ionic.Zip.ZipEntry zipEntry in this)
				{
					if (zipEntry.Source != global::Ionic.Zip.ZipEntrySource.ZipFile)
					{
						return null;
					}
					if (zipEntry._InputUsesZip64)
					{
						return new bool?(true);
					}
				}
				return new bool?(false);
			}
		}

		// Token: 0x17000E22 RID: 3618
		// (get) Token: 0x0600315A RID: 12634 RVA: 0x000B31AC File Offset: 0x000B13AC
		// (set) Token: 0x0600315B RID: 12635 RVA: 0x000B31C4 File Offset: 0x000B13C4
		[global::System.Obsolete("use AlternateEncoding instead.")]
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

		// Token: 0x17000E23 RID: 3619
		// (get) Token: 0x0600315C RID: 12636 RVA: 0x000B31D4 File Offset: 0x000B13D4
		// (set) Token: 0x0600315D RID: 12637 RVA: 0x000B31DC File Offset: 0x000B13DC
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

		// Token: 0x17000E24 RID: 3620
		// (get) Token: 0x0600315E RID: 12638 RVA: 0x000B31E8 File Offset: 0x000B13E8
		// (set) Token: 0x0600315F RID: 12639 RVA: 0x000B31F0 File Offset: 0x000B13F0
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

		// Token: 0x17000E25 RID: 3621
		// (get) Token: 0x06003160 RID: 12640 RVA: 0x000B31FC File Offset: 0x000B13FC
		public static global::System.Text.Encoding DefaultEncoding
		{
			get
			{
				return global::Ionic.Zip.ZipFile._defaultEncoding;
			}
		}

		// Token: 0x17000E26 RID: 3622
		// (get) Token: 0x06003161 RID: 12641 RVA: 0x000B3204 File Offset: 0x000B1404
		// (set) Token: 0x06003162 RID: 12642 RVA: 0x000B320C File Offset: 0x000B140C
		public global::System.IO.TextWriter StatusMessageTextWriter
		{
			get
			{
				return this._StatusMessageTextWriter;
			}
			set
			{
				this._StatusMessageTextWriter = value;
			}
		}

		// Token: 0x17000E27 RID: 3623
		// (get) Token: 0x06003163 RID: 12643 RVA: 0x000B3218 File Offset: 0x000B1418
		// (set) Token: 0x06003164 RID: 12644 RVA: 0x000B3220 File Offset: 0x000B1420
		public string TempFileFolder
		{
			get
			{
				return this._TempFileFolder;
			}
			set
			{
				this._TempFileFolder = value;
				if (value == null)
				{
					return;
				}
				if (!global::System.IO.Directory.Exists(value))
				{
					throw new global::System.IO.FileNotFoundException(string.Format("That directory ({0}) does not exist.", value));
				}
			}
		}

		// Token: 0x17000E28 RID: 3624
		// (get) Token: 0x06003166 RID: 12646 RVA: 0x000B327C File Offset: 0x000B147C
		// (set) Token: 0x06003165 RID: 12645 RVA: 0x000B324C File Offset: 0x000B144C
		public string Password
		{
			private get
			{
				return this._Password;
			}
			set
			{
				this._Password = value;
				if (this._Password == null)
				{
					this.Encryption = global::Ionic.Zip.EncryptionAlgorithm.None;
					return;
				}
				if (this.Encryption == global::Ionic.Zip.EncryptionAlgorithm.None)
				{
					this.Encryption = global::Ionic.Zip.EncryptionAlgorithm.PkzipWeak;
				}
			}
		}

		// Token: 0x17000E29 RID: 3625
		// (get) Token: 0x06003167 RID: 12647 RVA: 0x000B3284 File Offset: 0x000B1484
		// (set) Token: 0x06003168 RID: 12648 RVA: 0x000B328C File Offset: 0x000B148C
		public global::Ionic.Zip.ExtractExistingFileAction ExtractExistingFile { get; set; }

		// Token: 0x17000E2A RID: 3626
		// (get) Token: 0x06003169 RID: 12649 RVA: 0x000B3298 File Offset: 0x000B1498
		// (set) Token: 0x0600316A RID: 12650 RVA: 0x000B32B4 File Offset: 0x000B14B4
		public global::Ionic.Zip.ZipErrorAction ZipErrorAction
		{
			get
			{
				if (this.ZipError != null)
				{
					this._zipErrorAction = global::Ionic.Zip.ZipErrorAction.InvokeErrorEvent;
				}
				return this._zipErrorAction;
			}
			set
			{
				this._zipErrorAction = value;
				if (this._zipErrorAction != global::Ionic.Zip.ZipErrorAction.InvokeErrorEvent && this.ZipError != null)
				{
					this.ZipError = null;
				}
			}
		}

		// Token: 0x17000E2B RID: 3627
		// (get) Token: 0x0600316B RID: 12651 RVA: 0x000B32DC File Offset: 0x000B14DC
		// (set) Token: 0x0600316C RID: 12652 RVA: 0x000B32E4 File Offset: 0x000B14E4
		public global::Ionic.Zip.EncryptionAlgorithm Encryption
		{
			get
			{
				return this._Encryption;
			}
			set
			{
				if (value == global::Ionic.Zip.EncryptionAlgorithm.Unsupported)
				{
					throw new global::System.InvalidOperationException("You may not set Encryption to that value.");
				}
				this._Encryption = value;
			}
		}

		// Token: 0x17000E2C RID: 3628
		// (get) Token: 0x0600316D RID: 12653 RVA: 0x000B3300 File Offset: 0x000B1500
		// (set) Token: 0x0600316E RID: 12654 RVA: 0x000B3308 File Offset: 0x000B1508
		public global::Ionic.Zip.SetCompressionCallback SetCompression { get; set; }

		// Token: 0x17000E2D RID: 3629
		// (get) Token: 0x0600316F RID: 12655 RVA: 0x000B3314 File Offset: 0x000B1514
		// (set) Token: 0x06003170 RID: 12656 RVA: 0x000B331C File Offset: 0x000B151C
		public int MaxOutputSegmentSize
		{
			get
			{
				return this._maxOutputSegmentSize;
			}
			set
			{
				if (value < 65536 && value != 0)
				{
					throw new global::Ionic.Zip.ZipException("The minimum acceptable segment size is 65536.");
				}
				this._maxOutputSegmentSize = value;
			}
		}

		// Token: 0x17000E2E RID: 3630
		// (get) Token: 0x06003171 RID: 12657 RVA: 0x000B3344 File Offset: 0x000B1544
		public int NumberOfSegmentsForMostRecentSave
		{
			get
			{
				return (int)(this._numberOfSegmentsForMostRecentSave + 1U);
			}
		}

		// Token: 0x17000E2F RID: 3631
		// (get) Token: 0x06003173 RID: 12659 RVA: 0x000B3380 File Offset: 0x000B1580
		// (set) Token: 0x06003172 RID: 12658 RVA: 0x000B3350 File Offset: 0x000B1550
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
					throw new global::System.ArgumentOutOfRangeException("ParallelDeflateThreshold should be -1, 0, or > 65536");
				}
				this._ParallelDeflateThreshold = value;
			}
		}

		// Token: 0x17000E30 RID: 3632
		// (get) Token: 0x06003174 RID: 12660 RVA: 0x000B3388 File Offset: 0x000B1588
		// (set) Token: 0x06003175 RID: 12661 RVA: 0x000B3390 File Offset: 0x000B1590
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

		// Token: 0x06003176 RID: 12662 RVA: 0x000B33B0 File Offset: 0x000B15B0
		public override string ToString()
		{
			return string.Format("ZipFile::{0}", this.Name);
		}

		// Token: 0x17000E31 RID: 3633
		// (get) Token: 0x06003177 RID: 12663 RVA: 0x000B33C4 File Offset: 0x000B15C4
		public static global::System.Version LibraryVersion
		{
			get
			{
				return global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Version;
			}
		}

		// Token: 0x06003178 RID: 12664 RVA: 0x000B33D8 File Offset: 0x000B15D8
		internal void NotifyEntryChanged()
		{
			this._contentsChanged = true;
		}

		// Token: 0x06003179 RID: 12665 RVA: 0x000B33E4 File Offset: 0x000B15E4
		internal global::System.IO.Stream StreamForDiskNumber(uint diskNumber)
		{
			if (diskNumber + 1U == this._diskNumberWithCd || (diskNumber == 0U && this._diskNumberWithCd == 0U))
			{
				return this.ReadStream;
			}
			return global::Ionic.Zip.ZipSegmentedStream.ForReading(this._readName ?? this._name, diskNumber, this._diskNumberWithCd);
		}

		// Token: 0x0600317A RID: 12666 RVA: 0x000B343C File Offset: 0x000B163C
		internal void Reset(bool whileSaving)
		{
			if (this._JustSaved)
			{
				using (global::Ionic.Zip.ZipFile zipFile = new global::Ionic.Zip.ZipFile())
				{
					zipFile._readName = (zipFile._name = (whileSaving ? (this._readName ?? this._name) : this._name));
					zipFile.AlternateEncoding = this.AlternateEncoding;
					zipFile.AlternateEncodingUsage = this.AlternateEncodingUsage;
					global::Ionic.Zip.ZipFile.ReadIntoInstance(zipFile);
					foreach (global::Ionic.Zip.ZipEntry zipEntry in zipFile)
					{
						foreach (global::Ionic.Zip.ZipEntry zipEntry2 in this)
						{
							if (zipEntry.FileName == zipEntry2.FileName)
							{
								zipEntry2.CopyMetaData(zipEntry);
								break;
							}
						}
					}
				}
				this._JustSaved = false;
			}
		}

		// Token: 0x0600317B RID: 12667 RVA: 0x000B356C File Offset: 0x000B176C
		public ZipFile(string fileName)
		{
			try
			{
				this._InitInstance(fileName, null);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("Could not read {0} as a zip file", fileName), innerException);
			}
		}

		// Token: 0x0600317C RID: 12668 RVA: 0x000B3604 File Offset: 0x000B1804
		public ZipFile(string fileName, global::System.Text.Encoding encoding)
		{
			try
			{
				this.AlternateEncoding = encoding;
				this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
				this._InitInstance(fileName, null);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("{0} is not a valid zip file", fileName), innerException);
			}
		}

		// Token: 0x0600317D RID: 12669 RVA: 0x000B36AC File Offset: 0x000B18AC
		public ZipFile()
		{
			this._InitInstance(null, null);
		}

		// Token: 0x0600317E RID: 12670 RVA: 0x000B3720 File Offset: 0x000B1920
		public ZipFile(global::System.Text.Encoding encoding)
		{
			this.AlternateEncoding = encoding;
			this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
			this._InitInstance(null, null);
		}

		// Token: 0x0600317F RID: 12671 RVA: 0x000B37A4 File Offset: 0x000B19A4
		public ZipFile(string fileName, global::System.IO.TextWriter statusMessageWriter)
		{
			try
			{
				this._InitInstance(fileName, statusMessageWriter);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("{0} is not a valid zip file", fileName), innerException);
			}
		}

		// Token: 0x06003180 RID: 12672 RVA: 0x000B383C File Offset: 0x000B1A3C
		public ZipFile(string fileName, global::System.IO.TextWriter statusMessageWriter, global::System.Text.Encoding encoding)
		{
			try
			{
				this.AlternateEncoding = encoding;
				this.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
				this._InitInstance(fileName, statusMessageWriter);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("{0} is not a valid zip file", fileName), innerException);
			}
		}

		// Token: 0x06003181 RID: 12673 RVA: 0x000B38E4 File Offset: 0x000B1AE4
		public void Initialize(string fileName)
		{
			try
			{
				this._InitInstance(fileName, null);
			}
			catch (global::System.Exception innerException)
			{
				throw new global::Ionic.Zip.ZipException(string.Format("{0} is not a valid zip file", fileName), innerException);
			}
		}

		// Token: 0x06003182 RID: 12674 RVA: 0x000B3924 File Offset: 0x000B1B24
		private void _initEntriesDictionary()
		{
			global::System.StringComparer comparer = this.CaseSensitiveRetrieval ? global::System.StringComparer.Ordinal : global::System.StringComparer.OrdinalIgnoreCase;
			this._entries = ((this._entries == null) ? new global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>(comparer) : new global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>(this._entries, comparer));
		}

		// Token: 0x06003183 RID: 12675 RVA: 0x000B3978 File Offset: 0x000B1B78
		private void _InitInstance(string zipFileName, global::System.IO.TextWriter statusMessageWriter)
		{
			this._name = zipFileName;
			this._StatusMessageTextWriter = statusMessageWriter;
			this._contentsChanged = true;
			this.AddDirectoryWillTraverseReparsePoints = true;
			this.CompressionLevel = global::Ionic.Zlib.CompressionLevel.Default;
			this.ParallelDeflateThreshold = 524288L;
			this._initEntriesDictionary();
			if (global::System.IO.File.Exists(this._name))
			{
				if (this.FullScan)
				{
					global::Ionic.Zip.ZipFile.ReadIntoInstance_Orig(this);
				}
				else
				{
					global::Ionic.Zip.ZipFile.ReadIntoInstance(this);
				}
				this._fileAlreadyExists = true;
			}
		}

		// Token: 0x17000E32 RID: 3634
		// (get) Token: 0x06003184 RID: 12676 RVA: 0x000B39F4 File Offset: 0x000B1BF4
		private global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> ZipEntriesAsList
		{
			get
			{
				if (this._zipEntriesAsList == null)
				{
					this._zipEntriesAsList = new global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry>(this._entries.Values);
				}
				return this._zipEntriesAsList;
			}
		}

		// Token: 0x17000E33 RID: 3635
		public global::Ionic.Zip.ZipEntry this[int ix]
		{
			get
			{
				return this.ZipEntriesAsList[ix];
			}
		}

		// Token: 0x17000E34 RID: 3636
		public global::Ionic.Zip.ZipEntry this[string fileName]
		{
			get
			{
				string text = global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(fileName);
				if (this._entries.ContainsKey(text))
				{
					return this._entries[text];
				}
				text = text.Replace("/", "\\");
				if (this._entries.ContainsKey(text))
				{
					return this._entries[text];
				}
				return null;
			}
		}

		// Token: 0x17000E35 RID: 3637
		// (get) Token: 0x06003187 RID: 12679 RVA: 0x000B3A98 File Offset: 0x000B1C98
		public global::System.Collections.Generic.ICollection<string> EntryFileNames
		{
			get
			{
				return this._entries.Keys;
			}
		}

		// Token: 0x17000E36 RID: 3638
		// (get) Token: 0x06003188 RID: 12680 RVA: 0x000B3AA8 File Offset: 0x000B1CA8
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> Entries
		{
			get
			{
				return this._entries.Values;
			}
		}

		// Token: 0x17000E37 RID: 3639
		// (get) Token: 0x06003189 RID: 12681 RVA: 0x000B3AB8 File Offset: 0x000B1CB8
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> EntriesSorted
		{
			get
			{
				global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> list = new global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry>();
				foreach (global::Ionic.Zip.ZipEntry item in this.Entries)
				{
					list.Add(item);
				}
				global::System.StringComparison sc = this.CaseSensitiveRetrieval ? global::System.StringComparison.Ordinal : global::System.StringComparison.OrdinalIgnoreCase;
				list.Sort((global::Ionic.Zip.ZipEntry x, global::Ionic.Zip.ZipEntry y) => string.Compare(x.FileName, y.FileName, sc));
				return list.AsReadOnly();
			}
		}

		// Token: 0x17000E38 RID: 3640
		// (get) Token: 0x0600318A RID: 12682 RVA: 0x000B3B4C File Offset: 0x000B1D4C
		public int Count
		{
			get
			{
				return this._entries.Count;
			}
		}

		// Token: 0x0600318B RID: 12683 RVA: 0x000B3B5C File Offset: 0x000B1D5C
		public void RemoveEntry(global::Ionic.Zip.ZipEntry entry)
		{
			if (entry == null)
			{
				throw new global::System.ArgumentNullException("entry");
			}
			this._entries.Remove(global::Ionic.Zip.SharedUtilities.NormalizePathForUseInZipFile(entry.FileName));
			this._zipEntriesAsList = null;
			this._contentsChanged = true;
		}

		// Token: 0x0600318C RID: 12684 RVA: 0x000B3B94 File Offset: 0x000B1D94
		public void RemoveEntry(string fileName)
		{
			string fileName2 = global::Ionic.Zip.ZipEntry.NameInArchive(fileName, null);
			global::Ionic.Zip.ZipEntry zipEntry = this[fileName2];
			if (zipEntry == null)
			{
				throw new global::System.ArgumentException("The entry you specified was not found in the zip archive.");
			}
			this.RemoveEntry(zipEntry);
		}

		// Token: 0x0600318D RID: 12685 RVA: 0x000B3BD0 File Offset: 0x000B1DD0
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x0600318E RID: 12686 RVA: 0x000B3BE0 File Offset: 0x000B1DE0
		protected virtual void Dispose(bool disposeManagedResources)
		{
			if (!this._disposed)
			{
				if (disposeManagedResources)
				{
					if (this._ReadStreamIsOurs && this._readstream != null)
					{
						this._readstream.Dispose();
						this._readstream = null;
					}
					if (this._temporaryFileName != null && this._name != null && this._writestream != null)
					{
						this._writestream.Dispose();
						this._writestream = null;
					}
					if (this.ParallelDeflater != null)
					{
						this.ParallelDeflater.Dispose();
						this.ParallelDeflater = null;
					}
				}
				this._disposed = true;
			}
		}

		// Token: 0x17000E39 RID: 3641
		// (get) Token: 0x0600318F RID: 12687 RVA: 0x000B3C84 File Offset: 0x000B1E84
		internal global::System.IO.Stream ReadStream
		{
			get
			{
				if (this._readstream == null && (this._readName != null || this._name != null))
				{
					this._readstream = global::System.IO.File.Open(this._readName ?? this._name, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite);
					this._ReadStreamIsOurs = true;
				}
				return this._readstream;
			}
		}

		// Token: 0x17000E3A RID: 3642
		// (get) Token: 0x06003190 RID: 12688 RVA: 0x000B3CE4 File Offset: 0x000B1EE4
		// (set) Token: 0x06003191 RID: 12689 RVA: 0x000B3D74 File Offset: 0x000B1F74
		private global::System.IO.Stream WriteStream
		{
			get
			{
				if (this._writestream != null)
				{
					return this._writestream;
				}
				if (this._name == null)
				{
					return this._writestream;
				}
				if (this._maxOutputSegmentSize != 0)
				{
					this._writestream = global::Ionic.Zip.ZipSegmentedStream.ForWriting(this._name, this._maxOutputSegmentSize);
					return this._writestream;
				}
				global::Ionic.Zip.SharedUtilities.CreateAndOpenUniqueTempFile(this.TempFileFolder ?? global::System.IO.Path.GetDirectoryName(this._name), out this._writestream, out this._temporaryFileName);
				return this._writestream;
			}
			set
			{
				if (value != null)
				{
					throw new global::Ionic.Zip.ZipException("Cannot set the stream to a non-null value.");
				}
				this._writestream = null;
			}
		}

		// Token: 0x17000E3B RID: 3643
		// (get) Token: 0x06003192 RID: 12690 RVA: 0x000B3D90 File Offset: 0x000B1F90
		private string ArchiveNameForEvent
		{
			get
			{
				if (this._name == null)
				{
					return "(stream)";
				}
				return this._name;
			}
		}

		// Token: 0x140000E0 RID: 224
		// (add) Token: 0x06003193 RID: 12691 RVA: 0x000B3DAC File Offset: 0x000B1FAC
		// (remove) Token: 0x06003194 RID: 12692 RVA: 0x000B3DE8 File Offset: 0x000B1FE8
		public event global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> SaveProgress;

		// Token: 0x06003195 RID: 12693 RVA: 0x000B3E24 File Offset: 0x000B2024
		internal bool OnSaveBlock(global::Ionic.Zip.ZipEntry entry, long bytesXferred, long totalBytesToXfer)
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs saveProgressEventArgs = global::Ionic.Zip.SaveProgressEventArgs.ByteUpdate(this.ArchiveNameForEvent, entry, bytesXferred, totalBytesToXfer);
				saveProgress(this, saveProgressEventArgs);
				if (saveProgressEventArgs.Cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
			return this._saveOperationCanceled;
		}

		// Token: 0x06003196 RID: 12694 RVA: 0x000B3E74 File Offset: 0x000B2074
		private void OnSaveEntry(int current, global::Ionic.Zip.ZipEntry entry, bool before)
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs saveProgressEventArgs = new global::Ionic.Zip.SaveProgressEventArgs(this.ArchiveNameForEvent, before, this._entries.Count, current, entry);
				saveProgress(this, saveProgressEventArgs);
				if (saveProgressEventArgs.Cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
		}

		// Token: 0x06003197 RID: 12695 RVA: 0x000B3EC8 File Offset: 0x000B20C8
		private void OnSaveEvent(global::Ionic.Zip.ZipProgressEventType eventFlavor)
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs saveProgressEventArgs = new global::Ionic.Zip.SaveProgressEventArgs(this.ArchiveNameForEvent, eventFlavor);
				saveProgress(this, saveProgressEventArgs);
				if (saveProgressEventArgs.Cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
		}

		// Token: 0x06003198 RID: 12696 RVA: 0x000B3F10 File Offset: 0x000B2110
		private void OnSaveStarted()
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs saveProgressEventArgs = global::Ionic.Zip.SaveProgressEventArgs.Started(this.ArchiveNameForEvent);
				saveProgress(this, saveProgressEventArgs);
				if (saveProgressEventArgs.Cancel)
				{
					this._saveOperationCanceled = true;
				}
			}
		}

		// Token: 0x06003199 RID: 12697 RVA: 0x000B3F54 File Offset: 0x000B2154
		private void OnSaveCompleted()
		{
			global::System.EventHandler<global::Ionic.Zip.SaveProgressEventArgs> saveProgress = this.SaveProgress;
			if (saveProgress != null)
			{
				global::Ionic.Zip.SaveProgressEventArgs e = global::Ionic.Zip.SaveProgressEventArgs.Completed(this.ArchiveNameForEvent);
				saveProgress(this, e);
			}
		}

		// Token: 0x140000E1 RID: 225
		// (add) Token: 0x0600319A RID: 12698 RVA: 0x000B3F88 File Offset: 0x000B2188
		// (remove) Token: 0x0600319B RID: 12699 RVA: 0x000B3FC4 File Offset: 0x000B21C4
		public event global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> ReadProgress;

		// Token: 0x0600319C RID: 12700 RVA: 0x000B4000 File Offset: 0x000B2200
		private void OnReadStarted()
		{
			global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress = this.ReadProgress;
			if (readProgress != null)
			{
				global::Ionic.Zip.ReadProgressEventArgs e = global::Ionic.Zip.ReadProgressEventArgs.Started(this.ArchiveNameForEvent);
				readProgress(this, e);
			}
		}

		// Token: 0x0600319D RID: 12701 RVA: 0x000B4034 File Offset: 0x000B2234
		private void OnReadCompleted()
		{
			global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress = this.ReadProgress;
			if (readProgress != null)
			{
				global::Ionic.Zip.ReadProgressEventArgs e = global::Ionic.Zip.ReadProgressEventArgs.Completed(this.ArchiveNameForEvent);
				readProgress(this, e);
			}
		}

		// Token: 0x0600319E RID: 12702 RVA: 0x000B4068 File Offset: 0x000B2268
		internal void OnReadBytes(global::Ionic.Zip.ZipEntry entry)
		{
			global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress = this.ReadProgress;
			if (readProgress != null)
			{
				global::Ionic.Zip.ReadProgressEventArgs e = global::Ionic.Zip.ReadProgressEventArgs.ByteUpdate(this.ArchiveNameForEvent, entry, this.ReadStream.Position, this.LengthOfReadStream);
				readProgress(this, e);
			}
		}

		// Token: 0x0600319F RID: 12703 RVA: 0x000B40AC File Offset: 0x000B22AC
		internal void OnReadEntry(bool before, global::Ionic.Zip.ZipEntry entry)
		{
			global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress = this.ReadProgress;
			if (readProgress != null)
			{
				global::Ionic.Zip.ReadProgressEventArgs e = before ? global::Ionic.Zip.ReadProgressEventArgs.Before(this.ArchiveNameForEvent, this._entries.Count) : global::Ionic.Zip.ReadProgressEventArgs.After(this.ArchiveNameForEvent, entry, this._entries.Count);
				readProgress(this, e);
			}
		}

		// Token: 0x17000E3C RID: 3644
		// (get) Token: 0x060031A0 RID: 12704 RVA: 0x000B410C File Offset: 0x000B230C
		private long LengthOfReadStream
		{
			get
			{
				if (this._lengthOfReadStream == -99L)
				{
					this._lengthOfReadStream = (this._ReadStreamIsOurs ? global::Ionic.Zip.SharedUtilities.GetFileLength(this._name) : -1L);
				}
				return this._lengthOfReadStream;
			}
		}

		// Token: 0x140000E2 RID: 226
		// (add) Token: 0x060031A1 RID: 12705 RVA: 0x000B4148 File Offset: 0x000B2348
		// (remove) Token: 0x060031A2 RID: 12706 RVA: 0x000B4184 File Offset: 0x000B2384
		public event global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> ExtractProgress;

		// Token: 0x060031A3 RID: 12707 RVA: 0x000B41C0 File Offset: 0x000B23C0
		private void OnExtractEntry(int current, bool before, global::Ionic.Zip.ZipEntry currentEntry, string path)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs extractProgressEventArgs = new global::Ionic.Zip.ExtractProgressEventArgs(this.ArchiveNameForEvent, before, this._entries.Count, current, currentEntry, path);
				extractProgress(this, extractProgressEventArgs);
				if (extractProgressEventArgs.Cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
		}

		// Token: 0x060031A4 RID: 12708 RVA: 0x000B4214 File Offset: 0x000B2414
		internal bool OnExtractBlock(global::Ionic.Zip.ZipEntry entry, long bytesWritten, long totalBytesToWrite)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs extractProgressEventArgs = global::Ionic.Zip.ExtractProgressEventArgs.ByteUpdate(this.ArchiveNameForEvent, entry, bytesWritten, totalBytesToWrite);
				extractProgress(this, extractProgressEventArgs);
				if (extractProgressEventArgs.Cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
			return this._extractOperationCanceled;
		}

		// Token: 0x060031A5 RID: 12709 RVA: 0x000B4264 File Offset: 0x000B2464
		internal bool OnSingleEntryExtract(global::Ionic.Zip.ZipEntry entry, string path, bool before)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs extractProgressEventArgs = before ? global::Ionic.Zip.ExtractProgressEventArgs.BeforeExtractEntry(this.ArchiveNameForEvent, entry, path) : global::Ionic.Zip.ExtractProgressEventArgs.AfterExtractEntry(this.ArchiveNameForEvent, entry, path);
				extractProgress(this, extractProgressEventArgs);
				if (extractProgressEventArgs.Cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
			return this._extractOperationCanceled;
		}

		// Token: 0x060031A6 RID: 12710 RVA: 0x000B42C8 File Offset: 0x000B24C8
		internal bool OnExtractExisting(global::Ionic.Zip.ZipEntry entry, string path)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs extractProgressEventArgs = global::Ionic.Zip.ExtractProgressEventArgs.ExtractExisting(this.ArchiveNameForEvent, entry, path);
				extractProgress(this, extractProgressEventArgs);
				if (extractProgressEventArgs.Cancel)
				{
					this._extractOperationCanceled = true;
				}
			}
			return this._extractOperationCanceled;
		}

		// Token: 0x060031A7 RID: 12711 RVA: 0x000B4314 File Offset: 0x000B2514
		private void OnExtractAllCompleted(string path)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs e = global::Ionic.Zip.ExtractProgressEventArgs.ExtractAllCompleted(this.ArchiveNameForEvent, path);
				extractProgress(this, e);
			}
		}

		// Token: 0x060031A8 RID: 12712 RVA: 0x000B4348 File Offset: 0x000B2548
		private void OnExtractAllStarted(string path)
		{
			global::System.EventHandler<global::Ionic.Zip.ExtractProgressEventArgs> extractProgress = this.ExtractProgress;
			if (extractProgress != null)
			{
				global::Ionic.Zip.ExtractProgressEventArgs e = global::Ionic.Zip.ExtractProgressEventArgs.ExtractAllStarted(this.ArchiveNameForEvent, path);
				extractProgress(this, e);
			}
		}

		// Token: 0x140000E3 RID: 227
		// (add) Token: 0x060031A9 RID: 12713 RVA: 0x000B437C File Offset: 0x000B257C
		// (remove) Token: 0x060031AA RID: 12714 RVA: 0x000B43B8 File Offset: 0x000B25B8
		public event global::System.EventHandler<global::Ionic.Zip.AddProgressEventArgs> AddProgress;

		// Token: 0x060031AB RID: 12715 RVA: 0x000B43F4 File Offset: 0x000B25F4
		private void OnAddStarted()
		{
			global::System.EventHandler<global::Ionic.Zip.AddProgressEventArgs> addProgress = this.AddProgress;
			if (addProgress != null)
			{
				global::Ionic.Zip.AddProgressEventArgs addProgressEventArgs = global::Ionic.Zip.AddProgressEventArgs.Started(this.ArchiveNameForEvent);
				addProgress(this, addProgressEventArgs);
				if (addProgressEventArgs.Cancel)
				{
					this._addOperationCanceled = true;
				}
			}
		}

		// Token: 0x060031AC RID: 12716 RVA: 0x000B4438 File Offset: 0x000B2638
		private void OnAddCompleted()
		{
			global::System.EventHandler<global::Ionic.Zip.AddProgressEventArgs> addProgress = this.AddProgress;
			if (addProgress != null)
			{
				global::Ionic.Zip.AddProgressEventArgs e = global::Ionic.Zip.AddProgressEventArgs.Completed(this.ArchiveNameForEvent);
				addProgress(this, e);
			}
		}

		// Token: 0x060031AD RID: 12717 RVA: 0x000B446C File Offset: 0x000B266C
		internal void AfterAddEntry(global::Ionic.Zip.ZipEntry entry)
		{
			global::System.EventHandler<global::Ionic.Zip.AddProgressEventArgs> addProgress = this.AddProgress;
			if (addProgress != null)
			{
				global::Ionic.Zip.AddProgressEventArgs addProgressEventArgs = global::Ionic.Zip.AddProgressEventArgs.AfterEntry(this.ArchiveNameForEvent, entry, this._entries.Count);
				addProgress(this, addProgressEventArgs);
				if (addProgressEventArgs.Cancel)
				{
					this._addOperationCanceled = true;
				}
			}
		}

		// Token: 0x140000E4 RID: 228
		// (add) Token: 0x060031AE RID: 12718 RVA: 0x000B44BC File Offset: 0x000B26BC
		// (remove) Token: 0x060031AF RID: 12719 RVA: 0x000B44F8 File Offset: 0x000B26F8
		public event global::System.EventHandler<global::Ionic.Zip.ZipErrorEventArgs> ZipError;

		// Token: 0x060031B0 RID: 12720 RVA: 0x000B4534 File Offset: 0x000B2734
		internal bool OnZipErrorSaving(global::Ionic.Zip.ZipEntry entry, global::System.Exception exc)
		{
			if (this.ZipError != null)
			{
				object @lock = this.LOCK;
				lock (@lock)
				{
					global::Ionic.Zip.ZipErrorEventArgs zipErrorEventArgs = global::Ionic.Zip.ZipErrorEventArgs.Saving(this.Name, entry, exc);
					this.ZipError(this, zipErrorEventArgs);
					if (zipErrorEventArgs.Cancel)
					{
						this._saveOperationCanceled = true;
					}
				}
			}
			return this._saveOperationCanceled;
		}

		// Token: 0x060031B1 RID: 12721 RVA: 0x000B45A8 File Offset: 0x000B27A8
		public void ExtractAll(string path)
		{
			this._InternalExtractAll(path, true);
		}

		// Token: 0x060031B2 RID: 12722 RVA: 0x000B45B4 File Offset: 0x000B27B4
		public void ExtractAll(string path, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			this.ExtractExistingFile = extractExistingFile;
			this._InternalExtractAll(path, true);
		}

		// Token: 0x060031B3 RID: 12723 RVA: 0x000B45C8 File Offset: 0x000B27C8
		private void _InternalExtractAll(string path, bool overrideExtractExistingProperty)
		{
			bool flag = this.Verbose;
			this._inExtractAll = true;
			try
			{
				this.OnExtractAllStarted(path);
				int num = 0;
				foreach (global::Ionic.Zip.ZipEntry zipEntry in this._entries.Values)
				{
					if (flag)
					{
						this.StatusMessageTextWriter.WriteLine("\n{1,-22} {2,-8} {3,4}   {4,-8}  {0}", new object[]
						{
							"Name",
							"Modified",
							"Size",
							"Ratio",
							"Packed"
						});
						this.StatusMessageTextWriter.WriteLine(new string('-', 72));
						flag = false;
					}
					if (this.Verbose)
					{
						this.StatusMessageTextWriter.WriteLine("{1,-22} {2,-8} {3,4:F0}%   {4,-8} {0}", new object[]
						{
							zipEntry.FileName,
							zipEntry.LastModified.ToString("yyyy-MM-dd HH:mm:ss"),
							zipEntry.UncompressedSize,
							zipEntry.CompressionRatio,
							zipEntry.CompressedSize
						});
						if (!string.IsNullOrEmpty(zipEntry.Comment))
						{
							this.StatusMessageTextWriter.WriteLine("  Comment: {0}", zipEntry.Comment);
						}
					}
					zipEntry.Password = this._Password;
					this.OnExtractEntry(num, true, zipEntry, path);
					if (overrideExtractExistingProperty)
					{
						zipEntry.ExtractExistingFile = this.ExtractExistingFile;
					}
					zipEntry.Extract(path);
					num++;
					this.OnExtractEntry(num, false, zipEntry, path);
					if (this._extractOperationCanceled)
					{
						break;
					}
				}
				if (!this._extractOperationCanceled)
				{
					foreach (global::Ionic.Zip.ZipEntry zipEntry2 in this._entries.Values)
					{
						if (zipEntry2.IsDirectory || zipEntry2.FileName.EndsWith("/"))
						{
							string fileOrDirectory = zipEntry2.FileName.StartsWith("/") ? global::System.IO.Path.Combine(path, zipEntry2.FileName.Substring(1)) : global::System.IO.Path.Combine(path, zipEntry2.FileName);
							zipEntry2._SetTimes(fileOrDirectory, false);
						}
					}
					this.OnExtractAllCompleted(path);
				}
			}
			finally
			{
				this._inExtractAll = false;
			}
		}

		// Token: 0x060031B4 RID: 12724 RVA: 0x000B4870 File Offset: 0x000B2A70
		public static global::Ionic.Zip.ZipFile Read(string fileName)
		{
			return global::Ionic.Zip.ZipFile.Read(fileName, null, null, null);
		}

		// Token: 0x060031B5 RID: 12725 RVA: 0x000B487C File Offset: 0x000B2A7C
		public static global::Ionic.Zip.ZipFile Read(string fileName, global::Ionic.Zip.ReadOptions options)
		{
			if (options == null)
			{
				throw new global::System.ArgumentNullException("options");
			}
			return global::Ionic.Zip.ZipFile.Read(fileName, options.StatusMessageWriter, options.Encoding, options.ReadProgress);
		}

		// Token: 0x060031B6 RID: 12726 RVA: 0x000B48B8 File Offset: 0x000B2AB8
		private static global::Ionic.Zip.ZipFile Read(string fileName, global::System.IO.TextWriter statusMessageWriter, global::System.Text.Encoding encoding, global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress)
		{
			global::Ionic.Zip.ZipFile zipFile = new global::Ionic.Zip.ZipFile();
			zipFile.AlternateEncoding = (encoding ?? global::Ionic.Zip.ZipFile.DefaultEncoding);
			zipFile.AlternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
			zipFile._StatusMessageTextWriter = statusMessageWriter;
			zipFile._name = fileName;
			if (readProgress != null)
			{
				zipFile.ReadProgress = readProgress;
			}
			if (zipFile.Verbose)
			{
				zipFile._StatusMessageTextWriter.WriteLine("reading from {0}...", fileName);
			}
			global::Ionic.Zip.ZipFile.ReadIntoInstance(zipFile);
			zipFile._fileAlreadyExists = true;
			return zipFile;
		}

		// Token: 0x060031B7 RID: 12727 RVA: 0x000B4930 File Offset: 0x000B2B30
		public static global::Ionic.Zip.ZipFile Read(global::System.IO.Stream zipStream)
		{
			return global::Ionic.Zip.ZipFile.Read(zipStream, null, null, null);
		}

		// Token: 0x060031B8 RID: 12728 RVA: 0x000B493C File Offset: 0x000B2B3C
		public static global::Ionic.Zip.ZipFile Read(global::System.IO.Stream zipStream, global::Ionic.Zip.ReadOptions options)
		{
			if (options == null)
			{
				throw new global::System.ArgumentNullException("options");
			}
			return global::Ionic.Zip.ZipFile.Read(zipStream, options.StatusMessageWriter, options.Encoding, options.ReadProgress);
		}

		// Token: 0x060031B9 RID: 12729 RVA: 0x000B4978 File Offset: 0x000B2B78
		private static global::Ionic.Zip.ZipFile Read(global::System.IO.Stream zipStream, global::System.IO.TextWriter statusMessageWriter, global::System.Text.Encoding encoding, global::System.EventHandler<global::Ionic.Zip.ReadProgressEventArgs> readProgress)
		{
			if (zipStream == null)
			{
				throw new global::System.ArgumentNullException("zipStream");
			}
			global::Ionic.Zip.ZipFile zipFile = new global::Ionic.Zip.ZipFile();
			zipFile._StatusMessageTextWriter = statusMessageWriter;
			zipFile._alternateEncoding = (encoding ?? global::Ionic.Zip.ZipFile.DefaultEncoding);
			zipFile._alternateEncodingUsage = global::Ionic.Zip.ZipOption.Always;
			if (readProgress != null)
			{
				zipFile.ReadProgress += readProgress;
			}
			zipFile._readstream = ((zipStream.Position == 0L) ? zipStream : new global::Ionic.Zip.OffsetStream(zipStream));
			zipFile._ReadStreamIsOurs = false;
			if (zipFile.Verbose)
			{
				zipFile._StatusMessageTextWriter.WriteLine("reading from stream...");
			}
			global::Ionic.Zip.ZipFile.ReadIntoInstance(zipFile);
			return zipFile;
		}

		// Token: 0x060031BA RID: 12730 RVA: 0x000B4A14 File Offset: 0x000B2C14
		private static void ReadIntoInstance(global::Ionic.Zip.ZipFile zf)
		{
			global::System.IO.Stream readStream = zf.ReadStream;
			try
			{
				zf._readName = zf._name;
				if (!readStream.CanSeek)
				{
					global::Ionic.Zip.ZipFile.ReadIntoInstance_Orig(zf);
					return;
				}
				zf.OnReadStarted();
				if (global::Ionic.Zip.ZipFile.ReadFirstFourBytes(readStream) == 101010256U)
				{
					return;
				}
				int num = 0;
				bool flag = false;
				long num2 = readStream.Length - 64L;
				long num3 = global::System.Math.Max(readStream.Length - 16384L, 10L);
				do
				{
					if (num2 < 0L)
					{
						num2 = 0L;
					}
					readStream.Seek(num2, global::System.IO.SeekOrigin.Begin);
					if (global::Ionic.Zip.SharedUtilities.FindSignature(readStream, 101010256) != -1L)
					{
						flag = true;
					}
					else
					{
						if (num2 == 0L)
						{
							break;
						}
						num++;
						num2 -= (long)(32 * (num + 1) * num);
					}
				}
				while (!flag && num2 > num3);
				if (flag)
				{
					zf._locEndOfCDS = readStream.Position - 4L;
					byte[] array = new byte[16];
					readStream.Read(array, 0, array.Length);
					zf._diskNumberWithCd = (uint)global::System.BitConverter.ToUInt16(array, 2);
					if (zf._diskNumberWithCd == 65535U)
					{
						throw new global::Ionic.Zip.ZipException("Spanned archives with more than 65534 segments are not supported at this time.");
					}
					zf._diskNumberWithCd += 1U;
					int startIndex = 12;
					uint num4 = global::System.BitConverter.ToUInt32(array, startIndex);
					if (num4 == 4294967295U)
					{
						global::Ionic.Zip.ZipFile.Zip64SeekToCentralDirectory(zf);
					}
					else
					{
						zf._OffsetOfCentralDirectory = num4;
						readStream.Seek((long)((ulong)num4), global::System.IO.SeekOrigin.Begin);
					}
					global::Ionic.Zip.ZipFile.ReadCentralDirectory(zf);
				}
				else
				{
					readStream.Seek(0L, global::System.IO.SeekOrigin.Begin);
					global::Ionic.Zip.ZipFile.ReadIntoInstance_Orig(zf);
				}
			}
			catch (global::System.Exception innerException)
			{
				if (zf._ReadStreamIsOurs && zf._readstream != null)
				{
					zf._readstream.Dispose();
					zf._readstream = null;
				}
				throw new global::Ionic.Zip.ZipException("Cannot read that as a ZipFile", innerException);
			}
			zf._contentsChanged = false;
		}

		// Token: 0x060031BB RID: 12731 RVA: 0x000B4BEC File Offset: 0x000B2DEC
		private static void Zip64SeekToCentralDirectory(global::Ionic.Zip.ZipFile zf)
		{
			global::System.IO.Stream readStream = zf.ReadStream;
			byte[] array = new byte[16];
			readStream.Seek(-40L, global::System.IO.SeekOrigin.Current);
			readStream.Read(array, 0, 16);
			long num = global::System.BitConverter.ToInt64(array, 8);
			zf._OffsetOfCentralDirectory = uint.MaxValue;
			zf._OffsetOfCentralDirectory64 = num;
			readStream.Seek(num, global::System.IO.SeekOrigin.Begin);
			uint num2 = (uint)global::Ionic.Zip.SharedUtilities.ReadInt(readStream);
			if (num2 != 101075792U)
			{
				throw new global::Ionic.Zip.BadReadException(string.Format("  Bad signature (0x{0:X8}) looking for ZIP64 EoCD Record at position 0x{1:X8}", num2, readStream.Position));
			}
			readStream.Read(array, 0, 8);
			array = new byte[global::System.BitConverter.ToInt64(array, 0)];
			readStream.Read(array, 0, array.Length);
			num = global::System.BitConverter.ToInt64(array, 36);
			readStream.Seek(num, global::System.IO.SeekOrigin.Begin);
		}

		// Token: 0x060031BC RID: 12732 RVA: 0x000B4CAC File Offset: 0x000B2EAC
		private static uint ReadFirstFourBytes(global::System.IO.Stream s)
		{
			return (uint)global::Ionic.Zip.SharedUtilities.ReadInt(s);
		}

		// Token: 0x060031BD RID: 12733 RVA: 0x000B4CB4 File Offset: 0x000B2EB4
		private static void ReadCentralDirectory(global::Ionic.Zip.ZipFile zf)
		{
			bool flag = false;
			global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
			global::Ionic.Zip.ZipEntry zipEntry;
			while ((zipEntry = global::Ionic.Zip.ZipEntry.ReadDirEntry(zf, dictionary)) != null)
			{
				zipEntry.ResetDirEntry();
				zf.OnReadEntry(true, null);
				if (zf.Verbose)
				{
					zf.StatusMessageTextWriter.WriteLine("entry {0}", zipEntry.FileName);
				}
				zf._entries.Add(zipEntry.FileName, zipEntry);
				if (zipEntry._InputUsesZip64)
				{
					flag = true;
				}
				dictionary.Add(zipEntry.FileName, null);
			}
			if (flag)
			{
				zf.UseZip64WhenSaving = global::Ionic.Zip.Zip64Option.Always;
			}
			if (zf._locEndOfCDS > 0L)
			{
				zf.ReadStream.Seek(zf._locEndOfCDS, global::System.IO.SeekOrigin.Begin);
			}
			global::Ionic.Zip.ZipFile.ReadCentralDirectoryFooter(zf);
			if (zf.Verbose && !string.IsNullOrEmpty(zf.Comment))
			{
				zf.StatusMessageTextWriter.WriteLine("Zip file Comment: {0}", zf.Comment);
			}
			if (zf.Verbose)
			{
				zf.StatusMessageTextWriter.WriteLine("read in {0} entries.", zf._entries.Count);
			}
			zf.OnReadCompleted();
		}

		// Token: 0x060031BE RID: 12734 RVA: 0x000B4DD0 File Offset: 0x000B2FD0
		private static void ReadIntoInstance_Orig(global::Ionic.Zip.ZipFile zf)
		{
			zf.OnReadStarted();
			zf._entries = new global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>();
			if (zf.Verbose)
			{
				if (zf.Name == null)
				{
					zf.StatusMessageTextWriter.WriteLine("Reading zip from stream...");
				}
				else
				{
					zf.StatusMessageTextWriter.WriteLine("Reading zip {0}...", zf.Name);
				}
			}
			bool first = true;
			global::Ionic.Zip.ZipContainer zc = new global::Ionic.Zip.ZipContainer(zf);
			global::Ionic.Zip.ZipEntry zipEntry;
			while ((zipEntry = global::Ionic.Zip.ZipEntry.ReadEntry(zc, first)) != null)
			{
				if (zf.Verbose)
				{
					zf.StatusMessageTextWriter.WriteLine("  {0}", zipEntry.FileName);
				}
				zf._entries.Add(zipEntry.FileName, zipEntry);
				first = false;
			}
			try
			{
				global::System.Collections.Generic.Dictionary<string, object> dictionary = new global::System.Collections.Generic.Dictionary<string, object>();
				global::Ionic.Zip.ZipEntry zipEntry2;
				while ((zipEntry2 = global::Ionic.Zip.ZipEntry.ReadDirEntry(zf, dictionary)) != null)
				{
					global::Ionic.Zip.ZipEntry zipEntry3 = zf._entries[zipEntry2.FileName];
					if (zipEntry3 != null)
					{
						zipEntry3._Comment = zipEntry2.Comment;
						if (zipEntry2.IsDirectory)
						{
							zipEntry3.MarkAsDirectory();
						}
					}
					dictionary.Add(zipEntry2.FileName, null);
				}
				if (zf._locEndOfCDS > 0L)
				{
					zf.ReadStream.Seek(zf._locEndOfCDS, global::System.IO.SeekOrigin.Begin);
				}
				global::Ionic.Zip.ZipFile.ReadCentralDirectoryFooter(zf);
				if (zf.Verbose && !string.IsNullOrEmpty(zf.Comment))
				{
					zf.StatusMessageTextWriter.WriteLine("Zip file Comment: {0}", zf.Comment);
				}
			}
			catch (global::Ionic.Zip.ZipException)
			{
			}
			catch (global::System.IO.IOException)
			{
			}
			zf.OnReadCompleted();
		}

		// Token: 0x060031BF RID: 12735 RVA: 0x000B4F6C File Offset: 0x000B316C
		private static void ReadCentralDirectoryFooter(global::Ionic.Zip.ZipFile zf)
		{
			global::System.IO.Stream readStream = zf.ReadStream;
			int num = global::Ionic.Zip.SharedUtilities.ReadSignature(readStream);
			int num2 = 0;
			byte[] array;
			if ((long)num == 101075792L)
			{
				array = new byte[52];
				readStream.Read(array, 0, array.Length);
				long num3 = global::System.BitConverter.ToInt64(array, 0);
				if (num3 < 44L)
				{
					throw new global::Ionic.Zip.ZipException("Bad size in the ZIP64 Central Directory.");
				}
				zf._versionMadeBy = global::System.BitConverter.ToUInt16(array, num2);
				num2 += 2;
				zf._versionNeededToExtract = global::System.BitConverter.ToUInt16(array, num2);
				num2 += 2;
				zf._diskNumberWithCd = global::System.BitConverter.ToUInt32(array, num2);
				num2 += 2;
				array = new byte[num3 - 44L];
				readStream.Read(array, 0, array.Length);
				num = global::Ionic.Zip.SharedUtilities.ReadSignature(readStream);
				if ((long)num != 117853008L)
				{
					throw new global::Ionic.Zip.ZipException("Inconsistent metadata in the ZIP64 Central Directory.");
				}
				array = new byte[16];
				readStream.Read(array, 0, array.Length);
				num = global::Ionic.Zip.SharedUtilities.ReadSignature(readStream);
			}
			if ((long)num != 101010256L)
			{
				readStream.Seek(-4L, global::System.IO.SeekOrigin.Current);
				throw new global::Ionic.Zip.BadReadException(string.Format("Bad signature ({0:X8}) at position 0x{1:X8}", num, readStream.Position));
			}
			array = new byte[16];
			zf.ReadStream.Read(array, 0, array.Length);
			if (zf._diskNumberWithCd == 0U)
			{
				zf._diskNumberWithCd = (uint)global::System.BitConverter.ToUInt16(array, 2);
			}
			global::Ionic.Zip.ZipFile.ReadZipFileComment(zf);
		}

		// Token: 0x060031C0 RID: 12736 RVA: 0x000B50C0 File Offset: 0x000B32C0
		private static void ReadZipFileComment(global::Ionic.Zip.ZipFile zf)
		{
			byte[] array = new byte[2];
			zf.ReadStream.Read(array, 0, array.Length);
			short num = (short)((int)array[0] + (int)array[1] * 256);
			if (num > 0)
			{
				array = new byte[(int)num];
				zf.ReadStream.Read(array, 0, array.Length);
				string @string = zf.AlternateEncoding.GetString(array, 0, array.Length);
				zf.Comment = @string;
			}
		}

		// Token: 0x060031C1 RID: 12737 RVA: 0x000B5130 File Offset: 0x000B3330
		public static bool IsZipFile(string fileName)
		{
			return global::Ionic.Zip.ZipFile.IsZipFile(fileName, false);
		}

		// Token: 0x060031C2 RID: 12738 RVA: 0x000B513C File Offset: 0x000B333C
		public static bool IsZipFile(string fileName, bool testExtract)
		{
			bool result = false;
			try
			{
				if (!global::System.IO.File.Exists(fileName))
				{
					return false;
				}
				using (global::System.IO.FileStream fileStream = global::System.IO.File.Open(fileName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite))
				{
					result = global::Ionic.Zip.ZipFile.IsZipFile(fileStream, testExtract);
				}
			}
			catch (global::System.IO.IOException)
			{
			}
			catch (global::Ionic.Zip.ZipException)
			{
			}
			return result;
		}

		// Token: 0x060031C3 RID: 12739 RVA: 0x000B51C0 File Offset: 0x000B33C0
		public static bool IsZipFile(global::System.IO.Stream stream, bool testExtract)
		{
			if (stream == null)
			{
				throw new global::System.ArgumentNullException("stream");
			}
			bool result = false;
			try
			{
				if (!stream.CanRead)
				{
					return false;
				}
				global::System.IO.Stream @null = global::System.IO.Stream.Null;
				using (global::Ionic.Zip.ZipFile zipFile = global::Ionic.Zip.ZipFile.Read(stream, null, null, null))
				{
					if (testExtract)
					{
						foreach (global::Ionic.Zip.ZipEntry zipEntry in zipFile)
						{
							if (!zipEntry.IsDirectory)
							{
								zipEntry.Extract(@null);
							}
						}
					}
				}
				result = true;
			}
			catch (global::System.IO.IOException)
			{
			}
			catch (global::Ionic.Zip.ZipException)
			{
			}
			return result;
		}

		// Token: 0x060031C4 RID: 12740 RVA: 0x000B52AC File Offset: 0x000B34AC
		private void DeleteFileWithRetry(string filename)
		{
			bool flag = false;
			int num = 3;
			int num2 = 0;
			while (num2 < num && !flag)
			{
				try
				{
					global::System.IO.File.Delete(filename);
					flag = true;
				}
				catch (global::System.UnauthorizedAccessException)
				{
					global::System.Console.WriteLine("************************************************** Retry delete.");
					global::System.Threading.Thread.Sleep(200 + num2 * 200);
				}
				num2++;
			}
		}

		// Token: 0x060031C5 RID: 12741 RVA: 0x000B5314 File Offset: 0x000B3514
		public void Save()
		{
			try
			{
				bool flag = false;
				this._saveOperationCanceled = false;
				this._numberOfSegmentsForMostRecentSave = 0U;
				this.OnSaveStarted();
				if (this.WriteStream == null)
				{
					throw new global::Ionic.Zip.BadStateException("You haven't specified where to save the zip.");
				}
				if (this._name != null && this._name.EndsWith(".exe") && !this._SavingSfx)
				{
					throw new global::Ionic.Zip.BadStateException("You specified an EXE for a plain zip file.");
				}
				if (!this._contentsChanged)
				{
					this.OnSaveCompleted();
					if (this.Verbose)
					{
						this.StatusMessageTextWriter.WriteLine("No save is necessary....");
					}
					return;
				}
				this.Reset(true);
				if (this.Verbose)
				{
					this.StatusMessageTextWriter.WriteLine("saving....");
				}
				if (this._entries.Count >= 65535 && this._zip64 == global::Ionic.Zip.Zip64Option.Default)
				{
					throw new global::Ionic.Zip.ZipException("The number of entries is 65535 or greater. Consider setting the UseZip64WhenSaving property on the ZipFile instance.");
				}
				int num = 0;
				global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> collection = this.SortEntriesBeforeSaving ? this.EntriesSorted : this.Entries;
				foreach (global::Ionic.Zip.ZipEntry zipEntry in collection)
				{
					this.OnSaveEntry(num, zipEntry, true);
					zipEntry.Write(this.WriteStream);
					if (this._saveOperationCanceled)
					{
						break;
					}
					num++;
					this.OnSaveEntry(num, zipEntry, false);
					if (this._saveOperationCanceled)
					{
						break;
					}
					if (zipEntry.IncludedInMostRecentSave)
					{
						flag |= zipEntry.OutputUsedZip64.Value;
					}
				}
				if (this._saveOperationCanceled)
				{
					return;
				}
				global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream = this.WriteStream as global::Ionic.Zip.ZipSegmentedStream;
				this._numberOfSegmentsForMostRecentSave = ((zipSegmentedStream != null) ? zipSegmentedStream.CurrentSegment : 1U);
				bool flag2 = global::Ionic.Zip.ZipOutput.WriteCentralDirectoryStructure(this.WriteStream, collection, this._numberOfSegmentsForMostRecentSave, this._zip64, this.Comment, new global::Ionic.Zip.ZipContainer(this));
				this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_AfterSaveTempArchive);
				this._hasBeenSaved = true;
				this._contentsChanged = false;
				flag = (flag || flag2);
				this._OutputUsesZip64 = new bool?(flag);
				if (this._name != null && (this._temporaryFileName != null || zipSegmentedStream != null))
				{
					this.WriteStream.Dispose();
					if (this._saveOperationCanceled)
					{
						return;
					}
					if (this._fileAlreadyExists && this._readstream != null)
					{
						this._readstream.Close();
						this._readstream = null;
						foreach (global::Ionic.Zip.ZipEntry zipEntry2 in collection)
						{
							global::Ionic.Zip.ZipSegmentedStream zipSegmentedStream2 = zipEntry2._archiveStream as global::Ionic.Zip.ZipSegmentedStream;
							if (zipSegmentedStream2 != null)
							{
								zipSegmentedStream2.Dispose();
							}
							zipEntry2._archiveStream = null;
						}
					}
					string text = null;
					if (global::System.IO.File.Exists(this._name))
					{
						text = this._name + "." + global::System.IO.Path.GetRandomFileName();
						if (global::System.IO.File.Exists(text))
						{
							this.DeleteFileWithRetry(text);
						}
						global::System.IO.File.Move(this._name, text);
					}
					this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_BeforeRenameTempArchive);
					global::System.IO.File.Move((zipSegmentedStream != null) ? zipSegmentedStream.CurrentTempName : this._temporaryFileName, this._name);
					this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_AfterRenameTempArchive);
					if (text != null)
					{
						try
						{
							if (global::System.IO.File.Exists(text))
							{
								global::System.IO.File.Delete(text);
							}
						}
						catch
						{
						}
					}
					this._fileAlreadyExists = true;
				}
				global::Ionic.Zip.ZipFile.NotifyEntriesSaveComplete(collection);
				this.OnSaveCompleted();
				this._JustSaved = true;
			}
			finally
			{
				this.CleanupAfterSaveOperation();
			}
		}

		// Token: 0x060031C6 RID: 12742 RVA: 0x000B5714 File Offset: 0x000B3914
		private static void NotifyEntriesSaveComplete(global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> c)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in c)
			{
				zipEntry.NotifySaveComplete();
			}
		}

		// Token: 0x060031C7 RID: 12743 RVA: 0x000B5764 File Offset: 0x000B3964
		private void RemoveTempFile()
		{
			try
			{
				if (global::System.IO.File.Exists(this._temporaryFileName))
				{
					global::System.IO.File.Delete(this._temporaryFileName);
				}
			}
			catch (global::System.IO.IOException ex)
			{
				if (this.Verbose)
				{
					this.StatusMessageTextWriter.WriteLine("ZipFile::Save: could not delete temp file: {0}.", ex.Message);
				}
			}
		}

		// Token: 0x060031C8 RID: 12744 RVA: 0x000B57C8 File Offset: 0x000B39C8
		private void CleanupAfterSaveOperation()
		{
			if (this._name != null)
			{
				if (this._writestream != null)
				{
					try
					{
						this._writestream.Dispose();
					}
					catch (global::System.IO.IOException)
					{
					}
				}
				this._writestream = null;
				if (this._temporaryFileName != null)
				{
					this.RemoveTempFile();
					this._temporaryFileName = null;
				}
			}
		}

		// Token: 0x060031C9 RID: 12745 RVA: 0x000B5830 File Offset: 0x000B3A30
		public void Save(string fileName)
		{
			if (this._name == null)
			{
				this._writestream = null;
			}
			else
			{
				this._readName = this._name;
			}
			this._name = fileName;
			if (global::System.IO.Directory.Exists(this._name))
			{
				throw new global::Ionic.Zip.ZipException("Bad Directory", new global::System.ArgumentException("That name specifies an existing directory. Please specify a filename.", "fileName"));
			}
			this._contentsChanged = true;
			this._fileAlreadyExists = global::System.IO.File.Exists(this._name);
			this.Save();
		}

		// Token: 0x060031CA RID: 12746 RVA: 0x000B58B4 File Offset: 0x000B3AB4
		public void Save(global::System.IO.Stream outputStream)
		{
			if (outputStream == null)
			{
				throw new global::System.ArgumentNullException("outputStream");
			}
			if (!outputStream.CanWrite)
			{
				throw new global::System.ArgumentException("Must be a writable stream.", "outputStream");
			}
			this._name = null;
			this._writestream = new global::Ionic.Zip.CountingStream(outputStream);
			this._contentsChanged = true;
			this._fileAlreadyExists = false;
			this.Save();
		}

		// Token: 0x060031CB RID: 12747 RVA: 0x000B5918 File Offset: 0x000B3B18
		public void SaveSelfExtractor(string exeToGenerate, global::Ionic.Zip.SelfExtractorFlavor flavor)
		{
			this.SaveSelfExtractor(exeToGenerate, new global::Ionic.Zip.SelfExtractorSaveOptions
			{
				Flavor = flavor
			});
		}

		// Token: 0x060031CC RID: 12748 RVA: 0x000B5940 File Offset: 0x000B3B40
		public void SaveSelfExtractor(string exeToGenerate, global::Ionic.Zip.SelfExtractorSaveOptions options)
		{
			if (this._name == null)
			{
				this._writestream = null;
			}
			this._SavingSfx = true;
			this._name = exeToGenerate;
			if (global::System.IO.Directory.Exists(this._name))
			{
				throw new global::Ionic.Zip.ZipException("Bad Directory", new global::System.ArgumentException("That name specifies an existing directory. Please specify a filename.", "exeToGenerate"));
			}
			this._contentsChanged = true;
			this._fileAlreadyExists = global::System.IO.File.Exists(this._name);
			this._SaveSfxStub(exeToGenerate, options);
			this.Save();
			this._SavingSfx = false;
		}

		// Token: 0x060031CD RID: 12749 RVA: 0x000B59C8 File Offset: 0x000B3BC8
		private static void ExtractResourceToFile(global::System.Reflection.Assembly a, string resourceName, string filename)
		{
			byte[] array = new byte[1024];
			using (global::System.IO.Stream manifestResourceStream = a.GetManifestResourceStream(resourceName))
			{
				if (manifestResourceStream == null)
				{
					throw new global::Ionic.Zip.ZipException(string.Format("missing resource '{0}'", resourceName));
				}
				using (global::System.IO.FileStream fileStream = global::System.IO.File.OpenWrite(filename))
				{
					int num;
					do
					{
						num = manifestResourceStream.Read(array, 0, array.Length);
						fileStream.Write(array, 0, num);
					}
					while (num > 0);
				}
			}
		}

		// Token: 0x060031CE RID: 12750 RVA: 0x000B5A5C File Offset: 0x000B3C5C
		private void _SaveSfxStub(string exeToGenerate, global::Ionic.Zip.SelfExtractorSaveOptions options)
		{
			string text = null;
			string text2 = null;
			string dir = null;
			try
			{
				if (global::System.IO.File.Exists(exeToGenerate) && this.Verbose)
				{
					this.StatusMessageTextWriter.WriteLine("The existing file ({0}) will be overwritten.", exeToGenerate);
				}
				if (!exeToGenerate.EndsWith(".exe") && this.Verbose)
				{
					this.StatusMessageTextWriter.WriteLine("Warning: The generated self-extracting file will not have an .exe extension.");
				}
				dir = (this.TempFileFolder ?? global::System.IO.Path.GetDirectoryName(exeToGenerate));
				text = global::Ionic.Zip.ZipFile.GenerateTempPathname(dir, "exe");
				global::System.Reflection.Assembly assembly = typeof(global::Ionic.Zip.ZipFile).Assembly;
				using (global::Microsoft.CSharp.CSharpCodeProvider csharpCodeProvider = new global::Microsoft.CSharp.CSharpCodeProvider())
				{
					global::Ionic.Zip.ZipFile.ExtractorSettings extractorSettings = null;
					foreach (global::Ionic.Zip.ZipFile.ExtractorSettings extractorSettings2 in global::Ionic.Zip.ZipFile.SettingsList)
					{
						if (extractorSettings2.Flavor == options.Flavor)
						{
							extractorSettings = extractorSettings2;
							break;
						}
					}
					if (extractorSettings == null)
					{
						throw new global::Ionic.Zip.BadStateException(string.Format("While saving a Self-Extracting Zip, Cannot find that flavor ({0})?", options.Flavor));
					}
					global::System.CodeDom.Compiler.CompilerParameters compilerParameters = new global::System.CodeDom.Compiler.CompilerParameters();
					compilerParameters.ReferencedAssemblies.Add(assembly.Location);
					if (extractorSettings.ReferencedAssemblies != null)
					{
						foreach (string value in extractorSettings.ReferencedAssemblies)
						{
							compilerParameters.ReferencedAssemblies.Add(value);
						}
					}
					compilerParameters.GenerateInMemory = false;
					compilerParameters.GenerateExecutable = true;
					compilerParameters.IncludeDebugInformation = false;
					compilerParameters.CompilerOptions = "";
					global::System.Reflection.Assembly executingAssembly = global::System.Reflection.Assembly.GetExecutingAssembly();
					global::System.Text.StringBuilder stringBuilder = new global::System.Text.StringBuilder();
					string text3 = global::Ionic.Zip.ZipFile.GenerateTempPathname(dir, "cs");
					using (global::Ionic.Zip.ZipFile zipFile = global::Ionic.Zip.ZipFile.Read(executingAssembly.GetManifestResourceStream("Ionic.Zip.Resources.ZippedResources.zip")))
					{
						text2 = global::Ionic.Zip.ZipFile.GenerateTempPathname(dir, "tmp");
						if (string.IsNullOrEmpty(options.IconFile))
						{
							global::System.IO.Directory.CreateDirectory(text2);
							global::Ionic.Zip.ZipEntry zipEntry = zipFile["zippedFile.ico"];
							if ((zipEntry.Attributes & global::System.IO.FileAttributes.ReadOnly) == global::System.IO.FileAttributes.ReadOnly)
							{
								zipEntry.Attributes ^= global::System.IO.FileAttributes.ReadOnly;
							}
							zipEntry.Extract(text2);
							string arg = global::System.IO.Path.Combine(text2, "zippedFile.ico");
							global::System.CodeDom.Compiler.CompilerParameters compilerParameters2 = compilerParameters;
							compilerParameters2.CompilerOptions += string.Format("/win32icon:\"{0}\"", arg);
						}
						else
						{
							global::System.CodeDom.Compiler.CompilerParameters compilerParameters3 = compilerParameters;
							compilerParameters3.CompilerOptions += string.Format("/win32icon:\"{0}\"", options.IconFile);
						}
						compilerParameters.OutputAssembly = text;
						if (options.Flavor == global::Ionic.Zip.SelfExtractorFlavor.WinFormsApplication)
						{
							global::System.CodeDom.Compiler.CompilerParameters compilerParameters4 = compilerParameters;
							compilerParameters4.CompilerOptions += " /target:winexe";
						}
						if (!string.IsNullOrEmpty(options.AdditionalCompilerSwitches))
						{
							global::System.CodeDom.Compiler.CompilerParameters compilerParameters5 = compilerParameters;
							compilerParameters5.CompilerOptions = compilerParameters5.CompilerOptions + " " + options.AdditionalCompilerSwitches;
						}
						if (string.IsNullOrEmpty(compilerParameters.CompilerOptions))
						{
							compilerParameters.CompilerOptions = null;
						}
						if (extractorSettings.CopyThroughResources != null && extractorSettings.CopyThroughResources.Count != 0)
						{
							if (!global::System.IO.Directory.Exists(text2))
							{
								global::System.IO.Directory.CreateDirectory(text2);
							}
							foreach (string text4 in extractorSettings.CopyThroughResources)
							{
								string text5 = global::System.IO.Path.Combine(text2, text4);
								global::Ionic.Zip.ZipFile.ExtractResourceToFile(executingAssembly, text4, text5);
								compilerParameters.EmbeddedResources.Add(text5);
							}
						}
						compilerParameters.EmbeddedResources.Add(assembly.Location);
						stringBuilder.Append("// " + global::System.IO.Path.GetFileName(text3) + "\n").Append("// --------------------------------------------\n//\n").Append("// This SFX source file was generated by DotNetZip ").Append(global::Ionic.Zip.ZipFile.LibraryVersion.ToString()).Append("\n//         at ").Append(global::System.DateTime.Now.ToString("yyyy MMMM dd  HH:mm:ss")).Append("\n//\n// --------------------------------------------\n\n\n");
						if (!string.IsNullOrEmpty(options.Description))
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"" + options.Description.Replace("\"", "") + "\")]\n");
						}
						else
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyTitle(\"DotNetZip SFX Archive\")]\n");
						}
						if (!string.IsNullOrEmpty(options.ProductVersion))
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyInformationalVersion(\"" + options.ProductVersion.Replace("\"", "") + "\")]\n");
						}
						string str = string.IsNullOrEmpty(options.Copyright) ? "Extractor: Copyright © Dino Chiesa 2008-2011" : options.Copyright.Replace("\"", "");
						if (!string.IsNullOrEmpty(options.ProductName))
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"").Append(options.ProductName.Replace("\"", "")).Append("\")]\n");
						}
						else
						{
							stringBuilder.Append("[assembly: System.Reflection.AssemblyProduct(\"DotNetZip\")]\n");
						}
						stringBuilder.Append("[assembly: System.Reflection.AssemblyCopyright(\"" + str + "\")]\n").Append(string.Format("[assembly: System.Reflection.AssemblyVersion(\"{0}\")]\n", global::Ionic.Zip.ZipFile.LibraryVersion.ToString()));
						if (options.FileVersion != null)
						{
							stringBuilder.Append(string.Format("[assembly: System.Reflection.AssemblyFileVersion(\"{0}\")]\n", options.FileVersion.ToString()));
						}
						stringBuilder.Append("\n\n\n");
						string text6 = options.DefaultExtractDirectory;
						if (text6 != null)
						{
							text6 = text6.Replace("\"", "").Replace("\\", "\\\\");
						}
						string text7 = options.PostExtractCommandLine;
						if (text7 != null)
						{
							text7 = text7.Replace("\\", "\\\\");
							text7 = text7.Replace("\"", "\\\"");
						}
						foreach (string text8 in extractorSettings.ResourcesToCompile)
						{
							using (global::System.IO.Stream stream = zipFile[text8].OpenReader())
							{
								if (stream == null)
								{
									throw new global::Ionic.Zip.ZipException(string.Format("missing resource '{0}'", text8));
								}
								using (global::System.IO.StreamReader streamReader = new global::System.IO.StreamReader(stream))
								{
									while (streamReader.Peek() >= 0)
									{
										string text9 = streamReader.ReadLine();
										if (text6 != null)
										{
											text9 = text9.Replace("@@EXTRACTLOCATION", text6);
										}
										text9 = text9.Replace("@@REMOVE_AFTER_EXECUTE", options.RemoveUnpackedFilesAfterExecute.ToString());
										text9 = text9.Replace("@@QUIET", options.Quiet.ToString());
										if (!string.IsNullOrEmpty(options.SfxExeWindowTitle))
										{
											text9 = text9.Replace("@@SFX_EXE_WINDOW_TITLE", options.SfxExeWindowTitle);
										}
										text9 = text9.Replace("@@EXTRACT_EXISTING_FILE", ((int)options.ExtractExistingFile).ToString());
										if (text7 != null)
										{
											text9 = text9.Replace("@@POST_UNPACK_CMD_LINE", text7);
										}
										stringBuilder.Append(text9).Append("\n");
									}
								}
								stringBuilder.Append("\n\n");
							}
						}
					}
					string text10 = stringBuilder.ToString();
					global::System.CodeDom.Compiler.CompilerResults compilerResults = csharpCodeProvider.CompileAssemblyFromSource(compilerParameters, new string[]
					{
						text10
					});
					if (compilerResults == null)
					{
						throw new global::Ionic.Zip.SfxGenerationException("Cannot compile the extraction logic!");
					}
					if (this.Verbose)
					{
						foreach (string value2 in compilerResults.Output)
						{
							this.StatusMessageTextWriter.WriteLine(value2);
						}
					}
					if (compilerResults.Errors.Count != 0)
					{
						using (global::System.IO.TextWriter textWriter = new global::System.IO.StreamWriter(text3))
						{
							textWriter.Write(text10);
							textWriter.Write("\n\n\n// ------------------------------------------------------------------\n");
							textWriter.Write("// Errors during compilation: \n//\n");
							string fileName = global::System.IO.Path.GetFileName(text3);
							foreach (object obj in compilerResults.Errors)
							{
								global::System.CodeDom.Compiler.CompilerError compilerError = (global::System.CodeDom.Compiler.CompilerError)obj;
								textWriter.Write(string.Format("//   {0}({1},{2}): {3} {4}: {5}\n//\n", new object[]
								{
									fileName,
									compilerError.Line,
									compilerError.Column,
									compilerError.IsWarning ? "Warning" : "error",
									compilerError.ErrorNumber,
									compilerError.ErrorText
								}));
							}
						}
						throw new global::Ionic.Zip.SfxGenerationException(string.Format("Errors compiling the extraction logic!  {0}", text3));
					}
					this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_AfterCompileSelfExtractor);
					using (global::System.IO.Stream stream2 = global::System.IO.File.OpenRead(text))
					{
						byte[] array = new byte[4000];
						int num = 1;
						while (num != 0)
						{
							num = stream2.Read(array, 0, array.Length);
							if (num != 0)
							{
								this.WriteStream.Write(array, 0, num);
							}
						}
					}
				}
				this.OnSaveEvent(global::Ionic.Zip.ZipProgressEventType.Saving_AfterSaveTempArchive);
			}
			finally
			{
				try
				{
					if (global::System.IO.Directory.Exists(text2))
					{
						try
						{
							global::System.IO.Directory.Delete(text2, true);
						}
						catch (global::System.IO.IOException arg2)
						{
							this.StatusMessageTextWriter.WriteLine("Warning: Exception: {0}", arg2);
						}
					}
					if (global::System.IO.File.Exists(text))
					{
						try
						{
							global::System.IO.File.Delete(text);
						}
						catch (global::System.IO.IOException arg3)
						{
							this.StatusMessageTextWriter.WriteLine("Warning: Exception: {0}", arg3);
						}
					}
				}
				catch (global::System.IO.IOException)
				{
				}
			}
		}

		// Token: 0x060031CF RID: 12751 RVA: 0x000B65B0 File Offset: 0x000B47B0
		internal static string GenerateTempPathname(string dir, string extension)
		{
			string name = global::System.Reflection.Assembly.GetExecutingAssembly().GetName().Name;
			string text2;
			do
			{
				string text = global::System.Guid.NewGuid().ToString();
				string path = string.Format("{0}-{1}-{2}.{3}", new object[]
				{
					name,
					global::System.DateTime.Now.ToString("yyyyMMMdd-HHmmss"),
					text,
					extension
				});
				text2 = global::System.IO.Path.Combine(dir, path);
			}
			while (global::System.IO.File.Exists(text2) || global::System.IO.Directory.Exists(text2));
			return text2;
		}

		// Token: 0x060031D0 RID: 12752 RVA: 0x000B6638 File Offset: 0x000B4838
		public void AddSelectedFiles(string selectionCriteria)
		{
			this.AddSelectedFiles(selectionCriteria, ".", null, false);
		}

		// Token: 0x060031D1 RID: 12753 RVA: 0x000B6648 File Offset: 0x000B4848
		public void AddSelectedFiles(string selectionCriteria, bool recurseDirectories)
		{
			this.AddSelectedFiles(selectionCriteria, ".", null, recurseDirectories);
		}

		// Token: 0x060031D2 RID: 12754 RVA: 0x000B6658 File Offset: 0x000B4858
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk)
		{
			this.AddSelectedFiles(selectionCriteria, directoryOnDisk, null, false);
		}

		// Token: 0x060031D3 RID: 12755 RVA: 0x000B6664 File Offset: 0x000B4864
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, bool recurseDirectories)
		{
			this.AddSelectedFiles(selectionCriteria, directoryOnDisk, null, recurseDirectories);
		}

		// Token: 0x060031D4 RID: 12756 RVA: 0x000B6670 File Offset: 0x000B4870
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive)
		{
			this.AddSelectedFiles(selectionCriteria, directoryOnDisk, directoryPathInArchive, false);
		}

		// Token: 0x060031D5 RID: 12757 RVA: 0x000B667C File Offset: 0x000B487C
		public void AddSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
		{
			this._AddOrUpdateSelectedFiles(selectionCriteria, directoryOnDisk, directoryPathInArchive, recurseDirectories, false);
		}

		// Token: 0x060031D6 RID: 12758 RVA: 0x000B668C File Offset: 0x000B488C
		public void UpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories)
		{
			this._AddOrUpdateSelectedFiles(selectionCriteria, directoryOnDisk, directoryPathInArchive, recurseDirectories, true);
		}

		// Token: 0x060031D7 RID: 12759 RVA: 0x000B669C File Offset: 0x000B489C
		private string EnsureendInSlash(string s)
		{
			if (s.EndsWith("\\"))
			{
				return s;
			}
			return s + "\\";
		}

		// Token: 0x060031D8 RID: 12760 RVA: 0x000B66BC File Offset: 0x000B48BC
		private void _AddOrUpdateSelectedFiles(string selectionCriteria, string directoryOnDisk, string directoryPathInArchive, bool recurseDirectories, bool wantUpdate)
		{
			if (directoryOnDisk == null && global::System.IO.Directory.Exists(selectionCriteria))
			{
				directoryOnDisk = selectionCriteria;
				selectionCriteria = "*.*";
			}
			else if (string.IsNullOrEmpty(directoryOnDisk))
			{
				directoryOnDisk = ".";
			}
			while (directoryOnDisk.EndsWith("\\"))
			{
				directoryOnDisk = directoryOnDisk.Substring(0, directoryOnDisk.Length - 1);
			}
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("adding selection '{0}' from dir '{1}'...", selectionCriteria, directoryOnDisk);
			}
			global::System.Collections.ObjectModel.ReadOnlyCollection<string> readOnlyCollection = new global::Ionic.FileSelector(selectionCriteria, this.AddDirectoryWillTraverseReparsePoints).SelectFiles(directoryOnDisk, recurseDirectories);
			if (this.Verbose)
			{
				this.StatusMessageTextWriter.WriteLine("found {0} files...", readOnlyCollection.Count);
			}
			this.OnAddStarted();
			global::Ionic.Zip.AddOrUpdateAction action = wantUpdate ? global::Ionic.Zip.AddOrUpdateAction.AddOrUpdate : global::Ionic.Zip.AddOrUpdateAction.AddOnly;
			foreach (string text in readOnlyCollection)
			{
				string text2 = (directoryPathInArchive == null) ? null : global::Ionic.Zip.ZipFile.ReplaceLeadingDirectory(global::System.IO.Path.GetDirectoryName(text), directoryOnDisk, directoryPathInArchive);
				if (global::System.IO.File.Exists(text))
				{
					if (wantUpdate)
					{
						this.UpdateFile(text, text2);
					}
					else
					{
						this.AddFile(text, text2);
					}
				}
				else
				{
					this.AddOrUpdateDirectoryImpl(text, text2, action, false, 0);
				}
			}
			this.OnAddCompleted();
		}

		// Token: 0x060031D9 RID: 12761 RVA: 0x000B6828 File Offset: 0x000B4A28
		private static string ReplaceLeadingDirectory(string original, string pattern, string replacement)
		{
			string text = original.ToUpper();
			string text2 = pattern.ToUpper();
			if (text.IndexOf(text2) != 0)
			{
				return original;
			}
			return replacement + original.Substring(text2.Length);
		}

		// Token: 0x060031DA RID: 12762 RVA: 0x000B6868 File Offset: 0x000B4A68
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> SelectEntries(string selectionCriteria)
		{
			return new global::Ionic.FileSelector(selectionCriteria, this.AddDirectoryWillTraverseReparsePoints).SelectEntries(this);
		}

		// Token: 0x060031DB RID: 12763 RVA: 0x000B687C File Offset: 0x000B4A7C
		public global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> SelectEntries(string selectionCriteria, string directoryPathInArchive)
		{
			return new global::Ionic.FileSelector(selectionCriteria, this.AddDirectoryWillTraverseReparsePoints).SelectEntries(this, directoryPathInArchive);
		}

		// Token: 0x060031DC RID: 12764 RVA: 0x000B6894 File Offset: 0x000B4A94
		public int RemoveSelectedEntries(string selectionCriteria)
		{
			global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> collection = this.SelectEntries(selectionCriteria);
			this.RemoveEntries(collection);
			return collection.Count;
		}

		// Token: 0x060031DD RID: 12765 RVA: 0x000B68BC File Offset: 0x000B4ABC
		public int RemoveSelectedEntries(string selectionCriteria, string directoryPathInArchive)
		{
			global::System.Collections.Generic.ICollection<global::Ionic.Zip.ZipEntry> collection = this.SelectEntries(selectionCriteria, directoryPathInArchive);
			this.RemoveEntries(collection);
			return collection.Count;
		}

		// Token: 0x060031DE RID: 12766 RVA: 0x000B68E4 File Offset: 0x000B4AE4
		public void ExtractSelectedEntries(string selectionCriteria)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract();
			}
		}

		// Token: 0x060031DF RID: 12767 RVA: 0x000B6944 File Offset: 0x000B4B44
		public void ExtractSelectedEntries(string selectionCriteria, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract(extractExistingFile);
			}
		}

		// Token: 0x060031E0 RID: 12768 RVA: 0x000B69A8 File Offset: 0x000B4BA8
		public void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria, directoryPathInArchive))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract();
			}
		}

		// Token: 0x060031E1 RID: 12769 RVA: 0x000B6A0C File Offset: 0x000B4C0C
		public void ExtractSelectedEntries(string selectionCriteria, string directoryInArchive, string extractDirectory)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria, directoryInArchive))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract(extractDirectory);
			}
		}

		// Token: 0x060031E2 RID: 12770 RVA: 0x000B6A70 File Offset: 0x000B4C70
		public void ExtractSelectedEntries(string selectionCriteria, string directoryPathInArchive, string extractDirectory, global::Ionic.Zip.ExtractExistingFileAction extractExistingFile)
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this.SelectEntries(selectionCriteria, directoryPathInArchive))
			{
				zipEntry.Password = this._Password;
				zipEntry.Extract(extractDirectory, extractExistingFile);
			}
		}

		// Token: 0x060031E3 RID: 12771 RVA: 0x000B6AD4 File Offset: 0x000B4CD4
		public global::System.Collections.Generic.IEnumerator<global::Ionic.Zip.ZipEntry> GetEnumerator()
		{
			foreach (global::Ionic.Zip.ZipEntry zipEntry in this._entries.Values)
			{
				yield return zipEntry;
			}
			global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>.ValueCollection.Enumerator enumerator = default(global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry>.ValueCollection.Enumerator);
			yield break;
			yield break;
		}

		// Token: 0x060031E4 RID: 12772 RVA: 0x000B6AE4 File Offset: 0x000B4CE4
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x060031E5 RID: 12773 RVA: 0x000B6AEC File Offset: 0x000B4CEC
		[global::System.Runtime.InteropServices.DispId(-4)]
		public global::System.Collections.IEnumerator GetNewEnum()
		{
			return this.GetEnumerator();
		}

		// Token: 0x0400122D RID: 4653
		private global::System.IO.TextWriter _StatusMessageTextWriter;

		// Token: 0x0400122E RID: 4654
		private bool _CaseSensitiveRetrieval;

		// Token: 0x0400122F RID: 4655
		private global::System.IO.Stream _readstream;

		// Token: 0x04001230 RID: 4656
		private global::System.IO.Stream _writestream;

		// Token: 0x04001231 RID: 4657
		private ushort _versionMadeBy;

		// Token: 0x04001232 RID: 4658
		private ushort _versionNeededToExtract;

		// Token: 0x04001233 RID: 4659
		private uint _diskNumberWithCd;

		// Token: 0x04001234 RID: 4660
		private int _maxOutputSegmentSize;

		// Token: 0x04001235 RID: 4661
		private uint _numberOfSegmentsForMostRecentSave;

		// Token: 0x04001236 RID: 4662
		private global::Ionic.Zip.ZipErrorAction _zipErrorAction;

		// Token: 0x04001237 RID: 4663
		private bool _disposed;

		// Token: 0x04001238 RID: 4664
		private global::System.Collections.Generic.Dictionary<string, global::Ionic.Zip.ZipEntry> _entries;

		// Token: 0x04001239 RID: 4665
		private global::System.Collections.Generic.List<global::Ionic.Zip.ZipEntry> _zipEntriesAsList;

		// Token: 0x0400123A RID: 4666
		private string _name;

		// Token: 0x0400123B RID: 4667
		private string _readName;

		// Token: 0x0400123C RID: 4668
		private string _Comment;

		// Token: 0x0400123D RID: 4669
		internal string _Password;

		// Token: 0x0400123E RID: 4670
		private bool _emitNtfsTimes = true;

		// Token: 0x0400123F RID: 4671
		private bool _emitUnixTimes;

		// Token: 0x04001240 RID: 4672
		private global::Ionic.Zlib.CompressionStrategy _Strategy;

		// Token: 0x04001241 RID: 4673
		private global::Ionic.Zip.CompressionMethod _compressionMethod = global::Ionic.Zip.CompressionMethod.Deflate;

		// Token: 0x04001242 RID: 4674
		private bool _fileAlreadyExists;

		// Token: 0x04001243 RID: 4675
		private string _temporaryFileName;

		// Token: 0x04001244 RID: 4676
		private bool _contentsChanged;

		// Token: 0x04001245 RID: 4677
		private bool _hasBeenSaved;

		// Token: 0x04001246 RID: 4678
		private string _TempFileFolder;

		// Token: 0x04001247 RID: 4679
		private bool _ReadStreamIsOurs = true;

		// Token: 0x04001248 RID: 4680
		private object LOCK = new object();

		// Token: 0x04001249 RID: 4681
		private bool _saveOperationCanceled;

		// Token: 0x0400124A RID: 4682
		private bool _extractOperationCanceled;

		// Token: 0x0400124B RID: 4683
		private bool _addOperationCanceled;

		// Token: 0x0400124C RID: 4684
		private global::Ionic.Zip.EncryptionAlgorithm _Encryption;

		// Token: 0x0400124D RID: 4685
		private bool _JustSaved;

		// Token: 0x0400124E RID: 4686
		private long _locEndOfCDS = -1L;

		// Token: 0x0400124F RID: 4687
		private uint _OffsetOfCentralDirectory;

		// Token: 0x04001250 RID: 4688
		private long _OffsetOfCentralDirectory64;

		// Token: 0x04001251 RID: 4689
		private bool? _OutputUsesZip64;

		// Token: 0x04001252 RID: 4690
		internal bool _inExtractAll;

		// Token: 0x04001253 RID: 4691
		private global::System.Text.Encoding _alternateEncoding = global::System.Text.Encoding.GetEncoding("IBM437");

		// Token: 0x04001254 RID: 4692
		private global::Ionic.Zip.ZipOption _alternateEncodingUsage;

		// Token: 0x04001255 RID: 4693
		private static global::System.Text.Encoding _defaultEncoding = global::System.Text.Encoding.GetEncoding("IBM437");

		// Token: 0x04001256 RID: 4694
		private int _BufferSize = global::Ionic.Zip.ZipFile.BufferSizeDefault;

		// Token: 0x04001257 RID: 4695
		internal global::Ionic.Zlib.ParallelDeflateOutputStream ParallelDeflater;

		// Token: 0x04001258 RID: 4696
		private long _ParallelDeflateThreshold;

		// Token: 0x04001259 RID: 4697
		private int _maxBufferPairs = 16;

		// Token: 0x0400125A RID: 4698
		internal global::Ionic.Zip.Zip64Option _zip64;

		// Token: 0x0400125B RID: 4699
		private bool _SavingSfx;

		// Token: 0x0400125C RID: 4700
		public static readonly int BufferSizeDefault = 32768;

		// Token: 0x0400125F RID: 4703
		private long _lengthOfReadStream = -99L;

		// Token: 0x04001263 RID: 4707
		private static global::Ionic.Zip.ZipFile.ExtractorSettings[] SettingsList = new global::Ionic.Zip.ZipFile.ExtractorSettings[]
		{
			new global::Ionic.Zip.ZipFile.ExtractorSettings
			{
				Flavor = global::Ionic.Zip.SelfExtractorFlavor.WinFormsApplication,
				ReferencedAssemblies = new global::System.Collections.Generic.List<string>
				{
					"System.dll",
					"System.Windows.Forms.dll",
					"System.Drawing.dll"
				},
				CopyThroughResources = new global::System.Collections.Generic.List<string>
				{
					"Ionic.Zip.WinFormsSelfExtractorStub.resources",
					"Ionic.Zip.Forms.PasswordDialog.resources",
					"Ionic.Zip.Forms.ZipContentsDialog.resources"
				},
				ResourcesToCompile = new global::System.Collections.Generic.List<string>
				{
					"WinFormsSelfExtractorStub.cs",
					"WinFormsSelfExtractorStub.Designer.cs",
					"PasswordDialog.cs",
					"PasswordDialog.Designer.cs",
					"ZipContentsDialog.cs",
					"ZipContentsDialog.Designer.cs",
					"FolderBrowserDialogEx.cs"
				}
			},
			new global::Ionic.Zip.ZipFile.ExtractorSettings
			{
				Flavor = global::Ionic.Zip.SelfExtractorFlavor.ConsoleApplication,
				ReferencedAssemblies = new global::System.Collections.Generic.List<string>
				{
					"System.dll"
				},
				CopyThroughResources = null,
				ResourcesToCompile = new global::System.Collections.Generic.List<string>
				{
					"CommandLineSelfExtractorStub.cs"
				}
			}
		};

		// Token: 0x020004EA RID: 1258
		private class ExtractorSettings
		{
			// Token: 0x04001469 RID: 5225
			public global::Ionic.Zip.SelfExtractorFlavor Flavor;

			// Token: 0x0400146A RID: 5226
			public global::System.Collections.Generic.List<string> ReferencedAssemblies;

			// Token: 0x0400146B RID: 5227
			public global::System.Collections.Generic.List<string> CopyThroughResources;

			// Token: 0x0400146C RID: 5228
			public global::System.Collections.Generic.List<string> ResourcesToCompile;
		}
	}
}
