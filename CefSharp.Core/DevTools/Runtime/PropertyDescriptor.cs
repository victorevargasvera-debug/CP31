using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200003F RID: 63
	[global::System.Runtime.Serialization.DataContract]
	public class PropertyDescriptor : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000D9 RID: 217
		// (get) Token: 0x0600028A RID: 650 RVA: 0x000054FD File Offset: 0x000036FD
		// (set) Token: 0x0600028B RID: 651 RVA: 0x00005505 File Offset: 0x00003705
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170000DA RID: 218
		// (get) Token: 0x0600028C RID: 652 RVA: 0x0000550E File Offset: 0x0000370E
		// (set) Token: 0x0600028D RID: 653 RVA: 0x00005516 File Offset: 0x00003716
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Value { get; set; }

		// Token: 0x170000DB RID: 219
		// (get) Token: 0x0600028E RID: 654 RVA: 0x0000551F File Offset: 0x0000371F
		// (set) Token: 0x0600028F RID: 655 RVA: 0x00005527 File Offset: 0x00003727
		[global::System.Runtime.Serialization.DataMember(Name = "writable", IsRequired = false)]
		public bool? Writable { get; set; }

		// Token: 0x170000DC RID: 220
		// (get) Token: 0x06000290 RID: 656 RVA: 0x00005530 File Offset: 0x00003730
		// (set) Token: 0x06000291 RID: 657 RVA: 0x00005538 File Offset: 0x00003738
		[global::System.Runtime.Serialization.DataMember(Name = "get", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Get { get; set; }

		// Token: 0x170000DD RID: 221
		// (get) Token: 0x06000292 RID: 658 RVA: 0x00005541 File Offset: 0x00003741
		// (set) Token: 0x06000293 RID: 659 RVA: 0x00005549 File Offset: 0x00003749
		[global::System.Runtime.Serialization.DataMember(Name = "set", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Set { get; set; }

		// Token: 0x170000DE RID: 222
		// (get) Token: 0x06000294 RID: 660 RVA: 0x00005552 File Offset: 0x00003752
		// (set) Token: 0x06000295 RID: 661 RVA: 0x0000555A File Offset: 0x0000375A
		[global::System.Runtime.Serialization.DataMember(Name = "configurable", IsRequired = true)]
		public bool Configurable { get; set; }

		// Token: 0x170000DF RID: 223
		// (get) Token: 0x06000296 RID: 662 RVA: 0x00005563 File Offset: 0x00003763
		// (set) Token: 0x06000297 RID: 663 RVA: 0x0000556B File Offset: 0x0000376B
		[global::System.Runtime.Serialization.DataMember(Name = "enumerable", IsRequired = true)]
		public bool Enumerable { get; set; }

		// Token: 0x170000E0 RID: 224
		// (get) Token: 0x06000298 RID: 664 RVA: 0x00005574 File Offset: 0x00003774
		// (set) Token: 0x06000299 RID: 665 RVA: 0x0000557C File Offset: 0x0000377C
		[global::System.Runtime.Serialization.DataMember(Name = "wasThrown", IsRequired = false)]
		public bool? WasThrown { get; set; }

		// Token: 0x170000E1 RID: 225
		// (get) Token: 0x0600029A RID: 666 RVA: 0x00005585 File Offset: 0x00003785
		// (set) Token: 0x0600029B RID: 667 RVA: 0x0000558D File Offset: 0x0000378D
		[global::System.Runtime.Serialization.DataMember(Name = "isOwn", IsRequired = false)]
		public bool? IsOwn { get; set; }

		// Token: 0x170000E2 RID: 226
		// (get) Token: 0x0600029C RID: 668 RVA: 0x00005596 File Offset: 0x00003796
		// (set) Token: 0x0600029D RID: 669 RVA: 0x0000559E File Offset: 0x0000379E
		[global::System.Runtime.Serialization.DataMember(Name = "symbol", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Symbol { get; set; }
	}
}
