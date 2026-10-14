using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Target
{
	// Token: 0x02000108 RID: 264
	[global::System.Runtime.Serialization.DataContract]
	public class TargetInfoChangedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x1700031F RID: 799
		// (get) Token: 0x0600085F RID: 2143 RVA: 0x0000AEE8 File Offset: 0x000090E8
		// (set) Token: 0x06000860 RID: 2144 RVA: 0x0000AEF0 File Offset: 0x000090F0
		[global::System.Runtime.Serialization.DataMember(Name = "targetInfo", IsRequired = true)]
		public global::CefSharp.DevTools.Target.TargetInfo TargetInfo { get; private set; }
	}
}
