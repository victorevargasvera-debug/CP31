using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Security
{
	// Token: 0x02000152 RID: 338
	[global::System.Runtime.Serialization.DataContract]
	public class CertificateErrorEventArgs : global::CefSharp.DevTools.DevToolsDomainEventArgsBase
	{
		// Token: 0x170003FE RID: 1022
		// (get) Token: 0x06000AA3 RID: 2723 RVA: 0x0000D264 File Offset: 0x0000B464
		// (set) Token: 0x06000AA4 RID: 2724 RVA: 0x0000D26C File Offset: 0x0000B46C
		[global::System.Runtime.Serialization.DataMember(Name = "eventId", IsRequired = true)]
		public int EventId { get; private set; }

		// Token: 0x170003FF RID: 1023
		// (get) Token: 0x06000AA5 RID: 2725 RVA: 0x0000D275 File Offset: 0x0000B475
		// (set) Token: 0x06000AA6 RID: 2726 RVA: 0x0000D27D File Offset: 0x0000B47D
		[global::System.Runtime.Serialization.DataMember(Name = "errorType", IsRequired = true)]
		public string ErrorType { get; private set; }

		// Token: 0x17000400 RID: 1024
		// (get) Token: 0x06000AA7 RID: 2727 RVA: 0x0000D286 File Offset: 0x0000B486
		// (set) Token: 0x06000AA8 RID: 2728 RVA: 0x0000D28E File Offset: 0x0000B48E
		[global::System.Runtime.Serialization.DataMember(Name = "requestURL", IsRequired = true)]
		public string RequestURL { get; private set; }
	}
}
