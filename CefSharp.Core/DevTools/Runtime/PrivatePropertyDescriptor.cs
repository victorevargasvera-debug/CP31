using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x02000041 RID: 65
	[global::System.Runtime.Serialization.DataContract]
	public class PrivatePropertyDescriptor : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170000E5 RID: 229
		// (get) Token: 0x060002A4 RID: 676 RVA: 0x000055D9 File Offset: 0x000037D9
		// (set) Token: 0x060002A5 RID: 677 RVA: 0x000055E1 File Offset: 0x000037E1
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170000E6 RID: 230
		// (get) Token: 0x060002A6 RID: 678 RVA: 0x000055EA File Offset: 0x000037EA
		// (set) Token: 0x060002A7 RID: 679 RVA: 0x000055F2 File Offset: 0x000037F2
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Value { get; set; }

		// Token: 0x170000E7 RID: 231
		// (get) Token: 0x060002A8 RID: 680 RVA: 0x000055FB File Offset: 0x000037FB
		// (set) Token: 0x060002A9 RID: 681 RVA: 0x00005603 File Offset: 0x00003803
		[global::System.Runtime.Serialization.DataMember(Name = "get", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Get { get; set; }

		// Token: 0x170000E8 RID: 232
		// (get) Token: 0x060002AA RID: 682 RVA: 0x0000560C File Offset: 0x0000380C
		// (set) Token: 0x060002AB RID: 683 RVA: 0x00005614 File Offset: 0x00003814
		[global::System.Runtime.Serialization.DataMember(Name = "set", IsRequired = false)]
		public global::CefSharp.DevTools.Runtime.RemoteObject Set { get; set; }
	}
}
