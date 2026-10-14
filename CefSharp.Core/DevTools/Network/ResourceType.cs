using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001DB RID: 475
	public enum ResourceType
	{
		// Token: 0x0400076F RID: 1903
		[global::System.Runtime.Serialization.EnumMember(Value = "Document")]
		Document,
		// Token: 0x04000770 RID: 1904
		[global::System.Runtime.Serialization.EnumMember(Value = "Stylesheet")]
		Stylesheet,
		// Token: 0x04000771 RID: 1905
		[global::System.Runtime.Serialization.EnumMember(Value = "Image")]
		Image,
		// Token: 0x04000772 RID: 1906
		[global::System.Runtime.Serialization.EnumMember(Value = "Media")]
		Media,
		// Token: 0x04000773 RID: 1907
		[global::System.Runtime.Serialization.EnumMember(Value = "Font")]
		Font,
		// Token: 0x04000774 RID: 1908
		[global::System.Runtime.Serialization.EnumMember(Value = "Script")]
		Script,
		// Token: 0x04000775 RID: 1909
		[global::System.Runtime.Serialization.EnumMember(Value = "TextTrack")]
		TextTrack,
		// Token: 0x04000776 RID: 1910
		[global::System.Runtime.Serialization.EnumMember(Value = "XHR")]
		XHR,
		// Token: 0x04000777 RID: 1911
		[global::System.Runtime.Serialization.EnumMember(Value = "Fetch")]
		Fetch,
		// Token: 0x04000778 RID: 1912
		[global::System.Runtime.Serialization.EnumMember(Value = "Prefetch")]
		Prefetch,
		// Token: 0x04000779 RID: 1913
		[global::System.Runtime.Serialization.EnumMember(Value = "EventSource")]
		EventSource,
		// Token: 0x0400077A RID: 1914
		[global::System.Runtime.Serialization.EnumMember(Value = "WebSocket")]
		WebSocket,
		// Token: 0x0400077B RID: 1915
		[global::System.Runtime.Serialization.EnumMember(Value = "Manifest")]
		Manifest,
		// Token: 0x0400077C RID: 1916
		[global::System.Runtime.Serialization.EnumMember(Value = "SignedExchange")]
		SignedExchange,
		// Token: 0x0400077D RID: 1917
		[global::System.Runtime.Serialization.EnumMember(Value = "Ping")]
		Ping,
		// Token: 0x0400077E RID: 1918
		[global::System.Runtime.Serialization.EnumMember(Value = "CSPViolationReport")]
		CSPViolationReport,
		// Token: 0x0400077F RID: 1919
		[global::System.Runtime.Serialization.EnumMember(Value = "Preflight")]
		Preflight,
		// Token: 0x04000780 RID: 1920
		[global::System.Runtime.Serialization.EnumMember(Value = "Other")]
		Other
	}
}
