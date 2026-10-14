using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000078 RID: 120
	[global::System.Runtime.Serialization.DataContract]
	public enum DeviceMode
	{
		// Token: 0x0400034F RID: 847
		[global::System.Runtime.Serialization.EnumMember]
		UNKNOWN = 7,
		// Token: 0x04000350 RID: 848
		[global::System.Runtime.Serialization.EnumMember]
		NORMAL = 0,
		// Token: 0x04000351 RID: 849
		[global::System.Runtime.Serialization.EnumMember]
		CHARGING,
		// Token: 0x04000352 RID: 850
		[global::System.Runtime.Serialization.EnumMember]
		KERNEL,
		// Token: 0x04000353 RID: 851
		[global::System.Runtime.Serialization.EnumMember]
		FLASHSTRAP = 8,
		// Token: 0x04000354 RID: 852
		[global::System.Runtime.Serialization.EnumMember]
		RP = 3,
		// Token: 0x04000355 RID: 853
		[global::System.Runtime.Serialization.EnumMember]
		FRODO_DATABOX = 9,
		// Token: 0x04000356 RID: 854
		[global::System.Runtime.Serialization.EnumMember]
		MASS_STORAGE,
		// Token: 0x04000357 RID: 855
		[global::System.Runtime.Serialization.EnumMember]
		DEVICE_OFF
	}
}
