using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.Debugger;

namespace CefSharp.DevTools.Network
{
	// Token: 0x0200023D RID: 573
	[global::System.Runtime.Serialization.DataContract]
	public class SearchInResponseBodyResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170006F4 RID: 1780
		// (get) Token: 0x0600119B RID: 4507 RVA: 0x00012B4C File Offset: 0x00010D4C
		// (set) Token: 0x0600119C RID: 4508 RVA: 0x00012B54 File Offset: 0x00010D54
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.SearchMatch> result { get; set; }

		// Token: 0x170006F5 RID: 1781
		// (get) Token: 0x0600119D RID: 4509 RVA: 0x00012B5D File Offset: 0x00010D5D
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Debugger.SearchMatch> Result
		{
			get
			{
				return this.result;
			}
		}
	}
}
