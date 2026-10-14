using System;
using System.IO;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.AmpRequest.Models;
using Motorola.Common.CustomException;

namespace Motorola.Common.Communication
{
	// Token: 0x02000021 RID: 33
	public class HttpUploadFileCollection : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x17000011 RID: 17
		// (get) Token: 0x06000062 RID: 98 RVA: 0x00006774 File Offset: 0x00004974
		// (set) Token: 0x06000063 RID: 99 RVA: 0x00006824 File Offset: 0x00004A24
		public global::Motorola.Common.Communication.FileCollection ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1823539200;
				short num2 = num;
				num = (short)69646531;
				short num3 = num;
				num = (short)1370273987;
				switch (num3 == num)
				{
				}
				num = (short)68026369;
				if (num != 0)
				{
				}
				num = (short)926220288;
				if (num != 0)
				{
				}
				return this.b;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)2051473408;
				short num2 = num;
				num = (short)1019219348;
				short num3 = num;
				num = (short)818875796;
				switch (num3 == num)
				{
				}
				num = (short)178257921;
				if (num != 0)
				{
				}
				num = (short)1412628480;
				if (num != 0)
				{
				}
				this.b = value;
			}
		}

		// Token: 0x06000064 RID: 100 RVA: 0x000068D4 File Offset: 0x00004AD4
		public HttpUploadFileCollection(string manifestFileName)
		{
			int a_ = 4;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("\ud9beꣀ꿂ꃄ蓆ꛈꟊꇌ꫎닐꟒볔룖럘", a_));
			base.ReadTimeout = 1800000;
			this.a = manifestFileName;
			base.RequestMessage.Content = this.CreateRequestContent();
		}

		// Token: 0x06000065 RID: 101 RVA: 0x00006928 File Offset: 0x00004B28
		protected sealed override global::System.Net.Http.HttpContent CreateRequestContent()
		{
			int a_ = 0;
			short num = (short)1577661447;
			short num2 = num;
			num = (short)74265607;
			switch ((num2 == num) ? 1 : 0)
			{
			case 0:
			case 2:
				goto IL_B5;
			case 1:
				break;
			default:
			{
				num = (short)1335164928;
				short num3 = num;
				break;
			}
			}
			num = (short)549126144;
			if (num != 0)
			{
			}
			num = (short)1256914945;
			if (num != 0)
			{
			}
			if (global::System.IO.File.Exists(this.a))
			{
				return new global::System.Net.Http.StreamContent(new global::System.IO.FileStream(this.a, global::System.IO.FileMode.Open))
				{
					Headers = 
					{
						ContentType = new global::System.Net.Http.Headers.MediaTypeHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("\udaba춼쾾귀ꫂꛄꛆ뷈ꋊꋌꇎﻐꯒ룔믖", a_))
					}
				};
			}
			IL_B5:
			throw new global::Motorola.Common.CustomException.CommonException(global::Motorola.Common.CustomException.CommonErrorCode.FileIOAccessError, this.a + global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("鮺펼킾뗀ꃄ뿆ꃈ룊만", a_));
		}

		// Token: 0x06000066 RID: 102 RVA: 0x00006A3C File Offset: 0x00004C3C
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)567672832;
			short num2 = num;
			num = (short)1886348634;
			short num3 = num;
			num = (short)1907451226;
			switch (num3 == num)
			{
			}
			num = (short)501809152;
			if (num != 0)
			{
			}
			num = (short)1545928705;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			string result = response.Content.ReadAsStringAsync().Result;
			this.ResponseData = global::Motorola.Common.Communication.JSONHelper.Parse<global::Motorola.Common.Communication.FileCollection>(result);
		}

		// Token: 0x04000044 RID: 68
		private readonly string a;

		// Token: 0x04000045 RID: 69
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private global::Motorola.Common.Communication.FileCollection b;
	}
}
