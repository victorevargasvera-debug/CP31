using System;
using System.Collections.Generic;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000185 RID: 389
	[global::System.Runtime.Serialization.DataContract]
	public class InstallabilityError : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700048D RID: 1165
		// (get) Token: 0x06000BF1 RID: 3057 RVA: 0x0000E03B File Offset: 0x0000C23B
		// (set) Token: 0x06000BF2 RID: 3058 RVA: 0x0000E043 File Offset: 0x0000C243
		[global::System.Runtime.Serialization.DataMember(Name = "errorId", IsRequired = true)]
		public string ErrorId { get; set; }

		// Token: 0x1700048E RID: 1166
		// (get) Token: 0x06000BF3 RID: 3059 RVA: 0x0000E04C File Offset: 0x0000C24C
		// (set) Token: 0x06000BF4 RID: 3060 RVA: 0x0000E054 File Offset: 0x0000C254
		[global::System.Runtime.Serialization.DataMember(Name = "errorArguments", IsRequired = true)]
		public global::System.Collections.Generic.IList<global::CefSharp.DevTools.Page.InstallabilityErrorArgument> ErrorArguments { get; set; }
	}
}
