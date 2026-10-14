using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000329 RID: 809
	[global::System.Runtime.Serialization.DataContract]
	public class SetRuleSelectorResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170009AE RID: 2478
		// (get) Token: 0x060018AC RID: 6316 RVA: 0x0001A511 File Offset: 0x00018711
		// (set) Token: 0x060018AD RID: 6317 RVA: 0x0001A519 File Offset: 0x00018719
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.CSS.SelectorList selectorList { get; set; }

		// Token: 0x170009AF RID: 2479
		// (get) Token: 0x060018AE RID: 6318 RVA: 0x0001A522 File Offset: 0x00018722
		public global::CefSharp.DevTools.CSS.SelectorList SelectorList
		{
			get
			{
				return this.selectorList;
			}
		}
	}
}
