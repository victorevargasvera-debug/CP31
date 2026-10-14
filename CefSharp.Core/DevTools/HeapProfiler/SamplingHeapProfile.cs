using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x0200006C RID: 108
	[global::System.Runtime.Serialization.DataContract]
	public class SamplingHeapProfile : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000173 RID: 371
		// (get) Token: 0x06000407 RID: 1031 RVA: 0x00006C97 File Offset: 0x00004E97
		// (set) Token: 0x06000408 RID: 1032 RVA: 0x00006C9F File Offset: 0x00004E9F
		[global::System.Runtime.Serialization.DataMember(Name = "head", IsRequired = true)]
		public global::CefSharp.DevTools.HeapProfiler.SamplingHeapProfileNode Head { get; set; }

		// Token: 0x17000174 RID: 372
		// (get) Token: 0x06000409 RID: 1033 RVA: 0x00006CA8 File Offset: 0x00004EA8
		// (set) Token: 0x0600040A RID: 1034 RVA: 0x00006CB0 File Offset: 0x00004EB0
		[global::System.Runtime.Serialization.DataMember(Name = "samples", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.HeapProfiler.SamplingHeapProfileSample> Samples { get; set; }
	}
}
