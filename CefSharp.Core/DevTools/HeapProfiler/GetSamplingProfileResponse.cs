using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x02000073 RID: 115
	[global::System.Runtime.Serialization.DataContract]
	public class GetSamplingProfileResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000180 RID: 384
		// (get) Token: 0x06000426 RID: 1062 RVA: 0x00006D9A File Offset: 0x00004F9A
		// (set) Token: 0x06000427 RID: 1063 RVA: 0x00006DA2 File Offset: 0x00004FA2
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.HeapProfiler.SamplingHeapProfile profile { get; set; }

		// Token: 0x17000181 RID: 385
		// (get) Token: 0x06000428 RID: 1064 RVA: 0x00006DAB File Offset: 0x00004FAB
		public global::CefSharp.DevTools.HeapProfiler.SamplingHeapProfile Profile
		{
			get
			{
				return this.profile;
			}
		}
	}
}
