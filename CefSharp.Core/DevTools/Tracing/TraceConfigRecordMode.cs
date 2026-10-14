using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Tracing
{
	// Token: 0x020000EF RID: 239
	public enum TraceConfigRecordMode
	{
		// Token: 0x0400037C RID: 892
		[global::System.Runtime.Serialization.EnumMember(Value = "recordUntilFull")]
		RecordUntilFull,
		// Token: 0x0400037D RID: 893
		[global::System.Runtime.Serialization.EnumMember(Value = "recordContinuously")]
		RecordContinuously,
		// Token: 0x0400037E RID: 894
		[global::System.Runtime.Serialization.EnumMember(Value = "recordAsMuchAsPossible")]
		RecordAsMuchAsPossible,
		// Token: 0x0400037F RID: 895
		[global::System.Runtime.Serialization.EnumMember(Value = "echoToConsole")]
		EchoToConsole
	}
}
