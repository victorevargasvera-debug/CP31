using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Accessibility
{
	// Token: 0x02000383 RID: 899
	[global::System.Runtime.Serialization.DataContract]
	public class AXRelatedNode : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000AA5 RID: 2725
		// (get) Token: 0x06001B1B RID: 6939 RVA: 0x0001CA99 File Offset: 0x0001AC99
		// (set) Token: 0x06001B1C RID: 6940 RVA: 0x0001CAA1 File Offset: 0x0001ACA1
		[global::System.Runtime.Serialization.DataMember(Name = "backendDOMNodeId", IsRequired = true)]
		public int BackendDOMNodeId { get; set; }

		// Token: 0x17000AA6 RID: 2726
		// (get) Token: 0x06001B1D RID: 6941 RVA: 0x0001CAAA File Offset: 0x0001ACAA
		// (set) Token: 0x06001B1E RID: 6942 RVA: 0x0001CAB2 File Offset: 0x0001ACB2
		[global::System.Runtime.Serialization.DataMember(Name = "idref", IsRequired = false)]
		public string Idref { get; set; }

		// Token: 0x17000AA7 RID: 2727
		// (get) Token: 0x06001B1F RID: 6943 RVA: 0x0001CABB File Offset: 0x0001ACBB
		// (set) Token: 0x06001B20 RID: 6944 RVA: 0x0001CAC3 File Offset: 0x0001ACC3
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = false)]
		public string Text { get; set; }
	}
}
