using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000089 RID: 137
	[global::System.Runtime.Serialization.DataContract]
	public enum PowerSupplyStatus
	{
		// Token: 0x040003E5 RID: 997
		[global::System.Runtime.Serialization.EnumMember]
		POWERED_BY_BATTERY_AND_NO_CHARGER,
		// Token: 0x040003E6 RID: 998
		[global::System.Runtime.Serialization.EnumMember]
		POWERED_BY_DC_AND_BATTERY_IS_CHARGING,
		// Token: 0x040003E7 RID: 999
		[global::System.Runtime.Serialization.EnumMember]
		POWERED_BY_DC_ONLY_AND_NO_BATTERY,
		// Token: 0x040003E8 RID: 1000
		[global::System.Runtime.Serialization.EnumMember]
		RECOGNIZE_FAILED,
		// Token: 0x040003E9 RID: 1001
		[global::System.Runtime.Serialization.EnumMember]
		UN_DEFINED
	}
}
