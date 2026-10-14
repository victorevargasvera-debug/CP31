using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;

namespace Gibraltar
{
	// Token: 0x020000BA RID: 186
	internal class PrivateThreadPool : global::System.IDisposable
	{
		// Token: 0x14000024 RID: 36
		// (add) Token: 0x060007D1 RID: 2001 RVA: 0x0000F774 File Offset: 0x0000D974
		// (remove) Token: 0x060007D2 RID: 2002 RVA: 0x0000F7B0 File Offset: 0x0000D9B0
		public event global::System.EventHandler ShuttingDown;

		// Token: 0x14000025 RID: 37
		// (add) Token: 0x060007D3 RID: 2003 RVA: 0x0000F7EC File Offset: 0x0000D9EC
		// (remove) Token: 0x060007D4 RID: 2004 RVA: 0x0000F828 File Offset: 0x0000DA28
		public event global::Gibraltar.PrivateTaskErrorEventHandler TaskException;

		// Token: 0x060007D5 RID: 2005 RVA: 0x0000F864 File Offset: 0x0000DA64
		public PrivateThreadPool(string namePrefix, int maxThreads, int minThreads)
		{
			this.m_ThreadNamePrefix = (string.IsNullOrEmpty(namePrefix) ? "Private Worker Thread" : namePrefix);
			this.m_MaxThreads = maxThreads;
			this.m_MinThreads = minThreads;
		}

		// Token: 0x17000396 RID: 918
		// (get) Token: 0x060007D6 RID: 2006 RVA: 0x0000F8D4 File Offset: 0x0000DAD4
		// (set) Token: 0x060007D7 RID: 2007 RVA: 0x0000F8DC File Offset: 0x0000DADC
		public int MaxThreads
		{
			get
			{
				return this.m_MaxThreads;
			}
			set
			{
				this.m_MaxThreads = value;
			}
		}

		// Token: 0x17000397 RID: 919
		// (get) Token: 0x060007D8 RID: 2008 RVA: 0x0000F8E8 File Offset: 0x0000DAE8
		// (set) Token: 0x060007D9 RID: 2009 RVA: 0x0000F8F0 File Offset: 0x0000DAF0
		public int MinThreads
		{
			get
			{
				return this.m_MinThreads;
			}
			set
			{
				this.m_MinThreads = value;
			}
		}

		// Token: 0x17000398 RID: 920
		// (get) Token: 0x060007DA RID: 2010 RVA: 0x0000F8FC File Offset: 0x0000DAFC
		// (set) Token: 0x060007DB RID: 2011 RVA: 0x0000F904 File Offset: 0x0000DB04
		public global::System.Threading.ThreadPriority ThreadPriority
		{
			get
			{
				return this.m_ThreadPriority;
			}
			set
			{
				this.SetThreadPriority(value);
			}
		}

		// Token: 0x060007DC RID: 2012 RVA: 0x0000F910 File Offset: 0x0000DB10
		public bool QueueWorkItem(global::System.Threading.WaitCallback callBack)
		{
			return this.QueueWorkItem(callBack, null);
		}

		// Token: 0x060007DD RID: 2013 RVA: 0x0000F91C File Offset: 0x0000DB1C
		public bool QueueWorkItem(global::System.Threading.WaitCallback callBack, object state)
		{
			object queueLock = this.m_QueueLock;
			lock (queueLock)
			{
				this.m_Requests.Enqueue(new global::Gibraltar.PrivateThreadPool.ThreadPoolRequest(callBack, state));
				global::System.Threading.Monitor.PulseAll(this.m_QueueLock);
			}
			this.EnsureRunning();
			return true;
		}

