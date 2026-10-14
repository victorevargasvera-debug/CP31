using System;
using System.Collections.Generic;
using System.Security.Claims;

namespace IdentityModel.OidcClient.Results
{
	// Token: 0x02000028 RID: 40
	public class UserInfoResult : global::IdentityModel.OidcClient.Result
	{
		// Token: 0x17000043 RID: 67
		// (get) Token: 0x060000DD RID: 221 RVA: 0x00005A0C File Offset: 0x00003C0C
		// (set) Token: 0x060000DE RID: 222 RVA: 0x00005A14 File Offset: 0x00003C14
		public global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> Claims { get; set; }
	}
}
