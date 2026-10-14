using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000022 RID: 34
	public class HttpProvGetAliasId : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000067 RID: 103 RVA: 0x00006B08 File Offset: 0x00004D08
		public HttpProvGetAliasId()
		{
			int a_ = 10;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꋄꋆ뷈铊곌ꏎ룐닒ꛔ裖냘뿚", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뇄ꋆ뇈뿊뿎뷐닒볔맖", a_)));
		}

		// Token: 0x06000068 RID: 104 RVA: 0x00006B74 File Offset: 0x00004D74
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)981008384;
			short num2 = num;
			num = (short)137082428;
			short num3 = num;
			num = (short)1944041020;
			switch (num3 == num)
			{
			}
			num = (short)2111635457;
			if (num != 0)
			{
			}
			num = (short)979369984;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			this.AliasId = response.Content.ReadAsStringAsync().Result;
		}

		// Token: 0x04000046 RID: 70
		public string AliasId;
	}
}
