using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.CSS
{
	// Token: 0x02000306 RID: 774
	[global::System.Runtime.Serialization.DataContract]
	public class MediaQueryExpression : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000936 RID: 2358
		// (get) Token: 0x060017B5 RID: 6069 RVA: 0x00019C85 File Offset: 0x00017E85
		// (set) Token: 0x060017B6 RID: 6070 RVA: 0x00019C8D File Offset: 0x00017E8D
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public double Value { get; set; }

		// Token: 0x17000937 RID: 2359
		// (get) Token: 0x060017B7 RID: 6071 RVA: 0x00019C96 File Offset: 0x00017E96
		// (set) Token: 0x060017B8 RID: 6072 RVA: 0x00019C9E File Offset: 0x00017E9E
		[global::System.Runtime.Serialization.DataMember(Name = "unit", IsRequired = true)]
		public string Unit { get; set; }

		// Token: 0x17000938 RID: 2360
		// (get) Token: 0x060017B9 RID: 6073 RVA: 0x00019CA7 File Offset: 0x00017EA7
		// (set) Token: 0x060017BA RID: 6074 RVA: 0x00019CAF File Offset: 0x00017EAF
		[global::System.Runtime.Serialization.DataMember(Name = "feature", IsRequired = true)]
		public string Feature { get; set; }

		// Token: 0x17000939 RID: 2361
		// (get) Token: 0x060017BB RID: 6075 RVA: 0x00019CB8 File Offset: 0x00017EB8
		// (set) Token: 0x060017BC RID: 6076 RVA: 0x00019CC0 File Offset: 0x00017EC0
		[global::System.Runtime.Serialization.DataMember(Name = "valueRange", IsRequired = false)]
		public global::CefSharp.DevTools.CSS.SourceRange ValueRange { get; set; }

		// Token: 0x1700093A RID: 2362
		// (get) Token: 0x060017BD RID: 6077 RVA: 0x00019CC9 File Offset: 0x00017EC9
		// (set) Token: 0x060017BE RID: 6078 RVA: 0x00019CD1 File Offset: 0x00017ED1
		[global::System.Runtime.Serialization.DataMember(Name = "computedLength", IsRequired = false)]
		public double? ComputedLength { get; set; }
	}
}
