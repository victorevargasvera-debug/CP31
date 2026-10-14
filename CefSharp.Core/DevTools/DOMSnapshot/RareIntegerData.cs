using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A5 RID: 677
	[global::System.Runtime.Serialization.DataContract]
	public class RareIntegerData : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007F7 RID: 2039
		// (get) Token: 0x0600149D RID: 5277 RVA: 0x00016D77 File Offset: 0x00014F77
		// (set) Token: 0x0600149E RID: 5278 RVA: 0x00016D7F File Offset: 0x00014F7F
		[global::System.Runtime.Serialization.DataMember(Name = "index", IsRequired = true)]
		public int[] Index { get; set; }

		// Token: 0x170007F8 RID: 2040
		// (get) Token: 0x0600149F RID: 5279 RVA: 0x00016D88 File Offset: 0x00014F88
		// (set) Token: 0x060014A0 RID: 5280 RVA: 0x00016D90 File Offset: 0x00014F90
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public int[] Value { get; set; }
	}
}
