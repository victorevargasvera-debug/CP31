using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x0200037F RID: 895
	public enum AXValueType
	{
		// Token: 0x04000E5E RID: 3678
		[global::System.Runtime.Serialization.EnumMember(Value = "boolean")]
		Boolean,
		// Token: 0x04000E5F RID: 3679
		[global::System.Runtime.Serialization.EnumMember(Value = "tristate")]
		Tristate,
		// Token: 0x04000E60 RID: 3680
		[global::System.Runtime.Serialization.EnumMember(Value = "booleanOrUndefined")]
		BooleanOrUndefined,
		// Token: 0x04000E61 RID: 3681
		[global::System.Runtime.Serialization.EnumMember(Value = "idref")]
		Idref,
		// Token: 0x04000E62 RID: 3682
		[global::System.Runtime.Serialization.EnumMember(Value = "idrefList")]
		IdrefList,
		// Token: 0x04000E63 RID: 3683
		[global::System.Runtime.Serialization.EnumMember(Value = "integer")]
		Integer,
		// Token: 0x04000E64 RID: 3684
		[global::System.Runtime.Serialization.EnumMember(Value = "node")]
		Node,
		// Token: 0x04000E65 RID: 3685
		[global::System.Runtime.Serialization.EnumMember(Value = "nodeList")]
		NodeList,
		// Token: 0x04000E66 RID: 3686
		[global::System.Runtime.Serialization.EnumMember(Value = "number")]
		Number,
		// Token: 0x04000E67 RID: 3687
		[global::System.Runtime.Serialization.EnumMember(Value = "string")]
		String,
		// Token: 0x04000E68 RID: 3688
		[global::System.Runtime.Serialization.EnumMember(Value = "computedString")]
		ComputedString,
		// Token: 0x04000E69 RID: 3689
		[global::System.Runtime.Serialization.EnumMember(Value = "token")]
		Token,
		// Token: 0x04000E6A RID: 3690
		[global::System.Runtime.Serialization.EnumMember(Value = "tokenList")]
		TokenList,
		// Token: 0x04000E6B RID: 3691
		[global::System.Runtime.Serialization.EnumMember(Value = "domRelation")]
		DomRelation,
		// Token: 0x04000E6C RID: 3692
		[global::System.Runtime.Serialization.EnumMember(Value = "role")]
		Role,
		// Token: 0x04000E6D RID: 3693
		[global::System.Runtime.Serialization.EnumMember(Value = "internalRole")]
		InternalRole,
		// Token: 0x04000E6E RID: 3694
		[global::System.Runtime.Serialization.EnumMember(Value = "valueUndefined")]
		ValueUndefined
	}
}
