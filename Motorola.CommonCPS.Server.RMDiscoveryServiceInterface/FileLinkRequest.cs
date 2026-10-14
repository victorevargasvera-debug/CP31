using System;
using System.ServiceModel;

namespace Motorola.CommonCPS.Server.RMDiscoveryServiceInterface
{
	// Token: 0x02000006 RID: 6
	[global::System.ServiceModel.MessageContract]
	public class FileLinkRequest
	{
		// Token: 0x0400000C RID: 12
		[global::System.ServiceModel.MessageBodyMember]
		public string FileName;

		// Token: 0x0400000D RID: 13
		[global::System.ServiceModel.MessageBodyMember]
		public string PAC;

		// Token: 0x0400000E RID: 14
		[global::System.ServiceModel.MessageBodyMember]
		public string Family;
	}
}
