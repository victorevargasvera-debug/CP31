using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200032C RID: 812
	[global::System.Runtime.Serialization.DataContract]
	public class StopRuleUsageTrackingResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009B4 RID: 2484
		// (get) Token: 0x060018B8 RID: 6328 RVA: 0x0001A574 File Offset: 0x00018774
		// (set) Token: 0x060018B9 RID: 6329 RVA: 0x0001A57C File Offset: 0x0001877C
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.RuleUsage> ruleUsage { get; set; }

		// Token: 0x170009B5 RID: 2485
		// (get) Token: 0x060018BA RID: 6330 RVA: 0x0001A585 File Offset: 0x00018785
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.RuleUsage> RuleUsage
		{
			get
			{
				return this.ruleUsage;
			}
		}
	}
}
