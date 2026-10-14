using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Overlay
{
	// Token: 0x020001D3 RID: 467
	public enum InspectMode
	{
		// Token: 0x04000762 RID: 1890
		[global::System.Runtime.Serialization.EnumMember(Value = "searchForNode")]
		SearchForNode,
		// Token: 0x04000763 RID: 1891
		[global::System.Runtime.Serialization.EnumMember(Value = "searchForUAShadowDOM")]
		SearchForUAShadowDOM,
		// Token: 0x04000764 RID: 1892
		[global::System.Runtime.Serialization.EnumMember(Value = "captureAreaScreenshot")]
		CaptureAreaScreenshot,
		// Token: 0x04000765 RID: 1893
		[global::System.Runtime.Serialization.EnumMember(Value = "showDistances")]
		ShowDistances,
		// Token: 0x04000766 RID: 1894
		[global::System.Runtime.Serialization.EnumMember(Value = "none")]
		None
	}
}
