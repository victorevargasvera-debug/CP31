using System;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000012 RID: 18
	public class HttpDownloadFileCollection : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x1700000B RID: 11
		// (get) Token: 0x06000034 RID: 52 RVA: 0x000049C0 File Offset: 0x00002BC0
		// (set) Token: 0x06000035 RID: 53 RVA: 0x00004A70 File Offset: 0x00002C70
		public byte[] ResponseData
		{
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			get
			{
				short num = (short)1029037977;
				short num2 = num;
				num = (short)1904402329;
				switch (num2 == num)
				{
				}
				num = (short)912719872;
				if (num != 0)
				{
				}
				num = (short)413532160;
				short num3 = num;
				num = (short)570228737;
				if (num != 0)
				{
				}
				return this.a;
			}
			[global::System.Runtime.CompilerServices.CompilerGenerated]
			set
			{
				short num = (short)248993891;
				short num2 = num;
				num = (short)1797675107;
				switch (num2 == num)
				{
				}
				num = (short)1211170817;
				if (num != 0)
				{
				}
				num = (short)563675136;
				short num3 = num;
				num = (short)2119892992;
				if (num != 0)
				{
				}
				this.a = value;
			}
		}

		// Token: 0x06000036 RID: 54 RVA: 0x00004B24 File Offset: 0x00002D24
		public HttpDownloadFileCollection()
		{
			int a_ = 8;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꗂ계ꯆ곈裊ꋌꏎ뷐뛒뛔ꏖ냘듚돜", a_));
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꋂ뗄럆ꗈꋊ껌껎ꗐ뫒뫔맖듚뻜ꯞ蓠韢죤铦鷨駪裬軮鳰", a_)));
		}

		// Token: 0x06000037 RID: 55 RVA: 0x00004B90 File Offset: 0x00002D90
		public HttpDownloadFileCollection(string fileName)
		{
			int a_ = 6;
			base..ctor(global::System.Net.Http.HttpMethod.Get, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("Ꟁꫂ꧄ꋆ諈꓊ꇌꏎ듐냒ꇔ뻖뛘뗚", a_) + fileName);
			base.ReadTimeout = 1800000;
			base.RequestMessage.Headers.Accept.Clear();
			base.RequestMessage.Headers.Accept.Add(new global::System.Net.Http.Headers.MediaTypeWithQualityHeaderValue(global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꃀ돂뗄ꯆꃈ꣊곌믎룐볒믔뛘룚꧜뫞闠컢雤鏦鯨軪賬苮", a_)));
		}

		// Token: 0x06000038 RID: 56 RVA: 0x00004C10 File Offset: 0x00002E10
		public override void HandleResponse(global::System.Net.Http.HttpResponseMessage response)
		{
			short num = (short)1652817921;
			if (num != 0)
			{
			}
			num = (short)1436926552;
			short num2 = num;
			num = (short)880984664;
			switch (num2 == num)
			{
			}
			num = (short)754581504;
			short num3 = num;
			num = (short)1101922304;
			if (num != 0)
			{
			}
			base.HandleResponse(response);
			this.ResponseData = response.Content.ReadAsByteArrayAsync().Result;
		}

		// Token: 0x04000036 RID: 54
		[global::System.Runtime.CompilerServices.CompilerGenerated]
		private byte[] a;
	}
}
