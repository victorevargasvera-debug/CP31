using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.EntityModel
{
	// Token: 0x020001A5 RID: 421
	[global::System.Runtime.Serialization.DataContract(IsReference = true)]
	[global::System.Serializable]
	public class LESystemLinkInfo
	{
		// Token: 0x04000A5E RID: 2654
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.SystemInfo leSystemInfo;

		// Token: 0x04000A5F RID: 2655
		[global::System.Runtime.Serialization.DataMember]
		public global::Motorola.CommonCPS.Server.EntityModel.LinkType? linkType;
	}
}
