using System;
using System.Net.Http;
using System.Text;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001D RID: 29
	public class HttpTerminateSession : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x0600005B RID: 91 RVA: 0x00006370 File Offset: 0x00004570
		public HttpTerminateSession(int code, string msg)
		{
			int a_ = 13;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("볇꿉뻋ꏍ맏병뗓ꋕ뷗觙맛귝鏟诡诣裥", a_));
			this.a = new global::Motorola.Common.Communication.TerminateSession(new global::Motorola.Common.Communication.ReasonClass(code, msg));
			base.RequestMessage.Content = this.CreateRequestContent();
		}

		// Token: 0x0600005C RID: 92 RVA: 0x000063C4 File Offset: 0x000045C4
		protected sealed override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			short num = (short)1723531264;
			short num2 = num;
			num = (short)16384001;
			if (num != 0)
			{
			}
			num = (short)1903240853;
			short num3 = num;
			num = (short)851388053;
			switch (num3 == num)
			{
			}
			num = (short)259981312;
			if (num != 0)
			{
			}
			return new global::System.Net.Http.StringContent(global::Motorola.Common.Communication.JSONHelper.ToString(this.a), global::System.Text.Encoding.UTF8);
		}

		// Token: 0x04000041 RID: 65
		private readonly global::Motorola.Common.Communication.TerminateSession a;
	}
}
