using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using NLog.Common;
using NLog.Config;
using NLog.Internal;
using NLog.Layouts;

namespace NLog.Targets
{
	// Token: 0x02000050 RID: 80
	[global::NLog.Config.NLogConfigurationItem]
	public abstract class Target : global::NLog.Internal.ISupportsInitialize, global::System.IDisposable
	{
		// Token: 0x17000113 RID: 275
		// (get) Token: 0x06000714 RID: 1812 RVA: 0x000118F8 File Offset: 0x0000FAF8
		// (set) Token: 0x06000715 RID: 1813 RVA: 0x00011900 File Offset: 0x0000FB00
		internal global::NLog.Config.StackTraceUsage StackTraceUsage { get; private set; }

		// Token: 0x17000114 RID: 276
		// (get) Token: 0x06000716 RID: 1814 RVA: 0x00011909 File Offset: 0x0000FB09
		// (set) Token: 0x06000717 RID: 1815 RVA: 0x00011911 File Offset: 0x0000FB11
		public string Name { get; set; }

		// Token: 0x17000115 RID: 277
		// (get) Token: 0x06000718 RID: 1816 RVA: 0x0001191A File Offset: 0x0000FB1A
		// (set) Token: 0x06000719 RID: 1817 RVA: 0x00011922 File Offset: 0x0000FB22
		public bool OptimizeBufferReuse { get; set; }

		// Token: 0x17000116 RID: 278
		// (get) Token: 0x0600071A RID: 1818 RVA: 0x0001192B File Offset: 0x0000FB2B
		protected object SyncRoot
		{
			get
			{
				return this._lockObject;
			}
		}

		// Token: 0x17000117 RID: 279
		// (get) Token: 0x0600071B RID: 1819 RVA: 0x00011933 File Offset: 0x0000FB33
		// (set) Token: 0x0600071C RID: 1820 RVA: 0x0001193B File Offset: 0x0000FB3B
		private protected global::NLog.Config.LoggingConfiguration LoggingConfiguration { protected get; private set; }

		// Token: 0x17000118 RID: 280
		// (get) Token: 0x0600071D RID: 1821 RVA: 0x00011944 File Offset: 0x0000FB44
		protected bool IsInitialized
		{
			get
			{
				if (this._isInitialized)
				{
					return true;
				}
				object syncRoot = this.SyncRoot;
				bool isInitialized;
				lock (syncRoot)
				{
					isInitialized = this._isInitialized;
				}
				return isInitialized;
			}
		}

		// Token: 0x0600071E RID: 1822 RVA: 0x00011994 File Offset: 0x0000FB94
		void global::NLog.Internal.ISupportsInitialize.Initialize(global::NLog.Config.LoggingConfiguration configuration)
		{
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				bool isInitialized = this._isInitialized;
				this.Initialize(configuration);
				if (isInitialized && configuration != null)
				{
					this.FindAllLayouts();
				}
			}
		}

		// Token: 0x0600071F RID: 1823 RVA: 0x000119E8 File Offset: 0x0000FBE8
		void global::NLog.Internal.ISupportsInitialize.Close()
		{
			this.Close();
		}

		// Token: 0x06000720 RID: 1824 RVA: 0x000119F0 File Offset: 0x0000FBF0
		public void Dispose()
		{
			this.Dispose(true);
			global::System.GC.SuppressFinalize(this);
		}

