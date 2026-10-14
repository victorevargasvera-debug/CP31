using System;
using System.Collections.Concurrent;
using Microsoft.IdentityModel.Logging;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json.Linq;

namespace Microsoft.IdentityModel.JsonWebTokens
{
	// Token: 0x02000005 RID: 5
	internal static class JsonWebTokenManager
	{
		// Token: 0x06000033 RID: 51 RVA: 0x000037F3 File Offset: 0x000019F3
		internal static string GetHeaderCacheKey(global::Microsoft.IdentityModel.Tokens.SecurityKey securityKey, string algorithm)
		{
			return string.Format("{0}-{1}-{2}", securityKey.GetType(), securityKey.KeyId, algorithm);
		}

		// Token: 0x06000034 RID: 52 RVA: 0x0000380C File Offset: 0x00001A0C
		internal static string GetHeaderCacheKey(global::Microsoft.IdentityModel.Tokens.SigningCredentials signingCredentials)
		{
			if (signingCredentials == null)
			{
				throw global::Microsoft.IdentityModel.Logging.LogHelper.LogArgumentNullException("signingCredentials");
			}
			return global::Microsoft.IdentityModel.JsonWebTokens.JsonWebTokenManager.GetHeaderCacheKey(signingCredentials.Key, signingCredentials.Algorithm);
		}

		// Token: 0x0400000A RID: 10
		internal static global::System.Collections.Concurrent.ConcurrentDictionary<string, string> KeyToHeaderCache = new global::System.Collections.Concurrent.ConcurrentDictionary<string, string>();

		// Token: 0x0400000B RID: 11
		internal static global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Newtonsoft.Json.Linq.JObject> RawHeaderToJObjectCache = new global::System.Collections.Concurrent.ConcurrentDictionary<string, global::Newtonsoft.Json.Linq.JObject>();
	}
}
