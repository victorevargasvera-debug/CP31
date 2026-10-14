using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using CefSharp.DevTools.DOM;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002F5 RID: 757
	[global::System.Runtime.Serialization.DataContract]
	public class PseudoElementMatches : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008E7 RID: 2279
		// (get) Token: 0x06001707 RID: 5895 RVA: 0x0001964E File Offset: 0x0001784E
		// (set) Token: 0x06001708 RID: 5896 RVA: 0x0001966A File Offset: 0x0001786A
		public global::CefSharp.DevTools.DOM.PseudoType PseudoType
		{
			get
			{
				return (global::CefSharp.DevTools.DOM.PseudoType)global::CefSharp.DevTools.DevToolsDomainEntityBase.StringToEnum(typeof(global::CefSharp.DevTools.DOM.PseudoType), this.pseudoType);
			}
			set
			{
				this.pseudoType = global::CefSharp.DevTools.DevToolsDomainEntityBase.EnumToString(value);
			}
		}

		// Token: 0x170008E8 RID: 2280
		// (get) Token: 0x06001709 RID: 5897 RVA: 0x0001967D File Offset: 0x0001787D
		// (set) Token: 0x0600170A RID: 5898 RVA: 0x00019685 File Offset: 0x00017885
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoType", IsRequired = true)]
		internal string pseudoType { get; set; }

		// Token: 0x170008E9 RID: 2281
		// (get) Token: 0x0600170B RID: 5899 RVA: 0x0001968E File Offset: 0x0001788E
		// (set) Token: 0x0600170C RID: 5900 RVA: 0x00019696 File Offset: 0x00017896
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoIdentifier", IsRequired = false)]
		public string PseudoIdentifier { get; set; }

		// Token: 0x170008EA RID: 2282
		// (get) Token: 0x0600170D RID: 5901 RVA: 0x0001969F File Offset: 0x0001789F
		// (set) Token: 0x0600170E RID: 5902 RVA: 0x000196A7 File Offset: 0x000178A7
		[global::System.Runtime.Serialization.DataMember(Name = "matches", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.RuleMatch> Matches { get; set; }
	}
}
