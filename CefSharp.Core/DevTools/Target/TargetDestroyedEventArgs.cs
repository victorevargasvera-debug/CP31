using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000106 RID: 262
	[global::System.Runtime.Serialization.DataContract]
	public class TargetDestroyedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700031B RID: 795
		// (get) Token: 0x06000855 RID: 2133 RVA: 0x0000AE94 File Offset: 0x00009094
		// (set) Token: 0x06000856 RID: 2134 RVA: 0x0000AE9C File Offset: 0x0000909C
		[global::System.Runtime.Serialization.DataMember(Name = "targetId", IsRequired = true)]
		public string TargetId { get; private set; }
	}
}
