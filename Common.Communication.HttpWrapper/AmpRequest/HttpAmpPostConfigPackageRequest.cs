using System;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.Communication.CommonUtil;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.AmpRequest
{
	// Token: 0x0200003C RID: 60
	public class HttpAmpPostConfigPackageRequest : global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase
	{
		// Token: 0x06000106 RID: 262 RVA: 0x0000D878 File Offset: 0x0000BA78
		public HttpAmpPostConfigPackageRequest(string relativePath, byte[] configPackageData) : base(global::System.Net.Http.HttpMethod.Post, relativePath)
		{
			this.a = configPackageData;
			base.RequestMessage.Content = this.CreateRequestContent();
		}

		// Token: 0x06000107 RID: 263 RVA: 0x0000D8AC File Offset: 0x0000BAAC
		protected override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			int a_ = 2;
			short num = (short)2060291109;
			short num2 = num;
			num = (short)760646693;
			switch (num2 == num)
			{
			default:
			{
				num = (short)987103232;
				short num3 = num;
				break;
			}
			case true:
				break;
			}
			num = (short)501743617;
			if (num != 0)
			{
			}
			num = (short)1415970816;
			if (num != 0)
			{
			}
			global::System.Net.Http.ByteArrayContent byteArrayContent = new global::System.Net.Http.ByteArrayContent(this.a);
			byteArrayContent.Headers.ContentLength = new long?((long)this.a.Length);
			byteArrayContent.Headers.ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("\udcbc쾾뇀꿂계꓆꣈뿊꓌ꃎ뿐ﳒ뫔듖귘뻚꧜鋠韢韤苦裨蛪", a_));
			base.HasContent = true;
			return byteArrayContent;
		}

		// Token: 0x06000108 RID: 264 RVA: 0x0000D9A8 File Offset: 0x0000BBA8
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			int a_ = 3;
			short num = (short)53673984;
			short num2 = num;
			num = (short)1383187681;
			short num3 = num;
			num = (short)1224656097;
			switch ((num3 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				break;
			default:
				num = (short)539230208;
				if (num != 0)
				{
				}
				num = (short)1374748673;
				if (num != 0)
				{
				}
				if (response.IsSuccessStatusCode)
				{
					return;
				}
				break;
			}
			string text = string.Format(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꆿꯁꣃꏅ곇룋ꇍꋑ믓ꗕ곗龎뫛럝賟蟡쓣鋥蟧쫩裫语蛯鯱音鏵싷\udaf9ꧻ都旿稁球挅欇縉椋樍』娑䀓䈕䠗㨙減笝匟刡䬣䠥嬧伩ఫ崭䐯匱䀳䌵䬷ᨹ弻儽␿❁繃晅㍇穉ㅋ", a_), (int)response.StatusCode);
			global::Motorola.Common.Communication.CommonUtil.TraceLogger.Instance.WriteError(text, global::System.Array.Empty<object>());
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, text);
		}

		// Token: 0x0400008A RID: 138
		private readonly byte[] a;
	}
}
