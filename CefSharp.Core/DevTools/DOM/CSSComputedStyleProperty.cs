using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002BC RID: 700
	[global::System.Runtime.Serialization.DataContract]
	public class CSSComputedStyleProperty : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x1700086F RID: 2159
		// (get) Token: 0x060015A7 RID: 5543 RVA: 0x000179B9 File Offset: 0x00015BB9
		// (set) Token: 0x060015A8 RID: 5544 RVA: 0x000179C1 File Offset: 0x00015BC1
		[global::System.Runtime.Serialization.DataMember(Name = "name", IsRequired = true)]
		public string Name { get; set; }

		// Token: 0x17000870 RID: 2160
		// (get) Token: 0x060015A9 RID: 5545 RVA: 0x000179CA File Offset: 0x00015BCA
		// (set) Token: 0x060015AA RID: 5546 RVA: 0x000179D2 File Offset: 0x00015BD2
		[global::System.Runtime.Serialization.DataMember(Name = "value", IsRequired = true)]
		public string Value { get; set; }
	}
}
