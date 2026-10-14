using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D3 RID: 723
	[global::System.Runtime.Serialization.DataContract]
	public class GetOuterHTMLResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170008A2 RID: 2210
		// (get) Token: 0x06001619 RID: 5657 RVA: 0x00017D71 File Offset: 0x00015F71
		// (set) Token: 0x0600161A RID: 5658 RVA: 0x00017D79 File Offset: 0x00015F79
		[global::System.Runtime.Serialization.DataMember]
		internal string outerHTML { get; set; }

		// Token: 0x170008A3 RID: 2211
		// (get) Token: 0x0600161B RID: 5659 RVA: 0x00017D82 File Offset: 0x00015F82
		public string OuterHTML
		{
			get
			{
				return this.outerHTML;
			}
		}
	}
}
