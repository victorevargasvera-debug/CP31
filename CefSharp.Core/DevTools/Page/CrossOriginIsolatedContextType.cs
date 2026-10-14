using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000166 RID: 358
	public enum CrossOriginIsolatedContextType
	{
		// Token: 0x04000509 RID: 1289
		[global::System.Runtime.Serialization.EnumMember(Value = "Isolated")]
		Isolated,
		// Token: 0x0400050A RID: 1290
		[global::System.Runtime.Serialization.EnumMember(Value = "NotIsolated")]
		NotIsolated,
		// Token: 0x0400050B RID: 1291
		[global::System.Runtime.Serialization.EnumMember(Value = "NotIsolatedFeatureDisabled")]
		NotIsolatedFeatureDisabled
	}
}
