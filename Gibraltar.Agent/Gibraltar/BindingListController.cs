using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Reflection;
using System.Threading;
using Gibraltar.Data;
using Gibraltar.Monitor;
using Loupe.Extensibility.Data;

namespace Gibraltar
{
	// Token: 0x0200015B RID: 347
	internal class BindingListController<TList, TItem> where TList : global::Gibraltar.FilteredBindingList<TItem>
	{
		// Token: 0x06000E81 RID: 3713 RVA: 0x00024730 File Offset: 0x00022930
		public BindingListController(global::Gibraltar.IDynamicDataSource<TList> dataSource, global::System.ComponentModel.ISynchronizeInvoke syncObject, params object[] listArgs)
		{
			if (dataSource == null)
			{
				throw new global::System.ArgumentNullException("dataSource");
			}
			if (listArgs == null)
			{
				listArgs = new object[0];
			}
			this.m_DataSource = dataSource;
			this.m_SyncObject = syncObject;
			this.m_LogCategory = dataSource.LogCategory;
			this.m_InboundList = this.CreateList(listArgs);
			this.m_OutboundList = this.CreateList(listArgs);
			this.m_InboundList.ListChanged += this.InboundListListChangeHandler;
			this.m_SynchronizeOutboundListDelegate = new global::Gibraltar.SynchronizeListDelegate(this.SynchronizeOutboundList);
			this.m_EventQueue = new global::System.Collections.Generic.Queue<global::System.ComponentModel.ListChangedEventArgs>();
			this.m_LastRefresh = global::System.DateTimeOffset.MinValue;
			this.m_NeedsRefresh = true;
			this.m_NeedsReset = true;
			TList rootList = this.CreateList(listArgs);
			this.m_RootList = rootList;
		}

		// Token: 0x06000E82 RID: 3714 RVA: 0x00024814 File Offset: 0x00022A14
		private TList CreateList(object[] listArgs)
		{
			global::System.Type[] types = new global::System.Type[]
			{
				typeof(global::Gibraltar.BindingListEx<TItem>),
				typeof(global::System.Predicate<TItem>),
				typeof(bool),
				listArgs.GetType()
			};
			object[] parameters = new object[]
			{
				this.m_OutboundList,
				null,
				true,
				listArgs
			};
			global::System.Type typeFromHandle = typeof(TList);
			global::System.Reflection.ConstructorInfo constructor = typeFromHandle.GetConstructor(global::System.Reflection.BindingFlags.Instance | global::System.Reflection.BindingFlags.Public | global::System.Reflection.BindingFlags.NonPublic, null, types, null);
			if (constructor == null)
			{
				string name = typeFromHandle.Name;
				throw new global::System.ArgumentException("Missing constructor: " + name + "(BindingListEx<T> dataSource, Predicate<T> filter, bool getUpdates, params object[] args)");
			}
			return (TList)((object)constructor.Invoke(parameters));
		}

		// Token: 0x1700055C RID: 1372
		// (get) Token: 0x06000E83 RID: 3715 RVA: 0x000248C4 File Offset: 0x00022AC4
		// (set) Token: 0x06000E84 RID: 3716 RVA: 0x000248CC File Offset: 0x00022ACC
		public global::System.ComponentModel.ISynchronizeInvoke SyncObject
		{
			get
			{
				return this.m_SyncObject;
			}
			set
			{
				this.m_SyncObject = value;
			}
		}

		// Token: 0x1700055D RID: 1373
		// (get) Token: 0x06000E85 RID: 3717 RVA: 0x000248D8 File Offset: 0x00022AD8
		public TList RootList
		{
			get
			{
				return this.m_RootList;
			}
		}

		// Token: 0x1700055E RID: 1374
		// (get) Token: 0x06000E86 RID: 3718 RVA: 0x000248E0 File Offset: 0x00022AE0
		// (set) Token: 0x06000E87 RID: 3719 RVA: 0x000248E8 File Offset: 0x00022AE8
		public bool VerboseLogging { get; set; }

		// Token: 0x06000E88 RID: 3720 RVA: 0x000248F4 File Offset: 0x00022AF4
		public void MarkDirty()
		{
			object statusLock = this.m_StatusLock;
			lock (statusLock)
			{
				this.m_NeedsRefresh = true;
				global::System.Threading.Monitor.PulseAll(this.m_StatusLock);
			}
		}

		// Token: 0x1700055F RID: 1375
		// (get) Token: 0x06000E89 RID: 3721 RVA: 0x0002493C File Offset: 0x00022B3C
		public bool IsDirty
		{
			get
			{
				object statusLock = this.m_StatusLock;
				bool result;
				lock (statusLock)
				{
					global::System.Threading.Monitor.PulseAll(this.m_StatusLock);
					result = (this.m_NeedsRefresh || this.m_Refreshing);
				}
				return result;
			}
		}

