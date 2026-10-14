using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000084 RID: 132
	[global::System.Runtime.Serialization.DataContract]
	public enum RPTerminalStatus
	{
		// Token: 0x040003BE RID: 958
		[global::System.Runtime.Serialization.EnumMember]
		RP_RESET_MODE_NORMAL,
		// Token: 0x040003BF RID: 959
		[global::System.Runtime.Serialization.EnumMember]
		RP_RESET_MODE_CHARGING,
		// Token: 0x040003C0 RID: 960
		[global::System.Runtime.Serialization.EnumMember]
		RP_RESET_MODE_PROGRAMMING,
		// Token: 0x040003C1 RID: 961
		[global::System.Runtime.Serialization.EnumMember]
		RP_RESET_MODE_RP,
		// Token: 0x040003C2 RID: 962
		[global::System.Runtime.Serialization.EnumMember]
		RP_STATUS_UNKNOWN
	}
}
