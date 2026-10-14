using System;
using System.Net.Http;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication.ProvisioningRequest
{
	// Token: 0x0200003A RID: 58
	public class HttpProvSecureModeOn : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x060000FE RID: 254 RVA: 0x0000D33C File Offset: 0x0000B53C
		public HttpProvSecureModeOn()
		{
			int a_ = 6;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("닀ꛂꛄ닆믈껊賌뫎ꗐ믒", a_));
			base.RequestMessage.Headers.Accept.Clear();
		}

		// Token: 0x060000FF RID: 255 RVA: 0x0000D380 File Offset: 0x0000B580
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)484896921;
			short num2 = num;
			num = (short)558166169;
			switch (num2 == num)
			{
			}
			num = (short)298713089;
			if (num != 0)
			{
			}
			num = (short)1558708224;
			if (num != 0)
			{
			}
			num = (short)801505280;
			short num3 = num;
			base.HandleResponse(response);
			this.Response = response.Content.ReadAsStringAsync().Result;
		}

		// Token: 0x04000088 RID: 136
		public string Response;
	}
}
