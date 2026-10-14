using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x0200030D RID: 781
	[global::System.Runtime.Serialization.DataContract]
	public class FontVariationAxis : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000953 RID: 2387
		// (get) Token: 0x060017F6 RID: 6134 RVA: 0x00019EE6 File Offset: 0x000180E6
		// (set) Token: 0x060017F7 RID: 6135 RVA: 0x00019EEE File Offset: 0x000180EE
		[global::System.Runtime.Serialization.DataMember(Name = "tag", IsRequired = true)]
		public string Tag { get; set; }

		// Token: 0x17000954 RID: 2388
		// (get) Token: 0x060017F8 RID: 6136 RVA: 0x00019EF7 File Offset: 0x000180F7
		// (set) Token: 0x060017F9 RID: 6137 RVA: 0x00019EFF File Offset: 0x000180FF
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000955 RID: 2389
		// (get) Token: 0x060017FA RID: 6138 RVA: 0x00019F08 File Offset: 0x00018108
		// (set) Token: 0x060017FB RID: 6139 RVA: 0x00019F10 File Offset: 0x00018110
		[global::System.Runtime.Serialization.DataMember(Name = "minValue", IsRequired = true)]
		public double MinValue { get; set; }

		// Token: 0x17000956 RID: 2390
		// (get) Token: 0x060017FC RID: 6140 RVA: 0x00019F19 File Offset: 0x00018119
		// (set) Token: 0x060017FD RID: 6141 RVA: 0x00019F21 File Offset: 0x00018121
		[global::System.Runtime.Serialization.DataMember(Name = "maxValue", IsRequired = true)]
		public double MaxValue { get; set; }

		// Token: 0x17000957 RID: 2391
		// (get) Token: 0x060017FE RID: 6142 RVA: 0x00019F2A File Offset: 0x0001812A
		// (set) Token: 0x060017FF RID: 6143 RVA: 0x00019F32 File Offset: 0x00018132
		[global::System.Runtime.Serialization.DataMember(Name = "defaultValue", IsRequired = true)]
		public double DefaultValue { get; set; }
	}
}
