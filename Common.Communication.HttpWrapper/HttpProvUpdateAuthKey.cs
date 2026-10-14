using System;
using System.Net;
using System.Net.Http;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000028 RID: 40
	public class HttpProvUpdateAuthKey : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000074 RID: 116 RVA: 0x000074B4 File Offset: 0x000056B4
		public HttpProvUpdateAuthKey(string key, string alias)
		{
			int a_ = 10;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("꓄닆뷈ꏊ蛌꫎꣐", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Add(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("軄ꋆ냈", a_), key);
			base.RequestMessage.Headers.Add(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("賄ꏆ", a_), alias);
		}

		// Token: 0x06000075 RID: 117 RVA: 0x00007538 File Offset: 0x00005738
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)1289289728;
			short num2 = num;
			num = (short)1840185345;
			if (num != 0)
			{
			}
			num = (short)940734578;
			short num3 = num;
			num = (short)1391949938;
			switch (num3 == num)
			{
			}
			num = (short)505217024;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			this.Response = response.Content.ReadAsStringAsync().Result;
		}

		// Token: 0x06000076 RID: 118 RVA: 0x000075FC File Offset: 0x000057FC
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			int a_ = 3;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_55;
				}
				short num;
				int num3;
				global::System.Net.HttpStatusCode statusCode;
				for (;;)
				{
					IL_13:
					num = (short)1019478016;
					short num2 = num;
					switch (num3)
					{
					case 0:
					{
						if (statusCode == global::System.Net.HttpStatusCode.Unauthorized)
						{
							goto IL_106;
						}
						num = (short)1077194979;
						short num4 = num;
						num = (short)2003939555;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1220149248;
							if (num != 0)
							{
							}
							num = (short)119209985;
							if (num != 0)
							{
							}
							num = (short)2136145923;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)2145648642;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_14A;
					case 3:
						num = (short)1191116804;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (statusCode != global::System.Net.HttpStatusCode.NotAcceptable)
						{
							num = (short)1542455297;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_186;
					}
					break;
				}
				IL_55:
				statusCode = response.StatusCode;
				num = (short)1758265344;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			IL_106:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_Unauthorized, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("꺿ꟁ볃뛅귇꧉룋ꯍ듏鳓苕賗諙ﳛ곝藟釡铣觥蛧駩觫컭華蛱闳苵跷觹\udcfb鷽濿昁愃㰅⠇", a_) + ((int)response.StatusCode).ToString());
			IL_14A:
			base.HandleResponseStatusCode(response);
			return;
			IL_186:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_NOT_ACCEPTABLE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("꺿ꟁ볃뛅귇꧉룋ꯍ듏鳓苕賗諙ﳛ곝藟釡铣觥蛧駩觫컭華蛱闳苵跷觹\udcfb鷽濿昁愃㰅⠇", a_) + ((int)response.StatusCode).ToString());
		}

		// Token: 0x0400004D RID: 77
		public string Response;
	}
}
