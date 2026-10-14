using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Profiler
{
	// Token: 0x02000067 RID: 103
	[global::System.Runtime.Serialization.DataContract]
	public class StopResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x17000166 RID: 358
		// (get) Token: 0x060003DC RID: 988 RVA: 0x00006992 File Offset: 0x00004B92
		// (set) Token: 0x060003DD RID: 989 RVA: 0x0000699A File Offset: 0x00004B9A
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Profiler.Profile profile { get; set; }

		// Token: 0x17000167 RID: 359
		// (get) Token: 0x060003DE RID: 990 RVA: 0x000069A3 File Offset: 0x00004BA3
		public global::CefSharp.DevTools.Profiler.Profile Profile
		{
			get
			{
				return this.profile;
			}
		}
	}
}
