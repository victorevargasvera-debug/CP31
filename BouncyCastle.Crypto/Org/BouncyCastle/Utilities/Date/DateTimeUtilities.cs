using System;

namespace Org.BouncyCastle.Utilities.Date
{
	// Token: 0x0200006A RID: 106
	public class DateTimeUtilities
	{
		// Token: 0x0600043E RID: 1086 RVA: 0x00015B87 File Offset: 0x00013D87
		private DateTimeUtilities()
		{
		}

		// Token: 0x0600043F RID: 1087 RVA: 0x00015B90 File Offset: 0x00013D90
		public static long DateTimeToUnixMs(global::System.DateTime dateTime)
		{
			if (dateTime.CompareTo(global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixEpoch) < 0)
			{
				throw new global::System.ArgumentException("DateTime value may not be before the epoch", "dateTime");
			}
			return (dateTime.Ticks - global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixEpoch.Ticks) / 10000L;
		}

		// Token: 0x06000440 RID: 1088 RVA: 0x00015BD8 File Offset: 0x00013DD8
		public static global::System.DateTime UnixMsToDateTime(long unixMs)
		{
			return new global::System.DateTime(unixMs * 10000L + global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.UnixEpoch.Ticks);
		}

		// Token: 0x06000441 RID: 1089 RVA: 0x00015C00 File Offset: 0x00013E00
		public static long CurrentUnixMs()
		{
			return global::Org.BouncyCastle.Utilities.Date.DateTimeUtilities.DateTimeToUnixMs(global::System.DateTime.UtcNow);
		}

		// Token: 0x0400029C RID: 668
		public static readonly global::System.DateTime UnixEpoch = new global::System.DateTime(1970, 1, 1);
	}
}
