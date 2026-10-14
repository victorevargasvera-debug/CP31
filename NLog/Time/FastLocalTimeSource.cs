using System;

namespace NLog.Time
{
	// Token: 0x02000022 RID: 34
	[global::NLog.Time.TimeSource("FastLocal")]
	public class FastLocalTimeSource : global::NLog.Time.CachedTimeSource
	{
		// Token: 0x17000053 RID: 83
		// (get) Token: 0x0600048B RID: 1163 RVA: 0x0000909B File Offset: 0x0000729B
		protected override global::System.DateTime FreshTime
		{
			get
			{
				return global::System.DateTime.Now;
			}
		}

		// Token: 0x0600048C RID: 1164 RVA: 0x000090A2 File Offset: 0x000072A2
		public override global::System.DateTime FromSystemTime(global::System.DateTime systemTime)
		{
			return systemTime.ToLocalTime();
		}
	}
}
