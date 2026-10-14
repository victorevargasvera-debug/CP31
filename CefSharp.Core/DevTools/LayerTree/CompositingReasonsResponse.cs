using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x0200025B RID: 603
	[global::System.Runtime.Serialization.DataContract]
	public class CompositingReasonsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000740 RID: 1856
		// (get) Token: 0x060012AE RID: 4782 RVA: 0x000142D7 File Offset: 0x000124D7
		// (set) Token: 0x060012AF RID: 4783 RVA: 0x000142DF File Offset: 0x000124DF
		[global::System.Runtime.Serialization.DataMember]
		internal string[] compositingReasons { get; set; }

		// Token: 0x17000741 RID: 1857
		// (get) Token: 0x060012B0 RID: 4784 RVA: 0x000142E8 File Offset: 0x000124E8
		public string[] CompositingReasons
		{
			get
			{
				return this.compositingReasons;
			}
		}

		// Token: 0x17000742 RID: 1858
		// (get) Token: 0x060012B1 RID: 4785 RVA: 0x000142F0 File Offset: 0x000124F0
		// (set) Token: 0x060012B2 RID: 4786 RVA: 0x000142F8 File Offset: 0x000124F8
		[global::System.Runtime.Serialization.DataMember]
		internal string[] compositingReasonIds { get; set; }

		// Token: 0x17000743 RID: 1859
		// (get) Token: 0x060012B3 RID: 4787 RVA: 0x00014301 File Offset: 0x00012501
		public string[] CompositingReasonIds
		{
			get
			{
				return this.compositingReasonIds;
			}
		}
	}
}
