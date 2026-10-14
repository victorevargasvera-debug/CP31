using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000105 RID: 261
	[global::System.Runtime.Serialization.DataContract]
	public class TargetCreatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700031A RID: 794
		// (get) Token: 0x06000852 RID: 2130 RVA: 0x0000AE7B File Offset: 0x0000907B
		// (set) Token: 0x06000853 RID: 2131 RVA: 0x0000AE83 File Offset: 0x00009083
		[global::System.Runtime.Serialization.DataMember(Name = "targetInfo", IsRequired = true)]
		public global::CefSharp.DevTools.Target.TargetInfo TargetInfo { get; private set; }
	}
}
