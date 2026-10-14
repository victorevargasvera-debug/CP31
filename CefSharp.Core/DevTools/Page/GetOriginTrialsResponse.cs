using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B9 RID: 441
	[global::System.Runtime.Serialization.DataContract]
	public class GetOriginTrialsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700051A RID: 1306
		// (get) Token: 0x06000D18 RID: 3352 RVA: 0x0000EB19 File Offset: 0x0000CD19
		// (set) Token: 0x06000D19 RID: 3353 RVA: 0x0000EB21 File Offset: 0x0000CD21
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.OriginTrial> originTrials { get; set; }

		// Token: 0x1700051B RID: 1307
		// (get) Token: 0x06000D1A RID: 3354 RVA: 0x0000EB2A File Offset: 0x0000CD2A
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.OriginTrial> OriginTrials
		{
			get
			{
				return this.originTrials;
			}
		}
	}
}
