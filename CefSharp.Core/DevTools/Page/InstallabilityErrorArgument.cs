using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Page
{
	// Token: 0x02000184 RID: 388
	[global::System.Runtime.Serialization.DataContract]
	public class InstallabilityErrorArgument : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700048B RID: 1163
		// (get) Token: 0x06000BEC RID: 3052 RVA: 0x0000E011 File Offset: 0x0000C211
		// (set) Token: 0x06000BED RID: 3053 RVA: 0x0000E019 File Offset: 0x0000C219
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x1700048C RID: 1164
		// (get) Token: 0x06000BEE RID: 3054 RVA: 0x0000E022 File Offset: 0x0000C222
		// (set) Token: 0x06000BEF RID: 3055 RVA: 0x0000E02A File Offset: 0x0000C22A
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
