using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200021F RID: 543
	[global::System.Runtime.Serialization.DataContract]
	public class ResourceChangedPriorityEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000693 RID: 1683
		// (get) Token: 0x060010C4 RID: 4292 RVA: 0x000123A5 File Offset: 0x000105A5
		// (set) Token: 0x060010C5 RID: 4293 RVA: 0x000123AD File Offset: 0x000105AD
		[global::System.Runtime.Serialization.DataMember(Name = "requestId", IsRequired = true)]
		public string RequestId { get; private set; }

		// Token: 0x17000694 RID: 1684
		// (get) Token: 0x060010C6 RID: 4294 RVA: 0x000123B6 File Offset: 0x000105B6
		// (set) Token: 0x060010C7 RID: 4295 RVA: 0x000123D2 File Offset: 0x000105D2
		public global::CefSharp.DevTools.Network.ResourcePriority NewPriority
		{
			get
			{
				return (global::CefSharp.DevTools.Network.ResourcePriority)global::CefSharp.DevTools.DevToolsDomainEventArgsBase.StringToEnum(typeof(global::CefSharp.DevTools.Network.ResourcePriority), this.newPriority);
			}
			set
			{
				this.newPriority = global::CefSharp.DevTools.DevToolsDomainEventArgsBase.EnumToString(value);
			}
		}

		// Token: 0x17000695 RID: 1685
		// (get) Token: 0x060010C8 RID: 4296 RVA: 0x000123E5 File Offset: 0x000105E5
		// (set) Token: 0x060010C9 RID: 4297 RVA: 0x000123ED File Offset: 0x000105ED
		[global::System.Runtime.Serialization.DataMember(Name = "newPriority", IsRequired = true)]
		internal string newPriority { get; private set; }

		// Token: 0x17000696 RID: 1686
		// (get) Token: 0x060010CA RID: 4298 RVA: 0x000123F6 File Offset: 0x000105F6
		// (set) Token: 0x060010CB RID: 4299 RVA: 0x000123FE File Offset: 0x000105FE
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }
	}
}
