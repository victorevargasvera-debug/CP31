using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000010 RID: 16
	public static class EpochTime
	{
		// Token: 0x0600008A RID: 138 RVA: 0x00004F98 File Offset: 0x00003198
		public static long GetIntDate(global::System.DateTime datetime)
		{
			global::System.DateTime d = datetime;
			if (datetime.Kind != global::System.DateTimeKind.Utc)
			{
				d = datetime.ToUniversalTime();
			}
			if (d.ToUniversalTime() <= global::Microsoft.IdentityModel.Tokens.EpochTime.UnixEpoch)
			{
				return 0L;
			}
			return (long)(d - global::Microsoft.IdentityModel.Tokens.EpochTime.UnixEpoch).TotalSeconds;
		}

		// Token: 0x0600008B RID: 139 RVA: 0x00004FE4 File Offset: 0x000031E4
		public static global::System.DateTime DateTime(long secondsSinceUnixEpoch)
		{
			if (secondsSinceUnixEpoch <= 0L)
			{
				return global::Microsoft.IdentityModel.Tokens.EpochTime.UnixEpoch;
			}
			if ((double)secondsSinceUnixEpoch > global::System.TimeSpan.MaxValue.TotalSeconds)
			{
				return global::Microsoft.IdentityModel.Tokens.DateTimeUtil.Add(global::Microsoft.IdentityModel.Tokens.EpochTime.UnixEpoch, global::System.TimeSpan.MaxValue).ToUniversalTime();
			}
			return global::Microsoft.IdentityModel.Tokens.DateTimeUtil.Add(global::Microsoft.IdentityModel.Tokens.EpochTime.UnixEpoch, global::System.TimeSpan.FromSeconds((double)secondsSinceUnixEpoch)).ToUniversalTime();
		}

		// Token: 0x04000040 RID: 64
		public static readonly global::System.DateTime UnixEpoch = new global::System.DateTime(1970, 1, 1, 0, 0, 0, 0, global::System.DateTimeKind.Utc);
	}
}
