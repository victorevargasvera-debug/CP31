using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x0200027C RID: 636
	[global::System.Runtime.Serialization.DataContract]
	public class RequestDatabaseResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000786 RID: 1926
		// (get) Token: 0x06001369 RID: 4969 RVA: 0x000155C3 File Offset: 0x000137C3
		// (set) Token: 0x0600136A RID: 4970 RVA: 0x000155CB File Offset: 0x000137CB
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.IndexedDB.DatabaseWithObjectStores databaseWithObjectStores { get; set; }

		// Token: 0x17000787 RID: 1927
		// (get) Token: 0x0600136B RID: 4971 RVA: 0x000155D4 File Offset: 0x000137D4
		public global::CefSharp.DevTools.IndexedDB.DatabaseWithObjectStores DatabaseWithObjectStores
		{
			get
			{
				return this.databaseWithObjectStores;
			}
		}
	}
}
