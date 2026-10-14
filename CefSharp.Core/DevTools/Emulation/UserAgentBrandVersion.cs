using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x02000289 RID: 649
	[global::System.Runtime.Serialization.DataContract]
	public class UserAgentBrandVersion : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700079B RID: 1947
		// (get) Token: 0x060013A2 RID: 5026 RVA: 0x00015B8F File Offset: 0x00013D8F
		// (set) Token: 0x060013A3 RID: 5027 RVA: 0x00015B97 File Offset: 0x00013D97
		[global::System.Runtime.Serialization.DataMember(Name = "brand", IsRequired = true)]
		public string Brand { get; set; }

		// Token: 0x1700079C RID: 1948
		// (get) Token: 0x060013A4 RID: 5028 RVA: 0x00015BA0 File Offset: 0x00013DA0
		// (set) Token: 0x060013A5 RID: 5029 RVA: 0x00015BA8 File Offset: 0x00013DA8
		[global::System.Runtime.Serialization.DataMember(Name = "version", IsRequired = true)]
		public string Version { get; set; }
	}
}
