using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x02000380 RID: 896
	public enum AXValueSourceType
	{
		// Token: 0x04000E70 RID: 3696
		[global::System.Runtime.Serialization.EnumMember(Value = "attribute")]
		Attribute,
		// Token: 0x04000E71 RID: 3697
		[global::System.Runtime.Serialization.EnumMember(Value = "implicit")]
		Implicit,
		// Token: 0x04000E72 RID: 3698
		[global::System.Runtime.Serialization.EnumMember(Value = "style")]
		Style,
		// Token: 0x04000E73 RID: 3699
		[global::System.Runtime.Serialization.EnumMember(Value = "contents")]
		Contents,
		// Token: 0x04000E74 RID: 3700
		[global::System.Runtime.Serialization.EnumMember(Value = "placeholder")]
		Placeholder,
		// Token: 0x04000E75 RID: 3701
		[global::System.Runtime.Serialization.EnumMember(Value = "relatedElement")]
		RelatedElement
	}
}
