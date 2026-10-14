using System;
using System.ComponentModel;
using System.Threading;
using NLog.Common;
using NLog.Internal;

namespace NLog.Targets.Wrappers
{
	// Token: 0x02000060 RID: 96
	[global::NLog.Targets.Target("BufferingWrapper", IsWrapper = true)]
	public class BufferingTargetWrapper : global::NLog.Targets.Wrappers.WrapperTargetBase
	{
		// Token: 0x060007E0 RID: 2016 RVA: 0x000142B9 File Offset: 0x000124B9
		public BufferingTargetWrapper() : this(null)
		{
		}

		// Token: 0x060007E1 RID: 2017 RVA: 0x000142C2 File Offset: 0x000124C2
		public BufferingTargetWrapper(string name, global::NLog.Targets.Target wrappedTarget) : this(wrappedTarget)
		{
			base.Name = name;
		}

		// Token: 0x060007E2 RID: 2018 RVA: 0x000142D2 File Offset: 0x000124D2
		public BufferingTargetWrapper(global::NLog.Targets.Target wrappedTarget) : this(wrappedTarget, 100)
		{
		}

		// Token: 0x060007E3 RID: 2019 RVA: 0x000142DD File Offset: 0x000124DD
		public BufferingTargetWrapper(global::NLog.Targets.Target wrappedTarget, int bufferSize) : this(wrappedTarget, bufferSize, -1)
		{
		}

		// Token: 0x060007E4 RID: 2020 RVA: 0x000142E8 File Offset: 0x000124E8
		public BufferingTargetWrapper(global::NLog.Targets.Target wrappedTarget, int bufferSize, int flushTimeout) : this(wrappedTarget, bufferSize, flushTimeout, global::NLog.Targets.Wrappers.BufferingTargetWrapperOverflowAction.Flush)
		{
		}

		// Token: 0x060007E5 RID: 2021 RVA: 0x000142F4 File Offset: 0x000124F4
		public BufferingTargetWrapper(global::NLog.Targets.Target wrappedTarget, int bufferSize, int flushTimeout, global::NLog.Targets.Wrappers.BufferingTargetWrapperOverflowAction overflowAction)
		{
			base.WrappedTarget = wrappedTarget;
			this.BufferSize = bufferSize;
			this.FlushTimeout = flushTimeout;
			this.SlidingTimeout = true;
			this.OverflowAction = overflowAction;
		}

		// Token: 0x17000148 RID: 328
		// (get) Token: 0x060007E6 RID: 2022 RVA: 0x0001432B File Offset: 0x0001252B
		// (set) Token: 0x060007E7 RID: 2023 RVA: 0x00014333 File Offset: 0x00012533
		[global::System.ComponentModel.DefaultValue(100)]
		public int BufferSize { get; set; }

		// Token: 0x17000149 RID: 329
		// (get) Token: 0x060007E8 RID: 2024 RVA: 0x0001433C File Offset: 0x0001253C
		// (set) Token: 0x060007E9 RID: 2025 RVA: 0x00014344 File Offset: 0x00012544
		[global::System.ComponentModel.DefaultValue(-1)]
		public int FlushTimeout { get; set; }

		// Token: 0x1700014A RID: 330
		// (get) Token: 0x060007EA RID: 2026 RVA: 0x0001434D File Offset: 0x0001254D
		// (set) Token: 0x060007EB RID: 2027 RVA: 0x00014355 File Offset: 0x00012555
		[global::System.ComponentModel.DefaultValue(true)]
		public bool SlidingTimeout { get; set; }

		// Token: 0x1700014B RID: 331
		// (get) Token: 0x060007EC RID: 2028 RVA: 0x0001435E File Offset: 0x0001255E
		// (set) Token: 0x060007ED RID: 2029 RVA: 0x00014366 File Offset: 0x00012566
		[global::System.ComponentModel.DefaultValue("Flush")]
		public global::NLog.Targets.Wrappers.BufferingTargetWrapperOverflowAction OverflowAction { get; set; }

