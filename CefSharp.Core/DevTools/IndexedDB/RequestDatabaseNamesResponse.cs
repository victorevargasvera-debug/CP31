using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.IndexedDB
{
	// Token: 0x0200027D RID: 637
	[global::System.Runtime.Serialization.DataContract]
	public class RequestDatabaseNamesResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000788 RID: 1928
		// (get) Token: 0x0600136D RID: 4973 RVA: 0x000155E4 File Offset: 0x000137E4
		// (set) Token: 0x0600136E RID: 4974 RVA: 0x000155EC File Offset: 0x000137EC
		[global::System.Runtime.Serialization.DataMember]
		internal string[] databaseNames { get; set; }

		// Token: 0x17000789 RID: 1929
		// (get) Token: 0x0600136F RID: 4975 RVA: 0x000155F5 File Offset: 0x000137F5
		public string[] DatabaseNames
		{
			get
			{
				return this.databaseNames;
			}
		}
	}
}
