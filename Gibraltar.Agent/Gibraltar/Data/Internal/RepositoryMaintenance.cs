using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.IO;
using System.Threading;
using Gibraltar.Messaging;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Data.Internal
{
	// Token: 0x02000265 RID: 613
	internal class RepositoryMaintenance : global::System.IDisposable
	{
		// Token: 0x1400008E RID: 142
		// (add) Token: 0x06001F3F RID: 7999 RVA: 0x00071938 File Offset: 0x0006FB38
		// (remove) Token: 0x06001F40 RID: 8000 RVA: 0x00071974 File Offset: 0x0006FB74
		public event global::System.ComponentModel.CollectionChangeEventHandler CollectionChanged;

		// Token: 0x06001F41 RID: 8001 RVA: 0x000719B0 File Offset: 0x0006FBB0
		public RepositoryMaintenance(string repositoryPath, bool loggingEnabled)
		{
			if (string.IsNullOrEmpty(repositoryPath))
			{
				throw new global::System.ArgumentNullException("repositoryPath");
			}
			this.ProductName = null;
			this.ApplicationName = null;
			this.m_RepositoryPath = repositoryPath;
			this.m_SessionLockFolder = global::System.IO.Path.Combine(this.m_RepositoryPath, "RunningSessions");
			this.m_RepositoryArchivePath = global::System.IO.Path.Combine(this.m_RepositoryPath, "Archive");
			this.m_LoggingEnabled = loggingEnabled;
		}

		// Token: 0x06001F42 RID: 8002 RVA: 0x00071A30 File Offset: 0x0006FC30
		public RepositoryMaintenance(string repositoryPath, string productName, string applicationName, int maxAgeDays, int maxSizeMegabytes, bool loggingEnabled)
		{
			if (string.IsNullOrEmpty(repositoryPath))
			{
				throw new global::System.ArgumentNullException("repositoryPath");
			}
			if (string.IsNullOrEmpty(productName))
			{
				throw new global::System.ArgumentNullException("productName");
			}
			this.ProductName = productName;
			this.ApplicationName = applicationName;
			this.MaxAgeDays = maxAgeDays;
			this.MaxSizeMegabytes = maxSizeMegabytes;
			this.m_RepositoryPath = repositoryPath;
			this.m_RepositoryArchivePath = global::System.IO.Path.Combine(this.m_RepositoryPath, "Archive");
			this.m_SessionLockFolder = global::System.IO.Path.Combine(this.m_RepositoryPath, "RunningSessions");
			this.m_LoggingEnabled = loggingEnabled;
		}

		// Token: 0x06001F43 RID: 8003 RVA: 0x00071AD8 File Offset: 0x0006FCD8
		public void Dispose()
		{
			if (this.m_Disposed)
			{
				return;
			}
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x17000A32 RID: 2610
		// (get) Token: 0x06001F44 RID: 8004 RVA: 0x00071AF4 File Offset: 0x0006FCF4
		// (set) Token: 0x06001F45 RID: 8005 RVA: 0x00071AFC File Offset: 0x0006FCFC
		public string ProductName { get; private set; }

		// Token: 0x17000A33 RID: 2611
		// (get) Token: 0x06001F46 RID: 8006 RVA: 0x00071B08 File Offset: 0x0006FD08
		// (set) Token: 0x06001F47 RID: 8007 RVA: 0x00071B10 File Offset: 0x0006FD10
		public string ApplicationName { get; private set; }

		// Token: 0x17000A34 RID: 2612
		// (get) Token: 0x06001F48 RID: 8008 RVA: 0x00071B1C File Offset: 0x0006FD1C
		public string RepositoryPath
		{
			get
			{
				return this.m_RepositoryPath;
			}
		}

		// Token: 0x17000A35 RID: 2613
		// (get) Token: 0x06001F49 RID: 8009 RVA: 0x00071B24 File Offset: 0x0006FD24
		// (set) Token: 0x06001F4A RID: 8010 RVA: 0x00071B2C File Offset: 0x0006FD2C
		public int MaxAgeDays { get; set; }

		// Token: 0x17000A36 RID: 2614
		// (get) Token: 0x06001F4B RID: 8011 RVA: 0x00071B38 File Offset: 0x0006FD38
		// (set) Token: 0x06001F4C RID: 8012 RVA: 0x00071B40 File Offset: 0x0006FD40
		public int MaxSizeMegabytes { get; set; }

		// Token: 0x17000A37 RID: 2615
		// (get) Token: 0x06001F4D RID: 8013 RVA: 0x00071B4C File Offset: 0x0006FD4C
		// (set) Token: 0x06001F4E RID: 8014 RVA: 0x00071B54 File Offset: 0x0006FD54
		public global::System.DateTimeOffset LastMaintenanceRunDateTime { get; private set; }

		// Token: 0x17000A38 RID: 2616
		// (get) Token: 0x06001F4F RID: 8015 RVA: 0x00071B60 File Offset: 0x0006FD60
		// (set) Token: 0x06001F50 RID: 8016 RVA: 0x00071B68 File Offset: 0x0006FD68
		public bool IsLoggingEnabled
		{
			get
			{
				return this.m_LoggingEnabled;
			}
			set
			{
				this.m_LoggingEnabled = value;
			}
		}

		// Token: 0x17000A39 RID: 2617
		// (get) Token: 0x06001F51 RID: 8017 RVA: 0x00071B74 File Offset: 0x0006FD74
		public bool PerformingMaintenance
		{
			get
			{
				return this.m_PerformingMaintenance;
			}
		}

		// Token: 0x06001F52 RID: 8018 RVA: 0x00071B80 File Offset: 0x0006FD80
		public void PerformMaintenance(bool asyncronous)
		{
			this.QueueAsyncMaintenance(new global::System.Threading.WaitCallback(this.AsyncPerformMaintenance), asyncronous);
		}

		// Token: 0x06001F53 RID: 8019 RVA: 0x00071B98 File Offset: 0x0006FD98
		protected void QueueAsyncMaintenance(global::System.Threading.WaitCallback maintenanceDelegate, bool asyncronous)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!this.m_PerformingMaintenance)
				{
					this.m_PerformingMaintenance = true;
					this.LastMaintenanceRunDateTime = global::System.DateTimeOffset.Now;
					global::System.Threading.ThreadPool.QueueUserWorkItem(maintenanceDelegate);
				}
				global::System.Threading.Monitor.PulseAll(this.m_Lock);
			}
			if (!asyncronous)
			{
				@lock = this.m_Lock;
				lock (@lock)
				{
					while (this.m_PerformingMaintenance)
					{
						global::System.Threading.Monitor.Wait(this.m_Lock, 16);
					}
					global::System.Threading.Monitor.PulseAll(this.m_Lock);
				}
			}
		}

		// Token: 0x06001F54 RID: 8020 RVA: 0x00071C54 File Offset: 0x0006FE54
		protected virtual void Dispose(bool releaseManaged)
		{
			this.m_Disposed = true;
			if (releaseManaged)
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					global::System.DateTimeOffset left = global::System.DateTimeOffset.Now.AddMilliseconds(2000.0);
					while (this.m_PerformingMaintenance && left > global::System.DateTimeOffset.Now)
					{
						global::System.Threading.Monitor.Wait(this.m_Lock, 100);
					}
					global::System.Threading.Monitor.PulseAll(this.m_Lock);
				}
			}
		}

		// Token: 0x06001F55 RID: 8021 RVA: 0x00071CE8 File Offset: 0x0006FEE8
		protected virtual void OnCollectionChanged(global::System.ComponentModel.CollectionChangeEventArgs e)
		{
			global::System.ComponentModel.CollectionChangeEventHandler collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, e);
			}
		}

		// Token: 0x06001F56 RID: 8022 RVA: 0x00071D10 File Offset: 0x0006FF10
		private void AsyncPerformMaintenance(object state)
		{
			try
			{
				global::Gibraltar.Messaging.Publisher.ThreadMustNotBlock();
				bool flag = false;
				int maxSizeMegabytes = this.MaxSizeMegabytes;
				int maxAgeDays = this.MaxAgeDays;
				if (this.m_LoggingEnabled)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Repository.Maintenance", "Starting Repository Maintenance", "Starting repository maintenance on repository stored at {0}, removing fragments older than {1} days and keeping the repository under {2:N0} megabytes.", new object[]
					{
						this.RepositoryPath,
						maxAgeDays,
						maxSizeMegabytes
					});
				}
				using (global::Gibraltar.Data.InterprocessLock interprocessLock = global::Gibraltar.Data.InterprocessLockManager.Lock(this, this.m_RepositoryPath, "Maintenance", 0, true))
				{
					if (interprocessLock == null)
					{
						if (this.m_LoggingEnabled)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Repository.Maintenance", "Unable to Perform Maintenance - Repository Locked", "Unable to get the maintenance file lock on the repository stored at {0}, not performing maintenance.", new object[]
							{
								this.RepositoryPath
							});
						}
						return;
					}
					if (!string.IsNullOrEmpty(this.ApplicationName) && !global::Gibraltar.Monitor.Log.IsSessionEnding)
					{
						bool flag3;
						bool flag2 = this.ProcessPruneForAge(maxAgeDays, maxSizeMegabytes, out flag3);
						flag = (flag || flag2);
						if (maxSizeMegabytes <= 0)
						{
							flag3 = false;
						}
						if (flag3 && !global::Gibraltar.Monitor.Log.IsSessionEnding)
						{
							flag2 = this.ProcessPruneForSize(this.MaxSizeMegabytes);
							flag = (flag || flag2);
						}
					}
				}
				if (flag)
				{
					this.OnCollectionChanged(new global::System.ComponentModel.CollectionChangeEventArgs(global::System.ComponentModel.CollectionChangeAction.Refresh, null));
				}
				if (this.m_LoggingEnabled)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Repository.Maintenance", "Repository Maintenance Complete", "Repository maintenance completed on repository stored at {0}", new object[]
					{
						this.RepositoryPath
					});
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.KeepAlive(ex);
				if (this.m_LoggingEnabled)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Repository.Maintenance", "Unable to Perform Repository Maintenance", "Unable to complete repository maintenance successfully due to an exception: {0}", new object[]
					{
						ex
					});
				}
			}
			finally
			{
				object @lock = this.m_Lock;
				lock (@lock)
				{
					this.m_PerformingMaintenance = false;
					global::System.Threading.Monitor.PulseAll(this.m_Lock);
				}
			}
		}

		// Token: 0x06001F57 RID: 8023 RVA: 0x00071F44 File Offset: 0x00070144
		private bool ProcessPruneForAge(int maxAgeDays, int maxSizeMegabytes, out bool capacityPruningRequired)
		{
			int num = 0;
			long num2 = 0L;
			global::System.Collections.Generic.List<global::System.IO.FileInfo> list = this.AllExistingFileFragments();
			global::System.DateTimeOffset right = global::System.DateTimeOffset.UtcNow.AddDays((double)(-1 * maxAgeDays));
			foreach (global::System.IO.FileInfo fileInfo in list)
			{
				bool flag = false;
				if (fileInfo.CreationTimeUtc < right)
				{
					global::System.Guid? guid = this.SafeGetSessionId(fileInfo.FullName);
					if (guid != null && !this.IsSessionRunning(guid.Value))
					{
						flag = this.RemoveSessionFragment(fileInfo);
					}
				}
				if (flag)
				{
					num++;
				}
				else
				{
					num2 += fileInfo.Length;
				}
			}
			if (num > 0 && this.m_LoggingEnabled)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Repository.Maintenance", "Files Pruned for Age", "Removed {0} files because they are older than the maximum age of {1} for session fragments.", new object[]
				{
					num,
					maxAgeDays
				});
			}
			capacityPruningRequired = (num2 / 1048576m > maxSizeMegabytes);
			return num > 0;
		}

		// Token: 0x06001F58 RID: 8024 RVA: 0x00072080 File Offset: 0x00070280
		private bool ProcessPruneForSize(int maxSizeMegabytes)
		{
			if (global::Gibraltar.Monitor.Log.IsSessionEnding)
			{
				return false;
			}
			int num = 0;
			long num2 = 0L;
			global::System.Collections.Generic.List<global::System.IO.FileInfo> list = this.AllExistingFileFragments();
			long num3 = (long)(maxSizeMegabytes * 1024 * 1024);
			long num4 = 0L;
			global::System.DateTime t = global::System.DateTime.UtcNow.AddMinutes(-1.0);
			list.Sort(new global::System.Comparison<global::System.IO.FileInfo>(global::Gibraltar.Data.Internal.RepositoryMaintenance.SortFilesByUpdateDateDesc));
			foreach (global::System.IO.FileInfo fileInfo in list)
			{
				bool flag = false;
				if (num4 + fileInfo.Length > num3 && fileInfo.LastWriteTimeUtc < t)
				{
					flag = this.RemoveSessionFragment(fileInfo);
				}
				if (flag)
				{
					num2 += fileInfo.Length;
					num++;
				}
				else
				{
					num4 += fileInfo.Length;
				}
				if (global::Gibraltar.Monitor.Log.IsSessionEnding)
				{
					break;
				}
			}
			if (num > 0 && this.m_LoggingEnabled)
			{
				global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Repository.Maintenance", "Files Pruned for Size", "Removed {0} files to free up {1:N0} bytes.", new object[]
				{
					num,
					num2
				});
			}
			return num > 0;
		}

		// Token: 0x06001F59 RID: 8025 RVA: 0x000721C8 File Offset: 0x000703C8
		private global::System.Collections.Generic.List<global::System.IO.FileInfo> AllExistingFileFragments()
		{
			string searchPattern = string.Format("{0}*.{1}", global::Gibraltar.Messaging.FileMessenger.SessionFileNamePrefix(this.ProductName, this.ApplicationName), "glf");
			global::System.Collections.Generic.List<global::System.IO.FileInfo> list = new global::System.Collections.Generic.List<global::System.IO.FileInfo>(new global::System.IO.DirectoryInfo(this.m_RepositoryPath).GetFiles(searchPattern, global::System.IO.SearchOption.TopDirectoryOnly));
			if (global::System.IO.Directory.Exists(this.m_RepositoryArchivePath))
			{
				global::System.IO.DirectoryInfo directoryInfo = new global::System.IO.DirectoryInfo(this.m_RepositoryArchivePath);
				list.AddRange(directoryInfo.GetFiles(searchPattern));
			}
			return list;
		}

		// Token: 0x06001F5A RID: 8026 RVA: 0x0007223C File Offset: 0x0007043C
		private bool RemoveSessionFragment(global::System.IO.FileInfo victimFile)
		{
			bool result = false;
			try
			{
				using (global::Gibraltar.Data.FileLock fileLock = global::Gibraltar.Data.Win32Helper.GetFileLock(victimFile.FullName, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.Delete))
				{
					if (fileLock != null)
					{
						victimFile.Delete();
						result = true;
					}
					else if (victimFile.Exists && this.m_LoggingEnabled)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Repository.Maintenance", "Unable to Delete Session Fragment", "Unable to delete the session fragment at '{0}' because it could not be locked.", new object[]
						{
							victimFile.FullName
						});
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.GC.KeepAlive(ex);
				if (this.m_LoggingEnabled)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Repository.Maintenance", "Unable to Delete Session Fragment", "Unable to delete the session fragment at '{0}' because of an exception: {1}", new object[]
					{
						victimFile.FullName,
						ex
					});
				}
			}
			return result;
		}

		// Token: 0x06001F5B RID: 8027 RVA: 0x0007231C File Offset: 0x0007051C
		private global::System.Guid? SafeGetSessionId(string sessionFileNamePath)
		{
			global::Gibraltar.Data.SessionHeader sessionHeader = this.SafeGetSessionHeader(sessionFileNamePath);
			if (sessionHeader != null)
			{
				return new global::System.Guid?(sessionHeader.Id);
			}
			return null;
		}

		// Token: 0x06001F5C RID: 8028 RVA: 0x00072350 File Offset: 0x00070550
		private global::Gibraltar.Data.SessionHeader SafeGetSessionHeader(string sessionFileNamePath)
		{
			global::Gibraltar.Data.SessionHeader result = null;
			try
			{
				global::System.IO.FileStream fileStream2;
				global::System.IO.FileStream fileStream = fileStream2 = global::Gibraltar.Data.Win32Helper.OpenFileStream(sessionFileNamePath, global::System.IO.FileMode.Open, global::System.IO.FileAccess.ReadWrite, global::System.IO.FileShare.Read);
				try
				{
					if (fileStream == null && this.m_LoggingEnabled)
					{
						global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Verbose, "Loupe.Repository.Maintenance", "Unable to open session file, it is probably locked", "While attempting to open the local session fragment at '{0}', probably because it is still being written to.", new object[]
						{
							sessionFileNamePath
						});
					}
					using (global::Gibraltar.Data.GLFReader glfreader = new global::Gibraltar.Data.GLFReader(fileStream))
					{
						if (glfreader.IsSessionStream)
						{
							result = glfreader.SessionHeader;
						}
					}
				}
				finally
				{
					if (fileStream2 != null)
					{
						((global::System.IDisposable)fileStream2).Dispose();
					}
				}
			}
			catch (global::System.Exception ex)
			{
				if (this.m_LoggingEnabled)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, "Loupe.Repository.Maintenance", "Unexpected exception while attempting to load a session header", "While opening the file '{0}' an exception was thrown reading the session header. Since this routine is designed to not generate exceptions this may indicate a flaw in the logic of the routine.\r\nException: {1}\r\n", new object[]
					{
						sessionFileNamePath,
						ex.Message
					});
				}
			}
			return result;
		}

		// Token: 0x06001F5D RID: 8029 RVA: 0x00072448 File Offset: 0x00070648
		private static int SortFilesByUpdateDateDesc(global::System.IO.FileInfo leftFile, global::System.IO.FileInfo rightFile)
		{
			int num = leftFile.LastWriteTimeUtc.CompareTo(rightFile.LastWriteTimeUtc);
			if (num == 0)
			{
				num = leftFile.CreationTimeUtc.CompareTo(rightFile.LastWriteTimeUtc);
			}
			if (num == 0)
			{
				num = string.Compare(leftFile.FullName, rightFile.FullName, global::System.StringComparison.Ordinal);
			}
			return -1 * global::System.Math.Sign(num);
		}

		// Token: 0x06001F5E RID: 8030 RVA: 0x000724AC File Offset: 0x000706AC
		private bool IsSessionRunning(global::System.Guid sessionId)
		{
			bool result;
			using (global::Gibraltar.Data.InterprocessLock interprocessLock = global::Gibraltar.Data.InterprocessLockManager.Lock(this, this.m_SessionLockFolder, sessionId.ToString(), 0, true))
			{
				if (interprocessLock == null)
				{
					result = true;
				}
				else
				{
					result = false;
				}
			}
			return result;
		}

		// Token: 0x04000BE0 RID: 3040
		public const string MutiprocessLockName = "Maintenance";

		// Token: 0x04000BE1 RID: 3041
		private const string LogCategory = "Loupe.Repository.Maintenance";

		// Token: 0x04000BE2 RID: 3042
		private readonly object m_Lock = new object();

		// Token: 0x04000BE3 RID: 3043
		private readonly string m_RepositoryPath;

		// Token: 0x04000BE4 RID: 3044
		private readonly string m_RepositoryArchivePath;

		// Token: 0x04000BE5 RID: 3045
		private volatile bool m_PerformingMaintenance;

		// Token: 0x04000BE6 RID: 3046
		private bool m_Disposed;

		// Token: 0x04000BE7 RID: 3047
		private bool m_LoggingEnabled;

		// Token: 0x04000BE8 RID: 3048
		private string m_SessionLockFolder;
	}
}
