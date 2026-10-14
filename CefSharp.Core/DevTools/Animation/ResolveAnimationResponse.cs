using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.Animation
{
	// Token: 0x0200037D RID: 893
	[global::System.Runtime.Serialization.DataContract]
	public class ResolveAnimationResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000A98 RID: 2712
		// (get) Token: 0x06001AEF RID: 6895 RVA: 0x0001C6F0 File Offset: 0x0001A8F0
		// (set) Token: 0x06001AF0 RID: 6896 RVA: 0x0001C6F8 File Offset: 0x0001A8F8
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.RemoteObject remoteObject { get; set; }

		// Token: 0x17000A99 RID: 2713
		// (get) Token: 0x06001AF1 RID: 6897 RVA: 0x0001C701 File Offset: 0x0001A901
		public global::CefSharp.DevTools.Runtime.RemoteObject RemoteObject
		{
			get
			{
				return this.remoteObject;
			}
		}
	}
}
