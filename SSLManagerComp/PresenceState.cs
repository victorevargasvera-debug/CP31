using System;
using System.Runtime.Serialization;

namespace SSLMangrComp
{
	// Token: 0x0200001E RID: 30
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public enum PresenceState
	{
		// Token: 0x0400006F RID: 111
		[global::System.Runtime.Serialization.EnumMember]
		Unknown,
		// Token: 0x04000070 RID: 112
		[global::System.Runtime.Serialization.EnumMember]
		Present,
		// Token: 0x04000071 RID: 113
		[global::System.Runtime.Serialization.EnumMember]
		Absent
	}
}
