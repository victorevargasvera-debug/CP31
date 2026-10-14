using System;
using System.Collections.Generic;

namespace Microsoft.IdentityModel.Tokens
{
	// Token: 0x0200003D RID: 61
	// (Invoke) Token: 0x0600019F RID: 415
	public delegate global::System.Collections.Generic.IEnumerable<global::Microsoft.IdentityModel.Tokens.SecurityKey> IssuerSigningKeyResolver(string token, global::Microsoft.IdentityModel.Tokens.SecurityToken securityToken, string kid, global::Microsoft.IdentityModel.Tokens.TokenValidationParameters validationParameters);
}
