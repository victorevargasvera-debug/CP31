using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMDebugger
{
	// Token: 0x020002AD RID: 685
	public enum CSPViolationType
	{
		// Token: 0x04000B3A RID: 2874
		[global::System.Runtime.Serialization.EnumMember(Value = "trustedtype-sink-violation")]
		TrustedtypeSinkViolation,
		// Token: 0x04000B3B RID: 2875
		[global::System.Runtime.Serialization.EnumMember(Value = "trustedtype-policy-violation")]
		TrustedtypePolicyViolation
	}
}
