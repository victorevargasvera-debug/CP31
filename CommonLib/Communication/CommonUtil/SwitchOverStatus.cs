using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200002A RID: 42
	[global::System.Runtime.Serialization.DataContract]
	public enum SwitchOverStatus
	{
		// Token: 0x0400010C RID: 268
		[global::System.Runtime.Serialization.EnumMember]
		Success,
		// Token: 0x0400010D RID: 269
		[global::System.Runtime.Serialization.EnumMember]
		InvalidSessionID = 600,
		// Token: 0x0400010E RID: 270
		[global::System.Runtime.Serialization.EnumMember]
		Failure,
		// Token: 0x0400010F RID: 271
		[global::System.Runtime.Serialization.EnumMember]
		Timeout
	}
}
