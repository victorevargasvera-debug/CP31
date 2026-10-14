using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.AmpRequest
{
	// Token: 0x0200003D RID: 61
	public sealed class HttpAmpPostFirmwarePackageRequest : global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase
	{
		// Token: 0x06000109 RID: 265 RVA: 0x0000DA98 File Offset: 0x0000BC98
		public HttpAmpPostFirmwarePackageRequest(string relativePath, global::System.IO.Stream firmwareStream, int? timeout = null) : base(global::System.Net.Http.HttpMethod.Post, relativePath)
		{
			this.b = firmwareStream;
			if (timeout != null)
			{
				base.ReadTimeout = timeout.Value;
			}
			base.RequestMessage.Content = this.CreateRequestContent();
		}

		// Token: 0x0600010A RID: 266 RVA: 0x0000DAE4 File Offset: 0x0000BCE4
		protected override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			int a_ = 3;
			short num = (short)1599259193;
			short num2 = num;
			num = (short)1007993401;
			switch (num2 == num)
			{
			default:
			{
				num = (short)1643577344;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)2022768641;
			if (num != 0)
			{
			}
			num = (short)1108738048;
			if (num != 0)
			{
			}
			global::System.Net.Http.StreamContent streamContent = new global::System.Net.Http.StreamContent(this.b, 16384);
			streamContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("\udfbd낿닁ꣃ꿅ꯇꯉ룋ꟍ뿏병ﯓ맕믗껙맛ꫝ췟釡郣铥跧诩臫", a_));
			streamContent.Headers.ContentLength = new long?(this.b.Length);
			base.HasContent = true;
			return streamContent;
		}

		// Token: 0x0600010B RID: 267 RVA: 0x0000DBE8 File Offset: 0x0000BDE8
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			int a_ = 5;
			short num = (short)935133184;
			short num2 = num;
			num = (short)68805547;
			short num3 = num;
			num = (short)1213785003;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)272039936;
				if (num != 0)
				{
				}
				num = (short)289079297;
				if (num != 0)
				{
				}
				if (response.IsSuccessStatusCode)
				{
					return;
				}
				break;
			}
			string text = string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("蚿ꏁ귃꫅귇껉뫍뿏ꓓ맕ꯗ껙ﳛ룝觟軡臣웥鳧藩쳫諭闯蓱鷳闵鷷샹\udcfb꯽滿朁簃瘅洇椉砋欍琏㈑尓䈕䰗䨙㰛氝䔟儡吣䤥䘧天䤫อ䌯䘱唳䈵䴷䤹᰻崽⼿♁⅃籅桇ㅉ籋㍍", a_), (int)response.StatusCode);
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(text, global::System.Array.Empty<object>());
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, text);
		}

		// Token: 0x0400008B RID: 139
		private const int a = 16384;

		// Token: 0x0400008C RID: 140
		private readonly global::System.IO.Stream b;
	}
}
