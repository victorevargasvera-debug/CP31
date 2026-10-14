using System;
using System.Runtime.Serialization;

namespace SSLMangrComp.Packets
{
	// Token: 0x0200002F RID: 47
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public enum SubscriptionType
	{
		// Token: 0x040000AC RID: 172
		[global::System.Runtime.Serialization.EnumMember]
		Secure,
		// Token: 0x040000AD RID: 173
		[global::System.Runtime.Serialization.EnumMember]
		Reliable,
		// Token: 0x040000AE RID: 174
		[global::System.Runtime.Serialization.EnumMember]
		Unreliable
	}
}
