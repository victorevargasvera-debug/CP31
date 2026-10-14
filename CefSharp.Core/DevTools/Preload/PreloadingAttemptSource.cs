using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Preload
{
	// Token: 0x020000A4 RID: 164
	[global::System.Runtime.Serialization.DataContract]
	public class PreloadingAttemptSource : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700022A RID: 554
		// (get) Token: 0x060005C5 RID: 1477 RVA: 0x000089AA File Offset: 0x00006BAA
		// (set) Token: 0x060005C6 RID: 1478 RVA: 0x000089B2 File Offset: 0x00006BB2
		[global::System.Runtime.Serialization.DataMember(Name = "key", IsRequired = true)]
		public global::CefSharp.DevTools.Preload.PreloadingAttemptKey Key { get; set; }

		// Token: 0x1700022B RID: 555
		// (get) Token: 0x060005C7 RID: 1479 RVA: 0x000089BB File Offset: 0x00006BBB
		// (set) Token: 0x060005C8 RID: 1480 RVA: 0x000089C3 File Offset: 0x00006BC3
		[global::System.Runtime.Serialization.DataMember(Name = "ruleSetIds", IsRequired = true)]
		public string[] RuleSetIds { get; set; }

		// Token: 0x1700022C RID: 556
		// (get) Token: 0x060005C9 RID: 1481 RVA: 0x000089CC File Offset: 0x00006BCC
		// (set) Token: 0x060005CA RID: 1482 RVA: 0x000089D4 File Offset: 0x00006BD4
		[global::System.Runtime.Serialization.DataMember(Name = "nodeIds", IsRequired = true)]
		public int[] NodeIds { get; set; }
	}
}
