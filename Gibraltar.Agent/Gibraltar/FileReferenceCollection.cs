using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;

namespace Gibraltar
{
	// Token: 0x020000B2 RID: 178
	internal class FileReferenceCollection : global::System.Collections.Generic.IList<global::Gibraltar.FileReference>, global::System.Collections.Generic.ICollection<global::Gibraltar.FileReference>, global::System.Collections.Generic.IEnumerable<global::Gibraltar.FileReference>, global::System.Collections.IEnumerable, global::System.IDisposable
	{
		// Token: 0x14000022 RID: 34
		// (add) Token: 0x0600075A RID: 1882 RVA: 0x0000D6B8 File Offset: 0x0000B8B8
		// (remove) Token: 0x0600075B RID: 1883 RVA: 0x0000D6F4 File Offset: 0x0000B8F4
		public event global::System.ComponentModel.CollectionChangeEventHandler CollectionChanged;

		// Token: 0x0600075C RID: 1884 RVA: 0x0000D730 File Offset: 0x0000B930
		public FileReferenceCollection(string path, string filter)
		{
			if (path == null)
			{
				throw new global::System.ArgumentNullException("path");
			}
			this.m_Path = path.Trim();
			if (!global::System.IO.Directory.Exists(this.m_Path))
			{
				throw new global::System.IO.DirectoryNotFoundException(string.Format("The path '{0}' does not exist and therefore can't be monitored.", path));
			}
			this.m_Filter = filter;
			this.m_MonitoredDirectory = new global::System.IO.DirectoryInfo(this.m_Path);
			global::System.IO.FileInfo[] array = string.IsNullOrEmpty(this.m_Filter) ? this.m_MonitoredDirectory.GetFiles() : this.m_MonitoredDirectory.GetFiles(this.m_Filter);
			for (int i = 0; i < array.Length; i++)
			{
				global::Gibraltar.FileReference item = new global::Gibraltar.FileReference(array[i]);
				this.Add(item);
			}
			this.CreateDirectoryMonitorThread();
		}

		// Token: 0x0600075D RID: 1885 RVA: 0x0000D820 File Offset: 0x0000BA20
		public void Dispose()
		{
			this.m_Disposed = true;
		}

		// Token: 0x0600075E RID: 1886 RVA: 0x0000D82C File Offset: 0x0000BA2C
		public global::System.Collections.Generic.IEnumerator<global::Gibraltar.FileReference> GetEnumerator()
		{
			return this.m_FilesList.GetEnumerator();
		}

		// Token: 0x0600075F RID: 1887 RVA: 0x0000D840 File Offset: 0x0000BA40
		global::System.Collections.IEnumerator global::System.Collections.IEnumerable.GetEnumerator()
		{
			return this.GetEnumerator();
		}

		// Token: 0x06000760 RID: 1888 RVA: 0x0000D848 File Offset: 0x0000BA48
		public void Add(global::Gibraltar.FileReference item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			this.OnItemAdd(item, -1);
		}

		// Token: 0x06000761 RID: 1889 RVA: 0x0000D864 File Offset: 0x0000BA64
		public void Clear()
		{
			if (this.m_FilesList.Count > 0)
			{
				this.OnItemClear();
			}
		}

		// Token: 0x06000762 RID: 1890 RVA: 0x0000D880 File Offset: 0x0000BA80
		public bool Contains(global::Gibraltar.FileReference item)
		{
			return this.m_FilesDictionary.ContainsKey(item.FileNamePath);
		}

		// Token: 0x06000763 RID: 1891 RVA: 0x0000D894 File Offset: 0x0000BA94
		public bool ContainsKey(string key)
		{
			return this.m_FilesDictionary.ContainsKey(key);
		}

		// Token: 0x06000764 RID: 1892 RVA: 0x0000D8A4 File Offset: 0x0000BAA4
		public void CopyTo(global::Gibraltar.FileReference[] array, int arrayIndex)
		{
			this.m_FilesList.CopyTo(array, arrayIndex);
		}

