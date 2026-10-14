using System;
using System.IO;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication.AmpRequest
{
	// Token: 0x0200003B RID: 59
	public class GetFileRequest : global::Motorola.Common.Communication.AmpRequest.HttpAmpMessageBase
	{
		// Token: 0x1700004B RID: 75
		// (get) Token: 0x06000100 RID: 256 RVA: 0x0000D44C File Offset: 0x0000B64C
		// (set) Token: 0x06000101 RID: 257 RVA: 0x0000D4FC File Offset: 0x0000B6FC
		public global::System.IO.Stream ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)948978035;
				short num2 = num;
				num = (short)877085043;
				switch (num2 == num)
				{
				}
				num = (short)725155840;
				if (num != 0)
				{
				}
				num = (short)752287745;
				if (num != 0)
				{
				}
				num = (short)702021632;
				short num3 = num;
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)1878308996;
				short num2 = num;
				num = (short)1669445764;
				switch (num2 == num)
				{
				}
				num = (short)1790967809;
				if (num != 0)
				{
				}
				num = (short)209453056;
				if (num != 0)
				{
				}
				num = (short)1434255360;
				short num3 = num;
				this.a = value;
			}
		}

		// Token: 0x06000102 RID: 258 RVA: 0x0000D5B0 File Offset: 0x0000B7B0
		public GetFileRequest(string relativePath)
		{
			int a_ = 14;
			base..ctor(global::System.Net.Http.HttpMethod.Get, relativePath);
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("꣈믊뷌ꏎ룐냒듔ꏖ냘듚돜鯠諢闤", a_)));
		}

		// Token: 0x06000103 RID: 259 RVA: 0x0000D610 File Offset: 0x0000B810
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)651821057;
			if (num != 0)
			{
			}
			num = (short)555526675;
			short num2 = num;
			num = (short)1730325011;
			switch (num2 == num)
			{
			}
			num = (short)1967783936;
			if (num != 0)
			{
			}
			num = (short)2125529088;
			short num3 = num;
			base.HandleResponse(response);
			global::System.Net.Http.HttpContent content = response.Content;
			this.ResponseData = ((content != null) ? content.ReadAsStreamAsync().Result : null);
		}

		// Token: 0x06000104 RID: 260 RVA: 0x0000D6E4 File Offset: 0x0000B8E4
		protected override void HandleResponseStatusCode(global::System.Net.Http.HttpResponseMessage response)
		{
			if (response.StatusCode == global::System.Net.HttpStatusCode.NotFound)
			{
				short num = (short)195166209;
				if (num != 0)
				{
				}
				num = (short)845479936;
				short num2 = num;
				num = (short)1180286576;
				short num3 = num;
				num = (short)2097397360;
				switch ((num3 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1107558400;
					if (num != 0)
					{
					}
					this.a();
					return;
				}
			}
			base.HandleResponseStatusCode(response);
		}

		// Token: 0x06000105 RID: 261 RVA: 0x0000D7B0 File Offset: 0x0000B9B0
		private void a()
		{
			int a_ = 18;
			short num = (short)387224102;
			short num2 = num;
			num = (short)131699238;
			switch (num2 == num)
			{
			}
			num = (short)1469317121;
			if (num != 0)
			{
			}
			num = (short)1351745536;
			if (num != 0)
			{
			}
			num = (short)30343168;
			short num3 = num;
			string message = global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("诌ꛎ뷐뛒ꗖ볘꫚꣜뫞鋠韢胤菦짨迪苬諮苰폲鯴飶跸\udbfa飼蟾栀瀂焄", a_);
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.GenericError, message);
		}

		// Token: 0x04000089 RID: 137
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::System.IO.Stream a;
	}
}
