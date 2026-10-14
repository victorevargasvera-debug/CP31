using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200030A RID: 778
	[global::System.Runtime.Serialization.DataContract]
	public class CSSLayer : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700094A RID: 2378
		// (get) Token: 0x060017E1 RID: 6113 RVA: 0x00019E35 File Offset: 0x00018035
		// (set) Token: 0x060017E2 RID: 6114 RVA: 0x00019E3D File Offset: 0x0001803D
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = true)]
		public string Text { get; set; }

		// Token: 0x1700094B RID: 2379
		// (get) Token: 0x060017E3 RID: 6115 RVA: 0x00019E46 File Offset: 0x00018046
		// (set) Token: 0x060017E4 RID: 6116 RVA: 0x00019E4E File Offset: 0x0001804E
		[global::System.Runtime.Serialization.DataMember(Name = "range", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.SourceRange Range { get; set; }

		// Token: 0x1700094C RID: 2380
		// (get) Token: 0x060017E5 RID: 6117 RVA: 0x00019E57 File Offset: 0x00018057
		// (set) Token: 0x060017E6 RID: 6118 RVA: 0x00019E5F File Offset: 0x0001805F
		[global::System.Runtime.Serialization.DataMember(Name = "styleSheetId", IsRequired = false)]
		public string StyleSheetId { get; set; }
	}
}
