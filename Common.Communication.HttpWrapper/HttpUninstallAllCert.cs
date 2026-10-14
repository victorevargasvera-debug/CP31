using System;
using System.Net.Http;
using Motorola.Common.Communication.AmpRequest.Models;

namespace Motorola.Common.Communication
{
	// Token: 0x0200001E RID: 30
	public class HttpUninstallAllCert : global::Motorola.Common.Communication.HttpPbbMessageBase
	{
		// Token: 0x0600005D RID: 93 RVA: 0x00006484 File Offset: 0x00004684
		public HttpUninstallAllCert()
		{
			int a_ = 18;
			base..ctor(global::System.Net.Http.HttpMethod.Post, global::Motorola.Common.Communication.AmpRequest.Models.PostJobDescriptorResponse.b("껌꫎ꏐ꟒볔뇖냘룚볜ꯞ蓠쳢郤触胨藪黬鯮郰鿲駴뛶闸韺뻼뻾䈀昂眄猆稈", a_));
		}
	}
}
