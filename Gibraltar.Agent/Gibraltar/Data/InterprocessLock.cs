using System;
using System.IO;
using System.Threading;

namespace Gibraltar.Data
{
	// Token: 0x020000DE RID: 222
	internal sealed class InterprocessLock : global::System.IDisposable
	{
		// Token: 0x14000030 RID: 48
		// (add) Token: 0x0600091F RID: 2335 RVA: 0x00014A98 File Offset: 0x00012C98
		// (remove) Token: 0x06000920 RID: 2336 RVA: 0x00014AD4 File Offset: 0x00012CD4
		internal event global::System.EventHandler Disposed;

		// Token: 0x06000921 RID: 2337 RVA: 0x00014B10 File Offset: 0x00012D10
		internal InterprocessLock(object requester, string indexPath, string lockName, int timeoutSeconds)
		{
			this.m_OwningObject = requester;
			this.m_OwningThread = global::System.Threading.Thread.CurrentThread;
			this.m_IndexPath = indexPath;
			this.m_LockName = lockName;
			this.m_ActualLock = null;
			this.m_MyTurn = false;
			this.m_WaitForLock = (timeoutSeconds > 0);
			this.m_WaitTimeout = (this.m_WaitForLock ? global::System.DateTimeOffset.Now.AddSeconds((double)timeoutSeconds) : global::System.DateTimeOffset.Now);
			this.m_LockFullFileNamePath = global::Gibraltar.Data.InterprocessLock.GetLockFileName(indexPath, lockName);
		}

		// Token: 0x06000922 RID: 2338 RVA: 0x00014BA4 File Offset: 0x00012DA4
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x170003F6 RID: 1014
		// (get) Token: 0x06000923 RID: 2339 RVA: 0x00014BB4 File Offset: 0x00012DB4
		public string FullName
		{
			get
			{
				return this.m_LockFullFileNamePath;
			}
		}

		// Token: 0x170003F7 RID: 1015
		// (get) Token: 0x06000924 RID: 2340 RVA: 0x00014BBC File Offset: 0x00012DBC
		public string IndexPath
		{
			get
			{
				return this.m_IndexPath;
			}
		}

		// Token: 0x170003F8 RID: 1016
		// (get) Token: 0x06000925 RID: 2341 RVA: 0x00014BC4 File Offset: 0x00012DC4
		public string LockName
		{
			get
			{
				return this.m_LockName;
			}
		}

		// Token: 0x170003F9 RID: 1017
		// (get) Token: 0x06000926 RID: 2342 RVA: 0x00014BCC File Offset: 0x00012DCC
		public object Owner
		{
			get
			{
				return this.m_OwningObject;
			}
		}

		// Token: 0x170003FA RID: 1018
		// (get) Token: 0x06000927 RID: 2343 RVA: 0x00014BD4 File Offset: 0x00012DD4
		public global::System.Threading.Thread OwningThread
		{
			get
			{
				return this.m_OwningThread;
			}
		}

		// Token: 0x170003FB RID: 1019
		// (get) Token: 0x06000928 RID: 2344 RVA: 0x00014BDC File Offset: 0x00012DDC
		public int OwningThreadId
		{
			get
			{
				return this.m_OwningThread.ManagedThreadId;
			}
		}

		// Token: 0x170003FC RID: 1020
		// (get) Token: 0x06000929 RID: 2345 RVA: 0x00014BEC File Offset: 0x00012DEC
		public bool WaitForLock
		{
			get
			{
				return this.m_WaitForLock;
			}
		}

		// Token: 0x170003FD RID: 1021
		// (get) Token: 0x0600092A RID: 2346 RVA: 0x00014BF4 File Offset: 0x00012DF4
		public global::System.DateTimeOffset WaitTimeout
		{
			get
			{
				return this.m_WaitTimeout;
			}
		}

		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x0600092B RID: 2347 RVA: 0x00014BFC File Offset: 0x00012DFC
		public global::Gibraltar.Data.InterprocessLock ActualLock
		{
			get
			{
				return this.m_ActualLock;
			}
		}

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x0600092C RID: 2348 RVA: 0x00014C04 File Offset: 0x00012E04
		public bool IsSecondaryLock
		{
			get
			{
				return this.m_ActualLock != null && this.m_ActualLock != this;
			}
		}

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x0600092D RID: 2349 RVA: 0x00014C20 File Offset: 0x00012E20
		public bool IsExpired
		{
			get
			{
				object myLock = this.m_MyLock;
				bool result;
				lock (myLock)
				{
					result = (this.m_Disposed || this.m_WaitTimeout == global::System.DateTimeOffset.MinValue);
				}
				return result;
			}
		}

		// Token: 0x17000401 RID: 1025
		// (get) Token: 0x0600092E RID: 2350 RVA: 0x00014C7C File Offset: 0x00012E7C
		public bool IsDisposed
		{
			get
			{
				return this.m_Disposed;
			}
		}

