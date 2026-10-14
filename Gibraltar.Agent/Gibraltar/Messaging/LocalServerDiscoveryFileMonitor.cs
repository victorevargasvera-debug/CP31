using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;
using Gibraltar.Data;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar.Messaging
{
	// Token: 0x02000223 RID: 547
	internal class LocalServerDiscoveryFileMonitor
	{
		// Token: 0x14000080 RID: 128
		// (add) Token: 0x06001BA2 RID: 7074 RVA: 0x00060094 File Offset: 0x0005E294
		// (remove) Token: 0x06001BA3 RID: 7075 RVA: 0x000600D0 File Offset: 0x0005E2D0
		public event global::Gibraltar.Messaging.LocalServerDiscoveryFileEventHandler FileChanged;

		// Token: 0x14000081 RID: 129
		// (add) Token: 0x06001BA4 RID: 7076 RVA: 0x0006010C File Offset: 0x0005E30C
		// (remove) Token: 0x06001BA5 RID: 7077 RVA: 0x00060148 File Offset: 0x0005E348
		public event global::Gibraltar.Messaging.LocalServerDiscoveryFileEventHandler FileDeleted;

		// Token: 0x06001BA6 RID: 7078 RVA: 0x00060184 File Offset: 0x0005E384
		public void Start()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_FileSystemWatcher == null)
				{
					string path = global::Gibraltar.Data.PathManager.FindBestPath(global::Gibraltar.Data.PathType.Discovery);
					this.m_FileSystemWatcher = new global::System.IO.FileSystemWatcher(path, "*.gpd");
					this.m_FileSystemWatcher.NotifyFilter = global::System.IO.NotifyFilters.LastWrite;
					this.m_FileSystemWatcher.Changed += this.FileSystemWatcherOnChanged;
					this.m_FileSystemWatcher.Deleted += this.FileSystemWatcherOnDeleted;
				}
				this.m_FileSystemWatcher.EnableRaisingEvents = true;
				foreach (string fullPath in global::System.IO.Directory.GetFileSystemEntries(this.m_FileSystemWatcher.Path, "*.gpd"))
				{
					this.CheckRaiseChangedEvent(fullPath);
				}
			}
		}

		// Token: 0x06001BA7 RID: 7079 RVA: 0x0006025C File Offset: 0x0005E45C
		public void Stop()
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (this.m_FileSystemWatcher != null)
				{
					this.m_FileSystemWatcher.EnableRaisingEvents = false;
					this.m_FileSystemWatcher.Dispose();
					this.m_FileSystemWatcher = null;
				}
			}
		}

		// Token: 0x06001BA8 RID: 7080 RVA: 0x000602BC File Offset: 0x0005E4BC
		protected virtual void OnFileChanged(global::Gibraltar.Messaging.LocalServerDiscoveryFileEventArgs e)
		{
			global::Gibraltar.Messaging.LocalServerDiscoveryFileEventHandler fileChanged = this.FileChanged;
			if (fileChanged != null)
			{
				fileChanged(this, e);
			}
		}

		// Token: 0x06001BA9 RID: 7081 RVA: 0x000602E4 File Offset: 0x0005E4E4
		protected virtual void OnFileDeleted(global::Gibraltar.Messaging.LocalServerDiscoveryFileEventArgs e)
		{
			global::Gibraltar.Messaging.LocalServerDiscoveryFileEventHandler fileDeleted = this.FileDeleted;
			if (fileDeleted != null)
			{
				fileDeleted(this, e);
			}
		}

		// Token: 0x06001BAA RID: 7082 RVA: 0x0006030C File Offset: 0x0005E50C
		private void EnsureQueueProcessorRunning()
		{
			if (!this.m_ActiveThread)
			{
				this.m_ActiveThread = true;
				global::System.Threading.ThreadPool.QueueUserWorkItem(new global::System.Threading.WaitCallback(this.AsyncProcessQueue));
			}
		}

		// Token: 0x06001BAB RID: 7083 RVA: 0x00060338 File Offset: 0x0005E538
		private void AsyncProcessQueue(object state)
		{
			try
			{
				global::System.IO.FileSystemEventArgs fileSystemEventArgs = null;
				do
				{
					fileSystemEventArgs = null;
					object queueLock = this.m_QueueLock;
					lock (queueLock)
					{
						if (this.m_FileEventQueue.Count > 0)
						{
							fileSystemEventArgs = this.m_FileEventQueue.Dequeue();
						}
						else
						{
							this.m_ActiveThread = false;
						}
					}
					if (fileSystemEventArgs != null)
					{
						if (fileSystemEventArgs.ChangeType == global::System.IO.WatcherChangeTypes.Deleted)
						{
							this.CheckRaiseDeletedEvent(fileSystemEventArgs.FullPath);
						}
						else if (fileSystemEventArgs.ChangeType == global::System.IO.WatcherChangeTypes.Created || fileSystemEventArgs.ChangeType == global::System.IO.WatcherChangeTypes.Changed)
						{
							this.CheckRaiseChangedEvent(fileSystemEventArgs.FullPath);
						}
					}
				}
				while (fileSystemEventArgs != null);
			}
			catch (global::System.Exception ex)
			{
				if (!global::Gibraltar.Monitor.Log.SilentMode)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, "Loupe.Network.Messenger", "local server discovery file monitor queue event threw an exception, queue processing will pause", "While we were dequeueing items or raising events an exception was thrown.  Queue processing will be interupted until the next request comes in and the request that caused the exception will be dropped.\r\n{0} exception thrown:\r\n{1}", new object[]
					{
						ex.GetType(),
						ex.Message
					});
				}
				this.m_ActiveThread = false;
			}
		}

		// Token: 0x06001BAC RID: 7084 RVA: 0x00060444 File Offset: 0x0005E644
		private void CheckRaiseChangedEvent(string fullPath)
		{
			global::Gibraltar.Messaging.LocalServerDiscoveryFileEventArgs localServerDiscoveryFileEventArgs = null;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Messaging.LocalServerDiscoveryFile localServerDiscoveryFile = null;
				if (!this.m_DiscoveryFiles.ContainsKey(fullPath))
				{
					try
					{
						localServerDiscoveryFile = new global::Gibraltar.Messaging.LocalServerDiscoveryFile(fullPath);
						if (localServerDiscoveryFile.IsAlive)
						{
							this.m_DiscoveryFiles.Add(fullPath, localServerDiscoveryFile);
						}
					}
					catch (global::System.Exception ex)
					{
						if (!global::Gibraltar.Monitor.Log.SilentMode)
						{
							global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Information, "Loupe.Network.Messenger", "Unable to load local server discovery file due to " + ex.GetType() + " exception", "While attempting to load a local server discovery file an exception was thrown.  If this is because the file wasn't found or was incomplete it can be ignored.  An incomplete file will raise another event when complete that will cause it to be re-processed.\r\nFile: {0}\r\nException: {1}", new object[]
							{
								fullPath,
								ex.Message
							});
						}
					}
					if (localServerDiscoveryFile != null)
					{
						localServerDiscoveryFileEventArgs = new global::Gibraltar.Messaging.LocalServerDiscoveryFileEventArgs(localServerDiscoveryFile);
					}
				}
			}
			if (localServerDiscoveryFileEventArgs != null)
			{
				this.OnFileChanged(localServerDiscoveryFileEventArgs);
			}
		}

		// Token: 0x06001BAD RID: 7085 RVA: 0x00060524 File Offset: 0x0005E724
		private void CheckRaiseDeletedEvent(string fullPath)
		{
			global::Gibraltar.Messaging.LocalServerDiscoveryFileEventArgs localServerDiscoveryFileEventArgs = null;
			object @lock = this.m_Lock;
			lock (@lock)
			{
				global::Gibraltar.Messaging.LocalServerDiscoveryFile file;
				if (this.m_DiscoveryFiles.TryGetValue(fullPath, out file))
				{
					this.m_DiscoveryFiles.Remove(fullPath);
					localServerDiscoveryFileEventArgs = new global::Gibraltar.Messaging.LocalServerDiscoveryFileEventArgs(file);
				}
			}
			if (localServerDiscoveryFileEventArgs != null)
			{
				this.OnFileDeleted(localServerDiscoveryFileEventArgs);
			}
		}

		// Token: 0x06001BAE RID: 7086 RVA: 0x00060590 File Offset: 0x0005E790
		private void FileSystemWatcherOnDeleted(object sender, global::System.IO.FileSystemEventArgs fileSystemEventArgs)
		{
			global::System.Collections.Generic.Queue<global::System.IO.FileSystemEventArgs> fileEventQueue = this.m_FileEventQueue;
			lock (fileEventQueue)
			{
				this.m_FileEventQueue.Enqueue(fileSystemEventArgs);
			}
			this.EnsureQueueProcessorRunning();
		}

		// Token: 0x06001BAF RID: 7087 RVA: 0x000605D8 File Offset: 0x0005E7D8
		private void FileSystemWatcherOnChanged(object sender, global::System.IO.FileSystemEventArgs fileSystemEventArgs)
		{
			global::System.Collections.Generic.Queue<global::System.IO.FileSystemEventArgs> fileEventQueue = this.m_FileEventQueue;
			lock (fileEventQueue)
			{
				this.m_FileEventQueue.Enqueue(fileSystemEventArgs);
			}
			this.EnsureQueueProcessorRunning();
		}

		// Token: 0x040009F2 RID: 2546
		private readonly object m_Lock = new object();

		// Token: 0x040009F3 RID: 2547
		private readonly object m_QueueLock = new object();

		// Token: 0x040009F4 RID: 2548
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Messaging.LocalServerDiscoveryFile> m_DiscoveryFiles = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Messaging.LocalServerDiscoveryFile>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x040009F5 RID: 2549
		private readonly global::System.Collections.Generic.Queue<global::System.IO.FileSystemEventArgs> m_FileEventQueue = new global::System.Collections.Generic.Queue<global::System.IO.FileSystemEventArgs>();

		// Token: 0x040009F6 RID: 2550
		private volatile bool m_ActiveThread;

		// Token: 0x040009F7 RID: 2551
		private global::System.IO.FileSystemWatcher m_FileSystemWatcher;
	}
}
