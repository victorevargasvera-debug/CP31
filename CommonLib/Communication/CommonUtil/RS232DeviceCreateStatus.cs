using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200008B RID: 139
	[global::System.Runtime.Serialization.DataContract]
	public enum RS232DeviceCreateStatus
	{
		// Token: 0x04000471 RID: 1137
		[global::System.Runtime.Serialization.EnumMember]
		NOT_START,
		// Token: 0x04000472 RID: 1138
		[global::System.Runtime.Serialization.EnumMember]
		CREATING,
		// Token: 0x04000473 RID: 1139
		[global::System.Runtime.Serialization.EnumMember]
		CREATED,
		// Token: 0x04000474 RID: 1140
		[global::System.Runtime.Serialization.EnumMember]
		FORCE_CANCELLED,
		// Token: 0x04000475 RID: 1141
		[global::System.Runtime.Serialization.EnumMember]
		UN_DEFINED
	}
}
