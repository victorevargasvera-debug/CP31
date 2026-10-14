using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000357 RID: 855
	public enum ContentSecurityPolicyViolationType
	{
		// Token: 0x04000D86 RID: 3462
		[global::System.Runtime.Serialization.EnumMember(Value = "kInlineViolation")]
		KInlineViolation,
		// Token: 0x04000D87 RID: 3463
		[global::System.Runtime.Serialization.EnumMember(Value = "kEvalViolation")]
		KEvalViolation,
		// Token: 0x04000D88 RID: 3464
		[global::System.Runtime.Serialization.EnumMember(Value = "kURLViolation")]
		KURLViolation,
		// Token: 0x04000D89 RID: 3465
		[global::System.Runtime.Serialization.EnumMember(Value = "kTrustedTypesSinkViolation")]
		KTrustedTypesSinkViolation,
		// Token: 0x04000D8A RID: 3466
		[global::System.Runtime.Serialization.EnumMember(Value = "kTrustedTypesPolicyViolation")]
		KTrustedTypesPolicyViolation,
		// Token: 0x04000D8B RID: 3467
		[global::System.Runtime.Serialization.EnumMember(Value = "kWasmEvalViolation")]
		KWasmEvalViolation
	}
}