		// Token: 0x17000560 RID: 1376
		// (get) Token: 0x06000E8A RID: 3722 RVA: 0x00024998 File Offset: 0x00022B98
		public global::System.DateTimeOffset LastRefresh
		{
			get
			{
				object statusLock = this.m_StatusLock;
				global::System.DateTimeOffset lastRefresh;
				lock (statusLock)
				{
					global::System.Threading.Monitor.PulseAll(this.m_StatusLock);
					lastRefresh = this.m_LastRefresh;
				}
				return lastRefresh;
			}
		}

		// Token: 0x17000561 RID: 1377
		// (get) Token: 0x06000E8B RID: 3723 RVA: 0x000249E4 File Offset: 0x00022BE4
		public bool IsLoaded
		{
			get
			{
				object statusLock = this.m_StatusLock;
				bool result;
				lock (statusLock)
				{
					if (this.m_LastRefresh == global::System.DateTimeOffset.MinValue)
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
		}

		// Token: 0x06000E8C RID: 3724 RVA: 0x00024A3C File Offset: 0x00022C3C
		public void Refresh(bool async = true, bool force = false)
		{
			bool flag = false;
			object statusLock = this.m_StatusLock;
			lock (statusLock)
			{
				if (this.m_Refreshing)
				{
					this.m_NeedsRefresh = (this.m_NeedsRefresh || force);
					if (!async)
					{
						while (this.m_Refreshing)
						{
							global::System.Threading.Monitor.Wait(this.m_StatusLock, 1000);
						}
					}
				}
				else if (force || this.m_NeedsRefresh)
				{
					flag = true;
					this.m_Refreshing = true;
				}
				global::System.Threading.Monitor.PulseAll(this.m_StatusLock);
			}
			if (flag)
			{
				if (async)
				{
					global::System.Threading.ThreadPool.QueueUserWorkItem(delegate(object state)
					{
						this.AsyncProcessRefresh();
					});
					return;
				}
				this.ProcessRefresh();
			}
		}

		// Token: 0x06000E8D RID: 3725 RVA: 0x00024B00 File Offset: 0x00022D00
		private void AsyncProcessRefresh()
		{
			try
			{
				this.ProcessRefresh();
			}
			catch (global::System.Exception obj)
			{
				global::System.GC.KeepAlive(obj);
			}
		}

		// Token: 0x06000E8E RID: 3726 RVA: 0x00024B34 File Offset: 0x00022D34
		private global::Gibraltar.Data.OperationMetric GetMetric(string message)
		{
			if (this.VerboseLogging)
			{
				return new global::Gibraltar.Data.OperationMetric(this.m_LogCategory, message);
			}
			return null;
		}

		// Token: 0x06000E8F RID: 3727 RVA: 0x00024B50 File Offset: 0x00022D50
		private void ProcessRefresh()
		{
			using (this.GetMetric("Refresh binding list"))
			{
				try
				{
					object obj = this.m_StatusLock;
					lock (obj)
					{
						this.m_NeedsRefresh = false;
						this.m_LastRefresh = global::System.DateTimeOffset.Now;
						global::System.Threading.Monitor.PulseAll(this.m_StatusLock);
					}
					obj = this.m_Lock;
					lock (obj)
					{
						this.m_NeedsReset = false;
						this.m_AddCount = 0;
						this.m_ChangeCount = 0;
						this.m_DeleteCount = 0;
					}
					global::System.Collections.Generic.IList<global::Gibraltar.IDynamicData> list;
					this.m_DataSource.Synchronize(this.m_InboundList, out list);
					bool flag = true;
					obj = this.m_Lock;
					lock (obj)
					{
						if (this.m_NeedsReset || this.m_EventQueue.Count > 0 || (list != null && list.Count > 0))
						{
							flag = false;
							global::System.ComponentModel.ListChangedEventArgs[] changeEvents = this.m_EventQueue.ToArray();
							this.m_EventQueue.Clear();
							this.ProcessEvents(changeEvents, list);
						}
					}
					if (flag)
					{
						obj = this.m_StatusLock;
						lock (obj)
						{
							this.m_Refreshing = false;
							global::System.Threading.Monitor.PulseAll(this.m_StatusLock);
						}
					}
				}
				catch (global::System.Exception ex)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, this.m_LogCategory, string.Format("Unable to refresh the binding list from the data source due to {0} exception", ex.GetType()), "Changes up to the point of the failure will be reflected at a later refresh, and the collection is still considered dirty.\r\nException Details: {0}", new object[]
					{
						ex.Message
					});
					object obj = this.m_StatusLock;
					lock (obj)
					{
						this.m_NeedsRefresh = true;
						this.m_Refreshing = false;
						global::System.Threading.Monitor.PulseAll(this.m_StatusLock);
					}
					throw;
				}
			}
		}

