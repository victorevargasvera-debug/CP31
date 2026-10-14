using System;

namespace CefSharp.Internals
{
	// Token: 0x020000C8 RID: 200
	public sealed class BaseTimeConverter : global::CefSharp.Internals.IBaseTimeConverter
	{
		// Token: 0x060005F4 RID: 1524 RVA: 0x0000964C File Offset: 0x0000784C
		global::System.DateTime global::CefSharp.Internals.IBaseTimeConverter.FromBaseTimeToDateTime(long val)
		{
			long num = val * 10L;
			if (num > 2650467743999999999L)
			{
				return global::System.DateTime.MaxValue;
			}
			if (num >= 0L)
			{
				return global::System.DateTime.FromFileTime(num);
			}
			long num2 = num + 504911232000000000L;
			if (num2 <= 0L)
			{
				return global::System.DateTime.MinValue.ToLocalTime();
			}
			return new global::System.DateTime(num2, global::System.DateTimeKind.Utc).ToLocalTime();
		}

		// Token: 0x060005F5 RID: 1525 RVA: 0x000096AC File Offset: 0x000078AC
		long global::CefSharp.Internals.IBaseTimeConverter.FromDateTimeToBaseTime(global::System.DateTime dateTime)
		{
			global::System.DateTime t = dateTime.ToUniversalTime();
			if (t < global::CefSharp.Internals.BaseTimeConverter.UtcWindowsEpoch)
			{
				long num = t.Ticks - 504911232000000000L;
				return num / 10L;
			}
			return t.ToFileTimeUtc() / 10L;
		}

		// Token: 0x04000365 RID: 869
		private static global::System.DateTime UtcWindowsEpoch = global::System.DateTime.SpecifyKind(global::System.DateTime.Parse("1601-01-01"), global::System.DateTimeKind.Utc);
	}
}
