using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000020 RID: 32
	public class HttpUpdateLicense : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x06000060 RID: 96 RVA: 0x0000661C File Offset: 0x0000481C
		public HttpUpdateLicense(string licFullName)
		{
			int a_ = 14;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꗈꋊ껌꫎뿐ꃒ냔黖럘귚룜뇞闠賢韤黦", a_));
			this.a = licFullName;
			base.RequestMessage.Content = this.CreateRequestContent();
		}

		// Token: 0x06000061 RID: 97 RVA: 0x00006664 File Offset: 0x00004864
		protected sealed override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			int a_ = 9;
			short num = (short)781243831;
			short num2 = num;
			num = (short)1367463351;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B2;
			case 1:
				break;
			default:
			{
				num = (short)1934360576;
				short num3 = num;
				break;
			}
			}
			num = (short)1979187200;
			if (num != 0)
			{
			}
			num = (short)1377828865;
			if (num != 0)
			{
			}
			if (global::System.IO.File.Exists(this.a))
			{
				return new global::System.Net.Http.StreamContent(new global::System.IO.FileStream(this.a, global::System.IO.FileMode.Open))
				{
					Headers = 
					{
						ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꗃ뛅룇ꛉꗋ귍뇏ꛑ뷓맕뛗돛뷝铟蟡郣쯥鯧黩黫语釯鿱", a_))
					}
				};
			}
			IL_B2:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, this.a + global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꣅꟇ뻉ꯍ꣏믑ꟓꋕ", a_));
		}

		// Token: 0x04000043 RID: 67
		private readonly string a;
	}
}
