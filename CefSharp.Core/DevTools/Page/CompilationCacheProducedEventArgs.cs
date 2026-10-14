using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001A7 RID: 423
	[global::System.Runtime.Serialization.DataContract]
	public class CompilationCacheProducedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170004DA RID: 1242
		// (get) Token: 0x06000CA5 RID: 3237 RVA: 0x0000E754 File Offset: 0x0000C954
		// (set) Token: 0x06000CA6 RID: 3238 RVA: 0x0000E75C File Offset: 0x0000C95C
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; private set; }

		// Token: 0x170004DB RID: 1243
		// (get) Token: 0x06000CA7 RID: 3239 RVA: 0x0000E765 File Offset: 0x0000C965
		// (set) Token: 0x06000CA8 RID: 3240 RVA: 0x0000E76D File Offset: 0x0000C96D
		[global::System.Runtime.Serialization.DataMember(Name = "data", IsRequired = true)]
		public byte[] Data { get; private set; }
	}
}
