using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Debugger
{
	// Token: 0x02000090 RID: 144
	[global::System.Runtime.Serialization.DataContract]
	public class SearchInContentResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170001F5 RID: 501
		// (get) Token: 0x0600052D RID: 1325 RVA: 0x00007A60 File Offset: 0x00005C60
		// (set) Token: 0x0600052E RID: 1326 RVA: 0x00007A68 File Offset: 0x00005C68
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.SearchMatch> result { get; set; }

		// Token: 0x170001F6 RID: 502
		// (get) Token: 0x0600052F RID: 1327 RVA: 0x00007A71 File Offset: 0x00005C71
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.SearchMatch> Result
		{
			get
			{
				return this.result;
			}
		}
	}
}
