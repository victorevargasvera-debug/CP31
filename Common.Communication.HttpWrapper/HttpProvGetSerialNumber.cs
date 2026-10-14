using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000026 RID: 38
	public class HttpProvGetSerialNumber : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x0600006F RID: 111 RVA: 0x00007044 File Offset: 0x00005244
		public HttpProvGetSerialNumber()
		{
			int a_ = 14;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뫈껊뿌ꛎ냐뿒", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뷈껊뗌믎ﻐ믒ꇔ뫖뗘", a_)));
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뷈껊뗌믎ﻐꏒ맔뛖냘뗚", a_)));
		}

		// Token: 0x06000070 RID: 112 RVA: 0x000070D8 File Offset: 0x000052D8
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)93913088;
			short num2 = num;
			num = (short)823314381;
			short num3 = num;
			num = (short)656066509;
			switch (num3 == num)
			{
			}
			num = (short)1440677888;
			if (num != 0)
			{
			}
			num = (short)820510721;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			this.SerialNumber = response.Content.ReadAsStringAsync().Result;
			this.Timestamp = response.Headers.Date.Value.DateTime;
		}

		// Token: 0x0400004A RID: 74
		public string SerialNumber;

		// Token: 0x0400004B RID: 75
		public global::System.DateTime Timestamp;
	}
}
