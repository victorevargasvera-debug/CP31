using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002CD RID: 717
	[global::System.Runtime.Serialization.DataContract]
	public class GetAttributesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000892 RID: 2194
		// (get) Token: 0x060015FB RID: 5627 RVA: 0x00017C79 File Offset: 0x00015E79
		// (set) Token: 0x060015FC RID: 5628 RVA: 0x00017C81 File Offset: 0x00015E81
		[global::System.Runtime.Serialization.DataMember]
		internal string[] attributes { get; set; }

		// Token: 0x17000893 RID: 2195
		// (get) Token: 0x060015FD RID: 5629 RVA: 0x00017C8A File Offset: 0x00015E8A
		public string[] Attributes
		{
			get
			{
				return this.attributes;
			}
		}
	}
}
