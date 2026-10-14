using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000015 RID: 21
	public class HttpInstallApp : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x0600003C RID: 60 RVA: 0x00004E1C File Offset: 0x0000301C
		public HttpInstallApp(string appFullName, string name)
		{
			int a_ = 3;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("\udfbd낿닁跃ꣅ뻇꿉ꋋ뫍뿏ꃑ귓崙", a_) + name);
			this.a = appFullName;
			base.RequestMessage.Content = this.CreateRequestContent();
		}

		// Token: 0x0600003D RID: 61 RVA: 0x00004E6C File Offset: 0x0000306C
		protected sealed override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			int a_ = 14;
			short num = (short)1213267969;
			if (num != 0)
			{
			}
			if (!new global::System.IO.FileInfo(this.a).Exists)
			{
				num = (short)217959562;
				short num2 = num;
				num = (short)1637403786;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)613089280;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)1174798336;
				short num3 = num;
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, this.a + global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꗊꋌ믎뛒귔뻖꫘꿚", a_));
			}
			return new global::System.Net.Http.StreamContent(new global::System.IO.FileStream(this.a, global::System.IO.FileMode.Open))
			{
				Headers = 
				{
					ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("꣈믊뷌ꏎ룐냒듔ꏖ냘듚돜軠胢釤苦鷨웪黬鯮菰雲铴髶", a_))
				}
			};
		}

		// Token: 0x04000038 RID: 56
		private readonly string a;
	}
}
