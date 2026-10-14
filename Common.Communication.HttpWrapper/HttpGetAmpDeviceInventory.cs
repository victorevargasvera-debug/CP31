using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.AmpRequest;
using Motorola.Common.Communication.AmpRequest.Models;
using Newtonsoft.Json.Linq;

namespace Motorola.Common.Communication
{
	// Token: 0x02000003 RID: 3
	public class HttpGetAmpDeviceInventory : global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase
	{
		// Token: 0x17000003 RID: 3
		// (get) Token: 0x06000004 RID: 4 RVA: 0x0000214C File Offset: 0x0000034C
		// (set) Token: 0x06000005 RID: 5 RVA: 0x000021FC File Offset: 0x000003FC
		public global::Motorola.Common.Communication.AmpDeviceInventory ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)547051765;
				short num2 = num;
				num = (short)891443445;
				switch (num2 == num)
				{
				}
				num = (short)1622671361;
				if (num != 0)
				{
				}
				num = (short)436076544;
				short num3 = num;
				num = (short)1002766336;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)749509605;
				short num2 = num;
				num = (short)1449237477;
				switch (num2 == num)
				{
				}
				num = (short)1932984321;
				if (num != 0)
				{
				}
				num = (short)1635713024;
				short num3 = num;
				num = (short)1240858624;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000006 RID: 6 RVA: 0x000022AC File Offset: 0x000004AC
		public HttpGetAmpDeviceInventory()
		{
			int a_ = 18;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("꧌꫎Ꟑ뫒뛔닖郘뗚ꯜ뫞迠韢諤闦部", a_));
			base.HasContent = false;
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("곌뿎ꇐ뿒볔듖룘꿚드냞迠쳢迤铦蛨藪", a_)));
		}

		// Token: 0x06000007 RID: 7 RVA: 0x00002320 File Offset: 0x00000520
		public override void DecodeReplyMessage(byte[] replyBuffer, int offset, int length)
		{
			short num = (short)917050306;
			short num2 = num;
			num = (short)300749762;
			switch (num2 == num)
			{
			}
			num = (short)645070849;
			if (num != 0)
			{
			}
			num = (short)14811136;
			short num3 = num;
			num = (short)1566113792;
			if (num != 0)
			{
			}
			base.DecodeReplyMessage(replyBuffer, offset, length);
			this.HandleResponse(base.ResponseMessage);
		}

		// Token: 0x06000008 RID: 8 RVA: 0x000023E0 File Offset: 0x000005E0
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			int a_ = 13;
			short num = (short)2069692740;
			short num2 = num;
			num = (short)1810170180;
			switch (num2 == num)
			{
			}
			num = (short)777781248;
			if (num != 0)
			{
			}
			num = (short)1494941696;
			short num3 = num;
			num = (short)1662058497;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			global::Newtonsoft.Json.Linq.JToken jtoken = global::Newtonsoft.Json.Linq.JObject.Parse(response.Content.ReadAsStringAsync().Result)[global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("곇꿉뫋ꟍ돏럑鷓룕껗뿙닛ꫝ迟郡鷣", a_)];
			this.ResponseData = jtoken.ToObject<global::Motorola.Common.Communication.AmpDeviceInventory>();
		}

		// Token: 0x04000003 RID: 3
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.AmpDeviceInventory a;
	}
}
