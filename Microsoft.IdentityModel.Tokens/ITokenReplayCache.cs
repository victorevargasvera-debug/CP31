using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000025 RID: 37
	public interface ITokenReplayCache
	{
		// Token: 0x060000DD RID: 221
		bool TryAdd(string securityToken, global::System.DateTime expiresOn);

		// Token: 0x060000DE RID: 222
		bool TryFind(string securityToken);
	}
}
