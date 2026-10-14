using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Security.Claims;
using Microsoft.Extensions.Logging;

namespace IdentityModel.OidcClient
{
	// Token: 0x02000009 RID: 9
	internal static class LoggingExtensions
	{
		// Token: 0x06000025 RID: 37 RVA: 0x00002F8C File Offset: 0x0000118C
		[global::System.Diagnostics.DebuggerStepThrough]
		public static void LogClaims(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> claims)
		{
			foreach (global::System.Security.Claims.Claim claim in claims)
			{
				logger.LogDebug(string.Format("Claim: {0}: {1}", claim.Type, claim.Value), new object[0]);
			}
		}

		// Token: 0x06000026 RID: 38 RVA: 0x00002FF0 File Offset: 0x000011F0
		[global::System.Diagnostics.DebuggerStepThrough]
		public static void LogClaims(this global::Microsoft.Extensions.Logging.ILogger logger, global::System.Security.Claims.ClaimsPrincipal user)
		{
			logger.LogClaims(user.Claims);
		}
	}
}