		// Token: 0x06000765 RID: 1893 RVA: 0x0000D8B4 File Offset: 0x0000BAB4
		public bool Remove(global::Gibraltar.FileReference item)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "An item must be provided to remove it from the collection.");
			}
			return this.OnItemRemove(item);
		}

		// Token: 0x06000766 RID: 1894 RVA: 0x0000D8D4 File Offset: 0x0000BAD4
		public bool Remove(string key)
		{
			if (string.IsNullOrEmpty(key))
			{
				throw new global::System.ArgumentNullException("key", "A key must be provided to remove an item from the collection.");
			}
			global::Gibraltar.FileReference item;
			return this.TryGetValue(key, out item) && this.Remove(item);
		}

		// Token: 0x06000767 RID: 1895 RVA: 0x0000D920 File Offset: 0x0000BB20
		public bool Rename(string originalFileNamePath, string newFileNamePath)
		{
			if (string.IsNullOrEmpty(originalFileNamePath))
			{
				throw new global::System.ArgumentNullException("originalFileNamePath", "An original file name and path must be provided to rename an item in the collection.");
			}
			if (string.IsNullOrEmpty(newFileNamePath))
			{
				throw new global::System.ArgumentNullException("newFileNamePath", "An new file name and path must be provided to rename an item in the collection.");
			}
			global::Gibraltar.FileReference fileReference;
			this.TryGetValue(originalFileNamePath, out fileReference);
			global::Gibraltar.FileReference fileReference2;
			this.TryGetValue(newFileNamePath, out fileReference2);
			if (fileReference == null && fileReference2 == null)
			{
				throw new global::System.ArgumentOutOfRangeException("originalFileNamePath", "No item could be found in the collection by either the original or new name, indicating the file doesn't exist.");
			}
			if (fileReference != null && fileReference2 != null)
			{
				throw new global::System.ArgumentOutOfRangeException("newFileNamePath", "There is currently an item with the provided new file name in the collection, so the original can't be renamed.");
			}
			bool result = false;
			if (fileReference != null)
			{
				this.Remove(fileReference);
				fileReference.FileNamePath = newFileNamePath;
				fileReference.Caption = global::System.IO.Path.GetFileName(newFileNamePath);
				this.Add(fileReference);
				result = true;
			}
			return result;
		}

		// Token: 0x1700037B RID: 891
		// (get) Token: 0x06000768 RID: 1896 RVA: 0x0000D9E0 File Offset: 0x0000BBE0
		public int Count
		{
			get
			{
				return this.m_FilesList.Count;
			}
		}

		// Token: 0x1700037C RID: 892
		// (get) Token: 0x06000769 RID: 1897 RVA: 0x0000D9F0 File Offset: 0x0000BBF0
		public bool IsReadOnly
		{
			get
			{
				return false;
			}
		}

		// Token: 0x0600076A RID: 1898 RVA: 0x0000D9F4 File Offset: 0x0000BBF4
		public int IndexOf(global::Gibraltar.FileReference item)
		{
			return this.m_FilesList.IndexOf(item);
		}

		// Token: 0x0600076B RID: 1899 RVA: 0x0000DA04 File Offset: 0x0000BC04
		public void Insert(int index, global::Gibraltar.FileReference item)
		{
			if (index < 0 || index > this.m_FilesList.Count)
			{
				throw new global::System.IndexOutOfRangeException(string.Format("The provided index {0} is beyond the ends of the collection.", index));
			}
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item");
			}
			if (this.ContainsKey(item.FileNamePath))
			{
				throw new global::System.ArgumentException("There is already an item with the key '{0}' in the collection", item.FileNamePath);
			}
			this.OnItemAdd(item, index);
		}

		// Token: 0x0600076C RID: 1900 RVA: 0x0000DA80 File Offset: 0x0000BC80
		public void RemoveAt(int index)
		{
			global::Gibraltar.FileReference item = this.m_FilesList[index];
			this.Remove(item);
		}

		// Token: 0x1700037D RID: 893
		public global::Gibraltar.FileReference this[int index]
		{
			get
			{
				return this.m_FilesList[index];
			}
			set
			{
				if (value == null)
				{
					throw new global::System.ArgumentNullException("value");
				}
				if (index < 0 || index >= this.m_FilesList.Count)
				{
					throw new global::System.IndexOutOfRangeException(string.Format("The provided index {0} is beyond the ends of the collection.", index));
				}
				if (!this.m_FilesList[index].FileNamePath.Equals(value.FileNamePath, global::System.StringComparison.OrdinalIgnoreCase) && this.ContainsKey(value.FileNamePath))
				{
					throw new global::System.ArgumentException(string.Format("There is already a file reference with the full file name '{0}'", value.FileNamePath));
				}
				this.OnItemSet(index, value);
			}
		}

		// Token: 0x0600076F RID: 1903 RVA: 0x0000DB5C File Offset: 0x0000BD5C
		public bool TryGetValue(string key, out global::Gibraltar.FileReference value)
		{
			return this.m_FilesDictionary.TryGetValue(key, out value);
		}

		// Token: 0x06000770 RID: 1904 RVA: 0x0000DB6C File Offset: 0x0000BD6C
		internal void ClearItemFoundFlags()
		{
			foreach (global::Gibraltar.FileReference fileReference in this.m_FilesList)
			{
				fileReference.ItemFound = false;
			}
		}

		// Token: 0x06000771 RID: 1905 RVA: 0x0000DBC4 File Offset: 0x0000BDC4
		internal void RemoveItemsNotFound()
		{
			global::System.Collections.Generic.List<global::Gibraltar.FileReference> list = new global::System.Collections.Generic.List<global::Gibraltar.FileReference>();
			foreach (global::Gibraltar.FileReference fileReference in this.m_FilesList)
			{
				if (!fileReference.ItemFound)
				{
					list.Add(fileReference);
				}
			}
			foreach (global::Gibraltar.FileReference item in list)
			{
				this.Remove(item);
			}
		}

		// Token: 0x06000772 RID: 1906 RVA: 0x0000DC74 File Offset: 0x0000BE74
		protected virtual void OnCollectionChanged(global::System.ComponentModel.CollectionChangeEventArgs args)
		{
			global::System.ComponentModel.CollectionChangeEventHandler collectionChanged = this.CollectionChanged;
			if (collectionChanged != null)
			{
				collectionChanged(this, args);
			}
		}

		// Token: 0x06000773 RID: 1907 RVA: 0x0000DC9C File Offset: 0x0000BE9C
		protected virtual void OnItemAdd(global::Gibraltar.FileReference item, int index)
		{
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A new item must be provided to add it to the collection.");
			}
			this.m_FilesDictionary.Add(item.FileNamePath, item);
			if (index < 0)
			{
				this.m_FilesList.Add(item);
			}
			else
			{
				this.m_FilesList.Insert(index, item);
			}
			this.OnCollectionChanged(new global::System.ComponentModel.CollectionChangeEventArgs(global::System.ComponentModel.CollectionChangeAction.Add, item));
		}

		// Token: 0x06000774 RID: 1908 RVA: 0x0000DD08 File Offset: 0x0000BF08
		protected virtual void OnItemClear()
		{
			this.m_FilesList.Clear();
			this.m_FilesDictionary.Clear();
			this.OnCollectionChanged(new global::System.ComponentModel.CollectionChangeEventArgs(global::System.ComponentModel.CollectionChangeAction.Refresh, null));
		}

		// Token: 0x06000775 RID: 1909 RVA: 0x0000DD30 File Offset: 0x0000BF30
		protected virtual bool OnItemRemove(global::Gibraltar.FileReference item)
		{
			bool flag = false;
			if (item == null)
			{
				throw new global::System.ArgumentNullException("item", "A new item must be provided to remove it from the collection.");
			}
			if (this.m_FilesDictionary.ContainsKey(item.FileNamePath))
			{
				this.m_FilesDictionary.Remove(item.FileNamePath);
				flag = true;
			}
			if (this.m_FilesList.Contains(item))
			{
				this.m_FilesList.Remove(item);
				flag = true;
			}
			if (flag)
			{
				this.OnCollectionChanged(new global::System.ComponentModel.CollectionChangeEventArgs(global::System.ComponentModel.CollectionChangeAction.Remove, item));
			}
			return flag;
		}

		// Token: 0x06000776 RID: 1910 RVA: 0x0000DDB8 File Offset: 0x0000BFB8
		protected virtual void OnItemSet(int index, global::Gibraltar.FileReference item)
		{
			this.RemoveAt(index);
			this.m_FilesDictionary.Add(item.FileNamePath, item);
			this.m_FilesList[index] = item;
			this.OnCollectionChanged(new global::System.ComponentModel.CollectionChangeEventArgs(global::System.ComponentModel.CollectionChangeAction.Add, item));
		}

		// Token: 0x06000777 RID: 1911 RVA: 0x0000DDFC File Offset: 0x0000BFFC
		protected virtual bool OnDirectoryChange()
		{
			bool result = false;
			if (this.m_MonitoredDirectory.Exists)
			{
				this.m_CurrentPollStartDt = global::System.DateTime.Now;
				global::System.IO.FileInfo[] array = string.IsNullOrEmpty(this.m_Filter) ? this.m_MonitoredDirectory.GetFiles() : this.m_MonitoredDirectory.GetFiles(this.m_Filter);
				this.ClearItemFoundFlags();
				foreach (global::System.IO.FileInfo fileInfo in array)
				{
					global::Gibraltar.FileReference fileReference;
					if (this.TryGetValue(fileInfo.FullName, out fileReference))
					{
						if (fileInfo.LastWriteTime > fileReference.LastWriteTime)
						{
							result = true;
							fileReference.Refresh();
						}
					}
					else
					{
						result = true;
						fileReference = new global::Gibraltar.FileReference(fileInfo);
						this.Add(fileReference);
					}
					fileReference.ItemFound = true;
				}
				this.RemoveItemsNotFound();
				this.m_LastPollStartDt = this.m_CurrentPollStartDt;
			}
			return result;
		}

		// Token: 0x06000778 RID: 1912 RVA: 0x0000DEE0 File Offset: 0x0000C0E0
		private void CreateDirectoryMonitorThread()
		{
			object directoryMonitorThreadLock = this.m_DirectoryMonitorThreadLock;
			lock (directoryMonitorThreadLock)
			{
				this.m_DirectoryMonitorThread = new global::System.Threading.Thread(new global::System.Threading.ThreadStart(this.DirectoryMonitorMain));
				this.m_DirectoryMonitorThread.Name = "Gibraltar Directory Monitor";
				this.m_DirectoryMonitorThread.TrySetApartmentState(global::System.Threading.ApartmentState.MTA);
				this.m_DirectoryMonitorThread.IsBackground = true;
				this.m_DirectoryMonitorThread.Start();
				global::System.Threading.Monitor.PulseAll(this.m_DirectoryMonitorThreadLock);
			}
		}

		// Token: 0x06000779 RID: 1913 RVA: 0x0000DF6C File Offset: 0x0000C16C
		private bool CheckForChanges()
		{
			this.m_MonitoredDirectory.Refresh();
			return this.m_MonitoredDirectory.LastWriteTime > this.m_LastPollStartDt && this.OnDirectoryChange();
		}

		// Token: 0x0600077A RID: 1914 RVA: 0x0000DFB4 File Offset: 0x0000C1B4
		private void DirectoryMonitorMain()
		{
			try
			{
				global::System.Diagnostics.Trace.TraceInformation("Background Directory Monitor Started\r\nThe background monitor thread for directory '{0}' is starting.");
				while (!this.m_Disposed)
				{
					if (this.CheckForChanges())
					{
						global::System.Threading.Thread.Sleep(1000);
					}
					else
					{
						global::System.Threading.Thread.Sleep(15000);
					}
				}
				global::System.Diagnostics.Trace.TraceInformation("Background Directory Monitor Stopped\r\nThe background monitor thread for directory '{0}' is ending normally due to the collection being disposed.", new object[]
				{
					this.m_Path
				});
			}
			catch (global::System.Exception ex)
			{
				global::System.Diagnostics.Trace.TraceError("Error Processing Async File System Monitor Request\r\nWhile processing a file system monitor request, an exception was thrown: {0}", new object[]
				{
					ex.Message,
					ex
				});
			}
		}

		// Token: 0x04000163 RID: 355
		private const int WaitShortInterval = 1000;

		// Token: 0x04000164 RID: 356
		private const int WaitLongInterval = 15000;

		// Token: 0x04000165 RID: 357
		private readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.FileReference> m_FilesDictionary = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.FileReference>(global::System.StringComparer.OrdinalIgnoreCase);

		// Token: 0x04000166 RID: 358
		private readonly global::System.Collections.Generic.List<global::Gibraltar.FileReference> m_FilesList = new global::System.Collections.Generic.List<global::Gibraltar.FileReference>();

		// Token: 0x04000167 RID: 359
		private readonly string m_Path;

		// Token: 0x04000168 RID: 360
		private readonly string m_Filter;

		// Token: 0x04000169 RID: 361
		private readonly global::System.IO.DirectoryInfo m_MonitoredDirectory;

		// Token: 0x0400016A RID: 362
		private readonly object m_DirectoryMonitorThreadLock = new object();

		// Token: 0x0400016B RID: 363
		private global::System.Threading.Thread m_DirectoryMonitorThread;

		// Token: 0x0400016C RID: 364
		private global::System.DateTime m_CurrentPollStartDt;

		// Token: 0x0400016D RID: 365
		private global::System.DateTime m_LastPollStartDt;

		// Token: 0x0400016E RID: 366
		private bool m_Disposed;
	}
}
