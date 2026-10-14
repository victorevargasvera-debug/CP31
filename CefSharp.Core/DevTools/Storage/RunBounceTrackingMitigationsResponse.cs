using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200013E RID: 318
	[global::System.Runtime.Serialization.DataContract]
	public class RunBounceTrackingMitigationsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170003B9 RID: 953
		// (get) Token: 0x060009CB RID: 2507 RVA: 0x0000C197 File Offset: 0x0000A397
		// (set) Token: 0x060009CC RID: 2508 RVA: 0x0000C19F File Offset: 0x0000A39F
		[global::System.Runtime.Serialization.DataMember]
		internal string[] deletedSites { get; set; }

		// Token: 0x170003BA RID: 954
		// (get) Token: 0x060009CD RID: 2509 RVA: 0x0000C1A8 File Offset: 0x0000A3A8
		public string[] DeletedSites
		{
			get
			{
				return this.deletedSites;
			}
		}
	}
}
