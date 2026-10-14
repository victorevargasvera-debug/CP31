using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000050 RID: 80
	[global::System.Runtime.Serialization.DataContract]
	public enum PacketDataMode
	{
		// Token: 0x040002BC RID: 700
		[global::System.Runtime.Serialization.EnumMember]
		FNE,
		// Token: 0x040002BD RID: 701
		[global::System.Runtime.Serialization.EnumMember]
		REPEATED,
		// Token: 0x040002BE RID: 702
		[global::System.Runtime.Serialization.EnumMember]
		DIRECT
	}
}
