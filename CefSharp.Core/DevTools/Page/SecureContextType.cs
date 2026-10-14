using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000165 RID: 357
	public enum SecureContextType
	{
		// Token: 0x04000504 RID: 1284
		[global::System.Runtime.Serialization.EnumMember(Value = "Secure")]
		Secure,
		// Token: 0x04000505 RID: 1285
		[global::System.Runtime.Serialization.EnumMember(Value = "SecureLocalhost")]
		SecureLocalhost,
		// Token: 0x04000506 RID: 1286
		[global::System.Runtime.Serialization.EnumMember(Value = "InsecureScheme")]
		InsecureScheme,
		// Token: 0x04000507 RID: 1287
		[global::System.Runtime.Serialization.EnumMember(Value = "InsecureAncestor")]
		InsecureAncestor
	}
}
