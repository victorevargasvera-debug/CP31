using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.ServiceWorker
{
	// Token: 0x02000146 RID: 326
	[global::System.Runtime.Serialization.DataContract]
	public class WorkerRegistrationUpdatedEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170003D0 RID: 976
		// (get) Token: 0x06000A2C RID: 2604 RVA: 0x0000CB41 File Offset: 0x0000AD41
		// (set) Token: 0x06000A2D RID: 2605 RVA: 0x0000CB49 File Offset: 0x0000AD49
		[global::System.Runtime.Serialization.DataMember(Name = "registrations", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.ServiceWorker.ServiceWorkerRegistration> Registrations { get; private set; }
	}
}
