using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Input
{
	// Token: 0x02000267 RID: 615
	[global::System.Runtime.Serialization.DataContract]
	public class DragDataItem : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700075A RID: 1882
		// (get) Token: 0x060012FA RID: 4858 RVA: 0x00014823 File Offset: 0x00012A23
		// (set) Token: 0x060012FB RID: 4859 RVA: 0x0001482B File Offset: 0x00012A2B
		[global::System.Runtime.Serialization.DataMember(Name = "mimeType", IsRequired = true)]
		public string MimeType { get; set; }

		// Token: 0x1700075B RID: 1883
		// (get) Token: 0x060012FC RID: 4860 RVA: 0x00014834 File Offset: 0x00012A34
		// (set) Token: 0x060012FD RID: 4861 RVA: 0x0001483C File Offset: 0x00012A3C
		[global::System.Runtime.Serialization.DataMember(Name = "data", IsRequired = true)]
		public string Data { get; set; }

		// Token: 0x1700075C RID: 1884
		// (get) Token: 0x060012FE RID: 4862 RVA: 0x00014845 File Offset: 0x00012A45
		// (set) Token: 0x060012FF RID: 4863 RVA: 0x0001484D File Offset: 0x00012A4D
		[global::System.Runtime.Serialization.DataMember(Name = "title", IsRequired = false)]
		public string Title { get; set; }

		// Token: 0x1700075D RID: 1885
		// (get) Token: 0x06001300 RID: 4864 RVA: 0x00014856 File Offset: 0x00012A56
		// (set) Token: 0x06001301 RID: 4865 RVA: 0x0001485E File Offset: 0x00012A5E
		[global::System.Runtime.Serialization.DataMember(Name = "baseURL", IsRequired = false)]
		public string BaseURL { get; set; }
	}
}