		// Token: 0x06000E90 RID: 3728 RVA: 0x00024DB0 File Offset: 0x00022FB0
		private void InboundListListChangeHandler(object sender, global::System.ComponentModel.ListChangedEventArgs e)
		{
			object @lock = this.m_Lock;
			lock (@lock)
			{
				if (!this.m_NeedsReset)
				{
					switch (e.ListChangedType)
					{
					case global::System.ComponentModel.ListChangedType.Reset:
					case global::System.ComponentModel.ListChangedType.PropertyDescriptorAdded:
					case global::System.ComponentModel.ListChangedType.PropertyDescriptorDeleted:
					case global::System.ComponentModel.ListChangedType.PropertyDescriptorChanged:
						this.m_NeedsReset = true;
						this.m_EventQueue.Clear();
						return;
					case global::System.ComponentModel.ListChangedType.ItemAdded:
						this.m_EventQueue.Enqueue(new global::Gibraltar.ListChangedEventArgsItemAdded<TItem>(this.m_InboundList[e.NewIndex], e.NewIndex));
						this.m_AddCount++;
						break;
					case global::System.ComponentModel.ListChangedType.ItemDeleted:
						if (e is global::Gibraltar.ListChangedEventArgsItemDeleted<TItem>)
						{
							this.m_EventQueue.Enqueue(e);
							this.m_DeleteCount++;
						}
						break;
					case global::System.ComponentModel.ListChangedType.ItemMoved:
						throw new global::System.NotImplementedException("ListChangedType.ItemMoved is not supported");
					case global::System.ComponentModel.ListChangedType.ItemChanged:
						this.m_EventQueue.Enqueue(e);
						this.m_ChangeCount++;
						break;
					}
					if (this.m_EventQueue.Count > 250)
					{
						this.m_NeedsReset = true;
						this.m_EventQueue.Clear();
					}
				}
			}
		}

		// Token: 0x06000E91 RID: 3729 RVA: 0x00024F08 File Offset: 0x00023108
		private void ProcessEvents(global::System.Collections.Generic.IList<global::System.ComponentModel.ListChangedEventArgs> changeEvents, global::System.Collections.Generic.IList<global::Gibraltar.IDynamicData> deferredUpdates)
		{
			if (this.m_SyncObject == null || !this.m_SyncObject.InvokeRequired)
			{
				this.SynchronizeOutboundList(changeEvents, deferredUpdates);
				return;
			}
			this.m_SyncObject.BeginInvoke(this.m_SynchronizeOutboundListDelegate, new object[]
			{
				changeEvents,
				deferredUpdates
			});
		}

