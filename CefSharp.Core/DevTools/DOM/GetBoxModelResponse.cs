using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002CE RID: 718
	[global::System.Runtime.Serialization.DataContract]
	public class GetBoxModelResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000894 RID: 2196
		// (get) Token: 0x060015FF RID: 5631 RVA: 0x00017C9A File Offset: 0x00015E9A
		// (set) Token: 0x06001600 RID: 5632 RVA: 0x00017CA2 File Offset: 0x00015EA2
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.DOM.BoxModel model { get; set; }

		// Token: 0x17000895 RID: 2197
		// (get) Token: 0x06001601 RID: 5633 RVA: 0x00017CAB File Offset: 0x00015EAB
		public global::CefSharp.DevTools.DOM.BoxModel Model
		{
			get
			{
				return this.model;
			}
		}
	}
}
