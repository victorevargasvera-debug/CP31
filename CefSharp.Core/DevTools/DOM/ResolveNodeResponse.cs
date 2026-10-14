using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002DE RID: 734
	[global::System.Runtime.Serialization.DataContract]
	public class ResolveNodeResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008BA RID: 2234
		// (get) Token: 0x06001648 RID: 5704 RVA: 0x00017EF5 File Offset: 0x000160F5
		// (set) Token: 0x06001649 RID: 5705 RVA: 0x00017EFD File Offset: 0x000160FD
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.RemoteObject @object { get; set; }

		// Token: 0x170008BB RID: 2235
		// (get) Token: 0x0600164A RID: 5706 RVA: 0x00017F06 File Offset: 0x00016106
		public global::CefSharp.DevTools.Runtime.RemoteObject Object
		{
			get
			{
				return this.@object;
			}
		}
	}
}
