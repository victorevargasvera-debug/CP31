using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002F6 RID: 758
	[global::System.Runtime.Serialization.DataContract]
	public class InheritedStyleEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008EB RID: 2283
		// (get) Token: 0x06001710 RID: 5904 RVA: 0x000196B8 File Offset: 0x000178B8
		// (set) Token: 0x06001711 RID: 5905 RVA: 0x000196C0 File Offset: 0x000178C0
		[global::System.Runtime.Serialization.DataMember(Name = "inlineStyle", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.CSSStyle InlineStyle { get; set; }

		// Token: 0x170008EC RID: 2284
		// (get) Token: 0x06001712 RID: 5906 RVA: 0x000196C9 File Offset: 0x000178C9
		// (set) Token: 0x06001713 RID: 5907 RVA: 0x000196D1 File Offset: 0x000178D1
		[global::System.Runtime.Serialization.DataMember(Name = "matchedCSSRules", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.RuleMatch> MatchedCSSRules { get; set; }
	}
}
