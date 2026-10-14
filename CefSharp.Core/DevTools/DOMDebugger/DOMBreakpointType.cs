using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMDebugger
{
	// Token: 0x020002AC RID: 684
	public enum DOMBreakpointType
	{
		// Token: 0x04000B36 RID: 2870
		[global::System.Runtime.Serialization.EnumMember(Value = "subtree-modified")]
		SubtreeModified,
		// Token: 0x04000B37 RID: 2871
		[global::System.Runtime.Serialization.EnumMember(Value = "attribute-modified")]
		AttributeModified,
		// Token: 0x04000B38 RID: 2872
		[global::System.Runtime.Serialization.EnumMember(Value = "node-removed")]
		NodeRemoved
	}
}
