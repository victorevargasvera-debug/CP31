using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001A RID: 26
	public class HttpPasswordAuthenticate : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x1700000F RID: 15
		// (get) Token: 0x0600004F RID: 79 RVA: 0x00005B94 File Offset: 0x00003D94
		// (set) Token: 0x06000050 RID: 80 RVA: 0x00005C40 File Offset: 0x00003E40
		public global::Motorola.Common.Communication.DeviceInventory ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)803787479;
				short num2 = num;
				num = (short)1897124567;
				switch (num2 == num)
				{
				}
				num = (short)1395326977;
				if (num != 0)
				{
				}
				num = (short)168296448;
				short num3 = num;
				num = (short)155058176;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1247960362;
				short num2 = num;
				num = (short)1413242154;
				switch (num2 == num)
				{
				}
				num = (short)811532289;
				if (num != 0)
				{
				}
				num = (short)1804533760;
				short num3 = num;
				num = (short)244383744;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000051 RID: 81 RVA: 0x00005CEC File Offset: 0x00003EEC
		public HttpPasswordAuthenticate(string password)
		{
			int a_ = 17;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("볋꿍ꏏꇑꏓ맕꫗뻙", a_));
			this.a = password;
			global::System.Net.Http.HttpContent content = this.CreateRequestContent();
			base.RequestMessage.Content = content;
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("귋뻍ꃏ뻑뷓뗕맗껙뗛뇝軟췡軣闥蟧蓩", a_)));
		}

		// Token: 0x06000052 RID: 82 RVA: 0x00005D74 File Offset: 0x00003F74
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)2140012544;
			short num2 = num;
			num = (short)161547807;
			short num3 = num;
			num = (short)1868957215;
			switch (num3 == num)
			{
			}
			num = (short)1587216384;
			if (num != 0)
			{
			}
			num = (short)442040321;
			if (num != 0)
			{
			}
			base.DecodeReplyMessage(replyBuffer, offset, length);
			string @string = global::System.Text.Encoding.UTF8.GetString(base._myReplyBuffer, offset, length);
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.DeviceInventory>(@string);
		}

		// Token: 0x06000053 RID: 83 RVA: 0x00005E44 File Offset: 0x00004044
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)275185664;
			short num2 = num;
			num = (short)500228971;
			short num3 = num;
			num = (short)828564331;
			switch (num3 == num)
			{
			}
			num = (short)2061500416;
			if (num != 0)
			{
			}
			num = (short)645070849;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.DeviceInventory>(result);
		}

		// Token: 0x06000054 RID: 84 RVA: 0x00005F14 File Offset: 0x00004114
		protected sealed override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			short num = (short)136445952;
			short num2 = num;
			num = (short)1863265152;
			short num3 = num;
			num = (short)956640128;
			switch (num3 == num)
			{
			}
			num = (short)399835137;
			if (num != 0)
			{
			}
			num = (short)1616904192;
			if (num != 0)
			{
			}
			return new global::System.Net.Http.StringContent(this.a, global::System.Text.Encoding.UTF8);
		}

		// Token: 0x0400003E RID: 62
		private readonly string a;

		// Token: 0x0400003F RID: 63
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceInventory b;
	}
}
