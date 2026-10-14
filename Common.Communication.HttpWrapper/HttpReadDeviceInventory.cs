using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001B RID: 27
	public class HttpReadDeviceInventory : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x17000010 RID: 16
		// (get) Token: 0x06000055 RID: 85 RVA: 0x00005FD0 File Offset: 0x000041D0
		// (set) Token: 0x06000056 RID: 86 RVA: 0x00006080 File Offset: 0x00004280
		public global::Motorola.Common.Communication.DeviceInventory ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1505558528;
				short num2 = num;
				num = (short)1126301697;
				if (num != 0)
				{
				}
				num = (short)1040069243;
				short num3 = num;
				num = (short)1055404667;
				switch (num3 == num)
				{
				}
				num = (short)1500250112;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1837498368;
				short num2 = num;
				num = (short)1304980717;
				short num3 = num;
				num = (short)326397165;
				switch (num3 == num)
				{
				}
				num = (short)102367233;
				if (num != 0)
				{
				}
				num = (short)895614976;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000057 RID: 87 RVA: 0x00006130 File Offset: 0x00004330
		public HttpReadDeviceInventory()
		{
			int a_ = 7;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꛁꇃ냅ꇇ꧉꧋蟍뻏ꓑ뇓룕곗뗙껛꟝", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꏁ듃뛅꓇ꏉ꿋꿍꓏믑믓룕냙꿛뇝軟", a_)));
		}

		// Token: 0x06000058 RID: 88 RVA: 0x0000619C File Offset: 0x0000439C
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)1959657472;
			short num2 = num;
			num = (short)1485307905;
			if (num != 0)
			{
			}
			num = (short)2081497220;
			short num3 = num;
			num = (short)358817924;
			switch (num3 == num)
			{
			}
			num = (short)1080492032;
			if (num != 0)
			{
			}
			base.DecodeReplyMessage(replyBuffer, offset, length);
			string @string = global::System.Text.Encoding.UTF8.GetString(base._myReplyBuffer, offset, length);
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.DeviceInventory>(@string);
		}

		// Token: 0x06000059 RID: 89 RVA: 0x0000626C File Offset: 0x0000446C
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)297336832;
			short num2 = num;
			num = (short)1765732360;
			short num3 = num;
			num = (short)548007944;
			switch (num3 == num)
			{
			}
			num = (short)1576992769;
			if (num != 0)
			{
			}
			num = (short)447086592;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.DeviceInventory>(result);
		}

		// Token: 0x04000040 RID: 64
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.DeviceInventory a;
	}
}
