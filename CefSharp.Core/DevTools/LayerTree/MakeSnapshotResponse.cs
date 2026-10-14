using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x0200025D RID: 605
	[global::System.Runtime.Serialization.DataContract]
	public class MakeSnapshotResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000746 RID: 1862
		// (get) Token: 0x060012B9 RID: 4793 RVA: 0x00014332 File Offset: 0x00012532
		// (set) Token: 0x060012BA RID: 4794 RVA: 0x0001433A File Offset: 0x0001253A
		[global::System.Runtime.Serialization.DataMember]
		internal string snapshotId { get; set; }

		// Token: 0x17000747 RID: 1863
		// (get) Token: 0x060012BB RID: 4795 RVA: 0x00014343 File Offset: 0x00012543
		public string SnapshotId
		{
			get
			{
				return this.snapshotId;
			}
		}
	}
}
