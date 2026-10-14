using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200007F RID: 127
	[global::System.Runtime.Serialization.DataContract]
	public enum FDT_CMD
	{
		// Token: 0x04000385 RID: 901
		[global::System.Runtime.Serialization.EnumMember]
		Read_FDT,
		// Token: 0x04000386 RID: 902
		[global::System.Runtime.Serialization.EnumMember]
		Write_Updated_State,
		// Token: 0x04000387 RID: 903
		[global::System.Runtime.Serialization.EnumMember]
		Write_Ready_State,
		// Token: 0x04000388 RID: 904
		[global::System.Runtime.Serialization.EnumMember]
		Initialize_FDT
	}
}
