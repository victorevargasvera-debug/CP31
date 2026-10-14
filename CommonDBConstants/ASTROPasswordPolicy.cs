using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200000A RID: 10
	[global::System.Flags]
	[global::System.Runtime.Serialization.DataContract]
	public enum ASTROPasswordPolicy
	{
		// Token: 0x04000023 RID: 35
		[global::System.Runtime.Serialization.EnumMember]
		None = 0,
		// Token: 0x04000024 RID: 36
		[global::System.Runtime.Serialization.EnumMember]
		Read = 1,
		// Token: 0x04000025 RID: 37
		[global::System.Runtime.Serialization.EnumMember]
		Write = 2,
		// Token: 0x04000026 RID: 38
		[global::System.Runtime.Serialization.EnumMember]
		Open = 4
	}
}
