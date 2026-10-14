using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x0200025C RID: 604
	[global::System.Runtime.Serialization.DataContract]
	public class LoadSnapshotResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000744 RID: 1860
		// (get) Token: 0x060012B5 RID: 4789 RVA: 0x00014311 File Offset: 0x00012511
		// (set) Token: 0x060012B6 RID: 4790 RVA: 0x00014319 File Offset: 0x00012519
		[global::System.Runtime.Serialization.DataMember]
		internal string snapshotId { get; set; }

		// Token: 0x17000745 RID: 1861
		// (get) Token: 0x060012B7 RID: 4791 RVA: 0x00014322 File Offset: 0x00012522
		public string SnapshotId
		{
			get
			{
				return this.snapshotId;
			}
		}
	}
}
