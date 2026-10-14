using System;
using IdentityModel.Client;

namespace IdentityModel.Internal
{
	// Token: 0x02000033 RID: 51
	internal static class DiscoveryUrlHelper
	{
		// Token: 0x0600006C RID: 108 RVA: 0x00002EAC File Offset: 0x000010AC
		public static bool IsValidScheme(global::System.Uri url)
		{
			return string.Equals(url.Scheme, "http", global::System.StringComparison.OrdinalIgnoreCase) || string.Equals(url.Scheme, "https", global::System.StringComparison.OrdinalIgnoreCase);
		}

		// Token: 0x0600006D RID: 109 RVA: 0x00002ED8 File Offset: 0x000010D8
		public static bool IsSecureScheme(global::System.Uri url, global::IdentityModel.Client.DiscoveryPolicy policy)
		{
			if (policy.RequireHttps)
			{
				if (policy.AllowHttpOnLoopback)
				{
					string dnsSafeHost = url.DnsSafeHost;
					foreach (string b in policy.LoopbackAddresses)
					{
						if (string.Equals(dnsSafeHost, b, global::System.StringComparison.OrdinalIgnoreCase))
						{
							return true;
						}
					}
				}
				return string.Equals(url.Scheme, "https", global::System.StringComparison.OrdinalIgnoreCase);
			}
			return true;
		}
	}
}
