using System;
using System.Net;
using System.Net.Http;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.ProvisioningRequest
{
	// Token: 0x02000039 RID: 57
	public class HttpProvSecureModeOff : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x060000FB RID: 251 RVA: 0x0000D064 File Offset: 0x0000B264
		public HttpProvSecureModeOff()
		{
			int a_ = 8;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뇂ꃄ듆곈뿊賌뫎ꗐ믒", a_));
			base.RequestMessage.Headers.Accept.Clear();
		}

		// Token: 0x060000FC RID: 252 RVA: 0x0000D0A8 File Offset: 0x0000B2A8
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)563602742;
			short num2 = num;
			num = (short)1014752566;
			switch (num2 == num)
			{
			}
			num = (short)1155923968;
			if (num != 0)
			{
			}
			num = (short)151846913;
			if (num != 0)
			{
			}
			num = (short)506462208;
			short num3 = num;
			base.HandleResponse(response);
			this.a = response.Content.ReadAsStringAsync().Result;
		}

		// Token: 0x060000FD RID: 253 RVA: 0x0000D170 File Offset: 0x0000B370
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			int a_ = 0;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			int num;
			short num2;
			global::System.Net.HttpStatusCode statusCode;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1379077023;
					short num3 = num2;
					num2 = (short)2104298399;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_48;
					default:
						num2 = (short)1134231552;
						if (num2 != 0)
						{
						}
						num2 = (short)642318338;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 1:
					if (statusCode != global::System.Net.HttpStatusCode.NotAcceptable)
					{
						num2 = (short)1155727360;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_162;
				case 2:
					goto IL_AA;
				case 3:
					goto IL_48;
				case 4:
				{
					num2 = (short)1530331136;
					short num4 = num2;
					num2 = (short)77070337;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				}
				goto IL_2D;
				IL_48:
				if (statusCode == global::System.Net.HttpStatusCode.Unauthorized)
				{
					break;
				}
				num2 = (short)965607428;
				num = (int)((global::System.IntPtr)num2);
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_Unauthorized, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("펼\udabe맀돂ꃄ꓆뷈껊꧌駐蟒臔蟖律꧚룜곞釠賢诤铦賨쯪黬鯮郰蟲胴蓶\ud9f8飺鋼鯾搀㤂┄", a_) + ((int)response.StatusCode).ToString());
			IL_AA:
			base.HandleResponseStatusCode(response);
			return;
			IL_162:
			num2 = (short)77529089;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_NOT_ACCEPTABLE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("펼\udabe맀돂ꃄ꓆뷈껊꧌駐蟒臔蟖律꧚룜곞釠賢诤铦賨쯪黬鯮郰蟲胴蓶\ud9f8飺鋼鯾搀㤂┄", a_) + ((int)response.StatusCode).ToString());
			IL_2D:
			statusCode = response.StatusCode;
			num2 = (short)1553072131;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}

		// Token: 0x04000087 RID: 135
		private string a;
	}
}
