using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A3 RID: 675
	[global::System.Runtime.Serialization.DataContract]
	public class RareStringData : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007F4 RID: 2036
		// (get) Token: 0x06001495 RID: 5269 RVA: 0x00016D34 File Offset: 0x00014F34
		// (set) Token: 0x06001496 RID: 5270 RVA: 0x00016D3C File Offset: 0x00014F3C
		[global::System.Runtime.Serialization.DataMember(Name = "index", IsRequired = true)]
		public int[] Index { get; set; }

		// Token: 0x170007F5 RID: 2037
		// (get) Token: 0x06001497 RID: 5271 RVA: 0x00016D45 File Offset: 0x00014F45
		// (set) Token: 0x06001498 RID: 5272 RVA: 0x00016D4D File Offset: 0x00014F4D
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public int[] Value { get; set; }
	}
}
