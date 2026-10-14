using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000066 RID: 102
	[global::System.Runtime.Serialization.DataContract]
	public class StartPreciseCoverageResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000164 RID: 356
		// (get) Token: 0x060003D8 RID: 984 RVA: 0x00006971 File Offset: 0x00004B71
		// (set) Token: 0x060003D9 RID: 985 RVA: 0x00006979 File Offset: 0x00004B79
		[global::System.Runtime.Serialization.DataMember]
		internal double timestamp { get; set; }

		// Token: 0x17000165 RID: 357
		// (get) Token: 0x060003DA RID: 986 RVA: 0x00006982 File Offset: 0x00004B82
		public double Timestamp
		{
			get
			{
				return this.timestamp;
			}
		}
	}
}
