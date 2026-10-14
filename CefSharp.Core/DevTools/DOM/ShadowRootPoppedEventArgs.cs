using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002C8 RID: 712
	[global::System.Runtime.Serialization.DataContract]
	public class ShadowRootPoppedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000888 RID: 2184
		// (get) Token: 0x060015E5 RID: 5605 RVA: 0x00017BC2 File Offset: 0x00015DC2
		// (set) Token: 0x060015E6 RID: 5606 RVA: 0x00017BCA File Offset: 0x00015DCA
		[global::System.Runtime.Serialization.DataMember(Name = "hostId", IsRequired = true)]
		public int HostId { get; private set; }

		// Token: 0x17000889 RID: 2185
		// (get) Token: 0x060015E7 RID: 5607 RVA: 0x00017BD3 File Offset: 0x00015DD3
		// (set) Token: 0x060015E8 RID: 5608 RVA: 0x00017BDB File Offset: 0x00015DDB
		[global::System.Runtime.Serialization.DataMember(Name = "rootId", IsRequired = true)]
		public int RootId { get; private set; }
	}
}
