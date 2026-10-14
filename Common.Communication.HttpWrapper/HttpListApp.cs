using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000017 RID: 23
	public class HttpListApp : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x1700000C RID: 12
		// (get) Token: 0x06000040 RID: 64 RVA: 0x000050F0 File Offset: 0x000032F0
		// (set) Token: 0x06000041 RID: 65 RVA: 0x0000519C File Offset: 0x0000339C
		public global::Motorola.Common.Communication.AppInventory ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1904738563;
				short num2 = num;
				num = (short)506528003;
				switch (num2 == num)
				{
				}
				num = (short)1264517120;
				if (num != 0)
				{
				}
				num = (short)2026766336;
				short num3 = num;
				num = (short)1422131201;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1580612880;
				short num2 = num;
				num = (short)16989456;
				switch (num2 == num)
				{
				}
				num = (short)1184890880;
				if (num != 0)
				{
				}
				num = (short)1712324608;
				short num3 = num;
				num = (short)456196097;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000042 RID: 66 RVA: 0x00005250 File Offset: 0x00003450
		public HttpListApp()
		{
			int a_ = 6;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꃀ돂뗄軆ꟈ뷊꣌ꇎꗐ볒꟔껖", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꃀ돂뗄ꯆꃈ꣊곌믎룐볒믔돘꣚닜뇞", a_)));
		}

		// Token: 0x06000043 RID: 67 RVA: 0x000052BC File Offset: 0x000034BC
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)917015443;
			short num2 = num;
			num = (short)1509657491;
			switch (num2 == num)
			{
			}
			num = (short)1670316033;
			if (num != 0)
			{
			}
			num = (short)678100992;
			short num3 = num;
			num = (short)725221376;
			if (num != 0)
			{
			}
			base.DecodeReplyMessage(replyBuffer, offset, length);
			string @string = global::System.Text.Encoding.UTF8.GetString(base._myReplyBuffer, offset, length);
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.AppInventory>(@string);
		}

		// Token: 0x06000044 RID: 68 RVA: 0x0000538C File Offset: 0x0000358C
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)1219364458;
			short num2 = num;
			num = (short)150341226;
			switch (num2 == num)
			{
			}
			num = (short)1796734976;
			if (num != 0)
			{
			}
			num = (short)1718943744;
			short num3 = num;
			num = (short)1698889729;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.AppInventory>(result);
		}

		// Token: 0x0400003A RID: 58
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.AppInventory a;
	}
}
