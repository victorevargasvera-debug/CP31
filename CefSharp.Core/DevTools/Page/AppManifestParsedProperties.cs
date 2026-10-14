using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x0200017B RID: 379
	[global::System.Runtime.Serialization.DataContract]
	public class AppManifestParsedProperties : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700046E RID: 1134
		// (get) Token: 0x06000BAB RID: 2987 RVA: 0x0000DDDD File Offset: 0x0000BFDD
		// (set) Token: 0x06000BAC RID: 2988 RVA: 0x0000DDE5 File Offset: 0x0000BFE5
		[global::System.Runtime.Serialization.DataMember(Name = "scope", IsRequired = true)]
		public string Scope { get; set; }
	}
}
