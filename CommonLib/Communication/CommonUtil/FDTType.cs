using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x02000079 RID: 121
	[global::System.Runtime.Serialization.DataContract]
	public enum FDTType
	{
		// Token: 0x04000359 RID: 857
		[global::System.Runtime.Serialization.EnumMember]
		FDT_FDT,
		// Token: 0x0400035A RID: 858
		[global::System.Runtime.Serialization.EnumMember]
		FDT_FLASHSTRAP,
		// Token: 0x0400035B RID: 859
		[global::System.Runtime.Serialization.EnumMember]
		FDT_FIRMWARE,
		// Token: 0x0400035C RID: 860
		[global::System.Runtime.Serialization.EnumMember]
		FDT_KEY,
		// Token: 0x0400035D RID: 861
		[global::System.Runtime.Serialization.EnumMember]
		FDT_CODEPLUG,
		// Token: 0x0400035E RID: 862
		[global::System.Runtime.Serialization.EnumMember]
		FDT_FLASHPACKS,
		// Token: 0x0400035F RID: 863
		[global::System.Runtime.Serialization.EnumMember]
		FDT_LOGGING_DATA,
		// Token: 0x04000360 RID: 864
		[global::System.Runtime.Serialization.EnumMember]
		FDT_RELEASE_INFO,
		// Token: 0x04000361 RID: 865
		[global::System.Runtime.Serialization.EnumMember]
		FDT_BAD_RECORD,
		// Token: 0x04000362 RID: 866
		[global::System.Runtime.Serialization.EnumMember]
		FDT_DUMMY
	}
}
