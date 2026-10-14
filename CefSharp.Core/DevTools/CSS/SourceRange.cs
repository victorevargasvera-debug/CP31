using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002FE RID: 766
	[global::System.Runtime.Serialization.DataContract]
	public class SourceRange : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000916 RID: 2326
		// (get) Token: 0x0600176E RID: 5998 RVA: 0x00019A0F File Offset: 0x00017C0F
		// (set) Token: 0x0600176F RID: 5999 RVA: 0x00019A17 File Offset: 0x00017C17
		[global::System.Runtime.Serialization.DataMember(Name = "startLine", IsRequired = true)]
		public int StartLine { get; set; }

		// Token: 0x17000917 RID: 2327
		// (get) Token: 0x06001770 RID: 6000 RVA: 0x00019A20 File Offset: 0x00017C20
		// (set) Token: 0x06001771 RID: 6001 RVA: 0x00019A28 File Offset: 0x00017C28
		[global::System.Runtime.Serialization.DataMember(Name = "startColumn", IsRequired = true)]
		public int StartColumn { get; set; }

		// Token: 0x17000918 RID: 2328
		// (get) Token: 0x06001772 RID: 6002 RVA: 0x00019A31 File Offset: 0x00017C31
		// (set) Token: 0x06001773 RID: 6003 RVA: 0x00019A39 File Offset: 0x00017C39
		[global::System.Runtime.Serialization.DataMember(Name = "endLine", IsRequired = true)]
		public int EndLine { get; set; }

		// Token: 0x17000919 RID: 2329
		// (get) Token: 0x06001774 RID: 6004 RVA: 0x00019A42 File Offset: 0x00017C42
		// (set) Token: 0x06001775 RID: 6005 RVA: 0x00019A4A File Offset: 0x00017C4A
		[global::System.Runtime.Serialization.DataMember(Name = "endColumn", IsRequired = true)]
		public int EndColumn { get; set; }
	}
}
