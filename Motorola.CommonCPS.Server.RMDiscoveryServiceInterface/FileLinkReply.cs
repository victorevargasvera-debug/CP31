using System;
using System.ServiceModel;

namespace Motorola.CommonCPS.Server.RMDiscoveryServiceInterface
{
	// Token: 0x02000007 RID: 7
	[global::System.ServiceModel.MessageContract]
	public class FileLinkReply
	{
		// Token: 0x0400000F RID: 15
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string Url;

		// Token: 0x04000010 RID: 16
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string FileName;

		// Token: 0x04000011 RID: 17
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public long FileLength;

		// Token: 0x04000012 RID: 18
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string Version;

		// Token: 0x04000013 RID: 19
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string Hash;

		// Token: 0x04000014 RID: 20
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string CommandLineArguments;

		// Token: 0x04000015 RID: 21
		[global::System.ServiceModel.MessageHeader(MustUnderstand = true)]
		public string ExecutableName;
	}
}
