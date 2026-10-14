using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.ServiceWorker
{
	// Token: 0x02000147 RID: 327
	[global::System.Runtime.Serialization.DataContract]
	public class WorkerVersionUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170003D1 RID: 977
		// (get) Token: 0x06000A2F RID: 2607 RVA: 0x0000CB5A File Offset: 0x0000AD5A
		// (set) Token: 0x06000A30 RID: 2608 RVA: 0x0000CB62 File Offset: 0x0000AD62
		[global::System.Runtime.Serialization.DataMember(Name = "versions", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.ServiceWorker.ServiceWorkerVersion> Versions { get; private set; }
	}
}
