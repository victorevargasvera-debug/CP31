using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x0200006D RID: 109
	[global::System.Runtime.Serialization.DataContract]
	public enum SecureOperation
	{
		// Token: 0x0400042A RID: 1066
		[global::System.Runtime.Serialization.EnumMember]
		DISABLED,
		// Token: 0x0400042B RID: 1067
		[global::System.Runtime.Serialization.EnumMember]
		HARDWARE,
		// Token: 0x0400042C RID: 1068
		[global::System.Runtime.Serialization.EnumMember]
		SOFTWARE = 3
	}
}
