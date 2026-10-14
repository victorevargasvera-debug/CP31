using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.LayerTree
{
	// Token: 0x0200025F RID: 607
	[global::System.Runtime.Serialization.DataContract]
	public class ReplaySnapshotResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700074A RID: 1866
		// (get) Token: 0x060012C1 RID: 4801 RVA: 0x00014374 File Offset: 0x00012574
		// (set) Token: 0x060012C2 RID: 4802 RVA: 0x0001437C File Offset: 0x0001257C
		[global::System.Runtime.Serialization.DataMember]
		internal string dataURL { get; set; }

		// Token: 0x1700074B RID: 1867
		// (get) Token: 0x060012C3 RID: 4803 RVA: 0x00014385 File Offset: 0x00012585
		public string DataURL
		{
			get
			{
				return this.dataURL;
			}
		}
	}
}
