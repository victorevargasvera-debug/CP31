using System;
using System.Net.Http;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x02000013 RID: 19
	public class HttpEnableAllSysCert : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x06000039 RID: 57 RVA: 0x00004CD8 File Offset: 0x00002ED8
		public HttpEnableAllSysCert()
		{
			int a_ = 5;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("ꎿꟁ뛃닅ꇇ곉ꗋ귍뇏ꛑ뇓崙뷗듙뷛볝賟蟡ꗣ諥蓧맩闫鷭蓯韱駳뗵맷맹駻賽瓿焁", a_));
		}
	}
}
