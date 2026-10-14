using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000008 RID: 8
	public static class DateTimeUtil
	{
		// Token: 0x0600003D RID: 61 RVA: 0x00003918 File Offset: 0x00001B18
		public static global::System.DateTime Add(global::System.DateTime time, global::System.TimeSpan timespan)
		{
			if (timespan == global::System.TimeSpan.Zero)
			{
				return time;
			}
			if (timespan > global::System.TimeSpan.Zero && global::System.DateTime.MaxValue - time <= timespan)
			{
				return global::Microsoft.IdentityModel.Tokens.DateTimeUtil.GetMaxValue(time.Kind);
			}
			if (timespan < global::System.TimeSpan.Zero && global::System.DateTime.MinValue - time >= timespan)
			{
				return global::Microsoft.IdentityModel.Tokens.DateTimeUtil.GetMinValue(time.Kind);
			}
			return time + timespan;
		}

		// Token: 0x0600003E RID: 62 RVA: 0x00003998 File Offset: 0x00001B98
		public static global::System.DateTime GetMaxValue(global::System.DateTimeKind kind)
		{
			if (kind == global::System.DateTimeKind.Unspecified)
			{
				return new global::System.DateTime(global::System.DateTime.MaxValue.Ticks, global::System.DateTimeKind.Utc);
			}
			return new global::System.DateTime(global::System.DateTime.MaxValue.Ticks, kind);
		}

		// Token: 0x0600003F RID: 63 RVA: 0x000039D0 File Offset: 0x00001BD0
		public static global::System.DateTime GetMinValue(global::System.DateTimeKind kind)
		{
			if (kind == global::System.DateTimeKind.Unspecified)
			{
				return new global::System.DateTime(global::System.DateTime.MinValue.Ticks, global::System.DateTimeKind.Utc);
			}
			return new global::System.DateTime(global::System.DateTime.MinValue.Ticks, kind);
		}

		// Token: 0x06000040 RID: 64 RVA: 0x00003A08 File Offset: 0x00001C08
		public static global::System.DateTime? ToUniversalTime(global::System.DateTime? value)
		{
			if (value == null || value.Value.Kind == global::System.DateTimeKind.Utc)
			{
				return value;
			}
			return new global::System.DateTime?(global::Microsoft.IdentityModel.Tokens.DateTimeUtil.ToUniversalTime(value.Value));
		}

		// Token: 0x06000041 RID: 65 RVA: 0x00003A43 File Offset: 0x00001C43
		public static global::System.DateTime ToUniversalTime(global::System.DateTime value)
		{
			if (value.Kind == global::System.DateTimeKind.Utc)
			{
				return value;
			}
			return value.ToUniversalTime();
		}
	}
}
