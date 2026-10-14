using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Emulation
{
	// Token: 0x02000287 RID: 647
	[global::System.Runtime.Serialization.DataContract]
	public class MediaFeature : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000799 RID: 1945
		// (get) Token: 0x0600139D RID: 5021 RVA: 0x00015B65 File Offset: 0x00013D65
		// (set) Token: 0x0600139E RID: 5022 RVA: 0x00015B6D File Offset: 0x00013D6D
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x1700079A RID: 1946
		// (get) Token: 0x0600139F RID: 5023 RVA: 0x00015B76 File Offset: 0x00013D76
		// (set) Token: 0x060013A0 RID: 5024 RVA: 0x00015B7E File Offset: 0x00013D7E
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
