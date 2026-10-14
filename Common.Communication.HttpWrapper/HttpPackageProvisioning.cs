using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000019 RID: 25
	public class HttpPackageProvisioning : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x1700000E RID: 14
		// (get) Token: 0x0600004A RID: 74 RVA: 0x000057C8 File Offset: 0x000039C8
		// (set) Token: 0x0600004B RID: 75 RVA: 0x00005878 File Offset: 0x00003A78
		public global::Motorola.Common.Communication.FileCollection ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)261717880;
				short num2 = num;
				num = (short)1078951800;
				switch (num2 == num)
				{
				}
				num = (short)1372258305;
				if (num != 0)
				{
				}
				num = (short)170852352;
				short num3 = num;
				num = (short)834469888;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)378097707;
				short num2 = num;
				num = (short)1786662955;
				switch (num2 == num)
				{
				}
				num = (short)1909391361;
				if (num != 0)
				{
				}
				num = (short)1404174336;
				short num3 = num;
				num = (short)1980104704;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x0600004C RID: 76 RVA: 0x00005928 File Offset: 0x00003B28
		public HttpPackageProvisioning(string provisioningPackageFullName, bool? needReboot = null)
		{
			int a_ = 19;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("뻍뇏뇑뿓럕뿗뿙髛럝賟蟡", a_));
			base.ReadTimeout = 3600000;
			this.b = provisioningPackageFullName;
			base.RequestMessage.Content = this.CreateRequestContent();
			if (needReboot.GetValueOrDefault())
			{
				base.RequestMessage.Headers.ConnectionClose = new bool?(true);
			}
		}

		// Token: 0x0600004D RID: 77 RVA: 0x000059A0 File Offset: 0x00003BA0
		protected sealed override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			int a_ = 1;
			short num = (short)367460353;
			if (num != 0)
			{
			}
			if (!global::System.IO.File.Exists(this.b))
			{
				num = (short)1742077782;
				short num2 = num;
				num = (short)683474774;
				switch ((num2 == num) ? 1 : 0)
				{
				case 0:
				case 2:
					break;
				default:
					num = (short)1621622784;
					if (num != 0)
					{
					}
					break;
				}
				num = (short)131923968;
				short num3 = num;
				throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, this.b + global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("鲻킽꾿뛁ꏅ냇ꏉ뿋뫍", a_));
			}
			return new global::System.Net.Http.StreamContent(new global::System.IO.FileStream(this.b, global::System.IO.FileMode.Open))
			{
				Headers = 
				{
					ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("\uddbb캽낿껁귃ꗅ꧇뻉ꗋꇍ뻏﷑믓뗕곗뿙꣛鏟雡難菥觧蟩", a_))
				}
			};
		}

		// Token: 0x0600004E RID: 78 RVA: 0x00005AB4 File Offset: 0x00003CB4
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)1559845046;
			short num2 = num;
			num = (short)1880774838;
			switch (num2 == num)
			{
			}
			num = (short)136052737;
			if (num != 0)
			{
			}
			num = (short)173015040;
			short num3 = num;
			num = (short)260767744;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = (string.IsNullOrEmpty(result) ? null : global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.FileCollection>(result));
		}

		// Token: 0x0400003C RID: 60
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.FileCollection a;

		// Token: 0x0400003D RID: 61
		private readonly string b;
	}
}
