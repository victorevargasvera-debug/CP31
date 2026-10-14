using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001F RID: 31
	public class HttpUpdateFirmware : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x0600005E RID: 94 RVA: 0x000064B4 File Offset: 0x000046B4
		public HttpUpdateFirmware(string fwFullName)
		{
			int a_ = 1;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("\ud8bb\udbbd뚿ꯁꟃꏅ軇ꏉ뻋ꏍ꟏돑ꛓ돕", a_));
			base.ReadTimeout = 10800000;
			this.a = fwFullName;
			base.RequestMessage.Content = this.CreateRequestContent();
		}

		// Token: 0x0600005F RID: 95 RVA: 0x00006508 File Offset: 0x00004708
		protected sealed override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			int a_ = 5;
			short num = (short)1889011872;
			short num2 = num;
			num = (short)1359677600;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B4;
			case 1:
				break;
			default:
			{
				num = (short)2027683840;
				short num3 = num;
				break;
			}
			}
			num = (short)1339162625;
			if (num != 0)
			{
			}
			num = (short)1160904704;
			if (num != 0)
			{
			}
			if (global::System.IO.File.Exists(this.a))
			{
				return new global::System.Net.Http.StreamContent(new global::System.IO.FileStream(this.a, global::System.IO.FileMode.Open, global::System.IO.FileAccess.Read, global::System.IO.FileShare.ReadWrite))
				{
					Headers = 
					{
						ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꆿ닁듃꫅ꇇ꧉귋뫍맏뷑뫓崙럗맙꣛믝铟쿡韣鋥髧迩跫菭", a_))
					}
				};
			}
			IL_B4:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, this.a + global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꛁꯃꏅ믇ꋋꇍ꓏뇓껕뇗꧙꣛", a_));
		}

		// Token: 0x04000042 RID: 66
		private readonly string a;
	}
}
