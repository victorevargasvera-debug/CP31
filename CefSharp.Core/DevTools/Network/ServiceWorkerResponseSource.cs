using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x020001EC RID: 492
	public enum ServiceWorkerResponseSource
	{
		// Token: 0x0400081F RID: 2079
		[global::System.Runtime.Serialization.EnumMember(Value = "cache-storage")]
		CacheStorage,
		// Token: 0x04000820 RID: 2080
		[global::System.Runtime.Serialization.EnumMember(Value = "http-cache")]
		HttpCache,
		// Token: 0x04000821 RID: 2081
		[global::System.Runtime.Serialization.EnumMember(Value = "fallback-code")]
		FallbackCode,
		// Token: 0x04000822 RID: 2082
		[global::System.Runtime.Serialization.EnumMember(Value = "network")]
		Network
	}
}
