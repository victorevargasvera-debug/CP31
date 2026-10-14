using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002FD RID: 765
	[global::System.Runtime.Serialization.DataContract]
	public class RuleUsage : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000912 RID: 2322
		// (get) Token: 0x06001765 RID: 5989 RVA: 0x000199C3 File Offset: 0x00017BC3
		// (set) Token: 0x06001766 RID: 5990 RVA: 0x000199CB File Offset: 0x00017BCB
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = true)]
		public string StyleSheetId { get; set; }

		// Token: 0x17000913 RID: 2323
		// (get) Token: 0x06001767 RID: 5991 RVA: 0x000199D4 File Offset: 0x00017BD4
		// (set) Token: 0x06001768 RID: 5992 RVA: 0x000199DC File Offset: 0x00017BDC
		[global::System.Runtime.Serialization.DataMember(Name = "startOffset", IsRequired = true)]
		public double StartOffset { get; set; }

		// Token: 0x17000914 RID: 2324
		// (get) Token: 0x06001769 RID: 5993 RVA: 0x000199E5 File Offset: 0x00017BE5
		// (set) Token: 0x0600176A RID: 5994 RVA: 0x000199ED File Offset: 0x00017BED
		[global::System.Runtime.Serialization.DataMember(Name = "endOffset", IsRequired = true)]
		public double EndOffset { get; set; }

		// Token: 0x17000915 RID: 2325
		// (get) Token: 0x0600176B RID: 5995 RVA: 0x000199F6 File Offset: 0x00017BF6
		// (set) Token: 0x0600176C RID: 5996 RVA: 0x000199FE File Offset: 0x00017BFE
		[global::System.Runtime.Serialization.DataMember(Name = "used", IsRequired = true)]
		public bool Used { get; set; }
	}
}
