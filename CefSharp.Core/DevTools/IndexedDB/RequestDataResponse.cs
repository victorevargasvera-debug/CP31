using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x0200027A RID: 634
	[global::System.Runtime.Serialization.DataContract]
	public class RequestDataResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700077E RID: 1918
		// (get) Token: 0x0600135B RID: 4955 RVA: 0x0001554F File Offset: 0x0001374F
		// (set) Token: 0x0600135C RID: 4956 RVA: 0x00015557 File Offset: 0x00013757
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.IndexedDB.DataEntry> objectStoreDataEntries { get; set; }

		// Token: 0x1700077F RID: 1919
		// (get) Token: 0x0600135D RID: 4957 RVA: 0x00015560 File Offset: 0x00013760
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.IndexedDB.DataEntry> ObjectStoreDataEntries
		{
			get
			{
				return this.objectStoreDataEntries;
			}
		}

		// Token: 0x17000780 RID: 1920
		// (get) Token: 0x0600135E RID: 4958 RVA: 0x00015568 File Offset: 0x00013768
		// (set) Token: 0x0600135F RID: 4959 RVA: 0x00015570 File Offset: 0x00013770
		[global::System.Runtime.Serialization.DataMember]
		internal bool hasMore { get; set; }

		// Token: 0x17000781 RID: 1921
		// (get) Token: 0x06001360 RID: 4960 RVA: 0x00015579 File Offset: 0x00013779
		public bool HasMore
		{
			get
			{
				return this.hasMore;
			}
		}
	}
}
