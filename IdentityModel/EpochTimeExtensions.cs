using System;

namespace IdentityModel
{
	// Token: 0x02000007 RID: 7
	public static class EpochTimeExtensions
	{
		// Token: 0x06000018 RID: 24 RVA: 0x00002454 File Offset: 0x00000654
		public static long ToEpochTime(this global::System.DateTime dateTime)
		{
			return (dateTime.ToUniversalTime().Ticks - new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0, global::System.DateTimeKind.Utc).Ticks) / 10000000L;
		}

		// Token: 0x06000019 RID: 25 RVA: 0x00002494 File Offset: 0x00000694
		public static long ToEpochTime(this global::System.DateTimeOffset dateTime)
		{
			return (dateTime.ToUniversalTime().Ticks - new global::System.DateTimeOffset(1970, 1, 1, 0, 0, 0, global::System.TimeSpan.Zero).Ticks) / 10000000L;
		}

		// Token: 0x0600001A RID: 26 RVA: 0x000024D4 File Offset: 0x000006D4
		public static global::System.DateTime ToDateTimeFromEpoch(this long intDate)
		{
			long value = intDate * 10000000L;
			return new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0, global::System.DateTimeKind.Utc).AddTicks(value);
		}

		// Token: 0x0600001B RID: 27 RVA: 0x00002504 File Offset: 0x00000704
		public static global::System.DateTimeOffset ToDateTimeOffsetFromEpoch(this long intDate)
		{
			long ticks = intDate * 10000000L;
			return new global::System.DateTimeOffset(1970, 1, 1, 0, 0, 0, global::System.TimeSpan.Zero).AddTicks(ticks);
		}
	}
}
