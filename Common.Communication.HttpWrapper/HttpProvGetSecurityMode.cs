using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000025 RID: 37
	public class HttpProvGetSecurityMode : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x0600006D RID: 109 RVA: 0x00006F10 File Offset: 0x00005110
		public HttpProvGetSecurityMode()
		{
			int a_ = 6;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꛀꛂ뇄飆꓈꓊꧌꫎", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뗀ꛂ뷄돆믊ꇌ껎룐뷒", a_)));
		}

		// Token: 0x0600006E RID: 110 RVA: 0x00006F7C File Offset: 0x0000517C
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)1269104640;
			short num2 = num;
			num = (short)57606650;
			short num3 = num;
			num = (short)199754234;
			switch (num3 == num)
			{
			}
			num = (short)326500353;
			if (num != 0)
			{
			}
			num = (short)1785921536;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			this.SecurityMode = response.Content.ReadAsStringAsync().Result;
		}

		// Token: 0x04000049 RID: 73
		public string SecurityMode;
	}
}