		// Token: 0x17000402 RID: 1026
		// (get) Token: 0x0600092F RID: 2351 RVA: 0x00014C84 File Offset: 0x00012E84
		// (set) Token: 0x06000930 RID: 2352 RVA: 0x00014CA0 File Offset: 0x00012EA0
		public bool DisposeProxyOnClose
		{
			get
			{
				return this.m_OurLockProxy != null && this.m_OurLockProxy.DisposeOnClose;
			}
			set
			{
				if (this.m_OurLockProxy != null)
				{
					this.m_OurLockProxy.DisposeOnClose = value;
				}
			}
		}

		// Token: 0x17000403 RID: 1027
		// (get) Token: 0x06000931 RID: 2353 RVA: 0x00014CBC File Offset: 0x00012EBC
		// (set) Token: 0x06000932 RID: 2354 RVA: 0x00014CC4 File Offset: 0x00012EC4
		internal global::Gibraltar.Data.InterprocessLockProxy OurLockProxy
		{
			get
			{
				return this.m_OurLockProxy;
			}
			set
			{
				this.m_OurLockProxy = value;
			}
		}

		// Token: 0x06000933 RID: 2355 RVA: 0x00014CD0 File Offset: 0x00012ED0
		internal void GrantTheLock(global::Gibraltar.Data.InterprocessLock actualLock)
		{
			if (actualLock != null && !actualLock.IsDisposed && actualLock.OwningThread == this.m_OwningThread && string.Equals(actualLock.FullName, this.m_LockFullFileNamePath, global::System.StringComparison.OrdinalIgnoreCase))
			{
				this.m_ActualLock = actualLock;
				this.m_WaitTimeout = global::System.DateTimeOffset.MaxValue;
				return;
			}
			this.m_ActualLock = null;
		}

		// Token: 0x06000934 RID: 2356 RVA: 0x00014D34 File Offset: 0x00012F34
		internal void SignalMyTurn()
		{
			object myLock = this.m_MyLock;
			lock (myLock)
			{
				this.m_MyTurn = true;
				global::System.Threading.Monitor.PulseAll(this.m_MyLock);
			}
		}

		// Token: 0x06000935 RID: 2357 RVA: 0x00014D7C File Offset: 0x00012F7C
		internal bool AwaitTurnOrTimeout()
		{
			object myLock = this.m_MyLock;
			bool result;
			lock (myLock)
			{
				if (this.m_WaitForLock)
				{
					while (!this.m_MyTurn && !this.m_Disposed)
					{
						global::System.TimeSpan timeout = this.m_WaitTimeout - global::System.DateTimeOffset.Now;
						if (timeout.TotalMilliseconds <= 0.0)
						{
							this.m_WaitTimeout = global::System.DateTimeOffset.MinValue;
							return false;
						}
						global::System.Threading.Monitor.Wait(this.m_MyLock, timeout);
					}
				}
				if (this.m_Disposed || !this.m_MyTurn)
				{
					result = false;
				}
				else
				{
					result = true;
				}
			}
			return result;
		}

		// Token: 0x06000936 RID: 2358 RVA: 0x00014E3C File Offset: 0x0001303C
		internal static string GetLockFileName(string indexPath, string lockName)
		{
			return global::System.IO.Path.Combine(indexPath, lockName + ".lock");
		}

		// Token: 0x06000937 RID: 2359 RVA: 0x00014E50 File Offset: 0x00013050
		private void Dispose(bool releaseManaged)
		{
			if (releaseManaged)
			{
				object myLock = this.m_MyLock;
				lock (myLock)
				{
					if (!this.m_Disposed)
					{
						this.m_Disposed = true;
						this.m_WaitTimeout = global::System.DateTimeOffset.MinValue;
						this.m_OwningThread = null;
						this.m_OwningObject = null;
					}
					global::System.Threading.Monitor.PulseAll(this.m_MyLock);
				}
				this.OnDispose();
			}
		}

		// Token: 0x06000938 RID: 2360 RVA: 0x00014EC8 File Offset: 0x000130C8
		private void OnDispose()
		{
			global::System.EventHandler disposed = this.Disposed;
			if (disposed != null)
			{
				disposed(this, new global::System.EventArgs());
			}
		}

		// Token: 0x0400021D RID: 541
		public const string LockFileExtension = "lock";

		// Token: 0x0400021E RID: 542
		private readonly string m_IndexPath;

		// Token: 0x0400021F RID: 543
		private readonly string m_LockName;

		// Token: 0x04000220 RID: 544
		private readonly string m_LockFullFileNamePath;

		// Token: 0x04000221 RID: 545
		private readonly bool m_WaitForLock;

		// Token: 0x04000222 RID: 546
		private readonly object m_MyLock = new object();

		// Token: 0x04000223 RID: 547
		private global::System.Threading.Thread m_OwningThread;

		// Token: 0x04000224 RID: 548
		private object m_OwningObject;

		// Token: 0x04000225 RID: 549
		private global::Gibraltar.Data.InterprocessLockProxy m_OurLockProxy;

		// Token: 0x04000226 RID: 550
		private global::Gibraltar.Data.InterprocessLock m_ActualLock;

		// Token: 0x04000227 RID: 551
		private global::System.DateTimeOffset m_WaitTimeout;

		// Token: 0x04000228 RID: 552
		private bool m_MyTurn;

		// Token: 0x04000229 RID: 553
		private bool m_Disposed;
	}
}
