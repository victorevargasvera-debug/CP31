using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200007B RID: 123
	[global::System.Runtime.Serialization.DataContract]
	public enum RPDeivceState
	{
		// Token: 0x04000368 RID: 872
		[global::System.Runtime.Serialization.EnumMember]
		NORMAL_NO_RP,
		// Token: 0x04000369 RID: 873
		[global::System.Runtime.Serialization.EnumMember]
		GREEN_NO_UPDATE,
		// Token: 0x0400036A RID: 874
		[global::System.Runtime.Serialization.EnumMember]
		WHITE_CHARGING_BATTERY,
		// Token: 0x0400036B RID: 875
		[global::System.Runtime.Serialization.EnumMember]
		RED_PROGRAMMING_FAILED,
		// Token: 0x0400036C RID: 876
		[global::System.Runtime.Serialization.EnumMember]
		ORANGE_SYNCHRONIZING
	}
}
