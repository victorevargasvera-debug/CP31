using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002F8 RID: 760
	[global::System.Runtime.Serialization.DataContract]
	public class RuleMatch : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008EE RID: 2286
		// (get) Token: 0x06001718 RID: 5912 RVA: 0x000196FB File Offset: 0x000178FB
		// (set) Token: 0x06001719 RID: 5913 RVA: 0x00019703 File Offset: 0x00017903
		[global::System.Runtime.Serialization.DataMember(Name = "rule", IsRequired = true)]
		public global::CefSharp.DevTools.CSS.CSSRule Rule { get; set; }

		// Token: 0x170008EF RID: 2287
		// (get) Token: 0x0600171A RID: 5914 RVA: 0x0001970C File Offset: 0x0001790C
		// (set) Token: 0x0600171B RID: 5915 RVA: 0x00019714 File Offset: 0x00017914
		[global::System.Runtime.Serialization.DataMember(Name = "matchingSelectors", IsRequired = true)]
		public int[] MatchingSelectors { get; set; }
	}
}
