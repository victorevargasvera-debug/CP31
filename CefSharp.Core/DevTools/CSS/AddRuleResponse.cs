using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000318 RID: 792
	[global::System.Runtime.Serialization.DataContract]
	public class AddRuleResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000976 RID: 2422
		// (get) Token: 0x06001847 RID: 6215 RVA: 0x0001A1CD File Offset: 0x000183CD
		// (set) Token: 0x06001848 RID: 6216 RVA: 0x0001A1D5 File Offset: 0x000183D5
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.CSSRule rule { get; set; }

		// Token: 0x17000977 RID: 2423
		// (get) Token: 0x06001849 RID: 6217 RVA: 0x0001A1DE File Offset: 0x000183DE
		public global::CefSharp.DevTools.CSS.CSSRule Rule
		{
			get
			{
				return this.rule;
			}
		}
	}
}
