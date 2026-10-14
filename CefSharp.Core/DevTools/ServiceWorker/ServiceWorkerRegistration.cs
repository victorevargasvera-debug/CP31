using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.ServiceWorker
{
	// Token: 0x02000140 RID: 320
	[global::System.Runtime.Serialization.DataContract]
	public class ServiceWorkerRegistration : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170003BB RID: 955
		// (get) Token: 0x060009FE RID: 2558 RVA: 0x0000C980 File Offset: 0x0000AB80
		// (set) Token: 0x060009FF RID: 2559 RVA: 0x0000C988 File Offset: 0x0000AB88
		[global::System.Runtime.Serialization.DataMember(Name = "registrationId", IsRequired = true)]
		public string RegistrationId { get; set; }

		// Token: 0x170003BC RID: 956
		// (get) Token: 0x06000A00 RID: 2560 RVA: 0x0000C991 File Offset: 0x0000AB91
		// (set) Token: 0x06000A01 RID: 2561 RVA: 0x0000C999 File Offset: 0x0000AB99
		[global::System.Runtime.Serialization.DataMember(Name = "scopeURL", IsRequired = true)]
		public string ScopeURL { get; set; }

		// Token: 0x170003BD RID: 957
		// (get) Token: 0x06000A02 RID: 2562 RVA: 0x0000C9A2 File Offset: 0x0000ABA2
		// (set) Token: 0x06000A03 RID: 2563 RVA: 0x0000C9AA File Offset: 0x0000ABAA
		[global::System.Runtime.Serialization.DataMember(Name = "isDeleted", IsRequired = true)]
		public bool IsDeleted { get; set; }
	}
}
