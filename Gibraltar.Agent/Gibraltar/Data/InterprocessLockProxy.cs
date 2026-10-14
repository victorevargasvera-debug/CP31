using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using Microsoft.Win32.SafeHandles;

namespace Gibraltar.Data
{
	// Token: 0x020000E0 RID: 224
	internal class InterprocessLockProxy
	{
		// Token: 0x14000031 RID: 49
		// (add) Token: 0x0600093E RID: 2366 RVA: 0x00015118 File Offset: 0x00013318
		// (remove) Token: 0x0600093F RID: 2367 RVA: 0x00015154 File Offset: 0x00013354
		internal event global::System.EventHandler Disposed;

		// Token: 0x06000940 RID: 2368 RVA: 0x00015190 File Offset: 0x00013390
		internal InterprocessLockProxy(string indexPath, string lockName, bool deleteOnClose)
		{
			this.m_IndexPath = indexPath;
			this.m_LockName = lockName;
			this.m_DeleteOnClose = deleteOnClose;
			this.m_LockFullFileNamePath = global::Gibraltar.Data.InterprocessLockProxy.GetLockFileName(indexPath, lockName);
		}

		// Token: 0x06000941 RID: 2369 RVA: 0x000151EC File Offset: 0x000133EC
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x17000404 RID: 1028
		// (get) Token: 0x06000942 RID: 2370 RVA: 0x000151FC File Offset: 0x000133FC
		public string FullName
		{
			get
			{
				return this.m_LockFullFileNamePath;
			}
		}

		// Token: 0x17000405 RID: 1029
		// (get) Token: 0x06000943 RID: 2371 RVA: 0x00015204 File Offset: 0x00013404
		public string IndexPath
		{
			get
			{
				return this.m_IndexPath;
			}
		}

		// Token: 0x17000406 RID: 1030
		// (get) Token: 0x06000944 RID: 2372 RVA: 0x0001520C File Offset: 0x0001340C
		public string LockName
		{
			get
			{
				return this.m_LockName;
			}
		}

		// Token: 0x17000407 RID: 1031
		// (get) Token: 0x06000945 RID: 2373 RVA: 0x00015214 File Offset: 0x00013414
		public bool IsDisposed
		{
			get
			{
				return this.m_Disposed;
			}
		}

		// Token: 0x17000408 RID: 1032
		// (get) Token: 0x06000946 RID: 2374 RVA: 0x0001521C File Offset: 0x0001341C
		public int WaitingCount
		{
			get
			{
				if (this.m_CurrentLockTurn != null)
				{
					return this.m_WaitQueue.Count;
				}
				return -1;
			}
		}

		// Token: 0x17000409 RID: 1033
		// (get) Token: 0x06000947 RID: 2375 RVA: 0x00015238 File Offset: 0x00013438
		internal global::Gibraltar.Data.InterprocessLock CurrentLockTurn
		{
			get
			{
				return this.m_CurrentLockTurn;
			}
		}

		// Token: 0x1700040A RID: 1034
		// (get) Token: 0x06000948 RID: 2376 RVA: 0x00015240 File Offset: 0x00013440
		internal object CurrentTurnOwner
		{
			get
			{
				if (this.m_CurrentLockTurn != null)
				{
					return this.m_CurrentLockTurn.Owner;
				}
				return null;
			}
		}

		// Token: 0x1700040B RID: 1035
		// (get) Token: 0x06000949 RID: 2377 RVA: 0x0001525C File Offset: 0x0001345C
		internal global::System.Threading.Thread CurrentTurnThread
		{
			get
			{
				if (this.m_CurrentLockTurn != null)
				{
					return this.m_CurrentLockTurn.OwningThread;
				}
				return null;
			}
		}

		// Token: 0x1700040C RID: 1036
		// (get) Token: 0x0600094A RID: 2378 RVA: 0x00015278 File Offset: 0x00013478
		internal int CurrentTurnThreadId
		{
			get
			{
				if (this.m_CurrentLockTurn == null)
				{
					return -1;
				}
				return this.m_CurrentLockTurn.OwningThread.ManagedThreadId;
			}
		}

		// Token: 0x1700040D RID: 1037
		// (get) Token: 0x0600094B RID: 2379 RVA: 0x00015298 File Offset: 0x00013498
		// (set) Token: 0x0600094C RID: 2380 RVA: 0x000152A0 File Offset: 0x000134A0
		internal bool DisposeOnClose
		{
			get
			{
				return this.m_DisposeOnClose;
			}
			set
			{
				this.m_DisposeOnClose = value;
			}
		}

