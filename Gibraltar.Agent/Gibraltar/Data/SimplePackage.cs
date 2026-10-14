using System;
using System.Collections.Generic;
using System.IO;
using Gibraltar.Monitor;
using Ionic.Crc;
using Ionic.Zip;
using Ionic.Zlib;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data
{
	// Token: 0x02000254 RID: 596
	internal class SimplePackage : global::System.IDisposable
	{
		// Token: 0x06001DCE RID: 7630 RVA: 0x00069CE8 File Offset: 0x00067EE8
		public SimplePackage()
		{
			this.Caption = "New Package";
			this.OnInitialize();
		}

		// Token: 0x06001DCF RID: 7631 RVA: 0x00069D18 File Offset: 0x00067F18
		public SimplePackage(string fileNamePath)
		{
			if (string.IsNullOrEmpty(fileNamePath))
			{
				throw new global::System.ArgumentNullException("fileNamePath", "Unable to create package from file because no file was specified.");
			}
			if (!global::System.IO.File.Exists(fileNamePath))
			{
				throw new global::System.IO.FileNotFoundException("No existing package could be found with the provided file name", fileNamePath);
			}
			this.m_Archive = new global::Ionic.Zip.ZipFile(fileNamePath);
			this.m_Archive.ParallelDeflateThreshold = -1L;
			this.m_FileNamePath = fileNamePath;
			this.Caption = global::System.IO.Path.GetFileNameWithoutExtension(this.m_FileNamePath);
			this.IsDirty = false;
			this.OnInitialize();
		}

		// Token: 0x06001DD0 RID: 7632 RVA: 0x00069DB8 File Offset: 0x00067FB8
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06001DD1 RID: 7633 RVA: 0x00069DC8 File Offset: 0x00067FC8
		public void AddSession(global::System.IO.Stream sessionStream)
		{
			using (global::Gibraltar.Data.GLFReader glfreader = new global::Gibraltar.Data.GLFReader(sessionStream))
			{
				if (!glfreader.IsSessionStream)
				{
					throw new global::Gibraltar.GibraltarException("The data stream provided is not a valid session data stream.");
				}
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Repository.Package", "Stream is session file, attempting to load", null, new object[0]);
				}
				object @lock = this.m_Lock;
				lock (@lock)
				{
					string path = glfreader.SessionHeader.HasFileInfo ? string.Format("{0}~{1}.{2}", glfreader.SessionHeader.Id, glfreader.SessionHeader.FileId, "glf") : string.Format("{0}.{1}", glfreader.SessionHeader.Id, "glf");
					string text = global::System.IO.Path.Combine(this.m_TemporaryWorkingDirectory, path);
					using (global::System.IO.FileStream fileStream = new global::System.IO.FileStream(text, global::System.IO.FileMode.Create, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.Read))
					{
						global::Gibraltar.FileSystemTools.StreamContentCopy(sessionStream, fileStream, true);
					}
					string fileName = global::Gibraltar.Data.SimplePackage.GenerateFragmentPath(glfreader.SessionHeader.FileId);
					global::Ionic.Zip.ZipEntry zipEntry = this.m_Archive[fileName];
					if (zipEntry != null)
					{
						this.m_Archive.RemoveEntry(fileName);
					}
					zipEntry = this.m_Archive.AddFile(text, "SessionFragments");
					zipEntry.CompressionLevel = global::Ionic.Zlib.CompressionLevel.None;
					this.AddSessionHeaderToIndex(glfreader.SessionHeader, zipEntry);
					this.IsDirty = true;
				}
			}
		}

		// Token: 0x06001DD2 RID: 7634 RVA: 0x00069F88 File Offset: 0x00068188
		public void Save(global::Gibraltar.ProgressMonitorStack progressMonitors)
		{
			if (string.IsNullOrEmpty(this.m_FileNamePath))
			{
				throw new global::System.IO.FileNotFoundException("Unable to save the current package because no path has been set to save to.");
			}
			this.Save(progressMonitors, this.m_FileNamePath);
		}

		// Token: 0x06001DD3 RID: 7635 RVA: 0x00069FB4 File Offset: 0x000681B4
		public void Save(global::Gibraltar.ProgressMonitorStack progressMonitors, string fileNamePath)
		{
			if (string.IsNullOrEmpty(fileNamePath))
			{
				throw new global::System.ArgumentNullException("fileNamePath", "Unable to save the current package because no path has been set to save to.");
			}
			global::Gibraltar.FileSystemTools.EnsurePathExists(fileNamePath);
			object @lock = this.m_Lock;
			lock (@lock)
			{
				int maxSteps = 3;
				int num = 0;
				using (global::Gibraltar.ProgressMonitor progressMonitor = progressMonitors.NewMonitor(this, "Saving Package", maxSteps))
				{
					progressMonitor.Update("Saving Package File to Disk", num++);
					this.m_Archive.Comment = this.m_Description;
					this.m_Archive.Save(fileNamePath);
					this.m_Archive.Dispose();
					this.m_Archive = new global::Ionic.Zip.ZipFile(fileNamePath);
					this.m_Archive.ParallelDeflateThreshold = -1L;
					this.m_FileNamePath = fileNamePath;
					progressMonitor.Update("Confirming package contents", num++);
					this.LoadIndex();
					this.m_FileNamePath = fileNamePath;
					this.IsDirty = false;
					progressMonitor.Update("Removing temporary storage", num++);
					foreach (string text in global::System.IO.Directory.GetFiles(this.m_TemporaryWorkingDirectory))
					{
						try
						{
							global::System.IO.Directory.Delete(text);
						}
						catch (global::System.Exception ex)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Repository.Package", "Unable to clean up temporary file from cache", "While removing the temporary file '{0}' from the temp file cache an exception was thrown.  This file may be leaked and use up disk space after the package process completes.\r\nException: {1}", new object[]
								{
									text,
									ex.Message
								});
							}
						}
					}
				}
			}
		}

		// Token: 0x170009A9 RID: 2473
		// (get) Token: 0x06001DD4 RID: 7636 RVA: 0x0006A16C File Offset: 0x0006836C
		// (set) Token: 0x06001DD5 RID: 7637 RVA: 0x0006A174 File Offset: 0x00068374
		public string Caption
		{
			get
			{
				return this.m_Caption;
			}
			set
			{
				this.m_Caption = value;
			}
		}

		// Token: 0x170009AA RID: 2474
		// (get) Token: 0x06001DD6 RID: 7638 RVA: 0x0006A180 File Offset: 0x00068380
		// (set) Token: 0x06001DD7 RID: 7639 RVA: 0x0006A188 File Offset: 0x00068388
		public string Description
		{
			get
			{
				return this.m_Description;
			}
			set
			{
				this.m_Description = value;
			}
		}

		// Token: 0x170009AB RID: 2475
		// (get) Token: 0x06001DD8 RID: 7640 RVA: 0x0006A194 File Offset: 0x00068394
		// (set) Token: 0x06001DD9 RID: 7641 RVA: 0x0006A19C File Offset: 0x0006839C
		public bool IsDirty
		{
			get
			{
				return this.m_IsDirty;
			}
			private set
			{
				this.m_IsDirty = value;
			}
		}

		// Token: 0x170009AC RID: 2476
		// (get) Token: 0x06001DDA RID: 7642 RVA: 0x0006A1A8 File Offset: 0x000683A8
		public string FileNamePath
		{
			get
			{
				return this.m_FileNamePath;
			}
		}

		// Token: 0x06001DDB RID: 7643 RVA: 0x0006A1B0 File Offset: 0x000683B0
		public void Clear()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_Sessions.Clear();
				this.m_Archive.RemoveSelectedEntries("*.glf", "SessionFragments");
			}
		}

		// Token: 0x06001DDC RID: 7644 RVA: 0x0006A208 File Offset: 0x00068408
		public void GetStats(out int sessions, out int problemSessions, out int files, out long fileBytes)
		{
			sessions = this.m_Sessions.Count;
			problemSessions = 0;
			fileBytes = 0L;
			files = 0;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				foreach (global::Gibraltar.Monitor.SessionFileInfo<global::Ionic.Zip.ZipEntry> sessionFileInfo in this.m_Sessions.Values)
				{
					if (sessionFileInfo.Header.ErrorCount > 0 || sessionFileInfo.Header.CriticalCount > 0 || sessionFileInfo.Header.StatusName.Equals(global::Loupe.Extensibility.Data.SessionStatus.Crashed.ToString(), global::System.StringComparison.OrdinalIgnoreCase))
					{
						problemSessions++;
					}
					files += sessionFileInfo.Fragments.Count;
					foreach (global::Ionic.Zip.ZipEntry zipEntry in sessionFileInfo.Fragments)
					{
						fileBytes += zipEntry.UncompressedSize;
					}
				}
			}
		}

		// Token: 0x06001DDD RID: 7645 RVA: 0x0006A34C File Offset: 0x0006854C
		public global::System.Collections.Generic.IList<global::Gibraltar.Data.SessionHeader> GetSessions()
		{
			object @lock = this.m_Lock;
			global::System.Collections.Generic.IList<global::Gibraltar.Data.SessionHeader> result;
			lock (@lock)
			{
				global::System.Collections.Generic.List<global::Gibraltar.Data.SessionHeader> list = new global::System.Collections.Generic.List<global::Gibraltar.Data.SessionHeader>(this.m_Sessions.Count);
				foreach (global::Gibraltar.Monitor.SessionFileInfo<global::Ionic.Zip.ZipEntry> sessionFileInfo in this.m_Sessions.Values)
				{
					list.Add(sessionFileInfo.Header);
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001DDE RID: 7646 RVA: 0x0006A3EC File Offset: 0x000685EC
		public global::Gibraltar.Monitor.Session GetSession(global::System.Guid sessionId, global::System.Guid? fileId = null)
		{
			global::Gibraltar.Monitor.Session session = null;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Monitor.SessionFileInfo<global::Ionic.Zip.ZipEntry> sessionFileInfo;
				if (!this.m_Sessions.TryGetValue(sessionId, out sessionFileInfo))
				{
					throw new global::System.ArgumentOutOfRangeException("sessionId", "There is no session in the package with the provided id");
				}
				global::Gibraltar.Monitor.SessionCollection sessionCollection = new global::Gibraltar.Monitor.SessionCollection();
				foreach (global::Ionic.Zip.ZipEntry zipEntry in sessionFileInfo.Fragments)
				{
					if (fileId != null)
					{
						using (global::Gibraltar.Data.GLFReader glfreader = new global::Gibraltar.Data.GLFReader(global::Gibraltar.FileSystemTools.GetTempFileStreamCopy(zipEntry.OpenReader())))
						{
							if (glfreader.SessionHeader.FileId != fileId.Value)
							{
								continue;
							}
						}
					}
					session = sessionCollection.Add(global::Gibraltar.FileSystemTools.GetTempFileStreamCopy(zipEntry.OpenReader()), true);
				}
			}
			if (session == null)
			{
				throw new global::System.ArgumentOutOfRangeException("fileId", "There is no session file in the package with the provided file id");
			}
			return session;
		}

		// Token: 0x06001DDF RID: 7647 RVA: 0x0006A520 File Offset: 0x00068720
		public global::System.Collections.Generic.IList<global::System.Guid> GetSessionFileIds(global::System.Guid sessionId)
		{
			object @lock = this.m_Lock;
			global::System.Collections.Generic.IList<global::System.Guid> result;
			lock (@lock)
			{
				global::Gibraltar.Monitor.SessionFileInfo<global::Ionic.Zip.ZipEntry> sessionFileInfo;
				if (!this.m_Sessions.TryGetValue(sessionId, out sessionFileInfo))
				{
					throw new global::System.ArgumentOutOfRangeException("sessionId", "There is no session in the package with the provided id");
				}
				global::System.Collections.Generic.List<global::System.Guid> list = new global::System.Collections.Generic.List<global::System.Guid>();
				foreach (global::Ionic.Zip.ZipEntry zipEntry in sessionFileInfo.Fragments)
				{
					using (global::Gibraltar.Data.GLFReader glfreader = new global::Gibraltar.Data.GLFReader(global::Gibraltar.FileSystemTools.GetTempFileStreamCopy(zipEntry.OpenReader())))
					{
						list.Add(glfreader.SessionHeader.FileId);
					}
				}
				result = list;
			}
			return result;
		}

		// Token: 0x06001DE0 RID: 7648 RVA: 0x0006A604 File Offset: 0x00068804
		protected virtual void Dispose(bool releaseManaged)
		{
			if (!this.m_Disposed)
			{
				this.m_Disposed = true;
				if (releaseManaged)
				{
					if (this.m_Archive != null)
					{
						this.m_Archive.Dispose();
						this.m_Archive = null;
					}
					if (!string.IsNullOrEmpty(this.m_TemporaryWorkingDirectory))
					{
						if (global::System.IO.Directory.Exists(this.m_TemporaryWorkingDirectory))
						{
							try
							{
								global::System.IO.Directory.Delete(this.m_TemporaryWorkingDirectory, true);
								return;
							}
							catch (global::System.Exception ex)
							{
								if (!global::Gibraltar.Monitor.Log.SilentMode)
								{
									global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Repository.Package", "Unable to Delete Package Temporary Directory due to " + ex.GetType(), "Unable to delete the temporary working directory '{0}'. This means we'll use more disk space than we should but otherwise should not impact the application.", new object[]
									{
										this.m_TemporaryWorkingDirectory
									});
								}
								return;
							}
						}
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Repository.Package", "Package Temporary Directory already deleted", "The temporary working directory '{0}' does not exist when trying to dispose of it.  This is unexpected, but not generally a problem unless the detection is in error.", new object[]
							{
								this.m_TemporaryWorkingDirectory
							});
						}
					}
				}
			}
		}

		// Token: 0x06001DE1 RID: 7649 RVA: 0x0006A6FC File Offset: 0x000688FC
		protected virtual void OnInitialize()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_TemporaryWorkingDirectory = global::System.IO.Path.Combine(global::System.IO.Path.GetTempPath(), global::System.IO.Path.GetRandomFileName());
				global::System.IO.Directory.CreateDirectory(this.m_TemporaryWorkingDirectory);
				if (this.m_Archive == null)
				{
					if (!global::Gibraltar.Monitor.Log.SilentMode)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Repository.Package", "Creating new package.", null, new object[0]);
					}
					this.m_Archive = new global::Ionic.Zip.ZipFile();
				}
				else
				{
					this.m_Description = this.m_Archive.Comment;
					this.LoadIndex();
				}
			}
		}

		// Token: 0x06001DE2 RID: 7650 RVA: 0x0006A7A8 File Offset: 0x000689A8
		private void AddSessionHeaderToIndex(global::Gibraltar.Data.SessionHeader sessionHeader, global::Ionic.Zip.ZipEntry sessionFragment)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Monitor.SessionFileInfo<global::Ionic.Zip.ZipEntry> sessionFileInfo;
				if (this.m_Sessions.TryGetValue(sessionHeader.Id, out sessionFileInfo))
				{
					sessionFileInfo.AddFragment(sessionHeader, sessionFragment, true);
				}
				else
				{
					sessionFileInfo = new global::Gibraltar.Monitor.SessionFileInfo<global::Ionic.Zip.ZipEntry>(sessionHeader, sessionFragment, true);
					this.m_Sessions.Add(sessionFileInfo.Id, sessionFileInfo);
				}
			}
		}

		// Token: 0x06001DE3 RID: 7651 RVA: 0x0006A820 File Offset: 0x00068A20
		private void LoadIndex()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Repository.Package", "Loading package file", "File name: {0}", new object[]
					{
						this.m_FileNamePath
					});
				}
				this.m_Sessions.Clear();
				foreach (global::Ionic.Zip.ZipEntry zipEntry in this.m_Archive)
				{
					if (!zipEntry.IsDirectory && (zipEntry.FileName.StartsWith("SessionFragments", global::System.StringComparison.OrdinalIgnoreCase) || zipEntry.FileName.EndsWith("glp", global::System.StringComparison.OrdinalIgnoreCase)))
					{
						try
						{
							global::Gibraltar.Data.SessionHeader sessionHeader = global::Gibraltar.Data.SimplePackage.LoadSessionHeader(zipEntry);
							if (sessionHeader != null)
							{
								this.AddSessionHeaderToIndex(sessionHeader, zipEntry);
							}
						}
						catch (global::System.Exception ex)
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, true, "Loupe.Repository.Package", "Unable to parse file fragment name in simple package due to " + ex.GetType(), "File Name: {0}\r\nException: {1}", new object[]
								{
									zipEntry.FileName,
									ex.Message
								});
							}
						}
					}
				}
			}
		}

		// Token: 0x06001DE4 RID: 7652 RVA: 0x0006A99C File Offset: 0x00068B9C
		private static string GenerateFragmentPath(global::System.Guid fileId)
		{
			return string.Format("{0}/{1}.{2}", "SessionFragments", fileId, "glf");
		}

		// Token: 0x06001DE5 RID: 7653 RVA: 0x0006A9B8 File Offset: 0x00068BB8
		private static global::Gibraltar.Data.SessionHeader LoadSessionHeader(global::Ionic.Zip.ZipEntry zipEntry)
		{
			if (!global::Gibraltar.Monitor.Log.SilentMode)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Repository.Package", "Opening session file from zip file to read header", "Opening zip entry '{0}'.", new object[]
				{
					zipEntry.FileName
				});
			}
			global::Gibraltar.Data.SessionHeader result = null;
			try
			{
				using (global::Ionic.Crc.CrcCalculatorStream crcCalculatorStream = zipEntry.OpenReader())
				{
					byte[] array = new byte[20];
					crcCalculatorStream.Read(array, 0, array.Length);
					global::Gibraltar.Data.FileHeader fileHeader = null;
					using (global::System.IO.MemoryStream memoryStream = new global::System.IO.MemoryStream(array))
					{
						if (!global::Gibraltar.Data.GLFReader.IsGLF(memoryStream, out fileHeader))
						{
							if (!global::Gibraltar.Monitor.Log.SilentMode)
							{
								global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Repository.Package", "Session file does not check out as a GLF file, skipping", "Zip entry: '{0}'.", new object[]
								{
									zipEntry.FileName
								});
							}
							return result;
						}
					}
					byte[] array2 = new byte[fileHeader.DataOffset];
					array.CopyTo(array2, 0);
					crcCalculatorStream.Read(array2, array.Length, array2.Length - array.Length);
					using (global::System.IO.MemoryStream memoryStream2 = new global::System.IO.MemoryStream(array2))
					{
						using (global::Gibraltar.Data.GLFReader glfreader = new global::Gibraltar.Data.GLFReader(memoryStream2))
						{
							if (glfreader.IsSessionStream)
							{
								result = glfreader.SessionHeader;
							}
						}
					}
				}
			}
			catch (global::System.Exception ex)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Repository.Package", "Unexpected exception while attempting to load a session header", "While opening the zip file entry '{0}' an exception was thrown reading the session header. Since this routine is designed to not generate exceptions this may indicate a flaw in the logic of the routine.\r\nException: {1}\r\n", new object[]
					{
						zipEntry.FileName,
						ex.Message
					});
				}
			}
			return result;
		}

		// Token: 0x04000B1A RID: 2842
		private const string LogCategory = "Loupe.Repository.Package";

		// Token: 0x04000B1B RID: 2843
		private const string FragmentsFolder = "SessionFragments";

		// Token: 0x04000B1C RID: 2844
		private readonly object m_Lock = new object();

		// Token: 0x04000B1D RID: 2845
		private readonly global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::Ionic.Zip.ZipEntry>> m_Sessions = new global::System.Collections.Generic.Dictionary<global::System.Guid, global::Gibraltar.Monitor.SessionFileInfo<global::Ionic.Zip.ZipEntry>>();

		// Token: 0x04000B1E RID: 2846
		private global::Ionic.Zip.ZipFile m_Archive;

		// Token: 0x04000B1F RID: 2847
		private string m_FileNamePath;

		// Token: 0x04000B20 RID: 2848
		private string m_TemporaryWorkingDirectory;

		// Token: 0x04000B21 RID: 2849
		private volatile bool m_Disposed;

		// Token: 0x04000B22 RID: 2850
		private string m_Caption;

		// Token: 0x04000B23 RID: 2851
		private string m_Description;

		// Token: 0x04000B24 RID: 2852
		private bool m_IsDirty;
	}
}
