using System;
using System.Runtime.Serialization;

namespace Motorola.CommonCPS.Server.CommonDBConstants
{
	// Token: 0x02000046 RID: 70
	[global::System.Runtime.Serialization.DataContract]
	public enum NatureType
	{
		// Token: 0x0400027A RID: 634
		[global::System.Runtime.Serialization.EnumMember]
		None,
		// Token: 0x0400027B RID: 635
		[global::System.Runtime.Serialization.EnumMember]
		Global,
		// Token: 0x0400027C RID: 636
		[global::System.Runtime.Serialization.EnumMember]
		ForceLoad,
		// Token: 0x0400027D RID: 637
		[global::System.Runtime.Serialization.EnumMember]
		Virtual,
		// Token: 0x0400027E RID: 638
		[global::System.Runtime.Serialization.EnumMember]
		RadioSpecific,
		// Token: 0x0400027F RID: 639
		[global::System.Runtime.Serialization.EnumMember]
		DynamicSet
	}
}
