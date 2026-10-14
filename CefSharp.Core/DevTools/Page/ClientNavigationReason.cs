using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000182 RID: 386
	public enum ClientNavigationReason
	{
		// Token: 0x040005E7 RID: 1511
		[global::System.Runtime.Serialization.EnumMember(Value = "formSubmissionGet")]
		FormSubmissionGet,
		// Token: 0x040005E8 RID: 1512
		[global::System.Runtime.Serialization.EnumMember(Value = "formSubmissionPost")]
		FormSubmissionPost,
		// Token: 0x040005E9 RID: 1513
		[global::System.Runtime.Serialization.EnumMember(Value = "httpHeaderRefresh")]
		HttpHeaderRefresh,
		// Token: 0x040005EA RID: 1514
		[global::System.Runtime.Serialization.EnumMember(Value = "scriptInitiated")]
		ScriptInitiated,
		// Token: 0x040005EB RID: 1515
		[global::System.Runtime.Serialization.EnumMember(Value = "metaTagRefresh")]
		MetaTagRefresh,
		// Token: 0x040005EC RID: 1516
		[global::System.Runtime.Serialization.EnumMember(Value = "pageBlockInterstitial")]
		PageBlockInterstitial,
		// Token: 0x040005ED RID: 1517
		[global::System.Runtime.Serialization.EnumMember(Value = "reload")]
		Reload,
		// Token: 0x040005EE RID: 1518
		[global::System.Runtime.Serialization.EnumMember(Value = "anchorClick")]
		AnchorClick
	}
}
