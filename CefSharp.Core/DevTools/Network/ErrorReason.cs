using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001DC RID: 476
	public enum ErrorReason
	{
		// Token: 0x04000782 RID: 1922
		[global::System.Runtime.Serialization.EnumMember(Value = "Failed")]
		Failed,
		// Token: 0x04000783 RID: 1923
		[global::System.Runtime.Serialization.EnumMember(Value = "Aborted")]
		Aborted,
		// Token: 0x04000784 RID: 1924
		[global::System.Runtime.Serialization.EnumMember(Value = "TimedOut")]
		TimedOut,
		// Token: 0x04000785 RID: 1925
		[global::System.Runtime.Serialization.EnumMember(Value = "AccessDenied")]
		AccessDenied,
		// Token: 0x04000786 RID: 1926
		[global::System.Runtime.Serialization.EnumMember(Value = "ConnectionClosed")]
		ConnectionClosed,
		// Token: 0x04000787 RID: 1927
		[global::System.Runtime.Serialization.EnumMember(Value = "ConnectionReset")]
		ConnectionReset,
		// Token: 0x04000788 RID: 1928
		[global::System.Runtime.Serialization.EnumMember(Value = "ConnectionRefused")]
		ConnectionRefused,
		// Token: 0x04000789 RID: 1929
		[global::System.Runtime.Serialization.EnumMember(Value = "ConnectionAborted")]
		ConnectionAborted,
		// Token: 0x0400078A RID: 1930
		[global::System.Runtime.Serialization.EnumMember(Value = "ConnectionFailed")]
		ConnectionFailed,
		// Token: 0x0400078B RID: 1931
		[global::System.Runtime.Serialization.EnumMember(Value = "NameNotResolved")]
		NameNotResolved,
		// Token: 0x0400078C RID: 1932
		[global::System.Runtime.Serialization.EnumMember(Value = "InternetDisconnected")]
		InternetDisconnected,
		// Token: 0x0400078D RID: 1933
		[global::System.Runtime.Serialization.EnumMember(Value = "AddressUnreachable")]
		AddressUnreachable,
		// Token: 0x0400078E RID: 1934
		[global::System.Runtime.Serialization.EnumMember(Value = "BlockedByClient")]
		BlockedByClient,
		// Token: 0x0400078F RID: 1935
		[global::System.Runtime.Serialization.EnumMember(Value = "BlockedByResponse")]
		BlockedByResponse
	}
}
