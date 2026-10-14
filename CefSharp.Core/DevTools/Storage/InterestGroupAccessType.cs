using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x02000123 RID: 291
	public enum InterestGroupAccessType
	{
		// Token: 0x04000412 RID: 1042
		[global::System.Runtime.Serialization.EnumMember(Value = "join")]
		Join,
		// Token: 0x04000413 RID: 1043
		[global::System.Runtime.Serialization.EnumMember(Value = "leave")]
		Leave,
		// Token: 0x04000414 RID: 1044
		[global::System.Runtime.Serialization.EnumMember(Value = "update")]
		Update,
		// Token: 0x04000415 RID: 1045
		[global::System.Runtime.Serialization.EnumMember(Value = "loaded")]
		Loaded,
		// Token: 0x04000416 RID: 1046
		[global::System.Runtime.Serialization.EnumMember(Value = "bid")]
		Bid,
		// Token: 0x04000417 RID: 1047
		[global::System.Runtime.Serialization.EnumMember(Value = "win")]
		Win
	}
}
