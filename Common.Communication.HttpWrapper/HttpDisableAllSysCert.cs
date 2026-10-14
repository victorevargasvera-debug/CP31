using System;
using System.Net.Http;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000010 RID: 16
	public class HttpDisableAllSysCert : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x06000032 RID: 50 RVA: 0x00004978 File Offset: 0x00002B78
		public HttpDisableAllSysCert()
		{
			int a_ = 8;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꃂꃄ뗆뷈ꋊꯌꛎ닐닒ꇔ닖뿚드곞胠臢觤苦꣨蟪臬볮裰胲致鋶铸룺볼볾搀焂焄理", a_));
		}
	}
}
