using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x02000288 RID: 648
	public enum VirtualTimePolicy
	{
		// Token: 0x04000A9A RID: 2714
		[global::System.Runtime.Serialization.EnumMember(Value = "advance")]
		Advance,
		// Token: 0x04000A9B RID: 2715
		[global::System.Runtime.Serialization.EnumMember(Value = "pause")]
		Pause,
		// Token: 0x04000A9C RID: 2716
		[global::System.Runtime.Serialization.EnumMember(Value = "pauseIfNetworkFetchesPending")]
		PauseIfNetworkFetchesPending
	}
}
