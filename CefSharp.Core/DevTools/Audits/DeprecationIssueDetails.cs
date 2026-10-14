using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Audits
{
	// Token: 0x02000366 RID: 870
	[global::System.Runtime.Serialization.DataContract]
	public class DeprecationIssueDetails : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000A53 RID: 2643
		// (get) Token: 0x06001A52 RID: 6738 RVA: 0x0001C03E File Offset: 0x0001A23E
		// (set) Token: 0x06001A53 RID: 6739 RVA: 0x0001C046 File Offset: 0x0001A246
		[global::System.Runtime.Serialization.DataMember(Name = "affectedFrame", IsRequired = false)]
		public global::CefSharp.DevTools.Audits.AffectedFrame AffectedFrame { get; set; }

		// Token: 0x17000A54 RID: 2644
		// (get) Token: 0x06001A54 RID: 6740 RVA: 0x0001C04F File Offset: 0x0001A24F
		// (set) Token: 0x06001A55 RID: 6741 RVA: 0x0001C057 File Offset: 0x0001A257
		[global::System.Runtime.Serialization.DataMember(Name = "sourceCodeLocation", IsRequired = true)]
		public global::CefSharp.DevTools.Audits.SourceCodeLocation SourceCodeLocation { get; set; }

		// Token: 0x17000A55 RID: 2645
		// (get) Token: 0x06001A56 RID: 6742 RVA: 0x0001C060 File Offset: 0x0001A260
		// (set) Token: 0x06001A57 RID: 6743 RVA: 0x0001C068 File Offset: 0x0001A268
		[global::System.Runtime.Serialization.DataMember(Name = "type", IsRequired = true)]
		public string Type { get; set; }
	}
}
