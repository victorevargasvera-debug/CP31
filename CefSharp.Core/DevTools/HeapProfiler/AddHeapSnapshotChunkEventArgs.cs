using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x0200006D RID: 109
	[global::System.Runtime.Serialization.DataContract]
	public class AddHeapSnapshotChunkEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000175 RID: 373
		// (get) Token: 0x0600040C RID: 1036 RVA: 0x00006CC1 File Offset: 0x00004EC1
		// (set) Token: 0x0600040D RID: 1037 RVA: 0x00006CC9 File Offset: 0x00004EC9
		[global::System.Runtime.Serialization.DataMember(Name = "chunk", IsRequired = true)]
		public string Chunk { get; private set; }
	}
}
