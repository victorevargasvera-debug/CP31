using System;
using System.Collections.Generic;
using System.Threading;
using NLog.Common;
using NLog.Internal;

namespace NLog.Targets.Wrappers
{
	// Token: 0x0200005C RID: 92
	internal class AsyncRequestQueue
	{
		// Token: 0x060007B0 RID: 1968 RVA: 0x000137B4 File Offset: 0x000119B4
		public AsyncRequestQueue(int requestLimit, global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction overflowAction)
		{
			this.RequestLimit = requestLimit;
			this.OnOverflow = overflowAction;
		}

		// Token: 0x1700013D RID: 317
		// (get) Token: 0x060007B1 RID: 1969 RVA: 0x000137D5 File Offset: 0x000119D5
		// (set) Token: 0x060007B2 RID: 1970 RVA: 0x000137DD File Offset: 0x000119DD
		public int RequestLimit { get; set; }

		// Token: 0x1700013E RID: 318
		// (get) Token: 0x060007B3 RID: 1971 RVA: 0x000137E6 File Offset: 0x000119E6
		// (set) Token: 0x060007B4 RID: 1972 RVA: 0x000137EE File Offset: 0x000119EE
		public global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction OnOverflow { get; set; }

		// Token: 0x1700013F RID: 319
		// (get) Token: 0x060007B5 RID: 1973 RVA: 0x000137F8 File Offset: 0x000119F8
		public int RequestCount
		{
			get
			{
				int count;
				lock (this)
				{
					count = this._logEventInfoQueue.Count;
				}
				return count;
			}
		}

		// Token: 0x060007B6 RID: 1974 RVA: 0x0001383C File Offset: 0x00011A3C
		public bool Enqueue(global::NLog.Common.AsyncLogEventInfo logEventInfo)
		{
			bool result;
			lock (this)
			{
				if (this._logEventInfoQueue.Count >= this.RequestLimit)
				{
					global::NLog.Common.InternalLogger.Debug("Async queue is full");
					switch (this.OnOverflow)
					{
					case global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction.Grow:
						global::NLog.Common.InternalLogger.Debug("The overflow action is Grow, adding element anyway");
						break;
					case global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction.Discard:
						global::NLog.Common.InternalLogger.Debug("Discarding one element from queue");
						this._logEventInfoQueue.Dequeue();
						break;
					case global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction.Block:
						while (this._logEventInfoQueue.Count >= this.RequestLimit)
						{
							global::NLog.Common.InternalLogger.Debug("Blocking because the overflow action is Block...");
							global::System.Threading.Monitor.Wait(this);
							global::NLog.Common.InternalLogger.Trace("Entered critical section.");
						}
						global::NLog.Common.InternalLogger.Trace("Limit ok.");
						break;
					}
				}
				this._logEventInfoQueue.Enqueue(logEventInfo);
				result = (this._logEventInfoQueue.Count == 1);
			}
			return result;
		}

		// Token: 0x060007B7 RID: 1975 RVA: 0x00013924 File Offset: 0x00011B24
		public global::NLog.Common.AsyncLogEventInfo[] DequeueBatch(int count)
		{
			global::NLog.Common.AsyncLogEventInfo[] array;
			lock (this)
			{
				if (this._logEventInfoQueue.Count < count)
				{
					count = this._logEventInfoQueue.Count;
				}
				if (count == 0)
				{
					return global::NLog.Internal.ArrayHelper.Empty<global::NLog.Common.AsyncLogEventInfo>();
				}
				array = new global::NLog.Common.AsyncLogEventInfo[count];
				for (int i = 0; i < count; i++)
				{
					array[i] = this._logEventInfoQueue.Dequeue();
				}
				if (this.OnOverflow == global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction.Block)
				{
					global::System.Threading.Monitor.PulseAll(this);
				}
			}
			return array;
		}

		// Token: 0x060007B8 RID: 1976 RVA: 0x000139BC File Offset: 0x00011BBC
		public void DequeueBatch(int count, global::System.Collections.Generic.IList<global::NLog.Common.AsyncLogEventInfo> result)
		{
			lock (this)
			{
				if (this._logEventInfoQueue.Count < count)
				{
					count = this._logEventInfoQueue.Count;
				}
				for (int i = 0; i < count; i++)
				{
					result.Add(this._logEventInfoQueue.Dequeue());
				}
				if (this.OnOverflow == global::NLog.Targets.Wrappers.AsyncTargetWrapperOverflowAction.Block)
				{
					global::System.Threading.Monitor.PulseAll(this);
				}
			}
		}

		// Token: 0x060007B9 RID: 1977 RVA: 0x00013A38 File Offset: 0x00011C38
		public void Clear()
		{
			lock (this)
			{
				this._logEventInfoQueue.Clear();
			}
		}

		// Token: 0x040001AC RID: 428
		private readonly global::System.Collections.Generic.Queue<global::NLog.Common.AsyncLogEventInfo> _logEventInfoQueue = new global::System.Collections.Generic.Queue<global::NLog.Common.AsyncLogEventInfo>();
	}
}
