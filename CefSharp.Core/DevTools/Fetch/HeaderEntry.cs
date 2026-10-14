using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Fetch
{
	// Token: 0x020000E5 RID: 229
	[global::System.Runtime.Serialization.DataContract]
	public class HeaderEntry : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170002C5 RID: 709
		// (get) Token: 0x0600077A RID: 1914 RVA: 0x0000A049 File Offset: 0x00008249
		// (set) Token: 0x0600077B RID: 1915 RVA: 0x0000A051 File Offset: 0x00008251
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170002C6 RID: 710
		// (get) Token: 0x0600077C RID: 1916 RVA: 0x0000A05A File Offset: 0x0000825A
		// (set) Token: 0x0600077D RID: 1917 RVA: 0x0000A062 File Offset: 0x00008262
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
