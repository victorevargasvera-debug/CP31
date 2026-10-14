using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002F7 RID: 759
	[global::System.Runtime.Serialization.DataContract]
	public class InheritedPseudoElementMatches : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170008ED RID: 2285
		// (get) Token: 0x06001715 RID: 5909 RVA: 0x000196E2 File Offset: 0x000178E2
		// (set) Token: 0x06001716 RID: 5910 RVA: 0x000196EA File Offset: 0x000178EA
		[global::System.Runtime.Serialization.DataMember(Name = "pseudoElements", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.PseudoElementMatches> PseudoElements { get; set; }
	}
}
