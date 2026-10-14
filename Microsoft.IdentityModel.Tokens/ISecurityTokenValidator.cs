using System;
using System.Security.Claims;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000024 RID: 36
	public interface ISecurityTokenValidator
	{
		// Token: 0x060000D8 RID: 216
		bool CanReadToken(string securityToken);

		// Token: 0x17000029 RID: 41
		// (get) Token: 0x060000D9 RID: 217
		bool CanValidateToken { get; }

		// Token: 0x1700002A RID: 42
		// (get) Token: 0x060000DA RID: 218
		// (set) Token: 0x060000DB RID: 219
		int MaximumTokenSizeInBytes { get; set; }

		// Token: 0x060000DC RID: 220
		global::System.Security.Claims.ClaimsPrincipal ValidateToken(string securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters, out global::Microsoft.IdentityModel.Tokens.SecurityToken validatedToken);
	}
}
