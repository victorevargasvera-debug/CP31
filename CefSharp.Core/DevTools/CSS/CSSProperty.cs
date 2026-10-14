using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000302 RID: 770
	[global::System.Runtime.Serialization.DataContract]
	public class CSSProperty : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000924 RID: 2340
		// (get) Token: 0x0600178E RID: 6030 RVA: 0x00019B1D File Offset: 0x00017D1D
		// (set) Token: 0x0600178F RID: 6031 RVA: 0x00019B25 File Offset: 0x00017D25
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000925 RID: 2341
		// (get) Token: 0x06001790 RID: 6032 RVA: 0x00019B2E File Offset: 0x00017D2E
		// (set) Token: 0x06001791 RID: 6033 RVA: 0x00019B36 File Offset: 0x00017D36
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }

		// Token: 0x17000926 RID: 2342
		// (get) Token: 0x06001792 RID: 6034 RVA: 0x00019B3F File Offset: 0x00017D3F
		// (set) Token: 0x06001793 RID: 6035 RVA: 0x00019B47 File Offset: 0x00017D47
		[global::System.Runtime.Serialization.DataMember(Name = "important", IsRequired = false)]
		public bool? Important { get; set; }

		// Token: 0x17000927 RID: 2343
		// (get) Token: 0x06001794 RID: 6036 RVA: 0x00019B50 File Offset: 0x00017D50
		// (set) Token: 0x06001795 RID: 6037 RVA: 0x00019B58 File Offset: 0x00017D58
		[global::System.Runtime.Serialization.DataMember(Name = "implicit", IsRequired = false)]
		public bool? Implicit { get; set; }

		// Token: 0x17000928 RID: 2344
		// (get) Token: 0x06001796 RID: 6038 RVA: 0x00019B61 File Offset: 0x00017D61
		// (set) Token: 0x06001797 RID: 6039 RVA: 0x00019B69 File Offset: 0x00017D69
		[global::System.Runtime.Serialization.DataMember(Name = "text", IsRequired = false)]
		public string Text { get; set; }

		// Token: 0x17000929 RID: 2345
		// (get) Token: 0x06001798 RID: 6040 RVA: 0x00019B72 File Offset: 0x00017D72
		// (set) Token: 0x06001799 RID: 6041 RVA: 0x00019B7A File Offset: 0x00017D7A
		[global::System.Runtime.Serialization.DataMember(Name = "parsedOk", IsRequired = false)]
		public bool? ParsedOk { get; set; }

		// Token: 0x1700092A RID: 2346
		// (get) Token: 0x0600179A RID: 6042 RVA: 0x00019B83 File Offset: 0x00017D83
		// (set) Token: 0x0600179B RID: 6043 RVA: 0x00019B8B File Offset: 0x00017D8B
		[global::System.Runtime.Serialization.DataMember(Name = "disabled", IsRequired = false)]
		public bool? Disabled { get; set; }

		// Token: 0x1700092B RID: 2347
		// (get) Token: 0x0600179C RID: 6044 RVA: 0x00019B94 File Offset: 0x00017D94
		// (set) Token: 0x0600179D RID: 6045 RVA: 0x00019B9C File Offset: 0x00017D9C
		[global::System.Runtime.Serialization.DataMember(Name = "range", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.SourceRange Range { get; set; }

		// Token: 0x1700092C RID: 2348
		// (get) Token: 0x0600179E RID: 6046 RVA: 0x00019BA5 File Offset: 0x00017DA5
		// (set) Token: 0x0600179F RID: 6047 RVA: 0x00019BAD File Offset: 0x00017DAD
		[global::System.Runtime.Serialization.DataMember(Name = "longhandProperties", IsRequired = false)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.CSS.CSSProperty> LonghandProperties { get; set; }
	}
}
