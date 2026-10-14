using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x02000260 RID: 608
	[global::System.Runtime.Serialization.DataContract]
	public class SnapshotCommandLogResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700074C RID: 1868
		// (get) Token: 0x060012C5 RID: 4805 RVA: 0x00014395 File Offset: 0x00012595
		// (set) Token: 0x060012C6 RID: 4806 RVA: 0x0001439D File Offset: 0x0001259D
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<object> commandLog { get; set; }

		// Token: 0x1700074D RID: 1869
		// (get) Token: 0x060012C7 RID: 4807 RVA: 0x000143A6 File Offset: 0x000125A6
		public global::System.Collections.Generic.IList<object> CommandLog
		{
			get
			{
				return this.commandLog;
			}
		}
	}
}
