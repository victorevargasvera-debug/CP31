using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Debugger;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000063 RID: 99
	[global::System.Runtime.Serialization.DataContract]
	public class ConsoleProfileStartedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700015C RID: 348
		// (get) Token: 0x060003C6 RID: 966 RVA: 0x000068DA File Offset: 0x00004ADA
		// (set) Token: 0x060003C7 RID: 967 RVA: 0x000068E2 File Offset: 0x00004AE2
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; private set; }

		// Token: 0x1700015D RID: 349
		// (get) Token: 0x060003C8 RID: 968 RVA: 0x000068EB File Offset: 0x00004AEB
		// (set) Token: 0x060003C9 RID: 969 RVA: 0x000068F3 File Offset: 0x00004AF3
		[global::System.Runtime.Serialization.DataMember(Name = "location", IsRequired = true)]
		public global::CefSharp.DevTools.Debugger.Location Location { get; private set; }

		// Token: 0x1700015E RID: 350
		// (get) Token: 0x060003CA RID: 970 RVA: 0x000068FC File Offset: 0x00004AFC
		// (set) Token: 0x060003CB RID: 971 RVA: 0x00006904 File Offset: 0x00004B04
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = false)]
		public string Title { get; private set; }
	}
}
