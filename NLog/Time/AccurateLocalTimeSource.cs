using System;

namespace NLog.Time
{
	// Token: 0x0200001F RID: 31
	[global::NLog.Time.TimeSource("AccurateLocal")]
	public class AccurateLocalTimeSource : global::NLog.Time.TimeSource
	{
		// Token: 0x1700004F RID: 79
		// (get) Token: 0x06000482 RID: 1154 RVA: 0x00009016 File Offset: 0x00007216
		public override global::System.DateTime Time
		{
			get
			{
				return global::System.DateTime.Now;
			}
		}

		// Token: 0x06000483 RID: 1155 RVA: 0x0000901D File Offset: 0x0000721D
		public override global::System.DateTime FromSystemTime(global::System.DateTime systemTime)
		{
			return systemTime.ToLocalTime();
		}
	}
}
