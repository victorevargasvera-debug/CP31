using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000088 RID: 136
	[global::System.Runtime.Serialization.DataContract]
	public enum FlashOperationType
	{
		// Token: 0x040003E1 RID: 993
		[global::System.Runtime.Serialization.EnumMember]
		BACKUP,
		// Token: 0x040003E2 RID: 994
		[global::System.Runtime.Serialization.EnumMember]
		RESTORE,
		// Token: 0x040003E3 RID: 995
		[global::System.Runtime.Serialization.EnumMember]
		NONE
	}
}