		// Token: 0x0600094D RID: 2381 RVA: 0x000152AC File Offset: 0x000134AC
		internal global::System.Threading.Thread CheckCurrentTurnThread(global::Gibraltar.Data.InterprocessLock candidateLock)
		{
			if (candidateLock != null && candidateLock.OwningThread != global::System.Threading.Thread.CurrentThread)
			{
				throw new global::System.InvalidOperationException("A lock request may only be waited on by the thread which created it.");
			}
			object queueLock = this.m_QueueLock;
			global::System.Threading.Thread result;
			lock (queueLock)
			{
				if (this.m_CurrentLockTurn != null)
				{
					global::System.Threading.Thread owningThread = this.m_CurrentLockTurn.OwningThread;
					if (candidateLock != null && global::System.Threading.Thread.CurrentThread == owningThread)
					{
						candidateLock.GrantTheLock(this.m_CurrentLockTurn);
						if (candidateLock.ActualLock == this.m_CurrentLockTurn)
						{
							candidateLock.OurLockProxy = this;
						}
					}
					result = owningThread;
				}
				else
				{
					result = null;
				}
			}
			return result;
		}

		// Token: 0x0600094E RID: 2382 RVA: 0x0001535C File Offset: 0x0001355C
		internal void QueueRequest(global::Gibraltar.Data.InterprocessLock lockRequest)
		{
			if (!string.Equals(lockRequest.FullName, this.m_LockFullFileNamePath, global::System.StringComparison.OrdinalIgnoreCase))
			{
				throw new global::System.InvalidOperationException("A lock request may not be queued to a proxy for a different full name.");
			}
			if (lockRequest.OwningThread != global::System.Threading.Thread.CurrentThread)
			{
				throw new global::System.InvalidOperationException("A lock request may only be queued by the thread which created it.");
			}
			object queueLock = this.m_QueueLock;
			lock (queueLock)
			{
				this.m_WaitQueue.Enqueue(lockRequest);
			}
		}

		// Token: 0x0600094F RID: 2383 RVA: 0x000153DC File Offset: 0x000135DC
		internal bool AwaitOurTurnOrTimeout(global::Gibraltar.Data.InterprocessLock lockRequest)
		{
			if (lockRequest.IsExpired)
			{
				throw new global::System.InvalidOperationException("Can't wait on an expired lock request.");
			}
			if (!string.Equals(lockRequest.FullName, this.m_LockFullFileNamePath, global::System.StringComparison.OrdinalIgnoreCase))
			{
				throw new global::System.InvalidOperationException("A lock request may not be queued to a proxy for a different full name.");
			}
			if (lockRequest.OwningThread != global::System.Threading.Thread.CurrentThread)
			{
				throw new global::System.InvalidOperationException("A lock request may only be waited on by the thread which created it.");
			}
			lockRequest.OurLockProxy = this;
			bool flag = this.StartNextTurn(lockRequest);
			if (!flag)
			{
				if (lockRequest.WaitForLock && lockRequest.WaitTimeout > global::System.DateTimeOffset.Now)
				{
					flag = lockRequest.AwaitTurnOrTimeout();
				}
				if (!flag)
				{
					if (!global::Gibraltar.CommonCentralLogic.SilentMode)
					{
						if (this.m_CurrentLockTurn != null)
						{
							global::System.Threading.Thread owningThread = this.m_CurrentLockTurn.OwningThread;
							int num = -1;
							string text = "null";
							if (owningThread != null)
							{
								num = owningThread.ManagedThreadId;
								text = (owningThread.Name ?? string.Empty);
							}
							global::System.Diagnostics.Trace.WriteLine(string.Format("{0}\r\nA lock request gave up because it is still being held by another thread.\r\nLock file: {1}\r\nCurrent holding thread: {2} ({3})", new object[]
							{
								lockRequest.WaitForLock ? "Lock request timed out" : "Lock request couldn't wait",
								this.m_LockFullFileNamePath,
								num,
								text
							}));
						}
						else
						{
							global::System.Diagnostics.Trace.TraceError("Lock request turn error\r\nA lock request failed to get its turn but the current lock turn is null.  This probably should not happen.\r\nLock file: {0}\r\n", new object[]
							{
								this.m_LockFullFileNamePath
							});
						}
					}
					lockRequest.Dispose();
					return false;
				}
			}
			bool flag2 = this.m_FileLock != null || this.TryGetLock(lockRequest);
			if (flag2)
			{
				lockRequest.GrantTheLock(lockRequest);
			}
			else
			{
				if (!global::Gibraltar.CommonCentralLogic.SilentMode)
				{
					global::System.Diagnostics.Trace.WriteLine(string.Format("{0}\r\nA lock request gave up because it could not obtain the file lock.  It is most likely still held by another process.\r\nLock file: {1}", lockRequest.WaitForLock ? "Lock request timed out" : "Lock request couldn't wait", this.m_LockFullFileNamePath));
				}
				lockRequest.Dispose();
			}
			return flag2;
		}

