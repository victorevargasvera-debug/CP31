using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000066 RID: 102
	[global::System.Runtime.Serialization.DataContract]
	public enum RPLocalType : byte
	{
		// Token: 0x040002AE RID: 686
		[global::System.Runtime.Serialization.EnumMember]
		UNKNOWN,
		// Token: 0x040002AF RID: 687
		[global::System.Runtime.Serialization.EnumMember]
		PASSIVE_PEER = 3
	}
}
