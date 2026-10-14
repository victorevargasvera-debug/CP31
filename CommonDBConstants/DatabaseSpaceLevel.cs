using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000025 RID: 37
	[global::System.Runtime.Serialization.DataContract]
	[global::System.Serializable]
	public enum DatabaseSpaceLevel
	{
		// Token: 0x04000123 RID: 291
		[global::System.Runtime.Serialization.EnumMember]
		DatabaseSpaceNormal,
		// Token: 0x04000124 RID: 292
		[global::System.Runtime.Serialization.EnumMember]
		DatabaseSpaceWarning,
		// Token: 0x04000125 RID: 293
		[global::System.Runtime.Serialization.EnumMember]
		DatabaseSpaceCritical
	}
}
