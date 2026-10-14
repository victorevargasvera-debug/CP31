using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000358 RID: 856
	[global::System.Runtime.Serialization.DataContract]
	public class SourceCodeLocation : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A1D RID: 2589
		// (get) Token: 0x060019DC RID: 6620 RVA: 0x0001BBA4 File Offset: 0x00019DA4
		// (set) Token: 0x060019DD RID: 6621 RVA: 0x0001BBAC File Offset: 0x00019DAC
		[global::System.Runtime.Serialization.DataMember(Name = "scriptId", IsRequired = false)]
		public string ScriptId { get; set; }

		// Token: 0x17000A1E RID: 2590
		// (get) Token: 0x060019DE RID: 6622 RVA: 0x0001BBB5 File Offset: 0x00019DB5
		// (set) Token: 0x060019DF RID: 6623 RVA: 0x0001BBBD File Offset: 0x00019DBD
		[global::System.Runtime.Serialization.DataMember(Name = "url", IsRequired = true)]
		public string Url { get; set; }

		// Token: 0x17000A1F RID: 2591
		// (get) Token: 0x060019E0 RID: 6624 RVA: 0x0001BBC6 File Offset: 0x00019DC6
		// (set) Token: 0x060019E1 RID: 6625 RVA: 0x0001BBCE File Offset: 0x00019DCE
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = true)]
		public int LineNumber { get; set; }

		// Token: 0x17000A20 RID: 2592
		// (get) Token: 0x060019E2 RID: 6626 RVA: 0x0001BBD7 File Offset: 0x00019DD7
		// (set) Token: 0x060019E3 RID: 6627 RVA: 0x0001BBDF File Offset: 0x00019DDF
		[global::System.Runtime.Serialization.DataMember(Name = "columnNumber", IsRequired = true)]
		public int ColumnNumber { get; set; }
	}
}
