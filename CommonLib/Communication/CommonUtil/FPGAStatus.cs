using System;
using System.Runtime.Serialization;

namespace Motorola.Common.Communication.CommonUtil
{
	// Token: 0x0200005F RID: 95
	[global::System.Runtime.Serialization.DataContract]
	public enum FPGAStatus : byte
	{
		// Token: 0x04000266 RID: 614
		None,
		// Token: 0x04000267 RID: 615
		[global::System.Runtime.Serialization.EnumMember]
		Empty,
		// Token: 0x04000268 RID: 616
		[global::System.Runtime.Serialization.EnumMember]
		Inactive,
		// Token: 0x04000269 RID: 617
		[global::System.Runtime.Serialization.EnumMember]
		Active
	}
}
