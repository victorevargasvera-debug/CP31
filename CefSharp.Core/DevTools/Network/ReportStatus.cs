using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000213 RID: 531
	public enum ReportStatus
	{
		// Token: 0x04000909 RID: 2313
		[global::System.Runtime.Serialization.EnumMember(Value = "Queued")]
		Queued,
		// Token: 0x0400090A RID: 2314
		[global::System.Runtime.Serialization.EnumMember(Value = "Pending")]
		Pending,
		// Token: 0x0400090B RID: 2315
		[global::System.Runtime.Serialization.EnumMember(Value = "MarkedForRemoval")]
		MarkedForRemoval,
		// Token: 0x0400090C RID: 2316
		[global::System.Runtime.Serialization.EnumMember(Value = "Success")]
		Success
	}
}
