using System;
using System.ServiceModel;

namespace Motorola.CommonCPS.Server.RMDiscoveryServiceInterface
{
	// Token: 0x02000004 RID: 4
	[global::System.ServiceModel.MessageContract]
	public class FileRequest
	{
		// Token: 0x04000003 RID: 3
		[global::System.ServiceModel.MessageBodyMember]
		public string FileName;

		// Token: 0x04000004 RID: 4
		[global::System.ServiceModel.MessageBodyMember]
		public string PAC;
	}
}