		// Token: 0x06000721 RID: 1825 RVA: 0x00011A00 File Offset: 0x0000FC00
		public void Flush(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			if (asyncContinuation == null)
			{
				throw new global::System.ArgumentNullException("asyncContinuation");
			}
			asyncContinuation = global::NLog.Common.AsyncHelpers.PreventMultipleCalls(asyncContinuation);
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				if (!this.IsInitialized)
				{
					asyncContinuation(null);
				}
				else
				{
					try
					{
						this.FlushAsync(asyncContinuation);
					}
					catch (global::System.Exception exception)
					{
						if (exception.MustBeRethrown())
						{
							throw;
						}
						asyncContinuation(exception);
					}
				}
			}
		}

		// Token: 0x06000722 RID: 1826 RVA: 0x00011A8C File Offset: 0x0000FC8C
		public void PrecalculateVolatileLayouts(global::NLog.LogEventInfo logEvent)
		{
			if (this._allLayoutsAreThreadAgnostic && (!this._oneLayoutIsMutableUnsafe || logEvent.IsLogEventMutableSafe()))
			{
				return;
			}
			object syncRoot;
			if (this.OptimizeBufferReuse)
			{
				if (this._allLayoutsAreThreadSafe)
				{
					if (!this.IsInitialized)
					{
						return;
					}
					if (this._allLayouts == null)
					{
						return;
					}
					if (this._precalculateStringBuilderPool == null)
					{
						global::System.Threading.Interlocked.CompareExchange<global::NLog.Internal.StringBuilderPool>(ref this._precalculateStringBuilderPool, new global::NLog.Internal.StringBuilderPool(global::System.Environment.ProcessorCount * 4, 1024, 524288), null);
					}
					using (global::NLog.Internal.StringBuilderPool.ItemHolder itemHolder = this._precalculateStringBuilderPool.Acquire())
					{
						using (global::System.Collections.Generic.List<global::NLog.Layouts.Layout>.Enumerator enumerator = this._allLayouts.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::NLog.Layouts.Layout layout = enumerator.Current;
								itemHolder.Item.ClearBuilder();
								layout.PrecalculateBuilder(logEvent, itemHolder.Item);
							}
							return;
						}
					}
				}
				syncRoot = this.SyncRoot;
				lock (syncRoot)
				{
					if (!this._isInitialized)
					{
						return;
					}
					if (this._allLayouts == null)
					{
						return;
					}
					using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject = this.ReusableLayoutBuilder.Allocate())
					{
						using (global::System.Collections.Generic.List<global::NLog.Layouts.Layout>.Enumerator enumerator = this._allLayouts.GetEnumerator())
						{
							while (enumerator.MoveNext())
							{
								global::NLog.Layouts.Layout layout2 = enumerator.Current;
								lockOject.Result.ClearBuilder();
								layout2.PrecalculateBuilder(logEvent, lockOject.Result);
							}
							return;
						}
					}
				}
			}
			syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				if (this._isInitialized)
				{
					if (this._allLayouts != null)
					{
						foreach (global::NLog.Layouts.Layout layout3 in this._allLayouts)
						{
							layout3.Precalculate(logEvent);
						}
					}
				}
			}
		}

		// Token: 0x06000723 RID: 1827 RVA: 0x00011CC0 File Offset: 0x0000FEC0
		public override string ToString()
		{
			global::NLog.Targets.TargetAttribute customAttribute = base.GetType().GetCustomAttribute<global::NLog.Targets.TargetAttribute>();
			if (customAttribute != null)
			{
				return string.Format("{0} Target[{1}]", customAttribute.Name, this.Name ?? "(unnamed)");
			}
			return base.GetType().Name;
		}

		// Token: 0x06000724 RID: 1828 RVA: 0x00011D08 File Offset: 0x0000FF08
		public void WriteAsyncLogEvent(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			if (!this.IsInitialized)
			{
				object syncRoot = this.SyncRoot;
				lock (syncRoot)
				{
					logEvent.Continuation(null);
				}
				return;
			}
			if (this._initializeException != null)
			{
				object syncRoot = this.SyncRoot;
				lock (syncRoot)
				{
					logEvent.Continuation(this.CreateInitException());
				}
				return;
			}
			global::NLog.Common.AsyncContinuation asyncContinuation = global::NLog.Common.AsyncHelpers.PreventMultipleCalls(logEvent.Continuation);
			global::NLog.Common.AsyncLogEventInfo logEvent2 = logEvent.LogEvent.WithContinuation(asyncContinuation);
			try
			{
				this.WriteAsyncThreadSafe(logEvent2);
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrown())
				{
					throw;
				}
				logEvent2.Continuation(exception);
			}
		}

		// Token: 0x06000725 RID: 1829 RVA: 0x00011DEC File Offset: 0x0000FFEC
		public void WriteAsyncLogEvents(params global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			if (logEvents == null || logEvents.Length == 0)
			{
				return;
			}
			this.WriteAsyncLogEvents(logEvents);
		}

		// Token: 0x06000726 RID: 1830 RVA: 0x00011E00 File Offset: 0x00010000
		public void WriteAsyncLogEvents(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			if (logEvents == null || logEvents.Count == 0)
			{
				return;
			}
			if (!this.IsInitialized)
			{
				object syncRoot = this.SyncRoot;
				lock (syncRoot)
				{
					for (int i = 0; i < logEvents.Count; i++)
					{
						logEvents[i].Continuation(null);
					}
				}
				return;
			}
			if (this._initializeException != null)
			{
				object syncRoot = this.SyncRoot;
				lock (syncRoot)
				{
					for (int j = 0; j < logEvents.Count; j++)
					{
						logEvents[j].Continuation(this.CreateInitException());
					}
				}
				return;
			}
			global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> list;
			if (this.OptimizeBufferReuse)
			{
				for (int k = 0; k < logEvents.Count; k++)
				{
					logEvents[k] = logEvents[k].LogEvent.WithContinuation(global::NLog.Common.AsyncHelpers.PreventMultipleCalls(logEvents[k].Continuation));
				}
				list = logEvents;
			}
			else
			{
				global::NLog.Common.AsyncLogEventInfo[] array = new global::NLog.Common.AsyncLogEventInfo[logEvents.Count];
				for (int l = 0; l < logEvents.Count; l++)
				{
					global::NLog.Common.AsyncLogEventInfo asyncLogEventInfo = logEvents[l];
					array[l] = asyncLogEventInfo.LogEvent.WithContinuation(global::NLog.Common.AsyncHelpers.PreventMultipleCalls(asyncLogEventInfo.Continuation));
				}
				list = array;
			}
			try
			{
				this.WriteAsyncThreadSafe(list);
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrown())
				{
					throw;
				}
				for (int m = 0; m < list.Count; m++)
				{
					list[m].Continuation(exception);
				}
			}
		}

		// Token: 0x06000727 RID: 1831 RVA: 0x00011FD0 File Offset: 0x000101D0
		internal void Initialize(global::NLog.Config.LoggingConfiguration configuration)
		{
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				this.LoggingConfiguration = configuration;
				if (!this.IsInitialized)
				{
					global::NLog.Internal.PropertyHelper.CheckRequiredParameters(this);
					try
					{
						this.InitializeTarget();
						this._initializeException = null;
						if (!this._scannedForLayouts)
						{
							global::NLog.Common.InternalLogger.Debug<global::NLog.Targets.Target>("{0}: InitializeTarget is done but not scanned For Layouts", this);
							this.FindAllLayouts();
						}
					}
					catch (global::System.Exception ex)
					{
						global::NLog.Common.InternalLogger.Error(ex, "{0}: Error initializing target", new object[]
						{
							this
						});
						this._initializeException = ex;
						if (ex.MustBeRethrown())
						{
							throw;
						}
					}
					finally
					{
						this._isInitialized = true;
					}
				}
			}
		}

		// Token: 0x06000728 RID: 1832 RVA: 0x00012094 File Offset: 0x00010294
		internal void Close()
		{
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				this.LoggingConfiguration = null;
				if (this.IsInitialized)
				{
					this._isInitialized = false;
					try
					{
						if (this._initializeException == null)
						{
							global::NLog.Common.InternalLogger.Debug<global::NLog.Targets.Target>("Closing target '{0}'.", this);
							this.CloseTarget();
							global::NLog.Common.InternalLogger.Debug<global::NLog.Targets.Target>("Closed target '{0}'.", this);
						}
					}
					catch (global::System.Exception ex)
					{
						global::NLog.Common.InternalLogger.Error(ex, "{0}: Error closing target", new object[]
						{
							this
						});
						if (ex.MustBeRethrown())
						{
							throw;
						}
					}
				}
			}
		}

		// Token: 0x06000729 RID: 1833 RVA: 0x0001213C File Offset: 0x0001033C
		protected virtual void Dispose(bool disposing)
		{
			if (disposing && this._isInitialized)
			{
				this._isInitialized = false;
				if (this._initializeException == null)
				{
					this.CloseTarget();
				}
			}
		}

		// Token: 0x0600072A RID: 1834 RVA: 0x00012162 File Offset: 0x00010362
		protected virtual void InitializeTarget()
		{
			this.FindAllLayouts();
		}

		// Token: 0x0600072B RID: 1835 RVA: 0x0001216C File Offset: 0x0001036C
		private void FindAllLayouts()
		{
			this._allLayouts = global::NLog.Internal.ObjectGraphScanner.FindReachableObjects<global::NLog.Layouts.Layout>(false, new object[]
			{
				this
			});
			global::NLog.Common.InternalLogger.Trace<global::NLog.Targets.Target, int>("{0} has {1} layouts", this, this._allLayouts.Count);
			this._allLayoutsAreThreadAgnostic = this._allLayouts.All((global::NLog.Layouts.Layout layout) => layout.ThreadAgnostic);
			bool oneLayoutIsMutableUnsafe;
			if (this._allLayoutsAreThreadAgnostic)
			{
				oneLayoutIsMutableUnsafe = this._allLayouts.Any((global::NLog.Layouts.Layout layout) => layout.MutableUnsafe);
			}
			else
			{
				oneLayoutIsMutableUnsafe = false;
			}
			this._oneLayoutIsMutableUnsafe = oneLayoutIsMutableUnsafe;
			if (!this._allLayoutsAreThreadAgnostic || this._oneLayoutIsMutableUnsafe)
			{
				this._allLayoutsAreThreadSafe = this._allLayouts.All((global::NLog.Layouts.Layout layout) => layout.ThreadSafe);
			}
			this.StackTraceUsage = this._allLayouts.DefaultIfEmpty<global::NLog.Layouts.Layout>().Max(delegate(global::NLog.Layouts.Layout layout)
			{
				if (layout == null)
				{
					return global::NLog.Config.StackTraceUsage.None;
				}
				return layout.StackTraceUsage;
			});
			global::NLog.Internal.IUsesStackTrace usesStackTrace;
			if ((usesStackTrace = (this as global::NLog.Internal.IUsesStackTrace)) != null && usesStackTrace.StackTraceUsage > this.StackTraceUsage)
			{
				this.StackTraceUsage = usesStackTrace.StackTraceUsage;
			}
			this._scannedForLayouts = true;
		}

		// Token: 0x0600072C RID: 1836 RVA: 0x000122B0 File Offset: 0x000104B0
		protected virtual void CloseTarget()
		{
		}

		// Token: 0x0600072D RID: 1837 RVA: 0x000122B2 File Offset: 0x000104B2
		protected virtual void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			asyncContinuation(null);
		}

		// Token: 0x0600072E RID: 1838 RVA: 0x000122BB File Offset: 0x000104BB
		protected virtual void Write(global::NLog.LogEventInfo logEvent)
		{
		}

		// Token: 0x0600072F RID: 1839 RVA: 0x000122C0 File Offset: 0x000104C0
		protected virtual void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			try
			{
				this.Write(logEvent.LogEvent);
				logEvent.Continuation(null);
			}
			catch (global::System.Exception exception)
			{
				if (exception.MustBeRethrown())
				{
					throw;
				}
				logEvent.Continuation(exception);
			}
		}

		// Token: 0x06000730 RID: 1840 RVA: 0x00012314 File Offset: 0x00010514
		protected virtual void WriteAsyncThreadSafe(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				if (!this.IsInitialized)
				{
					logEvent.Continuation(null);
				}
				else
				{
					this.Write(logEvent);
				}
			}
		}

		// Token: 0x06000731 RID: 1841 RVA: 0x0001236C File Offset: 0x0001056C
		[global::System.Obsolete("Instead override Write(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
		protected virtual void Write(global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			this.Write(logEvents);
		}

		// Token: 0x06000732 RID: 1842 RVA: 0x00012378 File Offset: 0x00010578
		protected virtual void Write(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			for (int i = 0; i < logEvents.Count; i++)
			{
				this.Write(logEvents[i]);
			}
		}

		// Token: 0x06000733 RID: 1843 RVA: 0x000123A3 File Offset: 0x000105A3
		[global::System.Obsolete("Instead override WriteAsyncThreadSafe(IList<AsyncLogEventInfo> logEvents. Marked obsolete on NLog 4.5")]
		protected virtual void WriteAsyncThreadSafe(global::NLog.Common.AsyncLogEventInfo[] logEvents)
		{
			this.WriteAsyncThreadSafe(logEvents);
		}

		// Token: 0x06000734 RID: 1844 RVA: 0x000123AC File Offset: 0x000105AC
		protected virtual void WriteAsyncThreadSafe(global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> logEvents)
		{
			object syncRoot = this.SyncRoot;
			lock (syncRoot)
			{
				if (!this.IsInitialized)
				{
					for (int i = 0; i < logEvents.Count; i++)
					{
						logEvents[i].Continuation(null);
					}
				}
				else
				{
					global::NLog.Common.AsyncLogEventInfo[] array = this.OptimizeBufferReuse ? null : (logEvents as global::NLog.Common.AsyncLogEventInfo[]);
					if (!this.OptimizeBufferReuse && array != null)
					{
						this.Write(array);
					}
					else
					{
						this.Write(logEvents);
					}
				}
			}
		}

		// Token: 0x06000735 RID: 1845 RVA: 0x00012444 File Offset: 0x00010644
		private global::System.Exception CreateInitException()
		{
			return new global::NLog.NLogRuntimeException(string.Format("Target {0} failed to initialize.", this), this._initializeException);
		}

		// Token: 0x06000736 RID: 1846 RVA: 0x0001245C File Offset: 0x0001065C
		[global::System.Obsolete("Logger.Trace(logEvent) now automatically captures the logEvent Properties. Marked obsolete on NLog 4.6")]
		protected void MergeEventProperties(global::NLog.LogEventInfo logEvent)
		{
			if (logEvent.Parameters == null || logEvent.Parameters.Length == 0)
			{
				return;
			}
			for (int i = 0; i < logEvent.Parameters.Length; i++)
			{
				global::NLog.LogEventInfo logEventInfo = logEvent.Parameters[i] as global::NLog.LogEventInfo;
				if (logEventInfo != null && logEventInfo.HasProperties)
				{
					foreach (object key in logEventInfo.Properties.Keys)
					{
						logEvent.Properties.Add(key, logEventInfo.Properties[key]);
					}
					logEventInfo.Properties.Clear();
				}
			}
		}

		// Token: 0x06000737 RID: 1847 RVA: 0x00012508 File Offset: 0x00010708
		protected string RenderLogEvent(global::NLog.Layouts.Layout layout, global::NLog.LogEventInfo logEvent)
		{
			if (layout == null || logEvent == null)
			{
				return null;
			}
			if (this.OptimizeBufferReuse)
			{
				global::NLog.Layouts.SimpleLayout simpleLayout = layout as global::NLog.Layouts.SimpleLayout;
				if (simpleLayout != null && simpleLayout.IsFixedText)
				{
					return simpleLayout.Render(logEvent);
				}
				object obj;
				if ((!layout.ThreadAgnostic || layout.MutableUnsafe) && logEvent.TryGetCachedLayoutValue(layout, out obj))
				{
					return ((obj != null) ? obj.ToString() : null) ?? string.Empty;
				}
				using (global::NLog.Internal.ReusableObjectCreator<global::System.Text.StringBuilder>.LockOject lockOject = this.ReusableLayoutBuilder.Allocate())
				{
					return layout.RenderAllocateBuilder(logEvent, lockOject.Result);
				}
			}
			return layout.Render(logEvent);
		}

		// Token: 0x06000738 RID: 1848 RVA: 0x000125B4 File Offset: 0x000107B4
		public static void Register<T>(string name) where T : global::NLog.Targets.Target
		{
			global::System.Type typeFromHandle = typeof(T);
			global::NLog.Targets.Target.Register(name, typeFromHandle);
		}

		// Token: 0x06000739 RID: 1849 RVA: 0x000125D3 File Offset: 0x000107D3
		public static void Register(string name, global::System.Type targetType)
		{
			global::NLog.Config.ConfigurationItemFactory.Default.Targets.RegisterDefinition(name, targetType);
		}

		// Token: 0x04000165 RID: 357
		private readonly object _lockObject = new object();

		// Token: 0x04000166 RID: 358
		private global::System.Collections.Generic.List<global::NLog.Layouts.Layout> _allLayouts;

		// Token: 0x04000167 RID: 359
		private bool _allLayoutsAreThreadAgnostic;

		// Token: 0x04000168 RID: 360
		private bool _allLayoutsAreThreadSafe;

		// Token: 0x04000169 RID: 361
		private bool _oneLayoutIsMutableUnsafe;

		// Token: 0x0400016A RID: 362
		private bool _scannedForLayouts;

		// Token: 0x0400016B RID: 363
		private global::System.Exception _initializeException;

		// Token: 0x04000170 RID: 368
		private volatile bool _isInitialized;

		// Token: 0x04000171 RID: 369
		internal readonly global::NLog.Internal.ReusableBuilderCreator ReusableLayoutBuilder = new global::NLog.Internal.ReusableBuilderCreator();

		// Token: 0x04000172 RID: 370
		private global::NLog.Internal.StringBuilderPool _precalculateStringBuilderPool;
	}
}
