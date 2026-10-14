using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Storage
{
	// Token: 0x0200013B RID: 315
	[global::System.Runtime.Serialization.DataContract]
	public class GetInterestGroupDetailsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170003B3 RID: 947
		// (get) Token: 0x060009BF RID: 2495 RVA: 0x0000C134 File Offset: 0x0000A334
		// (set) Token: 0x060009C0 RID: 2496 RVA: 0x0000C13C File Offset: 0x0000A33C
		[global::System.Runtime.Serialization.DataMember]
		internal global::CefSharp.DevTools.Storage.InterestGroupDetails details { get; set; }

		// Token: 0x170003B4 RID: 948
		// (get) Token: 0x060009C1 RID: 2497 RVA: 0x0000C145 File Offset: 0x0000A345
		public global::CefSharp.DevTools.Storage.InterestGroupDetails Details
		{
			get
			{
				return this.details;
			}
		}
	}
}