		// Token: 0x06000E92 RID: 3730 RVA: 0x00024F60 File Offset: 0x00023160
		private void SynchronizeOutboundList(global::System.Collections.Generic.IList<global::System.ComponentModel.ListChangedEventArgs> changeEvents, global::System.Collections.Generic.IList<global::Gibraltar.IDynamicData> deferredUpdates)
		{
			using (this.GetMetric("Synchronize Outbound list"))
			{
				try
				{
					this.m_OutboundList.SynchornizationStart();
					int num = (deferredUpdates == null) ? 0 : deferredUpdates.Count;
					if (this.m_NeedsReset || this.m_AddCount + this.m_ChangeCount + this.m_DeleteCount + num >= 250)
					{
						this.ProcessResetEvent(deferredUpdates);
					}
					else
					{
						this.ProcessPendingEvents(changeEvents, deferredUpdates);
					}
				}
				catch (global::System.Exception ex)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Error, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, this.m_LogCategory, string.Format("Unable to synchronize the outbound list from the data source due to {0} exception", ex.GetType()), "Some changes might be reflected, but any other pending change will be lost.\r\nException Details: {0}", new object[]
					{
						ex.Message
					});
				}
				finally
				{
					object obj = this.m_Lock;
					lock (obj)
					{
						this.m_NeedsReset = false;
						this.m_AddCount = 0;
						this.m_ChangeCount = 0;
						this.m_DeleteCount = 0;
					}
					obj = this.m_StatusLock;
					lock (obj)
					{
						this.m_Refreshing = false;
						global::System.Threading.Monitor.PulseAll(this.m_StatusLock);
					}
					this.m_OutboundList.SynchronizationEnd();
				}
			}
		}

		// Token: 0x06000E93 RID: 3731 RVA: 0x00025114 File Offset: 0x00023314
		private void ProcessPendingEvents(global::System.Collections.Generic.IList<global::System.ComponentModel.ListChangedEventArgs> changeEvents, global::System.Collections.Generic.IList<global::Gibraltar.IDynamicData> deferredUpdates)
		{
			foreach (global::System.ComponentModel.ListChangedEventArgs listChangedEventArgs in changeEvents)
			{
				try
				{
					switch (listChangedEventArgs.ListChangedType)
					{
					case global::System.ComponentModel.ListChangedType.ItemAdded:
						this.m_OutboundList.Add(((global::Gibraltar.ListChangedEventArgsItemAdded<TItem>)listChangedEventArgs).Item);
						break;
					case global::System.ComponentModel.ListChangedType.ItemDeleted:
					{
						TItem item = ((global::Gibraltar.ListChangedEventArgsItemDeleted<TItem>)listChangedEventArgs).Item;
						int num = this.m_OutboundList.IndexOf(item);
						if (num >= 0)
						{
							this.m_OutboundList.RemoveAt(num);
						}
						break;
					}
					case global::System.ComponentModel.ListChangedType.ItemChanged:
						this.m_OutboundList.ResetItem(listChangedEventArgs.NewIndex);
						break;
					}
				}
				catch (global::System.Exception ex)
				{
					global::Gibraltar.Monitor.Log.Write(global::Loupe.Extensibility.Data.LogMessageSeverity.Warning, global::Gibraltar.Monitor.LogWriteMode.Queued, ex, this.m_LogCategory, string.Concat(new object[]
					{
						"Failed to process ",
						listChangedEventArgs.ListChangedType,
						" event change for list due to ",
						ex.GetType(),
						" exception"
					}), "We will continue with other events but the outbound list may be in an unexpected state.\r\nEvent: {0}\r\n{1}: {2}", new object[]
					{
						listChangedEventArgs,
						ex.GetType(),
						ex.Message
					});
				}
			}
			if (deferredUpdates != null)
			{
				foreach (global::Gibraltar.IDynamicData dynamicData in deferredUpdates)
				{
					dynamicData.CommitChanges(this.m_SyncObject);
				}
			}
			object @lock = this.m_Lock;
			lock (@lock)
			{
				this.m_EventQueue.Clear();
			}
		}

		// Token: 0x06000E94 RID: 3732 RVA: 0x00025330 File Offset: 0x00023530
		private void ProcessResetEvent(global::System.Collections.Generic.IList<global::Gibraltar.IDynamicData> deferredUpdates)
		{
			if (deferredUpdates != null)
			{
				foreach (global::Gibraltar.IDynamicData dynamicData in deferredUpdates)
				{
					dynamicData.Clear();
				}
			}
			this.m_OutboundList.RaiseListChangedEvents = false;
			try
			{
				this.m_OutboundList.Clear();
				foreach (TItem item in this.m_InboundList)
				{
					this.m_OutboundList.Add(item);
				}
			}
			finally
			{
				this.m_OutboundList.RaiseListChangedEvents = true;
				this.m_OutboundList.ResetBindings();
			}
		}

		// Token: 0x040004CC RID: 1228
		private readonly TList m_RootList;

		// Token: 0x040004CD RID: 1229
		private readonly global::Gibraltar.IDynamicDataSource<TList> m_DataSource;

		// Token: 0x040004CE RID: 1230
		private global::System.ComponentModel.ISynchronizeInvoke m_SyncObject;

		// Token: 0x040004CF RID: 1231
		private readonly TList m_InboundList;

		// Token: 0x040004D0 RID: 1232
		private readonly TList m_OutboundList;

		// Token: 0x040004D1 RID: 1233
		private readonly object m_Lock = new object();

		// Token: 0x040004D2 RID: 1234
		private readonly object m_StatusLock = new object();

		// Token: 0x040004D3 RID: 1235
		private readonly global::System.Collections.Generic.Queue<global::System.ComponentModel.ListChangedEventArgs> m_EventQueue;

		// Token: 0x040004D4 RID: 1236
		private readonly global::Gibraltar.SynchronizeListDelegate m_SynchronizeOutboundListDelegate;

		// Token: 0x040004D5 RID: 1237
		private readonly string m_LogCategory;

		// Token: 0x040004D6 RID: 1238
		private bool m_NeedsRefresh;

		// Token: 0x040004D7 RID: 1239
		private bool m_Refreshing;

		// Token: 0x040004D8 RID: 1240
		private global::System.DateTimeOffset m_LastRefresh;

		// Token: 0x040004D9 RID: 1241
		private bool m_NeedsReset;

		// Token: 0x040004DA RID: 1242
		private int m_AddCount;

		// Token: 0x040004DB RID: 1243
		private int m_ChangeCount;

		// Token: 0x040004DC RID: 1244
		private int m_DeleteCount;

		// Token: 0x040004DD RID: 1245
		private const int ResetEventThreshold = 250;
	}
}