		// Token: 0x06000950 RID: 2384 RVA: 0x000155AC File Offset: 0x000137AC
		internal static string GetLockFileName(string indexPath, string lockName)
		{
			return global::System.IO.Path.Combine(indexPath, lockName + ".lock");
		}

		// Token: 0x06000951 RID: 2385 RVA: 0x000155C0 File Offset: 0x000137C0
		private bool TryGetLock(global::Gibraltar.Data.InterprocessLock currentRequest)
		{
			bool waitForLock = currentRequest.WaitForLock;
			global::System.DateTimeOffset waitTimeout = currentRequest.WaitTimeout;
			bool flag = false;
			while (!waitForLock || global::System.DateTimeOffset.Now < waitTimeout)
			{
				if (global::System.DateTimeOffset.Now >= this.m_MinTimeNextTurn)
				{
					this.m_FileLock = this.GetFileLock(this.m_LockFullFileNamePath);
					if (this.m_FileLock != null)
					{
						if (this.m_LockRequest != null)
						{
							this.m_LockRequest.Dispose();
							this.m_LockRequest = null;
						}
						flag = true;
					}
				}
				if (flag || !waitForLock)
				{
					break;
				}
				if (this.m_LockRequest == null)
				{
					this.m_LockRequest = this.GetLockRequest(this.m_LockFullFileNamePath);
				}
				global::System.Threading.Thread.Sleep(16);
			}
			return flag;
		}

		// Token: 0x06000952 RID: 2386 RVA: 0x00015680 File Offset: 0x00013880
		private bool StartNextTurn(global::Gibraltar.Data.InterprocessLock currentRequest)
		{
			object queueLock = this.m_QueueLock;
			bool result;
			lock (queueLock)
			{
				int num = this.DequeueNextRequest();
				if (this.m_CurrentLockTurn != null)
				{
					if (num > 0)
					{
						this.m_CurrentLockTurn.SignalMyTurn();
					}
					if (this.m_CurrentLockTurn == currentRequest)
					{
						return true;
					}
				}
				else
				{
					if (this.m_LockRequest != null)
					{
						this.m_LockRequest.Dispose();
						this.m_LockRequest = null;
					}
					if (this.m_FileLock != null)
					{
						this.m_FileLock.Dispose();
						this.m_FileLock = null;
					}
					if (this.m_DisposeOnClose)
					{
						this.Dispose();
					}
				}
				result = false;
			}
			return result;
		}

		// Token: 0x06000953 RID: 2387 RVA: 0x0001573C File Offset: 0x0001393C
		private int DequeueNextRequest()
		{
			object queueLock = this.m_QueueLock;
			int result;
			lock (queueLock)
			{
				int num = 0;
				global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
				try
				{
				}
				finally
				{
					while (this.m_CurrentLockTurn == null && this.m_WaitQueue.Count > 0)
					{
						this.m_CurrentLockTurn = this.m_WaitQueue.Dequeue();
						num++;
						if (this.m_CurrentLockTurn.IsExpired)
						{
							this.m_CurrentLockTurn.Dispose();
							this.m_CurrentLockTurn = null;
						}
						else
						{
							this.m_CurrentLockTurn.Disposed += this.Lock_Disposed;
						}
					}
				}
				result = num;
			}
			return result;
		}

		// Token: 0x06000954 RID: 2388 RVA: 0x00015800 File Offset: 0x00013A00
		private void Dispose(bool releaseManaged)
		{
			if (releaseManaged)
			{
				object queueLock = this.m_QueueLock;
				lock (queueLock)
				{
					if (!this.m_Disposed)
					{
						this.m_Disposed = true;
						while (this.m_WaitQueue.Count > 0)
						{
							this.m_WaitQueue.Dequeue().Dispose();
						}
						if (this.m_CurrentLockTurn == null)
						{
							if (this.m_LockRequest != null)
							{
								this.m_LockRequest.Dispose();
								this.m_LockRequest = null;
							}
							if (this.m_FileLock != null)
							{
								this.m_FileLock.Dispose();
								this.m_FileLock = null;
							}
						}
						this.OnDispose();
					}
					return;
				}
			}
			if (this.m_LockRequest != null)
			{
				this.m_LockRequest.Dispose();
				this.m_LockRequest = null;
			}
			if (this.m_FileLock != null)
			{
				this.m_FileLock.Dispose();
				this.m_FileLock = null;
			}
		}

