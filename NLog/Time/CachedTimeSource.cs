using System;

namespace NLog.Time
{
	// Token: 0x02000021 RID: 33
	public abstract class CachedTimeSource : global::NLog.Time.TimeSource
	{
		// Token: 0x17000051 RID: 81
		// (get) Token: 0x06000488 RID: 1160
		protected abstract global::System.DateTime FreshTime { get; }

		// Token: 0x17000052 RID: 82
		// (get) Token: 0x06000489 RID: 1161 RVA: 0x00009048 File Offset: 0x00007248
		public override global::System.DateTime Time
		{
			get
			{
				int tickCount = global::System.Environment.TickCount;
				if (tickCount == this._lastTicks)
				{
					return this._lastTime;
				}
				global::System.DateTime freshTime = this.FreshTime;
				this._lastTicks = tickCount;
				this._lastTime = freshTime;
				return freshTime;
			}
		}

		// Token: 0x0400004D RID: 77
		private int _lastTicks = -1;

		// Token: 0x0400004E RID: 78
		private global::System.DateTime _lastTime = global::System.DateTime.MinValue;
	}
}
