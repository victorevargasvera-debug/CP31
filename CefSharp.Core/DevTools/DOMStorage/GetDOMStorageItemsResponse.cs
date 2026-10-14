using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOMStorage
{
	// Token: 0x0200029C RID: 668
	[global::System.Runtime.Serialization.DataContract]
	public class GetDOMStorageItemsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170007C7 RID: 1991
		// (get) Token: 0x06001427 RID: 5159 RVA: 0x000167E5 File Offset: 0x000149E5
		// (set) Token: 0x06001428 RID: 5160 RVA: 0x000167ED File Offset: 0x000149ED
		[global::System.Runtime.Serialization.DataMember]
		internal string[] entries { get; set; }

		// Token: 0x170007C8 RID: 1992
		// (get) Token: 0x06001429 RID: 5161 RVA: 0x000167F6 File Offset: 0x000149F6
		public string[] Entries
		{
			get
			{
				return this.entries;
			}
		}
	}
}
