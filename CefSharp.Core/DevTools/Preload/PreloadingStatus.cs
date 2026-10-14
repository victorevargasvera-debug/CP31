using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000A7 RID: 167
	public enum PreloadingStatus
	{
		// Token: 0x040002A3 RID: 675
		[global::System.Runtime.Serialization.EnumMember(Value = "Pending")]
		Pending,
		// Token: 0x040002A4 RID: 676
		[global::System.Runtime.Serialization.EnumMember(Value = "Running")]
		Running,
		// Token: 0x040002A5 RID: 677
		[global::System.Runtime.Serialization.EnumMember(Value = "Ready")]
		Ready,
		// Token: 0x040002A6 RID: 678
		[global::System.Runtime.Serialization.EnumMember(Value = "Success")]
		Success,
		// Token: 0x040002A7 RID: 679
		[global::System.Runtime.Serialization.EnumMember(Value = "Failure")]
		Failure,
		// Token: 0x040002A8 RID: 680
		[global::System.Runtime.Serialization.EnumMember(Value = "NotSupported")]
		NotSupported
	}
}
