using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000023 RID: 35
	public class HttpProvGetCfs : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000069 RID: 105 RVA: 0x00006C40 File Offset: 0x00004E40
		public HttpProvGetCfs()
		{
			int a_ = 7;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꇁꋃ뗅韇ꋉ귋볍듏ꗑ뗓ꓕ뷗藙뗛뫝", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뛁ꇃ뻅볇꓋뫍뷏뻑", a_)));
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뛁ꇃ뻅볇볋ꋍ뇏믑뫓", a_)));
		}

		// Token: 0x0600006A RID: 106 RVA: 0x00006CD4 File Offset: 0x00004ED4
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)2053046272;
			short num2 = num;
			num = (short)1809055745;
			if (num != 0)
			{
			}
			num = (short)1905254619;
			short num3 = num;
			num = (short)1468588251;
			switch (num3 == num)
			{
			}
			num = (short)1432223744;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			this.CFSHardwareID = response.Content.ReadAsStringAsync().Result;
		}

		// Token: 0x04000047 RID: 71
		public string CFSHardwareID;
	}
}
