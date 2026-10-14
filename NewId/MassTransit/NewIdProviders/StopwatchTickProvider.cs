using System;
using System.Diagnostics;

namespace MassTransit.NewIdProviders
{
	// Token: 0x02000012 RID: 18
	public class StopwatchTickProvider : global::MassTransit.ITickProvider
	{
		// Token: 0x06000042 RID: 66 RVA: 0x0000309B File Offset: 0x0000129B
		public StopwatchTickProvider()
		{
			this._start = global::System.DateTime.UtcNow;
			this._stopwatch = global::System.Diagnostics.Stopwatch.StartNew();
		}

		// Token: 0x17000007 RID: 7
		// (get) Token: 0x06000043 RID: 67 RVA: 0x000030BC File Offset: 0x000012BC
		public long Ticks
		{
			get
			{
				return this._start.AddTicks(this._stopwatch.Elapsed.Ticks).Ticks;
			}
		}

		// Token: 0x0400001A RID: 26
		private readonly global::System.Diagnostics.Stopwatch _stopwatch;

		// Token: 0x0400001B RID: 27
		private readonly global::System.DateTime _start;
	}
}
