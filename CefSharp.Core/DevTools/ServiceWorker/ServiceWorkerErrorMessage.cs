using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.ServiceWorker
{
	// Token: 0x02000144 RID: 324
	[global::System.Runtime.Serialization.DataContract]
	public class ServiceWorkerErrorMessage : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170003C9 RID: 969
		// (get) Token: 0x06000A1C RID: 2588 RVA: 0x0000CABA File Offset: 0x0000ACBA
		// (set) Token: 0x06000A1D RID: 2589 RVA: 0x0000CAC2 File Offset: 0x0000ACC2
		[global::System.Runtime.Serialization.DataMember(Name = "errorMessage", IsRequired = true)]
		public string ErrorMessage { get; set; }

		// Token: 0x170003CA RID: 970
		// (get) Token: 0x06000A1E RID: 2590 RVA: 0x0000CACB File Offset: 0x0000ACCB
		// (set) Token: 0x06000A1F RID: 2591 RVA: 0x0000CAD3 File Offset: 0x0000ACD3
		[global::System.Runtime.Serialization.DataMember(Name = "registrationId", IsRequired = true)]
		public string RegistrationId { get; set; }

		// Token: 0x170003CB RID: 971
		// (get) Token: 0x06000A20 RID: 2592 RVA: 0x0000CADC File Offset: 0x0000ACDC
		// (set) Token: 0x06000A21 RID: 2593 RVA: 0x0000CAE4 File Offset: 0x0000ACE4
		[global::System.Runtime.Serialization.DataMember(Name = "versionId", IsRequired = true)]
		public string VersionId { get; set; }

		// Token: 0x170003CC RID: 972
		// (get) Token: 0x06000A22 RID: 2594 RVA: 0x0000CAED File Offset: 0x0000ACED
		// (set) Token: 0x06000A23 RID: 2595 RVA: 0x0000CAF5 File Offset: 0x0000ACF5
		[global::System.Runtime.Serialization.DataMember(Name = "sourceURL", IsRequired = true)]
		public string SourceURL { get; set; }

		// Token: 0x170003CD RID: 973
		// (get) Token: 0x06000A24 RID: 2596 RVA: 0x0000CAFE File Offset: 0x0000ACFE
		// (set) Token: 0x06000A25 RID: 2597 RVA: 0x0000CB06 File Offset: 0x0000AD06
		[global::System.Runtime.Serialization.DataMember(Name = "lineNumber", IsRequired = true)]
		public int LineNumber { get; set; }

		// Token: 0x170003CE RID: 974
		// (get) Token: 0x06000A26 RID: 2598 RVA: 0x0000CB0F File Offset: 0x0000AD0F
		// (set) Token: 0x06000A27 RID: 2599 RVA: 0x0000CB17 File Offset: 0x0000AD17
		[global::System.Runtime.Serialization.DataMember(Name = "columnNumber", IsRequired = true)]
		public int ColumnNumber { get; set; }
	}
}
