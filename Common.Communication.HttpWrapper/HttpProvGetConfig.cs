using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000024 RID: 36
	public class HttpProvGetConfig : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x0600006B RID: 107 RVA: 0x00006D98 File Offset: 0x00004F98
		public HttpProvGetConfig(string fileTag)
		{
			int a_ = 2;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("\udebc킾꿀ꗂ계ꃆ", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("\udcbc쾾뇀꿂계꓆꣈뿊꓌ꃎ뿐ﳒ뫔듖귘뻚꧜鋠韢韤苦裨蛪", a_)));
			string str = global::System.Uri.EscapeDataString(fileTag);
			string str2 = global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("芼料ꣀ꿂ꃄ鏆꣈곊", a_) + str;
			string uriString = base.RequestMessage.RequestUri.OriginalString + str2;
			base.RequestMessage.RequestUri = new global::System.Uri(uriString);
		}

		// Token: 0x0600006C RID: 108 RVA: 0x00006E48 File Offset: 0x00005048
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)961216512;
			short num2 = num;
			num = (short)1591754582;
			short num3 = num;
			num = (short)2141470550;
			switch (num3 == num)
			{
			}
			num = (short)1781268481;
			if (num != 0)
			{
			}
			num = (short)1168113664;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			this.a = response.Content.ReadAsByteArrayAsync().Result;
		}

		// Token: 0x04000048 RID: 72
		private byte[] a;
	}
}
