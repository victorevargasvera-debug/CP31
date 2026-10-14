using System;
using System.Collections.Generic;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200002A RID: 42
	public class HttpProvUploadConfig : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000078 RID: 120 RVA: 0x00007828 File Offset: 0x00005A28
		public HttpProvUploadConfig(global::System.Collections.Generic.Dictionary<string, global::System.IO.Stream> configFiles)
		{
			int a_ = 10;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꛄ꣆ꟈ귊꓌꣎", a_));
			global::System.Net.Http.MultipartFormDataContent multipartFormDataContent = new global::System.Net.Http.MultipartFormDataContent();
			foreach (global::System.Collections.Generic.KeyValuePair<string, global::System.IO.Stream> keyValuePair in configFiles)
			{
				string key = keyValuePair.Key;
				global::System.Net.Http.StreamContent streamContent = new global::System.Net.Http.StreamContent(keyValuePair.Value);
				streamContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("꓄럆마ꟊ꓌곎냐꟒볔룖럘닜볞闠蛢釤쫦髨鿪鿬諮郰黲", a_));
				string text = global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("", a_) + key + global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("", a_);
				multipartFormDataContent.Add(streamContent, text, text);
			}
			base.RequestMessage.Content = multipartFormDataContent;
		}

		// Token: 0x06000079 RID: 121 RVA: 0x00007910 File Offset: 0x00005B10
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			int a_ = 4;
			switch (0)
			{
			case 0:
				goto IL_91;
			}
			int num;
			global::System.Net.HttpStatusCode statusCode;
			short num2;
			for (;;)
			{
				IL_13:
				switch (num)
				{
				case 0:
					if (statusCode != (global::System.Net.HttpStatusCode)487)
					{
						num2 = (short)2008481795;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1AB;
				case 1:
					num2 = (short)1873281046;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 2:
					num2 = (short)762380295;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 3:
					num2 = (short)1176764432;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 4:
					if (statusCode != global::System.Net.HttpStatusCode.NotAcceptable)
					{
						num2 = (short)1351417857;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_EF;
				case 5:
					num2 = (short)1396637710;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 6:
					switch (statusCode)
					{
					case (global::System.Net.HttpStatusCode)471:
						goto IL_36C;
					case (global::System.Net.HttpStatusCode)472:
						goto IL_50E;
					case (global::System.Net.HttpStatusCode)473:
					case (global::System.Net.HttpStatusCode)474:
						goto IL_659;
					case (global::System.Net.HttpStatusCode)475:
						goto IL_15C;
					default:
						num2 = (short)1485635597;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 7:
					if (statusCode != (global::System.Net.HttpStatusCode)481)
					{
						num2 = (short)719650821;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_353;
				case 8:
					if (statusCode <= (global::System.Net.HttpStatusCode)419)
					{
						num2 = (short)1069875220;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)788529180;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 9:
					goto IL_18D;
				case 10:
					num2 = (short)1617559560;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 11:
					num2 = (short)1680605210;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 12:
					num2 = (short)719454214;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 13:
					num2 = (short)2082996247;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 14:
					if (statusCode != (global::System.Net.HttpStatusCode)482)
					{
						num2 = (short)1315373083;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_1FE;
				case 15:
					if (statusCode <= (global::System.Net.HttpStatusCode)475)
					{
						num2 = (short)1276117002;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)369033240;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 16:
					if (statusCode != (global::System.Net.HttpStatusCode)491)
					{
						num2 = (short)28704779;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_619;
				case 17:
					num2 = (short)2095513625;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 18:
					switch (statusCode)
					{
					case (global::System.Net.HttpStatusCode)461:
						goto IL_5E7;
					case (global::System.Net.HttpStatusCode)462:
						goto IL_192;
					case (global::System.Net.HttpStatusCode)463:
						goto IL_D6;
					default:
						num2 = (short)1948975116;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				case 19:
					goto IL_30F;
				case 20:
					num2 = (short)595066884;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 21:
					goto IL_247;
				case 22:
					if (statusCode != (global::System.Net.HttpStatusCode)419)
					{
						num2 = (short)14221341;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_600;
				case 23:
					goto IL_1F9;
				case 24:
				{
					num2 = (short)1499267072;
					short num3 = num2;
					if (statusCode > (global::System.Net.HttpStatusCode)482)
					{
						num2 = (short)1934032896;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					num2 = (short)544494614;
					short num4 = num2;
					num2 = (short)1918129174;
					switch ((num4 == num2) ? 1 : 0)
					{
					case 0:
					case 2:
						goto IL_30F;
					default:
						num2 = (short)2143682560;
						if (num2 != 0)
						{
						}
						num2 = (short)426115074;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					break;
				}
				case 25:
					goto IL_1DC;
				case 26:
					if (statusCode != (global::System.Net.HttpStatusCode)492)
					{
						num2 = (short)633929745;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_217;
				case 27:
					num2 = (short)1857683477;
					num = (int)((global::System.IntPtr)num2);
					continue;
				case 28:
					if (statusCode != (global::System.Net.HttpStatusCode)421)
					{
						num2 = (short)1139277843;
						num = (int)((global::System.IntPtr)num2);
						continue;
					}
					goto IL_401;
				case 29:
					num2 = (short)155451401;
					num = (int)((global::System.IntPtr)num2);
					continue;
				}
				goto IL_91;
				IL_30F:
				num2 = (short)1432879122;
				num = (int)((global::System.IntPtr)num2);
			}
			IL_D6:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONNECT_TC_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ﲾ껀귂ꯄꋆ꫈뿊믎뻐臔铖律뷚볜뛞跠離韤苦쟨", a_));
			IL_EF:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_NOT_ACCEPTABLE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("꿀뗂꓄ꯆꃈ꿊껎ꓐ꟒뷔닖럘꿚드볞胠韢賤裦蟨쯪黬賮駰雲飴鋶", a_));
			IL_15C:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_BRIDGE_GW_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("苀鏂釆鯈裊諌风냒뫔맖뿘닚뫜￞铠鏢臤蛦鷨軪췬觮郰髲駴鋶鷸헺", a_));
			IL_18D:
			goto IL_659;
			IL_192:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_TC_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("苀ꛄ꣆ꟈ귊꓌꣎ꛒꗔ돖룘꿚룜￞蟠苢賤详賨迪쏬", a_));
			IL_1AB:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_CMB_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ﲾ賀臂꓆ꛈꗊꯌꛎ뛐ꃔꟖ뷘뫚꧜뫞쇠藢蓤軦藨軪觬쇮", a_));
			IL_1DC:
			IL_1F9:
			goto IL_659;
			IL_1FE:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_UEM_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("蓀軂꓆ꛈꗊꯌꛎ뛐ꃔꟖ뷘뫚꧜뫞쇠藢蓤軦藨軪觬쿮\ud9f0뗲ꃴꏶ곸ꧺ룼훾⼀", a_));
			IL_217:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_NTP_CHANGE_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("闀鏂ꛆ귈꿊뿌꫎ꋐꃒ듖뇘뫚돜룞蓠쏢菤蛦胨蟪飬鷮铰\uddf2", a_));
			IL_247:
			goto IL_659;
			IL_353:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_LICENSE_UEM_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("蓀軂ꯆꃈ꣊꣌ꇎꋐ뛒룖꧘뻚꿜뻞闠諢諤触짨跪賬蛮鷰雲釴\ud9f6", a_));
			IL_36C:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_LICENSE_MNIS_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("迀諂雄ꗈꋊ껌꫎뿐ꃒ냔뛘ꯚ룜귞胠韢賤裦蟨쯪诬軮飰鿲郴鏶ퟸ", a_));
			IL_401:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.HttpProvConfigServiceBusy, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ﲾ껀귂ꏄ껆껈뻊뿌껎ꗐ뫒뫔맖律뷚볜뛞跠蛢臤짦짨꣪苬臮韰髲鋴ퟶ諸黺迼觾栀怂怄✆怈砊ⴌ洎搐怒气㤖", a_));
			IL_50E:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_CONFIG_MNIS_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("迀諂雄꫈꓊ꏌ꧎룐듒ꋖ꧘뿚볜ꯞ蓠쏢菤蛦胨蟪裬诮\udff0", a_));
			IL_5E7:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_LICENSE_TC_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("苀꧄껆꫈껊ꏌ볎듐體Ꟗ볘꧚볜ꯞ裠賢诤쟦迨諪蓬菮铰韲\udbf4", a_));
			IL_600:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.HttpProvConfigFileRejected, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ﲾ껀귂ꏄ껆껈뻊뿌껎ꗐ뫒뫔맖律뷚볜뛞跠蛢臤짦짨꣪苬臮韰髲鋴ퟶ諸黺迼觾栀怂怄✆笈渊朌樎爐朒瀔猖㤘爚猜椞䀠伢䰤䌦न䴪䐬䌮吰䀲᬴", a_));
			IL_619:
			num2 = (short)344653825;
			if (num2 != 0)
			{
			}
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_IP_CHANGE_FAILURE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("釀꓄ꏆ귈맊꣌볎ꋐ뛔뿖룘뗚뫜뫞쇠藢蓤軦藨軪觬쇮", a_));
			IL_659:
			base.HandleResponseStatusCode(response);
			return;
			IL_91:
			statusCode = response.StatusCode;
			num2 = (short)1948712975;
			num = (int)((global::System.IntPtr)num2);
			goto IL_13;
		}
	}
}