		// Token: 0x060007EE RID: 2030 RVA: 0x0001436F File Offset: 0x0001256F
		protected override void FlushAsync(global::NLog.Common.AsyncContinuation asyncContinuation)
		{
			this.WriteEventsInBuffer("Flush Async");
			base.FlushAsync(asyncContinuation);
		}

		// Token: 0x060007EF RID: 2031 RVA: 0x00014384 File Offset: 0x00012584
		protected override void InitializeTarget()
		{
			base.InitializeTarget();
			this._buffer = new global::NLog.Common.LogEventInfoBuffer(this.BufferSize, false, 0);
			global::NLog.Common.InternalLogger.Trace<string>("BufferingWrapper(Name={0}): Create Timer", base.Name);
			this._flushTimer = new global::System.Threading.Timer(new global::System.Threading.TimerCallback(this.FlushCallback), null, -1, -1);
		}

		// Token: 0x060007F0 RID: 2032 RVA: 0x000143D4 File Offset: 0x000125D4
		protected override void CloseTarget()
		{
			global::System.Threading.Timer flushTimer = this._flushTimer;
			if (flushTimer != null)
			{
				this._flushTimer = null;
				if (flushTimer.WaitForDispose(global::System.TimeSpan.FromSeconds(1.0)))
				{
					object lockObject = this._lockObject;
					lock (lockObject)
					{
						this.WriteEventsInBuffer("Closing Target");
					}
				}
			}
			base.CloseTarget();
		}

		// Token: 0x060007F1 RID: 2033 RVA: 0x00014448 File Offset: 0x00012648
		protected override void Write(global::NLog.Common.AsyncLogEventInfo logEvent)
		{
			base.PrecalculateVolatileLayouts(logEvent.LogEvent);
			int num = this._buffer.Append(logEvent);
			if (num >= this.BufferSize)
			{
				if (this.OverflowAction == global::NLog.Targets.Wrappers.BufferingTargetWrapperOverflowAction.Flush)
				{
					this.WriteEventsInBuffer("Exceeding BufferSize");
					return;
				}
			}
			else if (this.FlushTimeout > 0 && (this.SlidingTimeout || num == 1))
			{
				this._flushTimer.Change(this.FlushTimeout, -1);
			}
		}

		// Token: 0x060007F2 RID: 2034 RVA: 0x000144B4 File Offset: 0x000126B4
		private void FlushCallback(object state)
		{
			try
			{
				object lockObject = this._lockObject;
				lock (lockObject)
				{
					if (this._flushTimer != null)
					{
						this.WriteEventsInBuffer(null);
					}
				}
			}
			catch (global::System.Exception ex)
			{
				global::NLog.Common.InternalLogger.Error(ex, "BufferingWrapper(Name={0}): Error in flush procedure.", new object[]
				{
					base.Name
				});
				if (ex.MustBeRethrownImmediately())
				{
					throw;
				}
			}
		}

		// Token: 0x060007F3 RID: 2035 RVA: 0x00014534 File Offset: 0x00012734
		private void WriteEventsInBuffer(string reason)
		{
			if (base.WrappedTarget == null)
			{
				global::NLog.Common.InternalLogger.Error<string>("BufferingWrapper(Name={0}): WrappedTarget is NULL", base.Name);
				return;
			}
			object lockObject = this._lockObject;
			lock (lockObject)
			{
				global::NLog.Common.AsyncLogEventInfo[] eventsAndClear = this._buffer.GetEventsAndClear();
				if (eventsAndClear.Length != 0)
				{
					if (reason != null)
					{
						global::NLog.Common.InternalLogger.Trace<string, int, string>("BufferingWrapper(Name={0}): Writing {1} events ({2})", base.Name, eventsAndClear.Length, reason);
					}
					base.WrappedTarget.WriteAsyncLogEvents(eventsAndClear);
				}
			}
		}

		// Token: 0x040001BF RID: 447
		private global::NLog.Common.LogEventInfoBuffer _buffer;

		// Token: 0x040001C0 RID: 448
		private global::System.Threading.Timer _flushTimer;

		// Token: 0x040001C1 RID: 449
		private readonly object _lockObject = new object();
	}
}
