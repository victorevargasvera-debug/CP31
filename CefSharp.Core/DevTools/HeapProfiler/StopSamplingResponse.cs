using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x02000074 RID: 116
	[global::System.Runtime.Serialization.DataContract]
	public class StopSamplingResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000182 RID: 386
		// (get) Token: 0x0600042A RID: 1066 RVA: 0x00006DBB File Offset: 0x00004FBB
		// (set) Token: 0x0600042B RID: 1067 RVA: 0x00006DC3 File Offset: 0x00004FC3
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.HeapProfiler.SamplingHeapProfile profile { get; set; }

		// Token: 0x17000183 RID: 387
		// (get) Token: 0x0600042C RID: 1068 RVA: 0x00006DCC File Offset: 0x00004FCC
		public global::CefSharp.DevTools.HeapProfiler.SamplingHeapProfile Profile
		{
			get
			{
				return this.profile;
			}
		}
	}
}
