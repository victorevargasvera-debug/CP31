using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000054 RID: 84
	[global::System.Runtime.Serialization.DataContract]
	public enum PCRPasswordPolicy
	{
		// Token: 0x040002DE RID: 734
		[global::System.Runtime.Serialization.EnumMember]
		NA = -1,
		// Token: 0x040002DF RID: 735
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x040002E0 RID: 736
		[global::System.Runtime.Serialization.EnumMember]
		Read,
		// Token: 0x040002E1 RID: 737
		[global::System.Runtime.Serialization.EnumMember]
		ReadWrite
	}
}
