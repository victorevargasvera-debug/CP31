using System;
using System.Net.Http;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001C RID: 28
	public class HttpRemoveApp : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x0600005A RID: 90 RVA: 0x00006338 File Offset: 0x00004538
		public HttpRemoveApp(string appName)
		{
			int a_ = 11;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꋅ귇ꛉ꧋뫍뗏鏑ꓓꛕ釗듙ꫛ믝軟雡诣铥釧엩", a_) + appName);
		}
	}
}
