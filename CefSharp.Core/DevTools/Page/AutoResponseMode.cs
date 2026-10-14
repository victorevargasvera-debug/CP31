using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000188 RID: 392
	public enum AutoResponseMode
	{
		// Token: 0x04000604 RID: 1540
		[global::System.Runtime.Serialization.EnumMember(Value = "none")]
		None,
		// Token: 0x04000605 RID: 1541
		[global::System.Runtime.Serialization.EnumMember(Value = "autoAccept")]
		AutoAccept,
		// Token: 0x04000606 RID: 1542
		[global::System.Runtime.Serialization.EnumMember(Value = "autoReject")]
		AutoReject,
		// Token: 0x04000607 RID: 1543
		[global::System.Runtime.Serialization.EnumMember(Value = "autoOptOut")]
		AutoOptOut
	}
}
