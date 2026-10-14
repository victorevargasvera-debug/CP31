using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Runtime
{
	// Token: 0x0200004C RID: 76
	[global::System.Runtime.Serialization.DataContract]
	public class ExceptionThrownEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x17000112 RID: 274
		// (get) Token: 0x06000308 RID: 776 RVA: 0x00005944 File Offset: 0x00003B44
		// (set) Token: 0x06000309 RID: 777 RVA: 0x0000594C File Offset: 0x00003B4C
		[global::System.Runtime.Serialization.DataMember(Name = "timestamp", IsRequired = true)]
		public double Timestamp { get; private set; }

		// Token: 0x17000113 RID: 275
		// (get) Token: 0x0600030A RID: 778 RVA: 0x00005955 File Offset: 0x00003B55
		// (set) Token: 0x0600030B RID: 779 RVA: 0x0000595D File Offset: 0x00003B5D
		[global::System.Runtime.Serialization.DataMember(Name = "exceptionDetails", IsRequired = true)]
		public global::CefSharp.DevTools.Runtime.ExceptionDetails ExceptionDetails { get; private set; }
	}
}
