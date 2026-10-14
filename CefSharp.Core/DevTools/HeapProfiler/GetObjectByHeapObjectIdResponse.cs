using System;
using System.Runtime.Serialization;
using CefSharp.DevTools.Runtime;

namespace CefSharp.DevTools.HeapProfiler
{
	// Token: 0x02000072 RID: 114
	[global::System.Runtime.Serialization.DataContract]
	public class GetObjectByHeapObjectIdResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x1700017E RID: 382
		// (get) Token: 0x06000422 RID: 1058 RVA: 0x00006D79 File Offset: 0x00004F79
		// (set) Token: 0x06000423 RID: 1059 RVA: 0x00006D81 File Offset: 0x00004F81
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Runtime.RemoteObject result { get; set; }

		// Token: 0x1700017F RID: 383
		// (get) Token: 0x06000424 RID: 1060 RVA: 0x00006D8A File Offset: 0x00004F8A
		public global::CefSharp.DevTools.Runtime.RemoteObject Result
		{
			get
			{
				return this.result;
			}
		}
	}
}
