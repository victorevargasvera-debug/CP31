using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001B2 RID: 434
	[global::System.Runtime.Serialization.DataContract]
	public class GetNavigationHistoryResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000502 RID: 1282
		// (get) Token: 0x06000CED RID: 3309 RVA: 0x0000E9AF File Offset: 0x0000CBAF
		// (set) Token: 0x06000CEE RID: 3310 RVA: 0x0000E9B7 File Offset: 0x0000CBB7
		[global::System.Runtime.Serialization.DataMember]
		internal int currentIndex { get; set; }

		// Token: 0x17000503 RID: 1283
		// (get) Token: 0x06000CEF RID: 3311 RVA: 0x0000E9C0 File Offset: 0x0000CBC0
		public int CurrentIndex
		{
			get
			{
				return this.currentIndex;
			}
		}

		// Token: 0x17000504 RID: 1284
		// (get) Token: 0x06000CF0 RID: 3312 RVA: 0x0000E9C8 File Offset: 0x0000CBC8
		// (set) Token: 0x06000CF1 RID: 3313 RVA: 0x0000E9D0 File Offset: 0x0000CBD0
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.NavigationEntry> entries { get; set; }

		// Token: 0x17000505 RID: 1285
		// (get) Token: 0x06000CF2 RID: 3314 RVA: 0x0000E9D9 File Offset: 0x0000CBD9
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.NavigationEntry> Entries
		{
			get
			{
				return this.entries;
			}
		}
	}
}
