using System;
using System.IO;
using System.Threading;
using NLog.Common;
using NLog.Time;

namespace NLog.Internal.FileAppenders
{
	// Token: 0x0200013F RID: 319
	internal sealed class FileAppenderCache : global::System.IDisposable
	{
		// Token: 0x06000E56 RID: 3670 RVA: 0x00024814 File Offset: 0x00022A14
		private FileAppenderCache() : this(0, null, null)
		{
		}

		// Token: 0x06000E57 RID: 3671 RVA: 0x00024820 File Offset: 0x00022A20
		public FileAppenderCache(int size, global::NLog.Internal.FileAppenders.IFileAppenderFactory appenderFactory, global::NLog.Internal.FileAppenders.ICreateFileParameters createFileParams)
		{
			this.Size = size;
			this.Factory = appenderFactory;
			this.CreateFileParameters = createFileParams;
			this._appenders = new global::NLog.Internal.FileAppenders.BaseFileAppender[this.Size];
			this._autoClosingTimer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.AutoClosingTimerCallback), null, -1, -1);
			this._externalFileArchivingWatcher.FileChanged += this.ExternalFileArchivingWatcher_OnFileChanged;
		}

		// Token: 0x06000E58 RID: 3672 RVA: 0x00024898 File Offset: 0x00022A98
		private void ExternalFileArchivingWatcher_OnFileChanged(object sender, global::System.IO.FileSystemEventArgs e)
		{
			if (this._logFileWasArchived || this.CheckCloseAppenders == null || this._autoClosingTimer == null)
			{
				return;
			}
			if (this.FileAppenderFolderChanged(e.FullPath))
			{
				if ((e.ChangeType & (global::System.IO.WatcherChangeTypes.Deleted | global::System.IO.WatcherChangeTypes.Renamed)) != (global::System.IO.WatcherChangeTypes)0)
				{
					this._logFileWasArchived = true;
				}
			}
			else if ((e.ChangeType & global::System.IO.WatcherChangeTypes.Created) == global::System.IO.WatcherChangeTypes.Created)
			{
				this._logFileWasArchived = true;
			}
			if (this._logFileWasArchived && this._autoClosingTimer != null)
			{
				this._autoClosingTimer.Change(50, -1);
			}
		}

		// Token: 0x06000E59 RID: 3673 RVA: 0x00024914 File Offset: 0x00022B14
		private bool FileAppenderFolderChanged(string fullPath)
		{
			if (string.IsNullOrEmpty(fullPath))
			{
				return false;
			}
			if (string.IsNullOrEmpty(this._archiveFilePatternToWatch))
			{
				return true;
			}
			string directoryName = global::System.IO.Path.GetDirectoryName(this._archiveFilePatternToWatch);
			if (!string.IsNullOrEmpty(directoryName))
			{
				string directoryName2 = global::System.IO.Path.GetDirectoryName(fullPath);
				return !string.Equals(directoryName, directoryName2, global::System.StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}

		// Token: 0x170002AF RID: 687
		// (get) Token: 0x06000E5A RID: 3674 RVA: 0x00024962 File Offset: 0x00022B62
		// (set) Token: 0x06000E5B RID: 3675 RVA: 0x0002496C File Offset: 0x00022B6C
		public string ArchiveFilePatternToWatch
		{
			get
			{
				return this._archiveFilePatternToWatch;
			}
			set
			{
				if (this._archiveFilePatternToWatch != value)
				{
					if (!string.IsNullOrEmpty(this._archiveFilePatternToWatch))
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(this._archiveFilePatternToWatch);
						if (string.IsNullOrEmpty(directoryName))
						{
							this._externalFileArchivingWatcher.StopWatching(directoryName);
						}
					}
					this._archiveFilePatternToWatch = value;
					this._logFileWasArchived = false;
				}
			}
		}

		// Token: 0x06000E5C RID: 3676 RVA: 0x000249C2 File Offset: 0x00022BC2
		public void InvalidateAppendersForArchivedFiles()
		{
			if (this._logFileWasArchived)
			{
				this._logFileWasArchived = false;
				global::NLog.Common.InternalLogger.Trace("FileAppender: Invalidate archived files");
				this.CloseAppenders("Cleanup Archive");
			}
		}

		// Token: 0x06000E5D RID: 3677 RVA: 0x000249E8 File Offset: 0x00022BE8
		private void AutoClosingTimerCallback(object state)
		{
			global::System.EventHandler checkCloseAppenders = this.CheckCloseAppenders;
			if (checkCloseAppenders != null)
			{
				checkCloseAppenders(this, global::System.EventArgs.Empty);
			}
		}

		// Token: 0x170002B0 RID: 688
		// (get) Token: 0x06000E5E RID: 3678 RVA: 0x00024A0B File Offset: 0x00022C0B
		// (set) Token: 0x06000E5F RID: 3679 RVA: 0x00024A13 File Offset: 0x00022C13
		public global::NLog.Internal.FileAppenders.ICreateFileParameters CreateFileParameters { get; private set; }

		// Token: 0x170002B1 RID: 689
		// (get) Token: 0x06000E60 RID: 3680 RVA: 0x00024A1C File Offset: 0x00022C1C
		// (set) Token: 0x06000E61 RID: 3681 RVA: 0x00024A24 File Offset: 0x00022C24
		public global::NLog.Internal.FileAppenders.IFileAppenderFactory Factory { get; private set; }

		// Token: 0x170002B2 RID: 690
		// (get) Token: 0x06000E62 RID: 3682 RVA: 0x00024A2D File Offset: 0x00022C2D
		// (set) Token: 0x06000E63 RID: 3683 RVA: 0x00024A35 File Offset: 0x00022C35
		public int Size { get; private set; }

		// Token: 0x14000017 RID: 23
		// (add) Token: 0x06000E64 RID: 3684 RVA: 0x00024A40 File Offset: 0x00022C40
		// (remove) Token: 0x06000E65 RID: 3685 RVA: 0x00024A78 File Offset: 0x00022C78
		public event global::System.EventHandler CheckCloseAppenders;

		// Token: 0x06000E66 RID: 3686 RVA: 0x00024AB0 File Offset: 0x00022CB0
		public global::NLog.Internal.FileAppenders.BaseFileAppender AllocateAppender(string fileName)
		{
			global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = null;
			int freeSpot = this._appenders.Length - 1;
			for (int i = 0; i < this._appenders.Length; i++)
			{
				if (this._appenders[i] == null)
				{
					freeSpot = i;
					break;
				}
				if (string.Equals(this._appenders[i].FileName, fileName, global::System.StringComparison.OrdinalIgnoreCase))
				{
					global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender2 = this._appenders[i];
					if (i > 0)
					{
						for (int j = i; j > 0; j--)
						{
							this._appenders[j] = this._appenders[j - 1];
						}
						this._appenders[0] = baseFileAppender2;
					}
					baseFileAppender = baseFileAppender2;
					break;
				}
			}
			if (baseFileAppender == null)
			{
				baseFileAppender = this.CreateAppender(fileName, freeSpot);
			}
			return baseFileAppender;
		}

		// Token: 0x06000E67 RID: 3687 RVA: 0x00024B4C File Offset: 0x00022D4C
		private global::NLog.Internal.FileAppenders.BaseFileAppender CreateAppender(string fileName, int freeSpot)
		{
			global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender2;
			try
			{
				global::NLog.Common.InternalLogger.Debug<string>("Creating file appender: {0}", fileName);
				global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this.Factory.Open(fileName, this.CreateFileParameters);
				if (this._appenders[freeSpot] != null)
				{
					this.CloseAppender(this._appenders[freeSpot], "Stale", false);
					this._appenders[freeSpot] = null;
				}
				for (int i = freeSpot; i > 0; i--)
				{
					this._appenders[i] = this._appenders[i - 1];
				}
				this._appenders[0] = baseFileAppender;
				baseFileAppender2 = baseFileAppender;
				if (this.CheckCloseAppenders != null)
				{
					if (freeSpot == 0)
					{
						this._logFileWasArchived = false;
					}
					if (!string.IsNullOrEmpty(this._archiveFilePatternToWatch))
					{
						string directoryName = global::System.IO.Path.GetDirectoryName(this._archiveFilePatternToWatch);
						if (!global::System.IO.Directory.Exists(directoryName))
						{
							global::System.IO.Directory.CreateDirectory(directoryName);
						}
						this._externalFileArchivingWatcher.Watch(this._archiveFilePatternToWatch);
					}
					this._externalFileArchivingWatcher.Watch(baseFileAppender2.FileName);
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Warn(ex, "Failed to create file appender: {0}", new object[]
				{
					fileName
				});
				throw;
			}
			return baseFileAppender2;
		}

		// Token: 0x06000E68 RID: 3688 RVA: 0x00024C4C File Offset: 0x00022E4C
		public void CloseAppenders(string reason)
		{
			if (this._appenders != null)
			{
				for (int i = 0; i < this._appenders.Length; i++)
				{
					global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this._appenders[i];
					if (baseFileAppender == null)
					{
						break;
					}
					this.CloseAppender(baseFileAppender, reason, true);
					this._appenders[i] = null;
					baseFileAppender.Dispose();
				}
			}
		}

		// Token: 0x06000E69 RID: 3689 RVA: 0x00024C98 File Offset: 0x00022E98
		public void CloseAppenders(global::System.DateTime expireTime)
		{
			if (this._logFileWasArchived)
			{
				this._logFileWasArchived = false;
				this.CloseAppenders("Cleanup Timer");
				return;
			}
			if (expireTime != global::System.DateTime.MinValue)
			{
				int num = 0;
				while (num < this._appenders.Length && this._appenders[num] != null)
				{
					if (this._appenders[num].OpenTimeUtc < expireTime)
					{
						for (int i = num; i < this._appenders.Length; i++)
						{
							global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this._appenders[i];
							if (baseFileAppender == null)
							{
								return;
							}
							this.CloseAppender(baseFileAppender, "Expired", num == 0);
							this._appenders[i] = null;
							baseFileAppender.Dispose();
						}
						return;
					}
					num++;
				}
			}
		}

		// Token: 0x06000E6A RID: 3690 RVA: 0x00024D40 File Offset: 0x00022F40
		public void FlushAppenders()
		{
			foreach (global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender in this._appenders)
			{
				if (baseFileAppender == null)
				{
					break;
				}
				try
				{
					baseFileAppender.Flush();
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "Failed to flush file '{0}'.", new object[]
					{
						baseFileAppender.FileName
					});
					global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender2 = this.InvalidateAppender(baseFileAppender.FileName);
					if (baseFileAppender2 != null)
					{
						baseFileAppender2.Dispose();
					}
					throw;
				}
			}
		}

		// Token: 0x06000E6B RID: 3691 RVA: 0x00024DB4 File Offset: 0x00022FB4
		private global::NLog.Internal.FileAppenders.BaseFileAppender GetAppender(string fileName)
		{
			for (int i = 0; i < this._appenders.Length; i++)
			{
				global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this._appenders[i];
				if (baseFileAppender == null)
				{
					break;
				}
				if (string.Equals(baseFileAppender.FileName, fileName, global::System.StringComparison.OrdinalIgnoreCase))
				{
					return baseFileAppender;
				}
			}
			return null;
		}

		// Token: 0x06000E6C RID: 3692 RVA: 0x00024DF4 File Offset: 0x00022FF4
		public global::System.DateTime? GetFileCreationTimeSource(string filePath, global::System.DateTime? fallbackTimeSource = null)
		{
			global::NLog.Internal.FileAppenders.BaseFileAppender appender = this.GetAppender(filePath);
			global::System.DateTime? result = null;
			if (appender != null)
			{
				try
				{
					result = global::NLog.Internal.FileCharacteristicsHelper.ValidateFileCreationTime<global::NLog.Internal.FileAppenders.BaseFileAppender>(appender, (global::NLog.Internal.FileAppenders.BaseFileAppender f) => f.GetFileCreationTimeUtc(), (global::NLog.Internal.FileAppenders.BaseFileAppender f) => fallbackTimeSource, null);
					if (result != null)
					{
						global::System.DateTime creationTimeUtc = appender.CreationTimeUtc;
						if (result.Value != creationTimeUtc)
						{
							appender.CreationTimeUtc = result.Value;
						}
						return new global::System.DateTime?(appender.CreationTimeSource);
					}
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "Failed to get file creation time for file '{0}'.", new object[]
					{
						appender.FileName
					});
					global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this.InvalidateAppender(appender.FileName);
					if (baseFileAppender != null)
					{
						baseFileAppender.Dispose();
					}
					throw;
				}
			}
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(filePath);
			if (fileInfo.Exists)
			{
				result = new global::System.DateTime?(global::NLog.Internal.FileCharacteristicsHelper.ValidateFileCreationTime<global::System.IO.FileInfo>(fileInfo, (global::System.IO.FileInfo f) => new global::System.DateTime?(f.GetCreationTimeUtc()), (global::System.IO.FileInfo f) => fallbackTimeSource, (global::System.IO.FileInfo f) => new global::System.DateTime?(f.GetLastWriteTimeUtc())).Value);
				return new global::System.DateTime?(global::NLog.Time.TimeSource.Current.FromSystemTime(result.Value));
			}
			return result;
		}

		// Token: 0x06000E6D RID: 3693 RVA: 0x00024F68 File Offset: 0x00023168
		public global::System.DateTime? GetFileLastWriteTimeUtc(string filePath)
		{
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(filePath);
			if (fileInfo.Exists)
			{
				return new global::System.DateTime?(fileInfo.GetLastWriteTimeUtc());
			}
			return null;
		}

		// Token: 0x06000E6E RID: 3694 RVA: 0x00024F9C File Offset: 0x0002319C
		public long? GetFileLength(string filePath)
		{
			global::NLog.Internal.FileAppenders.BaseFileAppender appender = this.GetAppender(filePath);
			if (appender != null)
			{
				try
				{
					long? fileLength = appender.GetFileLength();
					if (fileLength != null)
					{
						return fileLength;
					}
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "Failed to get length for file '{0}'.", new object[]
					{
						appender.FileName
					});
					global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this.InvalidateAppender(appender.FileName);
					if (baseFileAppender != null)
					{
						baseFileAppender.Dispose();
					}
					throw;
				}
			}
			global::System.IO.FileInfo fileInfo = new global::System.IO.FileInfo(filePath);
			if (fileInfo.Exists)
			{
				return new long?(fileInfo.Length);
			}
			return null;
		}

		// Token: 0x06000E6F RID: 3695 RVA: 0x00025034 File Offset: 0x00023234
		public global::NLog.Internal.FileAppenders.BaseFileAppender InvalidateAppender(string filePath)
		{
			for (int i = 0; i < this._appenders.Length; i++)
			{
				global::NLog.Internal.FileAppenders.BaseFileAppender baseFileAppender = this._appenders[i];
				if (baseFileAppender == null)
				{
					break;
				}
				if (string.Equals(baseFileAppender.FileName, filePath, global::System.StringComparison.OrdinalIgnoreCase))
				{
					for (int j = i; j < this._appenders.Length - 1; j++)
					{
						this._appenders[j] = this._appenders[j + 1];
					}
					this._appenders[this._appenders.Length - 1] = null;
					this.CloseAppender(baseFileAppender, "Invalidate", this._appenders[0] == null);
					return baseFileAppender;
				}
			}
			return null;
		}

		// Token: 0x06000E70 RID: 3696 RVA: 0x000250C4 File Offset: 0x000232C4
		private void CloseAppender(global::NLog.Internal.FileAppenders.BaseFileAppender appender, string reason, bool lastAppender)
		{
			global::NLog.Common.InternalLogger.Debug<string, string>("FileAppender Closing {0} - {1}", reason, appender.FileName);
			if (lastAppender)
			{
				this._autoClosingTimer.Change(-1, -1);
				this._externalFileArchivingWatcher.StopWatching();
				this._logFileWasArchived = false;
			}
			else
			{
				this._externalFileArchivingWatcher.StopWatching(appender.FileName);
			}
			appender.Close();
		}

		// Token: 0x06000E71 RID: 3697 RVA: 0x00025120 File Offset: 0x00023320
		public void Dispose()
		{
			this.CheckCloseAppenders = null;
			this._externalFileArchivingWatcher.Dispose();
			this._logFileWasArchived = false;
			global::System.Threading.Timer autoClosingTimer = this._autoClosingTimer;
			if (autoClosingTimer != null)
			{
				this._autoClosingTimer = null;
				autoClosingTimer.WaitForDispose(global::System.TimeSpan.Zero);
			}
		}

		// Token: 0x040003F7 RID: 1015
		private readonly global::NLog.Internal.FileAppenders.BaseFileAppender[] _appenders;

		// Token: 0x040003F8 RID: 1016
		private global::System.Threading.Timer _autoClosingTimer;

		// Token: 0x040003F9 RID: 1017
		private string _archiveFilePatternToWatch;

		// Token: 0x040003FA RID: 1018
		private readonly global::NLog.Internal.MultiFileWatcher _externalFileArchivingWatcher = new global::NLog.Internal.MultiFileWatcher(global::System.IO.NotifyFilters.FileName | global::System.IO.NotifyFilters.DirectoryName);

		// Token: 0x040003FB RID: 1019
		private bool _logFileWasArchived;

		// Token: 0x040003FC RID: 1020
		public static readonly global::NLog.Internal.FileAppenders.FileAppenderCache Empty = new global::NLog.Internal.FileAppenders.FileAppenderCache();
	}
}
