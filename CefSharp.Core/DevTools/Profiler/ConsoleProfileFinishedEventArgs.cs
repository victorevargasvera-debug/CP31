using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Debugger;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000062 RID: 98
	[global::System.Runtime.Serialization.DataContract]
	public class ConsoleProfileFinishedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000158 RID: 344
		// (get) Token: 0x060003BD RID: 957 RVA: 0x0000688E File Offset: 0x00004A8E
		// (set) Token: 0x060003BE RID: 958 RVA: 0x00006896 File Offset: 0x00004A96
		[global::System.Runtime.Serialization.DataMember(Name = "id", IsRequired = true)]
		public string Id { get; private set; }

		// Token: 0x17000159 RID: 345
		// (get) Token: 0x060003BF RID: 959 RVA: 0x0000689F File Offset: 0x00004A9F
		// (set) Token: 0x060003C0 RID: 960 RVA: 0x000068A7 File Offset: 0x00004AA7
		[global::System.Runtime.Serialization.DataMember(Name = "location", IsRequired = true)]
		public global::CefSharp.DevTools.Debugger.Location Location { get; private set; }

		// Token: 0x1700015A RID: 346
		// (get) Token: 0x060003C1 RID: 961 RVA: 0x000068B0 File Offset: 0x00004AB0
		// (set) Token: 0x060003C2 RID: 962 RVA: 0x000068B8 File Offset: 0x00004AB8
		[global::System.Runtime.Serialization.DataMember(Name = "profile", IsRequired = true)]
		public global::CefSharp.DevTools.Profiler.Profile Profile { get; private set; }

		// Token: 0x1700015B RID: 347
		// (get) Token: 0x060003C3 RID: 963 RVA: 0x000068C1 File Offset: 0x00004AC1
		// (set) Token: 0x060003C4 RID: 964 RVA: 0x000068C9 File Offset: 0x00004AC9
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = false)]
		public string Title { get; private set; }
	}
}
