using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000077 RID: 119
	[global::System.Runtime.Serialization.DataContract]
	public enum HwConfigSectionType : byte
	{
		// Token: 0x04000348 RID: 840
		[global::System.Runtime.Serialization.EnumMember]
		Hardware_ID,
		// Token: 0x04000349 RID: 841
		[global::System.Runtime.Serialization.EnumMember]
		Flash_IC,
		// Token: 0x0400034A RID: 842
		[global::System.Runtime.Serialization.EnumMember]
		LCD,
		// Token: 0x0400034B RID: 843
		[global::System.Runtime.Serialization.EnumMember]
		HW_CONFIG_LINK_TYPE,
		// Token: 0x0400034C RID: 844
		[global::System.Runtime.Serialization.EnumMember]
		BLUETOOTH_CAPABILITY,
		// Token: 0x0400034D RID: 845
		[global::System.Runtime.Serialization.EnumMember]
		GNSS_CAPABILITY
	}
}
