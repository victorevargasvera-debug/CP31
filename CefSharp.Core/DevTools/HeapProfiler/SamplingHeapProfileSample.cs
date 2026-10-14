using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x0200006B RID: 107
	[global::System.Runtime.Serialization.DataContract]
	public class SamplingHeapProfileSample : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000170 RID: 368
		// (get) Token: 0x06000400 RID: 1024 RVA: 0x00006C5C File Offset: 0x00004E5C
		// (set) Token: 0x06000401 RID: 1025 RVA: 0x00006C64 File Offset: 0x00004E64
		[global::System.Runtime.Serialization.DataMember(Name = "size", IsRequired = true)]
		public double Size { get; set; }

		// Token: 0x17000171 RID: 369
		// (get) Token: 0x06000402 RID: 1026 RVA: 0x00006C6D File Offset: 0x00004E6D
		// (set) Token: 0x06000403 RID: 1027 RVA: 0x00006C75 File Offset: 0x00004E75
		[global::System.Runtime.Serialization.DataMember(Name = "nodeId", IsRequired = true)]
		public int NodeId { get; set; }

		// Token: 0x17000172 RID: 370
		// (get) Token: 0x06000404 RID: 1028 RVA: 0x00006C7E File Offset: 0x00004E7E
		// (set) Token: 0x06000405 RID: 1029 RVA: 0x00006C86 File Offset: 0x00004E86
		[global::System.Runtime.Serialization.DataMember(Name = "ordinal", IsRequired = true)]
		public double Ordinal { get; set; }
	}
}
