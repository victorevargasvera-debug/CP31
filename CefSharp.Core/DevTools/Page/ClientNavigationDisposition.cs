using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000183 RID: 387
	public enum ClientNavigationDisposition
	{
		// Token: 0x040005F0 RID: 1520
		[global::System.Runtime.Serialization.EnumMember(Value = "currentTab")]
		CurrentTab,
		// Token: 0x040005F1 RID: 1521
		[global::System.Runtime.Serialization.EnumMember(Value = "newTab")]
		NewTab,
		// Token: 0x040005F2 RID: 1522
		[global::System.Runtime.Serialization.EnumMember(Value = "newWindow")]
		NewWindow,
		// Token: 0x040005F3 RID: 1523
		[global::System.Runtime.Serialization.EnumMember(Value = "download")]
		Download
	}
}
