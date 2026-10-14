using System;

namespace NLog.Time
{
	// Token: 0x02000020 RID: 32
	[global::NLog.Time.TimeSource("AccurateUTC")]
	public class AccurateUtcTimeSource : global::NLog.Time.TimeSource
	{
		// Token: 0x17000050 RID: 80
		// (get) Token: 0x06000485 RID: 1157 RVA: 0x0000902E File Offset: 0x0000722E
		public override global::System.DateTime Time
		{
			get
			{
				return global::System.DateTime.UtcNow;
			}
		}

		// Token: 0x06000486 RID: 1158 RVA: 0x00009035 File Offset: 0x00007235
		public override global::System.DateTime FromSystemTime(global::System.DateTime systemTime)
		{
			return systemTime.ToUniversalTime();
		}
	}
}
