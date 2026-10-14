using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200002D RID: 45
	[global::System.Runtime.Serialization.DataContract]
	public enum ProgrammingStatus
	{
		// Token: 0x04000118 RID: 280
		[global::System.Runtime.Serialization.EnumMember]
		Connect,
		// Token: 0x04000119 RID: 281
		[global::System.Runtime.Serialization.EnumMember]
		Pending,
		// Token: 0x0400011A RID: 282
		[global::System.Runtime.Serialization.EnumMember]
		Idle,
		// Token: 0x0400011B RID: 283
		[global::System.Runtime.Serialization.EnumMember]
		StartingJob,
		// Token: 0x0400011C RID: 284
		[global::System.Runtime.Serialization.EnumMember]
		JobSuccess,
		// Token: 0x0400011D RID: 285
		[global::System.Runtime.Serialization.EnumMember]
		JobFailure
	}
}
