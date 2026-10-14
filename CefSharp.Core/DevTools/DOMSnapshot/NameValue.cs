using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A2 RID: 674
	[global::System.Runtime.Serialization.DataContract]
	public class NameValue : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007F2 RID: 2034
		// (get) Token: 0x06001490 RID: 5264 RVA: 0x00016D0A File Offset: 0x00014F0A
		// (set) Token: 0x06001491 RID: 5265 RVA: 0x00016D12 File Offset: 0x00014F12
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x170007F3 RID: 2035
		// (get) Token: 0x06001492 RID: 5266 RVA: 0x00016D1B File Offset: 0x00014F1B
		// (set) Token: 0x06001493 RID: 5267 RVA: 0x00016D23 File Offset: 0x00014F23
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
