using System;
using System.Net;

namespace IdentityModel.Client
{
	// Token: 0x0200005C RID: 92
	public class TokenRevocationResponse : global::IdentityModel.Client.Response
	{
		// Token: 0x060001B1 RID: 433 RVA: 0x00006B84 File Offset: 0x00004D84
		public TokenRevocationResponse() : base(global::System.Net.HttpStatusCode.OK, "OK")
		{
		}

		// Token: 0x060001B2 RID: 434 RVA: 0x00006B98 File Offset: 0x00004D98
		public TokenRevocationResponse(string raw) : base(raw)
		{
		}

		// Token: 0x060001B3 RID: 435 RVA: 0x00006BA4 File Offset: 0x00004DA4
		public TokenRevocationResponse(global::System.Exception exception) : base(exception)
		{
		}

		// Token: 0x060001B4 RID: 436 RVA: 0x00006BB0 File Offset: 0x00004DB0
		public TokenRevocationResponse(global::System.Net.HttpStatusCode statusCode, string reason) : base(statusCode, reason)
		{
		}
	}
}
