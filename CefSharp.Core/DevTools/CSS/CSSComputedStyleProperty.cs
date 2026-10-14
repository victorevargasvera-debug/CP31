using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000300 RID: 768
	[global::System.Runtime.Serialization.DataContract]
	public class CSSComputedStyleProperty : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700091D RID: 2333
		// (get) Token: 0x0600177E RID: 6014 RVA: 0x00019A96 File Offset: 0x00017C96
		// (set) Token: 0x0600177F RID: 6015 RVA: 0x00019A9E File Offset: 0x00017C9E
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x1700091E RID: 2334
		// (get) Token: 0x06001780 RID: 6016 RVA: 0x00019AA7 File Offset: 0x00017CA7
		// (set) Token: 0x06001781 RID: 6017 RVA: 0x00019AAF File Offset: 0x00017CAF
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
