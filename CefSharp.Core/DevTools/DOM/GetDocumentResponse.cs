using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002D0 RID: 720
	[global::System.Runtime.Serialization.DataContract]
	public class GetDocumentResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000898 RID: 2200
		// (get) Token: 0x06001607 RID: 5639 RVA: 0x00017CDC File Offset: 0x00015EDC
		// (set) Token: 0x06001608 RID: 5640 RVA: 0x00017CE4 File Offset: 0x00015EE4
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.DOM.Node root { get; set; }

		// Token: 0x17000899 RID: 2201
		// (get) Token: 0x06001609 RID: 5641 RVA: 0x00017CED File Offset: 0x00015EED
		public global::CefSharp.DevTools.DOM.Node Root
		{
			get
			{
				return this.root;
			}
		}
	}
}
