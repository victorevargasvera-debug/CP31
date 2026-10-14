using System;
using System.Collections.Generic;
using System.Net.Http;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000029 RID: 41
	public class HttpProvUpdatePassword : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000077 RID: 119 RVA: 0x000077C4 File Offset: 0x000059C4
		public HttpProvUpdatePassword(string password)
		{
			int a_ = 1;
			base..ctor(global::System.Net.Http.HttpMethod.Put, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("즻캽꒿ꏁ냃ꏅ뷇막꧋볍", a_));
			global::System.Net.Http.HttpContent content = new global::System.Net.Http.FormUrlEncodedContent(new global::System.Collections.Generic.KeyValuePair<string, string>[]
			{
				new global::System.Collections.Generic.KeyValuePair<string, string>(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("첻\udfbd뎿뇁돃꧅뫇껉", a_), password)
			});
			base.RequestMessage.Content = content;
		}
	}
}
