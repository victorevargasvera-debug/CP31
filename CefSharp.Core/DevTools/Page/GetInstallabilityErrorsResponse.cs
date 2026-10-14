using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x020001AD RID: 429
	[global::System.Runtime.Serialization.DataContract]
	public class GetInstallabilityErrorsResponse : global::CefSharp.DevTools.DevToolsDomainResponseBase
	{
		// Token: 0x170004EC RID: 1260
		// (get) Token: 0x06000CC7 RID: 3271 RVA: 0x0000E874 File Offset: 0x0000CA74
		// (set) Token: 0x06000CC8 RID: 3272 RVA: 0x0000E87C File Offset: 0x0000CA7C
		[global::System.Runtime.Serialization.DataMember]
		internal global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.InstallabilityError> installabilityErrors { get; set; }

		// Token: 0x170004ED RID: 1261
		// (get) Token: 0x06000CC9 RID: 3273 RVA: 0x0000E885 File Offset: 0x0000CA85
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.InstallabilityError> InstallabilityErrors
		{
			get
			{
				return this.installabilityErrors;
			}
		}
	}
}
