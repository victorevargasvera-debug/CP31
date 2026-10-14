using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x02000071 RID: 113
	[global::System.Runtime.Serialization.DataContract]
	public class GetHeapObjectIdResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700017C RID: 380
		// (get) Token: 0x0600041E RID: 1054 RVA: 0x00006D58 File Offset: 0x00004F58
		// (set) Token: 0x0600041F RID: 1055 RVA: 0x00006D60 File Offset: 0x00004F60
		[global::System.Runtime.Serialization.DataMember]
		internal string heapSnapshotObjectId { get; set; }

		// Token: 0x1700017D RID: 381
		// (get) Token: 0x06000420 RID: 1056 RVA: 0x00006D69 File Offset: 0x00004F69
		public string HeapSnapshotObjectId
		{
			get
			{
				return this.heapSnapshotObjectId;
			}
		}
	}
}
