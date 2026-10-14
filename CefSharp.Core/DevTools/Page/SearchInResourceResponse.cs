using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Debugger;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B7 RID: 439
	[global::System.Runtime.Serialization.DataContract]
	public class SearchInResourceResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000516 RID: 1302
		// (get) Token: 0x06000D10 RID: 3344 RVA: 0x0000EAD7 File Offset: 0x0000CCD7
		// (set) Token: 0x06000D11 RID: 3345 RVA: 0x0000EADF File Offset: 0x0000CCDF
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.SearchMatch> result { get; set; }

		// Token: 0x17000517 RID: 1303
		// (get) Token: 0x06000D12 RID: 3346 RVA: 0x0000EAE8 File Offset: 0x0000CCE8
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.SearchMatch> Result
		{
			get
			{
				return this.result;
			}
		}
	}
}
