using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMSnapshot
{
	// Token: 0x020002A4 RID: 676
	[global::System.Runtime.Serialization.DataContract]
	public class RareBooleanData : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170007F6 RID: 2038
		// (get) Token: 0x0600149A RID: 5274 RVA: 0x00016D5E File Offset: 0x00014F5E
		// (set) Token: 0x0600149B RID: 5275 RVA: 0x00016D66 File Offset: 0x00014F66
		[global::System.Runtime.Serialization.DataMember(Name = "index", IsRequired = true)]
		public int[] Index { get; set; }
	}
}
