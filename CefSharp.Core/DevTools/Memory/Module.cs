using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Memory
{
	// Token: 0x02000246 RID: 582
	[global::System.Runtime.Serialization.DataContract]
	public class Module : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000701 RID: 1793
		// (get) Token: 0x06001215 RID: 4629 RVA: 0x00013B07 File Offset: 0x00011D07
		// (set) Token: 0x06001216 RID: 4630 RVA: 0x00013B0F File Offset: 0x00011D0F
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000702 RID: 1794
		// (get) Token: 0x06001217 RID: 4631 RVA: 0x00013B18 File Offset: 0x00011D18
		// (set) Token: 0x06001218 RID: 4632 RVA: 0x00013B20 File Offset: 0x00011D20
		[global::System.Runtime.Serialization.DataMember(Name = "uuid", IsRequired = true)]
		public string Uuid { get; set; }

		// Token: 0x17000703 RID: 1795
		// (get) Token: 0x06001219 RID: 4633 RVA: 0x00013B29 File Offset: 0x00011D29
		// (set) Token: 0x0600121A RID: 4634 RVA: 0x00013B31 File Offset: 0x00011D31
		[global::System.Runtime.Serialization.DataMember(Name = "baseAddress", IsRequired = true)]
		public string BaseAddress { get; set; }

		// Token: 0x17000704 RID: 1796
		// (get) Token: 0x0600121B RID: 4635 RVA: 0x00013B3A File Offset: 0x00011D3A
		// (set) Token: 0x0600121C RID: 4636 RVA: 0x00013B42 File Offset: 0x00011D42
		[global::System.Runtime.Serialization.DataMember(Name = "size", IsRequired = true)]
		public double Size { get; set; }
	}
}
