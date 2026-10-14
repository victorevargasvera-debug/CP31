using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.Memory
{
	// Token: 0x02000244 RID: 580
	[global::System.Runtime.Serialization.DataContract]
	public class SamplingProfileNode : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x170006FC RID: 1788
		// (get) Token: 0x06001209 RID: 4617 RVA: 0x00013AA2 File Offset: 0x00011CA2
		// (set) Token: 0x0600120A RID: 4618 RVA: 0x00013AAA File Offset: 0x00011CAA
		[global::System.Runtime.Serialization.DataMember(Name = "size", IsRequired = true)]
		public double Size { get; set; }

		// Token: 0x170006FD RID: 1789
		// (get) Token: 0x0600120B RID: 4619 RVA: 0x00013AB3 File Offset: 0x00011CB3
		// (set) Token: 0x0600120C RID: 4620 RVA: 0x00013ABB File Offset: 0x00011CBB
		[global::System.Runtime.Serialization.DataMember(Name = "total", IsRequired = true)]
		public double Total { get; set; }

		// Token: 0x170006FE RID: 1790
		// (get) Token: 0x0600120D RID: 4621 RVA: 0x00013AC4 File Offset: 0x00011CC4
		// (set) Token: 0x0600120E RID: 4622 RVA: 0x00013ACC File Offset: 0x00011CCC
		[global::System.Runtime.Serialization.DataMember(Name = "stack", IsRequired = true)]
		public string[] Stack { get; set; }
	}
}