		// Token: 0x060007DE RID: 2014 RVA: 0x0000F978 File Offset: 0x0000DB78
		public void Shutdown(int gracePeriod)
		{
			bool flag = false;
			object obj = this.m_QueueLock;
			lock (obj)
			{
				if (!this.m_ShuttingDown)
				{
					flag = true;
					this.m_ShuttingDown = true;
					this.m_Requests.Clear();
				}
				global::System.Threading.Monitor.PulseAll(this.m_QueueLock);
			}
			if (flag)
			{
				this.OnShuttingDown();
			}
			global::System.DateTimeOffset right = global::System.DateTimeOffset.Now.AddMilliseconds((double)gracePeriod);
			obj = this.m_ThreadLock;
			lock (obj)
			{
				while (this.m_Threads.Count > 0 && global::System.DateTimeOffset.Now < right)
				{
					global::System.Threading.Monitor.Wait(this.m_ThreadLock, 16);
				}
				global::System.Threading.Monitor.PulseAll(this.m_ThreadLock);
			}
			if (flag)
			{
				global::System.Collections.Generic.List<global::System.Threading.Thread> list = null;
				obj = this.m_ThreadLock;
				lock (obj)
				{
					list = new global::System.Collections.Generic.List<global::System.Threading.Thread>(this.m_Threads);
					global::System.Threading.Monitor.PulseAll(this.m_ThreadLock);
				}
				foreach (global::System.Threading.Thread thread in list)
				{
					try
					{
						thread.Abort();
					}
					catch
					{
					}
				}
			}
		}

		// Token: 0x060007DF RID: 2015 RVA: 0x0000FB00 File Offset: 0x0000DD00
		public void Dispose()
		{
		}

