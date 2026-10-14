using System;
using System.Collections.Generic;
using System.IO;
using NLog.Common;

namespace NLog.Internal
{
	// Token: 0x02000110 RID: 272
	internal sealed class MultiFileWatcher : global::System.IDisposable
	{
		// Token: 0x17000280 RID: 640
		// (get) Token: 0x06000D0F RID: 3343 RVA: 0x000202A0 File Offset: 0x0001E4A0
		// (set) Token: 0x06000D10 RID: 3344 RVA: 0x000202A8 File Offset: 0x0001E4A8
		public global::System.IO.NotifyFilters NotifyFilters { get; set; }

		// Token: 0x14000016 RID: 22
		// (add) Token: 0x06000D11 RID: 3345 RVA: 0x000202B4 File Offset: 0x0001E4B4
		// (remove) Token: 0x06000D12 RID: 3346 RVA: 0x000202EC File Offset: 0x0001E4EC
		public event global::System.IO.FileSystemEventHandler FileChanged;

		// Token: 0x06000D13 RID: 3347 RVA: 0x00020321 File Offset: 0x0001E521
		public MultiFileWatcher() : this(global::System.IO.NotifyFilters.Attributes | global::System.IO.NotifyFilters.Size | global::System.IO.NotifyFilters.LastWrite | global::System.IO.NotifyFilters.CreationTime | global::System.IO.NotifyFilters.Security)
		{
		}

		// Token: 0x06000D14 RID: 3348 RVA: 0x0002032E File Offset: 0x0001E52E
		public MultiFileWatcher(global::System.IO.NotifyFilters notifyFilters)
		{
			this.NotifyFilters = notifyFilters;
		}

		// Token: 0x06000D15 RID: 3349 RVA: 0x00020348 File Offset: 0x0001E548
		public void Dispose()
		{
			this.FileChanged = null;
			this.StopWatching();
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000D16 RID: 3350 RVA: 0x00020360 File Offset: 0x0001E560
		public void StopWatching()
		{
			lock (this)
			{
				foreach (global::System.IO.FileSystemWatcher watcher in this._watcherMap.Values)
				{
					this.StopWatching(watcher);
				}
				this._watcherMap.Clear();
			}
		}

		// Token: 0x06000D17 RID: 3351 RVA: 0x000203E8 File Offset: 0x0001E5E8
		public void StopWatching(string fileName)
		{
			lock (this)
			{
				global::System.IO.FileSystemWatcher watcher;
				if (this._watcherMap.TryGetValue(fileName, out watcher))
				{
					this.StopWatching(watcher);
					this._watcherMap.Remove(fileName);
				}
			}
		}

		// Token: 0x06000D18 RID: 3352 RVA: 0x00020444 File Offset: 0x0001E644
		public void Watch(global::System.Collections.Generic.IEnumerable<string> fileNames)
		{
			if (fileNames == null)
			{
				return;
			}
			foreach (string fileName in fileNames)
			{
				this.Watch(fileName);
			}
		}

		// Token: 0x06000D19 RID: 3353 RVA: 0x00020490 File Offset: 0x0001E690
		internal void Watch(string fileName)
		{
			string directoryName = global::System.IO.Path.GetDirectoryName(fileName);
			if (!global::System.IO.Directory.Exists(directoryName))
			{
				global::NLog.Common.InternalLogger.Warn<string>("Cannot watch {0} for changes as it doesn't exist", directoryName);
				return;
			}
			lock (this)
			{
				if (!this._watcherMap.ContainsKey(fileName))
				{
					global::System.IO.FileSystemWatcher fileSystemWatcher = null;
					try
					{
						fileSystemWatcher = new global::System.IO.FileSystemWatcher
						{
							Path = directoryName,
							Filter = global::System.IO.Path.GetFileName(fileName),
							NotifyFilter = this.NotifyFilters
						};
						fileSystemWatcher.Created += this.OnFileChanged;
						fileSystemWatcher.Changed += this.OnFileChanged;
						fileSystemWatcher.Deleted += this.OnFileChanged;
						fileSystemWatcher.Renamed += new global::System.IO.RenamedEventHandler(this.OnFileChanged);
						fileSystemWatcher.Error += this.OnWatcherError;
						fileSystemWatcher.EnableRaisingEvents = true;
						global::NLog.Common.InternalLogger.Debug<string, string>("Watching path '{0}' filter '{1}' for changes.", fileSystemWatcher.Path, fileSystemWatcher.Filter);
						this._watcherMap.Add(fileName, fileSystemWatcher);
					}
					catch (global::System.Exception ex)
					{
						global::NLog.Common.InternalLogger.Error(ex, "Failed Watching path '{0}' with file '{1}' for changes.", new object[]
						{
							directoryName,
							fileName
						});
						if (ex.MustBeRethrown())
						{
							throw;
						}
						if (fileSystemWatcher != null)
						{
							this.StopWatching(fileSystemWatcher);
						}
					}
				}
			}
		}

		// Token: 0x06000D1A RID: 3354 RVA: 0x000205E0 File Offset: 0x0001E7E0
		private void StopWatching(global::System.IO.FileSystemWatcher watcher)
		{
			try
			{
				global::NLog.Common.InternalLogger.Debug<string, string>("Stopping file watching for path '{0}' filter '{1}'", watcher.Path, watcher.Filter);
				watcher.EnableRaisingEvents = false;
				watcher.Created -= this.OnFileChanged;
				watcher.Changed -= this.OnFileChanged;
				watcher.Deleted -= this.OnFileChanged;
				watcher.Renamed -= new global::System.IO.RenamedEventHandler(this.OnFileChanged);
				watcher.Error -= this.OnWatcherError;
				watcher.Dispose();
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "Failed to stop file watcher for path '{0}' filter '{1}'", new object[]
				{
					watcher.Path,
					watcher.Filter
				});
				if (ex.MustBeRethrown())
				{
					throw;
				}
			}
		}

		// Token: 0x06000D1B RID: 3355 RVA: 0x000206AC File Offset: 0x0001E8AC
		private void OnWatcherError(object source, global::System.IO.ErrorEventArgs e)
		{
			string text = string.Empty;
			global::System.IO.FileSystemWatcher fileSystemWatcher = source as global::System.IO.FileSystemWatcher;
			if (fileSystemWatcher != null)
			{
				text = fileSystemWatcher.Path;
			}
			global::System.Exception exception = e.GetException();
			if (exception != null)
			{
				global::NLog.Common.InternalLogger.Warn(exception, "Error Watching Path {0}", new object[]
				{
					text
				});
				return;
			}
			global::NLog.Common.InternalLogger.Warn<string>("Error Watching Path {0}", text);
		}

		// Token: 0x06000D1C RID: 3356 RVA: 0x000206FC File Offset: 0x0001E8FC
		private void OnFileChanged(object source, global::System.IO.FileSystemEventArgs e)
		{
			global::System.IO.FileSystemEventHandler fileChanged = this.FileChanged;
			if (fileChanged != null)
			{
				try
				{
					fileChanged(source, e);
				}
				catch (global::System.Exception ex)
				{
					global::NLog.Common.InternalLogger.Error(ex, "Error Handling File Changed");
					if (ex.MustBeRethrownImmediately())
					{
						throw;
					}
				}
			}
		}

		// Token: 0x040003A1 RID: 929
		private readonly global::System.Collections.Generic.Dictionary<string, global::System.IO.FileSystemWatcher> _watcherMap = new global::System.Collections.Generic.Dictionary<string, global::System.IO.FileSystemWatcher>();
	}
}
