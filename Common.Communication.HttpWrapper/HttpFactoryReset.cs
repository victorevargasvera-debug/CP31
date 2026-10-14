using System;
using System.Net.Http;
using System.Text;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000014 RID: 20
	public class HttpFactoryReset : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x0600003A RID: 58 RVA: 0x00004D08 File Offset: 0x00002F08
		public HttpFactoryReset(int code, string msg)
		{
			int a_ = 13;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("껇ꯉ꿋뫍뿏ꃑ귓蓕뷗꧙맛ꫝ", a_));
			global::Motorola.Common.Communication.FactoryReset factoryReset = new global::Motorola.Common.Communication.FactoryReset(new global::Motorola.Common.Communication.ReasonClass(code, msg));
			this.a = factoryReset;
			base.RequestMessage.Content = this.CreateRequestContent();
		}

		// Token: 0x0600003B RID: 59 RVA: 0x00004D5C File Offset: 0x00002F5C
		protected sealed override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			short num = (short)125110426;
			short num2 = num;
			num = (short)1443994;
			switch (num2 == num)
			{
			}
			num = (short)2140864513;
			if (num != 0)
			{
			}
			num = (short)684785664;
			short num3 = num;
			num = (short)491323392;
			if (num != 0)
			{
			}
			return new global::System.Net.Http.StringContent(global::Motorola.Common.Communication.JSONHelper.ToString(this.a), global::System.Text.Encoding.UTF8);
		}

		// Token: 0x04000037 RID: 55
		private readonly object a;
	}
}
