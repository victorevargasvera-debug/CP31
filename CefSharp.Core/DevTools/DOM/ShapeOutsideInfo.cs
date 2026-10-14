using System;
using System.Runtime.Serialization;

namespace CefSharp.DevTools.DOM
{
	// Token: 0x020002BA RID: 698
	[global::System.Runtime.Serialization.DataContract]
	public class ShapeOutsideInfo : global::CefSharp.DevTools.DevToolsDomainEntityBase
	{
		// Token: 0x17000868 RID: 2152
		// (get) Token: 0x06001597 RID: 5527 RVA: 0x00017932 File Offset: 0x00015B32
		// (set) Token: 0x06001598 RID: 5528 RVA: 0x0001793A File Offset: 0x00015B3A
		[global::System.Runtime.Serialization.DataMember(Name = "bounds", IsRequired = true)]
		public double[] Bounds { get; set; }

		// Token: 0x17000869 RID: 2153
		// (get) Token: 0x06001599 RID: 5529 RVA: 0x00017943 File Offset: 0x00015B43
		// (set) Token: 0x0600159A RID: 5530 RVA: 0x0001794B File Offset: 0x00015B4B
		[global::System.Runtime.Serialization.DataMember(Name = "shape", IsRequired = true)]
		public object[] Shape { get; set; }

		// Token: 0x1700086A RID: 2154
		// (get) Token: 0x0600159B RID: 5531 RVA: 0x00017954 File Offset: 0x00015B54
		// (set) Token: 0x0600159C RID: 5532 RVA: 0x0001795C File Offset: 0x00015B5C
		[global::System.Runtime.Serialization.DataMember(Name = "marginShape", IsRequired = true)]
		public object[] MarginShape { get; set; }
	}
}
