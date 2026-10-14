using System;
using System.Diagnostics;

namespace IdentityModel
{
	// Token: 0x02000009 RID: 9
	internal static class StringExtensions
	{
		// Token: 0x0600001F RID: 31 RVA: 0x000026D8 File Offset: 0x000008D8
		[global::System.Diagnostics.DebuggerStepThrough]
		public static string EnsureTrailingSlash(this string url)
		{
			if (!url.EndsWith("/"))
			{
				return url + "/";
			}
			return url;
		}

		// Token: 0x06000020 RID: 32 RVA: 0x000026F4 File Offset: 0x000008F4
		[global::System.Diagnostics.DebuggerStepThrough]
		public static string RemoveTrailingSlash(this string url)
		{
			if (url != null && url.EndsWith("/"))
			{
				url = url.Substring(0, url.Length - 1);
			}
			return url;
		}
	}
}
