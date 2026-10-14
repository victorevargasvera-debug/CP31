using System;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x02000040 RID: 64
	// (Invoke) Token: 0x060001AB RID: 427
	public delegate bool LifetimeValidator(global::System.DateTime? notBefore, global::System.DateTime? expires, global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters);
}
