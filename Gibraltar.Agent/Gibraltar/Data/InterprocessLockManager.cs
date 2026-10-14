using System;
using System.Collections.Generic;
using System.IO;
using System.Threading;

namespace Gibraltar.Data
{
	// Token: 0x020000DF RID: 223
	internal static class InterprocessLockManager
	{
		// Token: 0x06000939 RID: 2361 RVA: 0x00014EF4 File Offset: 0x000130F4
		public static global::Gibraltar.Data.InterprocessLock Lock(object requester, string indexPath, string lockName, int timeoutSeconds)
		{
			return global::Gibraltar.Data.InterprocessLockManager.Lock(requester, indexPath, lockName, timeoutSeconds, false);
		}

		// Token: 0x0600093A RID: 2362 RVA: 0x00014F00 File Offset: 0x00013100
		public static global::Gibraltar.Data.InterprocessLock Lock(object requester, string indexPath, string lockName, int timeoutSeconds, bool deleteOnClose)
		{
			if (requester == null)
			{
				throw new global::System.ArgumentNullException("requester");
			}
			if (indexPath == null)
			{
				throw new global::System.ArgumentNullException("indexPath");
			}
			if (lockName == null)
			{
				throw new global::System.ArgumentNullException("lockName");
			}
			global::Gibraltar.Data.InterprocessLock interprocessLock = new global::Gibraltar.Data.InterprocessLock(requester, indexPath, lockName, timeoutSeconds);
			object obj = global::Gibraltar.Data.InterprocessLockManager.g_Lock;
			global::Gibraltar.Data.InterprocessLockProxy interprocessLockProxy;
			lock (obj)
			{
				if (!global::Gibraltar.Data.InterprocessLockManager.g_Proxies.TryGetValue(interprocessLock.FullName, out interprocessLockProxy))
				{
					interprocessLockProxy = new global::Gibraltar.Data.InterprocessLockProxy(indexPath, lockName, deleteOnClose);
					interprocessLockProxy.Disposed += global::Gibraltar.Data.InterprocessLockManager.LockProxy_Disposed;
					global::Gibraltar.Data.InterprocessLockManager.g_Proxies.Add(interprocessLockProxy.FullName, interprocessLockProxy);
				}
				global::System.Threading.Thread thread = interprocessLockProxy.CheckCurrentTurnThread(interprocessLock);
				if (global::System.Threading.Thread.CurrentThread == thread && interprocessLock.ActualLock != null)
				{
					return interprocessLock;
				}
				if (thread != null && !interprocessLock.WaitForLock)
				{
					interprocessLock.Dispose();
					return null;
				}
				interprocessLockProxy.QueueRequest(interprocessLock);
			}
			bool flag = false;
			try
			{
				flag = interprocessLockProxy.AwaitOurTurnOrTimeout(interprocessLock);
			}
			finally
			{
				if (!flag)
				{
					interprocessLock.Dispose();
					interprocessLock = null;
				}
			}
			return interprocessLock;
		}

		// Token: 0x0600093B RID: 2363 RVA: 0x00015034 File Offset: 0x00013234
		public static bool QueryLockAvailable(object requester, string indexPath, string lockName)
		{
			if (!global::System.IO.File.Exists(global::Gibraltar.Data.InterprocessLockProxy.GetLockFileName(indexPath, lockName)))
			{
				return true;
			}
			bool result;
			using (global::Gibraltar.Data.InterprocessLock interprocessLock = global::Gibraltar.Data.InterprocessLockManager.Lock(requester, indexPath, lockName, 0, true))
			{
				result = (interprocessLock != null);
			}
			return result;
		}

		// Token: 0x0600093C RID: 2364 RVA: 0x00015088 File Offset: 0x00013288
		private static void LockProxy_Disposed(object sender, global::System.EventArgs e)
		{
			global::Gibraltar.Data.InterprocessLockProxy interprocessLockProxy = (global::Gibraltar.Data.InterprocessLockProxy)sender;
			object obj = global::Gibraltar.Data.InterprocessLockManager.g_Lock;
			lock (obj)
			{
				string fullName = interprocessLockProxy.FullName;
				global::Gibraltar.Data.InterprocessLockProxy interprocessLockProxy2;
				if (global::Gibraltar.Data.InterprocessLockManager.g_Proxies.TryGetValue(fullName, out interprocessLockProxy2) && interprocessLockProxy2 == interprocessLockProxy)
				{
					global::Gibraltar.Data.InterprocessLockManager.g_Proxies.Remove(fullName);
				}
				global::System.Threading.Monitor.PulseAll(global::Gibraltar.Data.InterprocessLockManager.g_Lock);
			}
		}

		// Token: 0x0400022B RID: 555
		private static readonly object g_Lock = new object();

		// Token: 0x0400022C RID: 556
		private static readonly global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Data.InterprocessLockProxy> g_Proxies = new global::System.Collections.Generic.Dictionary<string, global::Gibraltar.Data.InterprocessLockProxy>(global::System.StringComparer.OrdinalIgnoreCase);
	}
}