		// Token: 0x06000955 RID: 2389 RVA: 0x000158F8 File Offset: 0x00013AF8
		private void OnDispose()
		{
			global::System.EventHandler disposed = this.Disposed;
			if (disposed != null)
			{
				disposed(this, new global::System.EventArgs());
			}
		}

		// Token: 0x06000956 RID: 2390 RVA: 0x00015924 File Offset: 0x00013B24
		private void Lock_Disposed(object sender, global::System.EventArgs e)
		{
			global::Gibraltar.Data.InterprocessLock interprocessLock = (global::Gibraltar.Data.InterprocessLock)sender;
			interprocessLock.Disposed -= this.Lock_Disposed;
			object queueLock = this.m_QueueLock;
			lock (queueLock)
			{
				if (this.m_CurrentLockTurn != null && this.m_CurrentLockTurn == interprocessLock)
				{
					this.m_CurrentLockTurn = null;
					if (!this.m_Disposed)
					{
						if (this.m_FileLock != null && this.CheckLockRequest(this.m_LockFullFileNamePath))
						{
							this.m_MinTimeNextTurn = global::System.DateTimeOffset.Now.AddMilliseconds(48.0);
							this.m_FileLock.Dispose();
							this.m_FileLock = null;
						}
						this.StartNextTurn(null);
					}
					else
					{
						if (this.m_LockRequest != null)
						{
							this.m_LockRequest.Dispose();
							this.m_LockRequest = null;
						}
						if (this.m_FileLock != null)
						{
							this.m_FileLock.Dispose();
							this.m_FileLock = null;
						}
					}
				}
			}
		}

		// Token: 0x06000957 RID: 2391 RVA: 0x00015A34 File Offset: 0x00013C34
		private global::Gibraltar.Data.FileLock GetFileLock(string lockFullFileNamePath)
		{
			global::Gibraltar.Data.FileLock fileLock = null;
			try
			{
				global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(lockFullFileNamePath));
			}
			catch (global::System.UnauthorizedAccessException obj)
			{
				global::System.GC.KeepAlive(obj);
				throw;
			}
			catch (global::System.Exception obj2)
			{
				global::System.GC.KeepAlive(obj2);
			}
			try
			{
				fileLock = this.OpenFileAccess(lockFullFileNamePath, global::System.IO.FileAccess.Write, global::System.IO.FileShare.Read, this.m_DeleteOnClose);
			}
			catch (global::System.Threading.ThreadAbortException)
			{
				if (fileLock != null)
				{
					fileLock.Dispose();
				}
				throw;
			}
			catch
			{
				fileLock = null;
			}
			return fileLock;
		}

		// Token: 0x06000958 RID: 2392 RVA: 0x00015AC8 File Offset: 0x00013CC8
		private global::Gibraltar.Data.FileLock GetLockRequest(string lockFullFileNamePath)
		{
			try
			{
				global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(lockFullFileNamePath));
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
			global::System.IO.FileShare fileShare = global::System.IO.FileShare.ReadWrite;
			if (global::Gibraltar.CommonCentralLogic.IsMonoRuntime)
			{
				lockFullFileNamePath += "req";
				fileShare = global::System.IO.FileShare.Read;
			}
			global::Gibraltar.Data.FileLock result;
			try
			{
				result = this.OpenFileAccess(lockFullFileNamePath, global::System.IO.FileAccess.Read, fileShare, false);
			}
			catch
			{
				result = null;
			}
			return result;
		}

