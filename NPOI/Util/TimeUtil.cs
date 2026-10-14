using System;

namespace NPOI.Util
{
	// Token: 0x02000293 RID: 659
	public static class TimeUtil
	{
		// Token: 0x06001215 RID: 4629 RVA: 0x00036344 File Offset: 0x00034544
		public static long CurrentMillis()
		{
			long ticks = global::System.DateTime.Now.Ticks;
			global::System.DateTime dateTime = new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0);
			return (ticks - dateTime.Ticks) / 10000L;
		}
	}
}
