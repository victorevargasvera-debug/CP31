using System;

namespace NLog.Time
{
	// Token: 0x02000023 RID: 35
	[global::NLog.Time.TimeSource("FastUTC")]
	public class FastUtcTimeSource : global::NLog.Time.CachedTimeSource
	{
		// Token: 0x17000054 RID: 84
		// (get) Token: 0x0600048E RID: 1166 RVA: 0x000090B3 File Offset: 0x000072B3
		protected override global::System.DateTime FreshTime
		{
			get
			{
				return global::System.DateTime.UtcNow;
			}
		}

		// Token: 0x0600048F RID: 1167 RVA: 0x000090BA File Offset: 0x000072BA
		public override global::System.DateTime FromSystemTime(global::System.DateTime systemTime)
		{
			return systemTime.ToUniversalTime();
		}
	}
}
