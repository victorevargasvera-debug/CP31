using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000169 RID: 361
	public enum PermissionsPolicyBlockReason
	{
		// Token: 0x04000562 RID: 1378
		[global::System.Runtime.Serialization.EnumMember(Value = "Header")]
		Header,
		// Token: 0x04000563 RID: 1379
		[global::System.Runtime.Serialization.EnumMember(Value = "IframeAttribute")]
		IframeAttribute,
		// Token: 0x04000564 RID: 1380
		[global::System.Runtime.Serialization.EnumMember(Value = "InFencedFrameTree")]
		InFencedFrameTree,
		// Token: 0x04000565 RID: 1381
		[global::System.Runtime.Serialization.EnumMember(Value = "InIsolatedApp")]
		InIsolatedApp
	}
}
