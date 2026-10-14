using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200019C RID: 412
	public enum DownloadProgressState
	{
		// Token: 0x040006B4 RID: 1716
		[global::System.Runtime.Serialization.EnumMember(Value = "inProgress")]
		InProgress,
		// Token: 0x040006B5 RID: 1717
		[global::System.Runtime.Serialization.EnumMember(Value = "completed")]
		Completed,
		// Token: 0x040006B6 RID: 1718
		[global::System.Runtime.Serialization.EnumMember(Value = "canceled")]
		Canceled
	}
}
