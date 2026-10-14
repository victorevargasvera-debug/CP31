using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000016 RID: 22
	public class HttpInstallCert : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x0600003E RID: 62 RVA: 0x00004F84 File Offset: 0x00003184
		public HttpInstallCert(string certFullName, string name)
		{
			int a_ = 9;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꟃꏅ뫇뻉ꗋ꣍맏뇑뗓ꋕ뷗뗛냝鏟雡藣諥蓧ꧩ귫귭闯胱胳\ud9f5", a_) + name);
			this.a = certFullName;
			base.RequestMessage.Content = this.CreateRequestContent();
		}

		// Token: 0x0600003F RID: 63 RVA: 0x00004FD4 File Offset: 0x000031D4
		protected sealed override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			int a_ = 12;
			if (!new global::System.IO.FileInfo(this.a).Exists)
			{
				short num = (short)592979634;
				short num2 = num;
				num = (short)1070737074;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1969553409;
					if (num != 0)
					{
					}
					num = (short)81199104;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)1150812160;
				short num3 = num;
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, this.a + global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꟈ꓊만듐ꯒ볔ꓖ귘", a_));
			}
			return new global::System.Net.Http.StreamContent(new global::System.IO.FileStream(this.a, global::System.IO.FileMode.Open))
			{
				Headers = 
				{
					ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꛆ마믊ꇌꛎ닐닒ꇔ뻖뛘뗚냞苠韢胤鏦쓨飪駬鷮铰鋲飴", a_))
				}
			};
		}

		// Token: 0x04000039 RID: 57
		private readonly string a;
	}
}
