using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Browser
{
	// Token: 0x02000338 RID: 824
	public enum DownloadProgressState
	{
		// Token: 0x04000CF9 RID: 3321
		[global::System.Runtime.Serialization.EnumMember(Value = "inProgress")]
		InProgress,
		// Token: 0x04000CFA RID: 3322
		[global::System.Runtime.Serialization.EnumMember(Value = "completed")]
		Completed,
		// Token: 0x04000CFB RID: 3323
		[global::System.Runtime.Serialization.EnumMember(Value = "canceled")]
		Canceled
	}
}
