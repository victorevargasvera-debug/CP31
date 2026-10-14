using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.ServiceWorker
{
	// Token: 0x02000145 RID: 325
	[global::System.Runtime.Serialization.DataContract]
	public class WorkerErrorReportedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170003CF RID: 975
		// (get) Token: 0x06000A29 RID: 2601 RVA: 0x0000CB28 File Offset: 0x0000AD28
		// (set) Token: 0x06000A2A RID: 2602 RVA: 0x0000CB30 File Offset: 0x0000AD30
		[global::System.Runtime.Serialization.DataMember(Name = "errorMessage", IsRequired = true)]
		public global::CefSharp.DevTools.ServiceWorker.ServiceWorkerErrorMessage ErrorMessage { get; private set; }
	}
}