		// Token: 0x06000959 RID: 2393 RVA: 0x00015B44 File Offset: 0x00013D44
		private bool CheckLockRequest(string lockFullFileNamePath)
		{
			try
			{
				global::System.IO.Directory.CreateDirectory(global::System.IO.Path.GetDirectoryName(lockFullFileNamePath));
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
			global::System.IO.FileAccess fileAccess = global::System.IO.FileAccess.Read;
			global::System.IO.FileShare fileShare = global::System.IO.FileShare.Write;
			bool manualDeleteOnClose = false;
			if (global::Gibraltar.CommonCentralLogic.IsMonoRuntime)
			{
				lockFullFileNamePath += "req";
				fileAccess = global::System.IO.FileAccess.Write;
				fileShare = global::System.IO.FileShare.None;
				manualDeleteOnClose = this.m_DeleteOnClose;
				if (!global::System.IO.File.Exists(lockFullFileNamePath))
				{
					return false;
				}
			}
			bool result;
			try
			{
				using (global::Gibraltar.Data.FileLock fileLock = this.OpenFileAccess(lockFullFileNamePath, fileAccess, fileShare, manualDeleteOnClose))
				{
					result = (fileLock == null);
				}
			}
			catch
			{
				result = true;
			}
			return result;
		}

		// Token: 0x0600095A RID: 2394 RVA: 0x00015BF8 File Offset: 0x00013DF8
		private global::Gibraltar.Data.FileLock OpenFileAccess(string fullFileNamePath, global::System.IO.FileAccess fileAccess, global::System.IO.FileShare fileShare, bool manualDeleteOnClose)
		{
			uint num = 0U;
			global::Gibraltar.Data.FileLock fileLock = null;
			if (global::Gibraltar.CommonCentralLogic.IsMonoRuntime)
			{
				global::System.IO.FileStream fileStream = null;
				try
				{
					global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
					try
					{
					}
					finally
					{
						fileStream = new global::System.IO.FileStream(fullFileNamePath, global::System.IO.FileMode.OpenOrCreate, fileAccess, fileShare, 8192, (global::System.IO.FileOptions)num);
					}
				}
				catch (global::System.Threading.ThreadAbortException)
				{
					if (fileStream != null)
					{
						fileStream.Dispose();
					}
					throw;
				}
				catch
				{
					fileStream = null;
				}
				if (fileStream != null)
				{
					fileLock = new global::Gibraltar.Data.FileLock(fileStream, fullFileNamePath, global::System.IO.FileMode.OpenOrCreate, fileAccess, fileShare, manualDeleteOnClose);
				}
			}
			else
			{
				global::Microsoft.Win32.SafeHandles.SafeFileHandle safeFileHandle = null;
				try
				{
					global::System.Runtime.CompilerServices.RuntimeHelpers.PrepareConstrainedRegions();
					try
					{
					}
					finally
					{
						safeFileHandle = global::Gibraltar.Data.Win32Helper.CreateFile(fullFileNamePath, fileAccess, fileShare, global::System.IntPtr.Zero, global::System.IO.FileMode.OpenOrCreate, num, global::System.IntPtr.Zero);
					}
					if (safeFileHandle != null && (safeFileHandle.IsInvalid || safeFileHandle.IsClosed))
					{
						safeFileHandle.Dispose();
						safeFileHandle = null;
					}
					if (safeFileHandle != null)
					{
						fileLock = new global::Gibraltar.Data.FileLock(safeFileHandle, fullFileNamePath, global::System.IO.FileMode.OpenOrCreate, fileAccess, fileShare, manualDeleteOnClose);
					}
				}
				catch (global::System.Threading.ThreadAbortException)
				{
					if (fileLock != null)
					{
						fileLock.Dispose();
					}
					else if (safeFileHandle != null)
					{
						safeFileHandle.Dispose();
					}
					throw;
				}
			}
			return fileLock;
		}

		// Token: 0x0400022D RID: 557
		private const int LockPollingDelay = 16;

		// Token: 0x0400022E RID: 558
		private const int BackOffDelay = 48;

		// Token: 0x0400022F RID: 559
		private const string LogCategory = "Loupe.Interprocess Lock.Proxy";

		// Token: 0x04000230 RID: 560
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.Data.InterprocessLock> m_WaitQueue = new global::System.Collections.Generic.Queue<global::Gibraltar.Data.InterprocessLock>();

		// Token: 0x04000231 RID: 561
		private readonly object m_QueueLock = new object();

		// Token: 0x04000232 RID: 562
		private readonly string m_IndexPath;

		// Token: 0x04000233 RID: 563
		private readonly string m_LockName;

		// Token: 0x04000234 RID: 564
		private readonly string m_LockFullFileNamePath;

		// Token: 0x04000235 RID: 565
		private readonly bool m_DeleteOnClose;

		// Token: 0x04000236 RID: 566
		private global::Gibraltar.Data.InterprocessLock m_CurrentLockTurn;

		// Token: 0x04000237 RID: 567
		private global::Gibraltar.Data.FileLock m_FileLock;

		// Token: 0x04000238 RID: 568
		private global::Gibraltar.Data.FileLock m_LockRequest;

		// Token: 0x04000239 RID: 569
		private global::System.DateTimeOffset m_MinTimeNextTurn = global::System.DateTimeOffset.MinValue;

		// Token: 0x0400023A RID: 570
		private bool m_DisposeOnClose;

		// Token: 0x0400023B RID: 571
		private bool m_Disposed;
	}
}
