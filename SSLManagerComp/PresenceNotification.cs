using System;
using System.Runtime.Serialization;

namespace SSLMangrComp
{
	// Token: 0x0200001C RID: 28
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public class PresenceNotification
	{
		// Token: 0x060000C4 RID: 196 RVA: 0x0000C640 File Offset: 0x0000A840
		public PresenceNotification()
		{
			this.SubscriptionState = string.Empty;
			this.EntityType = string.Empty;
			this.DeviceId = string.Empty;
			this.IPAddr = string.Empty;
			this.EventValue = global::SSLMangrComp.RequestEvent.Unknown;
			this.PresenceState = global::SSLMangrComp.PresenceState.Unknown;
		}

		// Token: 0x04000063 RID: 99
		[global::System.Runtime.Serialization.DataMember]
		public string SubscriptionState;

		// Token: 0x04000064 RID: 100
		[global::System.Runtime.Serialization.DataMember]
		public string EntityType;

		// Token: 0x04000065 RID: 101
		[global::System.Runtime.Serialization.DataMember]
		public string DeviceId;

		// Token: 0x04000066 RID: 102
		[global::System.Runtime.Serialization.DataMember]
		public string IPAddr;

		// Token: 0x04000067 RID: 103
		[global::System.Runtime.Serialization.DataMember]
		public global::SSLMangrComp.RequestEvent EventValue;

		// Token: 0x04000068 RID: 104
		[global::System.Runtime.Serialization.DataMember]
		public global::SSLMangrComp.PresenceState PresenceState;
	}
}
