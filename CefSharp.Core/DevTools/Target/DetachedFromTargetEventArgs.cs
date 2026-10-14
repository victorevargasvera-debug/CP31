using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000103 RID: 259
	[global::System.Runtime.Serialization.DataContract]
	public class DetachedFromTargetEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000315 RID: 789
		// (get) Token: 0x06000846 RID: 2118 RVA: 0x0000AE16 File Offset: 0x00009016
		// (set) Token: 0x06000847 RID: 2119 RVA: 0x0000AE1E File Offset: 0x0000901E
		[global::System.Runtime.Serialization.DataMember(Name = "sessionId", IsRequired = true)]
		public string SessionId { get; private set; }

		// Token: 0x17000316 RID: 790
		// (get) Token: 0x06000848 RID: 2120 RVA: 0x0000AE27 File Offset: 0x00009027
		// (set) Token: 0x06000849 RID: 2121 RVA: 0x0000AE2F File Offset: 0x0000902F
		[global::System.Runtime.Serialization.DataMember(Name = "targetId", IsRequired = false)]
		public string TargetId { get; private set; }
	}
}
