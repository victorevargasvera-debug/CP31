using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000176 RID: 374
	public enum TransitionType
	{
		// Token: 0x040005A7 RID: 1447
		[global::System.Runtime.Serialization.EnumMember(Value = "link")]
		Link,
		// Token: 0x040005A8 RID: 1448
		[global::System.Runtime.Serialization.EnumMember(Value = "typed")]
		Typed,
		// Token: 0x040005A9 RID: 1449
		[global::System.Runtime.Serialization.EnumMember(Value = "address_bar")]
		AddressBar,
		// Token: 0x040005AA RID: 1450
		[global::System.Runtime.Serialization.EnumMember(Value = "auto_bookmark")]
		AutoBookmark,
		// Token: 0x040005AB RID: 1451
		[global::System.Runtime.Serialization.EnumMember(Value = "auto_subframe")]
		AutoSubframe,
		// Token: 0x040005AC RID: 1452
		[global::System.Runtime.Serialization.EnumMember(Value = "manual_subframe")]
		ManualSubframe,
		// Token: 0x040005AD RID: 1453
		[global::System.Runtime.Serialization.EnumMember(Value = "generated")]
		Generated,
		// Token: 0x040005AE RID: 1454
		[global::System.Runtime.Serialization.EnumMember(Value = "auto_toplevel")]
		AutoToplevel,
		// Token: 0x040005AF RID: 1455
		[global::System.Runtime.Serialization.EnumMember(Value = "form_submit")]
		FormSubmit,
		// Token: 0x040005B0 RID: 1456
		[global::System.Runtime.Serialization.EnumMember(Value = "reload")]
		Reload,
		// Token: 0x040005B1 RID: 1457
		[global::System.Runtime.Serialization.EnumMember(Value = "keyword")]
		Keyword,
		// Token: 0x040005B2 RID: 1458
		[global::System.Runtime.Serialization.EnumMember(Value = "keyword_generated")]
		KeywordGenerated,
		// Token: 0x040005B3 RID: 1459
		[global::System.Runtime.Serialization.EnumMember(Value = "other")]
		Other
	}
}
