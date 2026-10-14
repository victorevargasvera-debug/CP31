using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.ServiceWorker
{
	// Token: 0x02000142 RID: 322
	public enum ServiceWorkerVersionStatus
	{
		// Token: 0x0400047E RID: 1150
		[global::System.Runtime.Serialization.EnumMember(Value = "new")]
		New,
		// Token: 0x0400047F RID: 1151
		[global::System.Runtime.Serialization.EnumMember(Value = "installing")]
		Installing,
		// Token: 0x04000480 RID: 1152
		[global::System.Runtime.Serialization.EnumMember(Value = "installed")]
		Installed,
		// Token: 0x04000481 RID: 1153
		[global::System.Runtime.Serialization.EnumMember(Value = "activating")]
		Activating,
		// Token: 0x04000482 RID: 1154
		[global::System.Runtime.Serialization.EnumMember(Value = "activated")]
		Activated,
		// Token: 0x04000483 RID: 1155
		[global::System.Runtime.Serialization.EnumMember(Value = "redundant")]
		Redundant
	}
}
