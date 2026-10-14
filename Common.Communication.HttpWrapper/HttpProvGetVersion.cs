using System;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000027 RID: 39
	public class HttpProvGetVersion : global::Motorola.Common.Communication.HttpMessageBase
	{
		// Token: 0x06000071 RID: 113 RVA: 0x000071BC File Offset: 0x000053BC
		public HttpProvGetVersion()
		{
			int a_ = 8;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뗂ꃄ뗆뫈ꋊꋌꇎ", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꋂ뗄럆ꗈꋊ껌껎ꗐ뫒뫔맖뇚껜냞迠", a_)));
		}

		// Token: 0x06000072 RID: 114 RVA: 0x00007228 File Offset: 0x00005428
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)901578752;
			short num2 = num;
			num = (short)1034067403;
			short num3 = num;
			num = (short)1843240395;
			switch (num3 == num)
			{
			}
			num = (short)802357248;
			if (num != 0)
			{
			}
			num = (short)467337217;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.VersionData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.ProvVersion>(result);
		}

		// Token: 0x06000073 RID: 115 RVA: 0x000072F4 File Offset: 0x000054F4
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			int a_ = 8;
			short num;
			for (;;)
			{
				IL_09:
				switch (0)
				{
				case 0:
					goto IL_56;
				}
				int num3;
				global::System.Net.HttpStatusCode statusCode;
				for (;;)
				{
					IL_13:
					num = (short)964689920;
					short num2 = num;
					switch (num3)
					{
					case 0:
					{
						if (statusCode == global::System.Net.HttpStatusCode.Unauthorized)
						{
							goto IL_DB;
						}
						num = (short)1645253655;
						short num4 = num;
						num = (short)1413452823;
						switch ((num4 == num) ? 1 : 0)
						{
						case 0:
						case 2:
							goto IL_09;
						default:
							num = (short)1562640384;
							if (num != 0)
							{
							}
							num = (short)1942683651;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						break;
					}
					case 1:
						num = (short)406519810;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 2:
						goto IL_11E;
					case 3:
						num = (short)1057423364;
						num3 = (int)((global::System.IntPtr)num);
						continue;
					case 4:
						if (statusCode != global::System.Net.HttpStatusCode.NotAcceptable)
						{
							num = (short)724172801;
							num3 = (int)((global::System.IntPtr)num);
							continue;
						}
						goto IL_159;
					}
					break;
				}
				IL_56:
				statusCode = response.StatusCode;
				num = (short)1580924928;
				num3 = (int)((global::System.IntPtr)num);
				goto IL_13;
			}
			IL_DB:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_Unauthorized, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("雂ꯄꋆ뇈믊꣌곎ꗐ뛒뇔釘迚觜连쇠釢胤铦駨蓪菬鳮铰폲蛴菶飸迺裼賾℀怂樄挆氈ㄊⴌ", a_) + ((int)response.StatusCode).ToString());
			IL_11E:
			num = (short)1128726529;
			if (num != 0)
			{
			}
			base.HandleResponseStatusCode(response);
			return;
			IL_159:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.Http_NOT_ACCEPTABLE, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("雂ꯄꋆ뇈믊꣌곎ꗐ뛒뇔釘迚觜连쇠釢胤铦駨蓪菬鳮铰폲蛴菶飸迺裼賾℀怂樄挆氈ㄊⴌ", a_) + ((int)response.StatusCode).ToString());
		}

		// Token: 0x0400004C RID: 76
		public global::Motorola.Common.Communication.ProvVersion VersionData;
	}
}
