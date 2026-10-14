using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000023 RID: 35
	[global::System.Runtime.Serialization.DataContract]
	public enum OTAPConnectionType
	{
		// Token: 0x040000C6 RID: 198
		[global::System.Runtime.Serialization.EnumMember]
		LMR,
		// Token: 0x040000C7 RID: 199
		[global::System.Runtime.Serialization.EnumMember]
		LTE,
		// Token: 0x040000C8 RID: 200
		[global::System.Runtime.Serialization.EnumMember]
		NONE
	}
}
