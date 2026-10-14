using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Network
{
	// Token: 0x02000217 RID: 535
	[global::System.Runtime.Serialization.DataContract]
	public class LoadNetworkResourceOptions : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700065F RID: 1631
		// (get) Token: 0x06001054 RID: 4180 RVA: 0x00011F5B File Offset: 0x0001015B
		// (set) Token: 0x06001055 RID: 4181 RVA: 0x00011F63 File Offset: 0x00010163
		[global::System.Runtime.Serialization.DataMember(Name = "disableCache", IsRequired = true)]
		public bool DisableCache { get; set; }

		// Token: 0x17000660 RID: 1632
		// (get) Token: 0x06001056 RID: 4182 RVA: 0x00011F6C File Offset: 0x0001016C
		// (set) Token: 0x06001057 RID: 4183 RVA: 0x00011F74 File Offset: 0x00010174
		[global::System.Runtime.Serialization.DataMember(Name = "includeCredentials", IsRequired = true)]
		public bool IncludeCredentials { get; set; }
	}
}
