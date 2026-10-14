using System;
using System.Collections.Generic;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using System.Text;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;
using Newtonsoft.Json.Serialization;

namespace Motorola.Common.Communication.AmpRequest
{
	// Token: 0x0200003E RID: 62
	public class PostJobDescriptorRequest : global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase
	{
		// Token: 0x1700004C RID: 76
		// (get) Token: 0x0600010C RID: 268 RVA: 0x0000DCDC File Offset: 0x0000BEDC
		// (set) Token: 0x0600010D RID: 269 RVA: 0x0000DD8C File Offset: 0x0000BF8C
		public global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)907082131;
				short num2 = num;
				num = (short)730593683;
				switch (num2 == num)
				{
				default:
				{
					num = (short)1030356992;
					short num3 = num;
					break;
				}
				case true:
					break;
				}
				num = (short)325058561;
				if (num != 0)
				{
				}
				num = (short)1971847168;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1807548417;
				if (num != 0)
				{
				}
				num = (short)1482817536;
				short num2 = num;
				num = (short)579762192;
				short num3 = num;
				num = (short)1859614736;
				switch (num3 == num)
				{
				}
				num = (short)947126272;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600010E RID: 270 RVA: 0x0000DE3C File Offset: 0x0000C03C
		public PostJobDescriptorRequest(global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor jobDescriptor)
		{
			int a_ = 7;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꣁꯃ꓅", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꏁ듃뛅꓇ꏉ꿋꿍꓏믑믓룕냙꿛뇝軟", a_)));
			base.RequestMessage.Content = global::Motorola.Common.Communication.AmpRequest.PostJobDescriptorRequest.a(jobDescriptor);
			base.HasContent = true;
		}

		// Token: 0x0600010F RID: 271 RVA: 0x0000DEC0 File Offset: 0x0000C0C0
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)346226688;
			short num2 = num;
			num = (short)226471753;
			short num3 = num;
			num = (short)1197256521;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)1465384960;
				if (num != 0)
				{
				}
				base.HandleResponse(response);
				try
				{
					string result = response.Content.ReadAsStringAsync().Result;
					this.ResponseData = global::Newtonsoft.Json.JsonConvert.DeserializeObject<global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse>(result);
				}
				catch (global::System.Exception ex)
				{
					throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, ex.Message);
				}
				break;
			}
			num = (short)1726349313;
			if (num != 0)
			{
			}
		}

		// Token: 0x06000110 RID: 272 RVA: 0x0000DFB0 File Offset: 0x0000C1B0
		private static global::System.Net.Http.HttpContent a(global::Motorola.Common.Communication.AmpRequest.Models.HttpJobDescriptor A_0)
		{
			int a_ = 8;
			short num = (short)474522018;
			short num2 = num;
			num = (short)1453892002;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1107951616;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)693305345;
			if (num != 0)
			{
			}
			num = (short)223870976;
			if (num != 0)
			{
			}
			global::Newtonsoft.Json.JsonSerializerSettings settings = new global::Newtonsoft.Json.JsonSerializerSettings
			{
				ContractResolver = new global::Newtonsoft.Json.Serialization.CamelCasePropertyNamesContractResolver(),
				Converters = new global::System.Collections.Generic.List<global::Newtonsoft.Json.JsonConverter>
				{
					new global::Newtonsoft.Json.Converters.StringEnumConverter()
				}
			};
			string text = global::Newtonsoft.Json.JsonConvert.SerializeObject(A_0, settings);
			return new global::System.Net.Http.StringContent(text, global::System.Text.Encoding.UTF8, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꋂ뗄럆ꗈꋊ껌껎ꗐ뫒뫔맖뇚껜냞迠", a_))
			{
				Headers = 
				{
					ContentLength = new long?((long)text.Length)
				}
			};
		}

		// Token: 0x06000111 RID: 273 RVA: 0x0000E0C0 File Offset: 0x0000C2C0
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			switch (0)
			{
			case 0:
				goto IL_24;
			}
			int num;
			short num2;
			global::System.Net.HttpStatusCode statusCode;
			for (;;)
			{
				IL_0A:
				switch (num)
				{
				case 0:
				{
					num2 = (short)1828890348;
					short num3 = num2;
					num2 = (short)2127341292;
					switch ((num3 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_DC;
					default:
					{
						num2 = (short)2046623744;
						if (num2 != 0)
						{
						}
						num2 = (short)58785792;
						short num4 = num2;
						num2 = (short)281542657;
						if (num2 != 0)
						{
						}
						num2 = (short)896532484;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					}
					break;
				}
				case 1:
					if (statusCode != global::System.Net.HttpStatusCode.NotAcceptable)
					{
						num2 = (short)819920896;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_D4;
				case 2:
					goto IL_F4;
				case 3:
					goto IL_DC;
				case 4:
					if (statusCode != global::System.Net.HttpStatusCode.Conflict)
					{
						num2 = (short)2120548355;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_157;
				}
				goto IL_24;
				IL_DC:
				num2 = (short)470417410;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D4:
			this.a(response);
			return;
			IL_F4:
			base.HandleResponseStatusCode(response);
			return;
			IL_157:
			this.b(response);
			return;
			IL_24:
			statusCode = response.StatusCode;
			num2 = (short)778108929;
			num = (int)((global::System.IntPtr)num2);
			goto IL_0A;
		}

		// Token: 0x06000112 RID: 274 RVA: 0x0000E234 File Offset: 0x0000C434
		private void b(global::System.Net.Http.HttpResponseMessage A_0)
		{
			int a_ = 7;
			short num = (short)218646068;
			short num2 = num;
			num = (short)1218659892;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1938096128;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)1717239809;
			if (num != 0)
			{
			}
			num = (short)28835840;
			if (num != 0)
			{
			}
			string message = global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("蛁ꇃ냅ꇇ꧉꧋뻏럑뇓닕ꯗ龎꣛뇝샟雡跣该跧쫩菫鯭蓯틱闳훵鋷闹黻\udefd狿朁甃猅洇礉砋⸍焏琑怓猕樗㨙紛㸝借䜡嘣伥䜧丩ఫ夭夯䘱尳ᘵ嘷唹᰻崽⼿⽁⥃㍅♇⍉⽋⽍⑏㭑㭓㡕硗㭙㉛㩝䁟ౡୣብ䡧३ͫͭoṱᅳɵᅷᑹ᭻幽ꚅ", a_);
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, message);
		}

		// Token: 0x06000113 RID: 275 RVA: 0x0000E2FC File Offset: 0x0000C4FC
		private void a(global::System.Net.Http.HttpResponseMessage A_0)
		{
			int a_ = 14;
			switch (0)
			{
			case 0:
				goto IL_2D;
			}
			short num2;
			string message;
			for (;;)
			{
				IL_13:
				int num;
				string json;
				global::Motorola.Common.Communication.AmpRequest.Models.NotAcceptableResponse notAcceptableResponse;
				switch (num)
				{
				case 0:
					json = null;
					goto IL_16E;
				case 1:
				{
					global::System.Net.Http.HttpContent content = A_0.Content;
					if (content == null)
					{
						num2 = (short)438501376;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					json = content.ReadAsStringAsync().Result;
					goto IL_16E;
				}
				case 2:
					goto IL_146;
				case 3:
					message = string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("鳈ꗊ꣌럎ꇐ뛒뛔ꏖ볘뿚﷜韞뗠럢뗤쟦鯨軪黬鿮黰鷲蛴鋶\ud9f8裺觼黾甀瘂瘄✆樈搊椌樎⬐㌒渔✖搘㬚樜瘞唠䬢Ԥ唦䰨䨪帬䀮弰लᔴ䰶࠸䘺ᴼ帾⽀❂敄㑆㵈⩊㥌㩎≐楒畔ⱖ歘♚", a_), (int)A_0.StatusCode, notAcceptableResponse.Reason, notAcceptableResponse.StatusInfo);
					num2 = (short)173146114;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					goto IL_18B;
				}
				goto IL_2D;
				IL_16E:
				notAcceptableResponse = global::Motorola.Common.Communication.JSONHelper.TryDeserializeJson<global::Motorola.Common.Communication.AmpRequest.Models.NotAcceptableResponse>(json);
				num2 = (short)175767556;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_146:
			num2 = (short)1842020353;
			if (num2 != 0)
			{
			}
			goto IL_1B7;
			IL_2D:
			message = string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("鳈ꗊ꣌럎ꇐ뛒뛔ꏖ볘뿚﷜韞뗠럢뗤쟦鯨軪黬鿮黰鷲蛴鋶\ud9f8裺觼黾甀瘂瘄✆樈搊椌樎⬐㌒渔✖搘", a_), (int)A_0.StatusCode);
			num2 = (short)548143104;
			short num3 = num2;
			num2 = (short)705157898;
			short num4 = num2;
			num2 = (short)1099946762;
			switch ((num4 == num2) ? 1 : 0)
			{
			case 0:
			case 2:
			{
				IL_18B:
				global::Motorola.Common.Communication.AmpRequest.Models.NotAcceptableResponse notAcceptableResponse;
				if (notAcceptableResponse != null)
				{
					num2 = (short)1558249475;
					int num = (int)((global::System.IntPtr)num2);
					goto IL_13;
				}
				break;
			}
			default:
			{
				num2 = (short)526516224;
				if (num2 != 0)
				{
				}
				num2 = (short)2116812801;
				int num = (int)((global::System.IntPtr)num2);
				goto IL_13;
			}
			}
			IL_1B7:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, message);
		}

		// Token: 0x0400008D RID: 141
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse a;
	}
}
