using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200013D RID: 317
	[global::System.Runtime.Serialization.DataContract]
	public class GetSharedStorageEntriesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170003B7 RID: 951
		// (get) Token: 0x060009C7 RID: 2503 RVA: 0x0000C176 File Offset: 0x0000A376
		// (set) Token: 0x060009C8 RID: 2504 RVA: 0x0000C17E File Offset: 0x0000A37E
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.SharedStorageEntry> entries { get; set; }

		// Token: 0x170003B8 RID: 952
		// (get) Token: 0x060009C9 RID: 2505 RVA: 0x0000C187 File Offset: 0x0000A387
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Storage.SharedStorageEntry> Entries
		{
			get
			{
				return this.entries;
			}
		}
	}
}
