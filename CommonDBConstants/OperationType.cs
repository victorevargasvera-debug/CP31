using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000047 RID: 71
	[global::System.Runtime.Serialization.DataContract]
	public enum OperationType
	{
		// Token: 0x04000281 RID: 641
		[global::System.Runtime.Serialization.EnumMember]
		Read,
		// Token: 0x04000282 RID: 642
		[global::System.Runtime.Serialization.EnumMember]
		Write,
		// Token: 0x04000283 RID: 643
		[global::System.Runtime.Serialization.EnumMember]
		ReadFile
	}
}
