using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200000B RID: 11
	[global::System.Runtime.Serialization.DataContract]
	public enum AstroSystemARSMode
	{
		// Token: 0x04000028 RID: 40
		[global::System.Runtime.Serialization.EnumMember]
		DISABLED,
		// Token: 0x04000029 RID: 41
		[global::System.Runtime.Serialization.EnumMember]
		SERVER,
		// Token: 0x0400002A RID: 42
		[global::System.Runtime.Serialization.EnumMember]
		NONSERVER,
		// Token: 0x0400002B RID: 43
		[global::System.Runtime.Serialization.EnumMember]
		ENHANCEDSERVER = 5
	}
}
