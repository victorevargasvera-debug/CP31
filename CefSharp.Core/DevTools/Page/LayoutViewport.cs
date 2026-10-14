using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200017C RID: 380
	[global::System.Runtime.Serialization.DataContract]
	public class LayoutViewport : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700046F RID: 1135
		// (get) Token: 0x06000BAE RID: 2990 RVA: 0x0000DDF6 File Offset: 0x0000BFF6
		// (set) Token: 0x06000BAF RID: 2991 RVA: 0x0000DDFE File Offset: 0x0000BFFE
		[global::System.Runtime.Serialization.DataMember(Name = "pageX", IsRequired = true)]
		public int PageX { get; set; }

		// Token: 0x17000470 RID: 1136
		// (get) Token: 0x06000BB0 RID: 2992 RVA: 0x0000DE07 File Offset: 0x0000C007
		// (set) Token: 0x06000BB1 RID: 2993 RVA: 0x0000DE0F File Offset: 0x0000C00F
		[global::System.Runtime.Serialization.DataMember(Name = "pageY", IsRequired = true)]
		public int PageY { get; set; }

		// Token: 0x17000471 RID: 1137
		// (get) Token: 0x06000BB2 RID: 2994 RVA: 0x0000DE18 File Offset: 0x0000C018
		// (set) Token: 0x06000BB3 RID: 2995 RVA: 0x0000DE20 File Offset: 0x0000C020
		[global::System.Runtime.Serialization.DataMember(Name = "clientWidth", IsRequired = true)]
		public int ClientWidth { get; set; }

		// Token: 0x17000472 RID: 1138
		// (get) Token: 0x06000BB4 RID: 2996 RVA: 0x0000DE29 File Offset: 0x0000C029
		// (set) Token: 0x06000BB5 RID: 2997 RVA: 0x0000DE31 File Offset: 0x0000C031
		[global::System.Runtime.Serialization.DataMember(Name = "clientHeight", IsRequired = true)]
		public int ClientHeight { get; set; }
	}
}
