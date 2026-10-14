using System;
using System.Runtime.Serialization;

namespace SSLMangrComp.Packets
{
	// Token: 0x02000024 RID: 36
	[global::System.Runtime.Serialization.DataContract]
	public enum EntitiesTypes
	{
		// Token: 0x04000083 RID: 131
		[global::System.Runtime.Serialization.EnumMember]
		Unknown,
		// Token: 0x04000084 RID: 132
		[global::System.Runtime.Serialization.EnumMember]
		DeviceID = 10,
		// Token: 0x04000085 RID: 133
		[global::System.Runtime.Serialization.EnumMember]
		DeviceName,
		// Token: 0x04000086 RID: 134
		[global::System.Runtime.Serialization.EnumMember]
		UserName,
		// Token: 0x04000087 RID: 135
		[global::System.Runtime.Serialization.EnumMember]
		IPv4,
		// Token: 0x04000088 RID: 136
		[global::System.Runtime.Serialization.EnumMember]
		TalkGroupID = 15
	}
}
