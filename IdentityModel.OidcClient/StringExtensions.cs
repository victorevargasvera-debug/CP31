using System;
using System.Diagnostics;

namespace IdentityModel.OidcClient
{
	// Token: 0x0200000A RID: 10
	internal static class StringExtensions
	{
		// Token: 0x06000027 RID: 39 RVA: 0x00003000 File Offset: 0x00001200
		[global::System.Diagnostics.DebuggerStepThrough]
		public static string EnsureTrailingSlash(this string input)
		{
			if (!input.EndsWith("/"))
			{
				return input + "/";
			}
			return input;
		}

		// Token: 0x06000028 RID: 40 RVA: 0x0000301C File Offset: 0x0000121C
		[global::System.Diagnostics.DebuggerStepThrough]
		public static bool IsMissing(this string value)
		{
			return string.IsNullOrWhiteSpace(value);
		}

		// Token: 0x06000029 RID: 41 RVA: 0x00003024 File Offset: 0x00001224
		[global::System.Diagnostics.DebuggerStepThrough]
		public static bool IsPresent(this string value)
		{
			return !string.IsNullOrWhiteSpace(value);
		}
	}
}
