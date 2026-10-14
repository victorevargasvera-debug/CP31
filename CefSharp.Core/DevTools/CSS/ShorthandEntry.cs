using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x020002FF RID: 767
	[global::System.Runtime.Serialization.DataContract]
	public class ShorthandEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700091A RID: 2330
		// (get) Token: 0x06001777 RID: 6007 RVA: 0x00019A5B File Offset: 0x00017C5B
		// (set) Token: 0x06001778 RID: 6008 RVA: 0x00019A63 File Offset: 0x00017C63
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x1700091B RID: 2331
		// (get) Token: 0x06001779 RID: 6009 RVA: 0x00019A6C File Offset: 0x00017C6C
		// (set) Token: 0x0600177A RID: 6010 RVA: 0x00019A74 File Offset: 0x00017C74
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }

		// Token: 0x1700091C RID: 2332
		// (get) Token: 0x0600177B RID: 6011 RVA: 0x00019A7D File Offset: 0x00017C7D
		// (set) Token: 0x0600177C RID: 6012 RVA: 0x00019A85 File Offset: 0x00017C85
		[global::System.Runtime.Serialization.DataMember(Name = "important", IsRequired = false)]
		public bool? Important { get; set; }
	}
}
