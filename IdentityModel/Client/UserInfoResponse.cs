using System;
using System.Collections.Generic;
using System.Net;
using System.Security.Claims;

namespace IdentityModel.Client
{
	// Token: 0x0200005F RID: 95
	public class UserInfoResponse : global::IdentityModel.Client.Response
	{
		// Token: 0x170000A8 RID: 168
		// (get) Token: 0x060001BB RID: 443 RVA: 0x00006ED0 File Offset: 0x000050D0
		public global::System.Collections.Generic.IEnumerable<global::System.Security.Claims.Claim> Claims { get; }

		// Token: 0x060001BC RID: 444 RVA: 0x00006ED8 File Offset: 0x000050D8
		public UserInfoResponse(string raw) : base(raw)
		{
			if (!base.IsError)
			{
				this.Claims = base.Json.ToClaims(new string[0]);
			}
		}

		// Token: 0x060001BD RID: 445 RVA: 0x00006F00 File Offset: 0x00005100
		public UserInfoResponse(global::System.Exception exception) : base(exception)
		{
		}

		// Token: 0x060001BE RID: 446 RVA: 0x00006F0C File Offset: 0x0000510C
		public UserInfoResponse(global::System.Net.HttpStatusCode statusCode, string reason) : base(statusCode, reason)
		{
		}
	}
}
