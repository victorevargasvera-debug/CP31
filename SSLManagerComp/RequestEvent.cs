using System;
using System.Runtime.Serialization;

namespace SSLMangrComp
{
	// Token: 0x0200001D RID: 29
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public enum RequestEvent
	{
		// Token: 0x0400006A RID: 106
		[global::System.Runtime.Serialization.EnumMember]
		Ack,
		// Token: 0x0400006B RID: 107
		[global::System.Runtime.Serialization.EnumMember]
		Presence,
		// Token: 0x0400006C RID: 108
		[global::System.Runtime.Serialization.EnumMember]
		Absence,
		// Token: 0x0400006D RID: 109
		[global::System.Runtime.Serialization.EnumMember]
		Unknown
	}
}