		// Token: 0x060007E0 RID: 2016 RVA: 0x0000FB04 File Offset: 0x0000DD04
		protected virtual void OnShuttingDown()
		{
			global::System.EventHandler shuttingDown = this.ShuttingDown;
			if (shuttingDown != null)
			{
				try
				{
					shuttingDown(this, new global::System.EventArgs());
				}
				catch
				{
				}
			}
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x0000FB48 File Offset: 0x0000DD48
		protected virtual void OnTaskException(object state, global::System.Exception ex)
		{
			global::Gibraltar.PrivateTaskErrorEventHandler taskException = this.TaskException;
			if (taskException != null)
			{
				try
				{
					taskException(this, new global::Gibraltar.PrivateTaskErrorEventArgs(state, ex));
				}
				catch
				{
				}
			}
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x0000FB8C File Offset: 0x0000DD8C
		private void AsyncWorkerThreadMain(object state)
		{
			try
			{
				while (!this.m_ShuttingDown)
				{
					global::Gibraltar.PrivateThreadPool.ThreadPoolRequest threadPoolRequest = null;
					object obj = this.m_QueueLock;
					lock (obj)
					{
						if (this.m_Requests.Count > 0)
						{
							threadPoolRequest = this.m_Requests.Dequeue();
						}
						global::System.Threading.Monitor.PulseAll(this.m_QueueLock);
					}
					if (threadPoolRequest != null)
					{
						this.ExecuteThreadPoolTask(threadPoolRequest);
					}
					obj = this.m_QueueLock;
					lock (obj)
					{
						while (!this.m_ShuttingDown && this.m_Requests.Count == 0)
						{
							global::System.Threading.Monitor.Wait(this.m_QueueLock, 1000);
						}
						global::System.Threading.Monitor.PulseAll(this.m_QueueLock);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::System.Diagnostics.Trace.TraceError("Background task engine thread failed due to internal exception:\r\n{0}", new object[]
				{
					ex.Message,
					ex
				});
			}
			finally
			{
				object obj = this.m_ThreadLock;
				lock (obj)
				{
					if (this.m_Threads.Contains(global::System.Threading.Thread.CurrentThread))
					{
						this.m_Threads.Remove(global::System.Threading.Thread.CurrentThread);
					}
					global::System.Threading.Monitor.PulseAll(this.m_ThreadLock);
				}
				if (!this.m_ShuttingDown)
				{
					this.EnsureRunning();
				}
			}
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x0000FD18 File Offset: 0x0000DF18
		private void ExecuteThreadPoolTask(global::Gibraltar.PrivateThreadPool.ThreadPoolRequest request)
		{
			try
			{
				request.CallBack(request.State);
			}
			catch (global::System.Exception ex)
			{
				this.OnTaskException(request.State, ex);
			}
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x0000FD60 File Offset: 0x0000DF60
		private void EnsureRunning()
		{
			object threadLock = this.m_ThreadLock;
			lock (threadLock)
			{
				while (this.m_Threads.Count < this.MinThreads)
				{
					int num = this.m_Threads.Count + 1;
					bool flag = false;
					string text;
					do
					{
						text = string.Format("{0} {1}", this.m_ThreadNamePrefix, num);
						using (global::System.Collections.Generic.List<global::System.Threading.Thread>.Enumerator enumerator = this.m_Threads.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								if (enumerator.Current.Name.Equals(text, global::System.StringComparison.OrdinalIgnoreCase))
								{
									flag = true;
									break;
								}
							}
						}
						if (flag)
						{
							num++;
						}
					}
					while (flag);
					global::System.Threading.Thread thread = new global::System.Threading.Thread(new global::System.Threading.ParameterizedThreadStart(this.AsyncWorkerThreadMain));
					thread.Name = text;
					thread.TrySetApartmentState(global::System.Threading.ApartmentState.MTA);
					thread.IsBackground = true;
					thread.Priority = this.m_ThreadPriority;
					thread.Start();
					this.m_Threads.Add(thread);
				}
				global::System.Threading.Monitor.PulseAll(this.m_ThreadLock);
			}
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x0000FE98 File Offset: 0x0000E098
		private void SetThreadPriority(global::System.Threading.ThreadPriority newValue)
		{
			object threadLock = this.m_ThreadLock;
			lock (threadLock)
			{
				if (this.m_ThreadPriority != newValue)
				{
					this.m_ThreadPriority = newValue;
					foreach (global::System.Threading.Thread thread in this.m_Threads)
					{
						thread.Priority = this.m_ThreadPriority;
					}
					global::System.Threading.Monitor.PulseAll(this.m_ThreadLock);
				}
			}
		}

		// Token: 0x0400018A RID: 394
		private readonly object m_ThreadLock = new object();

		// Token: 0x0400018B RID: 395
		private readonly object m_QueueLock = new object();

		// Token: 0x0400018C RID: 396
		private readonly global::System.Collections.Generic.List<global::System.Threading.Thread> m_Threads = new global::System.Collections.Generic.List<global::System.Threading.Thread>();

		// Token: 0x0400018D RID: 397
		private readonly global::System.Collections.Generic.Queue<global::Gibraltar.PrivateThreadPool.ThreadPoolRequest> m_Requests = new global::System.Collections.Generic.Queue<global::Gibraltar.PrivateThreadPool.ThreadPoolRequest>();

		// Token: 0x0400018E RID: 398
		private readonly string m_ThreadNamePrefix;

		// Token: 0x0400018F RID: 399
		private int m_MaxThreads;

		// Token: 0x04000190 RID: 400
		private int m_MinThreads;

		// Token: 0x04000191 RID: 401
		private global::System.Threading.ThreadPriority m_ThreadPriority;

		// Token: 0x04000192 RID: 402
		private volatile bool m_ShuttingDown;

		// Token: 0x02000490 RID: 1168
		private class ThreadPoolRequest
		{
			// Token: 0x060032FB RID: 13051 RVA: 0x000B969C File Offset: 0x000B789C
			public ThreadPoolRequest(global::System.Threading.WaitCallback callBack, object state)
			{
				this.CallBack = callBack;
				this.State = state;
				this.QueueEntry = global::System.DateTimeOffset.Now;
			}

			// Token: 0x17000EAF RID: 3759
			// (get) Token: 0x060032FC RID: 13052 RVA: 0x000B96CC File Offset: 0x000B78CC
			// (set) Token: 0x060032FD RID: 13053 RVA: 0x000B96D4 File Offset: 0x000B78D4
			public global::System.DateTimeOffset QueueEntry { get; private set; }

			// Token: 0x17000EB0 RID: 3760
			// (get) Token: 0x060032FE RID: 13054 RVA: 0x000B96E0 File Offset: 0x000B78E0
			// (set) Token: 0x060032FF RID: 13055 RVA: 0x000B96E8 File Offset: 0x000B78E8
			public global::System.Threading.WaitCallback CallBack { get; private set; }

			// Token: 0x17000EB1 RID: 3761
			// (get) Token: 0x06003300 RID: 13056 RVA: 0x000B96F4 File Offset: 0x000B78F4
			// (set) Token: 0x06003301 RID: 13057 RVA: 0x000B96FC File Offset: 0x000B78FC
			public object State { get; private set; }
		}
	}
}
